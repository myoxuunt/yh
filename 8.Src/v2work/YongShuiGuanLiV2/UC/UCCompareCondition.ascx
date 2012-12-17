<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCCompareCondition.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCCompareCondition" %>
<asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
<fieldset>
    <legend>条件</legend>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblStation" runat="server" Text="站点"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStation" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDate" runat="server" Text="开始时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateBegin" runat="server"></asp:TextBox>
                    <input id="btnBegin" runat="server" type="button" value="..." />
                </td>
                <td>
                    <asp:CustomValidator ID="cvDateBegin" runat="server" ErrorMessage="*" OnServerValidate="cvBegin_ServerValidate">
                    </asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDate3" runat="server" Text="结束时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateEnd" runat="server"></asp:TextBox>
                    <input id="btnEnd" runat="server" type="button" value="..." />
                </td>
                <td>
                    <asp:CustomValidator ID="cvDateEnd" runat="server" ErrorMessage="*" OnServerValidate="cvEnd_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
        </table>
    </div>
</fieldset>
<fieldset>
    <legend>条件</legend>
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblStation2" runat="server" Text="站点"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlStation2" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDate2" runat="server" Text="开始时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateBegin2" runat="server"></asp:TextBox>
                    <input id="btnBegin2" runat="server" type="button" value="..." />
                </td>
                <td>
                    <asp:CustomValidator ID="cvDateBegin2" runat="server" ErrorMessage="*" OnServerValidate="cvBegin2_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblDate4" runat="server" Text="结束时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtDateEnd2" runat="server"></asp:TextBox>
                    <input id="btnEnd2" runat="server" type="button" value="..." />
                </td>
                <td>
                    <asp:CustomValidator ID="cvDateEnd2" runat="server" ErrorMessage="*" OnServerValidate="cvEnd2_ServerValidate"></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="查询" />
                </td>
                <td>
                </td>
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
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtDateBegin.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
          
      cal.manageFields(
           document.getElementById ("<%=btnBegin2.ClientID%>"),
           document.getElementById("<%=txtDateBegin2.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
          
          
      cal.manageFields(
           document.getElementById ("<%=btnEnd.ClientID%>"),
           document.getElementById("<%=txtDateEnd.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
          
      cal.manageFields(
           document.getElementById ("<%=btnEnd2.ClientID%>"),
           document.getElementById("<%=txtDateEnd2.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
      
    //]]></script> 