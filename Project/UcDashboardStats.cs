using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class UcDashboardStats : UserControl
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public UcDashboardStats()
        {
            InitializeComponent();
            LoadDashboardStats();
        }

        public void LoadDashboardStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // ✅ Available Rooms
                    string roomQuery = "SELECT COUNT(*) FROM Rooms WHERE Status = 'Available'";
                    using (SqlCommand cmd = new SqlCommand(roomQuery, conn))
                    {
                        int availableRooms = (int)cmd.ExecuteScalar();
                        lblVacant.Text = availableRooms.ToString();
                    }

                    // ✅ Total Profit
                    string profitQuery = "SELECT SUM(TotalAmount) FROM Invoices";
                    using (SqlCommand cmd = new SqlCommand(profitQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        lblProfit.Text = result != DBNull.Value ? Convert.ToDecimal(result).ToString("C") : "₱0.00";
                    }

                    // ✅ Total Clients
                    string clientQuery = "SELECT COUNT(DISTINCT GuestID) FROM Bookings";
                    using (SqlCommand cmd = new SqlCommand(clientQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        lblClient.Text = result != DBNull.Value ? result.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message);
            }
        }
    }
}
