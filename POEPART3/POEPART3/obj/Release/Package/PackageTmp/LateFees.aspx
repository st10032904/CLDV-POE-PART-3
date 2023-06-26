<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LateFees.aspx.cs" Inherits="POEPART3.LateFees" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Fees</h1>
            <asp:Button ID="btnGetFees" runat="server" Text="Calculate Fees" Width="100px" OnClick="btnGetFees_Click" />
            <br />
            <asp:GridView ID="GridView1" runat ="server"></asp:GridView>

            <br />

        </div>
        <asp:Label ID="Label1" runat="server" Text="Rental ID" Width="150px"></asp:Label>
        <asp:TextBox ID="txtRentalID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Days Over" Width="150px"></asp:Label>
            <asp:TextBox ID="txtDaysOver" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Fees" Width="150px"></asp:Label>
        <asp:TextBox ID="txtFees" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblComplete" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnBack" runat="server" OnClick="btnHome_Click" Text="Back" Width="65px" />
    </form>
</body>
</html>
