<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="map_station.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_station" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table width="90%" style="top:1px" cellpadding="1px" cellspacing="1px">
   <tr>
   <td align="center" width="100%"><a href="map_station_query.aspx" title="点击放大地图"><asp:ImageMap ID="ImageMap1" runat="server"  ImageUrl="~/images/yehe(12).gif"  AlternateText="点击放大地图">
    </asp:ImageMap></a></td>
   </tr>
   </table>
</asp:Content>
