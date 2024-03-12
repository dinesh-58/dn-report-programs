<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Q13Table.aspx.cs" Inherits="WebApplication1.Q13Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Table runat="server" border="1">
        <asp:TableRow >
            <asp:TableHeaderCell runat="server" >ISBN</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" >Title</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" >Author</asp:TableHeaderCell>
            <asp:TableHeaderCell runat="server" >Price</asp:TableHeaderCell>
        </asp:TableRow>
        <asp:TableRow >
            <asp:TableCell runat="server" ID="TableISBN"></asp:TableCell>
            <asp:TableCell runat="server" ID="TableTitle"></asp:TableCell>
            <asp:TableCell runat="server" ID="TableAuthor"></asp:TableCell>
            <asp:TableCell runat="server" ID="TablePrice"></asp:TableCell>
        </asp:TableRow>
    </asp:Table>

    <asp:Label runat="server" ID="TestLabel" ></asp:Label>
</asp:Content>
