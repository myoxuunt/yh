<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pLoginItem.aspx.cs"
    Inherits="YongShuiGuanLiV2Manage.pLoginItem" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        登录信息</h2>
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="用户名:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="确认密码:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwd2" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="所属单位:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlWaterUser" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblRole" runat="server" Text="用户角色:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlRole" runat="server">
                        <asp:ListItem Value="2">系统管理员</asp:ListItem>
                        <asp:ListItem Value="1">管理员</asp:ListItem>
                        <asp:ListItem Value="0">用户</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:CheckBox ID="cbAllowEdit" runat="server" Text="允许修改水位" />
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblEditPassword" Text="修改水位密码:"> </asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txtEditPassword"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="确定" />
                    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="取消" />
                </td>
                <td>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
