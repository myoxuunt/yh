<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pFormula.aspx.cs" Inherits="YongShuiGuanLiV2.pFormula" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table >
    <tr>
        <td>
        <asp:Label ID="lblStationName" runat="server" Text="站名"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="txtStationName" runat="server" ReadOnly="true"></asp:TextBox>
        </td>
        <td></td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label1" runat="server" Text="放水季名称"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="ddlDuringWaterName" runat="server" AutoPostBack = "true"
                    onselectedindexchanged="ddlDuringWaterName_SelectedIndexChanged"></asp:DropDownList>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label2" runat="server" Text="开始时间"></asp:Label>
            </td>
            <td>
                
                <asp:TextBox ID="txtBegin" runat="server"></asp:TextBox>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="Label3" runat="server" Text="结束时间"></asp:Label>
            </td>
            <td>
                
                <asp:TextBox ID="txtEnd" runat="server"></asp:TextBox>
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
        <td>
        <asp:Label ID="lblFormula" runat="server" Text="流量计算公式"></asp:Label>
        </td>
        <td>
        <asp:TextBox ID="txtFormula" runat="server" ></asp:TextBox>
        </td>
        <td></td>
        </tr>
        
        <tr>
        <td></td>
        <td>
        <asp:Button ID="btnOK" runat="server" Text ="确定" onclick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="取消" onclick="btnCancel_Click" />
        </td>
        <td></td>
        </tr>
    </table>
</asp:Content>
