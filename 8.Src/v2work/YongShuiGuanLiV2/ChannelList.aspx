<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChannelList.aspx.cs" Inherits="YongShuiGuanLiV2.ChannelList"
    Trace="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0px" cellspacing="3" cellpadding="3" width="100%">
        <tr >
            <td >
                渠道信息查询
            </td>
        </tr>
        <tr>
            <td >
                <table >
                    <tr>
                        <td >
                            <asp:GridView ID="GridView1" runat="server" OnRowDeleting="GridView1_RowDeleting"
                                OnRowEditing="GridView1_RowEditing" DataKeyNames="ChannelID">
                                <HeaderStyle />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="btnAddChannel" runat="server" OnClick="btnAddChannel_Click" Text="Add"
                                 BorderStyle="Solid" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
