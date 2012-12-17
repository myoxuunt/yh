<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="p2Hour.aspx.cs" Inherits="YongShuiGuanLiV2.p2Hour" Title="无标题页" %>
<%@ Register src="UC/UCConditionDTOne.ascx" tagname="UCConditionDTOne" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCConditionDTOne ID="UCConditionDTOne1" runat="server" />
    <br />
    <asp:Label ID="lblGridViewCaption" runat="server" BackColor="White" 
        Font-Bold="True" Font-Size="12pt" Width="100%" BorderColor="White"></asp:Label>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
    <asp:Button ID="Button1" runat="server" Text="导出到Excel" onclick="Button1_Click" 
        Width="120px" />
    </asp:Content>
