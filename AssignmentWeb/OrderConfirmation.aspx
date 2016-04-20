<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OrderConfirmation.aspx.cs" Inherits="AssignmentWeb.OrderConfirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Thank You, "></asp:Label>
        <asp:Label ID="lblName" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Your Purchases:"></asp:Label>
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2" AllowCustomPaging="True" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="1">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" InsertVisible="False" ReadOnly="True" />
                <asp:BoundField DataField="CoffeeID1" HeaderText="CoffeeID1" SortExpression="CoffeeID1" />
                <asp:BoundField DataField="Quantity1" HeaderText="Quantity1" SortExpression="Quantity1" />
                <asp:BoundField DataField="Price1" HeaderText="Price1" SortExpression="Price1" />
                <asp:BoundField DataField="Grind1" HeaderText="Grind1" SortExpression="Grind1" />
                <asp:BoundField DataField="Price2" HeaderText="Price2" SortExpression="Price2" />
                <asp:BoundField DataField="Quantity2" HeaderText="Quantity2" SortExpression="Quantity2" />
                <asp:BoundField DataField="CoffeeID2" HeaderText="CoffeeID2" SortExpression="CoffeeID2" />
                <asp:BoundField DataField="Grind2" HeaderText="Grind2" SortExpression="Grind2" />
                <asp:BoundField DataField="CoffeeID3" HeaderText="CoffeeID3" SortExpression="CoffeeID3" />
                <asp:BoundField DataField="Quantity3" HeaderText="Quantity3" SortExpression="Quantity3" />
                <asp:BoundField DataField="Price3" HeaderText="Price3" SortExpression="Price3" />
                <asp:BoundField DataField="Grind3" HeaderText="Grind3" SortExpression="Grind3" />
                <asp:BoundField DataField="CoffeeID4" HeaderText="CoffeeID4" SortExpression="CoffeeID4" />
                <asp:BoundField DataField="Quantity4" HeaderText="Quantity4" SortExpression="Quantity4" />
                <asp:BoundField DataField="Price4" HeaderText="Price4" SortExpression="Price4" />
                <asp:BoundField DataField="Grind4" HeaderText="Grind4" SortExpression="Grind4" />
                <asp:BoundField DataField="OrderDateTime" HeaderText="OrderDateTime" SortExpression="OrderDateTime" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeShopConnectionString %>" SelectCommand="SELECT [Id], [CoffeeID1], [Quantity1], [Price1], [Grind1], [Price2], [Quantity2], [CoffeeID2], [Grind2], [CoffeeID3], [Quantity3], [Price3], [Grind3], [CoffeeID4], [Quantity4], [Price4], [Grind4], [OrderDateTime] FROM [Orders] ORDER BY [Id] DESC"></asp:SqlDataSource>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Order Number:"></asp:Label>
        <asp:Label ID="lblOrderNum" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label runat="server" Text="Delivery Cost:"></asp:Label>
        <asp:Label ID="lblDelivery" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Total Order Cost:"></asp:Label>
        <asp:Label ID="lblTotalCost" runat="server"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        
        <asp:Button ID="printButton" runat="server" Text="Print Confirmation" OnClientClick="javascript:window.print();" OnClick="printButton_Click" />
    </p>
    <p>
        
        &nbsp;</p>
</asp:Content>
