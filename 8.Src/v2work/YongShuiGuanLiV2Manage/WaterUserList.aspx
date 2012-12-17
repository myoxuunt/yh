 <%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WaterUserList.aspx.cs" Inherits="YongShuiGuanLiV2Manage.WaterUserList" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>用水户管理</h2>
    <div>
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="WaterUserID" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing">
        </asp:GridView>
    
    </div>
    <p></p>
    <asp:DropDownList ID="ddlNewWaterUserLevel" runat="server">
    </asp:DropDownList>
    <%--<asp:LinkButton ID="lbAdd" runat="server" OnClick="lbAdd_Click">新建用水户</asp:LinkButton>--%>
    <asp:Button ID="btnNewWaterUser" runat="server" OnClick="lbAdd_Click" Text="新建用水户"/>
</asp:Content>