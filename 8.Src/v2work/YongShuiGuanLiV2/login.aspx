<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="YongShuiGuanLiV2.login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
     <style type="text/css">
        .style1
        {
            height: 100%;
        }
        .style3
        {
            height: 38%;
        }
        .style2
        {
            width: 30%;
        }
         .style4
        {
            width: 38%;
        }
        .style5
        {
            height: 38%;
        }
    </style>
</head>
<body>
    <form id="form2" runat="server">
    <asp:Login ID="Login1" runat="server" style="margin:0 auto;" OnAuthenticate="Login1_Authenticate" OnLoggingIn="Login1_LoggingIn"
        DisplayRememberMe="False" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid"
        BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
        <LayoutTemplate>
    <table  style="BORDER-RIGHT: thin outset; BORDER-TOP: thin outset; BORDER-LEFT: thin outset; BORDER-BOTTOM: thin outset; border-style: none; background-image: url('images/login/Login.gif');" 
      height="560" width="1000" align="center"  
            cellpadding="0" cellspacing="0" >
        <tr class="style3">
        <td  ></td>
        <td  ></td>
        <td  ></td>
        </tr>
        
        <tr><td class="style2"></td>
        <td >
        <table width="100%" class="style1">
        <tr>
        <td colspan="2"></td>
        </tr>
        
        <tr>
        <td class="style4" align="right">
        <img  src="images/login/user.gif" />
        </td>
        <td align="left"><asp:TextBox ID="UserName" runat="server" Width="200px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                        ErrorMessage="必须填写“用户名”。" ToolTip="必须填写“用户名”。" ValidationGroup="Login1">*</asp:RequiredFieldValidator></td>
        </tr>
        <tr>
        <td align="right"><img  src="images/login/lock.gif" /></td>
        <td align="left"><asp:TextBox ID="Password" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                        ErrorMessage="必须填写“密码”。" ToolTip="必须填写“密码”。" ValidationGroup="Login1">*</asp:RequiredFieldValidator></td>
        </tr>
         <tr class="style3">
        <td colspan="2" ><asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal></td>
        </tr>
         
         <tr>
        <td ></td>
        <td align="left"><asp:imagebutton id="LoginButton" runat="server" CommandName="Login" ValidationGroup="Login1" ImageUrl="images/login/userlogin.gif"></asp:imagebutton></td>
        </tr>
        
        </table>
        </td>
        <td class="style2"></td></tr>
        
        <tr class="style5"><td></td>
        <td align="center" style="font-size:12px">唐山现代工程技术有限公司版权所有 2010-2013<br />
            版本：v1.1</td>
        <td></td></tr>
        </table>
        </LayoutTemplate>
        <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
    </asp:Login>
    </form>
</body>
</html>
