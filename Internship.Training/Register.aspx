<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Internship.Training.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-4">
    <h2>Register</h2>
    
        <div class="mb-3 mt-3">
            <label>Name:</label>
            
            <asp:TextBox  runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
            
        </div>
        
        <div class="mb-3 mt-3">
            <label>Contact:</label>
            <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" ID="txtContact"></asp:TextBox>
        </div>
        
        <div class="mb-3 mt-3">
            <label>Email:</label>
            <asp:TextBox runat="server" TextMode="Email" CssClass="form-control" ID="txtEmail"></asp:TextBox>
        </div>
        
        <div class="mb-3 mt-3">
            <label>DOB:</label>
            <asp:TextBox runat="server" TextMode="Date" CssClass="form-control" ID="txtDOB"></asp:TextBox>
        </div>
        
        <div class="mb-3 mt-3">
            <label>Address:</label>
            <asp:TextBox runat="server" TextMode="MultiLine" CssClass="form-control" ID="txtAddress"></asp:TextBox>
        </div>
        
        <div class="mb-3 mt-3">
            <label>City:</label>
            <asp:DropDownList ID="ddlCities" CssClass="form-control" runat="server">
                <asp:ListItem>Select City</asp:ListItem>
                <asp:ListItem>Kolhapur</asp:ListItem>
                <asp:ListItem>Mumbai</asp:ListItem>
                <asp:ListItem>Delhi</asp:ListItem>
                <asp:ListItem>Pune</asp:ListItem>
            </asp:DropDownList>
        </div>
        <asp:Button runat="server" CssClass="btn btn-outline-success" Text="Submit" ID="btnSumbit" />
        
  
</div>
</asp:Content>
