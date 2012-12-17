<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="glqk.aspx.cs" Inherits="YongShuiGuanLiV2.base_info.glqk" Title="无标题页" %>
<%@ Register TagPrefix="iewc" Namespace="Microsoft.Web.UI.WebControls" Assembly="Microsoft.Web.UI.WebControls, Version=1.0.2.226, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="BORDER-RIGHT: #d6d3ce 1px solid; BORDER-TOP: #d6d3ce 2px solid; BORDER-LEFT: #d6d3ce 1px solid; BORDER-BOTTOM: #d6d3ce 1px solid"
				height="35" cellSpacing="0" cellPadding="0" width="100%">
				<tr>
					<td style="HEIGHT: 100%" bgColor="#f7f3ef"><iewc:tabstrip id="TabStrip1" style="BORDER-TOP: #666666 1px solid; Z-INDEX: 101; LEFT: 336px; PADDING-TOP: 3px; BORDER-BOTTOM: #d6d3ce 3px solid; BACKGROUND-COLOR: #f7f3ef"
							runat="server" BackColor="#83A4EF" SepSelectedStyle="display:none;" SepDefaultStyle="display:inline;background-color:#f7f3ef;padding-bottom:2px;"
							TabSelectedStyle="background-color:#83A4EF;color:#000000;border-left:1px solid #ffffff;border-top-width:1px;border-right:1px solid #000000;border-bottom:1px solid #D6D3Ce;font-weight:bold;border-top-color:1px solid #ffffff;"
							TabHoverStyle="background-color:#f7f3ef;" TabDefaultStyle="background-color:#E3EDF9;font-family:verdana;font-size:8pt;color:#525552;width:120;height:21;text-align:center;padding-bottom:-1px solid #ffffff;height:100%"
							TargetID="MultiPage1" Width="256px" Height="100%">
							<iewc:Tab Text="管理情况统计" TargetID="Page11"></iewc:Tab>
							<iewc:Tab Text="管理情况新建" TargetID="Page21"></iewc:Tab>
						</iewc:tabstrip></td>
				</tr>
			</table>
			<table height="750px" width="996px">
				<tr>
					<td>
						<iewc:MultiPage id="MultiPage1" runat="server" Width="996px" height="750px">
							<iewc:PageView id="Page11">
								<iframe name="ifrmReport" align="middle" src="glqktj.aspx" frameBorder="0" width="100%"
									height="100%"></iframe>
							</iewc:PageView>
							<iewc:PageView id="Page21">
								<iframe name="ifrmReport1" align="middle" src="glqk_new.aspx" frameBorder="0" width="100%"
									height="100%"></iframe>
							</iewc:PageView>
						</iewc:MultiPage>
					</td>
				</tr>
			</table>
</div>
</asp:Content>
