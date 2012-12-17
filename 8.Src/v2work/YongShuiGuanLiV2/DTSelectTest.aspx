<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DTSelectTest.aspx.cs" Inherits="YongShuiGuanLiV2.DTSelectTest" %>

<%@ Register src="UC/UCDTTwoOnly.ascx" tagname="UCDTTwoOnly" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>无标题页</title> 
       <script type="text/jscript" src="jscript/jscalsrc/js/jscal2.js"></script>
    <script type="text/jscript" src="jscript/jscalsrc/js/lang/cn.js"></script>
    <link rel="stylesheet" type="text/css" href="jscript/jscalsrc/css/jscal2.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <p>
    <uc1:UCDTTwoOnly ID="UCDTTwoOnly1" runat="server" />
    <uc1:UCDTTwoOnly ID="UCDTTwoOnly2" runat="server" />
    </form>
    </body>
</html>
