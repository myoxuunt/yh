<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCCompareWithWaterUser.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCCompareWithWaterUser" %>

<%@ Register src="UCShiDuan.ascx" tagname="UCShiDuan" tagprefix="uc1" %>
<%@ Register src="UCDanRi.ascx" tagname="UCDanRi" tagprefix="uc2" %>
<fieldset>
    <legend>条件</legend>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="用户选择:"></asp:Label>
            </td>
            <td>
                <asp:CheckBoxList ID="cblLLWaterUser" runat="server" RepeatDirection="Horizontal">
                </asp:CheckBoxList>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="对比时段:"></asp:Label>
            </td>
            <td>
                <asp:RadioButton ID="rbYear" runat="server" Text="年" AutoPostBack="True" GroupName="a"
                    OnCheckedChanged="rbYear_CheckedChanged" />
                <asp:RadioButton ID="rbWaterDuring" runat="server" Text="放水季" AutoPostBack="True"
                    GroupName="a" OnCheckedChanged="rbWaterDuring_CheckedChanged" />
                <asp:RadioButton ID="rbShiDuan" runat="server" Text="时段" AutoPostBack="True" GroupName="a"
                    OnCheckedChanged="rbShiDuan_CheckedChanged" />
                <asp:RadioButton ID="rbDay" runat="server" Text="单日" AutoPostBack="True" GroupName="a"
                    OnCheckedChanged="rbDay_CheckedChanged" />
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Label ID="lblDTRange" runat="server" Text="时段选择:"></asp:Label>
            </td>
            <td>
                <!--year-->
                <asp:Panel ID="panelYear" runat="server">
                    <asp:DropDownList ID="ddlYear" runat="server">
                    </asp:DropDownList>
                </asp:Panel>
                <!-- water during-->
                <asp:Panel ID="panelWaterDuring" runat="server">
                    <asp:DropDownList ID="ddlWaterDuring" runat="server">
                    </asp:DropDownList>
                </asp:Panel>
                <!-- shiduan -->
                <asp:Panel ID="panelShiDuan" runat="server">
                    <uc1:UCShiDuan ID="UCShiDuan1" runat="server" />
                </asp:Panel>
                <!-- day -->
                <asp:Panel ID="panelDay" runat="server">
                <!--
                    <asp:TextBox ID="txtDay" runat="server"></asp:TextBox>
                    <input id="btnDay" runat="server" type="button" value="..." />
                    -->
                    <uc2:UCDanRi ID="UCDanRi1" runat="server" />
                </asp:Panel>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
            </td>
            <td>
            </td>
        </tr>
    </table>
</fieldset>