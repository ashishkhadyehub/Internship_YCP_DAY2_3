<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Internship.Training.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Webform</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-3">
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
    </form>
</body>
</html>
