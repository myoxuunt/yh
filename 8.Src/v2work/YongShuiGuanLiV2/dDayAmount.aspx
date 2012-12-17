<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dDayAmount.aspx.cs" Inherits="YongShuiGuanLiV2.dDayAmount" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 90%;
        }
        .style2
        {
            width: 57px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="width: 697px">
<legend> 条件</legend>
        <table class="style1">
            <tr>
                <td class="style2">
    单位</td>
                <td>
  <select name="select" style="width: 130px">
    <option>一干管理处</option>
    <option>二干管理处</option>
    <option>三干管理处</option>
  </select></td>
            </tr>
            <tr>
                <td class="style2">
    日期</td>
                <td>
  <input type="text" name="textfield" style="width: 130px" value="2010-03-17" /></td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                                        <td>
  <input type="submit" name="Submit" value="查询" style="width: 75px" /></td>
                                    </tr>
                                </table>
  </fieldset>
<p><img src="images/d/dayAmount.png" width="700" height="500" alt="" /></p>
<table width="467" border="1">
  <tr>
    <th width="103" scope="col">&nbsp;</th>
    <th width="59" scope="col">七亩</th>
    <th width="57" scope="col">牛山</th>
    <th width="69" scope="col">土门</th>
    <th width="63" scope="col">韩庄</th>
    <th width="76" scope="col">上寨</th>
  </tr>
  <tr>
    <th scope="row">2010-03-17</th>
    <td>1</td>
    <td>2</td>
    <td>3</td>
    <td>4</td>
    <td>5</td>
  </tr>
</table>
</asp:Content>
