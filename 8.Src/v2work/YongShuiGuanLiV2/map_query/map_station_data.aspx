<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map_station_data.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_station_data" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <table>
					<tr>
						<td align="center">
							<asp:Image ID="Image1" runat="server" ImageUrl="~/images/i_5.jpg" />
                        </td>
						<td>
						<table>
						<tr>
						<td>测站名称：</td>
						<td><asp:Label ID="station" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>时间：</td>
						<td><asp:Label ID="DT1" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>一号水位：</td>
						<td><asp:Label ID="wl1" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>二号水位：</td>
						<td><asp:Label ID="wl2" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>瞬时流量：</td>
						<td><asp:Label ID="instantflux" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>已用水量：</td>
						<td><asp:Label ID="usedamount" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						
						</table>
						
						</td>
					</tr>
					
				</table>
    </form>
</body>
</html>
