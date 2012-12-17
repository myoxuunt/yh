<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map_manystation_query.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_manystation_query" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
    <style type="text/css">
        .style1
        {
            width: 301px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table  width="100%" cellpadding="0px" cellspacing="0px" border="0px">
    <tr>
    <td class="style1"><asp:Image ID="Image1" runat="server" ImageUrl="~/images/闸门图.gif" /></td>
    <td>
    <asp:datagrid id="DataGrid1" runat="server" Width="100%" 
                                            AllowSorting="True" HorizontalAlign="Center"
										AllowPaging="True" PageSize="4" AutoGenerateColumns="False" 
                                         CellPadding="4" BackColor="White" 
                                             BorderColor="#DEDFDE" 
                                            BorderStyle="Solid" BorderWidth="1px" ForeColor="Black" GridLines="Vertical">
										
											<AlternatingItemStyle BackColor="White" />
                                            <ItemStyle BackColor="#F7F7DE" />
										<HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
										<Columns>
											
											<asp:BoundColumn  ItemStyle-Width="30%" DataField="stationname" HeaderText="站点名称">
												<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="true"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn   ItemStyle-Width="40%" DataField="dt" HeaderText="时间">
												<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="true"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn  DataField="Height" HeaderText="闸高(cm)">
												<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="true"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn ItemStyle-Width="10%" DataField="BeforeWL"  HeaderText="闸前水位(cm)">
												<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="true"></ItemStyle>
											</asp:BoundColumn>
											<asp:BoundColumn ItemStyle-Width="10%" DataField="BehindWL"  HeaderText="闸后水位(cm)">
												<HeaderStyle Font-Bold="True" Wrap="False"></HeaderStyle>
												<ItemStyle Wrap="true"></ItemStyle>
											</asp:BoundColumn>
										</Columns>
										
									</asp:datagrid>
    </td>
    </tr>
    </table>
    </form>
</body>
</html>
