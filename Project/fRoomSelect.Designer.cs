namespace Project
{
    partial class fRoomSelect
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            groupBoxAddRoom = new GroupBox();
            btnSave = new Button();
            cmbRoomType = new ComboBox();
            cmbStatus = new ComboBox();
            txtPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAddRoom = new Button();
            btnRefresh = new Button();
            txtSearch = new TextBox();
            dgvRooms = new DataGridView();
            panelChangeDate = new Panel();
            cmbRoomIDUpdate = new ComboBox();
            btnUpdate = new Button();
            cmbDeleteRoomID = new ComboBox();
            btnDelete = new Button();
            groupBoxAddRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            panelChangeDate.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAddRoom
            // 
            groupBoxAddRoom.Controls.Add(btnSave);
            groupBoxAddRoom.Controls.Add(cmbRoomType);
            groupBoxAddRoom.Controls.Add(cmbStatus);
            groupBoxAddRoom.Controls.Add(txtPrice);
            groupBoxAddRoom.Controls.Add(label5);
            groupBoxAddRoom.Controls.Add(label4);
            groupBoxAddRoom.Controls.Add(label3);
            groupBoxAddRoom.Controls.Add(label2);
            groupBoxAddRoom.Location = new Point(109, 291);
            groupBoxAddRoom.Name = "groupBoxAddRoom";
            groupBoxAddRoom.Size = new Size(600, 287);
            groupBoxAddRoom.TabIndex = 12;
            groupBoxAddRoom.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SlateBlue;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(156, 220);
            btnSave.Margin = new Padding(0, 0, 3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(271, 30);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbRoomType
            // 
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "Single", "Double", " Suite", " Deluxe", " Family" });
            cmbRoomType.Location = new Point(155, 84);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(272, 28);
            cmbRoomType.TabIndex = 11;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Available", "Occupied", "Maintenance", "Reserved" });
            cmbStatus.Location = new Point(155, 176);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(272, 28);
            cmbStatus.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(156, 126);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(271, 27);
            txtPrice.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(17, 181);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 8;
            label5.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(17, 130);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 7;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(17, 85);
            label3.Name = "label3";
            label3.Size = new Size(95, 23);
            label3.TabIndex = 6;
            label3.Text = "Room Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(17, 23);
            label2.Name = "label2";
            label2.Size = new Size(249, 35);
            label2.TabIndex = 5;
            label2.Text = "Add Room / Update";
            label2.Click += label2_Click;
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.SlateBlue;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRoom.ForeColor = Color.White;
            btnAddRoom.Image = Properties.Resources.b6db6290574add7b907ade725bb69df9_preview_17523102465801;
            btnAddRoom.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRoom.Location = new Point(481, 42);
            btnAddRoom.Margin = new Padding(0, 0, 3, 3);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Padding = new Padding(1, 0, 3, 0);
            btnAddRoom.Size = new Size(122, 38);
            btnAddRoom.TabIndex = 11;
            btnAddRoom.Text = "Add Room";
            btnAddRoom.TextAlign = ContentAlignment.MiddleRight;
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += btnAddRoom_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(609, 42);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 10;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click_1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(109, 45);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(226, 27);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // dgvRooms
            // 
            dgvRooms.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRooms.BackgroundColor = SystemColors.Control;
            dgvRooms.ColumnHeadersHeight = 29;
            dgvRooms.Location = new Point(109, 90);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.ReadOnly = true;
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(600, 164);
            dgvRooms.TabIndex = 8;
            // 
            // panelChangeDate
            // 
            panelChangeDate.Anchor = AnchorStyles.None;
            panelChangeDate.Controls.Add(cmbRoomIDUpdate);
            panelChangeDate.Controls.Add(btnUpdate);
            panelChangeDate.Controls.Add(cmbDeleteRoomID);
            panelChangeDate.Controls.Add(btnDelete);
            panelChangeDate.Controls.Add(groupBoxAddRoom);
            panelChangeDate.Controls.Add(btnAddRoom);
            panelChangeDate.Controls.Add(btnRefresh);
            panelChangeDate.Controls.Add(txtSearch);
            panelChangeDate.Controls.Add(dgvRooms);
            panelChangeDate.Location = new Point(69, 30);
            panelChangeDate.Name = "panelChangeDate";
            panelChangeDate.Size = new Size(802, 584);
            panelChangeDate.TabIndex = 13;
            // 
            // cmbRoomIDUpdate
            // 
            cmbRoomIDUpdate.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomIDUpdate.FormattingEnabled = true;
            cmbRoomIDUpdate.Location = new Point(492, 260);
            cmbRoomIDUpdate.Name = "cmbRoomIDUpdate";
            cmbRoomIDUpdate.Size = new Size(94, 28);
            cmbRoomIDUpdate.TabIndex = 15;
            cmbRoomIDUpdate.SelectedIndexChanged += cmbRoomIDUpdate_SelectedIndexChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SlateBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.ImageAlign = ContentAlignment.MiddleLeft;
            btnUpdate.Location = new Point(599, 260);
            btnUpdate.Margin = new Padding(0, 0, 3, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 30);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Room";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbDeleteRoomID
            // 
            cmbDeleteRoomID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDeleteRoomID.FormattingEnabled = true;
            cmbDeleteRoomID.Location = new Point(224, 260);
            cmbDeleteRoomID.Name = "cmbDeleteRoomID";
            cmbDeleteRoomID.Size = new Size(94, 28);
            cmbDeleteRoomID.TabIndex = 14;
            cmbDeleteRoomID.SelectedIndexChanged += cmbDeleteRoomID_SelectedIndexChanged;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(109, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 30);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // fRoomSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(1150, 626);
            Controls.Add(panelChangeDate);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fRoomSelect";
            Load += fRoomSelect_Load;
            groupBoxAddRoom.ResumeLayout(false);
            groupBoxAddRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            panelChangeDate.ResumeLayout(false);
            panelChangeDate.PerformLayout();
            ResumeLayout(false);
        }
        private GroupBox groupBoxAddRoom;
        private Button btnSave;
        private ComboBox cmbRoomType;
        private ComboBox cmbStatus;
        private TextBox txtPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnAddRoom;
        private Button btnRefresh;
        private TextBox txtSearch;
        private DataGridView dgvRooms;
        private Panel panelChangeDate;
        private Button btnDelete;
        private ComboBox cmbDeleteRoomID;
        private Button btnUpdate;
        private ComboBox cmbRoomIDUpdate;
    }
}
