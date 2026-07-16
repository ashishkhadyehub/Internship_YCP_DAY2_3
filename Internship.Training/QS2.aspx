<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="QS2.aspx.cs" Inherits="Internship.Training.QS2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <div class="container mt-3">
    <h2>Confirm Details</h2>
    
        <div class="mb-3 mt-3">
            <label>Name:</label>
            
            <asp:TextBox  runat="server" CssClass="form-control" ID="txtName"></asp:TextBox>
            
        </div>
        
        <div class="mb-3 mt-3">
            <label>Contact:</label>
            <asp:TextBox runat="server" TextMode="Number" CssClass="form-control" ID="txtContact"></asp:TextBox>
        </div>
        
      
        
        
  
</div>
</asp:Content>
