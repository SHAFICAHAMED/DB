<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="myform.aspx.cs" Inherits="DB.myform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <label>Firstname:</label>
                    <asp:TextBox ID="firstname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>

                    <td>
                        <label>Lasttname:</label>
                        <asp:TextBox ID="lastname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <label>Age:</label>
                        <asp:TextBox ID="age" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="ins" runat="server" Text="insert" OnClick="ins_Click" />
                        <asp:Button ID="del" runat="server" Text="delete" OnClick="del_Click" />
                        <asp:Button ID="upd" runat="server" Text="update" OnClick="upd_Click" />
                        <asp:Button ID="vie" runat="server" Text="view" OnClick="vie_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label>Enter id for update:</label>
               
                        <asp:TextBox ID="idold" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
