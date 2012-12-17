<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="qxjzw_query.aspx.cs" Inherits="YongShuiGuanLiV2.gcssgl.qxjzw_query" Title="无标题页" %>
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
							TabHoverStyle="background-color:#f7f3ef;" TabDefaultStyle="background-color:#E3EDF9;font-family:verdana;font-size:8pt;color:#525552;width:100;height:21;text-align:center;padding-bottom:-1px solid #ffffff;height:100%"
							TargetID="MultiPage1" Width="100%" Height="100%">
							<iewc:Tab Text="桥梁信息" TargetID="Page11"></iewc:Tab>
							<iewc:Tab Text="泵站信息" TargetID="Page21"></iewc:Tab>
							<iewc:Tab Text="沉沙池信息" TargetID="Page31"></iewc:Tab>
							<iewc:Tab Text="倒虹吸信息" TargetID="Page41"></iewc:Tab>
							<iewc:Tab Text="跌水信息" TargetID="Page51"></iewc:Tab>
							<iewc:Tab Text="陡坡信息" TargetID="Page61"></iewc:Tab>
							<iewc:Tab Text="渡槽信息" TargetID="Page71"></iewc:Tab>
							<iewc:Tab Text="涵洞信息" TargetID="Page81"></iewc:Tab>
							<iewc:Tab Text="其他建筑物信息" TargetID="Page91"></iewc:Tab>
						</iewc:tabstrip></td>
				</tr>
			</table>
			<table height="750px" style="width: 966px">
				<tr>
					<td>
						<iewc:MultiPage id="MultiPage1" runat="server" Width="966px" height="750px">
							<iewc:PageView id="Page11">
								<iframe name="ifrmReport" align="middle" src="qlxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page21">
								<iframe name="ifrmReport1" align="middle" src="bzxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page31">
								<iframe name="ifrmReport1" align="middle" src="csdxx.aspx" frameBorder="0" width="100%"
									height="100%"></iframe>
							</iewc:PageView>
							<iewc:PageView id="Page41">
								<iframe name="ifrmReport1" align="middle" src="dhxxx.aspx" frameBorder="0" width="100%"
									height="100%"></iframe>
							</iewc:PageView>
							<iewc:PageView id="Page51">
								<iframe name="ifrmReport1" align="middle" src="dsxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page61">
								<iframe name="ifrmReport1" align="middle" src="dpxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page71">
								<iframe name="ifrmReport1" align="middle" src="dcxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page81">
								<iframe name="ifrmReport1" align="middle" src="hdxx.aspx" frameBorder="0" width="100%" height="100%">
								</iframe>
							</iewc:PageView>
							<iewc:PageView id="Page91">
								<iframe name="ifrmReport1" align="middle" src="qtxx.aspx" frameBorder="0" width="100%"
									height="100%"></iframe>
							</iewc:PageView>
						</iewc:MultiPage>
					</td>
				</tr>
			</table>
</div>
</asp:Content>
