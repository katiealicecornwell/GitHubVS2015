using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AssignmentWeb
{
    public partial class Purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string rows = Session["Rows"].ToString();

            string Delivery = DDDelivery.SelectedValue;

            if (Delivery == "Standard")
            {
                Delivery = "3.99";
            }
            else
            {
                Delivery = "5.00";
            }


            
            if (rows == "1")
            {

                DateTime date = DateTime.Now;

                string CoffeeID1 = Session["FirstCoffeeID"].ToString();
                string Quan1 = Session["FirstCoffeeQuan"].ToString();
                string Price1 = Session["FirstCoffeePrice"].ToString();
                string Grind1 = Session["FirstCoffeeGrind"].ToString();

                string CustomerName = txtCustName.Text;
                Session["CustomerName"] = CustomerName;
                string CustomerEmail = txtCustEmail.Text;
                Session["CustomerEmail"] = CustomerEmail;
                string AddressLine1 = txtAddressLine1.Text;
                string AddressLine2 = txtAddressLine2.Text;
                string Postcode = txtPostcode.Text;
                string TeleNumber = txtNumber.Text;
                string CardNumber = txtCardNumber.Text;
                string NameOnCard = txtNameOnCard.Text;
                string SecurityCode = txtSecurityCode.Text;
                string ExpiryDate = txtExpiryDate.Text;


                decimal first = Decimal.Parse(Price1);
                decimal quan = decimal.Parse(Quan1);
                
                decimal Del = decimal.Parse(Delivery);
                Session["Delivery"] = Del;
                decimal TotalCost = (first * quan) + Del;
                Session["Total"] = TotalCost;
                decimal FinalCost = 0;
                if (txtDiscountCode.Text == "StudentDiscount")
                {
                    FinalCost = (TotalCost * 0.90m);
                    Session["final"] = FinalCost;
                }

                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                SqlCommand AddRecord = new SqlCommand("INSERT INTO Orders VALUES( '" + CustomerName + "',  '" + CustomerEmail + "', '" + AddressLine1 + "', '" + AddressLine2 + "' , '" + Postcode + "',  '" + TeleNumber + "', '" + CoffeeID1 + "', '" + Quan1 + "', '" + Price1 + "', '" + Grind1 + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "',  '" + 1 + "', '" + Delivery + "', '" + FinalCost + "' , '" + CardNumber + "' ,  '" + NameOnCard + "', '" + SecurityCode + "', '" + ExpiryDate + "' , '" + "PAID" + "', '" + date + "')", conn);
                conn.Open();
                AddRecord.ExecuteNonQuery();
                conn.Close();



                string SQLselect = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID1 + "'";
                SqlCommand Find = new SqlCommand();
                Find = new SqlCommand();
                Find.CommandText = SQLselect;
                Find.Connection = conn;
                Find.Connection.Open();
                Find.ExecuteNonQuery();
                SqlDataReader reader = Find.ExecuteReader();
                int Quan = 0;
                while (reader.Read())
                {
                    Quan = reader.GetInt32(0);
                }

                Find.Connection.Close();





                int RemainingQuantity = Quan;
                int QuantityBrought = Int32.Parse(Quan1);
                int TotalRemaining = RemainingQuantity - QuantityBrought;

                string sqlStatementUpdate = "UPDATE Coffee SET Quantity = '" + TotalRemaining + "' WHERE CoffeeID = " + CoffeeID1 + ";";
                SqlCommand Update = new SqlCommand();
                Update = new SqlCommand();
                Update.CommandText = sqlStatementUpdate;
                Update.Connection = conn;
                Update.Connection.Open();
                Update.ExecuteNonQuery();
                Update.Connection.Close();

            }

            if (rows == "2")
            {
                DateTime date = DateTime.Now;

                string CoffeeID1 = Session["FirstCoffeeID"].ToString();
                string Quan1 = Session["FirstCoffeeQuan"].ToString();
                string Price1 = Session["FirstCoffeePrice"].ToString();
                string Grind1 = Session["FirstCoffeeGrind"].ToString();


                string CoffeeID2 = Session["SecondCoffeeID"].ToString();
                string Quantity2 = Session["SecondCoffeeQuan"].ToString();
                string Price2 = Session["SecondCoffeePrice"].ToString();
                string Grind2 = Session["SecondCoffeeGrind"].ToString();


                string CustomerName = txtCustName.Text;
                Session["CustomerName"] = CustomerName;
                string CustomerEmail = txtCustEmail.Text;
                Session["CustomerEmail"] = CustomerEmail;
                string AddressLine1 = txtAddressLine1.Text;
                string AddressLine2 = txtAddressLine2.Text;
                string Postcode = txtPostcode.Text;
                string TeleNumber = txtNumber.Text;
                string CardNumber = txtCardNumber.Text;
                string NameOnCard = txtNameOnCard.Text;
                string SecurityCode = txtSecurityCode.Text;
                string ExpiryDate = txtExpiryDate.Text;

                decimal first = Decimal.Parse(Price1);
                decimal second = Decimal.Parse(Price2);
                decimal quan = decimal.Parse(Quan1);
                decimal quan2 = decimal.Parse(Quantity2);
                decimal TotalCost1 = first * quan;
                decimal TotalCost2 = second * quan2;
                decimal Del = decimal.Parse(Delivery);
                Session["Delivery"] = Del;
                decimal TotalCost = TotalCost1 + TotalCost2 + Del;
                Session["Total"] = TotalCost;
                decimal FinalCost = 0;
                if (txtDiscountCode.Text == "StudentDiscount")
                {
                    FinalCost = (TotalCost * 0.90m);
                    Session["final"] = FinalCost;
                }

                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                SqlCommand AddRecord = new SqlCommand("INSERT INTO Orders VALUES('" + CustomerName + "',  '" + CustomerEmail + "', '" + AddressLine1 + "', '" + AddressLine2 + "' , '" + Postcode + "',  '" + TeleNumber + "', '" + CoffeeID1 + "', '" + Quan1 + "', '" + Price1 + "', '" + Grind1 + "' , '" + CoffeeID2 + "', '" + Quantity2 + "', '" + Price2 + "', '" + Grind2 + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "',  '" + 2 + "', '" + Delivery + "', '" + FinalCost + "' , '" + CardNumber + "' ,  '" + NameOnCard + "', '" + SecurityCode + "', '" + ExpiryDate + "' , '" + "PAID" + "', '" + date + "')", conn);
                conn.Open();
                AddRecord.ExecuteNonQuery();
                conn.Close();


                string SQLselect = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID1 + "'";
                SqlCommand Find = new SqlCommand();
                Find = new SqlCommand();
                Find.CommandText = SQLselect;
                Find.Connection = conn;
                Find.Connection.Open();
                Find.ExecuteNonQuery();
                SqlDataReader reader = Find.ExecuteReader();
              
                int Quan = 0;
                while (reader.Read())
                {
                    Quan = reader.GetInt32(0);
                }

                Find.Connection.Close();
                int RemainingQuantity = Quan;
                int QuantityBrought = Int32.Parse(Quan1);
                int TotalRemaining = RemainingQuantity - QuantityBrought;

                string sqlStatementUpdate = "UPDATE Coffee SET Quantity = '" + TotalRemaining + "' WHERE CoffeeID = " + CoffeeID1 + ";";
                SqlCommand Update = new SqlCommand();
                Update = new SqlCommand();
                Update.CommandText = sqlStatementUpdate;
                Update.Connection = conn;
                Update.Connection.Open();
                Update.ExecuteNonQuery();
                Update.Connection.Close();

                string SQLselec2t = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID2 + "'";
                SqlCommand Find2 = new SqlCommand();
                Find2 = new SqlCommand();
                Find2.CommandText = SQLselect;
                Find2.Connection = conn;
                Find2.Connection.Open();
                Find2.ExecuteNonQuery();
                SqlDataReader reader2 = Find.ExecuteReader();

                int Quantity = 0;
                while (reader2.Read())
                {
                    Quantity = reader2.GetInt32(0);
                }

                Find.Connection.Close();




                int RemainQuantity = Quan;
                int QB = Int32.Parse(Quan1);
                int TotalLeft = RemainQuantity - QB;

                string sqlStatement = "UPDATE Coffee SET Quantity = '" + TotalLeft + "' WHERE CoffeeID = " + CoffeeID2 + ";";
                SqlCommand Update2 = new SqlCommand();
                Update2 = new SqlCommand();
                Update2.CommandText = sqlStatementUpdate;
                Update2.Connection = conn;
                Update2.Connection.Open();
                Update2.ExecuteNonQuery();
                Update2.Connection.Close();
            }





            if (rows == "3")
            {
                DateTime date = DateTime.Now;

                string CoffeeID1 = Session["FirstCoffeeID"].ToString();
                string Quan1 = Session["FirstCoffeeQuan"].ToString();
                string Price1 = Session["FirstCoffeePrice"].ToString();
                string Grind1 = Session["FirstCoffeeGrind"].ToString();


                string CoffeeID2 = Session["SecondCoffeeID"].ToString();
                string Quantity2 = Session["SecondCoffeeQuan"].ToString();
                string Price2 = Session["SecondCoffeePrice"].ToString();
                string Grind2 = Session["SecondCoffeeGrind"].ToString();

                string CoffeeID3 = Session["ThirdCoffeeID"].ToString();
                string Quantity3 = Session["ThirdCoffeeQuan"].ToString();
                string Price3 = Session["ThirdCoffeePrice"].ToString();
                string Grind3 = Session["ThirdCoffeeGrind"].ToString();


                string CustomerName = txtCustName.Text;
                Session["CustomerName"] = CustomerName;
                string CustomerEmail = txtCustEmail.Text;
                Session["CustomerEmail"] = CustomerEmail;
                string AddressLine1 = txtAddressLine1.Text;
                string AddressLine2 = txtAddressLine2.Text;
                string Postcode = txtPostcode.Text;
                string TeleNumber = txtNumber.Text;
                string CardNumber = txtCardNumber.Text;
                string NameOnCard = txtNameOnCard.Text;
                string SecurityCode = txtSecurityCode.Text;
                string ExpiryDate = txtExpiryDate.Text;


                decimal first = Decimal.Parse(Price1);
                decimal second = Decimal.Parse(Price2);
                decimal third = decimal.Parse(Price3);
                decimal quan = decimal.Parse(Quan1);
                decimal quan2 = decimal.Parse(Quantity2);
                decimal quan3 = decimal.Parse(Quantity3);
                decimal TotalCost1 = first * quan;
                decimal TotalCost2 = second * quan2;
                decimal TotalCost3 = third * quan3;
                decimal Del = decimal.Parse(Delivery);
                Session["Delivery"] = Del;
                decimal TotalCost = TotalCost1 + TotalCost2 + TotalCost3 + Del;
                Session["Total"] = TotalCost;

                decimal FinalCost = 0;
                if (txtDiscountCode.Text == "StudentDiscount")
                {
                    FinalCost = (TotalCost * 0.90m);
                    Session["final"] = FinalCost;
                }


                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                SqlCommand AddRecord = new SqlCommand("INSERT INTO Orders VALUES( '" + CustomerName + "',  '" + CustomerEmail + "', '" + AddressLine1 + "', '" + AddressLine2 + "' , '" + Postcode + "',  '" + TeleNumber + "', '" + CoffeeID1 + "', '" + Quan1 + "', '" + Price1 + "', '" + Grind1 + "' , '" + CoffeeID2 + "', '" + Quantity2 + "', '" + Price2 + "', '" + Grind2 + "' , '" + CoffeeID3 + "', '" + Quantity3 + "', '" + Price3 + "', '" + Grind3 + "' , '" + "" + "', '" + "" + "', '" + "" + "', '" + "" + "',  '" + 3 + "', '" + Delivery + "', '" + FinalCost + "' , '" + CardNumber + "' ,  '" + NameOnCard + "', '" + SecurityCode + "', '" + ExpiryDate + "' , '" + "PAID" + "', '" + date + "')", conn);
                conn.Open();
                AddRecord.ExecuteNonQuery();
                conn.Close();




                string SQLselect = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID1 + "'";
                SqlCommand Find = new SqlCommand();
                Find = new SqlCommand();
                Find.CommandText = SQLselect;
                Find.Connection = conn;
                Find.Connection.Open();
                Find.ExecuteNonQuery();
                SqlDataReader reader = Find.ExecuteReader();

                int Quan = 0;
                while (reader.Read())
                {
                    Quan = reader.GetInt32(0);
                }

                Find.Connection.Close();
                int RemainingQuantity = Quan;
                int QuantityBrought = Int32.Parse(Quan1);
                int TotalRemaining = RemainingQuantity - QuantityBrought;

                string sqlStatementUpdate = "UPDATE Coffee SET Quantity = '" + TotalRemaining + "' WHERE CoffeeID = " + CoffeeID1 + ";";
                SqlCommand Update = new SqlCommand();
                Update = new SqlCommand();
                Update.CommandText = sqlStatementUpdate;
                Update.Connection = conn;
                Update.Connection.Open();
                Update.ExecuteNonQuery();
                Update.Connection.Close();

                string SQLselec2t = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID2 + "'";
                SqlCommand Find2 = new SqlCommand();
                Find2 = new SqlCommand();
                Find2.CommandText = SQLselect;
                Find2.Connection = conn;
                Find2.Connection.Open();
                Find2.ExecuteNonQuery();
                SqlDataReader reader2 = Find.ExecuteReader();

                int Quantity = 0;
                while (reader2.Read())
                {
                    Quantity = reader2.GetInt32(0);
                }

                Find.Connection.Close();




                int RemainQuantity = Quan;
                int QB = Int32.Parse(Quan1);
                int TotalLeft = RemainQuantity - QB;

                string sqlStatement = "UPDATE Coffee SET Quantity = '" + TotalLeft + "' WHERE CoffeeID = " + CoffeeID2 + ";";
                SqlCommand Update2 = new SqlCommand();
                Update2 = new SqlCommand();
                Update2.CommandText = sqlStatementUpdate;
                Update2.Connection = conn;
                Update2.Connection.Open();
                Update2.ExecuteNonQuery();
                Update2.Connection.Close();


                string SQLselect3 = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID3 + "'";
                SqlCommand Find3 = new SqlCommand();
                Find3 = new SqlCommand();
                Find3.CommandText = SQLselect;
                Find3.Connection = conn;
                Find3.Connection.Open();
                Find3.ExecuteNonQuery();
                SqlDataReader reader3 = Find.ExecuteReader();

                int Quantity1 = 0;
                while (reader3.Read())
                {
                    Quantity1 = reader3.GetInt32(0);
                }

                Find.Connection.Close();




                int RQuantity = Quan;
                int QBought = Int32.Parse(Quan1);
                int TL = RQuantity - QBought;

                string sqlStatement1 = "UPDATE Coffee SET Quantity = '" + TL + "' WHERE CoffeeID = " + CoffeeID3 + ";";
                SqlCommand Update3 = new SqlCommand();
                Update3 = new SqlCommand();
                Update3.CommandText = sqlStatementUpdate;
                Update3.Connection = conn;
                Update3.Connection.Open();
                Update3.ExecuteNonQuery();
                Update3.Connection.Close();
            }






        
            if (rows == "4")
            {
                DateTime date = DateTime.Now;

                string CoffeeID1 = Session["FirstCoffeeID"].ToString();
                string Quan1 = Session["FirstCoffeeQuan"].ToString();
                string Price1 = Session["FirstCoffeePrice"].ToString();
                string Grind1 = Session["FirstCoffeeGrind"].ToString();


                string CoffeeID2 = Session["SecondCoffeeID"].ToString();
                string Quantity2 = Session["SecondCoffeeQuan"].ToString();
                string Price2 = Session["SecondCoffeePrice"].ToString();
                string Grind2 = Session["SecondCoffeeGrind"].ToString();

                string CoffeeID3 = Session["ThirdCoffeeID"].ToString();
                string Quantity3 = Session["ThirdCoffeeQuan"].ToString();
                string Price3 = Session["ThirdCoffeePrice"].ToString();
                string Grind3 = Session["ThirdCoffeeGrind"].ToString();

                string CoffeeID4 = Session["FourthCoffeeID"].ToString();
                string Quantity4 = Session["FourthCoffeeQuan"].ToString();
                string Price4 = Session["FourthCoffeePrice"].ToString();
                string Grind4 = Session["FourthCoffeeGrind"].ToString();

                string CustomerName = txtCustName.Text;
                Session["CustomerName"] = CustomerName;
                string CustomerEmail = txtCustEmail.Text;
                Session["CustomerEmail"] = CustomerEmail;
                string AddressLine1 = txtAddressLine1.Text;
                string AddressLine2 = txtAddressLine2.Text;
                string Postcode = txtPostcode.Text;
                string TeleNumber = txtNumber.Text;
                string CardNumber = txtCardNumber.Text;
                string NameOnCard = txtNameOnCard.Text;
                string SecurityCode = txtSecurityCode.Text;
                string ExpiryDate = txtExpiryDate.Text;


                decimal first = Decimal.Parse(Price1);
                decimal second = Decimal.Parse(Price2);
                decimal third = decimal.Parse(Price3);
                decimal forth = decimal.Parse(Price4);
                decimal quan = decimal.Parse(Quan1);
                decimal quan2 = decimal.Parse(Quantity2);
                decimal quan3 = decimal.Parse(Quantity3);
                decimal quan4 = decimal.Parse(Quantity4);
                decimal TotalCost1 = first * quan;
                decimal TotalCost2 = second * quan2;
                decimal TotalCost3 = third * quan3;
                decimal TotalCost4 = forth * quan4;
                decimal Del = decimal.Parse(Delivery);
                Session["Delivery"] = Del;
                decimal TotalCost = TotalCost1 + TotalCost2 + TotalCost3 + TotalCost4 + Del;
                Session["Total"] = TotalCost;

                decimal FinalCost = 0;
                if (txtDiscountCode.Text == "StudentDiscount")
                {
                    FinalCost = (TotalCost * 0.90m);
                    Session["final"] = FinalCost;
                }


                SqlConnection conn = new SqlConnection(@"Data Source=ELITEBOOK745\sqlexpress;Initial Catalog=CoffeeShop;Integrated Security=True;Pooling=False");
                SqlCommand AddRecord = new SqlCommand("INSERT INTO Orders VALUES('" + CustomerName + "',  '" + CustomerEmail + "', '" + AddressLine1 + "', '" + AddressLine2 + "' , '" + Postcode + "',  '" + TeleNumber + "', '" + CoffeeID1 + "', '" + Quan1 + "', '" + Price1 + "', '" + Grind1 + "' , '" + CoffeeID2 + "', '" + Quantity2 + "', '" + Price2 + "', '" + Grind2 + "' , '" + CoffeeID3 + "', '" + Quantity3 + "', '" + Price3 + "', '" + Grind3 + "' , '" + CoffeeID4 + "', '" + Quantity4 + "', '" + Price4 + "', '" + Grind4 + "',  '" + 4 + "', '" + Delivery + "', '" + FinalCost + "' , '" + CardNumber + "' ,  '" + NameOnCard + "', '" + SecurityCode + "', '" + ExpiryDate + "' , '" + "PAID" + "', '" + date + "')", conn);
                conn.Open();
                AddRecord.ExecuteNonQuery();
                conn.Close();



                string SQLselect = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID1 + "'";
                SqlCommand Find = new SqlCommand();
                Find = new SqlCommand();
                Find.CommandText = SQLselect;
                Find.Connection = conn;
                Find.Connection.Open();
                Find.ExecuteNonQuery();
                SqlDataReader reader = Find.ExecuteReader();

                int Quan = 0;
                while (reader.Read())
                {
                    Quan = reader.GetInt32(0);
                }

                Find.Connection.Close();
                int RemainingQuantity = Quan;
                int QuantityBrought = Int32.Parse(Quan1);
                int TotalRemaining = RemainingQuantity - QuantityBrought;

                string sqlStatementUpdate = "UPDATE Coffee SET Quantity = '" + TotalRemaining + "' WHERE CoffeeID = " + CoffeeID1 + ";";
                SqlCommand Update = new SqlCommand();
                Update = new SqlCommand();
                Update.CommandText = sqlStatementUpdate;
                Update.Connection = conn;
                Update.Connection.Open();
                Update.ExecuteNonQuery();
                Update.Connection.Close();

                string SQLselec2t = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID2 + "'";
                SqlCommand Find2 = new SqlCommand();
                Find2 = new SqlCommand();
                Find2.CommandText = SQLselect;
                Find2.Connection = conn;
                Find2.Connection.Open();
                Find2.ExecuteNonQuery();
                SqlDataReader reader2 = Find.ExecuteReader();

                int Quantity = 0;
                while (reader2.Read())
                {
                    Quantity = reader2.GetInt32(0);
                }

                Find.Connection.Close();




                int RemainQuantity = Quan;
                int QB = Int32.Parse(Quan1);
                int TotalLeft = RemainQuantity - QB;

                string sqlStatement = "UPDATE Coffee SET Quantity = '" + TotalLeft + "' WHERE CoffeeID = " + CoffeeID2 + ";";
                SqlCommand Update2 = new SqlCommand();
                Update2 = new SqlCommand();
                Update2.CommandText = sqlStatementUpdate;
                Update2.Connection = conn;
                Update2.Connection.Open();
                Update2.ExecuteNonQuery();
                Update2.Connection.Close();


                string SQLselect3 = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID3 + "'";
                SqlCommand Find3 = new SqlCommand();
                Find3 = new SqlCommand();
                Find3.CommandText = SQLselect;
                Find3.Connection = conn;
                Find3.Connection.Open();
                Find3.ExecuteNonQuery();
                SqlDataReader reader3 = Find.ExecuteReader();

                int Quantity1 = 0;
                while (reader3.Read())
                {
                    Quantity1 = reader3.GetInt32(0);
                }

                Find.Connection.Close();




                int RQuantity = Quan;
                int QBought = Int32.Parse(Quan1);
                int TL = RQuantity - QBought;

                string sqlStatement1 = "UPDATE Coffee SET Quantity = '" + TL + "' WHERE CoffeeID = " + CoffeeID3 + ";";
                SqlCommand Update3 = new SqlCommand();
                Update3 = new SqlCommand();
                Update3.CommandText = sqlStatementUpdate;
                Update3.Connection = conn;
                Update3.Connection.Open();
                Update3.ExecuteNonQuery();
                Update3.Connection.Close();


                string SQLselect4 = "SELECT Quantity FROM Coffee WHERE CoffeeID LIKE '" + CoffeeID3 + "'";
                SqlCommand Find4 = new SqlCommand();
                Find4 = new SqlCommand();
                Find4.CommandText = SQLselect;
                Find4.Connection = conn;
                Find4.Connection.Open();
                Find4.ExecuteNonQuery();
                SqlDataReader reader4 = Find.ExecuteReader();

                int Qu = 0;
                while (reader4.Read())
                {
                    Qu = reader4.GetInt32(0);
                }

                Find.Connection.Close();




                int RQuan = Quan;
                int purchased = Int32.Parse(Quan1);
                int TLeft = RQuan - purchased;

                string sqlStatement2 = "UPDATE Coffee SET Quantity = '" + TLeft + "' WHERE CoffeeID = " + CoffeeID3 + ";";
                SqlCommand Update4 = new SqlCommand();
                Update4 = new SqlCommand();
                Update4.CommandText = sqlStatementUpdate;
                Update4.Connection = conn;
                Update4.Connection.Open();
                Update4.ExecuteNonQuery();
                Update4.Connection.Close();

            }
            Response.Redirect("OrderConfirmation.aspx");


           
        }
    }
}