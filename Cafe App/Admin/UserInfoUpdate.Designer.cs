namespace Cafe_App.Admin
{
    partial class UserInfoUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoUpdate));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvShowInfo = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearchOp = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.userLbL = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).BeginInit();
            this.pnlSearchOp.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvShowInfo);
            this.panel1.Location = new System.Drawing.Point(406, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 206);
            this.panel1.TabIndex = 0;
            // 
            // dgvShowInfo
            // 
            this.dgvShowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UName,
            this.UPassword,
            this.Phone,
            this.Role});
            this.dgvShowInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvShowInfo.Name = "dgvShowInfo";
            this.dgvShowInfo.ReadOnly = true;
            this.dgvShowInfo.RowHeadersWidth = 51;
            this.dgvShowInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowInfo.Size = new System.Drawing.Size(817, 206);
            this.dgvShowInfo.TabIndex = 0;
            this.dgvShowInfo.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // UName
            // 
            this.UName.DataPropertyName = "UName";
            this.UName.HeaderText = "Name";
            this.UName.MinimumWidth = 6;
            this.UName.Name = "UName";
            this.UName.ReadOnly = true;
            this.UName.Width = 125;
            // 
            // UPassword
            // 
            this.UPassword.DataPropertyName = "UPassword";
            this.UPassword.HeaderText = "Password";
            this.UPassword.MinimumWidth = 6;
            this.UPassword.Name = "UPassword";
            this.UPassword.ReadOnly = true;
            this.UPassword.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 125;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 125;
            // 
            // pnlSearchOp
            // 
            this.pnlSearchOp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlSearchOp.Controls.Add(this.metroLabel1);
            this.pnlSearchOp.Controls.Add(this.txtSearch);
            this.pnlSearchOp.Controls.Add(this.btnSearch);
            this.pnlSearchOp.Controls.Add(this.showButton);
            this.pnlSearchOp.Location = new System.Drawing.Point(406, 411);
            this.pnlSearchOp.Name = "pnlSearchOp";
            this.pnlSearchOp.Size = new System.Drawing.Size(817, 44);
            this.pnlSearchOp.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(58, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(150, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(3, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 20);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(713, 3);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(101, 38);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(66, 31);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 60);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(31, 93);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(46, 120);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(55, 151);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "Role";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(108, 28);
            this.txtID.Margin = new System.Windows.Forms.Padding(2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(96, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 20);
            this.txtName.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(108, 90);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(139, 20);
            this.txtPassword.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(108, 120);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(139, 20);
            this.txtPhone.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(69, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlInfo.Controls.Add(this.btnClear);
            this.pnlInfo.Controls.Add(this.cbRole);
            this.pnlInfo.Controls.Add(this.btnDelete);
            this.pnlInfo.Controls.Add(this.lblID);
            this.pnlInfo.Controls.Add(this.lblName);
            this.pnlInfo.Controls.Add(this.btnSave);
            this.pnlInfo.Controls.Add(this.lblPassword);
            this.pnlInfo.Controls.Add(this.txtPhone);
            this.pnlInfo.Controls.Add(this.lblPhone);
            this.pnlInfo.Controls.Add(this.txtPassword);
            this.pnlInfo.Controls.Add(this.lblRole);
            this.pnlInfo.Controls.Add(this.txtName);
            this.pnlInfo.Controls.Add(this.txtID);
            this.pnlInfo.Location = new System.Drawing.Point(406, 81);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(814, 325);
            this.pnlInfo.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(250, 221);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // cbRole
            // 
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "admin",
            "user",
            "member"});
            this.cbRole.Location = new System.Drawing.Point(108, 148);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(139, 21);
            this.cbRole.TabIndex = 11;
            this.cbRole.SelectedIndexChanged += new System.EventHandler(this.roleCB_SelectedIndexChanged);
            this.cbRole.Validated += new System.EventHandler(this.roleCB_Validated);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(160, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnlLeft.Controls.Add(this.userLbL);
            this.pnlLeft.Controls.Add(this.pictureBox1);
            this.pnlLeft.Controls.Add(this.btnBack);
            this.pnlLeft.Location = new System.Drawing.Point(3, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(397, 667);
            this.pnlLeft.TabIndex = 13;
            // 
            // userLbL
            // 
            this.userLbL.AutoSize = true;
            this.userLbL.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbL.Location = new System.Drawing.Point(87, 253);
            this.userLbL.Name = "userLbL";
            this.userLbL.Size = new System.Drawing.Size(228, 25);
            this.userLbL.TabIndex = 19;
            this.userLbL.Text = "User Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(56, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(74, 594);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(241, 38);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.backButton_Click);
            // 
            // pnlUp
            // 
            this.pnlUp.BackColor = System.Drawing.SystemColors.Highlight;
            this.pnlUp.Location = new System.Drawing.Point(406, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(813, 76);
            this.pnlUp.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Cursor = System.Windows.Forms.Cursors.No;
            this.metroLabel1.Location = new System.Drawing.Point(240, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(170, 19);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Search by ID / Name / Role";
            // 
            // UserInfoUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 666);
            this.Controls.Add(this.pnlUp);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlSearchOp);
            this.Controls.Add(this.panel1);
            this.Name = "UserInfoUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserInfoUpdate_FormClosed);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowInfo)).EndInit();
            this.pnlSearchOp.ResumeLayout(false);
            this.pnlSearchOp.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvShowInfo;
        private System.Windows.Forms.Panel pnlSearchOp;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label userLbL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}