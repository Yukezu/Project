namespace Project
{
    partial class ForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtUsername = new TextBox();
            txtNewP = new TextBox();
            txtConfirmP = new TextBox();
            label2 = new Label();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            ChangePassword = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 8F);
            label1.Location = new Point(541, 226);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(467, 586);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Window;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(540, 247);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(322, 32);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += textBox1_TextChanged;
            // 
            // txtNewP
            // 
            txtNewP.BackColor = SystemColors.Window;
            txtNewP.Font = new Font("Segoe UI", 11F);
            txtNewP.ForeColor = Color.White;
            txtNewP.Location = new Point(540, 327);
            txtNewP.Name = "txtNewP";
            txtNewP.Size = new Size(322, 32);
            txtNewP.TabIndex = 4;
            // 
            // txtConfirmP
            // 
            txtConfirmP.BackColor = SystemColors.Window;
            txtConfirmP.Font = new Font("Segoe UI", 11F);
            txtConfirmP.ForeColor = Color.White;
            txtConfirmP.Location = new Point(540, 406);
            txtConfirmP.Name = "txtConfirmP";
            txtConfirmP.Size = new Size(322, 32);
            txtConfirmP.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 8F);
            label2.Location = new Point(541, 306);
            label2.Name = "label2";
            label2.Size = new Size(104, 18);
            label2.TabIndex = 6;
            label2.Text = "New Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic", 8F);
            label3.Location = new Point(541, 385);
            label3.Name = "label3";
            label3.Size = new Size(127, 18);
            label3.TabIndex = 7;
            label3.Text = "Confirm Password";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(640, 45);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 104);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // ChangePassword
            // 
            ChangePassword.BackColor = Color.Yellow;
            ChangePassword.Cursor = Cursors.Hand;
            ChangePassword.Font = new Font("Cascadia Code", 7F);
            ChangePassword.ForeColor = Color.Black;
            ChangePassword.Location = new Point(623, 474);
            ChangePassword.Name = "ChangePassword";
            ChangePassword.Size = new Size(159, 48);
            ChangePassword.TabIndex = 10;
            ChangePassword.Text = "Change Password";
            ChangePassword.UseVisualStyleBackColor = false;
            ChangePassword.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16F, FontStyle.Bold);
            label4.Location = new Point(572, 165);
            label4.Name = "label4";
            label4.Size = new Size(250, 33);
            label4.TabIndex = 11;
            label4.Text = "Reset your password";
            label4.Paint += label4_Paint;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(963, 586);
            Controls.Add(label4);
            Controls.Add(ChangePassword);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtConfirmP);
            Controls.Add(txtNewP);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ForgotPassword";
            Text = "Forget Password";
            Load += ForgotPassword_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtUsername;
        private TextBox txtNewP;
        private TextBox txtConfirmP;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private Button ChangePassword;
        private Label label4;
    }
}