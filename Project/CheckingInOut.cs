using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class CheckingInOut : Form
    {
        private int bookingID;
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public CheckingInOut(int bookingId, string guestName, string roomType, DateTime checkIn, DateTime checkOut, string status)
        {
            InitializeComponent();
            bookingID = bookingId;

            lblGuestName.Text = guestName;
            lblRoomType.Text = roomType;
            lblCheckInDate.Text = checkIn.ToShortDateString();
            lblCheckOutDate.Text = checkOut.ToShortDateString();
            lblBookingStatus.Text = status;

            // Enable correct radio button depending on status
            if (status == "Pending")
            {
                rbtnCheckIn.Enabled = true;
                rbtnCheckOut.Enabled = false;
                rbtnCheckIn.Checked = true;
            }
            else if (status == "Checked-In")
            {
                rbtnCheckIn.Enabled = false;
                rbtnCheckOut.Enabled = true;
                rbtnCheckOut.Checked = true;
            }
            else
            {
                rbtnCheckIn.Enabled = false;
                rbtnCheckOut.Enabled = false;
                lblStatus.Text = "This booking is already completed.";
                btnConfirm.Enabled = false;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newStatus = rbtnCheckIn.Checked ? "Checked-In" : "Checked-Out";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "UPDATE Bookings SET Status = @Status WHERE BookingID = @BookingID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@BookingID", bookingID);
                    cmd.ExecuteNonQuery();

                    int roomId = 0;
                    SqlCommand getRoomIdCmd = new SqlCommand("SELECT RoomID FROM Bookings WHERE BookingID = @BookingID", conn);
                    getRoomIdCmd.Parameters.AddWithValue("@BookingID", bookingID);
                    roomId = Convert.ToInt32(getRoomIdCmd.ExecuteScalar());

                    if (newStatus == "Checked-Out")
                    {
                        SqlCommand updateRoomCmd = new SqlCommand("UPDATE Rooms SET Status = 'Available' WHERE RoomID = @RoomID", conn);
                        updateRoomCmd.Parameters.AddWithValue("@RoomID", roomId);
                        updateRoomCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Booking successfully {newStatus.ToLower()}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // ✅ Open billing invoice form after successful check-out
                    if (newStatus == "Checked-Out")
                    {
                        // Get required data for invoice
                        SqlCommand detailsCmd = new SqlCommand(@"
                    SELECT g.GuestName, r.RoomType, r.Price, b.CheckIn, b.CheckOut
                    FROM Bookings b
                    JOIN Guests g ON b.GuestID = g.GuestID
                    JOIN Rooms r ON b.RoomID = r.RoomID
                    WHERE b.BookingID = @BookingID", conn);
                        detailsCmd.Parameters.AddWithValue("@BookingID", bookingID);

                        using (SqlDataReader reader = detailsCmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string guestName = reader["GuestName"].ToString();
                                string roomType = reader["RoomType"].ToString();
                                decimal roomRate = Convert.ToDecimal(reader["Price"]);
                                DateTime checkIn = Convert.ToDateTime(reader["CheckIn"]);
                                DateTime checkOut = Convert.ToDateTime(reader["CheckOut"]);

                                // 🧾 Show the billing invoice
                                FbillingInvoice invoice = new FbillingInvoice(bookingID, guestName, roomType, roomRate, checkIn, checkOut);
                                invoice.ShowDialog();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtnCheckOut_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
