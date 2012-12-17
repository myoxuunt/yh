<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCDTTwoOnly.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCDTTwoOnly" %>
<div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"/>
    <fieldset>
        <legend>条件</legend>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblBegin" runat="server" Text="开始时间"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                        <input id="btnBegin" runat="server" type="button" value="..." />
                    </td>
                    <td>
                        <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="*" OnServerValidate="cvBegin_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEnd" runat="server" Text="结束时间"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
                        <input id="btnEnd" runat="server" type="button" value="..." />
                    </td>
                    <td>
                        <asp:CustomValidator ID="cvEnd" runat="server" ErrorMessage="*" OnServerValidate="cvEnd_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="查询" />
                    </td>
                    <td>
                        &nbsp;
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
           /*"btnBegin", */
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtBegin.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
      
        cal.manageFields(
            document.getElementById("<%=btnEnd.ClientID%>"), 
            document.getElementById("<%=txtEnd.ClientID%>"), 
            "%Y-%m-%d %H:%M:%S");
      /*
      cal.manageFields("f_btn2", "f_date2", "%b %e, %Y");
      cal.manageFields("f_btn3", "f_date3", "%e %B %Y");
      cal.manageFields("f_btn4", "f_date4", "%A, %e %B, %Y");
      */

    //]]></script> 
</div>
