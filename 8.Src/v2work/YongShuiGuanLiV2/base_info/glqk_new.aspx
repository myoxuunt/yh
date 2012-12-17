<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="glqk_new.aspx.cs" Inherits="YongShuiGuanLiV2.base_info.glqk_new" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table borderColor="#7ab4ff" cellSpacing="0" cellPadding="0" width="100%" border="1">
				<tr>
					<td>
						<table cellSpacing="0" cellPadding="0" width="100%">
							<tr class="title">
								<td align="center" colSpan="2"><label style="font-size: 15px; font-weight: bold;">管理文件统计文件上传</label></td>
							</tr>
							<tr>
								<td>统计年度：<asp:textbox id="year" runat="server" CssClass="text"></asp:textbox>
									<asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" ErrorMessage="RequiredFieldValidator"
										ControlToValidate="year" InitialValue="0">请输入年份</asp:RequiredFieldValidator></td>
							</tr>
							<tr>
								<td>上传文件：<INPUT id="myFile" type="file" name="myFile" runat="server" style="BORDER-RIGHT: 1px solid; BORDER-TOP: 1px solid; BORDER-LEFT: 1px solid; BORDER-BOTTOM: 1px solid"></td>
							</tr>
							<tr>
								<td>备注信息：<asp:textbox id="remark" runat="server" CssClass="text" Height="94px" TextMode="MultiLine"></asp:textbox></td>
							</tr>
							<tr>
								<td align="left"><asp:button id="upload" runat="server" Text="上传" 
                                        onclick="upload_Click"></asp:button></td>
							</tr>
							<tr>
								<td>
									<HR color="#84d7ff" SIZE="2">
								</td>
							</tr>
							<TR>
								<TD><B>文件资料信息：</B></TD>
							</TR>
							<TR>
								<TD>文件名：<asp:label id="fname" runat="server" text=""></asp:label></TD>
							</TR>
							<TR>
								<TD>文件类型：<asp:label id="fenc" runat="server"></asp:label></TD>
							</TR>
							<TR>
								<TD>文件大小 :(in bytes)<asp:label id="fsize" runat="server"></asp:label></TD>
							</TR>
							<tr>
								<td>
									<asp:image id="Image1" runat="server" ImageAlign="AbsMiddle"></asp:image>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
    </div>
    </form>
</body>
</html>
