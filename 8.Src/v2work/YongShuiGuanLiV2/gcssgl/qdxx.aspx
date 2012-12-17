<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qdxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.qdxx" %>

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
									<td align="center" colSpan="2"><label style="font-size: 15px; font-weight: bold;">渠道信息查询</label></td>
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
												<asp:ButtonColumn Text="查看" HeaderText="操作区" CommandName="select" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn DataField="id" Visible="False"></asp:BoundColumn>
												<asp:BoundColumn DataField="渠道名称" HeaderText="渠道名称" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												
												<asp:BoundColumn DataField="渠道长度（千米）" HeaderText="渠道长度（千米）" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计流量（立方米/秒）" HeaderText="设计流量（立方米/秒）" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="实际防渗长度(千米)" HeaderText="实际防渗长度（千米）" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												
												<asp:BoundColumn DataField="渠道防渗率（%）" HeaderText="渠道防渗率（%）" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												
												
												<asp:BoundColumn DataField="规划防渗面积（平方米）" HeaderText="规划防渗面积（平方米）" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="建设时间" HeaderText="建设时间" ItemStyle-HorizontalAlign="Center">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
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
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
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
							<table cellSpacing="0" cellPadding="0" width="100%" border="0" style="height:220px">
								<TBODY>
									<tr class="style1">
										<td width="50%">渠道名称：
											<asp:label id="qdmc" runat="server"></asp:label></td>
										<td align="left">渠道简称：
											<asp:label id="qdjc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">渠道级别：
											<asp:label id="qdjb" runat="server"></asp:label></td>
										<td>上级渠道：<asp:label id="sjqd" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">渠道长度（千米）：<asp:label id="qdcd" runat="server"></asp:label></td>
										<td>设计流量（立方米/秒）：<asp:label id="sjll" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">联接上级渠道设施：<asp:label id="ljsjqdss" runat="server"></asp:label></td>
										<td>本级渠道在上级渠道上的桩号：<asp:label id="bjqdzh" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">实际防渗长度（千米）：<asp:label id="sjfscd" runat="server"></asp:label></td>
										<td>设计防渗长度（千米）：<asp:label id="shjfscd" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">渠道防渗率（%）：<asp:label id="qdfsl" runat="server"></asp:label></td>
										<td>设计灌溉面积（万亩）：<asp:label id="shjggmj" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">有效灌溉面积（万亩）：<asp:label id="yxggmj" runat="server"></asp:label></td>
										<td>实际灌溉面积（万亩）：<asp:label id="sjggmj" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">渠道水利用系数：<asp:label id="qdslyxs" runat="server"></asp:label></td>
										<td>规划防渗面积（平方米）：<asp:label id="ghfsmj" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
										<td>建设时间：<asp:label id="jssj" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">运行状况：<asp:label id="yszk" runat="server"></asp:label></td>
										<td width="50%">备注说明：<asp:label id="bzsm" runat="server"></asp:label></td>
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
