<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="IsPostBackExample.aspx.cs" Inherits="Internship.Training.IsPostBackExample" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container" style="margin-top:50px">
            <h3>IsPostBack Example</h3>
        <asp:Button runat="server"  ID="btnrefresh" Text="Postback Request" />
            <br />
            <asp:DropDownList runat="server" style="margin-top:15px" ID="ddlcity">

            </asp:DropDownList>
        </div>
</asp:Content>
