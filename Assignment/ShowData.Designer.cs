namespace Assignment
{
    partial class ShowData
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
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.strengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewDetails = new System.Windows.Forms.DataGridViewLinkColumn();
            this.coffeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet6 = new Assignment.CoffeeShopDataSet6();
            this.coffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet = new Assignment.CoffeeShopDataSet();
            this.coffeeTableAdapter = new Assignment.CoffeeShopDataSetTableAdapters.CoffeeTableAdapter();
            this.coffeeTableAdapter1 = new Assignment.CoffeeShopDataSet6TableAdapters.CoffeeTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.strengthDataGridViewTextBoxColumn,
            this.grindDataGridViewTextBoxColumn,
            this.originDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.imageDataGridViewTextBoxColumn,
            this.Des,
            this.ViewDetails});
            this.dataGridView1.DataSource = this.coffeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(694, 225);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // strengthDataGridViewTextBoxColumn
            // 
            this.strengthDataGridViewTextBoxColumn.DataPropertyName = "Strength";
            this.strengthDataGridViewTextBoxColumn.HeaderText = "Strength";
            this.strengthDataGridViewTextBoxColumn.Name = "strengthDataGridViewTextBoxColumn";
            this.strengthDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // grindDataGridViewTextBoxColumn
            // 
            this.grindDataGridViewTextBoxColumn.DataPropertyName = "Grind";
            this.grindDataGridViewTextBoxColumn.HeaderText = "Grind";
            this.grindDataGridViewTextBoxColumn.Name = "grindDataGridViewTextBoxColumn";
            this.grindDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            this.originDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            this.imageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Des
            // 
            this.Des.DataPropertyName = "Des";
            this.Des.HeaderText = "Des";
            this.Des.Name = "Des";
            this.Des.ReadOnly = true;
            // 
            // ViewDetails
            // 
            this.ViewDetails.HeaderText = "ViewDetails";
            this.ViewDetails.Name = "ViewDetails";
            this.ViewDetails.ReadOnly = true;
            // 
            // coffeeBindingSource1
            // 
            this.coffeeBindingSource1.DataMember = "Coffee";
            this.coffeeBindingSource1.DataSource = this.coffeeShopDataSet6;
            // 
            // coffeeShopDataSet6
            // 
            this.coffeeShopDataSet6.DataSetName = "CoffeeShopDataSet6";
            this.coffeeShopDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeBindingSource
            // 
            this.coffeeBindingSource.DataMember = "Coffee";
            this.coffeeBindingSource.DataSource = this.coffeeShopDataSet;
            // 
            // coffeeShopDataSet
            // 
            this.coffeeShopDataSet.DataSetName = "CoffeeShopDataSet";
            this.coffeeShopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeTableAdapter
            // 
            this.coffeeTableAdapter.ClearBeforeFill = true;
            // 
            // coffeeTableAdapter1
            // 
            this.coffeeTableAdapter1.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(300, 291);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(236, 115);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(85, 282);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(709, 460);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDataSet coffeeShopDataSet;
        private System.Windows.Forms.BindingSource coffeeBindingSource;
        private CoffeeShopDataSetTableAdapters.CoffeeTableAdapter coffeeTableAdapter;
        private CoffeeShopDataSet6 coffeeShopDataSet6;
        private System.Windows.Forms.BindingSource coffeeBindingSource1;
        private CoffeeShopDataSet6TableAdapters.CoffeeTableAdapter coffeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
        private System.Windows.Forms.DataGridViewLinkColumn ViewDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}