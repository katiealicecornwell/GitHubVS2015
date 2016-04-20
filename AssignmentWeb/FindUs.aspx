<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FindUs.aspx.cs" Inherits="AssignmentWeb.FindUs"%>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
</p>
<p>
    <asp:Label ID="Label1" runat="server" Text="Find Your Nearest Store:"></asp:Label>
</p>
<asp:Label ID="Label2" runat="server" Text="Please Enter Your Postcode:"></asp:Label>
<asp:TextBox ID="txtPostcode" runat="server"></asp:TextBox>
<p>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find Us" />
</p>
    <asp:Label ID="Label4" runat="server" Text="Distance In Miles:"></asp:Label>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
<p>
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
    <script src="http://maps.googleapis.com/maps/api/js"></script>
<script>
    var myCenter = new google.maps.LatLng(52.572799, -0.242634);

function initialize()
{
var mapProp = {
  center:myCenter,
  zoom:5,
  mapTypeId:google.maps.MapTypeId.ROADMAP
  };

var map=new google.maps.Map(document.getElementById("googleMap"),mapProp);

var marker=new google.maps.Marker({
  position:myCenter,
  });

marker.setMap(map);


var infowindow = new google.maps.InfoWindow({
    content:"Opening Times: Monday 9-5, Tuesday 9-5, Wednesday 9-5, Thursday 9-7, Friday 9-5, Saturday 9-4"
});

infowindow.open(map,marker);
}

google.maps.event.addDomListener(window, 'load', initialize);
</script>


    <div id="googleMap" style="width:500px;height:380px;"></div>

</asp:Content>
