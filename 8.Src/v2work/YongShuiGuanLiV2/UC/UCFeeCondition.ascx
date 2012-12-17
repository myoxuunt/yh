<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCFeeCondition.ascx.cs"
    Inherits="YongShuiGuanLiV2.UC.UCFeeCondition" %>
<fieldset>
    <legend>条件</legend>
    <table>
        <tr>
            <td>
                <asp:Label ID="lblWaterUser" runat="server" Text="下级单位"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlWaterUser" runat="server">
                </asp:DropDownList>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBegin" runat="server" Text="开始时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                <input id="btnBegin" runat="server" type="button" value="..." />
            </td>
            <td>
                <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="*" 
                    onservervalidate="cvBegin_ServerValidate" ></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEnd" runat="server" Text="开始时间"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
                <input id="btnEnd" runat="server" type="button" value="..." />
            </td>
            <td>
                <asp:CustomValidator ID="cvEnd" runat="server" ErrorMessage="*" 
                    onservervalidate="cvEnd_ServerValidate" ></asp:CustomValidator>
            </td>
        </tr>
         <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        <asp:button id="btnquery" runat="server" onclick="btnquery_click" text="查询" />
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
    </table>
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

