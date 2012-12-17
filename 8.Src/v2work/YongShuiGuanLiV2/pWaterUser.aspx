<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pWaterUser.aspx.cs"
    Inherits="YongShuiGuanLiV2.pWaterUser" Title="无标题页" %>

<%@ Register Src="UC/UCWaterUser.ascx" TagName="UCWaterUser" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td class="TopLeftClass">
                <asp:Panel ID="Panel1" runat="server" >
                    <asp:TreeView ID="TreeView1" runat="server" OnLoad="TreeView1_Load" 
                        OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" CssClass="TreeClass" 
                        ShowLines="True" >
                    </asp:TreeView>
                </asp:Panel>
            </td>
            <td class="TopLeftClass">
                <uc1:UCWaterUser ID="UCWaterUser1" runat="server" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
