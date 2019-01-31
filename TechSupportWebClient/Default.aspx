<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechSupportWebClient.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tech Support</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>

    <div class="jumbotron">
        <h1 class="display-4 text-center">Tech Support Incidents</h1>
    </div>

    <form id="form1" runat="server">

        <div class ="row">
            <div class ="col-12 text-center">
                <asp:Button ID="btnTech" runat="server" OnClick="btnTech_Click" Text="Technician" />
                <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customer" />

            </div>
        </div>

        <div class ="row">
            <div class ="col-12 text-center">

            <asp:Label ID="lblID" runat="server" Text="lblID"></asp:Label>
            <asp:DropDownList ID="ddlID" runat="server" AutoPostBack="True" Height="74px" OnSelectedIndexChanged="ddlID_SelectedIndexChanged" Width="134px">
            </asp:DropDownList>

            </div>
        </div>

        <div class ="row">
            <div class ="col-12 text-center">

                <asp:GridView ID="gvID" runat="server">
                </asp:GridView>

            </div>
        </div>

    </form>

</body>
</html>
