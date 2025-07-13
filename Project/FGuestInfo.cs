using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class FGuestInfo : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public FGuestInfo()
        {
            InitializeComponent();
            this.Shown += (s, e) => CenterGuestPanel();
            this.Resize += (s, e) => CenterGuestPanel();
        }

        private void FGuestInfo_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadGuestData();
            LoadGuestIDsToComboBox();
        }

        private void CenterGuestPanel()
        {
            if (panelGuestInfo != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                panelGuestInfo.Left = (this.ClientSize.Width - panelGuestInfo.Width) / 2;
                panelGuestInfo.Top = (this.ClientSize.Height - panelGuestInfo.Height) / 2;
            }
        }

        private void LoadGuestData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Guests", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvGuestInfo.DataSource = dt;
                    dgvGuestInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guests: " + ex.Message);
                }
            }
        }

        private void btnAddGuest_Click(object sender, EventArgs e)
        {
            string name = txtGuestName.Text.Trim();
            string contact = txtContact.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = richtxtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(contact))
            {
                MessageBox.Show("Please enter guest name and contact.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Guests (GuestName, Contact, Email, Address) VALUES (@name, @contact, @email, @address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@contact", contact);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@address", address);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guest added successfully.");

                    txtGuestName.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    richtxtAddress.Clear();

                    LoadGuestData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert error: " + ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadGuestData();
        }

        // Unused event handlers (optional to keep or remove)
        private void dgvGuestInfo_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void richtxtAddress_TextChanged(object sender, EventArgs e) { }
        private void txtEmail_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged_1(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void panelGuestInfo_Paint(object sender, PaintEventArgs e) { }

        private void btnDeleteGuest_Click(object sender, EventArgs e)
        {
            if (cmbDeleteGuestID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Guest ID to delete.");
                return;
            }

            int selectedGuestID = Convert.ToInt32(cmbDeleteGuestID.SelectedValue);

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Delete related invoices
                    string deleteInvoicesQuery = @"
                DELETE FROM Invoices
                WHERE BookingID IN (
                    SELECT BookingID FROM Bookings WHERE GuestID = @GuestID
                )";
                    using (SqlCommand deleteInvoicesCmd = new SqlCommand(deleteInvoicesQuery, conn))
                    {
                        deleteInvoicesCmd.Parameters.AddWithValue("@GuestID", selectedGuestID);
                        deleteInvoicesCmd.ExecuteNonQuery();
                    }

                    // Step 2: Delete bookings of the guest
                    string deleteBookingsQuery = "DELETE FROM Bookings WHERE GuestID = @GuestID";
                    using (SqlCommand deleteBookingsCmd = new SqlCommand(deleteBookingsQuery, conn))
                    {
                        deleteBookingsCmd.Parameters.AddWithValue("@GuestID", selectedGuestID);
                        deleteBookingsCmd.ExecuteNonQuery();
                    }

                    // Step 3: Delete guest record
                    string deleteGuestQuery = "DELETE FROM Guests WHERE GuestID = @GuestID";
                    using (SqlCommand deleteGuestCmd = new SqlCommand(deleteGuestQuery, conn))
                    {
                        deleteGuestCmd.Parameters.AddWithValue("@GuestID", selectedGuestID);
                        int rowsAffected = deleteGuestCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Guest deleted successfully.");
                            LoadGuestData();
                            LoadGuestIDsToComboBox();
                        }
                        else
                        {
                            MessageBox.Show("Guest not found or could not be deleted.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }


        private void LoadGuestIDsToComboBox()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT GuestID FROM Guests", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    cmbDeleteGuestID.DisplayMember = "GuestID";
                    cmbDeleteGuestID.ValueMember = "GuestID";
                    cmbDeleteGuestID.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading guest IDs: " + ex.Message);
                }
            }
        }
    }
}

