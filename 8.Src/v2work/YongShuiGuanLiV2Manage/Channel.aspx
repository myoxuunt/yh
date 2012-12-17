<%@ Page 
Language="C#" 
MasterPageFile="~/Site1.Master" 
AutoEventWireup="true" 
CodeBehind="Channel.aspx.cs" Inherits="YongShuiGuanLiV2Manage.Channel"
Title="无标题页" 
Trace="false"
%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script src="jquery.js" type="text/javascript"></script>
    <script src="iColorPicker.js" type="text/javascript"></script>
    <script type="text/javascript">
    
            function only_check(chk){
                $(":checkbox").attr("checked", false);
                chk.checked = true;
            }
            
            $(document).ready(function(){
                   $(":checkbox").click(function(){
                       only_check(this);
                   });
            });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>渠道信息</h2>

    <table border="0px" cellspacing="3" cellpadding="3" width="100%">
        <tr>
            <td>
                <table align="left" >
                    <tr>
                        <td colspan="3">
                            <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="List"/>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:Label ID="Label1" runat="server" Text="渠道名称:"></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtChannelName" runat="server" OnTextChanged="txtChannelName_TextChanged"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtChannelName"
                                ErrorMessage="RequiredFieldValidator" SetFocusOnError="True">*</asp:RequiredFieldValidator><asp:CustomValidator
                                    ID="CustomValidator1" runat="server" ErrorMessage="CustomValidator" OnServerValidate="CustomValidator1_ServerValidate"
                                    SetFocusOnError="True">*</asp:CustomValidator>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="Label3" runat="server" Text="渠道站点:"></asp:Label>
                        </td>
                        <td valign="top">
                            
                            <asp:DataList ID="dlStation" runat="server">
                            <ItemTemplate>
                            <asp:CheckBox ID ="chkSelected" Width="200px" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"StationName") %>' /> 
                            <asp:TextBox ID="txtColor" runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"ColorString") %>' CssClass ="iColorPicker" EnableTheming="False" Width="80px"></asp:TextBox>
                            </ItemTemplate>
                            </asp:DataList>
                        </td>
                        <td valign="top">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnAddStation" runat="server" Text="添加站点" OnClick="btnAddStation_Click"
                                            />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnDeleteStation" runat="server" Text="移除站点" OnClick="btnDeleteStation_Click"
                                            />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnStationUp" runat="server" Text="站点上移" 
                                            onclick="btnStationUp_Click" />
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Button ID="btnStationDown" runat="server" Text="站点下移" 
                                            onclick="btnStationDown_Click" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td valign="top">
                            <asp:Label ID="Label2" runat="server" Text="备注:"></asp:Label>
                        </td>
                        <td colspan="2">
                            <asp:TextBox ID="txtChannelRemark" runat="server" 
                                Height="100px" TextMode="MultiLine"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3" align="center">
                            <asp:Button ID="btnOK" runat="server" Text="确定" OnClick="btnOK_Click" />
                             &nbsp;
                            <asp:Button ID="btnCancel" runat="server" Text="取消" onclick="btnCancel_Click" />
                            
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>


</asp:Content>