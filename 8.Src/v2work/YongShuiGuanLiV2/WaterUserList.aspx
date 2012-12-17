<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WaterUserList.aspx.cs" Inherits="YongShuiGuanLiV2.WaterUserList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="WaterUserID" 
            onrowdeleting="GridView1_RowDeleting" onrowediting="GridView1_RowEditing">
        </asp:GridView>
    
    </div>
    <p>
        &nbsp;</p>
    <asp:DropDownList ID="ddlNewWaterUserLevel" runat="server">
    </asp:DropDownList>
    <asp:LinkButton ID="lbAdd" runat="server" OnClick="lbAdd_Click">Add water 
    user</asp:LinkButton>
    </form>
</body>
</html>
