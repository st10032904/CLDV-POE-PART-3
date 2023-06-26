<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rental.aspx.cs" Inherits="POEPART3.Rental" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rental</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Rental</h1>
        </div>
        <asp:Button ID="btnRead" runat="server" OnClick="BtnRead_Click" Text="Read" Width="60px" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" Width="60px" OnClick="btnInsert_Click" />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat ="server"></asp:GridView>
        <br />
            
           
        <asp:Label ID="Label1" runat="server" Text="rentalID" Width="150px"></asp:Label>
        <asp:TextBox ID="txtRentalID" runat="server"></asp:TextBox>
        <p>
            
            <asp:Label ID="Label2" runat="server" Text="Car Number" Width="150px"></asp:Label>
            <asp:TextBox ID="txtCarNumber" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label3" runat="server" Text="Inspector ID" Width="150px"></asp:Label>
        <asp:TextBox ID="txtInspectorID" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Driver ID" Width="150px"></asp:Label>
            <asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Rental Fee" Width="150px"></asp:Label>
            <asp:TextBox ID="txtRentalFee" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="Label6" runat="server" Text="Start Date" Width="150px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Label7" runat="server" Text="End Date" Width="150px"></asp:Label>
            <asp:TextBox ID="txtEndDate" runat="server"></asp:TextBox>
        </p>
        <asp:Label ID="lblComplete" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="65px" />
        </p>
    </form>
</body>
</html>
