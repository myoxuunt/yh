<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pDistributeList.aspx.cs"
    Inherits="YongShuiGuanLiV2.pDistributeList" Title="无标题页" %>

<%@ Register Src="UC/UCDTTwoOnly.ascx" TagName="UCDTTwoOnly" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:UCDTTwoOnly ID="UCDTTwoOnly1" runat="server" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>
