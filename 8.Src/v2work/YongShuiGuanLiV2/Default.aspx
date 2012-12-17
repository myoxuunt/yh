<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="YongShuiGuanLiV2._Default"
    MasterPageFile="~/Site1.Master" %>

<%@ Register src="UC/UCCharList.ascx" tagname="UCCharList" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/pReal.aspx">real</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/pDataHistory.aspx">history</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink3" runat="server" NavigateUrl="~/pProject.aspx">pproject</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/pWaterUser.aspx">pwateruser</asp:HyperLink>
        <br />
        <asp:HyperLink ID="HyperLink8" runat="server" NavigateUrl="~/p2hour.aspx">2hour</asp:HyperLink>
    </div>
</asp:Content>
