namespace Project
{
    partial class fChangeDates
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
            lblBookingInfo = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            label3 = new Label();
            label2 = new Label();
            dtpCheckIn = new DateTimePicker();
            dtpCheckOut = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(lblBookingInfo);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(dtpCheckIn);
            groupBox1.Controls.Add(dtpCheckOut);
            groupBox1.Location = new Point(15, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(536, 442);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // lblBookingInfo
            // 
            lblBookingInfo.AutoSize = true;
            lblBookingInfo.Font = new Font("Segoe UI", 11F);
            lblBookingInfo.Location = new Point(155, 66);
            lblBookingInfo.Name = "lblBookingInfo";
            lblBookingInfo.Size = new Size(185, 25);
            lblBookingInfo.TabIndex = 9;
            lblBookingInfo.Text = "Booking ID:  |  Guest:";
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Location = new Point(268, 290);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(135, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Navy;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(103, 290);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(26, 211);
            label3.Name = "label3";
            label3.Size = new Size(181, 23);
            label3.TabIndex = 5;
            label3.Text = "New Check-Out Date: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(26, 140);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 4;
            label2.Text = "New Check-In Date:";
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.Location = new Point(221, 136);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(249, 27);
            dtpCheckIn.TabIndex = 3;
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.Location = new Point(221, 211);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(249, 27);
            dtpCheckOut.TabIndex = 2;
            // 
            // fChangeDates
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(575, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "fChangeDates";
            Text = "Change Date";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private Label label2;
        private Label lblBookingInfo;
    }
}