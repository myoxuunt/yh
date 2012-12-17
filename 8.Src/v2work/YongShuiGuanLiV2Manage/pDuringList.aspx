
<%@ Page 
Language="C#" 
MasterPageFile="~/Site1.Master" 
AutoEventWireup="true" 
CodeBehind="pDuringList.aspx.cs" 
Inherits="YongShuiGuanLiV2Manage.pDuringList" 
Title="无标题页" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <h2>放水季管理</h2>
    <div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="btnNew" runat="server" Text="新建放水季" onclick="btnNew_Click" />
    </div>

</asp:Content>