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
    public partial class ManageProducts : Form
    {
        private DataAccess Da { get; set; }


        public ManageProducts()
        {
            InitializeComponent();
            this.Da = new DataAccess();    
            this.PopulateGridView();
            this.AutoIdGenerate();
        }

        private void PopulateGridView(string sql = "select * from Product")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = ds.Tables[0];

        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DashboardAdminForm().Show();
        }

        private void ManageProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = "select * from Product where ItemID = '" + this.productIDTxt.Text + "';";
                var ds = this.Da.ExecuteQuery(sql);
                string query = null;


                if (ds.Tables[0].Rows.Count == 1)
                {
                    //Update

                    query = " UPDATE Product SET IName = '" + this.productNameTxt.Text + "',ICategory = '" + this.categoryCB.SelectedItem +"' ,IPrice = " + this.productPriceTxt.Text + " WHERE ItemID = '" + this.productIDTxt.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(query);
                    if (count == 1)
                        MessageBox.Show("Data Updated Successfully");
                    else
                        MessageBox.Show("Data not updated please check!!!");
                }
                else
                {
                    //Insert

                    query = "INSERT INTO Product VALUES ('" + this.productIDTxt.Text + "','" + this.productNameTxt.Text + "','" + this.categoryCB.SelectedItem + "','" + this.productPriceTxt.Text + "')";
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.dgvProduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

               
                DialogResult result = MessageBox.Show("Are you sure to delete this Item?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (result == DialogResult.No)
                   return;

     
                var fsl = this.dgvProduct.CurrentRow.Cells["ItemID"].Value.ToString();
                var query = "delete from Product where ItemID = '" + fsl + "'";
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
                MessageBox.Show("Error!! ...please check...\n"+exc.Message);
            }

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.ClearInstruction();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string sql = "select * from Product where IName = '"+this.searchTxt.Text+ "' ";
            this.PopulateGridView(sql);
        }

        private void AutosearchTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ManageProducts_Load(object sender, EventArgs e)
        {
            this.dgvProduct.ClearSelection();
        }

        private void AutoIdGenerate()
        {
            var sql = "SELECT ItemID FROM Product ORDER BY ItemID DESC;";
            var dt = this.Da.ExecuteQueryTable(sql);
            var oldId = dt.Rows[0][0].ToString();
            string[] temp = oldId.Split('-');
            int n1 = Convert.ToInt32(temp[1]);
            string newId = "pd-"+(++n1).ToString();
            this.productIDTxt.Text = newId;

        }

        private void ClearInstruction()
        {
            this.productNameTxt.Clear();
            this.productPriceTxt.Clear();
            this.productIDTxt.Clear();
            this.categoryCB.SelectedItem = false;

            this.searchTxt.Clear();

            this.dgvProduct.ClearSelection();

            this.AutoIdGenerate();
        }

        private void dgvProduct_DoubleClick(object sender, EventArgs e)
        {
            this.productIDTxt.Text = this.dgvProduct.CurrentRow.Cells["ItemID"].Value.ToString();
            this.productNameTxt.Text = this.dgvProduct.CurrentRow.Cells["IName"].Value.ToString();
            this.categoryCB.Text = this.dgvProduct.CurrentRow.Cells["ICategory"].Value.ToString();
            this.productPriceTxt.Text = this.dgvProduct.CurrentRow.Cells["IPrice"].Value.ToString();
                       
        }

    }
}
