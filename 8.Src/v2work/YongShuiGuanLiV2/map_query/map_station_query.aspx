<%@ Page Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="map_station_query.aspx.cs" Inherits="YongShuiGuanLiV2.map_query.map_station_query" Title="无标题页" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<asp:Panel ID="panel1" runat="server">
<asp:LinkButton ID="LinkButton1"  
            style="Z-INDEX: 128; LEFT: 694px; POSITION: absolute; TOP: 468px; width: 71px; height: 12px;" 
            runat="server">六支渠测站</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2"  
            style="Z-INDEX: 128; LEFT: 610px; POSITION: absolute; TOP: 475px; width: 67px;" 
              runat="server">七支渠测站</asp:LinkButton>
         <asp:LinkButton ID="LinkButton3"  
            style="Z-INDEX: 128; LEFT: 655px; POSITION: absolute; TOP: 528px; width: 63px;" 
              runat="server" >王平测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton24"  
            style="Z-INDEX: 128; LEFT: 246px; POSITION: absolute; TOP: 362px;" 
              runat="server"  >霍宾台雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton25"  
            style="Z-INDEX: 128; LEFT: 324px; POSITION: absolute; TOP: 429px;" 
              runat="server"  >回舍雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton4"  
            style="Z-INDEX: 128; LEFT: 427px; POSITION: absolute; TOP: 504px;" 
              runat="server"  >老虎洞测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton5"  
            style="Z-INDEX: 128; LEFT: 541px; POSITION: absolute; TOP: 593px;" 
              runat="server"  >杨西冶测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton6"  
            style="Z-INDEX: 128; LEFT:490px; POSITION: absolute; TOP: 605px; bottom: 231px;" 
              runat="server">西冶测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton7"  
            style="Z-INDEX: 128; LEFT: 500px; POSITION: absolute; TOP: 623px; height: 14px; width: 59px;" 
              runat="server" >封城测站</asp:LinkButton>
             <asp:LinkButton ID="LinkButton28"  
            style="Z-INDEX: 128; LEFT: 417px; POSITION: absolute; TOP: 595px; height: 14px; width: 74px;" 
              runat="server"  >封城配水闸</asp:LinkButton>
              <asp:LinkButton ID="LinkButton29"  
            style="Z-INDEX: 128; LEFT: 605px; POSITION: absolute; TOP: 620px; height: 14px; width: 74px;" 
              runat="server" >宋西冶配水闸</asp:LinkButton>
            <asp:LinkButton ID="LinkButton8"  
            style="Z-INDEX: 128; LEFT: 651px; POSITION: absolute; TOP: 643px; height: 14px; width: 70px;" 
              runat="server"  >南分干测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton9"  
            style="Z-INDEX: 128; LEFT: 703px; POSITION: absolute; TOP: 625px; height: 14px; width: 83px;" 
              runat="server">北分干测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton20"  
            style="Z-INDEX: 128; LEFT: 768px; POSITION: absolute; TOP: 637px; height: 14px; width: 83px; right: 284px;" 
              runat="server">里庄雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton10"  
            style="Z-INDEX: 128; LEFT: 763px; POSITION: absolute; TOP: 595px; height: 14px; width: 85px;" 
              runat="server"  >采石场测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton11"  
            style="Z-INDEX: 128; LEFT: 931px; POSITION: absolute; TOP: 620px; height: 14px; width: 63px;" 
              runat="server"  >二岔口测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton12"  
            style="Z-INDEX: 128; LEFT: 880px; POSITION: absolute; height: 14px; width: 71px; top: 650px;" 
             runat="server" >南石桥测站</asp:LinkButton>
             <asp:LinkButton ID="LinkButton36"  
            style="Z-INDEX: 128; LEFT: 899px; POSITION: absolute; height: 14px; width: 82px; top: 661px;" 
             runat="server" >南石桥雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton13"  
            style="Z-INDEX: 128; LEFT: 907px; POSITION: absolute; TOP: 534px; height: 14px; width: 309px;" 
              runat="server">牛山泄水闸测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton30"  
            style="Z-INDEX: 128; LEFT: 907px; POSITION: absolute; TOP: 551px; height: 14px; width: 309px;" 
              runat="server">牛山泄雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton14"  
            style="Z-INDEX: 128; LEFT: 1078px; POSITION: absolute; TOP: 853px; height: 14px; width: 65px;" 
              runat="server">山前测站</asp:LinkButton>
             <asp:LinkButton ID="LinkButton31"  
            style="Z-INDEX: 128; LEFT: 1078px; POSITION: absolute; TOP: 867px; height: 14px; width: 65px;" 
              runat="server">山前雨量站</asp:LinkButton>
             <asp:LinkButton ID="LinkButton21"  
            style="Z-INDEX: 128; LEFT: 1116px; POSITION: absolute; TOP: 787px; height: 14px; width: 65px;" 
              runat="server">宜安雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton15"  
            style="Z-INDEX: 128; LEFT: 1234px; POSITION: absolute; TOP: 1362px; height: 14px; width: 80px;" 
             runat="server">大孝庄测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton32"  
            style="Z-INDEX: 128; LEFT: 1232px; POSITION: absolute; TOP: 1379px; height: 14px; width: 80px;" 
             runat="server">大孝庄雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton22"  
            style="Z-INDEX: 128; LEFT: 1106px; POSITION: absolute; TOP: 1174px; height: 14px; width: 80px;" 
             runat="server">城关雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton16"  
            style="Z-INDEX: 128; LEFT: 1194px; POSITION: absolute; TOP: 1620px; height: 14px; width: 80px;" 
              runat="server">南任村测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton33"  
            style="Z-INDEX: 128; LEFT: 1194px; POSITION: absolute; TOP: 1640px; height: 14px; width: 80px;" 
              runat="server">南任村雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton23"  
            style="Z-INDEX: 128; LEFT: 1322px; POSITION: absolute; TOP: 1649px; height: 14px; width: 80px;" 
              runat="server">铜冶雨量站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton17"  
            style="Z-INDEX: 128; LEFT: 1358px; POSITION: absolute; TOP: 1638px; height: 14px; width: 76px;" 
              runat="server">马山头测站</asp:LinkButton>
            <asp:LinkButton ID="LinkButton34"  
            style="Z-INDEX: 128; LEFT: 1367px; POSITION: absolute; TOP: 1853px; height: 14px; width: 76px;" 
              runat="server">马山头雨量站</asp:LinkButton>
            <asp:LinkButton  ID="LinkButton18"
            style="Z-INDEX: 128; LEFT: 1350px; POSITION: absolute; TOP: 1950px; height: 14px; width: 71px;" 
             runat="server">范庄测站</asp:LinkButton>
             <asp:LinkButton  ID="LinkButton35"
            style="Z-INDEX: 128; LEFT: 1286px; POSITION: absolute; TOP: 1935px; height: 14px; width: 71px;" 
             runat="server">范庄雨量站</asp:LinkButton>
            
            <asp:LinkButton  ID="LinkButton26"
            style="Z-INDEX: 128; LEFT: 524px; POSITION: absolute; TOP: 898px; height: 14px; width: 71px;" 
             runat="server">九石洞水闸</asp:LinkButton>
             <asp:LinkButton  ID="LinkButton27"
            style="Z-INDEX: 128; LEFT: 533px; POSITION: absolute; TOP: 953px; width: 64px;" 
             runat="server">引冶渠首</asp:LinkButton>
             
            <input name="test" id="test" 
               style="Z-INDEX: 128; LEFT: 652px; POSITION: absolute; TOP: 720px; height: 21px; width: 20px;"  
               type="image"  src="../images/配水中心.gif" onmouseover= "clickme(this);" 
               onmouseout="clickme1(this);" />
            <script type="text/javascript">
            function clickme(obj)   
            {   
                obj.height="30px";
                obj.width="31px";
                obj.src="../images/配水中心.gif";   
            }
            function clickme1(obj)   
            {   
                obj.src="../images/配水中心1.gif";   
            }
            
            </script>
            
            <asp:LinkButton ID="LinkButton19"  
            style="Z-INDEX: 128; LEFT: 671px; POSITION: absolute; TOP: 723px; height: 14px; width: 70px;" 
              runat="server"  >配水中心</asp:LinkButton>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/yehe.gif" />
        </asp:Panel>

</div>
</asp:Content>
