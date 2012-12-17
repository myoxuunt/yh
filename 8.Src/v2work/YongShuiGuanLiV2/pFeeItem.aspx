<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pFeeItem.aspx.cs"
    Inherits="YongShuiGuanLiV2.pFeeItem" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List" />
    <table>
        <tr>
            <td>
                <asp:Label ID="lblWaterUser" runat="server" Text="用水户:"></asp:Label>
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
                <asp:Label ID="lblFeeName" runat="server" Text="行水项目:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtFeeName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:CustomValidator ID="cvName" runat="server" ErrorMessage="CustomValidator" OnServerValidate="cvName_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblUnitPrice" runat="server" Text="水费标准:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUnitPrice" runat="server">0</asp:TextBox>(元/立方米)
            </td>
            <td>
                <asp:CustomValidator ID="cvUnitPrice" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvUnitPrice_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBegin" runat="server" Text="开始时间:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
            </td>
            <td>
                <input id="btnBegin" type="button" runat="server" value="..." />
                <asp:CustomValidator ID="cvBegin" runat="server" ErrorMessage="CustomValidator" OnServerValidate="cvBegin_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblEnd" runat="server" Text="结束时间:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
            </td>
            <td>
                <input id="btnEnd" type="button" runat="server" value="..." />
                <asp:CustomValidator ID="cvEnd" runat="server" ErrorMessage="CustomValidator" OnServerValidate="cvEnd_ServerValidate">
                </asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="lbltianshu" Text="天数:"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtTianShu" ReadOnly="True" ForeColor="Blue">0</asp:TextBox>
            </td>
            <td>
            <asp:Button ID="btnDays" runat="server" Text="计算" OnClick="btnDays_Click" 
                    Width="48px" />
            </td>
            <td>
                <asp:CustomValidator runat="server" ID="cvTianShu"></asp:CustomValidator>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="lblUsedAmount" runat="server" Text="总用水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWaterAmount" runat="server" ReadOnly="True" 
                    ForeColor="Blue">0</asp:TextBox>
                (万立方米)</td>
            <td>
                <asp:CustomValidator ID="cvUsedTotal" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvUsedTotal_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblTotalPrice" runat="server" Text="损耗水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtWaterLost" runat="server">0</asp:TextBox>
                (万立方米)</td>
            <td>
                <asp:CustomValidator ID="cvTotalPrice" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvTotalPrice_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPayAmount" runat="server" Text="结算水量:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsedAmount" runat="server" ForeColor="Blue" ReadOnly="True">0</asp:TextBox>
                (万立方米)</td>
            <td>
                <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvUsedTotal_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Label ID="lalUsedPrice" runat="server" Text="结算水费:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtUsedPrice" runat="server" ForeColor="Blue" ReadOnly="True">0</asp:TextBox>
                (元)</td>
            <td>
                <asp:CustomValidator ID="CustomValidator2" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvTotalPrice_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblPayPrice" runat="server" Text="实付水费:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPayPrice" runat="server">0</asp:TextBox>
                (元)</td>
            <td>
                <asp:CustomValidator ID="CustomValidator3" runat="server" ErrorMessage="CustomValidator"
                    OnServerValidate="cvTotalPrice_ServerValidate"></asp:CustomValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lalLeftPrice" runat="server" Text="剩余水费:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtLeftPrice" runat="server" ReadOnly="True" ForeColor="Blue">0</asp:TextBox>
                (元)</td>
            <td>
            <asp:Button ID="btnLeft" runat="server" Text="计算" OnClick="btnLeft_Click" 
                    Width="48px" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td valign="top">
                <asp:Label ID="lblRemark" runat="server" Text="备注"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtRemark" runat="server" Height ="150px" TextMode="MultiLine"></asp:TextBox>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
            </td>
            <td>
            </td>
        </tr>
    </table>

    <script type="text/javascript">//<![CDATA[

      var cal = Calendar.setup({
          onSelect: function(cal) { cal.hide() },
          showTime: true
      });
      cal.manageFields(
           document.getElementById ("<%=btnBegin.ClientID%>"),
           document.getElementById("<%=txtBegin.ClientID%>"),
          "%Y-%m-%d");
      
        cal.manageFields(
            document.getElementById("<%=btnEnd.ClientID%>"), 
            document.getElementById("<%=txtEnd.ClientID%>"), 
            "%Y-%m-%d");
                //]]></script>

</asp:Content>
