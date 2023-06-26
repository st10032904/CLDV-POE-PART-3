<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="POEPART3.Main" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Home</h1>
            <p>Please select an option</p>        
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cars" Width="65px" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Drivers" Width="65px" />
        <asp:Button ID="btnInspector" runat="server" OnClick="btnInspector_Click" Text="Inspectors" Width="65px" />
        <asp:Button ID="btnRental" runat="server" OnClick="btnRental_Click" Text="Rental" Width="65px" />
        <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return" Width="65px" />
        <asp:Button ID="btnHelp" runat="server" OnClick="btnHelp_Click" Text="Help" Width="65px" />
    </form>
</body>
</html>
