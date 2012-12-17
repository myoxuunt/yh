<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qlxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.qlxx" %>

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
									<td align="center" colSpan="3"><label style="font-size: 15px; font-weight: bold;">桥梁信息查询</label></td>
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
									
									<td width="100%"><asp:datagrid id="DataGrid_ql" runat="server" Width="100%" 
                                            AllowSorting="True" HorizontalAlign="Center"
										AllowPaging="True" PageSize="15" AutoGenerateColumns="False" 
                                         CellPadding="4" BackColor="White" onitemcommand="DataGrid1_ItemCommand" 
                                            onpageindexchanged="DataGrid1_PageIndexChanged" BorderColor="#DEDFDE" 
                                            BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
										
											<AlternatingItemStyle BackColor="White" />
                                            <ItemStyle BackColor="#F7F7DE" />
											<Columns>
												<asp:ButtonColumn Text="查询" HeaderText="操作区" CommandName="select">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="桥梁名称" HeaderText="桥梁名称">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="所属渠道" HeaderText="所属渠道">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="桩号" HeaderText="桩号">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="桥宽（米）" HeaderText="桥宽（米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="桥长（米）" HeaderText="桥长（米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="总跨度（米）" HeaderText="总跨度（米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="孔数（孔）" HeaderText="孔数（孔）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="结构型式" HeaderText="结构型式">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="过水能力（立方米/秒）" HeaderText="过水能力（立方米/秒）">
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
							<table cellSpacing="0" cellPadding="0" width="100%" border="0" style="height:198px">
								<TBODY>
									<tr class="style1">
										<td width="50%">所属渠道：
											<asp:label id="ssqd" runat="server"></asp:label></td>
										<td align="left">桥梁名称：
											<asp:label id="qlmc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">桩号：
											<asp:label id="zh" runat="server"></asp:label></td>
										<td>桥宽（米）：<asp:label id="qk" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">桥长（米）：<asp:label id="qc" runat="server"></asp:label></td>
										<td>总跨度（米）：<asp:label id="zkd" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">孔数（孔）：<asp:label id="ks" runat="server"></asp:label></td>
										<td>单孔净宽（米）：<asp:label id="dkjk" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">桥下净空（米）：<asp:label id="qxjk" runat="server"></asp:label></td>
										<td>结构型式：<asp:label id="jgxs" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">过水能力（立方米/秒）：<asp:label id="gsnl" runat="server"></asp:label></td>
										<td>建筑材料：<asp:label id="jzcl" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">设计荷载：<asp:label id="sjhz" runat="server"></asp:label></td>
										<td>管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">建设时间：<asp:label id="yxsj" runat="server"></asp:label></td>
										<td>运行状况：<asp:label id="yxzk" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">备注说明：<asp:label id="bzsm" runat="server"></asp:label></td>
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
