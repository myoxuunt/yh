<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pMulitYearAmount.aspx.cs" Inherits="YongShuiGuanLiV2.pMulitYearAmount" Title="无标题页" %>
<%@ Register src="UC/UCMulitYearCondition.ascx" tagname="UCMulitYearCondition" tagprefix="uc1" %>
<%@ Register src="UC/UCZedChart.ascx" tagname="UCZedChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCMulitYearCondition ID="UCMulitYearCondition1" runat="server" />
    <uc2:UCZedChart ID="UCZedChart1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
