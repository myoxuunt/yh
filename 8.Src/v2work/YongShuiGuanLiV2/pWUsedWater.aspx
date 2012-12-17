<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pWUsedWater.aspx.cs" Inherits="YongShuiGuanLiV2.pWUsedWater" Title="无标题页" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<%@ Register src="UC/UCWUsedWater1.ascx" tagname="UCWUsedWater1" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCWUsedWater1 ID="UCWUsedWater11" runat="server" />
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:GridView ID="GridView1" runat="server" />
</asp:Content>