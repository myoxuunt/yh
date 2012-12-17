<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="psgxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.psgxx" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<style type="text/css">
.style1
{
	border-width:1px;
	background-color:#EDF7FB;
	}
</style>
<table borderColor="#7ab4ff" cellSpacing="0" cellPadding="0" width="996px" border="1">
				<tr>
					<td><FONT face="宋体">
							<table cellSpacing="0" cellPadding="0" width="100%">
								<tr class="title">
									<td align="center" colSpan="2"><label style="font-size: 15px; font-weight: bold;">排水沟信息查询</label></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td align="left">数据显示：</td>
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
												<asp:ButtonColumn Text="查询" HeaderText="操作区" CommandName="select">
								                      <HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="沟道名称" HeaderText="沟道名称">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="沟道简称" HeaderText="沟道简称">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="排涝面积（万亩）" HeaderText="排涝面积（万亩）">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计长度（米）" HeaderText="设计长度（米）">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计流量（立方米/秒）" HeaderText="设计流量（立方米/秒）">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="管理单位" HeaderText="管理单位">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
												</asp:BoundColumn>
												
												<asp:BoundColumn DataField="运行状况" HeaderText="运行状况">
													<HeaderStyle Font-Bold="True" Wrap="False" Width="14%"></HeaderStyle>
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
							<table width="100%" style="height: 264px" cellpadding="0px" cellspacing="0px" >
								<TBODY>
									<tr class="style1">
										<td Width="50%">沟道名称：<asp:label id="gdmc" runat="server" ></asp:label></td>
										<td>沟道简称：<asp:label id="gdjc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">上级沟道：<asp:label id="sjgd" runat="server"></asp:label></td>
										<td>排涝面积(万亩)：<asp:label id="plmj" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">设计排水标准（年）：<asp:label id="sjpsbz" runat="server"></asp:label></td>
										<td>现有排水标准（年）：<asp:label id="xypsbz" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">设计长度（千米）：<asp:label id="sjcd" runat="server"></asp:label></td>
										<td>现有长度（千米）：<asp:label id="xycd" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">设计流量（立方米/秒）：<asp:label id="sjll" runat="server"></asp:label></td>
										<td>现有流量（立方米/秒）：<asp:label id="xyll" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">设计深度（米）：<asp:label id="sjsd" runat="server"></asp:label></td>
										<td>现有深度（米）：<asp:label id="xysd" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">设计上口宽（米）：<asp:label id="sjskk" runat="server"></asp:label></td>
										<td>现有上口宽（米）：<asp:label id="xyskk" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">设计底宽（米）：<asp:label id="sjdk" runat="server"></asp:label></td>
										<td>现有底宽（米）：<asp:label id="xydk" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">设计坡降：<asp:label id="sjpj" runat="server"></asp:label></td>
										<td>现有坡降：<asp:label id="xypj" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">设计边坡：<asp:label id="sjbp" runat="server"></asp:label></td>
										<td>现有边坡：<asp:label id="xybp" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td Width="50%">管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
										<td>建设时间：<asp:label id="jssj" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td Width="50%">运行状况：<asp:label id="yxzk" runat="server"></asp:label></td>
										<td>备注说明：<asp:label id="bzsm" runat="server"></asp:label></td>
									</tr>
								</TBODY>
							</table>
							<table cellSpacing="0" cellPadding="0" width="75%" border="0">
								<tr>
									<td width="85%"></td>
								</tr>
							</table>
						</FONT>
					</td>
				</tr>
			</table>
</div>
</asp:Content>
