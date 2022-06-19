<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication6.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />


    <asp:CheckBox ID="CheckBox1" runat="server" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />


</asp:Content>
