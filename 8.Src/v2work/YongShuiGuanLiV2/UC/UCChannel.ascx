<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCChannel.ascx.cs" Inherits="YongShuiGuanLiV2.UCChannel" %>
<link href="../css/Common.css" rel="stylesheet" type="text/css" />
<table>
    <tr>
        <td class ="TDLabelClass">
            <asp:Label ID="Label1" runat="server" Text="渠道名称"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtChannelName" runat="server" 
                OnTextChanged="txtChannelName_TextChanged" CssClass="TextBoxClass"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="TDLabelClass">
            <asp:Label ID="Label2" runat="server" Text="备注"></asp:Label>
        </td>
        <td colspan="2">
            <asp:TextBox ID="txtChannelRemark" runat="server" CssClass="RemarkClass"></asp:TextBox>
        </td>
    </tr>
</table>
