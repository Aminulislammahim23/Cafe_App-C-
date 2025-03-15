using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Reflection;
using Cafe_App.Admin;
using WFADBG;
using System.Xml.Linq;


namespace Cafe_App.Login_Val
{
    public partial class LoginForm : Form
    {

        private NoticeForm NF {  get; set; }
        public LoginForm()
        {
            InitializeComponent();
            
        }

        public LoginForm(string text, NoticeForm nf) 
        {
            this.noticeShowTxt.Text += text;
            this.NF = nf;

        }
        

        private void LogInButton_Click(object sender, EventArgs e)
        {           

            string sql = "select * from UserInfo where ID= '" + this.UserIdTxt.Text + "' and UPassword = '"+this.PasswordTxt.Text + "';";
            DataAccess da = new DataAccess();
            DataSet ds = da.ExecuteQuery(sql);


            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Welcome");
                var name = ds.Tables[0].Rows[0][1].ToString().ToUpper();   //anony type
                if (ds.Tables[0].Rows[0][4].ToString() == "admin")
                {
                    this.Hide();
                    new DashboardAdminForm(name, this).Show();
                }
                else if (ds.Tables[0].Rows[0][4].ToString() == "user")
                {
                    this.Hide();
                    new DashboardUserForm(name, this).Show();
                }
                                          
            }
            else
            {
                MessageBox.Show("Invalid User!!!");
            }
            
            
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.UserIdTxt.Clear();
            this.PasswordTxt.Clear();
            this.cbShowPass.Checked = false;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        private void LogInButton_MouseHover(object sender, EventArgs e)
        {
            this.LogInButton.BackColor = Color.Green;
        }

        private void LogInButton_MouseLeave(object sender, EventArgs e)
        {
            this.LogInButton.BackColor = Color.Red;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //private void ShowPasswordRb_Click(object sender, EventArgs e)
        //{
            

        //}

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = true;
                
                // Checkbox is checked
                // Do something here
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = false;
                // Checkbox is not checked
                // Do something else here
            }


        }

    }
}
