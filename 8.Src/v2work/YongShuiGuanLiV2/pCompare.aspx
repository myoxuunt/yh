<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pCompare.aspx.cs" Inherits="YongShuiGuanLiV2.pCompare" Title="无标题页" %>
<%@ Register src="UC/UCCompareCondition.ascx" tagname="UCCompareCondition" tagprefix="uc1" %>
<%@ Register src="UC/UCZedChart.ascx" tagname="UCZedChart" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCCompareCondition ID="UCCompareCondition1" runat="server" />
    <uc2:UCZedChart ID="UCZedChart1" runat="server" />
    
    <table style="width: 100%;">
        <tr>
            <td valign="top">
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </td>
            <td valign="top">
                <asp:GridView ID="GridView2" runat="server">
                </asp:GridView>
            </td>
        </tr>
    </table>
</asp:Content>
