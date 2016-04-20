using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AssignmentWeb
{


    public partial class ViewDetails : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

         

            string recordnumber = Request.QueryString["record"].ToString();

                lblCoffeeID.Text = recordnumber;




                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                string sqlStatementFind = string.Format("SELECT * FROM Coffee WHERE CoffeeID = " + lblCoffeeID.Text + ";");
                SqlCommand Find = new SqlCommand();
                Find = new SqlCommand();
                Find.CommandText = sqlStatementFind;
                Find.Connection = conn;
                Find.Connection.Open();
                Find.ExecuteNonQuery();
                SqlDataReader reader = Find.ExecuteReader();
                int stocklevel = 0;
                while (reader.Read())
                {
                    lblCoffeeName.Text = reader.GetString(1);
                    lblOrigin.Text = reader.GetString(4);
                    lblStrength.Text = reader.GetString(2);
                    stocklevel = reader.GetInt32(6);
                    decimal value = reader.GetDecimal(5);
                    lblPrice.Text = (value.ToString("C2"));
                    string image = reader["Image"].ToString();
                    Image1.ImageUrl = @image;
                    lblDescription.Text = reader.GetString(8);




                    if (this.Page.User.Identity.IsAuthenticated)
                    {
                        lblno2.Text = Convert.ToString(stocklevel);
                    }



                }
                Find.Connection.Close();


                if (stocklevel == 0)
                {
                    lblStock.Text = "This item is currently out of stock!";
                    TextBox1.Visible = true;
                    lblEnterEmail.Visible = true;
                    btnEmailMe.Visible = true;


                }

                if (stocklevel <= 5 && stocklevel >= 1)
                {
                    lblStock.Text = "The stock level of this item is currently low!";


                }




            }



        protected void btnBuy_Click(object sender, EventArgs e)
        {

            
            string grind = DDGrind.SelectedValue;
            int quan = 1;

            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            SqlCommand AddRecord = new SqlCommand("INSERT INTO Cart (CoffeeID, CoffeeName, Quantity, Price, Grind) VALUES(" + lblCoffeeID.Text + ", '" + lblCoffeeName.Text + "',  '" + quan + "', '" + lblPrice.Text + "', '" + grind + "')", conn);
            conn.Open();
            AddRecord.ExecuteNonQuery();
            conn.Close();
           
          Response.Redirect("ShoppingCart.aspx");


        }



        protected void DDGRind_Change(object sender, EventArgs e)
        {

            if (DDGrind.SelectedItem.Text == "Whole Bean")
            {

                string Coffee = lblCoffeeName.Text;
                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                string sqlStatementFind1 = string.Format("SELECT * FROM Coffee WHERE CoffeeName = '" + lblCoffeeName.Text + "' AND Grind LIKE 'Whole Bean';");
                SqlCommand Find1 = new SqlCommand();
                Find1 = new SqlCommand();
                Find1.CommandText = sqlStatementFind1;
                Find1.Connection = conn;
                Find1.Connection.Open();
                Find1.ExecuteNonQuery();
                SqlDataReader reader1 = Find1.ExecuteReader();
                int stocklevel1 = 0;
                while (reader1.Read())
                {

                    stocklevel1 = reader1.GetInt32(6);

                    if (this.Page.User.Identity.IsAuthenticated)
                    {
                        lblno2.Text = Convert.ToString(stocklevel1);
                    }


                    string image = reader1["Image"].ToString();
                    Image1.ImageUrl = @image;
                    lblDescription.Text = reader1.GetString(8);

                }




                if (stocklevel1 == 0)
                {
                    lblStock.Text = "This item is currently out of stock!";
                    TextBox1.Visible = true;
                    lblEnterEmail.Visible = true;
                    btnEmailMe.Visible = true;

                }
                if (stocklevel1 <= 5 && stocklevel1 >= 1)
                {
                    lblStock.Text = "The stock level of this item is currently low!";
                }
                Find1.Connection.Close();


            }

            if (DDGrind.SelectedItem.Text == "Instant")
            {
                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                string sqlStatementFind2 = string.Format("SELECT * FROM Coffee WHERE CoffeeName = '" + lblCoffeeName.Text + "' AND Grind LIKE 'Instant';");
                SqlCommand Find2 = new SqlCommand();
                Find2 = new SqlCommand();
                Find2.CommandText = sqlStatementFind2;
                Find2.Connection = conn;
                Find2.Connection.Open();
                Find2.ExecuteNonQuery();
                SqlDataReader reader2 = Find2.ExecuteReader();
                int stocklevel2 = 0;
                while (reader2.Read())
                {

                    stocklevel2 = reader2.GetInt32(6);
                    if (this.Page.User.Identity.IsAuthenticated)
                    {
                        lblno2.Text = Convert.ToString(stocklevel2);
                    }

                    string image = reader2["Image"].ToString();
                    Image1.ImageUrl = @image;
                    lblDescription.Text = reader2.GetString(8);

                }




                if (stocklevel2 == 0)
                {
                    TextBox1.Visible = true;
                    lblEnterEmail.Visible = true;
                    btnEmailMe.Visible = true;

                }
                if (stocklevel2 <= 5 && stocklevel2 >= 1)
                {
                    lblStock.Text = "The stock level of this item is currently low!";
                }
                Find2.Connection.Close();


            }
        }
    



        


        
        

        protected void btnEmailMe_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            string sqlStatementFind = string.Format("SELECT * FROM Coffee WHERE CoffeeID = " + lblCoffeeID.Text + ";");
            SqlCommand Find = new SqlCommand();
            Find = new SqlCommand();
            Find.CommandText = sqlStatementFind;
            Find.Connection = conn;
            Find.Connection.Open();
            Find.ExecuteNonQuery();
            SqlDataReader reader = Find.ExecuteReader();
            int stocklevel = 0;
            int CoffeeID = 0;
            string CoffeeName = "";
            string Grind = "";
            while (reader.Read())
            {
                CoffeeID = reader.GetInt32(0);
                CoffeeName = reader.GetString(1);
                Grind = reader.GetString(3);

                stocklevel = reader.GetInt32(6);

                //decimal value = reader.GetDecimal(5);
                //lblPrice.Text = (value.ToString("C2"));
            }
            Find.Connection.Close();


            DateTime Date = DateTime.Now;
            string EmailAddress = TextBox1.Text;
           // SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
            SqlCommand AddRecord = new SqlCommand("INSERT INTO AwaitingStock VALUES( '" + "Katie Cornwell" + "',  '" + EmailAddress + "', '" + Date + "', '" + CoffeeID + "' , '" + CoffeeName + "',  '" + Grind + "')", conn);
            conn.Open();
            AddRecord.ExecuteNonQuery();
            conn.Close();

            lblThankYou.Text = "Thank you, we will email you when this item becomes available again";

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            //TextBox2.Text = //TextBox2.Text;
        }
    }
}