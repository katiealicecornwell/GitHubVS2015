using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace AssignmentWeb
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string CoffeeID = GridView1.Rows[0].Cells[0].Text;


            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            SqlCommand cmd = new SqlCommand("Delete * From Cart WHERE CoffeeID = '" + CoffeeID + "'");
            GridView1.DataBind();
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
        
           
            int rows = GridView1.Rows.Count;
            Session["Rows"] = rows;

            if (rows == 1)
            {
                string CoffeeID1 = GridView1.Rows[0].Cells[0].Text;
                string Quantity1 = GridView1.Rows[0].Cells[2].Text;
                string Price1 = GridView1.Rows[0].Cells[3].Text;
                string Grind1 = GridView1.Rows[0].Cells[4].Text;

                Session["FirstCoffeeID"] = CoffeeID1;
                Session["FirstCoffeeQuan"] = Quantity1;
                Session["FirstCoffeePrice"] = Price1;
                Session["FirstCoffeeGrind"] = Grind1;


                var CoffeeID2 = "";
                var Quantity2 = "";
                var Price2 = "";
                var Grind2 = "";

                var CoffeeID3 = "";
                //var CoffeeName3 = "";
                var Quantity3 = "";
                var Price3 = "";
                var Grind3 = "";

                var CoffeeID4 = "";
                var Quantity4 = "";
                var Price4 = "";
                var Grind4 = "";

            }

            if (rows == 2)
            {
                var CoffeeID1 = GridView1.Rows[0].Cells[0].Text;
                var Quantity1 = GridView1.Rows[0].Cells[2].Text;
                var Price1 = GridView1.Rows[0].Cells[3].Text;
                var Grind1 = GridView1.Rows[0].Cells[4].Text;

                    var CoffeeID2 = GridView1.Rows[1].Cells[0].Text;
                    var Quantity2 = GridView1.Rows[1].Cells[2].Text;
                    var Price2 = GridView1.Rows[1].Cells[3].Text;
                    var Grind2 = GridView1.Rows[1].Cells[4].Text;
                Session["FirstCoffeeID"] = CoffeeID1;
                Session["FirstCoffeeQuan"] = Quantity1;
                Session["FirstCoffeePrice"] = Price1;
                Session["FirstCoffeeGrind"] = Grind1;

                Session["SecondCoffeeID"] = CoffeeID2;
                Session["SecondCoffeeQuan"] = Quantity2;
                Session["SecondCoffeePrice"] = Price2;
                Session["SecondCoffeeGrind"] = Grind2;


                var CoffeeID3 = "";
                var Quantity3 = "";
                var Price3 = "";
                var Grind3 = "";

                var CoffeeID4 = "";
                var Quantity4 = "";
                var Price4 = "";
                var Grind4 = "";
            }


            if (rows == 3)
            {

                var CoffeeID1 = GridView1.Rows[0].Cells[0].Text;
                var Quantity1 = GridView1.Rows[0].Cells[2].Text;
                var Price1 = GridView1.Rows[0].Cells[3].Text;
                var Grind1 = GridView1.Rows[0].Cells[4].Text;

                var CoffeeID2 = GridView1.Rows[1].Cells[0].Text;
                var Quantity2 = GridView1.Rows[1].Cells[2].Text;
                var Price2 = GridView1.Rows[1].Cells[3].Text;
                var Grind2 = GridView1.Rows[1].Cells[4].Text;

                var CoffeeID3 = GridView1.Rows[2].Cells[0].Text;
                    var Quantity3 = GridView1.Rows[2].Cells[2].Text;
                    var Price3 = GridView1.Rows[2].Cells[3].Text;
                    var Grind3 = GridView1.Rows[2].Cells[4].Text;
                Session["FirstCoffeeID"] = CoffeeID1;
                Session["FirstCoffeeQuan"] = Quantity1;
                Session["FirstCoffeePrice"] = Price1;
                Session["FirstCoffeeGrind"] = Grind1;

                Session["SecondCoffeeID"] = CoffeeID2;
                Session["SecondCoffeeQuan"] = Quantity2;
                Session["SecondCoffeePrice"] = Price2;
                Session["SecondCoffeeGrind"] = Grind2;

                Session["ThirdCoffeeID"] = CoffeeID3;
                Session["ThirdCoffeeQuan"] = Quantity3;
                Session["ThirdCoffeePrice"] = Price3;
                Session["ThirdCoffeeGrind"] = Grind3;

                var CoffeeID4 = "";
                var Quantity4 = "";
                var Price4 = "";
                var Grind4 = "";


            }

            if (rows == 4)
            {

                var CoffeeID1 = GridView1.Rows[0].Cells[0].Text;
                var Quantity1 = GridView1.Rows[0].Cells[2].Text;
                var Price1 = GridView1.Rows[0].Cells[3].Text;
                var Grind1 = GridView1.Rows[0].Cells[4].Text;

                var CoffeeID2 = GridView1.Rows[1].Cells[0].Text;
                var Quantity2 = GridView1.Rows[1].Cells[2].Text;
                var Price2 = GridView1.Rows[1].Cells[3].Text;
                var Grind2 = GridView1.Rows[1].Cells[4].Text;

                var CoffeeID3 = GridView1.Rows[2].Cells[0].Text;
                var Quantity3 = GridView1.Rows[2].Cells[2].Text;
                var Price3 = GridView1.Rows[2].Cells[3].Text;
                var Grind3 = GridView1.Rows[2].Cells[4].Text;

                var CoffeeID4 = GridView1.Rows[3].Cells[0].Text;
                var Quantity4 = GridView1.Rows[3].Cells[2].Text;
                var Price4 = GridView1.Rows[3].Cells[3].Text;
                var Grind4 = GridView1.Rows[3].Cells[4].Text;
                Session["FirstCoffeeID"] = CoffeeID1;
                Session["FirstCoffeeQuan"] = Quantity1;
                Session["FirstCoffeePrice"] = Price1;
                Session["FirstCoffeeGrind"] = Grind1;

                Session["SecondCoffeeID"] = CoffeeID2;
                Session["SecondCoffeeQuan"] = Quantity2;
                Session["SecondCoffeePrice"] = Price2;
                Session["SecondCoffeeGrind"] = Grind2;

                Session["ThirdCoffeeID"] = CoffeeID3;
                Session["ThirdCoffeeQuan"] = Quantity3;
                Session["ThirdCoffeePrice"] = Price3;
                Session["ThirdCoffeeGrind"] = Grind3;

                Session["FourthCoffeeID"] = CoffeeID4;
                Session["FourthCoffeeQuan"] = Quantity4;
                Session["FourthCoffeePrice"] = Price4;
                Session["FourthCoffeeGrind"] = Grind4;


            }



          
            Response.Redirect("Purchase.aspx");









        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}