<%@ Page Language="C#" MasterPageFile="~/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="pDataHistroy2.aspx.cs" Inherits="YongShuiGuanLiV2.pDataHistroy2" Title="无标题页" %>
<%@ Register src="UC/UCChannelStationDT.ascx" tagname="UCChannelStationDT" tagprefix="uc1" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<%@ Register src="UC/UCNavigation.ascx" tagname="UCNavigation" tagprefix="uc3" %>
<%@ Register src="UC/UCCompareAmount.ascx" tagname="UCCompareAmount" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <uc4:UCCompareAmount ID="UCCompareAmount1" runat="server" />
    <uc3:UCNavigation ID="UCNavigation1" runat="server" Visible="false" />
    <div id="VerticalSpace" style="height:100px">
    </div>
    <br />
    <table border="0" >
    <tr>
    <td>
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    </td>
    <td valign="top" visible="false">
        <asp:LinkButton ID="lbWL" runat="server" visible="false" onclick="lbWL_Click">水 
        位</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lbFlux" runat="server" visible="false" onclick="lbFlux_Click">流 
        量</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lbAmount"  runat="server" visible="false" onclick="lbAmount_Click">水 
        量</asp:LinkButton>
        <br />
    </td>
    </tr>
    </table>
    <asp:Panel ID="Panel1" runat="server">
        <asp:GridView ID="GridView1" runat="server" >
        </asp:GridView>
    </asp:Panel>
    <asp:Button ID="btnExportToExcel" runat="server" Text="导出" 
        onclick="btnExportToExcel_Click" Width="120px" />
</asp:Content>
