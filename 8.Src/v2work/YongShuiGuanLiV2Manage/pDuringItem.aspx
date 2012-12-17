<%@ Page 
Language="C#" 
MasterPageFile="~/Site1.Master" 
AutoEventWireup="true" 

CodeBehind="pDuringItem.aspx.cs" Inherits="YongShuiGuanLiV2Manage.pDuringItem"
Title="无标题页" 
%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
    <h2>放水季定义</h2>
    <div>
    
    
    <table>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="放水季名称:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="起始日期:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="结束日期:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="btnOK" runat="server" onclick="btnOK_Click" Text="确定" />
                &nbsp;
                <asp:Button ID="btnCancel" runat="server"  Text="取消" 
                    onclick="btnCancel_Click" />
                    </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    </div>

</asp:Content>