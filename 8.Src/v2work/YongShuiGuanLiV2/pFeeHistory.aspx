<%@ Page Language="C#" MasterPageFile="~/Site1.Master" EnableEventValidation="false" AutoEventWireup="true" CodeBehind="pFeeHistory.aspx.cs"
    Inherits="YongShuiGuanLiV2.pFeeHistory" Title="无标题页" %>

<%@ Register Src="UC/UCFeeCondition.ascx" TagName="UCFeeCondition" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCFeeCondition ID="UCFeeCondition1" runat="server" />
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="FeeID" OnRowEditing="GridView1_RowEditing">
    </asp:GridView>
    <table>
        <tr>
            <td>
                <asp:Label ID="lalUsedAmount" runat="server" Text="总用水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWaterAmount" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lalPayAmount" runat="server" Text="结算总水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsedAmount" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lalPayPrice" runat="server" Text="实付总水费:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPayPrice" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="lalLeftPrice" runat="server" Text="剩余总水费:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLeftPrice" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="btnExport" runat="server" Text="导出" onclick="btnExport_Click" />
</asp:Content>
