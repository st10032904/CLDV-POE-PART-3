<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Return.aspx.cs" Inherits="POEPART3.Return" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Return</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Returns</h1>
        </div>
        <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" Width="60px" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="60px" />
        <asp:Button ID="btnLateFees" runat="server" OnClick="btnLateFees_Click" Text="Fees" Width="60px" />
        <br />
        <br />
         <asp:GridView ID="GridView1" runat ="server"></asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="rental ID" Width="100px"></asp:Label>
        <asp:TextBox ID="txtRentalID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Return Date" Width="100px"></asp:Label>
            <asp:TextBox ID="txtReturnDate" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Days Over" Width="100px"></asp:Label>
            <asp:TextBox ID="txtDaysOver" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblComplete" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="65px" />
        </p>
    </form>
</body>
</html>
