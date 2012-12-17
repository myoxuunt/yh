<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="pWLAdd.aspx.cs"
    Inherits="YongShuiGuanLiV2.pWLAdd" Title="无标题页" %>

<%@ Register Src="UC/UCWLAdd.ascx" TagName="UCWLAdd" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:UCWLAdd ID="UCWLAdd1" runat="server" IsSelectAllStation="false" />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:ButtonField HeaderText="站名" DataTextField="StationName" />
            <asp:TemplateField HeaderText="时间">
                <ItemTemplate>
                    <asp:TextBox runat="server" ID="txtDT" Text='<%#DataBinder.Eval(Container.DataItem, "DT")%>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="水位(cm)">
                <ItemTemplate>
                    <asp:TextBox runat="server" ID="txtWL" Text='<%#DataBinder.Eval(Container.DataItem, "WL")%>'></asp:TextBox>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:Panel ID="panelOpera" runat="server">
        <table>
            <tbody>
                <tr>
                    <td>
                        <asp:Label ID="lblEditPassword" runat="server" Text="修改水位密码:" ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEditPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:CheckBox ID="chkDeleteHistory" runat="server" Text="删除该日的其他数据" Checked="true" />
                    </td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                        <asp:Button ID="btnModify" runat="server" Text="添加" OnClick="btnModify_Click" />
                    </td>
                </tr>
            </tbody>
        </table>
    </asp:Panel>
</asp:Content>
