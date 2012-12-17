<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map_station_sluicedata.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_station_sluicedata" %>

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
							<asp:Image ID="Image1" runat="server" ImageUrl="~/images/闸门图.gif" />
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
						<td>闸高：</td>
						<td><asp:Label ID="height" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>闸前水位：</td>
						<td><asp:Label ID="beforewl" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>闸后水位：</td>
						<td><asp:Label ID="behindwl" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						
						
						</table>
						
						</td>
					</tr>
					
				</table>
    </form>
</body>
</html>
