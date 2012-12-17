<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pDataHistory.aspx.cs" Inherits="YongShuiGuanLiV2.pDataHistory" MasterPageFile="~/Site1.Master" %>


<%@ Register src="UC/UCConditionDTTwo.ascx" tagname="UCConditionDTTwo" tagprefix="uc1" %>


<%@ Register src="UC/UCChart.ascx" tagname="UCChart" tagprefix="uc2" %>


<%@ Register src="UC/UCZedChart.ascx" tagname="UCZedChart" tagprefix="uc3" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:UCConditionDTTwo ID="UCConditionDTTwo1" runat="server" />

    <uc3:UCZedChart ID="UCZedChart1" runat="server" />
    
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>


    <%--<uc2:UCChart ID="UCChart1" runat="server" />--%>

</asp:Content>