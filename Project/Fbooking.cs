using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Fbooking : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public Fbooking()
        {
            InitializeComponent();
            this.Shown += (s, e) => CenterBookingPanel();
            this.Resize += (s, e) => CenterBookingPanel();
        }

        private void Fbooking_Load(object sender, EventArgs e)
        {
            CenterBookingPanel();
            LoadGuests();
            LoadAvailableRooms();
            LoadCurrentBookings();
        }

        private void CenterBookingPanel()
        {
            if (BookingPanel != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                int offsetX = 10; // optional shift to the right
                BookingPanel.Left = (this.ClientSize.Width - BookingPanel.Width) / 2 + offsetX;
                BookingPanel.Top = (this.ClientSize.Height - BookingPanel.Height) / 2;
            }
        }

        private void LoadGuests()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(
                        "SELECT GuestID, GuestName AS FullName FROM Guests", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbGuest.DataSource = dt;
                    cmbGuest.DisplayMember = "FullName";
                    cmbGuest.ValueMember = "GuestID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guests: " + ex.Message);
                }
            }
        }



        private void LoadAvailableRooms()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomID, RoomType FROM Rooms WHERE Status = 'Available'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                cmbRoom.DataSource = dt;
                cmbRoom.DisplayMember = "RoomType";
                cmbRoom.ValueMember = "RoomID";
                cmbRoom.SelectedIndex = -1;
            }
        }

        private void LoadCurrentBookings()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT b.BookingID, g.GuestName AS FullName, r.RoomType, b.CheckIn, b.CheckOut
                         FROM Bookings b
                         JOIN Guests g ON b.GuestID = g.GuestID
                         JOIN Rooms r ON b.RoomID = r.RoomID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvCurrentBookings.DataSource = dt;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbGuest.SelectedIndex == -1 || cmbRoom.SelectedIndex == -1)
            {
                MessageBox.Show("Please select both guest and room.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Check-out must be after check-in.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int guestID = (int)cmbGuest.SelectedValue;
            int roomID = (int)cmbRoom.SelectedValue;
            DateTime checkIn = dtpCheckIn.Value.Date;
            DateTime checkOut = dtpCheckOut.Value.Date;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string insertBooking = @"INSERT INTO Bookings (GuestID, RoomID, CheckIn, CheckOut)
                                             VALUES (@GuestID, @RoomID, @CheckIn, @CheckOut)";
                    SqlCommand cmd = new SqlCommand(insertBooking, conn, transaction);
                    cmd.Parameters.AddWithValue("@GuestID", guestID);
                    cmd.Parameters.AddWithValue("@RoomID", roomID);
                    cmd.Parameters.AddWithValue("@CheckIn", checkIn);
                    cmd.Parameters.AddWithValue("@CheckOut", checkOut);
                    cmd.ExecuteNonQuery();

                    string updateRoom = "UPDATE Rooms SET Status = 'Occupied' WHERE RoomID = @RoomID";
                    SqlCommand cmd2 = new SqlCommand(updateRoom, conn, transaction);
                    cmd2.Parameters.AddWithValue("@RoomID", roomID);
                    cmd2.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Booking saved successfully.");

                    LoadAvailableRooms();
                    LoadCurrentBookings();

                    cmbGuest.SelectedIndex = -1;
                    cmbRoom.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error saving booking: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); // or Hide();
        }
    }
}
