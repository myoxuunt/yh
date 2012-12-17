<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pCompareAmountWithWaterUser.aspx.cs"
    Inherits="YongShuiGuanLiV2.pCompareAmountWithWaterUser" Title="无标题页" %>

<%@ Register Src="UC/UCCompareWithWaterUser.ascx" TagName="UCCompareWithWaterUser"
    TagPrefix="uc1" %>
<%@ Register Src="UC/UCAMChart.ascx" TagName="UCAMChart" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCCompareWithWaterUser ID="UCCompareWithWaterUser1" runat="server" />
    <div style="height: 150px;">
    </div>
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
