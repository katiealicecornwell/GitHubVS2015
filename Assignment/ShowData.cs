using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'coffeeShopDataSet6.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter1.Fill(this.coffeeShopDataSet6.Coffee);
            // TODO: This line of code loads data into the 'coffeeShopDataSet.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet.Coffee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];


            string CoffeeID = row.Cells[0].Value.ToString();
        
            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            SqlCommand QueryData = new SqlCommand("SELECT * FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID + "'", conn);
            conn.Open();
            SqlDataReader Result = QueryData.ExecuteReader();
            while (Result.Read())
            {
                string image = Result["Image"].ToString();
                pictureBox1.Image = Image.FromFile(@"C:\Users\Katie\Documents\Visual Studio 2015\Projects\Assignment\Assignment\Properties\images\" + image);
                pictureBox1.BackColor = Color.White;

               

            }


            Result.Close();
            conn.Close();





            richTextBox1.Text = row.Cells[8].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
