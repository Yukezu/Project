namespace Project
{
    partial class FbillingInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        //Declarations for the missing button controls
        private Button btnSaveInvoice;
        private Button btnPrintInvoice;
        private Button btnClose;

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
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lblCheckOutDate = new Label();
            lblCheckInDate = new Label();
            lblNights = new Label();
            lblRoomRate = new Label();
            lblRoomType = new Label();
            lblGuestName = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            label8 = new Label();
            groupBox4 = new GroupBox();
            txtDiscount = new TextBox();
            txtAdditionalCharge = new TextBox();
            lblTotalAmount = new Label();
            lblRoomCharges = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            btnSaveInvoice = new Button();
            btnPrintInvoice = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(160, 21);
            label1.Name = "label1";
            label1.Size = new Size(227, 30);
            label1.TabIndex = 0;
            label1.Text = " \U0001f9fe  Billing / Invoice   ";
            label1.TextAlign = ContentAlignment.BottomRight;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(43, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(591, 62);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblCheckOutDate);
            groupBox2.Controls.Add(lblCheckInDate);
            groupBox2.Controls.Add(lblNights);
            groupBox2.Controls.Add(lblRoomRate);
            groupBox2.Controls.Add(lblRoomType);
            groupBox2.Controls.Add(lblGuestName);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(46, 88);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(583, 332);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblCheckOutDate
            // 
            lblCheckOutDate.AutoSize = true;
            lblCheckOutDate.Font = new Font("Segoe UI", 9.5F);
            lblCheckOutDate.ForeColor = Color.Navy;
            lblCheckOutDate.Location = new Point(197, 253);
            lblCheckOutDate.Name = "lblCheckOutDate";
            lblCheckOutDate.Size = new Size(0, 21);
            lblCheckOutDate.TabIndex = 11;
            // 
            // lblCheckInDate
            // 
            lblCheckInDate.AutoSize = true;
            lblCheckInDate.Font = new Font("Segoe UI", 9.5F);
            lblCheckInDate.ForeColor = Color.Navy;
            lblCheckInDate.Location = new Point(197, 220);
            lblCheckInDate.Name = "lblCheckInDate";
            lblCheckInDate.Size = new Size(0, 21);
            lblCheckInDate.TabIndex = 10;
            // 
            // lblNights
            // 
            lblNights.AutoSize = true;
            lblNights.Font = new Font("Segoe UI", 9.5F);
            lblNights.ForeColor = Color.Navy;
            lblNights.Location = new Point(197, 152);
            lblNights.Name = "lblNights";
            lblNights.Size = new Size(0, 21);
            lblNights.TabIndex = 9;
            // 
            // lblRoomRate
            // 
            lblRoomRate.AutoSize = true;
            lblRoomRate.Font = new Font("Segoe UI", 9.5F);
            lblRoomRate.ForeColor = Color.Navy;
            lblRoomRate.Location = new Point(197, 114);
            lblRoomRate.Name = "lblRoomRate";
            lblRoomRate.Size = new Size(0, 21);
            lblRoomRate.TabIndex = 8;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 9.5F);
            lblRoomType.ForeColor = Color.Navy;
            lblRoomType.Location = new Point(197, 75);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(0, 21);
            lblRoomType.TabIndex = 7;
            // 
            // lblGuestName
            // 
            lblGuestName.AutoSize = true;
            lblGuestName.Font = new Font("Segoe UI", 9.5F);
            lblGuestName.ForeColor = Color.Navy;
            lblGuestName.Location = new Point(197, 36);
            lblGuestName.Name = "lblGuestName";
            lblGuestName.Size = new Size(0, 21);
            lblGuestName.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label7.ForeColor = Color.Green;
            label7.Location = new Point(30, 253);
            label7.Name = "label7";
            label7.Size = new Size(128, 21);
            label7.TabIndex = 5;
            label7.Text = "Check-Out Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(30, 220);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 4;
            label6.Text = "Check-In Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(30, 152);
            label5.Name = "label5";
            label5.Size = new Size(116, 21);
            label5.TabIndex = 3;
            label5.Text = "Nights Stayed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(27, 114);
            label4.Name = "label4";
            label4.Size = new Size(99, 21);
            label4.TabIndex = 2;
            label4.Text = " Room Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(30, 75);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 1;
            label3.Text = "Room Type:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(30, 36);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 0;
            label2.Text = "Guest Name:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(label8);
            groupBox3.Location = new Point(38, 427);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(591, 62);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.Location = new Point(160, 21);
            label8.Name = "label8";
            label8.Size = new Size(243, 30);
            label8.TabIndex = 0;
            label8.Text = "📄 Charges Breakdown";
            label8.TextAlign = ContentAlignment.BottomRight;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txtDiscount);
            groupBox4.Controls.Add(txtAdditionalCharge);
            groupBox4.Controls.Add(lblTotalAmount);
            groupBox4.Controls.Add(lblRoomCharges);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(label10);
            groupBox4.Controls.Add(label9);
            groupBox4.Location = new Point(38, 490);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(588, 170);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(205, 90);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 17;
            // 
            // txtAdditionalCharge
            // 
            txtAdditionalCharge.Location = new Point(205, 51);
            txtAdditionalCharge.Name = "txtAdditionalCharge";
            txtAdditionalCharge.Size = new Size(125, 27);
            txtAdditionalCharge.TabIndex = 16;
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Segoe UI", 9.5F);
            lblTotalAmount.ForeColor = Color.Navy;
            lblTotalAmount.Location = new Point(205, 131);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(0, 21);
            lblTotalAmount.TabIndex = 15;
            // 
            // lblRoomCharges
            // 
            lblRoomCharges.AutoSize = true;
            lblRoomCharges.Font = new Font("Segoe UI", 9.5F);
            lblRoomCharges.ForeColor = Color.Navy;
            lblRoomCharges.Location = new Point(205, 23);
            lblRoomCharges.Name = "lblRoomCharges";
            lblRoomCharges.Size = new Size(0, 21);
            lblRoomCharges.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label12.ForeColor = Color.Green;
            label12.Location = new Point(15, 131);
            label12.Name = "label12";
            label12.Size = new Size(112, 21);
            label12.TabIndex = 9;
            label12.Text = "Total Amount:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label11.ForeColor = Color.Green;
            label11.Location = new Point(19, 92);
            label11.Name = "label11";
            label11.Size = new Size(105, 21);
            label11.TabIndex = 8;
            label11.Text = "Discount (%):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label10.ForeColor = Color.Green;
            label10.Location = new Point(19, 57);
            label10.Name = "label10";
            label10.Size = new Size(153, 21);
            label10.TabIndex = 7;
            label10.Text = "Additional Charges:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.5F, FontStyle.Bold);
            label9.ForeColor = Color.Green;
            label9.Location = new Point(19, 23);
            label9.Name = "label9";
            label9.Size = new Size(121, 21);
            label9.TabIndex = 6;
            label9.Text = "Room Charges:";
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.BackColor = Color.Navy;
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.Location = new Point(46, 675);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.Size = new Size(139, 34);
            btnSaveInvoice.TabIndex = 4;
            btnSaveInvoice.Text = "💾 Save Invoice";
            btnSaveInvoice.UseVisualStyleBackColor = false;
            btnSaveInvoice.Click += btnSaveInvoice_Click;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BackColor = Color.Navy;
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(246, 675);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.Size = new Size(139, 34);
            btnPrintInvoice.TabIndex = 5;
            btnPrintInvoice.Text = "🖨️ Print Invoice";
            btnPrintInvoice.UseVisualStyleBackColor = false;
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(459, 675);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(139, 34);
            btnClose.TabIndex = 6;
            btnClose.Text = "❌ Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // FbillingInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(681, 733);
            Controls.Add(btnClose);
            Controls.Add(btnPrintInvoice);
            Controls.Add(btnSaveInvoice);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FbillingInvoice";
            Text = "Billing Invoice";
            Load += FbillingInvoice_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label label8;
        private GroupBox groupBox4;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Button button1;
        private Button button2;
        private Label lblCheckOutDate;
        private Label lblCheckInDate;
        private Label lblNights;
        private Label lblRoomRate;
        private Label lblRoomType;
        private Label lblGuestName;
        private Label txtAdditionalCharges;
        private Label lblRoomCharges;
        private Button button3;
        private Label lblTotalAmount;
        private TextBox txtDiscount;
        private TextBox txtAdditionalCharge;
        private Label label15;
    }
}