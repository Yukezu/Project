using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class fViewBookings : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public fViewBookings()
        {
            InitializeComponent();
        }

        private void fViewBookings_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CenterViewBookingPanel();
            LoadBookings();
            txtSearchGuest.Text = "Search guest...";
            txtSearchGuest.ForeColor = Color.Gray;
        }

        private void fViewBookings_Resize(object sender, EventArgs e)
        {
            CenterViewBookingPanel();
        }

        private void CenterViewBookingPanel()
        {
            if (panelViewBooking != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                int offsetX = 10;
                panelViewBooking.Left = (this.ClientSize.Width - panelViewBooking.Width) / 2 + offsetX;
                panelViewBooking.Top = (this.ClientSize.Height - panelViewBooking.Height) / 2;
            }
        }

        private void LoadBookings(string guestSearch = "", string statusFilter = "All")
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = @"
                    SELECT b.BookingID, g.GuestName, r.RoomType, b.CheckIn, b.CheckOut, b.Status
                    FROM Bookings b
                    JOIN Guests g ON b.GuestID = g.GuestID
                    JOIN Rooms r ON b.RoomID = r.RoomID
                    WHERE (@guestSearch = '' OR g.GuestName LIKE @guestSearch)";

                if (statusFilter == "Upcoming")
                    query += " AND b.CheckIn > GETDATE()";
                else if (statusFilter == "Ongoing")
                    query += " AND GETDATE() BETWEEN b.CheckIn AND b.CheckOut";
                else if (statusFilter == "Past")
                    query += " AND b.CheckOut < GETDATE()";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@guestSearch", "%" + guestSearch + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvViewBooking.DataSource = dt;

                if (dgvViewBooking.Columns.Contains("BookingID"))
                    dgvViewBooking.Columns["BookingID"].HeaderText = "Booking ID";
                if (dgvViewBooking.Columns.Contains("GuestName"))
                    dgvViewBooking.Columns["GuestName"].HeaderText = "Guest Name";
                if (dgvViewBooking.Columns.Contains("RoomType"))
                    dgvViewBooking.Columns["RoomType"].HeaderText = "Room Type";
                if (dgvViewBooking.Columns.Contains("CheckIn"))
                    dgvViewBooking.Columns["CheckIn"].HeaderText = "Check-In";
                if (dgvViewBooking.Columns.Contains("CheckOut"))
                    dgvViewBooking.Columns["CheckOut"].HeaderText = "Check-Out";
                if (dgvViewBooking.Columns.Contains("Status"))
                    dgvViewBooking.Columns["Status"].HeaderText = "Booking Status";
            }
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            LoadBookings(txtSearchGuest.Text.Trim());
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string guestSearch = txtSearchGuest.Text == "Search guest..." ? "" : txtSearchGuest.Text.Trim();
            string status = cmbFilter.SelectedItem.ToString();
            LoadBookings(guestSearch, status);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchGuest.Text = "Search guest...";
            cmbFilter.SelectedIndex = 0;
            LoadBookings();
        }

        private void btnCancelBookings_Click(object sender, EventArgs e)
        {
            if (dgvViewBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvViewBooking.SelectedRows[0].Cells["BookingID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        SqlCommand cmdRoom = new SqlCommand(
                            @"UPDATE Rooms SET Status = 'Available' 
                              WHERE RoomID = (SELECT RoomID FROM Bookings WHERE BookingID = @BookingID)",
                            conn, transaction);
                        cmdRoom.Parameters.AddWithValue("@BookingID", bookingID);
                        cmdRoom.ExecuteNonQuery();

                        SqlCommand cmdDelete = new SqlCommand(
                            "DELETE FROM Bookings WHERE BookingID = @BookingID",
                            conn, transaction);
                        cmdDelete.Parameters.AddWithValue("@BookingID", bookingID);
                        cmdDelete.ExecuteNonQuery();

                        transaction.Commit();
                        MessageBox.Show("Booking canceled successfully.");
                        LoadBookings();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error canceling booking: " + ex.Message);
                    }
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (dgvViewBooking.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to change.");
                return;
            }

            int bookingID = Convert.ToInt32(dgvViewBooking.SelectedRows[0].Cells["BookingID"].Value);

            fChangeDates changeForm = new fChangeDates(bookingID);
            changeForm.ShowDialog();
            LoadBookings();
        }

        private void txtSearchGuest_Enter(object sender, EventArgs e)
        {
            if (txtSearchGuest.Text == "Search guest...")
            {
                txtSearchGuest.Text = "";
                txtSearchGuest.ForeColor = Color.Black;
            }
        }

        private void txtSearchGuest_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchGuest.Text))
            {
                txtSearchGuest.Text = "Search guest...";
                txtSearchGuest.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvViewBooking.SelectedRows.Count > 0)
            {
                int bookingId = Convert.ToInt32(dgvViewBooking.SelectedRows[0].Cells["BookingID"].Value);
                string guestName = dgvViewBooking.SelectedRows[0].Cells["GuestName"].Value.ToString();
                string roomType = dgvViewBooking.SelectedRows[0].Cells["RoomType"].Value.ToString();
                DateTime checkIn = Convert.ToDateTime(dgvViewBooking.SelectedRows[0].Cells["CheckIn"].Value);
                DateTime checkOut = Convert.ToDateTime(dgvViewBooking.SelectedRows[0].Cells["CheckOut"].Value);
                string status = dgvViewBooking.SelectedRows[0].Cells["Status"].Value.ToString(); // now safe

                CheckingInOut checkForm = new CheckingInOut(bookingId, guestName, roomType, checkIn, checkOut, status);
                checkForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a booking first.");
            }
        }

        private void dgvViewBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
