<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCWUsedWater1.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCWUsedWater1" %>
<%@ Register src="UCShiDuan.ascx" tagname="UCShiDuan" tagprefix="uc1" %>
<%@ Register src="UCDanRi.ascx" tagname="UCDanRi" tagprefix="uc2" %>
<style type="text/css">
    .style1
    {
        width: 167px;
    }
    .style2
    {
        width: 104px;
    }
    .style3
    {
        width: 105px;
    }
    .style5
    {
        width: 106px;
        height: 133px;
    }
    .style6
    {
        width: 167px;
        height: 133px;
    }
    .style7
    {
        width: 105px;
        height: 134px;
    }
    .style8
    {
        width: 167px;
        height: 134px;
    }
    .style9
    {
        width: 106px;
    }
</style>
<fieldset>
    <legend>条件</legend>
    <table>
    <tr>
    <td class="style2">
        <asp:RadioButton ID="RadioButton1" runat="server" Text="用水户查询" GroupName="wang" AutoPostBack="True"
            oncheckedchanged="RadioButton1_CheckedChanged"/>
            </td>
         <td>   
        <asp:RadioButton ID="RadioButton2" runat="server" Text="渠道查询" GroupName="wang" AutoPostBack="True"
            oncheckedchanged="RadioButton2_CheckedChanged"/>
    </td>
    </tr>
    <tr>
    <td class="style2">
        <asp:Label ID="Label6" runat="server" Text="查询时间"></asp:Label>
        </td>
        <td>
        <asp:Panel ID="panelShiDuan" runat="server" TabIndex="200">
                    <uc1:UCShiDuan ID="UCShiDuan1" runat="server" />
        </asp:Panel>
        </td>
        </tr>
    </table>
    <div id="hidden_yonghu" runat="server">
    <table>
        <tr>
            <td class="style3">
            <asp:Label ID="Label1" runat="server" Text="用户选择:"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td class="style3">
            <asp:Label ID="Label2" runat="server" Text="管理处:"></asp:Label>
            </td>
            <td class="style1">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
            <asp:Label ID="Label3" runat="server" Text="管理所:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
            <asp:Label ID="Label4" runat="server" Text="村:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td class="style7">
        <asp:Label ID="Label5" runat="server" Text="已选条件"></asp:Label>
        </td>
        <td class="style8">
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" Height="112px" 
                Width="158px">
            </asp:CheckBoxList>
        </td>
        
        <tr>
        <td class="style3">
        <asp:Label ID="labText" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td>
            <asp:Button ID="Button1" runat="server" Text="添加" OnClick="Button1_Click1" style="float:left"/>
            <asp:Button ID="Button2" runat="server" Text="删除" OnClick="Button2_Click1" style="float:right"/>
        </td>
        <td>
        </td>
        <td>
        <asp:Button ID="btnOK" runat="server" Text="查询" OnClick="btnOK_Click" style="float:left"/>
        </td>
        </tr>
        
     </table>
     </div>
     
     <div id="hidden_qudao" runat="server">
     <table>
        <tr>
            <td class="style9">
            <asp:Label ID="Label7" runat="server" Text="渠道选择:"></asp:Label>
            </td>
            
        </tr>
        <tr>
            <td class="style9">
            <asp:Label ID="Label8" runat="server" Text="干渠:"></asp:Label>
            </td>
            <td class="style1">
                <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList4_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
            <asp:Label ID="Label9" runat="server" Text="支渠:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList5" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList5_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
            <td>
            <asp:Label ID="Label10" runat="server" Text="斗渠:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList6" runat="server" AutoPostBack="True" 
                    onselectedindexchanged="DropDownList6_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
        <td class="style5">
        <asp:Label ID="Label11" runat="server" Text="已选条件"></asp:Label>
        </td>
        <td class="style6">
            <asp:CheckBoxList ID="CheckBoxList2" runat="server" Height="112px" 
                Width="158px">
            </asp:CheckBoxList>
        </td>
        
        </tr>
        <tr>
        <td class="style9">
        <asp:Label ID="labText2" runat="server" ForeColor="Red"></asp:Label>
        </td>
        <td>
            <asp:Button ID="Button3" runat="server" Text="添加" OnClick="Button3_Click" style="float:left"/>
            <asp:Button ID="Button4" runat="server" Text="删除" OnClick="Button4_Click" style="float:right"/>
        </td>
        <td>
        </td>
        <td>
        <asp:Button ID="Button5" runat="server" Text="查询" OnClick="Button5_Click" style="float:left"/>
        </td>
        </tr>
        
     </table>
     </div>
</fieldset>
