<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dDay.aspx.cs"
    Inherits="YongShuiGuanLiV2.dDay" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 57px;
        }
    .style3
    {
        height: 15.0pt;
        width: 54pt;
        color: windowtext;
        font-size: 10.0pt;
        font-weight: 700;
        font-style: normal;
        text-decoration: none;
        font-family: "Arial Unicode MS", sans-serif;
        text-align: center;
        vertical-align: middle;
        white-space: normal;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style4
    {
        width: 54pt;
        color: windowtext;
        font-size: 10.0pt;
        font-weight: 700;
        font-style: normal;
        text-decoration: none;
        font-family: "Arial Unicode MS", sans-serif;
        text-align: center;
        vertical-align: middle;
        white-space: normal;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style5
    {
        width: 54pt;
        color: windowtext;
        font-size: 10.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: "Arial Unicode MS", sans-serif;
        text-align: general;
        vertical-align: middle;
        white-space: normal;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="width: 761px">
        <legend>条件</legend>
        <table cellspacing="1" class="style1">
            <tr>
                <td class="style2">
                    单位
                </td>
                <td>
                    <select name="select" style="width: 130px">
                        <option>&lt;全部&gt;</option>
                        <option>一干管理处</option>
                        <option>二干管理处</option>
                    </select>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    日期
                </td>
                <td>
                    <input type="text" name="textfield" style="width: 130px" value="2010-01-01" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                </td>
                <td>
                    <input type="submit" name="Submit" value="查询" style="width: 75px" />
                </td>
            </tr>
        </table>
    </fieldset>
    <p>
        <img src="images/d/day.jpg" alt="日水位曲线" name="day_water_line" width="766" height="374"
            id="day_water_line" style="background-color: #C0C0C0" /></p>
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse:
 collapse;width:324pt" width="432" x:str="">
        <colgroup>
            <col span="6" style="width:54pt" width="72" />
        </colgroup>
        <tr height="20">
            <td class="style3" height="20" width="72">
                　</td>
            <td class="style4" width="72">
                七亩</td>
            <td class="style4" width="72">
                牛山</td>
            <td class="style4" width="72">
                土门</td>
            <td class="style4" width="72">
                韩庄</td>
            <td class="style4" width="72">
                上寨</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0">
                00:00</td>
            <td class="style5" width="72">
                &nbsp; 1</td>
            <td class="style5" width="72">
                &nbsp; 2</td>
            <td class="style5" width="72">
                &nbsp; 3</td>
            <td class="style5" width="72">
                &nbsp; 4</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="8.3333333333333329E-2">
                02:00</td>
            <td class="style5" width="72">
                &nbsp;&nbsp; 2</td>
            <td class="style5" width="72">
                &nbsp;&nbsp; 3</td>
            <td class="style5" width="72">
                &nbsp; 4</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.16666666666666666">
                04:00</td>
            <td class="style5" width="72">
                &nbsp;&nbsp; 3</td>
            <td class="style5" width="72">
                &nbsp; 4</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.25">
                06:00</td>
            <td class="style5" width="72">
                &nbsp; 4</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.33333333333333331">
                08:00</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.41666666666666669">
                10:00</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.5">
                12:00</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
            <td class="style5" width="72">
                &nbsp; 11</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.58333333333333337">
                14:00</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
            <td class="style5" width="72">
                &nbsp; 11</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.66666666666666663">
                16:00</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
            <td class="style5" width="72">
                &nbsp; 11</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
            <td class="style5" width="72">
                &nbsp; 13</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.75">
                18:00</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
            <td class="style5" width="72">
                &nbsp; 11</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
            <td class="style5" width="72">
                &nbsp; 13</td>
            <td class="style5" width="72">
                &nbsp; 14</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.83333333333333337">
                20:00</td>
            <td class="style5" width="72">
                &nbsp; 11</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
            <td class="style5" width="72">
                &nbsp; 13</td>
            <td class="style5" width="72">
                &nbsp; 14</td>
            <td class="style5" width="72">
                &nbsp; 15</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72" x:num="0.91666666666666663">
                22:00</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
            <td class="style5" width="72">
                &nbsp; 13</td>
            <td class="style5" width="72">
                &nbsp; 14</td>
            <td class="style5" width="72">
                &nbsp; 15</td>
            <td class="style5" width="72">
                &nbsp; 16</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72">
                平均</td>
            <td class="style5" width="72">
                &nbsp; 6</td>
            <td class="style5" width="72">
                &nbsp; 7</td>
            <td class="style5" width="72">
                &nbsp; 8</td>
            <td class="style5" width="72">
                &nbsp; 9</td>
            <td class="style5" width="72">
                &nbsp; 10</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72">
                最大</td>
            <td class="style5" width="72">
                &nbsp; 12</td>
            <td class="style5" width="72">
                &nbsp; 13</td>
            <td class="style5" width="72">
                &nbsp; 14</td>
            <td class="style5" width="72">
                &nbsp; 15</td>
            <td class="style5" width="72">
                &nbsp;&nbsp; 16</td>
        </tr>
        <tr height="20">
            <td class="style3" height="20" width="72">
                最小</td>
            <td class="style5" width="72">
                &nbsp; 1</td>
            <td class="style5" width="72">
                &nbsp; 2</td>
            <td class="style5" width="72">
                &nbsp; 3</td>
            <td class="style5" width="72">
                &nbsp; 4</td>
            <td class="style5" width="72">
                &nbsp; 5</td>
        </tr>
</table>
</asp:Content>
