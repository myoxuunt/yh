<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pIFCalc.aspx.cs"
    Inherits="YongShuiGuanLiV2.pIFCalc" Title="无标题页" %>

<%@ Register Src="UC/UCCompareAmount.ascx" TagName="UCCompareAmount" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .A
        {
            margin-top: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCCompareAmount ID="UCCompareAmount1" runat="server" IsSelectedStation ="false" />
    <asp:Panel ID="Panel1" runat="server" Height="400px" ScrollBars="Vertical">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </asp:Panel>
    <div style="height:20px;"></div>
    <asp:Panel ID="panelNoFormula" runat="server">
        <asp:Label ID="lblNoFormula" runat="server" Text="没有流量计算公式" ForeColor="Red"> </asp:Label>
    </asp:Panel>
    
    <asp:Panel ID="panelFormula" runat="server">
        <asp:Label ID="lblFlux" runat="server" Text="流量计算公式:" CssClass="A"></asp:Label>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:Button ID="Calc" Text="重新计算" runat="server" OnClick="Calc_Click" />
    </asp:Panel>
</asp:Content>
