

<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pNeedWaterList.aspx.cs" Inherits="YongShuiGuanLiV2.pWaterPlanList" Title="无标题页" %>
<%@ Register src="UC/UCDTTwoOnly.ascx" tagname="UCDTTwoOnly" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCDTTwoOnly ID="UCDTTwoOnly1" runat="server" />
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="NeedWaterID">
</asp:GridView>
    </asp:Content>
