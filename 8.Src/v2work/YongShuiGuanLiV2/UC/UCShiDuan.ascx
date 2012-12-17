<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCShiDuan.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCShiDuan" %>

<asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                    <input id="btnBegin" runat="server" type="button" value="..." />
                    <br />
                    <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
                    <input id="btnEnd" runat="server" type="button" value="..." />
                    
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