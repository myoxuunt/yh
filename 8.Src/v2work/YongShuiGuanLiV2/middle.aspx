<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="middle.aspx.cs" Inherits="YongShuiGuanLiV2.middle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<HEAD>
		<title>无标题文档</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<style type="text/css"> <!-- .style1 {color: #000000}
	body { margin-left: 0px; margin-top: 0px; }
	        #form1
            {
                height: 569px;
            }
	-->
		</style>
	</HEAD>
	<body scroll="no" >
		<form id="form1" method="post" runat="server">
			<table id="t1" border="0" cellpadding="0" cellspacing="0" style="background-color:#4890C2"
                onClick="javascript:shframe()" style="height: 100%;">
				<tr>
					<td id="tdd"  width="5" onclick="javascript:imgclick()"><img id="image" src="images/left/jt1.jpg" /></td>
				</tr>
			</table>
			<script language="javascript">
			var s=true;   
			function imgclick()
			{
				im=document.getElementById("image");
				td11=document.getElementById("tdd");
				if(s)
				{
				
					td11.bgcolor="#3472BB";
					im.src="images/left/jt2.jpg";
					im.alt="展开左栏";
				}
				else
				{
					td11.bgcolor="#50D7F5";
					im.src="images/left/jt1.jpg";
					im.alt="隐藏左栏";
				}
				s=!s;
			}
			function   shframe()   
			{   
  
				if(parent.cen.cols   ==   "0,5,*")   
					parent.cen.cols   =   "155,5,*"; 
				else   
					parent.cen.cols   =   "0,5,*";   
			}   
			</script>
		</form>
	</body>
</html>
