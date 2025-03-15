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

namespace Cafe_App
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
          timer1.Start();
           
        }
        int startpoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 10;
            StartingProgress.Value = startpoint;
            if(StartingProgress.Value==100)
            {
                StartingProgress.Value = 0;
                timer1.Stop();
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.Show();
            }

        }
    }
}
