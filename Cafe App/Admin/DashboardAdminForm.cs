using Cafe_App.Admin;
using Cafe_App.Login_Val;
using Cafe_App.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WFADBG;

namespace Cafe_App
{
    public partial class DashboardAdminForm : Form
    {
       
        private LoginForm LF { get; set; }
        public DashboardAdminForm()
        {
            InitializeComponent();

            this.defaultPnl.Visible = true;
            
        }

        public DashboardAdminForm(string name, LoginForm lf) : this()
        {
            this.lblAdmin.Text += name;
            this.LF = lf;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        private void userInfoLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            new UserInfoUpdate().Show();
        }

        private void DashboardAdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NoticeUpdateLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            new NoticeForm().Show();
        }

        private void manageProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageProducts().Show();

        }

        private void incomeButton_Click(object sender, EventArgs e)
        {
            this.defaultPnl.Visible = false;
            this.incomePnl.Visible = true;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tdayIncomeLbl_Click(object sender, EventArgs e)
        {
            Customers uc1 = new Customers();

            this.defaultPnl.Controls.Clear();
            this.defaultPnl.Controls.Add(uc1);
        }

        private void mbillLbl_Click(object sender, EventArgs e)
        {
            ManageBill uc2 = new ManageBill();

            this.defaultPnl.Controls.Clear();
            this.defaultPnl.Controls.Add(uc2);
        }
    }
}
