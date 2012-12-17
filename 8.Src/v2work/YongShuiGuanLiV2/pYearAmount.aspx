<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pYearAmount.aspx.cs" Inherits="YongShuiGuanLiV2.pYearAmount" Title="无标题页" %>
<%@ Register src="UC/UCConditionYear.ascx" tagname="UCConditionYear" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCConditionYear ID="UCConditionYear1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
