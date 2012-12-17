<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pFluxHistory2.aspx.cs" Inherits="YongShuiGuanLiV2.pFluxHistory2" Title="无标题页" %>
<%@ Register src="UC/UCChannelStationDT.ascx" tagname="UCChannelStationDT" tagprefix="uc1" %>
<%@ Register Src="UC/UCAMChart.ascx" TagName="UCAMChart" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCChannelStationDT ID="UCChannelStationDT1" runat="server" />
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:GridView ID="GridView1" runat ="server" />
</asp:Content>
