<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewDetails.aspx.cs" Inherits="AssignmentWeb.ViewDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
               <AnnoymousTemplate>          
    <p>
        <br />
    </p>
                    <%--<asp:Label ID="lblno2" runat="server" Text="LoggedOut"></asp:Label>--%>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Coffee ID:"></asp:Label>
        <asp:Label ID="lblCoffeeID" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Coffee Name:"></asp:Label>
        <asp:Label ID="lblCoffeeName" runat="server"></asp:Label>
    </p> 
    <p>
        <asp:Label ID="Label4" runat="server" Text="Strength: "></asp:Label>
        <asp:Label ID="lblStrength" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Origin:"></asp:Label>
        <asp:Label ID="lblOrigin" runat="server"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblEnterEmail" runat="server" Text="Enter Email" Visible="False"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Visible="False"></asp:TextBox>
        <asp:Button ID="btnEmailMe" runat="server" Text="Email Me When Back In Stock" Visible="False" OnClick="btnEmailMe_Click" />
    </p>
               <asp:Label ID="Label6" runat="server" Text="Price:"></asp:Label>
        <asp:Label ID="lblPrice" runat="server"></asp:Label>
    <p>
       
                    <asp:Label ID="Label7" runat="server" Text="Stock Level:"></asp:Label>
       
                    <asp:Label ID="lblno2" runat="server"></asp:Label>
       
    </p>
               <p>
       
                    &nbsp;</p>
               <p>
    &nbsp;&nbsp;<asp:Image ID="Image1" runat="server" Height="70px" Width="70px" />
                   &nbsp;&nbsp;
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
    &nbsp;&nbsp;<asp:Label ID="Label8" runat="server" Text="Description:"></asp:Label>
    <asp:Label ID="lblDescription" runat="server" Text="Label"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:DropDownList ID="DDGrind" AutoPostBack="true" runat="server" OnSelectedIndexChanged="DDGRind_Change">
            <asp:ListItem>Instant</asp:ListItem>
            <asp:ListItem Value="WholeBean">Whole Bean</asp:ListItem>
        </asp:DropDownList>
    </p>

    <asp:Button ID="btnBuy" runat="server" Text="Add To Cart" Visible="false" OnClick="btnBuy_Click"/>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblThankYou" runat="server"></asp:Label>
    <p>
        <asp:Label ID="lblStock" runat="server" Visible ="true"></asp:Label>
       

       </AnnoymousTemplate>

        <asp:LoginView runat="server">
                        
                        <LoggedInTemplate>
                           
                                <br />
                           <%--  <asp:Label ID="lblInStock" runat="server"></asp:Label>--%>
                            <asp:Label ID="lblno2" runat="server"></asp:Label>
                                  
                            <br />

                          <% if (lblno2.Text != "0") %>
                            <%{ %>
                                    <asp:Button ID="btnBuy" runat="server" Text="Add To Cart" Visible="true" OnClick="btnBuy_Click" AutoPostBack="True" />
                                <%   } %>

                                                                    
                        
                             
           
                            <br />

               <%--            <%} %> --%>

                        </LoggedInTemplate>
                    </asp:LoginView>
        

</asp:Content>
