using System;
using System.Windows.Forms;

namespace Cafe_App.Login_Val
{
    partial class DashboardUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUserForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.defaultPnl = new System.Windows.Forms.Panel();
            this.visiblePnl = new System.Windows.Forms.Panel();
            this.titlePnl = new System.Windows.Forms.Panel();
            this.titleLbl = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.orderListButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.defaultPnl.SuspendLayout();
            this.titlePnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.defaultPnl);
            this.panel4.Controls.Add(this.addMemberButton);
            this.panel4.Controls.Add(this.orderListButton);
            this.panel4.Controls.Add(this.newOrderButton);
            this.panel4.Controls.Add(this.UserLbl);
            this.panel4.Controls.Add(this.LogoutButton);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1222, 664);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(81, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // defaultPnl
            // 
            this.defaultPnl.BackColor = System.Drawing.SystemColors.Desktop;
            this.defaultPnl.Controls.Add(this.visiblePnl);
            this.defaultPnl.Controls.Add(this.titlePnl);
            this.defaultPnl.Location = new System.Drawing.Point(289, -6);
            this.defaultPnl.Name = "defaultPnl";
            this.defaultPnl.Size = new System.Drawing.Size(933, 684);
            this.defaultPnl.TabIndex = 16;
            // 
            // visiblePnl
            // 
            this.visiblePnl.Location = new System.Drawing.Point(3, 64);
            this.visiblePnl.Name = "visiblePnl";
            this.visiblePnl.Size = new System.Drawing.Size(929, 606);
            this.visiblePnl.TabIndex = 2;
            // 
            // titlePnl
            // 
            this.titlePnl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.titlePnl.Controls.Add(this.titleLbl);
            this.titlePnl.Location = new System.Drawing.Point(2, 7);
            this.titlePnl.Name = "titlePnl";
            this.titlePnl.Size = new System.Drawing.Size(939, 55);
            this.titlePnl.TabIndex = 1;
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Rockwell Extra Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(370, 13);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(179, 25);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "USER PORTAL";
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(40, 350);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(211, 40);
            this.addMemberButton.TabIndex = 6;
            this.addMemberButton.Text = "New Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            this.addMemberButton.Click += new System.EventHandler(this.addMemberButton_Click);
            // 
            // orderListButton
            // 
            this.orderListButton.Location = new System.Drawing.Point(40, 292);
            this.orderListButton.Name = "orderListButton";
            this.orderListButton.Size = new System.Drawing.Size(211, 40);
            this.orderListButton.TabIndex = 5;
            this.orderListButton.Text = "Order List";
            this.orderListButton.UseVisualStyleBackColor = true;
            this.orderListButton.Click += new System.EventHandler(this.orderListButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Location = new System.Drawing.Point(40, 232);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(211, 40);
            this.newOrderButton.TabIndex = 4;
            this.newOrderButton.Text = "New Order";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.Location = new System.Drawing.Point(10, 107);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(125, 18);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "Login as User    ";
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(40, 611);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(211, 40);
            this.LogoutButton.TabIndex = 0;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click_1);
            // 
            // DashboardUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 666);
            this.Controls.Add(this.panel4);
            this.MaximizeBox = false;
            this.Name = "DashboardUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashboardUserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardUserForm_FormClosed);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.defaultPnl.ResumeLayout(false);
            this.titlePnl.ResumeLayout(false);
            this.titlePnl.PerformLayout();
            this.ResumeLayout(false);

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panel4;
        private Label UserLbl;
        private Button LogoutButton;
        private Button addMemberButton;
        private Button orderListButton;
        private Button newOrderButton;
        private Panel defaultPnl;
        private Panel titlePnl;
        private Label titleLbl;
        private Panel visiblePnl;
        private PictureBox pictureBox1;
    }
}