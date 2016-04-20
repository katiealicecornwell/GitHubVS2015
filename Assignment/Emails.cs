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
using System.Net.Mail;
using System.Net;


namespace Assignment
{
    public partial class Emails : Form
    {
        public Emails()
        {
            InitializeComponent();
        }

        private void Emails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDataSet3.AwaitingStock' table. You can move, or remove it, as needed.
            this.awaitingStockTableAdapter.Fill(this.coffeeShopDataSet3.AwaitingStock);

        }

        private void btnSendEmails_Click(object sender, EventArgs e)
        {
            


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             





        }
    }
}
