<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Drivers.aspx.cs" Inherits="POEPART3.Drivers" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Driver</title>
</head>
    
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Drivers</h1>
        <asp:Button ID="btnRead" runat="server" OnClick="btnRead_Click" Text="Read" Width="60px" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" Width="60px" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" Width="60px" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="60px" />
         <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat ="server"></asp:GridView>
            </div>
        <asp:Label ID="Label1" runat="server" Text="Driver Id" Width="150px"></asp:Label>
        <asp:TextBox ID="txtDriverID" runat="server" Width="125px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="First Name" Width="150px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="Label2" runat="server" Text="Last Name" Width="150px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Width="125px"></asp:TextBox>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Adress" Width="150px"></asp:Label>
            <asp:TextBox ID="txtAdress" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="Label5" runat="server" Text="Email" Width="150px"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" Width="125px"></asp:TextBox>
        <p>
            <asp:Label ID="Label6" runat="server" Text="Phone Number" Width="150px"></asp:Label>
            <asp:TextBox ID="txtPhoneNumber" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="lblComplete" runat="server"></asp:Label>
        <p>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" Width="65px" />
        </p>
    </form>

    
</body>
    
</html>
