<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="qd.ascx.cs" Inherits="YongShuiGuanLiV2.UC.qd" %>
<fieldset>
    <legend>条件</legend>
    <div>
        <table>
            <tr>
            <td><asp:Label ID="lblOrganization" runat="server" Text="上级渠道："></asp:Label></td>
            <td><asp:dropdownlist id="DropDownList1" runat="server" Width="160px" 
    AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged"></asp:dropdownlist></td>
            <td><asp:Label Text="所在渠道：" runat=server></asp:Label></td>
            <td><asp:dropdownlist id="DropDownList2" runat="server" Width="160px"></asp:dropdownlist></td>
            </tr>
            </table>
            </div>


</fieldset>
