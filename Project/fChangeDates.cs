using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class fChangeDates : Form
    {
        private int bookingID;
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public fChangeDates(int bookingID)
        {
            InitializeComponent();
            this.bookingID = bookingID;
            LoadBookingInfo(); // Load guest + room info and old dates
        }

        private void LoadBookingInfo()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT g.GuestName, r.RoomType, b.CheckIn, b.CheckOut
                                 FROM Bookings b
                                 JOIN Guests g ON b.GuestID = g.GuestID
                                 JOIN Rooms r ON b.RoomID = r.RoomID
                                 WHERE b.BookingID = @BookingID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@BookingID", bookingID);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    lblBookingInfo.Text = $"👤 {reader["GuestName"]} | 🛏 {reader["RoomType"]}";
                    dtpCheckIn.Value = Convert.ToDateTime(reader["CheckIn"]);
                    dtpCheckOut.Value = Convert.ToDateTime(reader["CheckOut"]);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dtpCheckIn.Value >= dtpCheckOut.Value)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Bookings SET CheckIn = @CheckIn, CheckOut = @CheckOut WHERE BookingID = @BookingID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CheckIn", dtpCheckIn.Value.Date);
                cmd.Parameters.AddWithValue("@CheckOut", dtpCheckOut.Value.Date);
                cmd.Parameters.AddWithValue("@BookingID", bookingID);

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("✅ Booking dates updated successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("❌ Failed to update booking.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
