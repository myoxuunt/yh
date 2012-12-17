<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pRainCompare.aspx.cs" Inherits="YongShuiGuanLiV2.pRainCompare" Title="无标题页" %>
<%@ Register src="UC/UCRain.ascx" tagname="UCRain" tagprefix="uc1" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:UCRain ID="UCRain1" runat="server" />
    
    <div id="VerticalSpace" style="height:100px"></div>
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
