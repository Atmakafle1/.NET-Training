<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="MenuPage.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1>Home</h1>
        <h3>Picture:</h3>
<asp:Image ID="imgGarden" runat="server"
ImageUrl="~/Images/bw.jpg" width="600px" Height="400px" /><br />
        <h4>This is a home page with picture and little description. </h4>
    </div>
</asp:Content>
