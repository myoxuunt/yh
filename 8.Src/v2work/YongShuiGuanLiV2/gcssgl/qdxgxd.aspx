<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qdxgxd.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.qdxgxd" %>

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
									<td align="center" colSpan="3"><label style="font-size: 15px; font-weight: bold;">渠道险工险段查询</label></td>
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
									<td style="WIDTH: 575px" align="left" colSpan="3">数据显示：
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
												<asp:ButtonColumn Text="查看" HeaderText="操作区" CommandName="select" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn DataField="id" Visible="False"></asp:BoundColumn>
												<asp:BoundColumn DataField="所属渠道" HeaderText="所属渠道" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="险工险段名称" HeaderText="险工险段名称" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="起始桩号" HeaderText="起始桩号" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="终止桩号" HeaderText="终止桩号" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="地理位置" HeaderText="地理位置" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="险工险段长度（千米）" HeaderText="险工险段长度（千米）" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="12%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计流量（立方米/秒）" HeaderText="设计流量（立方米/秒）" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="12%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="存在的问题" HeaderText="存在的问题" >
												<HeaderStyle Font-Bold="True" Wrap="False" Width="20%"></HeaderStyle>
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
							<table cellSpacing="0" cellPadding="0" width="100%" border="0" style="height:242px">
								<TBODY>
									<tr class="style1">
										<td width="50%">所属渠道：
											<asp:label id="ssqd" runat="server"></asp:label></td>
										<td align="left">险工险段名称：
											<asp:label id="xgxdmc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">起始桩号：
											<asp:label id="qszh" runat="server"></asp:label></td>
										<td>终止桩号：<asp:label id="zzzh" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">地理位置：<asp:label id="dlwz" runat="server"></asp:label></td>
										<td>险工险段长度（千米）：<asp:label id="xgxdcd" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">防渗渠段长度（千米）：<asp:label id="fsqdcd" runat="server"></asp:label></td>
										<td>设计流量（立方米/秒）：<asp:label id="sjll" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">设计水深(米)：<asp:label id="sjss" runat="server"></asp:label></td>
										<td>防洪水位渠堤高（米）：<asp:label id="fhswqdg" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">危害程度：<asp:label id="whcd" runat="server"></asp:label></td>
										<td>治理形式：<asp:label id="zlxs" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">渠道比降：<asp:label id="qdbj" runat="server"></asp:label></td>
										<td>内边坡系数：<asp:label id="nbpxs" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">外边坡系数：<asp:label id="wbpxs" runat="server"></asp:label></td>
										<td>糙率：<asp:label id="cl" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">渠底宽（米）：<asp:label id="qdk" runat="server"></asp:label></td>
										<td>上口宽（米）：<asp:label id="skk" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">左堤顶宽度（米）：<asp:label id="zddkd" runat="server"></asp:label></td>
										<td>右堤底宽度（米）：<asp:label id="yddkd" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td>存在的问题：<asp:label id="czdwt" runat="server"></asp:label></td>
										<td width="50%">备注说明：<asp:label id="bzsm" runat="server"></asp:label></td>
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
