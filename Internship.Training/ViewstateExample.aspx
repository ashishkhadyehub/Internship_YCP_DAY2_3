<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="ViewstateExample.aspx.cs" Inherits="Internship.Training.ViewstateExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
        <h3>ViewState Example</h3>
    <asp:TextBox runat="server" ID="txtcount"></asp:TextBox>
    <asp:Button runat="server"  OnClick="btnclick_Click" Text="Click" ID="btnclick"   />
    </div>
</asp:Content>
