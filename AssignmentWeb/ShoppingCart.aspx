<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="AssignmentWeb.ShoppingCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="CoffeeID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="CoffeeID" HeaderText="CoffeeID" ReadOnly="True" SortExpression="CoffeeID" />
                <asp:BoundField DataField="CoffeeName" HeaderText="CoffeeName" SortExpression="CoffeeName" ReadOnly="True" />
                <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" ReadOnly="false"/>
                <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" ReadOnly="True" />
                <asp:BoundField DataField="Grind" HeaderText="Grind" SortExpression="Grind" ReadOnly="True" />
                <asp:CommandField DeleteText="Remove" ShowDeleteButton="True"></asp:CommandField>
                <asp:CommandField EditText="Edit" ShowEditButton="True"></asp:CommandField>
                 
            </Columns>
        </asp:GridView>

    
    </p>


    <p>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CoffeeShopConnectionString %>" 
            SelectCommand="SELECT * FROM [Cart]"
             DeleteCommand="DELETE FROM [Cart] WHERE [CoffeeID]=@CoffeeID;"
            UpdateCommand="UPDATE [Cart] SET [Quantity]=@Quantity WHERE [CoffeeID]=@CoffeeID;"
            >
    <DeleteParameters>
         <asp:Parameter Name="CoffeeID" Type="string" />
    </DeleteParameters></asp:SqlDataSource>
    </p>
    <p>
        <asp:Button ID="btnBuy" runat="server" Text="Checkout" OnClick="btnBuy_Click" />
    </p>
</asp:Content>
