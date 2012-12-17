<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="webbaseinfo.aspx.cs" Inherits="YongShuiGuanLiV2Manage.webbaseinfo" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    <table height="450px" style="border:3px solid #4092AA; " width="100%">
    <tr>
    <td colspan="3" style="height:40px; background-color:#4092AA; color: #FFFFFF;" >
        冶河灌区概况</td>
    </tr>
				<tr style="background-color:#FFFFEE">
				    <td ></td>
					<td align="center" style="width:90%">
						<asp:TextBox   Height="410px"  id="txtBaseInfo"  runat="server" BackColor="#FFFFEE" 
                            Font-Bold="True" ForeColor="#52C6DE" TextMode="MultiLine"></asp:TextBox></td>
                      <td ></td>  
				</tr>
			</table>
			<table height="30px" >
				<tr>
					<td align="right">
						<asp:Button id="btnEdit" runat="server" Text="保存修改" Visible="False" 
                            onclick="btnEdit_Click"></asp:Button>
                        &nbsp;&nbsp;&nbsp;
						<asp:Button id="btnCancel" runat="server"  Text="取消修改" Visible="False" 
                            onclick="btnCancel_Click"></asp:Button>
                        &nbsp;&nbsp;
						<FONT face="宋体">&nbsp; </FONT>
					</td>
				</tr>
			</table>
			</div>
</asp:Content>
