<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pZM.aspx.cs" Inherits="YongShuiGuanLiV2.pZM" Title="无标题页" %>
<%@ Register src="UC/UCCompareAmount.ascx" tagname="UCCompareAmount" tagprefix="uc1" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCCompareAmount ID="UCCompareAmount1" runat="server" />
    <br />
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Auto">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </asp:Panel>
</asp:Content>
