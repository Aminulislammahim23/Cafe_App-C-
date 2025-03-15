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
    public partial class Customers : UserControl
    {
        private DataAccess Da { get; set; }
        public Customers()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from Customers")
        {
            DataSet ds = this.Da.ExecuteQuery(sql);

            this.dgvShow.AutoGenerateColumns = false;
            this.dgvShow.DataSource = ds.Tables[0];

        }


    }
}
