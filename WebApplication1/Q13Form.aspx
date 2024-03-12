<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Q13Form.aspx.cs" Inherits="WebApplication1.Q13Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Enter book details: </h1>
    <label>ISBN: 
        <asp:TextBox ID="ISBN" runat="server" />
    </label>
    <label>Title: 
        <asp:TextBox ID="BookTitle" runat="server" />
    </label>
    <label>Author: 
        <asp:TextBox ID="Author" runat="server" />
    </label>
    <label>Price: 
        <asp:TextBox ID="Price" runat="server" />
    </label>
    <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_OnClick" />
</asp:Content>

