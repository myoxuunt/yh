<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChannelSelect.aspx.cs" Inherits="YongShuiGuanLiV2.ChannelSelect" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:CheckBoxList ID="clChannel" runat="server">
    </asp:CheckBoxList>
    <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" onclick="btnCancel_Click" 
        Text="Cancel" />
    </form>
</body>
</html>
