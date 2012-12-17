<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Station.aspx.cs" Inherits="YongShuiGuanLiV2.Station" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    &nbsp;
                    <asp:Label ID="Label1" runat="server" Text="StationName"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Device Kind"></asp:Label>
                </td>
                <td class="style1">
                    &nbsp;
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td class="style1">
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Label ID="Label3" runat="server" Text="Device Type"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
            <td>
                    &nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Alarm =&gt;"></asp:Label>
                </td>
            <td>
        <asp:Panel ID="Panel1" runat="server" >
            <div style="background-color: #00FF00;">
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </div>
        </asp:Panel>
                </td>
            <td></td>
            </tr>
            
            <tr>
            <td>&nbsp;<asp:Button ID="btnOK" runat="server" Text="OK" onclick="btnOK_Click" />
                    </td>
            <td></td>
            <td></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
