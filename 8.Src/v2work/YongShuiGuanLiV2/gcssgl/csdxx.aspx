<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="csdxx.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.csdxx" %>

<%@ Register src="../UC/qd.ascx" tagname="qd" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<style type="text/css">
        .style1
        {
            border-width: 1px;
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
									<td align="center" colSpan="3"><label style="font-size: 15px; font-weight: bold;">沉沙池信息查询</label></td>
								</tr>
							</table>
							<table width="100%">
								<tr>
									<td colSpan="3">查询条件:</td>
								</tr>
								<tr>
									<td width="50%">
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
												<asp:ButtonColumn Text="查询" HeaderText="操作区" CommandName="select">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="8%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center" ForeColor="#009999"></ItemStyle>
												</asp:ButtonColumn>
												<asp:BoundColumn Visible="False" DataField="id"></asp:BoundColumn>
												<asp:BoundColumn DataField="沉沙池名称" HeaderText="沉沙池名称">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="16%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="所属渠道" HeaderText="所属渠道">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="16%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="起始桩号" HeaderText="起始桩号">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="长度（米）" HeaderText="长度（米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="占地面积（平方米）" HeaderText="占地面积（平方米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="设计沉沙库容（立方米）" HeaderText="设计沉沙库容（立方米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="现有沉沙库容（立方米）" HeaderText="现有沉沙库容（立方米）">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
												</asp:BoundColumn>
												<asp:BoundColumn DataField="管理单位" HeaderText="管理单位">
												<HeaderStyle Font-Bold="True" Wrap="False" Width="10%"></HeaderStyle>
													<ItemStyle HorizontalAlign="Center"></ItemStyle>
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
							<table cellSpacing="0" cellPadding="0" width="100%" border="0" 
                            style="height:154px">
								<TBODY>
									<tr class="style1">
										<td width="50%">所属渠道：<asp:label id="ssqd" runat="server"></asp:label></td>
										<td align="left">尘沙池名称：<asp:label id="csdmc" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">起始桩号：<asp:label id="qszh" runat="server"></asp:label></td>
										<td>形状：<asp:label id="xz" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">长度（米）：<asp:label id="cd" runat="server"></asp:label></td>
										<td>占地面积（平方米）：<asp:label id="zdmj" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">设计沉沙库容（立方米）：<asp:label id="sjcskr" runat="server"></asp:label></td>
										<td>现有沉沙库容（立方米）：<asp:label id="xycskr" runat="server"></asp:label></td>
									</tr>
									<tr class="style1">
										<td width="50%">主要作用：<asp:label id="zyzy" runat="server"></asp:label></td>
										<td>管理单位：<asp:label id="gldw" runat="server"></asp:label></td>
									</tr>
									<tr>
										<td width="50%">建设时间：<asp:label id="jssj" runat="server"></asp:label></td>
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
