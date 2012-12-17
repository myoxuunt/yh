<%@ Page Language="C#" Trace ="false" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pWLModify.aspx.cs"
    Inherits="YongShuiGuanLiV2.pWLModify" Title="无标题页" %>

<%@ Register src="UC/UCChannelStationDTOne.ascx" tagname="UCChannelStationDTOne" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <uc1:ucchannelstationdtone ID="UCChannelStationDTOne1" runat="server"  IsSelectAllStation ="false"/>
    
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataKeyNames="DitchDataID">
        <Columns>
            <asp:BoundField DataField="StationName" HeaderText="站名" />
            <asp:BoundField DataField="DT" HeaderText="时间" />
            <asp:BoundField DataField="wl1" HeaderText="水位(cm)" />
            <asp:BoundField DataField="InstantFlux" HeaderText="瞬时流量(m3/s)" />
            <asp:TemplateField HeaderText="修改值(cm)" >
                <ItemTemplate>
                    <asp:TextBox ID="txtNewWL" runat="server"></asp:TextBox>
                </ItemTemplate>
                <ItemStyle Width="160px" />
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div>
    <asp:Label ID="lblEditPassword" runat="server" Text="修改水位密码:" Visible="false"></asp:Label>
    <asp:TextBox ID="txtEditPassword" runat="server" Visible="false" 
            TextMode="Password"></asp:TextBox>
    <asp:CustomValidator
        ID="cvEditPassword" runat="server" ErrorMessage="密码无效" 
            onservervalidate="cvEditPassword_ServerValidate"></asp:CustomValidator>
        
    <asp:Button ID="btnModify" runat="server" Text="修改" Visible ="false" onclick="btnModify_Click" />
    </div>
    
</asp:Content>
