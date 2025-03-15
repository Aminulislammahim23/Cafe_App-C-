using System;
using System.Collections;
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
    public partial class OrderUC : UserControl
    {
        private DataAccess Da { get; set; }
        public OrderUC()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.dgvOrder.Visible = true;          
            this.Calculator();
            this.ShowTotalAmount();
            //this.AutoIdGenerate();
        }
       

        private void PopulateGridView(string sql)
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvShowFood.AutoGenerateColumns = false;
            this.dgvShowFood.DataSource = ds.Tables[0];
        }


        private void OrderListGridView(string sql="select * from OrderList")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = ds.Tables[0];
        }



        private void AddtoCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.AutoSLGenerate();
                this.Calculator();
                

                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please Add All data!!!!");
                    return;
                }
                

                var sql = "select * from OrderList ";
                var ds = this.Da.ExecuteQuery(sql);

                string query = "insert into OrderList (Serial,ItemName,Category,UnitPrice,Qty,Amount,DateAndTime) values ('"+this.lblCount.Text+"','" + this.txtFoodName.Text + "','"+this.categoryCB.Text+"'," + this.txtPrice.Text + "," + this.txtQty.Text + "," + this.txtAmount.Text + ",'"+this.dtpDATE.Text+"');";

                var count = this.Da.ExecuteDMLQuery(query);
                if (count == 1)
                    MessageBox.Show("Added Successfully");
                else
                    MessageBox.Show("Not added please check!!!");

                this.ShowTotalAmount();
                this.OrderListGridView();
                this.ClearForATC();
                
            }
            catch(Exception exc) 
            {
                MessageBox.Show("Error!! ...please check...\n" + exc.Message);

            }
            
        }


        private void ClearForATC()
        {
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.txtQty.Clear();
            this.txtAmount.Clear();
            
            
        }


        private void Calculator()
        {
            if (double.TryParse(txtPrice.Text, out double a) && double.TryParse(txtQty.Text, out double b))
            {
                double result = a * b;

                txtAmount.Text = result.ToString();
            }
           
        }


        private void deleteDVG()
        {            
            var query = "delete from OrderList";
            var count = this.Da.ExecuteDMLQuery(query);

            if (count > 0)
                MessageBox.Show("Table clean successfully");
                        
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.ClearInstruction();
        }


        private void ClearInstruction()
        {            
            this.txtOrderNo.Clear();
            this.sellerIDTxt.Clear();
            this.memberIDTxt.Clear();
            this.txtQty.Clear();
            this.dgvOrder.ClearSelection();
            this.txtAmount.Clear();
            this.txtFoodName.Clear();
            this.txtPrice.Clear();
            this.categoryCB.SelectedItem = null;
            this.lblshowAmount.Text = " ";

        }



        private void dgvShowFood_DoubleClick(object sender, EventArgs e)
        {
            this.txtFoodName.Text = this.dgvShowFood.CurrentRow.Cells["IName"].Value.ToString();
            this.txtPrice.Text = this.dgvShowFood.CurrentRow.Cells["IPrice"].Value.ToString();            
            
        }

        private void ShowTotalAmount()
        {
            var sql = "SELECT SUM(Amount) AS TotalAmount FROM OrderList;";
            DataTable dt = this.Da.ExecuteQueryTable(sql);

            
            if (dt.Rows.Count > 0 && dt.Rows[0]["TotalAmount"] != DBNull.Value)
            {                
                decimal totalAmount = Convert.ToDecimal(dt.Rows[0]["TotalAmount"]);                
                this.lblshowAmount.Text = totalAmount.ToString();
            }
            else
            {              
                this.lblshowAmount.Text = "00";
            }

        }

        //private void AutoIdGenerate()
        //{
        //    var sql = "SELECT Serial FROM OrderList ORDER BY Serial DESC;";
        //    var dt = this.Da.ExecuteQueryTable(sql);
        //    var oldId = dt.Rows[0][0].ToString();
        //    string[] temp = oldId.Split('-');
        //    int n1 = Convert.ToInt32(temp[1]);
        //    string newId = "o-" + (++n1).ToString("d3");
        //    this.txtOrderNo.Text = newId;
        //}

        private void AutoSLGenerate()
        {
            var sql = "SELECT Serial FROM OrderList ORDER BY Serial DESC;";
            var dt = this.Da.ExecuteQueryTable(sql);
           
            if (dt.Rows.Count > 0)
            {               
                int n1 = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i][0] != DBNull.Value)
                    {
                        string oldId = dt.Rows[i][0].ToString();
                        string[] temp = oldId.Split('-');
                        n1 = Convert.ToInt32(temp[1]);
                        break;
                    }
                }              
                string newId = "s-" + (++n1).ToString("d2");
                this.lblCount.Text = newId;
            }
            else
            {
                string newId = "s-01";
                this.lblCount.Text = newId;
            }
        }
    
        private void categoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryCB.SelectedIndex == -1)
            {
                
                return;
            }

            string selectedCategory = categoryCB.SelectedItem.ToString();

           
            Dictionary<string, string> categorySqlMap = new Dictionary<string, string>()
            {
                { "breakfast", "Select * from Product where ICategory = 'breakfast';" },
                { "hot drinks", "Select * from Product where ICategory = 'hot drinks';" },
                { "desserts", "Select * from Product where ICategory = 'desserts';" },
                { "juice", "Select * from Product where ICategory = 'juices';" }
            };

            if (categorySqlMap.TryGetValue(selectedCategory, out string sql))
            {
                this.PopulateGridView(sql);
            }            
        }
        

        private void quantityTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '_'))

            {
                e.Handled = true;

            }

            if ((e.KeyChar == '_')&&((sender as TextBox).Text.IndexOf('_')>-1))
            {
                e.Handled = true;
            }
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtAmount.Text) || String.IsNullOrEmpty(this.txtFoodName.Text)
            || String.IsNullOrEmpty(this.txtPrice.Text) || String.IsNullOrEmpty(this.txtQty.Text))

                return false;
            else
                return true;
        }


        private void btnDGVrf_Click(object sender, EventArgs e)
        {
            this.OrderListGridView();
            this.ShowTotalAmount();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to Create new Order this Item?\nif select Yes, Your previous data will delete.", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.No)
                return;

            this.deleteDVG();
            //this.AutoIdGenerate();
            this.OrderListGridView();
        }
    }
}
