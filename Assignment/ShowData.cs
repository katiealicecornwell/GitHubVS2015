﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class ShowData : Form
    {
        public ShowData()
        {
            InitializeComponent();
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDataSet.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet.Coffee);

        }
    }
}
