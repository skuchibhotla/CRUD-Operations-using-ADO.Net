<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="DB_Connection.CRUD.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 93px;
        }
        .auto-style3 {
            width: 93px;
            height: 29px;
        }
        .auto-style4 {
            height: 29px;
        }
        .auto-style5 {
            width: 350px;
        }
        .auto-style6 {
            height: 29px;
            width: 350px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CRUD Operations<br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Person ID: </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxID" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="ButtonSearch" runat="server" OnClick="ButtonSearch_Click" Text="Search" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Name: </td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxName" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="ButtonAdd" runat="server" Text="Add" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Gender: </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBoxGender" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="ButtonEdit" runat="server" Text="Edit" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Age</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBoxAge" runat="server" Width="350px"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" Width="100px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Status: </td>
                    <td colspan="2">
                        <asp:Label ID="LabelStatus" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
