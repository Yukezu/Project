namespace Project
{
    partial class Fbooking
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
            BookingPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            groupBox1 = new GroupBox();
            dgvCurrentBookings = new DataGridView();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            cmbRoom = new ComboBox();
            cmbGuest = new ComboBox();
            BookingPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCurrentBookings).BeginInit();
            SuspendLayout();
            // 
            // BookingPanel
            // 
            BookingPanel.Anchor = AnchorStyles.None;
            BookingPanel.Controls.Add(label4);
            BookingPanel.Controls.Add(label3);
            BookingPanel.Controls.Add(label2);
            BookingPanel.Controls.Add(label1);
            BookingPanel.Controls.Add(btnCancel);
            BookingPanel.Controls.Add(btnSave);
            BookingPanel.Controls.Add(groupBox1);
            BookingPanel.Controls.Add(dtpCheckOut);
            BookingPanel.Controls.Add(dtpCheckIn);
            BookingPanel.Controls.Add(cmbRoom);
            BookingPanel.Controls.Add(cmbGuest);
            BookingPanel.Location = new Point(71, 39);
            BookingPanel.Name = "BookingPanel";
            BookingPanel.Size = new Size(714, 589);
            BookingPanel.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 225);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 10;
            label4.Text = "Check-out Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 177);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 9;
            label3.Text = "Check-in Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 124);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 8;
            label2.Text = "Room:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 77);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Guest:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(370, 539);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 37);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(128, 539);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 37);
            btnSave.TabIndex = 5;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvCurrentBookings);
            groupBox1.Location = new Point(47, 276);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 257);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Current Bookings";
            // 
            // dgvCurrentBookings
            // 
            dgvCurrentBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCurrentBookings.Location = new Point(6, 26);
            dgvCurrentBookings.Name = "dgvCurrentBookings";
            dgvCurrentBookings.RowHeadersWidth = 51;
            dgvCurrentBookings.Size = new Size(577, 225);
            dgvCurrentBookings.TabIndex = 0;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(287, 225);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(253, 27);
            dtpCheckOut.TabIndex = 3;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(286, 170);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(253, 27);
            dtpCheckIn.TabIndex = 2;
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(286, 116);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(254, 28);
            cmbRoom.TabIndex = 1;
            // 
            // cmbGuest
            // 
            cmbGuest.FormattingEnabled = true;
            cmbGuest.Location = new Point(286, 74);
            cmbGuest.Name = "cmbGuest";
            cmbGuest.Size = new Size(254, 28);
            cmbGuest.TabIndex = 0;
            // 
            // Fbooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(917, 640);
            Controls.Add(BookingPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Fbooking";
            Text = "Fbooking";
            Load += Fbooking_Load;
            BookingPanel.ResumeLayout(false);
            BookingPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCurrentBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel BookingPanel;
        private ComboBox cmbRoom;
        private ComboBox cmbGuest;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private GroupBox groupBox1;
        private DataGridView dgvCurrentBookings;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}