namespace Assignment
{
    partial class Menu
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
            this.Add = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.Button();
            this.btnEmails = new System.Windows.Forms.Button();
            this.btnOrderHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Add.Location = new System.Drawing.Point(39, 80);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(122, 72);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add Data";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Edit.Location = new System.Drawing.Point(182, 80);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(129, 72);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit Data";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Delete.Location = new System.Drawing.Point(329, 80);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(116, 72);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Delete Data";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ShowData
            // 
            this.ShowData.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ShowData.Location = new System.Drawing.Point(39, 169);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(122, 70);
            this.ShowData.TabIndex = 3;
            this.ShowData.Text = "Show Data";
            this.ShowData.UseVisualStyleBackColor = false;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // btnEmails
            // 
            this.btnEmails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEmails.Location = new System.Drawing.Point(182, 169);
            this.btnEmails.Name = "btnEmails";
            this.btnEmails.Size = new System.Drawing.Size(129, 70);
            this.btnEmails.TabIndex = 4;
            this.btnEmails.Text = "Show Waiting Stock";
            this.btnEmails.UseVisualStyleBackColor = false;
            this.btnEmails.Click += new System.EventHandler(this.btnEmails_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOrderHistory.Location = new System.Drawing.Point(329, 169);
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(116, 70);
            this.btnOrderHistory.TabIndex = 5;
            this.btnOrderHistory.Text = "Order History";
            this.btnOrderHistory.UseVisualStyleBackColor = false;
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(488, 318);
            this.Controls.Add(this.btnOrderHistory);
            this.Controls.Add(this.btnEmails);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button btnEmails;
        private System.Windows.Forms.Button btnOrderHistory;
    }
}