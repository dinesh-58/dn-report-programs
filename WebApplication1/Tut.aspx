<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tut.aspx.cs" Inherits="WebApplication1.Tut" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label" runat="server"/>
    <br />
    Name: <asp:TextBox ID="TextBox" runat="server"/>
    <asp:Button ID="Btn" Text="Say Hello" runat="server" OnClick="SayHello"/>
    <asp:DropDownList runat="server" ID="GreetList" AutoPostBack="true" OnSelectedIndexChanged="GreetList_SelectedIndexChanged">

        <asp:ListItem Value="no one">No one</asp:ListItem>
        <asp:ListItem Value="world">World</asp:ListItem>
        <asp:ListItem value="universe">Universe</asp:ListItem>
    </asp:DropDownList>

    <asp:Label ID="TestingLabel" runat="server" />
</asp:Content>
