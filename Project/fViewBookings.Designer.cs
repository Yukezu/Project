namespace Project
{
    partial class fViewBookings
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
            panelViewBooking = new Panel();
            button1 = new Button();
            btnChange = new Button();
            btnCancelBookings = new Button();
            dgvViewBooking = new DataGridView();
            btnRefresh = new Button();
            txtSearchGuest = new TextBox();
            cmbFilter = new ComboBox();
            label1 = new Label();
            panelViewBooking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooking).BeginInit();
            SuspendLayout();
            // 
            // panelViewBooking
            // 
            panelViewBooking.Controls.Add(button1);
            panelViewBooking.Controls.Add(btnChange);
            panelViewBooking.Controls.Add(btnCancelBookings);
            panelViewBooking.Controls.Add(dgvViewBooking);
            panelViewBooking.Controls.Add(btnRefresh);
            panelViewBooking.Controls.Add(txtSearchGuest);
            panelViewBooking.Controls.Add(cmbFilter);
            panelViewBooking.Controls.Add(label1);
            panelViewBooking.Location = new Point(160, 34);
            panelViewBooking.Name = "panelViewBooking";
            panelViewBooking.Size = new Size(711, 507);
            panelViewBooking.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(267, 383);
            button1.Name = "button1";
            button1.Size = new Size(155, 45);
            button1.TabIndex = 9;
            button1.Text = "Check-in/Check-out";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnChange
            // 
            btnChange.BackColor = Color.White;
            btnChange.ForeColor = Color.Black;
            btnChange.Location = new Point(528, 383);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(133, 45);
            btnChange.TabIndex = 8;
            btnChange.Text = "Change Date";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // btnCancelBookings
            // 
            btnCancelBookings.BackColor = Color.Navy;
            btnCancelBookings.ForeColor = Color.White;
            btnCancelBookings.Location = new Point(28, 383);
            btnCancelBookings.Name = "btnCancelBookings";
            btnCancelBookings.Size = new Size(133, 45);
            btnCancelBookings.TabIndex = 7;
            btnCancelBookings.Text = "Cancel Booking";
            btnCancelBookings.UseVisualStyleBackColor = false;
            btnCancelBookings.Click += btnCancelBookings_Click;
            // 
            // dgvViewBooking
            // 
            dgvViewBooking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvViewBooking.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvViewBooking.Location = new Point(28, 138);
            dgvViewBooking.Name = "dgvViewBooking";
            dgvViewBooking.RowHeadersWidth = 51;
            dgvViewBooking.Size = new Size(633, 223);
            dgvViewBooking.TabIndex = 4;
            dgvViewBooking.CellContentClick += dgvViewBooking_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.Navy;
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Image = Properties.Resources._841e5a4216765b1459006302765fea4f_preview_1752374247677;
            btnRefresh.ImageAlign = ContentAlignment.MiddleLeft;
            btnRefresh.Location = new Point(554, 92);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Padding = new Padding(0, 0, 10, 0);
            btnRefresh.Size = new Size(107, 28);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.MiddleRight;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // txtSearchGuest
            // 
            txtSearchGuest.Location = new Point(28, 95);
            txtSearchGuest.Name = "txtSearchGuest";
            txtSearchGuest.Size = new Size(200, 27);
            txtSearchGuest.TabIndex = 2;
            txtSearchGuest.Enter += txtSearchGuest_Enter;
            txtSearchGuest.Leave += txtSearchGuest_Leave;
            // 
            // cmbFilter
            // 
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Upcoming", "Ongoing", "Past" });
            cmbFilter.Location = new Point(84, 46);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(112, 28);
            cmbFilter.TabIndex = 1;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 50);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter:";
            // 
            // fViewBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(972, 606);
            Controls.Add(panelViewBooking);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fViewBookings";
            Text = "ViewBookings";
            Load += fViewBookings_Load;
            Resize += fViewBookings_Resize;
            panelViewBooking.ResumeLayout(false);
            panelViewBooking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvViewBooking).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelViewBooking;
        private Label label1;
        private ComboBox cmbFilter;
        private TextBox txtSearchGuest;
        private Button btnRefresh;
        private Button btnChangeD;
        private DataGridView dgvViewBooking;
        private Button btnCancelBookings;
        private Button btnChange;
        private Button button1;
    }
}