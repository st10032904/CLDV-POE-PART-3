<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cars.aspx.cs" Inherits="POEPART3.Cars" %>

<!DOCTYPE html>
<link rel="stylesheet" href="styles.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cars</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <h1>Cars</h1>
            
        <asp:Button ID="btnRead" runat="server"   Text="Read"   OnClick="btnRead_Click" Width="60px"/>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" style="width: 55px" Width="60px" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" Width="60px" />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" Width="60px" />
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat ="server"></asp:GridView>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Car Number" Width="150px"></asp:Label>
        <asp:TextBox ID="txtCarNumber" runat="server" Width="125px" style="text-align: center"></asp:TextBox>
        <p>
            <asp:Label ID="Label2" runat="server" Text="ModelID" Width="150px"></asp:Label>
            <asp:TextBox ID="txtModelID" runat="server" Wrap="False" Width="125px" style="text-align: center"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Kilometres Travelled" Width="150px"></asp:Label>
            <asp:TextBox ID="txtKilometresTravelled" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="Label4" runat="server" Text="Available" Width="150px"></asp:Label>
        <asp:RadioButton ID="rbnAvailable" runat="server" Width="125px"/>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Service Kilometres" Width="150px"></asp:Label>
            <asp:TextBox ID="txtServiceKilometres" runat="server" Width="125px"></asp:TextBox>
        </p>
        <asp:Label ID="lblComplete" runat="server"></asp:Label>
            </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnHome" runat="server" Text="Home" OnClick="btnHome_Click" Width="65px" />
        </p>
        <p>
            &nbsp;</p>
    </form>
    
</body>
</html>
