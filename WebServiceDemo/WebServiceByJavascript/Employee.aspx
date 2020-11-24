<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebServiceByJavascript.Employee1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function GetEmployeeById() {
            var empId = document.getElementById("txtEmpId").value;
            WebServiceByJavascript.EmployeeService.GetEmpById(empId, GetEmployeeByIdSuccessCallBack, GetEmployeeByIdFailureCallBack);
        }

        function GetEmployeeByIdSuccessCallBack(result) {
            document.getElementById("txtTitle").value = result["Title"];
            document.getElementById("txtFirstName").value = result["FirstName"];
            document.getElementById("txtLastName").value = result["LastName"];
        }

        function GetEmployeeByIdFailureCallBack(error) {
            alert(error.get_message());
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/EmployeeService.asmx" />
            </Services>
        </asp:ScriptManager>
        <table>
            <tr>
                <td>Emp Id:
                </td>
                <td>
                    <asp:TextBox ID="txtEmpId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <input id="btnGetEmp" type="button" value="Get Emp" onclick="GetEmployeeById()" />
                </td>
            </tr>
            <tr>
                <td>Title:
                </td>
                <td>
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>First Name:
                </td>
                <td>
                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name:
                </td>
                <td>
                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <h1>
            the time below dosent chnage bcos its partial postback
            <br />b
            <asp:Label ID="lblTime" runat="server" ></asp:Label>
        </h1>
    </form>
</body>
</html>
