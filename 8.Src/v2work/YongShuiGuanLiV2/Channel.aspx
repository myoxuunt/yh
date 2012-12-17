<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Channel.aspx.cs" Inherits="YongShuiGuanLiV2.Channel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0px" cellspacing="3" cellpadding="3" width="100%">
        <tr class="title">
            <td align="center">
                渠道信息查询
            </td>
        </tr>
        <tr>
            <td>
                <table align="center" class="table" width="90%" cellpadding="0px" cellspacing="0px"
                    frame="above" rules="all">
                    <tr>
                        <td colspan="3">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"/>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 20%" bgcolor="#D7F0FC">
                            <asp:Label ID="Label1" runat="server" Text="Channel Name"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtChannelName" runat="server" OnTextChanged="txtChannelName_TextChanged"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtChannelName"
                                ErrorMessage="RequiredFieldValidator" SetFocusOnError="True">*</asp:RequiredFieldValidator><asp:CustomValidator
                                    ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate"
                                    SetFocusOnError="True">*</asp:CustomValidator>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#D7F0FC">
                            <asp:Label ID="Label3" runat="server" Text="Channel Station"></asp:Label>
                        </td>
                        <td>
                            <asp:ListBox ID="lstStaion" runat="server" Height="109px" Width="300px"></asp:ListBox>
                        </td>
                        <td>
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnAddStation" runat="server" Text="Add Station" OnClick="btnAddStation_Click"
                                            CssClass="button_image" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnDeleteStation" runat="server" Text="Delete Station" OnClick="btnDeleteStation_Click"
                                            CssClass="button_image" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnStationUp" runat="server" Text="Station UP" CssClass="button_image" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnStationDown" runat="server" Text="Station Down" CssClass="button_image" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#D7F0FC">
                            <asp:Label ID="Label2" runat="server" Text="Channel Remark"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtChannelRemark" runat="server" CssClass="input_text"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" CssClass="button_image" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
