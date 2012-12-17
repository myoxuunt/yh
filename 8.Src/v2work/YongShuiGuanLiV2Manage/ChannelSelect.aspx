<%@ Page 
Language="C#" 
MasterPageFile="~/Site1.Master" 
AutoEventWireup="true" 
CodeBehind="ChannelSelect.aspx.cs" Inherits="YongShuiGuanLiV2Manage.ChannelSelect"
Title="无标题页" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>渠道选择</h2>

    <asp:CheckBoxList ID="clChannel" runat="server">
    </asp:CheckBoxList>
    <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="确定" />
    &nbsp;
    <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
        Text="取消" />

</asp:Content>