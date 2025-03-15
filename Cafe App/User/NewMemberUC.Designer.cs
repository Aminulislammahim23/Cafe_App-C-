namespace Cafe_App.User
{
    partial class NewMemberUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.memberIDTxt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.mNameLbl = new System.Windows.Forms.Label();
            this.memberIDLbl = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.memberNameTxt = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.showButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 606);
            this.panel1.TabIndex = 0;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(153, 312);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 55);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(438, 312);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(104, 55);
            this.showButton.TabIndex = 2;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(34, 312);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 55);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(0, 373);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(542, 232);
            this.panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.UName,
            this.Phone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 232);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.memberIDTxt);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.PhoneLbl);
            this.panel2.Controls.Add(this.mNameLbl);
            this.panel2.Controls.Add(this.memberIDLbl);
            this.panel2.Controls.Add(this.phoneTxt);
            this.panel2.Controls.Add(this.memberNameTxt);
            this.panel2.Location = new System.Drawing.Point(2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 303);
            this.panel2.TabIndex = 0;
            // 
            // memberIDTxt
            // 
            this.memberIDTxt.Location = new System.Drawing.Point(151, 158);
            this.memberIDTxt.Name = "memberIDTxt";
            this.memberIDTxt.ReadOnly = true;
            this.memberIDTxt.Size = new System.Drawing.Size(124, 20);
            this.memberIDTxt.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Location = new System.Drawing.Point(546, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(380, 598);
            this.panel4.TabIndex = 9;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.AutoSize = true;
            this.PhoneLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneLbl.Location = new System.Drawing.Point(52, 226);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(84, 18);
            this.PhoneLbl.TabIndex = 8;
            this.PhoneLbl.Text = "Phone No.";
            // 
            // mNameLbl
            // 
            this.mNameLbl.AutoSize = true;
            this.mNameLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mNameLbl.Location = new System.Drawing.Point(14, 191);
            this.mNameLbl.Name = "mNameLbl";
            this.mNameLbl.Size = new System.Drawing.Size(122, 18);
            this.mNameLbl.TabIndex = 6;
            this.mNameLbl.Text = "Member Name";
            // 
            // memberIDLbl
            // 
            this.memberIDLbl.AutoSize = true;
            this.memberIDLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberIDLbl.Location = new System.Drawing.Point(41, 158);
            this.memberIDLbl.Name = "memberIDLbl";
            this.memberIDLbl.Size = new System.Drawing.Size(95, 18);
            this.memberIDLbl.TabIndex = 5;
            this.memberIDLbl.Text = "Member ID";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Location = new System.Drawing.Point(151, 226);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(285, 20);
            this.phoneTxt.TabIndex = 3;
            // 
            // memberNameTxt
            // 
            this.memberNameTxt.Location = new System.Drawing.Point(151, 189);
            this.memberNameTxt.Name = "memberNameTxt";
            this.memberNameTxt.Size = new System.Drawing.Size(285, 20);
            this.memberNameTxt.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // UName
            // 
            this.UName.DataPropertyName = "UName";
            this.UName.HeaderText = "Name";
            this.UName.Name = "UName";
            this.UName.Width = 200;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 200;
            // 
            // NewMemberUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "NewMemberUC";
            this.Size = new System.Drawing.Size(929, 606);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label mNameLbl;
        private System.Windows.Forms.Label memberIDLbl;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.TextBox memberNameTxt;
        private System.Windows.Forms.Label PhoneLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox memberIDTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}
