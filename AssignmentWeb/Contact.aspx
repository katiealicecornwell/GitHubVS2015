<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="AssignmentWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Contact page.</h3>
    <address>
       29a Seathwaite Road<br />
        Kings Lynn Norfolk PE30 3UW<br />
        <abbr title="Phone">P:</abbr>
        07584677862
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@KatiesCoffee.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">KatiesCoffee@hotmail.com</a>
    </address>
</asp:Content>
