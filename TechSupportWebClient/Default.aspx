<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechSupportWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnCustomer" runat="server" Text="Customer" OnClick="btnCustomer_Click" />
            <asp:Button ID="btnTech" runat="server" OnClick="btnTech_Click" Text="Technician" />
        </div>
        <asp:Label ID="lblID" runat="server" Text="Label"></asp:Label>
        <asp:DropDownList ID="ddlID" runat="server" AutoPostBack="True" Height="36px" Width="143px" OnSelectedIndexChanged="ddlID_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:GridView ID="gvID" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
