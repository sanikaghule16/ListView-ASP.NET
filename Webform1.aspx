<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ListView.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <table>
            <tr>
                <!-- Left ListView -->
                <td>
                    <asp:ListView ID="ListView1" runat="server">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" Text='<%# Eval("Name") %>' />
                            <br />
                        </ItemTemplate>
                    </asp:ListView>
                </td>

                <!-- Buttons -->
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text=">>" OnClick="btnAdd_Click" /><br /><br />
                    <asp:Button ID="btnRemove" runat="server" Text="<<" OnClick="btnRemove_Click" />
                </td>

                <!-- Right ListView -->
                <td>
                    <asp:ListView ID="ListView2" runat="server">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" Text='<%# Eval("Name") %>' />
                            <br />
                        </ItemTemplate>
                    </asp:ListView>
                </td>
            </tr>
        </table>
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
