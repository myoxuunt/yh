<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCCompareAmount.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCCompareAmount" %>
<%@ Register Src="UCShiDuan.ascx" TagName="UCShiDuan" TagPrefix="uc1" %>
<%@ Register Src="UCDanRi.ascx" TagName="UCDanRi" TagPrefix="uc2" %>
<fieldset>
    <legend>条件</legend>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="渠道选择:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="测点选择:"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cblStation" runat="server" RepeatDirection="Horizontal">
                        </asp:CheckBoxList>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="时段类型:"></asp:Label>
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
        </ContentTemplate>
        <Triggers>
            <asp:PostBackTrigger ControlID="btnOK" />
        </Triggers>
    </asp:UpdatePanel>
</fieldset>
