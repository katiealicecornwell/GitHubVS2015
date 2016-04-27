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
using System.Data.OleDb;

namespace Assignment
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData SD = new ShowData();
            SD.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            string sqlStatement = "SELECT * FROM Users WHERE Username LIKE '" + txtUsername.Text + "' AND Password LIKE '" + txtPassword.Text + "'";
            SqlCommand Find = new SqlCommand();
            Find = new SqlCommand();
            Find.CommandText = sqlStatement;
            Find.Connection = conn;
            Find.Connection.Open();
            Find.ExecuteNonQuery();
            SqlDataReader reader = Find.ExecuteReader();
            int count = 0;
            while (reader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                MessageBox.Show("Successful");
                Menu MU = new Menu();
                MU.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("unsuccessful");
            }

            Find.Connection.Close();


        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
