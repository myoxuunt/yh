<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCDanRi.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCDanRi" %>
<asp:TextBox ID="txtDay" runat="server"></asp:TextBox>
<input id="btnDay" runat="server" type="button" value="..." />

<script type="text/javascript">//<![CDATA[
     
      var cal = Calendar.setup({
          onSelect: function(cal) { cal.hide() },
          showTime: true
      });
        cal.manageFields(
            document.getElementById("<%=btnDay.ClientID%>"),
            document.getElementById("<%=txtDay.ClientID%>"),
            "%Y-%m-%d");
      
    //]]></script>

