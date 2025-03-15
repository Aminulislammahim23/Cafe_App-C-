
using Cafe_App.Login_Val;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cafe_App.Admin
{
    public partial class NoticeForm : Form
    {
        
        public NoticeForm()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.noticeTxt.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashboardAdminForm().Show();
        }

        

        private void publishButton_Click(object sender, EventArgs e)
        {
            string text = this.noticeTxt.Text;
            if (this.noticeTxt.Text == null)
            {
                MessageBox.Show("Please write some text!!!!");
            }
            else if (this.noticeTxt.Text != null)
            {
                MessageBox.Show("Your notice publish successfully");
                new LoginForm(text, this).Show();

                // Open the second form and pass the text


                this.Hide();
                new DashboardAdminForm().Show();
            }
        }
        private void NoticeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
