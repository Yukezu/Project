using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            bookingContainer.Height = 70;
            bookingContainer.AutoSize = false;

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            BackColor = Color.Snow;
            SetMdiClientBackColor(Color.Snow);
            LoadDashboardStats();
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\L\Project\Project\App_Data\Database1.mdf;Integrated Security=True";

        }
        public void LoadUserControl(UserControl control)
        {
            mainContainer.Controls.Clear();
            control.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(control);
            control.BringToFront();
        }

        public void LoadDashboardStats()
        {
            LoadUserControl(new UcDashboardStats());
        }



        private void SetMdiClientBackColor(Color color)
        {
            foreach (Control ctl in Controls)
            {
                if (ctl is MdiClient mdiClient)
                {
                    mdiClient.BackColor = color;
                    break;
                }
            }
        }

        private void LoadForm(Form form)
        {
            mainContainer.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainContainer.Controls.Add(form);
            form.Show();
        }


        private void btnRoomSelect_Click(object sender, EventArgs e)
        {
            var form = new fRoomSelect();


            LoadForm(form); ;
        }


        private void BtnGuestInfo_Click(object sender, EventArgs e)
        {
            LoadForm(new FGuestInfo());
        }

        private void ViewBookings_Click(object sender, EventArgs e)
        {
            LoadForm(new fViewBookings());
        }

        private void CheckInOut_Click(object sender, EventArgs e)
        {
            int bookingId = 123;
            string guestName = "John Doe";
            string roomType = "Deluxe";
            DateTime checkInDate = DateTime.Now;
            DateTime checkOutDate = DateTime.Now.AddDays(1);
            string bookingStatus = "Confirmed";
            LoadForm(new CheckingInOut(bookingId, guestName, roomType, checkInDate, checkOutDate, bookingStatus));
        }

        private void Billing_Click(object sender, EventArgs e)
        {
            int bookingId = 123; // Replace with actual booking ID
            string guestName = "John Doe"; // Replace with actual guest name
            string roomType = "Deluxe"; // Replace with actual room type
            decimal roomRate = 150.00m; // Replace with actual room rate
            DateTime checkInDate = DateTime.Now; // Replace with actual check-in date
            DateTime checkOutDate = DateTime.Now.AddDays(1); // Replace with actual check-out date

            LoadForm(new FbillingInvoice(bookingId, guestName, roomType, roomRate, checkInDate, checkOutDate));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new Form1().Show();
        }

        private void btnNbooking_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        bool isExpanded = false;


        private void timer1_Tick(object sender, EventArgs e)
        {
            int expandedHeight = 232;
            int collapsedHeight = 70;
            int step = 10;

            if (!isExpanded)
            {
                bookingContainer.Height += step;
                if (bookingContainer.Height >= expandedHeight)
                {
                    bookingContainer.Height = expandedHeight;
                    isExpanded = true;
                    timer1.Stop();
                }
            }
            else
            {
                bookingContainer.Height -= step;
                if (bookingContainer.Height <= collapsedHeight)
                {
                    bookingContainer.Height = collapsedHeight;
                    isExpanded = false;
                    timer1.Stop();
                }
            }
        }
        private void btnHamburger_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        bool isSidebarExpanded = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            int step = 10;

            if (isSidebarExpanded)
            {
                panelSidebar.Width -= step;
                if (panelSidebar.Width <= 65)
                {
                    sidebarTransition.Stop();
                    isSidebarExpanded = false; // collapsed
                }
            }
            else
            {
                panelSidebar.Width += step;
                if (panelSidebar.Width >= 240)
                {
                    sidebarTransition.Stop();
                    isSidebarExpanded = true; // expanded
                }
            }
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            LoadForm(new Fbooking());
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblProfit_Click(object sender, EventArgs e)
        {

        }

        private void lblVacant_Click(object sender, EventArgs e)
        {

        }

        private void lblClient_Click(object sender, EventArgs e)
        {

        }

        private void mainContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStats();
        }
    }
}
