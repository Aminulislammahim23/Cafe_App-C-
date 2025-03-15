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

namespace Cafe_App.Admin
{
    public partial class UserInfoUpdate : Form
    {
        private DataAccess Da { get; set; }
        public UserInfoUpdate()
        {
            this.Da = new DataAccess();
            InitializeComponent();
            this.PopulateGridView();
            

            this.dgvShowInfo.ClearSelection();
            
        }

        private void PopulateGridView(string sql = "select * from UserInfo")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvShowInfo.AutoGenerateColumns = false;
            this.dgvShowInfo.DataSource = ds.Tables[0];

        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the information");
                    return;
                }

                var sql = "select * from UserInfo where ID = '" + this.txtID.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                string query = null;



                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update

                    query = "update UserInfo set UName = '" + this.txtName.Text + "',UPassword = " + this.txtPassword.Text + ",Phone = '" + this.txtPhone.Text + "',Role = '" + this.cbRole.SelectedItem + "' where ID = '" + this.txtID.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                        MessageBox.Show("Data Updated Successfully");
                    else
                        MessageBox.Show("Data not updated please check!!!");
                }
                else
                {
                    //Insert

                    query = "insert into UserInfo values('" + this.txtID.Text + "','" + this.txtName.Text + "'," + this.txtPassword.Text + ",'" + this.txtPhone.Text + "','" + this.cbRole.SelectedItem + "')";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                        MessageBox.Show("Data Added Successfully");
                    else
                        MessageBox.Show("Data not added please check!!!");
                }




                this.AutoIdGenerate();
                this.PopulateGridView();

            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvShowInfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                DialogResult result = MessageBox.Show("Are you sure to delete this Item?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                    return;


                var uid = this.dgvShowInfo.CurrentRow.Cells["ID"].Value.ToString();
                var query = "delete from UserInfo where ID = '" + uid + "'";
                var count = this.Da.ExecuteDMLQuery(query);

                if (count > 0)
                    MessageBox.Show("Data remove successfully");
                else
                    MessageBox.Show("Data not remove please check!!!");

                this.ClearInstruction();
                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearInstruction();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.txtID.Text = this.dgvShowInfo.CurrentRow.Cells["ID"].Value.ToString();
            this.txtName.Text = this.dgvShowInfo.CurrentRow.Cells["UName"].Value.ToString();
            this.txtPassword.Text = this.dgvShowInfo.CurrentRow.Cells["UPassword"].Value.ToString();
            this.txtPhone.Text = this.dgvShowInfo.CurrentRow.Cells["Phone"].Value.ToString();
            this.cbRole.SelectedItem = this.dgvShowInfo.CurrentRow.Cells["Role"].Value.ToString();

        }

        private void AutoIdGenerate()
        {
                var sql = "SELECT ID FROM UserInfo ORDER BY ID DESC;";
                var dt = this.Da.ExecuteQueryTable(sql);
                var oldId = dt.Rows[0][0].ToString();
                string[] temp = oldId.Split('-');
                int n1 = Convert.ToInt32(temp[1]);
                string newId = "a-" + (++n1).ToString("d3");  
                this.txtID.Text = newId;
        }


        private void ClearInstruction()
        {
            this.txtID.Clear();
            this.txtName.Clear();
            this.txtPassword.Clear();
            this.txtPhone.Clear();
            this.cbRole.SelectedItem = null;


            this.dgvShowInfo.ClearSelection();

            this.AutoIdGenerate();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashboardAdminForm().Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var sql = "select * from UserInfo where ID = '" + this.txtSearch.Text + "' or Role = '"+this.txtSearch.Text+"' or UName = '"+this.txtSearch.Text+"';";
            this.PopulateGridView(sql);

        }

        private void UserInfoUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void roleCB_Validated(object sender, EventArgs e)
        {
            
        }

        private void roleCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            var sql = "select* from UserInfo where UName like '" + this.txtSearch.Text + "%';";
        }

        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtID.Text) || String.IsNullOrEmpty(this.txtName.Text)
            || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtPhone.Text)
            || String.IsNullOrEmpty(this.cbRole.Text))
                return false;
            else
                return true;
        }
    }
}
