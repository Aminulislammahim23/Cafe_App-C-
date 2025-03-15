namespace Cafe_App.User
{
    partial class OrderUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUC));
            this.placeOrderPnl = new System.Windows.Forms.Panel();
            this.dtpDATE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDGVrf = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.memberIDTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblshowAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showTotalLbl = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewOrderButton = new System.Windows.Forms.Button();
            this.placeOrderButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvShowFood = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ICategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryCB = new System.Windows.Forms.ComboBox();
            this.sellerIDTxt = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtOrderNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.selleridLbl = new System.Windows.Forms.Label();
            this.orderNoLbl = new System.Windows.Forms.Label();
            this.placeOrderPnl.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFood)).BeginInit();
            this.SuspendLayout();
            // 
            // placeOrderPnl
            // 
            this.placeOrderPnl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.placeOrderPnl.Controls.Add(this.dtpDATE);
            this.placeOrderPnl.Controls.Add(this.label6);
            this.placeOrderPnl.Controls.Add(this.panel6);
            this.placeOrderPnl.Controls.Add(this.btnDGVrf);
            this.placeOrderPnl.Controls.Add(this.lblAmount);
            this.placeOrderPnl.Controls.Add(this.txtAmount);
            this.placeOrderPnl.Controls.Add(this.panel3);
            this.placeOrderPnl.Controls.Add(this.panel1);
            this.placeOrderPnl.Controls.Add(this.label5);
            this.placeOrderPnl.Controls.Add(this.label3);
            this.placeOrderPnl.Controls.Add(this.txtPrice);
            this.placeOrderPnl.Controls.Add(this.txtFoodName);
            this.placeOrderPnl.Controls.Add(this.label1);
            this.placeOrderPnl.Controls.Add(this.memberIDTxt);
            this.placeOrderPnl.Controls.Add(this.panel5);
            this.placeOrderPnl.Controls.Add(this.panel4);
            this.placeOrderPnl.Controls.Add(this.panel2);
            this.placeOrderPnl.Controls.Add(this.categoryCB);
            this.placeOrderPnl.Controls.Add(this.sellerIDTxt);
            this.placeOrderPnl.Controls.Add(this.txtQty);
            this.placeOrderPnl.Controls.Add(this.txtOrderNo);
            this.placeOrderPnl.Controls.Add(this.label4);
            this.placeOrderPnl.Controls.Add(this.quantityLbl);
            this.placeOrderPnl.Controls.Add(this.selleridLbl);
            this.placeOrderPnl.Controls.Add(this.orderNoLbl);
            this.placeOrderPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.placeOrderPnl.Location = new System.Drawing.Point(0, 0);
            this.placeOrderPnl.Name = "placeOrderPnl";
            this.placeOrderPnl.Size = new System.Drawing.Size(929, 606);
            this.placeOrderPnl.TabIndex = 3;
            // 
            // dtpDATE
            // 
            this.dtpDATE.Location = new System.Drawing.Point(667, 281);
            this.dtpDATE.Name = "dtpDATE";
            this.dtpDATE.Size = new System.Drawing.Size(202, 20);
            this.dtpDATE.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(601, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Date";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.lblCount);
            this.panel6.Location = new System.Drawing.Point(319, 89);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(129, 36);
            this.panel6.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Count";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(58, 17);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 13);
            this.lblCount.TabIndex = 0;
            // 
            // btnDGVrf
            // 
            this.btnDGVrf.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDGVrf.BackgroundImage")));
            this.btnDGVrf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDGVrf.Location = new System.Drawing.Point(883, 324);
            this.btnDGVrf.Name = "btnDGVrf";
            this.btnDGVrf.Size = new System.Drawing.Size(40, 23);
            this.btnDGVrf.TabIndex = 35;
            this.btnDGVrf.UseVisualStyleBackColor = true;
            this.btnDGVrf.Click += new System.EventHandler(this.btnDGVrf_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(579, 247);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 18);
            this.lblAmount.TabIndex = 34;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(667, 247);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(124, 20);
            this.txtAmount.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvOrder);
            this.panel3.Location = new System.Drawing.Point(454, 353);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(469, 194);
            this.panel3.TabIndex = 31;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.ItemName,
            this.Category,
            this.UnitPrice,
            this.Qty,
            this.Amount});
            this.dgvOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrder.Location = new System.Drawing.Point(0, 0);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.Size = new System.Drawing.Size(469, 194);
            this.dgvOrder.TabIndex = 0;
            // 
            // Serial
            // 
            this.Serial.DataPropertyName = "Serial";
            this.Serial.HeaderText = "Serial";
            this.Serial.Name = "Serial";
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.btnNewOrder);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnAddToCart);
            this.panel1.Location = new System.Drawing.Point(815, 136);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 131);
            this.panel1.TabIndex = 30;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(21, 105);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(75, 23);
            this.btnNewOrder.TabIndex = 16;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(21, 32);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(21, 3);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 4;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.AddtoCartButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(596, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(550, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Food Name";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(667, 177);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(124, 20);
            this.txtPrice.TabIndex = 27;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(667, 134);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.ReadOnly = true;
            this.txtFoodName.Size = new System.Drawing.Size(124, 20);
            this.txtFoodName.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(549, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Member ID";
            // 
            // memberIDTxt
            // 
            this.memberIDTxt.Location = new System.Drawing.Point(667, 94);
            this.memberIDTxt.Name = "memberIDTxt";
            this.memberIDTxt.Size = new System.Drawing.Size(257, 20);
            this.memberIDTxt.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblshowAmount);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.showTotalLbl);
            this.panel5.Location = new System.Drawing.Point(462, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(467, 50);
            this.panel5.TabIndex = 23;
            // 
            // lblshowAmount
            // 
            this.lblshowAmount.AutoSize = true;
            this.lblshowAmount.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshowAmount.Location = new System.Drawing.Point(359, 13);
            this.lblshowAmount.Name = "lblshowAmount";
            this.lblshowAmount.Size = new System.Drawing.Size(17, 23);
            this.lblshowAmount.TabIndex = 22;
            this.lblshowAmount.Text = ".";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Order (Total Amount)";
            // 
            // showTotalLbl
            // 
            this.showTotalLbl.AutoSize = true;
            this.showTotalLbl.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTotalLbl.Location = new System.Drawing.Point(395, 13);
            this.showTotalLbl.Name = "showTotalLbl";
            this.showTotalLbl.Size = new System.Drawing.Size(35, 23);
            this.showTotalLbl.TabIndex = 20;
            this.showTotalLbl.Text = "Tk";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.viewOrderButton);
            this.panel4.Controls.Add(this.placeOrderButton);
            this.panel4.Location = new System.Drawing.Point(454, 553);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(472, 50);
            this.panel4.TabIndex = 22;
            // 
            // viewOrderButton
            // 
            this.viewOrderButton.Location = new System.Drawing.Point(37, 15);
            this.viewOrderButton.Name = "viewOrderButton";
            this.viewOrderButton.Size = new System.Drawing.Size(105, 23);
            this.viewOrderButton.TabIndex = 1;
            this.viewOrderButton.Text = "View Order";
            this.viewOrderButton.UseVisualStyleBackColor = true;
            // 
            // placeOrderButton
            // 
            this.placeOrderButton.Location = new System.Drawing.Point(326, 15);
            this.placeOrderButton.Name = "placeOrderButton";
            this.placeOrderButton.Size = new System.Drawing.Size(112, 23);
            this.placeOrderButton.TabIndex = 0;
            this.placeOrderButton.Text = "Place This Order";
            this.placeOrderButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvShowFood);
            this.panel2.Location = new System.Drawing.Point(0, 159);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 446);
            this.panel2.TabIndex = 19;
            // 
            // dgvShowFood
            // 
            this.dgvShowFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.IName,
            this.IPrice,
            this.ICategory});
            this.dgvShowFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvShowFood.Location = new System.Drawing.Point(0, 0);
            this.dgvShowFood.Name = "dgvShowFood";
            this.dgvShowFood.ReadOnly = true;
            this.dgvShowFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShowFood.Size = new System.Drawing.Size(448, 446);
            this.dgvShowFood.TabIndex = 0;
            this.dgvShowFood.DoubleClick += new System.EventHandler(this.dgvShowFood_DoubleClick);
            // 
            // ItemID
            // 
            this.ItemID.DataPropertyName = "ItemID";
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // IName
            // 
            this.IName.DataPropertyName = "IName";
            this.IName.HeaderText = "Food Name";
            this.IName.Name = "IName";
            this.IName.ReadOnly = true;
            // 
            // IPrice
            // 
            this.IPrice.DataPropertyName = "IPrice";
            this.IPrice.HeaderText = "Price";
            this.IPrice.Name = "IPrice";
            this.IPrice.ReadOnly = true;
            // 
            // ICategory
            // 
            this.ICategory.DataPropertyName = "ICategory";
            this.ICategory.HeaderText = "Categoty";
            this.ICategory.Name = "ICategory";
            this.ICategory.ReadOnly = true;
            // 
            // categoryCB
            // 
            this.categoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.categoryCB.Font = new System.Drawing.Font("Rockwell Extra Bold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryCB.FormattingEnabled = true;
            this.categoryCB.Items.AddRange(new object[] {
            "breakfast",
            "hot drinks",
            "desserts",
            "juices"});
            this.categoryCB.Location = new System.Drawing.Point(0, 131);
            this.categoryCB.Name = "categoryCB";
            this.categoryCB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryCB.Size = new System.Drawing.Size(448, 23);
            this.categoryCB.TabIndex = 18;
            this.categoryCB.Text = "Category";
            this.categoryCB.SelectedIndexChanged += new System.EventHandler(this.categoryCB_SelectedIndexChanged);
            // 
            // sellerIDTxt
            // 
            this.sellerIDTxt.Location = new System.Drawing.Point(667, 56);
            this.sellerIDTxt.Name = "sellerIDTxt";
            this.sellerIDTxt.Size = new System.Drawing.Size(257, 20);
            this.sellerIDTxt.TabIndex = 14;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(667, 205);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(124, 20);
            this.txtQty.TabIndex = 13;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTxt_KeyPress);
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(113, 74);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.ReadOnly = true;
            this.txtOrderNo.Size = new System.Drawing.Size(124, 20);
            this.txtOrderNo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "USER ORDER";
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLbl.Location = new System.Drawing.Point(608, 205);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(35, 18);
            this.quantityLbl.TabIndex = 9;
            this.quantityLbl.Text = "Qty";
            // 
            // selleridLbl
            // 
            this.selleridLbl.AutoSize = true;
            this.selleridLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selleridLbl.Location = new System.Drawing.Point(570, 58);
            this.selleridLbl.Name = "selleridLbl";
            this.selleridLbl.Size = new System.Drawing.Size(73, 18);
            this.selleridLbl.TabIndex = 8;
            this.selleridLbl.Text = "Seller ID";
            // 
            // orderNoLbl
            // 
            this.orderNoLbl.AutoSize = true;
            this.orderNoLbl.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderNoLbl.Location = new System.Drawing.Point(16, 74);
            this.orderNoLbl.Name = "orderNoLbl";
            this.orderNoLbl.Size = new System.Drawing.Size(78, 18);
            this.orderNoLbl.TabIndex = 7;
            this.orderNoLbl.Text = "Order No";
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.placeOrderPnl);
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(929, 606);
            this.placeOrderPnl.ResumeLayout(false);
            this.placeOrderPnl.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel placeOrderPnl;
        private System.Windows.Forms.TextBox sellerIDTxt;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtOrderNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.Label selleridLbl;
        private System.Windows.Forms.Label orderNoLbl;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox categoryCB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvShowFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label showTotalLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button viewOrderButton;
        private System.Windows.Forms.Button placeOrderButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberIDTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ICategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnDGVrf;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblshowAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDATE;
    }
}
