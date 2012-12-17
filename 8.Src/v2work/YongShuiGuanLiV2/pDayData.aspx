<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pDayData.aspx.cs"
    Inherits="YongShuiGuanLiV2.pDayData" Title="无标题页"  EnableEventValidation = "false"%>

<%@ Register Src="UC/UCChannelStationDTOne.ascx" TagName="UCChannelStationDTOne"
    TagPrefix="uc1" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCChannelStationDTOne ID="UCChannelStationDTOne1" runat="server" />
    <uc2:UCAMChart ID="UCAMChart1" runat="server" />
    <asp:Panel ID="Panel1" runat="server" Height ="400px" ScrollBars="Vertical">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </asp:Panel>
    <%--<asp:Button ID="b1" runat="server" Text ="bbb" onclick="b1_Click" />--%>
</asp:Content>
