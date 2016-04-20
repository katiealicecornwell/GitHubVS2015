using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMaps.LocationServices;
using GeoCoordinatePortable;

namespace AssignmentWeb
{
    public partial class FindUs : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            var address = Convert.ToString(txtPostcode.Text);
            var address2 = Convert.ToString("PE11YD");

            var locationService = new GoogleLocationService();
            var point = locationService.GetLatLongFromAddress(address);

            var locationService2 = new GoogleLocationService();
            var point2 = locationService.GetLatLongFromAddress(address2);

            var latitude = point.Latitude;
            var longitude = point.Longitude;

            var latitude2 = point2.Latitude;
            var longitude2 = point2.Longitude;


            var locA = new GeoCoordinate(latitude, longitude);
            var locB = new GeoCoordinate(latitude2, longitude2);
            double distance = locA.GetDistanceTo(locB);


            double miles = distance / 1609.344;
            Label3.Text = Convert.ToString(miles);

        }
    }
}