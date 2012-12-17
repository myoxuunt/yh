<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pDistributeItem.aspx.cs"
    Inherits="YongShuiGuanLiV2.pDistributeItem" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            border-collapse: collapse;
            border: 1px solid #00FF00;
            background-color: #C0C0C0;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table >
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="用水单位"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWaterUser" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="起始时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNeedBegin" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="结束时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNeedEnd" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="需水量"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNeedAmount" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Label ID="Label2" runat="server" Text="备注"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNeedRemark" runat="server" CssClass="RemarkClass" 
                    ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
    </table>
    <hr />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
        DisplayMode="List" />
    <table >
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="起始时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDistributeBegin" runat="server"></asp:TextBox>
                
            </td>
            <td>
                <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="*" 
                    onservervalidate="cvBegin_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="结束时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDistributeEnd" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="cvEnd" runat="server" 
                    ErrorMessage="CustomValidator" onservervalidate="cvEnd_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="配水量"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDistributeAmount" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="cvDistributeAmount" runat="server" 
                    ErrorMessage="无效的数字" 
                    onservervalidate="cvDistributeAmount_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Label ID="Label9" runat="server" Text="备注"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDistributeRemark" runat="server" CssClass="RemarkClass"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
        <td>
        </td>
            <td>
                <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
            </td>
            <td>
        </td>
        </tr>
    </table>
    <hr />
</asp:Content>
