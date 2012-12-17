<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCWLAdd.ascx.cs" Inherits="YongShuiGuanLiV2.UC.UCWLAdd" %>
<div>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
    <fieldset>
        <legend>条件</legend>
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblOrganization" runat="server" Text="渠道:"></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlChannel" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlChannel_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblStation" runat="server" Text="站点:"></asp:Label>
                    </td>
                    <td>
                        <asp:CheckBoxList ID="cblStation" runat="server" RepeatDirection="Horizontal">
                        </asp:CheckBoxList>
                    </td>
                    <td>
                        <asp:CustomValidator ID="cvSelectionStation" runat="server" 
                            ErrorMessage="*" onservervalidate="cvSelectionStation_ServerValidate"></asp:CustomValidator>
</td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblBegin" runat="server" Text="日期:"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
                        <input id="btnBegin" runat="server" type="button" value="..." />
                    </td>
                    <td>
                        <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="*" OnServerValidate="cvBegin_ServerValidate">*</asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                    <asp:Label runat="server" ID="lblInterval" Text="记录间隔:"></asp:Label>
                    </td>
                    <td>
                    <asp:TextBox runat="server" ID="txtInterval" Text="10" ></asp:TextBox>
                    </td>
                    <td>
                    <asp:CustomValidator runat="server" ID="cvInterval" Text="*" ErrorMessage="无效的数据" 
                            onservervalidate="cvInterval_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label runat="server" id="lblBaseWL" Text="基准水位"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtBaseWL" text="0"></asp:TextBox>
                    </td>
                    <td>
                    <asp:CustomValidator runat="server" ID="cvBaseWL" Text="*" ErrorMessage="无效的数据" 
                            onservervalidate="cvBaseWL_ServerValidate"></asp:CustomValidator>
                    </td>
                </tr>
                 <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server" OnClick="btnQuery_Click" Text="生成数据" />
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
          showTime: false 
      });
      cal.manageFields(
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtBegin.ClientID%>"),
          "%Y-%m-%d");
      
    //]]>function btnBegin_onclick() {


    </script>

</div>
