<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pNeedDistributeLowLevel.aspx.cs" Inherits="YongShuiGuanLiV2.pNeedDistributeLowLevel" Title="无标题页" %>
<%@ Register src="UC/UCZedChart.ascx" tagname="UCZedChart" tagprefix="uc2" %>
<%@ Register src="UC/UCChildWaterUserDTTwo.ascx" tagname="UCChildWaterUserDTTwo" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCChildWaterUserDTTwo ID="UCChildWaterUserDTTwo1" runat="server" />
    <uc2:UCZedChart ID="UCZedChart1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
