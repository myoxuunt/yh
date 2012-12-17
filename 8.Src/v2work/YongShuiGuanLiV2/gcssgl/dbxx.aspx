<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dbxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.dbxx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<style type="text/css">
.style1
{
	border-width:1px;
	background-color:#EDF7FB;
	}
</style>
<body>
    <form id="Form1" method="post" runat="server">
			<table borderColor="#7ab4ff" cellSpacing="0" cellPadding="0" width="100%" border="1">
				<tr>
					<td><FONT face="宋体">
							<table cellSpacing="0" cellPadding="0" width="100%">
								<tr class="title">
									<td align="center" colSpan="2"><label style="font-size: 15px; font-weight: bold;">大坝信息查询</label></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td align="left">数据显示：
									</td>
								</tr>
								<tr>
									<td width="100%"><asp:datagrid id="DataGrid1" runat="server" Width="100%" 
                                            AllowSorting="True" HorizontalAlign="Center"
										AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                                         CellPadding="4" BackColor="white" onitemcommand="DataGrid1_ItemCommand" 
                                            onpageindexchanged="DataGrid1_PageIndexChanged" BorderColor="#DEDFDE" 
                                            BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
										
											<AlternatingItemStyle BackColor="white"/>
                                            <ItemStyle BackColor="#F7F7DE" />
											<Columns>

												<asp:ButtonColumn Text="查看" HeaderText="操作区" CommandName="select">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn DataField="id" Visible="False"></asp:BoundColumn>
												<asp:BoundColumn DataField="大坝名称" HeaderText="大坝名称">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="12%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="地理位置" HeaderText="地理位置">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="工程等级" HeaderText="工程等级">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="大坝高度（米）" HeaderText="大坝高度">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="大坝长度（米）" HeaderText="大坝长度">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="管理单位" HeaderText="管理单位">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="建设时间" HeaderText="建设时间">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="11%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="运行状况" HeaderText="运行状况"></asp:BoundColumn>
											</Columns>
											<FooterStyle BackColor="#CCCC99" />
                                            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
											<PagerStyle NextPageText="下一页" Font-Size="12px" Font-Names="宋体" Font-Bold="True" PrevPageText="上一页"
												HorizontalAlign="Right"></PagerStyle>
										    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
										</asp:datagrid></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td>详细信息：
									</td>
								</tr>
							</table>
							<table width="100%" style="height: 154px">
								<TBODY>
									<tr class="style1">
										<td Width="50%">大坝名称：
											<asp:label id="dbmc" runat="server" ></asp:label></td>
									
										<td>地理位置：<asp:label id="dlwz" runat="server" ></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">大坝类型：<asp:label id="dblx" runat="server" ></asp:label></td>
										<td>工程等级：<asp:label id="gcdj" runat="server" ></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">大坝高度(米)：<asp:label id="dbgd" runat="server" ></asp:label></td>
										<td>大坝长度(米)：<asp:label id="dbcd" runat="server" ></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">大坝作用：<asp:label id="dbzy" runat="server" ></asp:label></td>
										<td>建筑材料：<asp:label id="jzcl" runat="server" ></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
										<td>建设时间：<asp:label id="jssj" runat="server" ></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">运行状况：<asp:label id="yxzk" runat="server" ></asp:label></td>
										<td>备注说明：<asp:label id="bzsm" runat="server"></asp:label></td>
									</tr>
								</TBODY>
							</table>
						</FONT>
					</td>
				</tr>
			</table>
		</form>
</body>
</html>
