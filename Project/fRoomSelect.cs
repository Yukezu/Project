using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class fRoomSelect : Form
    {
        string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        public fRoomSelect()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.Shown += (s, e) => CenterSelectionPanel();
            this.Resize += (s, e) => CenterSelectionPanel();
        }

        private void fRoomSelect_Load(object sender, EventArgs e)
        {
            txtSearch.Text = "Search room...";
            txtSearch.ForeColor = Color.Gray;
            LoadRoomData();
            LoadRoomIDsToComboBox();
            LoadRoomIDsToUpdateComboBox();
            groupBoxAddRoom.Visible = false;
        }

        private void CenterSelectionPanel()
        {
            if (panelChangeDate != null && this.ClientSize.Width > 0 && this.ClientSize.Height > 0)
            {
                int offsetX = 10;
                panelChangeDate.Left = (this.ClientSize.Width - panelChangeDate.Width) / 2 + offsetX;
                panelChangeDate.Top = (this.ClientSize.Height - panelChangeDate.Height) / 2;
            }
        }

        private void LoadRoomData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoomID, RoomType, Price, Status FROM Rooms", conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRooms.DataSource = dt;
                    dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading rooms: " + ex.Message);
                }
            }
        }
        private void LoadRoomIDsToUpdateComboBox()
        {
            cmbRoomIDUpdate.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT RoomID FROM Rooms", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbRoomIDUpdate.Items.Add(reader["RoomID"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Room IDs for update: " + ex.Message);
                }
            }
        }


        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "Search room...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search room...";
                txtSearch.ForeColor = Color.Gray;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT RoomID, RoomType, Price, Status FROM Rooms WHERE RoomType LIKE @search OR Status LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + searchText + "%");

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvRooms.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Search error: " + ex.Message);
                }
            }
        }
        private void cmbRoomIDUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoomIDUpdate.SelectedItem == null)
                return;

            int selectedRoomID = Convert.ToInt32(cmbRoomIDUpdate.SelectedItem);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT RoomType, Price, Status FROM Rooms WHERE RoomID = @RoomID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", selectedRoomID);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            cmbRoomType.Text = reader["RoomType"].ToString();
                            txtPrice.Text = reader["Price"].ToString();
                            cmbStatus.Text = reader["Status"].ToString();

                            groupBoxAddRoom.Visible = true; // auto show
                        }

                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading room details: " + ex.Message);
                }
            }
        }


        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            groupBoxAddRoom.Visible = !groupBoxAddRoom.Visible;

            if (groupBoxAddRoom.Visible)
            {
                cmbStatus.SelectedIndex = -1;
                cmbRoomType.SelectedIndex = -1;
                txtPrice.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string roomType = cmbRoomType.Text;
            string priceText = txtPrice.Text;
            string status = cmbStatus.Text;

            if (string.IsNullOrWhiteSpace(roomType) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Price must be a number.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Rooms (RoomType, Price, Status) VALUES (@RoomType, @Price, @Status)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Room added successfully.");
                            LoadRoomData();
                            LoadRoomIDsToComboBox();
                            cmbRoomType.SelectedIndex = -1;
                            cmbStatus.SelectedIndex = -1;
                            txtPrice.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Failed to add room.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDeleteRoomID.SelectedItem == null)
            {
                MessageBox.Show("Please select a Room ID to delete.", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int roomId = Convert.ToInt32(cmbDeleteRoomID.SelectedItem);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Rooms WHERE RoomID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomID", roomId);

                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Room deleted successfully.");
                            LoadRoomData();
                            LoadRoomIDsToComboBox();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete room.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void LoadRoomIDsToComboBox()
        {
            cmbDeleteRoomID.Items.Clear();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT RoomID FROM Rooms", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbDeleteRoomID.Items.Add(reader["RoomID"].ToString());
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Room IDs: " + ex.Message);
                }
            }
        }

        private void cmbDeleteRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (cmbRoomIDUpdate.SelectedItem == null)
            {
                MessageBox.Show("Select a Room ID to update.");
                return;
            }

            string roomType = cmbRoomType.Text;
            string priceText = txtPrice.Text;
            string status = cmbStatus.Text;

            if (string.IsNullOrWhiteSpace(roomType) || string.IsNullOrWhiteSpace(priceText) || string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("All fields must be filled.");
                return;
            }

            if (!decimal.TryParse(priceText, out decimal price))
            {
                MessageBox.Show("Invalid price.");
                return;
            }

            int roomId = Convert.ToInt32(cmbRoomIDUpdate.SelectedItem);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Rooms SET RoomType = @RoomType, Price = @Price, Status = @Status WHERE RoomID = @RoomID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.Parameters.AddWithValue("@Price", price);
                        cmd.Parameters.AddWithValue("@Status", status);
                        cmd.Parameters.AddWithValue("@RoomID", roomId);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Room updated successfully.");
                            LoadRoomData();
                            LoadRoomIDsToUpdateComboBox();

                            cmbRoomIDUpdate.SelectedIndex = -1;
                            cmbRoomType.SelectedIndex = -1;
                            cmbStatus.SelectedIndex = -1;
                            txtPrice.Text = "";
                            groupBoxAddRoom.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Update failed.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
