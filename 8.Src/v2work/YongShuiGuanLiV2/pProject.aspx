<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pProject.aspx.cs"
    Inherits="YongShuiGuanLiV2.pProject" Title="无标题页" %>

<%@ Register Src="UC/UCChannel.ascx" TagName="UCChannel" TagPrefix="uc1" %>
<%@ Register Src="UC/UCStation.ascx" TagName="UCStation" TagPrefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="TopLeftClass">
                <asp:TreeView ID="TreeView1" runat="server" 
                    OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" CssClass="TreeClass" 
                    ShowLines="True">
                </asp:TreeView>
            </td>
            <td class="TopLeftClass">
                <uc1:UCChannel ID="UCChannel1" runat="server" />
                <uc2:UCStation ID="UCStation1" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
