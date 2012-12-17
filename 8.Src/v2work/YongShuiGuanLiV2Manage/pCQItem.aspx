<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pCQItem.aspx.cs"
    Inherits="YongShuiGuanLiV2Manage.pCQItem" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="原站名:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtOldStationName" runat="server" ReadOnly ="true"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="新站名:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNewStationName" runat="server" ></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="cvNewStationName" runat="server" ErrorMessage="无效的名称" 
                    onservervalidate="cvNewStationName_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnOK" runat="server"  Text="确定" onclick="btnOK_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="取消" onclick="btnCancel_Click" />
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
