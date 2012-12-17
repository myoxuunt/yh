<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WaterUser.aspx.cs"
    Inherits="YongShuiGuanLiV2Manage.WaterUser" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>用水户信息</h2>
    <div>
        <asp:Label ID="lblAddEditState" runat="server" Text="Label" Visible ="false"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
        <%--        <table style="width: 100%;">
--%>
        <table>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="用水户名称:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtWaterUserName" runat="server" OnTextChanged="txtWaterUserName_TextChanged"></asp:TextBox>
                </td>
                <td>
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
                    <asp:DropDownList ID="ddlWaterUserType" runat="server" 
                        OnSelectedIndexChanged="ddlWaterUserType_SelectedIndexChanged" Height="21px" 
                        Width="300px">
                    </asp:DropDownList>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="上级单位:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlParentWaterUser" runat="server" 
                        OnSelectedIndexChanged="ddlParentWaterUser_SelectedIndexChanged" Height="18px" 
                        Width="300px">
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:CustomValidator ID="cvWaterUserLevel" runat="server" ErrorMessage="上级单位的级别不能低于本级单位">*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="Label4" runat="server" Text="进水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstIN" runat="server" Width="300px"></asp:ListBox>
                </td>
                <td valign="top">
                    <asp:Button ID="btnAddIn" runat="server" Text="添加进水测点" OnClick="btnAddIn_Click" 
                        Width="100px" />
                    <br />
                    <asp:Button ID="btnDeleteIn" runat="server" Text="删除进水测点" OnClick="btnDeleteIn_Click" 
                        width="100px"/>
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="Label5" runat="server" Text="出水测点:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstOut" runat="server" Width="300px"></asp:ListBox>
                </td>
                <td valign="top">
                    <asp:Button ID="btnAddOut" runat="server" Text="添加出水测点" OnClick="btnAddOut_Click" 
                    width="100px"/>
                    <br />
                    <asp:Button ID="btnDeleteOut" runat="server" Text="删除出水测点" OnClick="btnDeleteOut_Click" 
                    width="100px"/>
                </td>
            </tr>
            <tr>
                <td>
                    用水户级别:
                </td>
                <td>
                    <asp:DropDownList ID="ddlWaterUserLevel" runat="server" Height="18px" 
                        Width="300px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="lblChannel" runat="server" Text="管辖渠道:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstChannel" runat="server" Width="300px"></asp:ListBox>
                </td>
                <td valign="top">
                    <asp:Button ID="btnAddChannel" runat="server" Text="添加渠道" OnClick="btnAddChannel_Click"
                        Width="75px" />
                        <br />
                    <asp:Button ID="btnDeleteChannel" runat="server" Text="删除渠道" OnClick="btnDeleteChannel_Click" />
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="lblLowLevelWaterUser" runat="server" Text="下级单位:"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="lstLowLevelWaterUser" runat="server" Width="300px"></asp:ListBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td valign="top">
                    <asp:Label ID="Label6" runat="server" Text="备注:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtRemark" runat="server" Height="100px"></asp:TextBox>
                </td>
                <td>
                </td>
            </tr>
        </table>
        <p style="text-align:center">
            <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" Width="75px"
                Height="25px" />
            &nbsp;<asp:Button ID="btnCancel" runat="server" Text="取消" Height="25px" OnClick="btnCancel_Click"
                Width="75px" />
        </p>
        <p>
            &nbsp;</p>
        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="Dotted" ForeColor="#FF0066"
            Width="761px" Visible="false"></asp:TextBox>
    </div>
    <%-- </form>
</body>
</html>
--%>
</asp:Content>
