<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="webbaseinfo.aspx.cs" Inherits="YongShuiGuanLiV2.webbaseinfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        p<table height="420px" style="width: 1000px;border:3px solid #4092AA; ">
    <tr>
    <td colspan="3" style="height:40px; background-color:#4092AA; color: #FFFFFF;" align="center">
        kjj<label style="font-size: 15px; font-weight: bold;">冶河灌区概况</label>
     </td>
    </tr>
				<tr style="background-color:#FFFFEE">
				    <td ></td>
					<td align="center">
						<asp:TextBox width="900px"  Height="380px"  id="txtBaseInfo"  runat="server" BackColor="#FFFFEE" 
                            Font-Bold="True" ForeColor="#52C6DE" BorderStyle=None TextMode="MultiLine"></asp:TextBox></td>
                      <td ></td>  
				</tr>
			</table>
			<table height="30px" style="width: 966px">
				<tr>
					<td align="right">
						<asp:Button id="btnEdit" runat="server" Text="保存修改" Visible="False"></asp:Button>
                        &nbsp;&nbsp;&nbsp;
						<asp:Button id="btnCancel" runat="server"  Text="取消修改" Visible="False"></asp:Button>
                        &nbsp;&nbsp;
						<FONT face="宋体">&nbsp; </FONT>
					</td>
				</tr>
			</table>
			</div>
</asp:Content>
