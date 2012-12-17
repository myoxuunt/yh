
function exec (command) {
    window.oldOnError = window.onerror;
    window._command = command;
    window.onerror = function (err) {
      if (err.indexOf('utomation') != -1) {
        alert('命令已经被用户禁止！'); 
        return true;
      }
      else return false;
    };
    var wsh = new ActiveXObject('WScript.Shell');
    if (wsh)
      wsh.Run(command);
    window.onerror = window.oldOnError;
   
  }

function exeaspx (command) {
    var win = window.open("command",null,"width=700,height=200");
   
  }
  
function menuChange(obj,menu)
{
	if(menu.style.display=="")
	{
		obj.background="Images/left/left_menu2.gif";
		menu.style.display="none";
	}else{
		obj.background="Images/left/left_menu.gif";
		//menu.style.display="none";
		var c=menu.value
		alert(c);
		menu.style.display="";
	}
}
function menuChange3(count,ii)
{
	//循环判断，ss为总列表数,ii为当前列
 for (i=0;i<=count;i++){
   //错误过滤，当i=1至10中有一项以上出错，自动过滤
  try{
   //当i=ii时展开目录数，否则关闭
   if (i==ii){
    //判断i列的目录数是否展开，没有就展开，否则关闭
    if (window.eval("menu"+i).style.display=="none"){
     window.eval("menu"+i).style.display="";
    }else{
     window.eval("menu"+i).style.display="none"; 
    }
   }else{
    window.eval("menu"+i).style.display="none"; 
   }
  }catch(e){}
 }
}
function menuChange2(obj,menu)
{
	if(menu.style.display=="")
	{
		menu.style.display="none";
	}else{
		menu.style.display="";
	}
}

function proLoadimg()
{
	var i=new Image;
	i.src='Images/left/left_menu.gif';
}
proLoadimg();
