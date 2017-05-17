<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="LPP.APP.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LPP - SignIn</title>
</head>
<body>
    <form id="frmSignIn" runat="server">
        <div>
            <asp:Label ID="lblUserID" runat="server" Text="User ID:-"></asp:Label>
            <asp:TextBox ID="txtUserID" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <asp:Button ID="btnSignIn" runat="server" Text="SignIn" OnClick="btnSignIn_Click" />
        </div>
    </form>
</body>
</html>