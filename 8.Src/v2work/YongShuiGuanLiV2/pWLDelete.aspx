<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pWLDelete.aspx.cs"
    Inherits="YongShuiGuanLiV2.pWLDelete" Title="无标题页" %>

<%@ Register Src="UC/UCChannelStationDTOne.ascx" TagName="UCChannelStationDTOne"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script type="text/javascript">
    function check_all_or_not(chk){
        var value = chk.checked;
        var obj = $(".data_row_checked :checkbox").attr("checked", value);
    }
    
    $(document).ready(function(){
        var id = "#<%=chkSelectAll.ClientID%>";
        $(id).click(function(){
            check_all_or_not(this);
        });
    });
    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCChannelStationDTOne ID="UCChannelStationDTOne1" runat="server" IsSelectAllStation="false" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="DitchDataID">
        <Columns>
            <asp:BoundField DataField="StationName" HeaderText="站名" />
            <asp:BoundField DataField="DT" HeaderText="时间" />
            <asp:BoundField DataField="wl1" HeaderText="水位(cm)" />
            <asp:BoundField DataField="InstantFlux" HeaderText="瞬时流量(m3/s)" />
            <asp:TemplateField HeaderText="删除">
                <ItemTemplate>
                    <asp:CheckBox runat="server" AutoPostBack="false" CssClass="data_row_checked" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Panel ID="panelOpera" runat="server">
        <table>
            <tbody>
                <tr>
                    <td>
                        <asp:Label ID="lblEditPassword" runat="server" Text="修改水位密码:" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEditPassword" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:CustomValidator ID="cvEditPassword" runat="server" ErrorMessage="密码无效" OnServerValidate="cvEditPassword_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkSelectAll" runat="server" Text="选择全部" AutoPostBack="false" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnModify" runat="server" Text="删除" OnClick="btnModify_Click" />
                    </td>
                </tr>
            </tbody>
        </table>
    </asp:Panel>
</asp:Content>
