<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pFee.aspx.cs" Inherits="YongShuiGuanLiV2.pFee" Title="无标题页" %>
<%@ Register src="UC/UCFeeCondition.ascx" tagname="UCFeeCondition" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<uc1:UCFeeCondition ID="UCFeeCondition1" runat="server" />
&nbsp;
<asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
