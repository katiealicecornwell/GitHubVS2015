namespace Assignment
{
    partial class Emails
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
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.awaitingStockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet3 = new Assignment.CoffeeShopDataSet3();
            this.awaitingStockTableAdapter = new Assignment.CoffeeShopDataSet3TableAdapters.AwaitingStockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.awaitingStockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.coffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.grindDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.awaitingStockBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(729, 269);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "EmailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            this.emailAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            this.coffeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            this.coffeeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grindDataGridViewTextBoxColumn
            // 
            this.grindDataGridViewTextBoxColumn.DataPropertyName = "Grind";
            this.grindDataGridViewTextBoxColumn.HeaderText = "Grind";
            this.grindDataGridViewTextBoxColumn.Name = "grindDataGridViewTextBoxColumn";
            this.grindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // awaitingStockBindingSource
            // 
            this.awaitingStockBindingSource.DataMember = "AwaitingStock";
            this.awaitingStockBindingSource.DataSource = this.coffeeShopDataSet3;
            // 
            // coffeeShopDataSet3
            // 
            this.coffeeShopDataSet3.DataSetName = "CoffeeShopDataSet3";
            this.coffeeShopDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // awaitingStockTableAdapter
            // 
            this.awaitingStockTableAdapter.ClearBeforeFill = true;
            // 
            // Emails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(753, 356);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Emails";
            this.Text = "Emails";
            this.Load += new System.EventHandler(this.Emails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.awaitingStockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDataSet3 coffeeShopDataSet3;
        private System.Windows.Forms.BindingSource awaitingStockBindingSource;
        private CoffeeShopDataSet3TableAdapters.AwaitingStockTableAdapter awaitingStockTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grindDataGridViewTextBoxColumn;
    }
}