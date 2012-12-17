<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pReal.aspx.cs" Inherits="YongShuiGuanLiV2.pReal"
    MasterPageFile="~/Site1.Master" %>

<%@ Register TagPrefix="ofc" Namespace="OpenFlashChart" Assembly="OpenFlashChart" %>
<%@ Register src="UC/UCChart.ascx" tagname="UCChart" tagprefix="uc1" %>
<%@ Register src="UC/UCCharList.ascx" tagname="UCCharList" tagprefix="uc2" %>
<%@ Register src="UC/UCZedChart.ascx" tagname="UCZedChart" tagprefix="uc3" %>
<%@ Register src="UC/UCAMChart.ascx" tagname="UCAMChart" tagprefix="uc4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <uc3:UCZedChart ID="UCZedChart1" runat="server" />
    </div>
    <br />
    <asp:GridView ID="gvLast" runat="server">
    </asp:GridView>
    <asp:Button ID="btnRefresh" runat="server" Text="刷新" 
        onclick="btnRefresh_Click" />
    <uc4:UCAMChart ID="UCAMChart1" runat="server" />
</asp:Content>
