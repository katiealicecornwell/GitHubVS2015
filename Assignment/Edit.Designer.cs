namespace Assignment
{
    partial class Edit
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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCoffeeID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtOrigin = new System.Windows.Forms.TextBox();
            this.txtGrind = new System.Windows.Forms.TextBox();
            this.txtStrength = new System.Windows.Forms.TextBox();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
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
            this.coffeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet4 = new Assignment.CoffeeShopDataSet4();
            this.coffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeShopDataSet1 = new Assignment.CoffeeShopDataSet1();
            this.coffeeTableAdapter = new Assignment.CoffeeShopDataSet1TableAdapters.CoffeeTableAdapter();
            this.label9 = new System.Windows.Forms.Label();
            this.RTBDes = new System.Windows.Forms.RichTextBox();
            this.coffeeTableAdapter1 = new Assignment.CoffeeShopDataSet4TableAdapters.CoffeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 333);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Image";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Grind";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Strength";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Coffee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "CoffeeID";
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(378, 228);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(164, 26);
            this.txtImage.TabIndex = 25;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(378, 195);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(164, 26);
            this.txtQuantity.TabIndex = 24;
            // 
            // txtCoffeeID
            // 
            this.txtCoffeeID.Location = new System.Drawing.Point(119, 196);
            this.txtCoffeeID.Name = "txtCoffeeID";
            this.txtCoffeeID.Size = new System.Drawing.Size(164, 26);
            this.txtCoffeeID.TabIndex = 23;
            this.txtCoffeeID.TextChanged += new System.EventHandler(this.txtCoffeeID_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 360);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(164, 26);
            this.txtPrice.TabIndex = 22;
            // 
            // txtOrigin
            // 
            this.txtOrigin.Location = new System.Drawing.Point(119, 327);
            this.txtOrigin.Name = "txtOrigin";
            this.txtOrigin.Size = new System.Drawing.Size(164, 26);
            this.txtOrigin.TabIndex = 21;
            // 
            // txtGrind
            // 
            this.txtGrind.Location = new System.Drawing.Point(119, 294);
            this.txtGrind.Name = "txtGrind";
            this.txtGrind.Size = new System.Drawing.Size(164, 26);
            this.txtGrind.TabIndex = 20;
            // 
            // txtStrength
            // 
            this.txtStrength.Location = new System.Drawing.Point(119, 261);
            this.txtStrength.Name = "txtStrength";
            this.txtStrength.Size = new System.Drawing.Size(164, 26);
            this.txtStrength.TabIndex = 19;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(119, 228);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(164, 26);
            this.txtCoffeeName.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.Location = new System.Drawing.Point(556, 246);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(106, 50);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit Coffee";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataGridView1
            // 
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
            this.Des});
            this.dataGridView1.DataSource = this.coffeeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // strengthDataGridViewTextBoxColumn
            // 
            this.strengthDataGridViewTextBoxColumn.DataPropertyName = "Strength";
            this.strengthDataGridViewTextBoxColumn.HeaderText = "Strength";
            this.strengthDataGridViewTextBoxColumn.Name = "strengthDataGridViewTextBoxColumn";
            // 
            // grindDataGridViewTextBoxColumn
            // 
            this.grindDataGridViewTextBoxColumn.DataPropertyName = "Grind";
            this.grindDataGridViewTextBoxColumn.HeaderText = "Grind";
            this.grindDataGridViewTextBoxColumn.Name = "grindDataGridViewTextBoxColumn";
            // 
            // originDataGridViewTextBoxColumn
            // 
            this.originDataGridViewTextBoxColumn.DataPropertyName = "Origin";
            this.originDataGridViewTextBoxColumn.HeaderText = "Origin";
            this.originDataGridViewTextBoxColumn.Name = "originDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // imageDataGridViewTextBoxColumn
            // 
            this.imageDataGridViewTextBoxColumn.DataPropertyName = "Image";
            this.imageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.imageDataGridViewTextBoxColumn.Name = "imageDataGridViewTextBoxColumn";
            // 
            // Des
            // 
            this.Des.DataPropertyName = "Des";
            this.Des.HeaderText = "Des";
            this.Des.Name = "Des";
            // 
            // coffeeBindingSource1
            // 
            this.coffeeBindingSource1.DataMember = "Coffee";
            this.coffeeBindingSource1.DataSource = this.coffeeShopDataSet4;
            // 
            // coffeeShopDataSet4
            // 
            this.coffeeShopDataSet4.DataSetName = "CoffeeShopDataSet4";
            this.coffeeShopDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeBindingSource
            // 
            this.coffeeBindingSource.DataMember = "Coffee";
            this.coffeeBindingSource.DataSource = this.coffeeShopDataSet1;
            // 
            // coffeeShopDataSet1
            // 
            this.coffeeShopDataSet1.DataSetName = "CoffeeShopDataSet1";
            this.coffeeShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coffeeTableAdapter
            // 
            this.coffeeTableAdapter.ClearBeforeFill = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(283, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Description";
            // 
            // RTBDes
            // 
            this.RTBDes.Location = new System.Drawing.Point(378, 261);
            this.RTBDes.Name = "RTBDes";
            this.RTBDes.Size = new System.Drawing.Size(167, 119);
            this.RTBDes.TabIndex = 36;
            this.RTBDes.Text = "";
            // 
            // coffeeTableAdapter1
            // 
            this.coffeeTableAdapter1.ClearBeforeFill = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(674, 393);
            this.Controls.Add(this.RTBDes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCoffeeID);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtOrigin);
            this.Controls.Add(this.txtGrind);
            this.Controls.Add(this.txtStrength);
            this.Controls.Add(this.txtCoffeeName);
            this.Controls.Add(this.btnEdit);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeShopDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCoffeeID;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtOrigin;
        private System.Windows.Forms.TextBox txtGrind;
        private System.Windows.Forms.TextBox txtStrength;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CoffeeShopDataSet1 coffeeShopDataSet1;
        private System.Windows.Forms.BindingSource coffeeBindingSource;
        private CoffeeShopDataSet1TableAdapters.CoffeeTableAdapter coffeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn strengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imageDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox RTBDes;
        private CoffeeShopDataSet4 coffeeShopDataSet4;
        private System.Windows.Forms.BindingSource coffeeBindingSource1;
        private CoffeeShopDataSet4TableAdapters.CoffeeTableAdapter coffeeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Des;
    }
}