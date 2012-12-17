<%@ Page Language="C#" MasterPageFile="~/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="pCompareAmount.aspx.cs" Inherits="YongShuiGuanLiV2.pCompareAmount" Title="无标题页" %>
<%@ Register src="UC/UCCompareAmount.ascx" tagname="UCCompareAmount" tagprefix="uc1" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:UCCompareAmount ID="UCCompareAmount1" runat="server" />
<div style="height:150px;"></div>
<uc2:UCAMChart ID="UCAMChart1" runat="server" />
<asp:GridView ID="GridView1" runat="server" />
<asp:Button ID="btnExportToExcel" runat="server" Text="导出" 
        onclick="btnExportToExcel_Click"  />
</asp:Content>
