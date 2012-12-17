<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="dDuring.aspx.cs"
    Inherits="YongShuiGuanLiV2.dDuring" Title="无标题页" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <script language="javascript" type="text/javascript">
// <!CDATA[

function during_line_onclick() {

}

// ]]>
    </script>

    <style type="text/css">
        .style1
        {
            width: 89%;
        }
        .style2
        {
            width: 75px;
        }
    .style3
    {
        height: 14.25pt;
        width: 54pt;
        color: teal;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: general;
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
        color: teal;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: general;
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
        color: teal;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
        text-align: right;
        vertical-align: middle;
        white-space: normal;
        border: .5pt solid #3366FF;
        padding-left: 1px;
        padding-right: 1px;
        padding-top: 1px;
    }
    .style6
    {
        height: 14.25pt;
        width: 63pt;
        color: teal;
        font-size: 12.0pt;
        font-weight: 400;
        font-style: normal;
        text-decoration: none;
        font-family: 宋体;
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
    <fieldset style="width: 685px">
        <legend>条件</legend>
            <table cellspacing="1" class="style1">
                <tr>
                    <td class="style2">
                        放水季选择
                    </td>
                    <td>
                        <select name="select2" style="width: 130px">
                            <option>春灌一水</option>
                            <option>春灌二水</option>
                            <option>春灌三水</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        年份选择
                    </td>
                    <td>
                        <select name="select3" style="width: 130px">
                            <option>2010</option>
                            <option>2011</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        用水户选择
                    </td>
                    <td>
                        <select name="select" style="width: 130px">
                            <option>一干管理处</option>
                            <option>二干管理处</option>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td class="style2">
                        &nbsp;
                    </td>
                    <td>
                        <input type="submit" name="Submit" value="查询" style="width: 75px" />
                    </td>
                </tr>
            </table>
    </fieldset>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/d/during.png" />
    </p>
    <table border="0" cellpadding="0" cellspacing="0" style="border-collapse:
 collapse;width:333pt" width="444" x:str="">
        <colgroup>
            <col width="84" />
            <col span="5" width="72" />
        </colgroup>
        <tr height="19">
            <td class="style6" height="19" width="84">
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
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40619">
                2011-3-17</td>
            <td class="style5" width="72" x:num="">
                1</td>
            <td class="style5" width="72" x:num="">
                2</td>
            <td class="style5" width="72" x:num="">
                3</td>
            <td class="style5" width="72" x:num="">
                4</td>
            <td class="style5" width="72" x:num="">
                5</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40620">
                2011-3-18</td>
            <td class="style5" width="72" x:num="">
                2</td>
            <td class="style5" width="72" x:num="">
                3</td>
            <td class="style5" width="72" x:num="">
                4</td>
            <td class="style5" width="72" x:num="">
                5</td>
            <td class="style5" width="72" x:num="">
                6</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40621">
                2011-3-19</td>
            <td class="style5" width="72" x:num="">
                3</td>
            <td class="style5" width="72" x:num="">
                4</td>
            <td class="style5" width="72" x:num="">
                5</td>
            <td class="style5" width="72" x:num="">
                6</td>
            <td class="style5" width="72" x:num="">
                7</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40622">
                2011-3-20</td>
            <td class="style5" width="72" x:num="">
                4</td>
            <td class="style5" width="72" x:num="">
                5</td>
            <td class="style5" width="72" x:num="">
                6</td>
            <td class="style5" width="72" x:num="">
                7</td>
            <td class="style5" width="72" x:num="">
                8</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40623">
                2011-3-21</td>
            <td class="style5" width="72" x:num="">
                5</td>
            <td class="style5" width="72" x:num="">
                13</td>
            <td class="style5" width="72" x:num="">
                7</td>
            <td class="style5" width="72" x:num="">
                8</td>
            <td class="style5" width="72" x:num="">
                9</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40624">
                2011-3-22</td>
            <td class="style5" width="72" x:num="">
                6</td>
            <td class="style5" width="72" x:num="">
                7</td>
            <td class="style5" width="72" x:num="">
                8</td>
            <td class="style5" width="72" x:num="">
                9</td>
            <td class="style5" width="72" x:num="">
                10</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40625">
                2011-3-23</td>
            <td class="style5" width="72" x:num="">
                7</td>
            <td class="style5" width="72" x:num="">
                8</td>
            <td class="style5" width="72" x:num="">
                9</td>
            <td class="style5" width="72" x:num="">
                10</td>
            <td class="style5" width="72" x:num="">
                11</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40626">
                2011-3-24</td>
            <td class="style5" width="72" x:num="">
                8</td>
            <td class="style5" width="72" x:num="">
                9</td>
            <td class="style5" width="72" x:num="">
                10</td>
            <td class="style5" width="72" x:num="">
                11</td>
            <td class="style5" width="72" x:num="">
                12</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40627">
                2011-3-25</td>
            <td class="style5" width="72" x:num="">
                9</td>
            <td class="style5" width="72" x:num="">
                10</td>
            <td class="style5" width="72" x:num="">
                11</td>
            <td class="style5" width="72" x:num="">
                12</td>
            <td class="style5" width="72" x:num="">
                13</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40628">
                2011-3-26</td>
            <td class="style5" width="72" x:num="">
                10</td>
            <td class="style5" width="72" x:num="">
                11</td>
            <td class="style5" width="72" x:num="">
                12</td>
            <td class="style5" width="72" x:num="">
                13</td>
            <td class="style5" width="72" x:num="">
                14</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40629">
                2011-3-27</td>
            <td class="style5" width="72" x:num="">
                11</td>
            <td class="style5" width="72" x:num="">
                12</td>
            <td class="style5" width="72" x:num="">
                13</td>
            <td class="style5" width="72" x:num="">
                14</td>
            <td class="style5" width="72" x:num="">
                15</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40630">
                2011-3-28</td>
            <td class="style5" width="72" x:num="">
                12</td>
            <td class="style5" width="72" x:num="">
                13</td>
            <td class="style5" width="72" x:num="">
                14</td>
            <td class="style5" width="72" x:num="">
                15</td>
            <td class="style5" width="72" x:num="">
                16</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40631">
                2011-3-29</td>
            <td class="style5" width="72" x:num="">
                13</td>
            <td class="style5" width="72" x:num="">
                14</td>
            <td class="style5" width="72" x:num="">
                15</td>
            <td class="style5" width="72" x:num="">
                16</td>
            <td class="style5" width="72" x:num="">
                17</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40632">
                2011-3-30</td>
            <td class="style5" width="72" x:num="">
                14</td>
            <td class="style5" width="72" x:num="">
                15</td>
            <td class="style5" width="72" x:num="">
                16</td>
            <td class="style5" width="72" x:num="">
                17</td>
            <td class="style5" width="72" x:num="">
                18</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40633">
                2011-3-31</td>
            <td class="style5" width="72" x:num="">
                15</td>
            <td class="style5" width="72" x:num="">
                16</td>
            <td class="style5" width="72" x:num="">
                17</td>
            <td class="style5" width="72" x:num="">
                18</td>
            <td class="style5" width="72" x:num="">
                19</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40634">
                2011-4-1</td>
            <td class="style5" width="72" x:num="">
                16</td>
            <td class="style5" width="72" x:num="">
                17</td>
            <td class="style5" width="72" x:num="">
                18</td>
            <td class="style5" width="72" x:num="">
                19</td>
            <td class="style5" width="72" x:num="">
                20</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40635">
                2011-4-2</td>
            <td class="style5" width="72" x:num="">
                17</td>
            <td class="style5" width="72" x:num="">
                18</td>
            <td class="style5" width="72" x:num="">
                19</td>
            <td class="style5" width="72" x:num="">
                20</td>
            <td class="style5" width="72" x:num="">
                21</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40636">
                2011-4-3</td>
            <td class="style5" width="72" x:num="">
                18</td>
            <td class="style5" width="72" x:num="">
                19</td>
            <td class="style5" width="72" x:num="">
                20</td>
            <td class="style5" width="72" x:num="">
                21</td>
            <td class="style5" width="72" x:num="">
                22</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40637">
                2011-4-4</td>
            <td class="style5" width="72" x:num="">
                19</td>
            <td class="style5" width="72" x:num="">
                20</td>
            <td class="style5" width="72" x:num="">
                21</td>
            <td class="style5" width="72" x:num="">
                22</td>
            <td class="style5" width="72" x:num="">
                23</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40638">
                2011-4-5</td>
            <td class="style5" width="72" x:num="">
                20</td>
            <td class="style5" width="72" x:num="">
                21</td>
            <td class="style5" width="72" x:num="">
                22</td>
            <td class="style5" width="72" x:num="">
                23</td>
            <td class="style5" width="72" x:num="">
                24</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40639">
                2011-4-6</td>
            <td class="style5" width="72" x:num="">
                21</td>
            <td class="style5" width="72" x:num="">
                22</td>
            <td class="style5" width="72" x:num="">
                23</td>
            <td class="style5" width="72" x:num="">
                24</td>
            <td class="style5" width="72" x:num="">
                25</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40640">
                2011-4-7</td>
            <td class="style5" width="72" x:num="">
                22</td>
            <td class="style5" width="72" x:num="">
                23</td>
            <td class="style5" width="72" x:num="">
                24</td>
            <td class="style5" width="72" x:num="">
                25</td>
            <td class="style5" width="72" x:num="">
                26</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40641">
                2011-4-8</td>
            <td class="style5" width="72" x:num="">
                23</td>
            <td class="style5" width="72" x:num="">
                24</td>
            <td class="style5" width="72" x:num="">
                25</td>
            <td class="style5" width="72" x:num="">
                26</td>
            <td class="style5" width="72" x:num="">
                27</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40642">
                2011-4-9</td>
            <td class="style5" width="72" x:num="">
                24</td>
            <td class="style5" width="72" x:num="">
                25</td>
            <td class="style5" width="72" x:num="">
                26</td>
            <td class="style5" width="72" x:num="">
                27</td>
            <td class="style5" width="72" x:num="">
                28</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40643">
                2011-4-10</td>
            <td class="style5" width="72" x:num="">
                25</td>
            <td class="style5" width="72" x:num="">
                26</td>
            <td class="style5" width="72" x:num="">
                27</td>
            <td class="style5" width="72" x:num="">
                28</td>
            <td class="style5" width="72" x:num="">
                29</td>
        </tr>
        <tr height="19">
            <td align="right" class="style6" height="19" width="84" x:num="40644">
                2011-4-11</td>
            <td class="style5" width="72" x:num="">
                26</td>
            <td class="style5" width="72" x:num="">
                27</td>
            <td class="style5" width="72" x:num="">
                28</td>
            <td class="style5" width="72" x:num="">
                29</td>
            <td class="style5" width="72" x:num="">
                30</td>
        </tr>
        <tr height="19">
            <td class="style6" height="19" width="84">
                平均</td>
            <td class="style5" width="72" x:num="">
                13.5</td>
            <td class="style5" width="72" x:num="14.769">
                14.769</td>
            <td class="style5" width="72" x:num="">
                15.5</td>
            <td class="style5" width="72" x:num="">
                16.5</td>
            <td class="style5" width="72" x:num="">
                17.5</td>
        </tr>
        <tr height="19">
            <td class="style6" height="19" width="84">
                最大</td>
            <td class="style5" width="72" x:num="">
                26</td>
            <td class="style5" width="72" x:num="">
                27</td>
            <td class="style5" width="72" x:num="">
                28</td>
            <td class="style5" width="72" x:num="">
                29</td>
            <td class="style5" width="72" x:num="">
                30</td>
        </tr>
        <tr height="19">
            <td class="style6" height="19" width="84">
                最小</td>
            <td class="style5" width="72" x:num="">
                1</td>
            <td class="style5" width="72" x:num="">
                2</td>
            <td class="style5" width="72" x:num="">
                3</td>
            <td class="style5" width="72" x:num="">
                4</td>
            <td class="style5" width="72" x:num="">
                5</td>
        </tr>
</table>
</asp:Content>
