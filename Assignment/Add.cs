using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Assignment
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            SqlCommand AddRecord = new SqlCommand("INSERT INTO Coffee VALUES (" + txtCoffeeID.Text + ", '" + txtCoffeeName.Text + "', '" + txtStrength.Text + "', '" + txtGrind.Text + "', '" + txtOrigin.Text + "', '" + txtPrice.Text + "', '" + txtQuantity.Text + "', '" + txtImage.Text + "', '" + RTBDes.Text + "')", conn);
            conn.Open();
            AddRecord.ExecuteNonQuery();
            conn.Close();  
            MessageBox.Show("Successfully Added Coffee");
        }
    }  
} 
