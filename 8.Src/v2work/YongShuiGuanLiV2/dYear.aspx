<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dYear.aspx.cs"
    Inherits="YongShuiGuanLiV2.dYear" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            width: 66px;
        }
    .style3
    {
        width: 50px;
    }
    .style4
    {
        height: 14.25pt;
        width: 21pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid windowtext;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style5
    {
        width: 33pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid windowtext;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style6
    {
        height: 14.25pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid windowtext;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style7
    {
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid windowtext;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style8
    {
        height: 14.25pt;
        width: 21pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style9
    {
        width: 33pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style10
    {
        height: 14.25pt;
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style11
    {
        color: windowtext;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: center;
        vertical-align: middle;
        white-space: nowrap;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset>
        <legend>条件</legend>
            <table cellspacing="1" class="style1">
                <tr>
                    <td class="style2">
                        年份选择
                    </td>
                    <td>
                        <select name="select2" style="width: 130px">
                            <option>2009</option>
                            <option>2010</option>
                            <option>2011</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        测点选择
                    </td>
                    <td>
                        <select name="select" style="width: 130px">
                            <option>七亩</option>
                            <option>牛山</option>
                        </select>
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
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse:
 collapse;width:417pt" width="556" x:str="">
        <colgroup>
            <col width="28" />
            <col span="12" width="44" />
        </colgroup>
        <tr height="19">
            <td class="style8" height="19" width="28">
                月</td>
            <td class="style9" width="44" x:num="">
                1</td>
            <td class="style9" width="44" x:num="">
                2</td>
            <td class="style9" width="44" x:num="">
                3</td>
            <td class="style9" width="44" x:num="">
                4</td>
            <td class="style9" width="44" x:num="">
                5</td>
            <td class="style9" width="44" x:num="">
                6</td>
            <td class="style9" width="44" x:num="">
                7</td>
            <td class="style9" width="44" x:num="">
                8</td>
            <td class="style9" width="44" x:num="">
                9</td>
            <td class="style9" width="44" x:num="">
                10</td>
            <td class="style9" width="44" x:num="">
                11</td>
            <td class="style9" width="44" x:num="">
                12</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                1</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.81</td>
            <td class="style11" x:num="">
                8.17</td>
            <td class="style11" x:num="">
                4.57</td>
            <td class="style11" x:num="">
                7.68</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                2</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.79</td>
            <td class="style11" x:num="">
                8.21</td>
            <td class="style11" x:num="">
                4.44</td>
            <td class="style11" x:num="">
                4.98</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                3</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.8</td>
            <td class="style11" x:num="">
                8.08</td>
            <td class="style11" x:num="">
                4.14</td>
            <td class="style11" x:num="">
                3.81</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                4</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.12</td>
            <td class="style11" x:num="">
                6.03</td>
            <td class="style11" x:num="">
                0.92</td>
            <td class="style11" x:num="">
                3.65</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                5</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.86</td>
            <td class="style11" x:num="">
                6.01</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                2.12</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                6</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.24</td>
            <td class="style11" x:num="">
                5.86</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                7</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.87</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                8</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.8</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                9</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                3.82</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                10</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                0.38</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                11</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                1.79</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                12</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                1.9</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                13</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                0.71</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                1.75</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                14</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                1.16</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                2.12</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                15</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                4.51</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                3.45</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                16</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                3.27</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.3</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.27</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                17</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                0.81</td>
            <td class="style11" x:num="">
                3.56</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.02</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.22</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                18</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.83</td>
            <td class="style11" x:num="">
                3.52</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.21</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.16</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                19</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.88</td>
            <td class="style11" x:num="">
                3.36</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.05</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                6.69</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                20</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.6</td>
            <td class="style11" x:num="">
                3.47</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.38</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                6.8</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                21</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                5.91</td>
            <td class="style11" x:num="">
                3.94</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.66</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                6.71</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                22</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.03</td>
            <td class="style11" x:num="">
                6.5</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.23</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.06</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                23</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.05</td>
            <td class="style11" x:num="">
                6.82</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.95</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.18</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                24</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.16</td>
            <td class="style11" x:num="">
                6.88</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                9.37</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.31</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                25</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.33</td>
            <td class="style11" x:num="">
                6.89</td>
            <td class="style11" x:num="">
                0.84</td>
            <td class="style11" x:num="">
                9.05</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.2</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                26</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.44</td>
            <td class="style11" x:num="">
                6.9</td>
            <td class="style11" x:num="">
                1.67</td>
            <td class="style11" x:num="">
                7.55</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.48</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                27</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.17</td>
            <td class="style11" x:num="">
                8.4</td>
            <td class="style11" x:num="">
                1.94</td>
            <td class="style11" x:num="">
                8.08</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.94</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                28</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                7.98</td>
            <td class="style11" x:num="">
                8.34</td>
            <td class="style11" x:num="">
                4.79</td>
            <td class="style11" x:num="">
                8.42</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.19</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                29</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.06</td>
            <td class="style11" x:num="">
                8.37</td>
            <td class="style11" x:num="">
                4.69</td>
            <td class="style11" x:num="">
                8.13</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                6.81</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                30</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.64</td>
            <td class="style11" x:num="">
                8.28</td>
            <td class="style11" x:num="">
                4.67</td>
            <td class="style11" x:num="">
                7.87</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                6.72</td>
        </tr>
        <tr height="19">
            <td class="style10" height="19" x:num="">
                31</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                8.74</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                4.57</td>
            <td class="style11" x:num="">
                7.68</td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:str="    ">
                <span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;</span></td>
            <td class="style11" x:num="">
                4.88</td>
        </tr>
</table>
</asp:Content>
