<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebServiceConsumer.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td>
                    Number 1:
                </td>
                <td>
                    <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Number 2:
                </td>
                <td>
                    <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Result:
                </td>
                <td>
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
