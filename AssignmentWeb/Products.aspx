<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Products.aspx.cs" Inherits="AssignmentWeb.Products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CoffeeID" DataSourceID="SqlDataSource2" Width="536px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting ="true">
    <Columns>
        <asp:BoundField DataField="CoffeeID" HeaderText="CoffeeID" ReadOnly="True" />
        <asp:BoundField DataField="CoffeeName" HeaderText="CoffeeName" />
        <asp:BoundField DataField="Strength" HeaderText="Strength" SortExpression="Strength" />
        <asp:BoundField DataField="Grind" HeaderText="Grind" />
        <asp:BoundField DataField="Origin" HeaderText="Origin" SortExpression="Origin" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />

        
                <asp:HyperLinkField HeaderText="View" DataTextField="CoffeeName" DataNavigateUrlFields="CoffeeID"
                    DataNavigateUrlFormatString="ViewDetails.aspx?record={0} " />
                


    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeShopConnectionString %>" SelectCommand="SELECT * FROM [Coffee]"></asp:SqlDataSource>



</asp:Content>
