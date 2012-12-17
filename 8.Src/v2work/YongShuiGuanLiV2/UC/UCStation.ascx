<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCStation.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCStation" %>
<link href="../css/Common.css" rel="stylesheet" type="text/css" />
<table>
    <tr>
        <td class="TDLabelClass">
            <asp:Label ID="lblStationName" runat="server" Text="站点名称"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtStationName" runat="server" CssClass="TextBoxClass"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="TDLabelClass">
            <asp:Label ID="Label2" runat="server" Text="设备大类"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDeviceKind" runat="server" CssClass="TextBoxClass"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="TDLabelClass">
            <asp:Label ID="Label3" runat="server" Text="设备型号"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDeviceType" runat="server" CssClass="TextBoxClass"></asp:TextBox>
        </td>
    </tr>
    <tr visible="false">
        <td class="TDLabelClass">
            <asp:Label ID="lblAlarm" runat="server" Text="报警设定" Visible="false"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtAlarmHighLimit" runat="server" CssClass="TextBoxClass" Visible="false"></asp:TextBox>
            <asp:Button ID="btnModifyAlarm" runat="server" Text="修改" 
                onclick="btnModifyAlarm_Click"  Visible="false"/>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblFormula" runat="server" Text="计算公式" Visible="false"></asp:Label>
        </td>
        <td>
        </td>
    </tr>
</table>
<asp:GridView ID="gvFormula" runat="server" DataKeyNames="ID" 
    onrowdeleting="gvFormula_RowDeleting" onrowediting="gvFormula_RowEditing"
    Visible="false">
</asp:GridView>
<asp:Button ID="btnNewFormula" runat="server" Text="新建公式" 
    onclick="btnNewFormula_Click" Visible="false"/>

<asp:HiddenField ID="HiddenField1" runat="server" />


