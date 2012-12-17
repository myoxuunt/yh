<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bzxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.bzxx" %>

<%@ Register src="../UC/qd.ascx" tagname="qd" tagprefix="uc1" %>

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
    <form id="form1" runat="server">
    <table borderColor="#7ab4ff" cellSpacing="0" cellPadding="0" width="100%" border="1">
				<tr>
					<td><FONT face="宋体">
							<table cellSpacing="0" cellPadding="0" width="100%">
								<tr class="title">
									<td align="center" colSpan="3" style="background-color:#EDF7FB">
                                        <label style="font-size: 15px; font-weight: bold;">泵站信息查询</label></td>
								</tr>
							</table>
							<table width="100%">
								<tr>
									<td colSpan="3">查询条件:</td>
								</tr>
								<tr>
									<td style="width:50%">
                                        <uc1:qd ID="qd1" runat="server" />
                                    </td>
									<td align="left"><asp:button id="button1" Runat="server" Text="查询" 
                                            onclick="button1_Click"></asp:button></td>
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
                                         CellPadding="4" BackColor="White" onitemcommand="DataGrid1_ItemCommand" 
                                            onpageindexchanged="DataGrid1_PageIndexChanged" BorderColor="#DEDFDE" 
                                            BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
										
											<AlternatingItemStyle BackColor="White" />
                                            <ItemStyle BackColor="#F7F7DE" />
											<Columns>
												<asp:ButtonColumn Text="查看" HeaderText="操作区" CommandName="select">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="泵站名称" HeaderText="泵站名称">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="16%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="所属渠道" HeaderText="所属渠道">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="16%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="桩号" HeaderText="桩号">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="泵站类型" HeaderText="泵站类型">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="机组台数（台）" HeaderText="机组台数（台）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="总装机容量（千瓦）" HeaderText="总装机容量（千瓦）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计扬程（米）" HeaderText="设计扬程（米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计流量（立方米/秒）" HeaderText="设计流量（立方米/秒）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
											</Columns>
											<FooterStyle BackColor="#CCCC99" />
                                            <SelectedItemStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
											<PagerStyle NextPageText="下一页" Font-Size="12px" Font-Names="宋体" Font-Bold="True" PrevPageText="上一页"
												HorizontalAlign="Right"></PagerStyle>
										    <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
										</asp:datagrid></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0" >
								<tr>
									<td>
										<HR width="100%" color="#84d7ff" SIZE="2">
									</td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td>详细信息：
									</td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%"
                            style="border-color: #F3F3F4;height:264px;">
								<TBODY>
									<tr class="style1">
										<td width="50%">所属渠道：
											<asp:label id="ssqd" runat="server"></asp:label></td>
										<td align="left">泵站名称：
											<asp:label id="bzmc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">桩号：
											<asp:label id="zh" runat="server"></asp:label></td>
										<td>地理位置：<asp:label id="dlwz" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">泵站规模：<asp:label id="bzgm" runat="server"></asp:label></td>
										<td>泵站类型：<asp:label id="bzlx" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">机组台数（台）：<asp:label id="jzts" runat="server"></asp:label></td>
										<td>总装机容量（千瓦）：<asp:label id="zzjrl" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">设计扬程（米）：<asp:label id="sjyc" runat="server"></asp:label></td>
										<td>设计流量（立方米/秒）：<asp:label id="sjll" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">装置效率（%）：<asp:label id="zzxl" runat="server"></asp:label></td>
										<td>管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">机组编号：<asp:label id="jzbh" runat="server"></asp:label></td>
										<td>水泵类型：<asp:label id="sblx" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">型号：<asp:label id="xh" runat="server"></asp:label></td>
										<td>流量（立方米/秒）：<asp:label id="ll" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">扬程（米）：<asp:label id="yc" runat="server"></asp:label></td>
										<td>功率（千瓦）：<asp:label id="gl" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">效率（%）：<asp:label id="xl" runat="server"></asp:label></td>
										<td>配套动力：<asp:label id="ptdl" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">生产厂家：<asp:label id="sccj" runat="server"></asp:label></td>
										<td>出厂日期：<asp:label id="ccrq" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">使用年限：<asp:label id="synx" runat="server"></asp:label></td>
										<td></td>
									</tr>
									
								</TBODY>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td width="85%"></td>
								</tr>
							</table>
						</FONT>
					</td>
				</tr>
			</table>
    </form>
</body>
</html>
