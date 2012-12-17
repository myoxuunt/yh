<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pNeedWaterItem.aspx.cs" Inherits="YongShuiGuanLiV2.pNeedWaterItem" Title="需水计划" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
    <table style="margin-left:10px;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="用水单位:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWaterUser" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblneedname" runat="server" Text="需水名称:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtNeedName" runat="server"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="开始时间:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                <input id="btnBegin" type="button" value="..." runat="server"/>
                </td>
            <td>
                <asp:CustomValidator ID="cvBegin" runat="server" 
                    onservervalidate="cvBegin_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="结束时间:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
                <input id="btnEnd" type="button" value="..." runat="server" />
            </td>
            <td>
                <asp:CustomValidator ID="cvEnd" runat="server" 
                    ErrorMessage="CustomValidator" onservervalidate="cvEnd_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="用水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsedAmount" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="cvUsedAmount" runat="server" 
                    ErrorMessage="无效的数字" onservervalidate="cvUsedAmount_ServerValidate">*</asp:CustomValidator>
            </td>
        </tr>
        
        <tr>
            <td valign="top">
                <asp:Label ID="Label5" runat="server" Text="备注:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRemark" runat="server" Height="150px"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnOK" runat="server" Text="确定" onclick="btnOK_Click"  />
            </td>
            <td>
            </td>
        </tr>
    </table>
    <script type="text/javascript">//<![CDATA[

      var cal = Calendar.setup({
          onSelect: function(cal) { cal.hide() },
          showTime: true
      });
      cal.manageFields(
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtBegin.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
          
      cal.manageFields(
           document.getElementById ("<%=btnEnd.ClientID%>"),
           document.getElementById("<%=txtEnd.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
      
    //]]></script> 
</asp:Content>
