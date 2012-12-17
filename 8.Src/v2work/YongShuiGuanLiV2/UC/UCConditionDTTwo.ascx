<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCConditionDTTwo.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCConditionDTTwo" %>

<div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
            DisplayMode="List" />
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
                    <asp:Label ID="lblBegin" runat="server" Text="开始时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtBegin" runat="server" ></asp:TextBox>
                    <input id="btnBegin" runat="server" type="button" value="..." /></td>
                <td>
                    <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="*" 
                        onservervalidate="cvBegin_ServerValidate" >*</asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td >
                    <asp:Label ID="lblEnd" runat="server" Text="结束时间"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtEnd" runat="server" ></asp:TextBox>
                    <input id="btnEnd" runat="server" type="button" value="..." /></td>
                <td>
                    <asp:CustomValidator ID="cvEnd" runat="server" ErrorMessage="*" 
                        onservervalidate="cvEnd_ServerValidate" ></asp:CustomValidator>
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
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtBegin.ClientID%>"),
          "%Y-%m-%d %H:%M:%S");
      
        cal.manageFields(
            document.getElementById("<%=btnEnd.ClientID%>"), 
            document.getElementById("<%=txtEnd.ClientID%>"), 
            "%Y-%m-%d %H:%M:%S");
    //]]></script> 
    </div>