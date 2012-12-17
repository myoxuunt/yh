<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCLLWaterUserList.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCLLWaterUserList" %>
<table>
    <tr>
        <td>
            用水户:
        </td>
        <td>
            <asp:CheckBoxList ID="cblLLWaterUser" runat="server" 
                RepeatDirection="Horizontal">
            </asp:CheckBoxList>
        </td>
        <td>
        </td>
    </tr>
</table>
