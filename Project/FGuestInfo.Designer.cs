namespace Project
{
    partial class FGuestInfo
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
            panelGuestInfo = new Panel();
            btnDeleteGuest = new Button();
            cmbDeleteGuestID = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAddGuest = new Button();
            btnRefresh = new Button();
            richtxtAddress = new RichTextBox();
            txtEmail = new TextBox();
            txtContact = new TextBox();
            txtGuestName = new TextBox();
            dgvGuestInfo = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelGuestInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestInfo).BeginInit();
            SuspendLayout();
            // 
            // panelGuestInfo
            // 
            panelGuestInfo.BackColor = SystemColors.ActiveCaption;
            panelGuestInfo.Controls.Add(btnDeleteGuest);
            panelGuestInfo.Controls.Add(cmbDeleteGuestID);
            panelGuestInfo.Controls.Add(label4);
            panelGuestInfo.Controls.Add(label3);
            panelGuestInfo.Controls.Add(label2);
            panelGuestInfo.Controls.Add(label1);
            panelGuestInfo.Controls.Add(btnAddGuest);
            panelGuestInfo.Controls.Add(btnRefresh);
            panelGuestInfo.Controls.Add(richtxtAddress);
            panelGuestInfo.Controls.Add(txtEmail);
            panelGuestInfo.Controls.Add(txtContact);
            panelGuestInfo.Controls.Add(txtGuestName);
            panelGuestInfo.Controls.Add(dgvGuestInfo);
            panelGuestInfo.Location = new Point(65, -2);
            panelGuestInfo.Name = "panelGuestInfo";
            panelGuestInfo.Size = new Size(795, 621);
            panelGuestInfo.TabIndex = 0;
            panelGuestInfo.Paint += panelGuestInfo_Paint;
            // 
            // btnDeleteGuest
            // 
            btnDeleteGuest.Location = new Point(609, 510);
            btnDeleteGuest.Name = "btnDeleteGuest";
            btnDeleteGuest.Size = new Size(114, 28);
            btnDeleteGuest.TabIndex = 23;
            btnDeleteGuest.Text = "Delete";
            btnDeleteGuest.UseVisualStyleBackColor = true;
            btnDeleteGuest.Click += btnDeleteGuest_Click;
            // 
            // cmbDeleteGuestID
            // 
            cmbDeleteGuestID.FormattingEnabled = true;
            cmbDeleteGuestID.Location = new Point(468, 510);
            cmbDeleteGuestID.Name = "cmbDeleteGuestID";
            cmbDeleteGuestID.Size = new Size(135, 28);
            cmbDeleteGuestID.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(374, 79);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 21;
            label4.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(89, 220);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 20;
            label3.Text = "Email :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(89, 149);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 19;
            label2.Text = "Phone :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(94, 79);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 18;
            label1.Text = "Full Name :";
            // 
            // btnAddGuest
            // 
            btnAddGuest.BackColor = Color.SteelBlue;
            btnAddGuest.FlatStyle = FlatStyle.Flat;
            btnAddGuest.Font = new Font("Segoe UI", 8F);
            btnAddGuest.ForeColor = Color.White;
            btnAddGuest.Location = new Point(374, 247);
            btnAddGuest.Name = "btnAddGuest";
            btnAddGuest.Size = new Size(127, 39);
            btnAddGuest.TabIndex = 17;
            btnAddGuest.Text = "Add Guest";
            btnAddGuest.UseVisualStyleBackColor = false;
            btnAddGuest.Click += btnAddGuest_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(507, 246);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(114, 40);
            btnRefresh.TabIndex = 16;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // richtxtAddress
            // 
            richtxtAddress.BackColor = Color.Snow;
            richtxtAddress.BorderStyle = BorderStyle.FixedSingle;
            richtxtAddress.Location = new Point(374, 107);
            richtxtAddress.Name = "richtxtAddress";
            richtxtAddress.Size = new Size(247, 103);
            richtxtAddress.TabIndex = 15;
            richtxtAddress.Text = "";
            richtxtAddress.TextChanged += richtxtAddress_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Snow;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(94, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(240, 30);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtContact
            // 
            txtContact.BackColor = Color.Snow;
            txtContact.BorderStyle = BorderStyle.FixedSingle;
            txtContact.Font = new Font("Segoe UI", 10F);
            txtContact.Location = new Point(94, 175);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(240, 30);
            txtContact.TabIndex = 13;
            txtContact.TextChanged += textBox2_TextChanged;
            // 
            // txtGuestName
            // 
            txtGuestName.BackColor = Color.Snow;
            txtGuestName.BorderStyle = BorderStyle.FixedSingle;
            txtGuestName.Font = new Font("Segoe UI", 10F);
            txtGuestName.Location = new Point(94, 105);
            txtGuestName.Name = "txtGuestName";
            txtGuestName.Size = new Size(240, 30);
            txtGuestName.TabIndex = 12;
            // 
            // dgvGuestInfo
            // 
            dgvGuestInfo.BackgroundColor = SystemColors.ControlLightLight;
            dgvGuestInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGuestInfo.Location = new Point(58, 319);
            dgvGuestInfo.Name = "dgvGuestInfo";
            dgvGuestInfo.RowHeadersWidth = 51;
            dgvGuestInfo.Size = new Size(666, 185);
            dgvGuestInfo.TabIndex = 11;
            dgvGuestInfo.CellContentClick += dgvGuestInfo_CellContentClick;
            // 
            // FGuestInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1043, 618);
            Controls.Add(panelGuestInfo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FGuestInfo";
            Text = "GuestInfo";
            Load += FGuestInfo_Load;
            panelGuestInfo.ResumeLayout(false);
            panelGuestInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvGuestInfo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelGuestInfo;
        private DataGridView dgvGuestInfo;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnAddGuest;
        private Button btnRefresh;
        private RichTextBox richtxtAddress;
        private TextBox txtEmail;
        private TextBox txtContact;
        private TextBox txtGuestName;
        private Button btnDeleteGuest;
        private ComboBox cmbDeleteGuestID;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}