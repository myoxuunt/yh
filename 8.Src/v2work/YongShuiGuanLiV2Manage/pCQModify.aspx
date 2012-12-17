<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pCQModify.aspx.cs"
    Inherits="YongShuiGuanLiV2Manage.pCQModify" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" 
        onrowdatabound="GridView1_RowDataBound">
    </asp:GridView>
</asp:Content>
