using Cafe_App.Admin;
using Cafe_App.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using WFADBG;

namespace Cafe_App.Login_Val
{
    public partial class DashboardUserForm : Form
    {
        private DataAccess Da { get; set; }
        private LoginForm LF { get; set; }

        
        public DashboardUserForm()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.defaultPnl.Show();
        }

        private void PopulateGridView(string sql)
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            //this.dgvItems.AutoGenerateColumns = false;
            //this.dgvItems.DataSource = ds.Tables[0];

        }


        public DashboardUserForm(string name, LoginForm lf) : this()
        {
            this.UserLbl.Text += name;
            this.LF = lf;
        }

        

        private void DashboardUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LogoutButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().Show();
        }

        

        private void newOrderButton_Click(object sender, EventArgs e)
        {
            OrderUC uc1 = new OrderUC();

            this.visiblePnl.Controls.Clear();
            this.visiblePnl.Controls.Add(uc1);         
        }

        private void orderListButton_Click(object sender, EventArgs e)
        {
            OrderList uc2 = new OrderList();

            this.visiblePnl.Controls.Clear();
            this.visiblePnl.Controls.Add(uc2);
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            
            NewMemberUC uc3 = new NewMemberUC();

            this.visiblePnl.Controls.Clear();           
            this.visiblePnl.Controls.Add(uc3);
        }

       
        
    }
}
