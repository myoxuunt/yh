<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ChannelList.aspx.cs" Inherits="YongShuiGuanLiV2Manage.ChannelList" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>渠道管理</h2>
    <table border="0px" cellspacing="3" cellpadding="3" width="100%">
        <tr>
            <td >
                <table >
                    <tr>
                        <td >
                            <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting"
                                OnRowEditing="GridView1_RowEditing" DataKeyNames="ChannelID">
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="btnAddChannel" runat="server" OnClick="btnAddChannel_Click" 
                                Text="新建渠道" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>