<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaterUser.aspx.cs" Inherits="YongShuiGuanLiV2.WaterUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"/>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="用水户名称:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtWaterUserName" runat="server" OnTextChanged="txtWaterUserName_TextChanged"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
                        ControlToValidate="txtWaterUserName">*</asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="cvExistWaterUserName" runat="server" ErrorMessage="CustomValidator"
                        ControlToValidate="txtWaterUserName" OnServerValidate="cvExistWaterUserName_ServerValidate">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="用水户类型:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlWaterUserType" runat="server" OnSelectedIndexChanged="ddlWaterUserType_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="上级单位:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlParentWaterUser" runat="server" 
                        onselectedindexchanged="ddlParentWaterUser_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                    <asp:CustomValidator ID="cvWaterUserLevel" runat="server" 
                        ErrorMessage="上级单位的级别不能低于本级单位" >*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="进水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstIN" runat="server"></asp:ListBox>
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnAddIn" runat="server" Text="AddIn" OnClick="btnAddIn_Click" />
                    <asp:Button ID="btnDeleteIn" runat="server" Text="DeleteIn" OnClick="btnDeleteIn_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="出水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstOut" runat="server"></asp:ListBox>
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnAddOut" runat="server" Text="AddOut" OnClick="btnAddOut_Click" />
                    <asp:Button ID="btnDeleteOut" runat="server" Text="DeleteOut" OnClick="btnDeleteOut_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblChannel" runat="server" Text="管辖渠道:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstChannel" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnAddChannel" runat="server" Text="添加渠道" OnClick="btnAddChannel_Click"
                        Width="75px" />
                    <asp:Button ID="btnDeleteChannel" runat="server" Text="删除渠道" OnClick="btnDeleteChannel_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblLowLevelWaterUser" runat="server" Text="下级单位:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstLowLevelWaterUser" runat="server"></asp:ListBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="备注:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRemark" runat="server" Height="58px"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" Width="75px"
                Height="25px" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" Height="25px" OnClick="btnCancel_Click"
                Width="75px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted" ForeColor="#FF0066"
            Width="761px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
