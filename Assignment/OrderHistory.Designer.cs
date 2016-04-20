namespace Assignment
{
    partial class OrderHistory
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressLine2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTeleNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeID1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grind1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeID2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grind2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeID3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grind3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeID4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grind4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOnCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.securityCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet5 = new Assignment.CoffeeShopDataSet5();
            this.ordersTableAdapter = new Assignment.CoffeeShopDataSet5TableAdapters.OrdersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.customerEmailDataGridViewTextBoxColumn,
            this.addressLine1DataGridViewTextBoxColumn,
            this.addressLine2DataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.customerTeleNumberDataGridViewTextBoxColumn,
            this.coffeeID1DataGridViewTextBoxColumn,
            this.quantity1DataGridViewTextBoxColumn,
            this.price1DataGridViewTextBoxColumn,
            this.grind1DataGridViewTextBoxColumn,
            this.coffeeID2DataGridViewTextBoxColumn,
            this.quantity2DataGridViewTextBoxColumn,
            this.price2DataGridViewTextBoxColumn,
            this.grind2DataGridViewTextBoxColumn,
            this.coffeeID3DataGridViewTextBoxColumn,
            this.quantity3DataGridViewTextBoxColumn,
            this.price3DataGridViewTextBoxColumn,
            this.grind3DataGridViewTextBoxColumn,
            this.coffeeID4DataGridViewTextBoxColumn,
            this.quantity4DataGridViewTextBoxColumn,
            this.price4DataGridViewTextBoxColumn,
            this.grind4DataGridViewTextBoxColumn,
            this.totalItemsDataGridViewTextBoxColumn,
            this.deliveryCostDataGridViewTextBoxColumn,
            this.totalCostDataGridViewTextBoxColumn,
            this.cardNumberDataGridViewTextBoxColumn,
            this.nameOnCardDataGridViewTextBoxColumn,
            this.securityCodeDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.orderDateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ordersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(584, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            // 
            // customerEmailDataGridViewTextBoxColumn
            // 
            this.customerEmailDataGridViewTextBoxColumn.DataPropertyName = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.HeaderText = "CustomerEmail";
            this.customerEmailDataGridViewTextBoxColumn.Name = "customerEmailDataGridViewTextBoxColumn";
            // 
            // addressLine1DataGridViewTextBoxColumn
            // 
            this.addressLine1DataGridViewTextBoxColumn.DataPropertyName = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.HeaderText = "AddressLine1";
            this.addressLine1DataGridViewTextBoxColumn.Name = "addressLine1DataGridViewTextBoxColumn";
            // 
            // addressLine2DataGridViewTextBoxColumn
            // 
            this.addressLine2DataGridViewTextBoxColumn.DataPropertyName = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.HeaderText = "AddressLine2";
            this.addressLine2DataGridViewTextBoxColumn.Name = "addressLine2DataGridViewTextBoxColumn";
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            // 
            // customerTeleNumberDataGridViewTextBoxColumn
            // 
            this.customerTeleNumberDataGridViewTextBoxColumn.DataPropertyName = "CustomerTeleNumber";
            this.customerTeleNumberDataGridViewTextBoxColumn.HeaderText = "CustomerTeleNumber";
            this.customerTeleNumberDataGridViewTextBoxColumn.Name = "customerTeleNumberDataGridViewTextBoxColumn";
            // 
            // coffeeID1DataGridViewTextBoxColumn
            // 
            this.coffeeID1DataGridViewTextBoxColumn.DataPropertyName = "CoffeeID1";
            this.coffeeID1DataGridViewTextBoxColumn.HeaderText = "CoffeeID1";
            this.coffeeID1DataGridViewTextBoxColumn.Name = "coffeeID1DataGridViewTextBoxColumn";
            // 
            // quantity1DataGridViewTextBoxColumn
            // 
            this.quantity1DataGridViewTextBoxColumn.DataPropertyName = "Quantity1";
            this.quantity1DataGridViewTextBoxColumn.HeaderText = "Quantity1";
            this.quantity1DataGridViewTextBoxColumn.Name = "quantity1DataGridViewTextBoxColumn";
            // 
            // price1DataGridViewTextBoxColumn
            // 
            this.price1DataGridViewTextBoxColumn.DataPropertyName = "Price1";
            this.price1DataGridViewTextBoxColumn.HeaderText = "Price1";
            this.price1DataGridViewTextBoxColumn.Name = "price1DataGridViewTextBoxColumn";
            // 
            // grind1DataGridViewTextBoxColumn
            // 
            this.grind1DataGridViewTextBoxColumn.DataPropertyName = "Grind1";
            this.grind1DataGridViewTextBoxColumn.HeaderText = "Grind1";
            this.grind1DataGridViewTextBoxColumn.Name = "grind1DataGridViewTextBoxColumn";
            // 
            // coffeeID2DataGridViewTextBoxColumn
            // 
            this.coffeeID2DataGridViewTextBoxColumn.DataPropertyName = "CoffeeID2";
            this.coffeeID2DataGridViewTextBoxColumn.HeaderText = "CoffeeID2";
            this.coffeeID2DataGridViewTextBoxColumn.Name = "coffeeID2DataGridViewTextBoxColumn";
            // 
            // quantity2DataGridViewTextBoxColumn
            // 
            this.quantity2DataGridViewTextBoxColumn.DataPropertyName = "Quantity2";
            this.quantity2DataGridViewTextBoxColumn.HeaderText = "Quantity2";
            this.quantity2DataGridViewTextBoxColumn.Name = "quantity2DataGridViewTextBoxColumn";
            // 
            // price2DataGridViewTextBoxColumn
            // 
            this.price2DataGridViewTextBoxColumn.DataPropertyName = "Price2";
            this.price2DataGridViewTextBoxColumn.HeaderText = "Price2";
            this.price2DataGridViewTextBoxColumn.Name = "price2DataGridViewTextBoxColumn";
            // 
            // grind2DataGridViewTextBoxColumn
            // 
            this.grind2DataGridViewTextBoxColumn.DataPropertyName = "Grind2";
            this.grind2DataGridViewTextBoxColumn.HeaderText = "Grind2";
            this.grind2DataGridViewTextBoxColumn.Name = "grind2DataGridViewTextBoxColumn";
            // 
            // coffeeID3DataGridViewTextBoxColumn
            // 
            this.coffeeID3DataGridViewTextBoxColumn.DataPropertyName = "CoffeeID3";
            this.coffeeID3DataGridViewTextBoxColumn.HeaderText = "CoffeeID3";
            this.coffeeID3DataGridViewTextBoxColumn.Name = "coffeeID3DataGridViewTextBoxColumn";
            // 
            // quantity3DataGridViewTextBoxColumn
            // 
            this.quantity3DataGridViewTextBoxColumn.DataPropertyName = "Quantity3";
            this.quantity3DataGridViewTextBoxColumn.HeaderText = "Quantity3";
            this.quantity3DataGridViewTextBoxColumn.Name = "quantity3DataGridViewTextBoxColumn";
            // 
            // price3DataGridViewTextBoxColumn
            // 
            this.price3DataGridViewTextBoxColumn.DataPropertyName = "Price3";
            this.price3DataGridViewTextBoxColumn.HeaderText = "Price3";
            this.price3DataGridViewTextBoxColumn.Name = "price3DataGridViewTextBoxColumn";
            // 
            // grind3DataGridViewTextBoxColumn
            // 
            this.grind3DataGridViewTextBoxColumn.DataPropertyName = "Grind3";
            this.grind3DataGridViewTextBoxColumn.HeaderText = "Grind3";
            this.grind3DataGridViewTextBoxColumn.Name = "grind3DataGridViewTextBoxColumn";
            // 
            // coffeeID4DataGridViewTextBoxColumn
            // 
            this.coffeeID4DataGridViewTextBoxColumn.DataPropertyName = "CoffeeID4";
            this.coffeeID4DataGridViewTextBoxColumn.HeaderText = "CoffeeID4";
            this.coffeeID4DataGridViewTextBoxColumn.Name = "coffeeID4DataGridViewTextBoxColumn";
            // 
            // quantity4DataGridViewTextBoxColumn
            // 
            this.quantity4DataGridViewTextBoxColumn.DataPropertyName = "Quantity4";
            this.quantity4DataGridViewTextBoxColumn.HeaderText = "Quantity4";
            this.quantity4DataGridViewTextBoxColumn.Name = "quantity4DataGridViewTextBoxColumn";
            // 
            // price4DataGridViewTextBoxColumn
            // 
            this.price4DataGridViewTextBoxColumn.DataPropertyName = "Price4";
            this.price4DataGridViewTextBoxColumn.HeaderText = "Price4";
            this.price4DataGridViewTextBoxColumn.Name = "price4DataGridViewTextBoxColumn";
            // 
            // grind4DataGridViewTextBoxColumn
            // 
            this.grind4DataGridViewTextBoxColumn.DataPropertyName = "Grind4";
            this.grind4DataGridViewTextBoxColumn.HeaderText = "Grind4";
            this.grind4DataGridViewTextBoxColumn.Name = "grind4DataGridViewTextBoxColumn";
            // 
            // totalItemsDataGridViewTextBoxColumn
            // 
            this.totalItemsDataGridViewTextBoxColumn.DataPropertyName = "TotalItems";
            this.totalItemsDataGridViewTextBoxColumn.HeaderText = "TotalItems";
            this.totalItemsDataGridViewTextBoxColumn.Name = "totalItemsDataGridViewTextBoxColumn";
            // 
            // deliveryCostDataGridViewTextBoxColumn
            // 
            this.deliveryCostDataGridViewTextBoxColumn.DataPropertyName = "DeliveryCost";
            this.deliveryCostDataGridViewTextBoxColumn.HeaderText = "DeliveryCost";
            this.deliveryCostDataGridViewTextBoxColumn.Name = "deliveryCostDataGridViewTextBoxColumn";
            // 
            // totalCostDataGridViewTextBoxColumn
            // 
            this.totalCostDataGridViewTextBoxColumn.DataPropertyName = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.HeaderText = "TotalCost";
            this.totalCostDataGridViewTextBoxColumn.Name = "totalCostDataGridViewTextBoxColumn";
            // 
            // cardNumberDataGridViewTextBoxColumn
            // 
            this.cardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber";
            this.cardNumberDataGridViewTextBoxColumn.Name = "cardNumberDataGridViewTextBoxColumn";
            // 
            // nameOnCardDataGridViewTextBoxColumn
            // 
            this.nameOnCardDataGridViewTextBoxColumn.DataPropertyName = "NameOnCard";
            this.nameOnCardDataGridViewTextBoxColumn.HeaderText = "NameOnCard";
            this.nameOnCardDataGridViewTextBoxColumn.Name = "nameOnCardDataGridViewTextBoxColumn";
            // 
            // securityCodeDataGridViewTextBoxColumn
            // 
            this.securityCodeDataGridViewTextBoxColumn.DataPropertyName = "SecurityCode";
            this.securityCodeDataGridViewTextBoxColumn.HeaderText = "SecurityCode";
            this.securityCodeDataGridViewTextBoxColumn.Name = "securityCodeDataGridViewTextBoxColumn";
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // orderDateTimeDataGridViewTextBoxColumn
            // 
            this.orderDateTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderDateTime";
            this.orderDateTimeDataGridViewTextBoxColumn.HeaderText = "OrderDateTime";
            this.orderDateTimeDataGridViewTextBoxColumn.Name = "orderDateTimeDataGridViewTextBoxColumn";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.coffeeShopDataSet5;
            // 
            // coffeeShopDataSet5
            // 
            this.coffeeShopDataSet5.DataSetName = "CoffeeShopDataSet5";
            this.coffeeShopDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(655, 359);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.Load += new System.EventHandler(this.OrderHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDataSet5 coffeeShopDataSet5;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private CoffeeShopDataSet5TableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressLine2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerTeleNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeID1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grind1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeID2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grind2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeID3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grind3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeID4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grind4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOnCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn securityCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDateTimeDataGridViewTextBoxColumn;
    }
}