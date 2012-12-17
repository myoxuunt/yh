<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuanLiChu.aspx.cs" Inherits="YongShuiGuanLiV2.GuanLiChu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        #TextArea1
        {
            height: 141px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="管理处名称"></asp:Label>
                   </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="管辖渠道"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnAddChannel" runat="server" Text="Add Channel" />
                    <asp:Button ID="btnDeleteChannel" runat="server" Text="Delete Channel" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="下级单位"></asp:Label>
                </td>
                <td>
                    <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox>
                </td>
                <td>
                    <asp:Button ID="btnAddSubordinate" runat="server" Text="Add Subordinate" />
                    <asp:Button ID="btnDeleteSubordinate" runat="server" 
                        Text="Delete Subordinate" />
                </td>
            </tr>
            
            <tr>
            <td>
                    <asp:Label ID="Label4" runat="server" Text="上级单位"></asp:Label>
                </td>
            <td>
                <asp:HyperLink ID="HyperLink1" runat="server">HyperLink</asp:HyperLink>
                </td>
            <td></td>
            </tr>
            <tr>
            <td>
                    <asp:Label ID="Label5" runat="server" Text="Remark"></asp:Label>
                </td>
            <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            <td></td>
             </tr>
             <tr>
            <td>
                    <asp:Label ID="Label6" runat="server" Text="in "></asp:Label>
                 </td>
            <td>
                    <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
                 </td>
            <td>
                    <asp:Button ID="btnAddInWaterStation" runat="server" Text="Add In" />
                    <asp:Button ID="btnDeleteInWaterStation" runat="server" 
                        Text="Delete In" />
                 </td>
            </tr>
            <tr>
            <td>
                    <asp:Label ID="Label7" runat="server" Text="Out"></asp:Label>
                </td>
            <td>
                    <asp:ListBox ID="ListBox4" runat="server"></asp:ListBox>
                </td>
            <td>
                    <asp:Button ID="btnAddOutWaterStation" runat="server" Text="Add Out" />
                    <asp:Button ID="btnDeleteOutWaterStation" runat="server" 
                        Text="Delete Out" />
                </td>
            </tr>
        </table>
    
    </div>
    <asp:Button ID="btnOK" runat="server" Text="确定" Width="39px" />
    </form>
</body>
</html>
