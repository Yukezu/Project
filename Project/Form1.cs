using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool ISvalid()
        {
            if (txtUserName.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter Valid User Name", "error");
                return false;

            }
            else if (txtPassword.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("enter Valid Password", "error");
                return false;
            }
            return true;
        }

        [Obsolete]
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            if (!ISvalid())
                return;

            string dbPath = Path.Combine(Application.StartupPath, "C:\\L\\Project\\Project\\App_Data\\Database1.mdf");
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + dbPath + ";Integrated Security=True;";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM LOGIN WHERE username = @username AND password = @password";
                    SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                    sda.SelectCommand.Parameters.AddWithValue("@username", txtUserName.Text.Trim());
                    sda.SelectCommand.Parameters.AddWithValue("@password", txtPassword.Text.Trim());

                    DataTable dta = new DataTable();
                    sda.Fill(dta);

                    if (dta.Rows.Count == 1)
                    {
                        Dashboard dashboard = new Dashboard();
                        this.Hide();
                        dashboard.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password", "Login Failed");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Forg_Click(object sender, EventArgs e)
        {
            ForgotPassword forgot = new ForgotPassword();
            forgot.ShowDialog();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Focus();
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0'; 
            }
            else
            {
                txtPassword.PasswordChar = '*'; 
            }
        }
    }
}
