using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace AssignmentWeb
{
    public partial class OrderConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string CustName = Session["CustomerName"].ToString();
            string CustEmail = Session["CustomerEmail"].ToString();

            lblName.Text = CustName;

            string DeliveryCost = Session["Delivery"].ToString();
            lblDelivery.Text = DeliveryCost;

            string TotalCost = Session["final"].ToString();
            lblTotalCost.Text = TotalCost;

            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            string SQLselect = "SELECT id FROM Orders WHERE CustomerName LIKE '" + CustName + "'";
            SqlCommand Find = new SqlCommand();
            Find = new SqlCommand();
            Find.CommandText = SQLselect;
            Find.Connection = conn;
            Find.Connection.Open();
            Find.ExecuteNonQuery();
            SqlDataReader reader = Find.ExecuteReader();

            int id = 0;
            while (reader.Read())
            {
                id = reader.GetInt32(0);
            }

            Find.Connection.Close();
            int OrderID = id;


            string Ord= Convert.ToString(OrderID);
            lblOrderNum.Text = Ord;


            MailMessage mail = new MailMessage();
            //Testing
            NetworkCredential googlecred = new NetworkCredential("lindatooley@live.co.uk", "Toshto57");
            //string mail = CustEmail;
            mail.To.Add(CustEmail);
            mail.Subject = "Thanks for your order!!";
            mail.Body = "Thank you for placing your order! We hope to see you again soon!!";
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

        protected void btnPrint_Click(object sender, EventArgs e)
        {

        }

        protected void printButton_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
   
        }
    }
}