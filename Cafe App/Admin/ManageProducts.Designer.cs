namespace Cafe_App.Admin
{
    partial class ManageProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.showDetailsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.productIDLbl = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.categoryLbl = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productIDTxt = new System.Windows.Forms.TextBox();
            this.productNameLbl = new System.Windows.Forms.Label();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 661);
            this.panel1.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(7, 299);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchButton);
            this.panel3.Controls.Add(this.searchTxt);
            this.panel3.Controls.Add(this.showDetailsButton);
            this.panel3.Location = new System.Drawing.Point(3, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1213, 46);
            this.panel3.TabIndex = 6;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(2, 9);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(83, 11);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(197, 20);
            this.searchTxt.TabIndex = 4;
            this.searchTxt.TextChanged += new System.EventHandler(this.AutosearchTxt_TextChanged);
            // 
            // showDetailsButton
            // 
            this.showDetailsButton.Location = new System.Drawing.Point(1133, 11);
            this.showDetailsButton.Name = "showDetailsButton";
            this.showDetailsButton.Size = new System.Drawing.Size(75, 23);
            this.showDetailsButton.TabIndex = 3;
            this.showDetailsButton.Text = "Show";
            this.showDetailsButton.UseVisualStyleBackColor = true;
            this.showDetailsButton.Click += new System.EventHandler(this.showDetailsButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvProduct);
            this.panel2.Location = new System.Drawing.Point(2, 399);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 261);
            this.panel2.TabIndex = 5;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.IName,
            this.ICategory,
            this.IPrice});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(1213, 261);
            this.dgvProduct.TabIndex = 1;
            this.dgvProduct.DoubleClick += new System.EventHandler(this.dgvProduct_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.productIDLbl);
            this.panel4.Controls.Add(this.ClearButton);
            this.panel4.Controls.Add(this.categoryCB);
            this.panel4.Controls.Add(this.categoryLbl);
            this.panel4.Controls.Add(this.productPrice);
            this.panel4.Controls.Add(this.productIDTxt);
            this.panel4.Controls.Add(this.productNameLbl);
            this.panel4.Controls.Add(this.productPriceTxt);
            this.panel4.Controls.Add(this.productNameTxt);
            this.panel4.Controls.Add(this.DeleteButton);
            this.panel4.Controls.Add(this.AddButton);
            this.panel4.Location = new System.Drawing.Point(9, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 284);
            this.panel4.TabIndex = 4;
            // 
            // productIDLbl
            // 
            this.productIDLbl.AutoSize = true;
            this.productIDLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIDLbl.Location = new System.Drawing.Point(38, 24);
            this.productIDLbl.Name = "productIDLbl";
            this.productIDLbl.Size = new System.Drawing.Size(71, 18);
            this.productIDLbl.TabIndex = 13;
            this.productIDLbl.Text = "ProductID";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(348, 251);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 12;
            this.ClearButton.Text = "Clear All";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // categoryCB
            // 
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "breakfast",
            "hot drinks",
            "desserts",
            "fresh juices"});
            this.categoryCB.Location = new System.Drawing.Point(164, 104);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.Size = new System.Drawing.Size(121, 21);
            this.categoryCB.TabIndex = 11;
            // 
            // categoryLbl
            // 
            this.categoryLbl.AutoSize = true;
            this.categoryLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLbl.Location = new System.Drawing.Point(38, 104);
            this.categoryLbl.Name = "categoryLbl";
            this.categoryLbl.Size = new System.Drawing.Size(63, 18);
            this.categoryLbl.TabIndex = 10;
            this.categoryLbl.Text = "Category";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(38, 150);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(88, 18);
            this.productPrice.TabIndex = 9;
            this.productPrice.Text = "Product Price";
            // 
            // productIDTxt
            // 
            this.productIDTxt.Location = new System.Drawing.Point(164, 24);
            this.productIDTxt.Name = "productIDTxt";
            this.productIDTxt.ReadOnly = true;
            this.productIDTxt.Size = new System.Drawing.Size(298, 20);
            this.productIDTxt.TabIndex = 6;
            // 
            // productNameLbl
            // 
            this.productNameLbl.AutoSize = true;
            this.productNameLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLbl.Location = new System.Drawing.Point(38, 64);
            this.productNameLbl.Name = "productNameLbl";
            this.productNameLbl.Size = new System.Drawing.Size(95, 18);
            this.productNameLbl.TabIndex = 8;
            this.productNameLbl.Text = "Product Name";
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Location = new System.Drawing.Point(164, 148);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.Size = new System.Drawing.Size(298, 20);
            this.productPriceTxt.TabIndex = 4;
            // 
            // productNameTxt
            // 
            this.productNameTxt.Location = new System.Drawing.Point(164, 62);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.Size = new System.Drawing.Size(298, 20);
            this.productNameTxt.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(256, 251);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 2;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(164, 251);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // IName
            // 
            this.IName.DataPropertyName = "IName";
            this.IName.HeaderText = "Item Name";
            this.IName.Name = "IName";
            this.IName.ReadOnly = true;
            // 
            // ICategory
            // 
            this.ICategory.DataPropertyName = "ICategory";
            this.ICategory.HeaderText = "Category";
            this.ICategory.Name = "ICategory";
            this.ICategory.ReadOnly = true;
            // 
            // IPrice
            // 
            this.IPrice.DataPropertyName = "IPrice";
            this.IPrice.HeaderText = "Price";
            this.IPrice.Name = "IPrice";
            this.IPrice.ReadOnly = true;
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 666);
            this.Controls.Add(this.panel1);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManageProducts_FormClosed);
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox productIDTxt;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Button showDetailsButton;
        private System.Windows.Forms.Label categoryLbl;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Label productNameLbl;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label productIDLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPrice;
    }
}