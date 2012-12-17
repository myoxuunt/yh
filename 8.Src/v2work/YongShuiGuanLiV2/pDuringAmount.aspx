<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pDuringAmount.aspx.cs" Inherits="YongShuiGuanLiV2.pDuringAmount" Title="无标题页" %>
<%@ Register src="UC/UCConditionDTTwo.ascx" tagname="UCConditionDTTwo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCConditionDTTwo ID="UCConditionDTTwo1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
