<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="map_stationrain_data.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_stationrain_data" %>

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
							<asp:Image ID="Image1" runat="server" ImageUrl="~/images/rainfall.gif" />
                        </td>
						<td>
						<table>
						<tr>
						<td>站点名称：</td>
						<td><asp:Label ID="stationname" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td>时间：</td>
						<td><asp:Label ID="DT" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>
						<tr>
						<td style="text-align:left">降雨量(mm)：</td>
						<td><asp:Label ID="RainFill" Runat="server" Font-Bold="True"></asp:Label></td>
						</tr>



						</table>
						
						</td>
					</tr>
					
				</table>
    </form>
</body>
</html>
