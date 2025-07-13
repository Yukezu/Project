namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Username = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            btnLogIn = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            Forg = new Label();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.log_in_logo;
            pictureBox1.Location = new Point(32, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 302);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Font = new Font("Segoe Fluent Icons", 12F);
            Username.Location = new Point(423, 194);
            Username.Name = "Username";
            Username.Size = new Size(78, 20);
            Username.TabIndex = 1;
            Username.Text = "Username";
            Username.Click += Username_Click;
            // 
            // txtUserName
            // 
            txtUserName.Cursor = Cursors.IBeam;
            txtUserName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(422, 226);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(286, 31);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(422, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(286, 31);
            txtPassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe Fluent Icons", 12F);
            label1.Location = new Point(423, 282);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Yellow;
            btnLogIn.Cursor = Cursors.Hand;
            btnLogIn.Font = new Font("Cascadia Code", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogIn.Location = new Point(424, 401);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(286, 38);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(676, 232);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 22);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(676, 320);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(28, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(413, 73);
            label2.Name = "label2";
            label2.Size = new Size(148, 52);
            label2.TabIndex = 8;
            label2.Text = "Log In";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(423, 133);
            label3.Name = "label3";
            label3.Size = new Size(200, 34);
            label3.TabIndex = 9;
            label3.Text = "Welcome back! Please login your\r\n account.";
            label3.Click += label3_Click;
            // 
            // Forg
            // 
            Forg.AutoSize = true;
            Forg.Cursor = Cursors.Hand;
            Forg.FlatStyle = FlatStyle.System;
            Forg.Font = new Font("Segoe Fluent Icons", 11F);
            Forg.ForeColor = SystemColors.ControlDarkDark;
            Forg.Location = new Point(500, 459);
            Forg.Name = "Forg";
            Forg.Size = new Size(125, 19);
            Forg.TabIndex = 10;
            Forg.Text = "Forget Password?";
            Forg.Click += Forg_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 8F);
            checkBox1.Location = new Point(422, 362);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(126, 23);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(807, 584);
            Controls.Add(checkBox1);
            Controls.Add(Forg);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(Username);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Log In";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label Username;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Button btnLogIn;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label Forg;
        private CheckBox checkBox1;
    }
}
