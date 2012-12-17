<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCConditionYear.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCConditionYear" %>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"/>
    <fieldset>
    <legend>条件</legend>
    <div>
        <table>
            <tr>
                <td >
                    <asp:Label ID="lblOrganization" runat="server" Text="部门"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlOrganization" runat="server" 
                        onselectedindexchanged="ddlOrganization_SelectedIndexChanged" 
                        AutoPostBack="True" >
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblStation" runat="server" Text="站点"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStation" runat="server" >
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblDate" runat="server" Text="年份"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server" ></asp:TextBox>
                </td>
                <td>
                    <asp:CustomValidator ID="cvDate" runat="server" ErrorMessage="*" onservervalidate="cvBegin_ServerValidate" 
                         ></asp:CustomValidator>
                </td>
            </tr>

            <tr>
                <td >
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnQuery" runat="server" onclick="btnQuery_Click" Text="查询" 
                         />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </fieldset>
