<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuanLiJu.aspx.cs" Inherits="YongShuiGuanLiV2.GuanLiJu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="管理局名称:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="管辖渠道"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnAddChannel" runat="server" Text="添加" />
                    <asp:Button ID="btnDeleteChannel" runat="server" Text="删除" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="下级单位"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnAddSubordinate" runat="server" Text="添加" />
                    <asp:Button ID="btnDeleteSubordinate" runat="server" Text="删除" />
                </td>
            </tr>
            <tr>
            <td>
                    <asp:Label ID="Label4" runat="server" Text="备注"></asp:Label>
            </td>
            <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
            </tr>
        </table>
    </div>
    <asp:Button ID="btnOK" runat="server" Text="确定" />
    </form>
</body>
</html>
