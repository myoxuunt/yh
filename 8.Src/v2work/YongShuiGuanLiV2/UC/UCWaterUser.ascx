<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCWaterUser.ascx.cs"
    Inherits="YongShuiGuanLiV2.UCWaterUser" %>
<link href="../css/Common.css" rel="stylesheet" type="text/css" />
<div>
        <table >
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="Label1" runat="server" Text="名称:"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="txtWaterUserName" runat="server" ReadOnly="True" 
                        CssClass="TextBoxClass" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblWaterUserLevel" runat="server" Text="单位类型"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlWaterUserLevel" runat="server" CssClass="TextBoxClass">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblWaterUserType" runat="server" Text="用水类型:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlWaterUserType" runat="server" 
                        CssClass="DropDownListClass" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr visible="false">
                <td>
                    <asp:Label ID="lblUnitPrice" runat="server" Text="水价(元/立方米):" Visible="false"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtUnitPrice" runat="server" Visible="false"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblIn" runat="server" Text="进水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstIN" runat="server" CssClass="ListBoxClass"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblOut" runat="server" Text="出水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstOut" runat="server" CssClass="ListBoxClass"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblChannel" runat="server" Text="管辖渠道:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstChannel" runat="server" CssClass="ListBoxClass"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="TDLabelClass">
                    <asp:Label ID="lblRemark" runat="server" Text="备注:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRemark" runat="server"  ReadOnly="True" 
                        CssClass="RemarkClass"></asp:TextBox>
                </td>
            </tr>
        </table>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted" ForeColor="#FF0066"
            Width="761px" Visible="False"></asp:TextBox>
</div>
