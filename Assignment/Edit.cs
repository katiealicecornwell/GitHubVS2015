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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopDataSet4.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter1.Fill(this.coffeeShopDataSet4.Coffee);
            // TODO: This line of code loads data into the 'coffeeShopDataSet1.Coffee' table. You can move, or remove it, as needed.
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet1.Coffee);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];

            txtCoffeeID.Text = row.Cells[0].Value.ToString();
            txtCoffeeName.Text = row.Cells[1].Value.ToString();
            txtStrength.Text = row.Cells[2].Value.ToString();
            txtGrind.Text = row.Cells[3].Value.ToString();
            txtOrigin.Text = row.Cells[4].Value.ToString();
            txtPrice.Text = row.Cells[5].Value.ToString();
            txtQuantity.Text = row.Cells[6].Value.ToString();
            txtImage.Text = row.Cells[7].Value.ToString();
            RTBDes.Text = row.Cells[8].Value.ToString();

            if (Convert.ToInt32(txtQuantity.Text) <= 5)
            {
                MessageBox.Show("Stock is running low. Please update this product.");
            }


        }

       

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            string sqlStatementAdd = "UPDATE Coffee SET CoffeeID = '" + txtCoffeeID.Text + "', CoffeeName = '" + txtCoffeeName.Text + "', Strength = '" + txtStrength.Text + "' , Grind = '" + txtGrind.Text + "', Origin = '" + txtOrigin.Text + "' , Price = '" + txtPrice.Text + "', Quantity = '" + txtQuantity.Text + "' , Image = '" + txtImage.Text + "', Des = '" + RTBDes.Text + "' WHERE CoffeeID = " + txtCoffeeID.Text + ";";
            SqlCommand Update = new SqlCommand();
            Update = new SqlCommand();
            Update.CommandText = sqlStatementAdd;
            Update.Connection = conn;
            Update.Connection.Open();
            Update.ExecuteNonQuery();
            this.coffeeTableAdapter.Fill(this.coffeeShopDataSet1.Coffee);




            if (int.Parse(txtQuantity.Text) >= 1)
            {
                SqlCommand emailCoffee = new SqlCommand("SELECT * FROM AwaitingStock WHERE CoffeeName LIKE '" + txtCoffeeName.Text + "' ", conn);

                conn.Close();
                conn.Open();
                SqlDataReader reader = emailCoffee.ExecuteReader();
                while (reader.Read())
                {

                    string email = reader[@"EmailAddress"].ToString();
                    MailMessage mail = new MailMessage();

                    NetworkCredential googlecred = new NetworkCredential("lindatooley@live.co.uk", "Toshto57");

                    mail.To.Add(email);
                    mail.Subject = "Your Coffee is now back in stock";
                    mail.Body = "You recently requested for us to be in touch when an item was back in stock. Good news... The item is now back in stock";
                    mail.From = new MailAddress("lindatooley@live.co.uk");
                    mail.IsBodyHtml = true;
                    //connection to server                    
                    SmtpClient smtp = new SmtpClient("smtp.live.com");
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = googlecred;
                    smtp.EnableSsl = true;
                    smtp.Port = 587;
                    smtp.Send(mail);
                }
                reader.Close();
            }
            SqlCommand deleteEmail = new SqlCommand("DELETE FROM AwaitingStock WHERE CoffeeName LIKE'" + txtCoffeeName.Text + "' ", conn);
            conn.Close();
            conn.Open();
            deleteEmail.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Successfully Edited Coffee");



        }

        private void txtCoffeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }

}