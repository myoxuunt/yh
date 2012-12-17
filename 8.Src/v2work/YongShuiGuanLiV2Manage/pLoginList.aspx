<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pLoginList.aspx.cs"
    Inherits="YongShuiGuanLiV2Manage.pLoginList" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>
        登录管理</h2>
    <div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    <asp:Button ID="btnAddLogin" runat="server" OnClick="btnAddLogin_Click" Text="新建登录" />
</asp:Content>
