<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gcsjtj.aspx.cs" Inherits="YongShuiGuanLiV2.base_info.gcsjtj" %>

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
					<td><FONT face="宋体">
							<table cellSpacing="0" cellPadding="0" width="100%">
								<tr class="title">
									<td align="center" colSpan="2"><label style="font-size: 15px; font-weight: bold;">工程数据统计</label></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td align="left">查询条件：
									</td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td align="left">查询年份：<asp:textbox id="year" runat="server" CssClass="text"></asp:textbox>
                                        <asp:button id="query" runat="server" Text="查询" onclick="query_Click"></asp:button></td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td>
										<HR color="#84d7ff" SIZE="2">
									</td>
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
												<asp:ButtonColumn Text="选择" HeaderText="操作区" CommandName="select"></asp:ButtonColumn>
												<asp:BoundColumn DataField="gcsj_id" Visible="False"></asp:BoundColumn>
												<asp:BoundColumn DataField="year" HeaderText="统计年份"></asp:BoundColumn>
												<asp:BoundColumn DataField="time" HeaderText="上传时间"></asp:BoundColumn>
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
									<td>内容显示：
									</td>
								</tr>
							</table>
							<table cellSpacing="0" cellPadding="0" width="100%" border="0">
								<tr>
									<td width="85%"><asp:image id="Image2" runat="server"></asp:image></td>
									<td align="left" width="10%"></td>
								</tr>
							</table>
						</FONT>
					</td>
				</tr>
			</table>
			<table style="Z-INDEX: 104; LEFT: 256px; POSITION: absolute; TOP: 152px" cellSpacing="2"
				border="1">
			</table>
    </div>
    </form>
</body>
</html>
