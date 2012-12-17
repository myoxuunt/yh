<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCConditionDTOne.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCConditionDTOne" %>

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
                    <asp:Label ID="lblDate" runat="server" Text="日期"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDate" runat="server" ></asp:TextBox>
                    <input id="btnDT" runat="server" type="button" value="..." /></td>
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
<script type="text/javascript">//<![CDATA[

      var cal = Calendar.setup({
          onSelect: function(cal) { cal.hide() },
          showTime: true
      });
      cal.manageFields(
           document.getElementById ("<%=btnDT.ClientID%>"),
           document.getElementById("<%=txtDate.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
      
    //]]></script> 