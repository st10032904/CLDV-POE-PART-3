<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="POEPART3.Login" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body style="height: 711px">
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <p>Welcome to The Ride You Rent</p>
        </div>
        <br />
        
        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" Width="60px" />
        <asp:Button ID="btnExit" runat="server" Text="Exit" Width="60px" />
        <p>
            <asp:Label ID="lblComplete" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
