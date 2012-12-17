<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCMulitYearCondition.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCMulitYearCondition" %>

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
                        AutoPostBack="True" >
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblBeginYear" runat="server" Text="起始年份"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlBeginYear" runat="server" >
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:CustomValidator ID="cvEndYear" runat="server" ErrorMessage="*">
                    </asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblEndYear" runat="server" Text="结束年份"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlEndYear" runat="server" >
                    </asp:DropDownList>
                </td>
                <td>
                    <asp:CustomValidator ID="cvBeginYear" runat="server" ErrorMessage="*">
                    </asp:CustomValidator>
                </td>
            </tr>

            <tr>
                <td >
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btnQuery" runat="server"  Text="查询" onclick="btnQuery_Click" 
                         />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </div>
    </fieldset>