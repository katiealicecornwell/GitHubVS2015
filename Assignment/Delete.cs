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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void Delete_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDataSet2.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet2.Coffee);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

           


            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            SqlCommand DeleteRecord = new SqlCommand("DELETE FROM Coffee WHERE CoffeeID LIKE '" + txtCoffeeID.Text + "'", conn);
            conn.Open();
            DeleteRecord.ExecuteNonQuery();
            conn.Close();
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet2.Coffee);
            txtCoffeeID.Clear();
            MessageBox.Show("Successfully Deleted Coffee");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            txtCoffeeID.Text = row.Cells[0].Value.ToString();
        }
    }
}
