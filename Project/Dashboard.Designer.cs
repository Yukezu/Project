namespace Project
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
           
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            bookingContainer = new FlowLayoutPanel();
            btnNbooking = new Button();
            btnRoomSelect = new Button();
            BtnGuestInfo = new Button();
            btnDashboard = new Button();
            btnBooking = new Button();
            ViewBookings = new Button();
            button1 = new Button();
            upPanel = new Panel();
            label1 = new Label();
            btnHamburger = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainContainer = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lblClient = new Label();
            panel3 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            lblVacant = new Label();
            panel4 = new Panel();
            label4 = new Label();
            lblProfit = new Label();
            panel5 = new Panel();
            panelSidebar = new FlowLayoutPanel();
            panelSidebar.SuspendLayout();
            bookingContainer.SuspendLayout();
            upPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHamburger).BeginInit();
            mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(23, 24, 29);
            panelSidebar.Controls.Add(bookingContainer);
            panelSidebar.Controls.Add(btnDashboard);
            panelSidebar.Controls.Add(btnBooking);
            panelSidebar.Controls.Add(ViewBookings);
            panelSidebar.Controls.Add(button1);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 60);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(240, 566);
            panelSidebar.TabIndex = 8;
            // 
            // bookingContainer
            // 
            bookingContainer.Controls.Add(btnNbooking);
            bookingContainer.Controls.Add(btnRoomSelect);
            bookingContainer.Controls.Add(BtnGuestInfo);
            bookingContainer.FlowDirection = FlowDirection.TopDown;
            bookingContainer.Location = new Point(0, 3);
            bookingContainer.Margin = new Padding(0, 3, 3, 3);
            bookingContainer.Name = "bookingContainer";
            bookingContainer.Size = new Size(248, 74);
            bookingContainer.TabIndex = 4;
            // 
            // btnNbooking
            // 
            btnNbooking.BackColor = Color.FromArgb(23, 24, 29);
            btnNbooking.FlatAppearance.BorderSize = 0;
            btnNbooking.FlatStyle = FlatStyle.Flat;
            btnNbooking.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNbooking.ForeColor = Color.White;
            btnNbooking.Image = (Image)resources.GetObject("btnNbooking.Image");
            btnNbooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnNbooking.Location = new Point(0, 0);
            btnNbooking.Margin = new Padding(0, 0, 3, 3);
            btnNbooking.Name = "btnNbooking";
            btnNbooking.Padding = new Padding(15, 0, 0, 0);
            btnNbooking.Size = new Size(247, 70);
            btnNbooking.TabIndex = 1;
            btnNbooking.Text = "Room / Guest";
            btnNbooking.UseVisualStyleBackColor = false;
            btnNbooking.Click += btnNbooking_Click;
            // 
            // btnRoomSelect
            // 
            btnRoomSelect.BackColor = Color.FromArgb(23, 24, 29);
            btnRoomSelect.FlatAppearance.BorderSize = 0;
            btnRoomSelect.FlatStyle = FlatStyle.Flat;
            btnRoomSelect.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoomSelect.ForeColor = Color.White;
            btnRoomSelect.Image = (Image)resources.GetObject("btnRoomSelect.Image");
            btnRoomSelect.ImageAlign = ContentAlignment.MiddleLeft;
            btnRoomSelect.Location = new Point(253, 3);
            btnRoomSelect.Name = "btnRoomSelect";
            btnRoomSelect.Padding = new Padding(20, 0, 0, 0);
            btnRoomSelect.Size = new Size(245, 70);
            btnRoomSelect.TabIndex = 3;
            btnRoomSelect.Text = "Room Select";
            btnRoomSelect.UseVisualStyleBackColor = false;
            btnRoomSelect.Click += btnRoomSelect_Click;
            // 
            // BtnGuestInfo
            // 
            BtnGuestInfo.BackColor = Color.FromArgb(23, 24, 29);
            BtnGuestInfo.FlatAppearance.BorderSize = 0;
            BtnGuestInfo.FlatStyle = FlatStyle.Flat;
            BtnGuestInfo.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnGuestInfo.ForeColor = Color.White;
            BtnGuestInfo.Image = (Image)resources.GetObject("BtnGuestInfo.Image");
            BtnGuestInfo.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuestInfo.Location = new Point(504, 3);
            BtnGuestInfo.Name = "BtnGuestInfo";
            BtnGuestInfo.Padding = new Padding(20, 0, 0, 0);
            BtnGuestInfo.Size = new Size(245, 70);
            BtnGuestInfo.TabIndex = 2;
            BtnGuestInfo.Text = "Guest Info";
            BtnGuestInfo.UseVisualStyleBackColor = false;
            BtnGuestInfo.Click += BtnGuestInfo_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(23, 24, 29);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Image = (Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 83);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(13, 0, 3, 0);
            btnDashboard.Size = new Size(244, 70);
            btnDashboard.TabIndex = 9;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnBooking
            // 
            btnBooking.BackColor = Color.FromArgb(23, 24, 29);
            btnBooking.FlatAppearance.BorderSize = 0;
            btnBooking.FlatStyle = FlatStyle.Flat;
            btnBooking.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBooking.ForeColor = Color.White;
            btnBooking.Image = (Image)resources.GetObject("btnBooking.Image");
            btnBooking.ImageAlign = ContentAlignment.MiddleLeft;
            btnBooking.Location = new Point(3, 159);
            btnBooking.Name = "btnBooking";
            btnBooking.Padding = new Padding(19, 0, 3, 0);
            btnBooking.Size = new Size(244, 70);
            btnBooking.TabIndex = 8;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = false;
            btnBooking.Click += btnBooking_Click;
            // 
            // ViewBookings
            // 
            ViewBookings.BackColor = Color.FromArgb(23, 24, 29);
            ViewBookings.FlatAppearance.BorderSize = 0;
            ViewBookings.FlatStyle = FlatStyle.Flat;
            ViewBookings.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ViewBookings.ForeColor = Color.White;
            ViewBookings.Image = (Image)resources.GetObject("ViewBookings.Image");
            ViewBookings.ImageAlign = ContentAlignment.MiddleLeft;
            ViewBookings.Location = new Point(3, 235);
            ViewBookings.Name = "ViewBookings";
            ViewBookings.Padding = new Padding(5, 0, 0, 0);
            ViewBookings.Size = new Size(244, 70);
            ViewBookings.TabIndex = 2;
            ViewBookings.Text = "View Bookings";
            ViewBookings.UseVisualStyleBackColor = false;
            ViewBookings.Click += ViewBookings_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(23, 24, 29);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 311);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(244, 70);
            button1.TabIndex = 7;
            button1.Text = "Log Out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // upPanel
            // 
            upPanel.BackColor = Color.White;
            upPanel.BorderStyle = BorderStyle.FixedSingle;
            upPanel.Controls.Add(label1);
            upPanel.Controls.Add(btnHamburger);
            upPanel.Dock = DockStyle.Top;
            upPanel.Location = new Point(0, 0);
            upPanel.Name = "upPanel";
            upPanel.Size = new Size(1111, 60);
            upPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 18);
            label1.Name = "label1";
            label1.Size = new Size(289, 26);
            label1.TabIndex = 10;
            label1.Text = "Hospital System Management";
            // 
            // btnHamburger
            // 
            btnHamburger.Image = (Image)resources.GetObject("btnHamburger.Image");
            btnHamburger.Location = new Point(14, 18);
            btnHamburger.Name = "btnHamburger";
            btnHamburger.Size = new Size(29, 22);
            btnHamburger.TabIndex = 8;
            btnHamburger.TabStop = false;
            btnHamburger.Click += btnHamburger_Click;
            // 
            // timer1
            // 
            timer1.Interval = 15;
            timer1.Tick += timer1_Tick;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // mainContainer
            // 
            mainContainer.AccessibleRole = AccessibleRole.None;
            mainContainer.Controls.Add(panel5);
            mainContainer.Controls.Add(panel4);
            mainContainer.Controls.Add(panel3);
            mainContainer.Dock = DockStyle.Fill;
            mainContainer.Location = new Point(0, 0);
            mainContainer.Name = "mainContainer";
            mainContainer.Size = new Size(1111, 626);
            mainContainer.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(110, 6);
            label2.Name = "label2";
            label2.Size = new Size(106, 25);
            label2.TabIndex = 2;
            label2.Text = "Total Client";
            // 
            // lblClient
            // 
            lblClient.AutoSize = true;
            lblClient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblClient.ForeColor = Color.White;
            lblClient.Location = new Point(122, 54);
            lblClient.Name = "lblClient";
            lblClient.Size = new Size(0, 41);
            lblClient.TabIndex = 3;
            lblClient.Click += lblClient_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(lblClient);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(767, 90);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 160);
            panel3.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(22, 48);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(90, 7);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 3;
            label3.Text = "Vacant Room";
            // 
            // lblVacant
            // 
            lblVacant.AutoSize = true;
            lblVacant.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblVacant.ForeColor = Color.Black;
            lblVacant.Location = new Point(132, 54);
            lblVacant.Name = "lblVacant";
            lblVacant.Size = new Size(0, 41);
            lblVacant.TabIndex = 4;
            lblVacant.Click += lblVacant_Click;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(lblVacant);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(537, 295);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 160);
            panel4.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(93, 6);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 4;
            label4.Text = "Total Profit";
            // 
            // lblProfit
            // 
            lblProfit.AutoSize = true;
            lblProfit.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblProfit.ForeColor = Color.White;
            lblProfit.Location = new Point(118, 54);
            lblProfit.Name = "lblProfit";
            lblProfit.Size = new Size(0, 41);
            lblProfit.TabIndex = 5;
            lblProfit.Click += lblProfit_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSeaGreen;
            panel5.Controls.Add(lblProfit);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(299, 90);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 160);
            panel5.TabIndex = 17;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1111, 626);
            Controls.Add(panelSidebar);
            Controls.Add(upPanel);
            Controls.Add(mainContainer);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "Dashboard";
            Text = " ";
            Load += Dashboard_Load;
            panelSidebar.ResumeLayout(false);
            bookingContainer.ResumeLayout(false);
            upPanel.ResumeLayout(false);
            upPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHamburger).EndInit();
            mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        private void Transition_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel upPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer sidebarTransition;
        private Button ViewBookings;
        private Button button1;
        private FlowLayoutPanel panelSidebar;
        private PictureBox btnHamburger;
        private Label label1;
        private Panel mainContainer;
        private Button btnBooking;
        private FlowLayoutPanel bookingContainer;
        private Button btnNbooking;
        private Button btnRoomSelect;
        private Button BtnGuestInfo;
        private Button btnDashboard;
        private Panel panel5;
        private Label lblProfit;
        private Label label4;
        private Panel panel4;
        private Label lblVacant;
        private Label label3;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label lblClient;
        private Label label2;
        private PictureBox pictureBox1;
    }
}