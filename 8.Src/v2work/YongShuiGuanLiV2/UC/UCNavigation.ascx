<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNavigation.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCNavigation" %>
<div style="height: 100px;">
    <asp:LinkButton ID="lbForwar" runat="server" onclick="lbForwar_Click" >向前</asp:LinkButton>
    &nbsp;
    <asp:DropDownList ID="ddlStepUnit" runat="server" Width="80px">
    </asp:DropDownList>
    &nbsp;
    <asp:LinkButton ID="lbBackward" runat="server" OnClick="lbBackward_Click">向后</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lbIncrease" runat="server" ToolTip="增加时间范围" 
        onclick="lbIncrease_Click" Visible="False">增加</asp:LinkButton>
    &nbsp;
    <asp:LinkButton ID="lbDecrease" runat="server" ToolTip="减小时间范围" 
        onclick="lbDecrease_Click" Visible="False">减小</asp:LinkButton>
    &nbsp;
</div>
