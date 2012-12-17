<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Test1.aspx.cs" Inherits="YongShuiGuanLiV2.Test.Test1" Title="无标题页" %>
<%@ Register src="UC/UCShiDuan.ascx" tagname="UCShiDuan" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    a
 <p />   
    <uc1:UCShiDuan ID="UCShiDuan1" runat="server" />
</asp:Content>
