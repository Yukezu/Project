namespace Project
{
    partial class CheckingInOut
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
            groupBox1 = new GroupBox();
            btnCancel = new Button();
            btnConfirm = new Button();
            lblStatus = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            rbtnCheckIn = new RadioButton();
            rbtnCheckOut = new RadioButton();
            label6 = new Label();
            chkPaid = new CheckBox();
            groupBox2 = new GroupBox();
            lblBookingStatus = new Label();
            label5 = new Label();
            lblCheckOutDate = new Label();
            lblCheckInDate = new Label();
            lblRoomType = new Label();
            lblGuestName = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnConfirm);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(chkPaid);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(4, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(573, 567);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 8F);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(275, 513);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(127, 40);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "❌    Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Navy;
            btnConfirm.Font = new Font("Segoe UI", 8F);
            btnConfirm.ForeColor = Color.White;
            btnConfirm.Location = new Point(90, 513);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(127, 42);
            btnConfirm.TabIndex = 12;
            btnConfirm.Text = "✅    Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.Black;
            lblStatus.Location = new Point(117, 473);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 20);
            lblStatus.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(30, 473);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 10;
            label8.Text = "Status:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(224, 224, 224);
            groupBox3.Controls.Add(rbtnCheckIn);
            groupBox3.Controls.Add(rbtnCheckOut);
            groupBox3.Controls.Add(label6);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(24, 322);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(500, 138);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // rbtnCheckIn
            // 
            rbtnCheckIn.AutoSize = true;
            rbtnCheckIn.Location = new Point(23, 59);
            rbtnCheckIn.Name = "rbtnCheckIn";
            rbtnCheckIn.Size = new Size(91, 24);
            rbtnCheckIn.TabIndex = 8;
            rbtnCheckIn.TabStop = true;
            rbtnCheckIn.Text = " Check-In";
            rbtnCheckIn.UseVisualStyleBackColor = true;
            // 
            // rbtnCheckOut
            // 
            rbtnCheckOut.AutoSize = true;
            rbtnCheckOut.Location = new Point(22, 91);
            rbtnCheckOut.Name = "rbtnCheckOut";
            rbtnCheckOut.Size = new Size(99, 24);
            rbtnCheckOut.TabIndex = 7;
            rbtnCheckOut.TabStop = true;
            rbtnCheckOut.Text = "Check-Out";
            rbtnCheckOut.UseVisualStyleBackColor = true;
            rbtnCheckOut.CheckedChanged += rbtnCheckOut_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(7, 23);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 6;
            label6.Text = " ➤    Action:";
            // 
            // chkPaid
            // 
            chkPaid.AutoSize = true;
            chkPaid.ForeColor = Color.Black;
            chkPaid.Location = new Point(34, 281);
            chkPaid.Name = "chkPaid";
            chkPaid.Size = new Size(118, 24);
            chkPaid.TabIndex = 5;
            chkPaid.Text = " Mark as Paid";
            chkPaid.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Gainsboro;
            groupBox2.Controls.Add(lblBookingStatus);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(lblCheckOutDate);
            groupBox2.Controls.Add(lblCheckInDate);
            groupBox2.Controls.Add(lblRoomType);
            groupBox2.Controls.Add(lblGuestName);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(24, 35);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 230);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            // 
            // lblBookingStatus
            // 
            lblBookingStatus.AutoSize = true;
            lblBookingStatus.ForeColor = Color.Black;
            lblBookingStatus.Location = new Point(139, 188);
            lblBookingStatus.Name = "lblBookingStatus";
            lblBookingStatus.Size = new Size(0, 20);
            lblBookingStatus.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(7, 188);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Status:";
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.ForeColor = Color.Black;
            lblCheckOutDate.Location = new Point(149, 142);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(0, 20);
            lblCheckOutDate.TabIndex = 7;
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.ForeColor = Color.Black;
            lblCheckInDate.Location = new Point(149, 105);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(0, 20);
            lblCheckInDate.TabIndex = 6;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.ForeColor = Color.Black;
            lblRoomType.Location = new Point(139, 69);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(0, 20);
            lblRoomType.TabIndex = 5;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.ForeColor = Color.Black;
            lblGuestName.Location = new Point(139, 35);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(0, 20);
            lblGuestName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 2;
            label3.Text = "Check-In Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(7, 35);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 0;
            label1.Text = "Guest Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(7, 69);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Room Type :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 142);
            label4.Name = "label4";
            label4.Size = new Size(120, 20);
            label4.TabIndex = 3;
            label4.Text = "Check-Out Date:";
            // 
            // CheckingInOut
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(584, 586);
            Controls.Add(groupBox1);
            ForeColor = Color.WhiteSmoke;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CheckingInOut";
            Text = "CheckingInOut";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblCheckOutDate;
        private Label lblCheckInDate;
        private Label lblRoomType;
        private Label lblGuestName;
        private GroupBox groupBox3;
        private RadioButton rbtnCheckIn;
        private RadioButton rbtnCheckOut;
        private Label label6;
        private CheckBox chkPaid;
        private Label lblBookingStatus;
        private Button btnCancel;
        private Button btnConfirm;
        private Label lblStatus;
        private Label label8;
    }
}