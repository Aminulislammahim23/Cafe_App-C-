using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFADBG;

namespace Cafe_App.User
{
    public partial class NewMemberUC : UserControl
    {
        private DataAccess Da { get; set; }
        public NewMemberUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from UserInfo")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables[0];

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearIns();            
        }

        private void ClearIns()
        {
            this.memberIDTxt.Clear();
            this.memberNameTxt.Clear();           
            this.phoneTxt.Clear();
            this.dataGridView1.ClearSelection();

            this.AutoIdGenerate();

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you want to save this ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;

                var sql = "select * from UserInfo where ID = '" + this.memberIDTxt.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                string query = null;



                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update

                    query = "update UserInfo set UserName = '" + this.memberNameTxt.Text + "',Phone = " + this.phoneTxt.Text + " where ID = '" + this.memberIDTxt.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                        MessageBox.Show("Data Updated Successfully");
                    else
                        MessageBox.Show("Data not updated please check!!!");
                }
                else
                {
                    //Insert

                    query = "insert into UserInfo values('" + this.memberIDTxt.Text + "','" + this.memberNameTxt.Text + "','','"+this.phoneTxt.Text+"','member')";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                        MessageBox.Show("Data Added Successfully");
                    else
                        MessageBox.Show("Data not added please check!!!");



                    this.ClearIns();
                    this.PopulateGridView();

                }

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);

            }


        }

        private void AutoIdGenerate()
        {
            var sql = "SELECT ID FROM UserInfo ORDER BY ID DESC;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int n1 = Convert.ToInt32(temp[1]);
            string newId = "m-"+(++n1).ToString("d3");
            this.memberIDTxt.Text = newId;

        }
    }
}
