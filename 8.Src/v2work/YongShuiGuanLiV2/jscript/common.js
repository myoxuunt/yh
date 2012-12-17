
            /*
             *
             */
            function writeCookie(name, value, hours)
            {
                var expire = "";
                if(hours != null)
                {
                    expire = new Date((new Date()).getTime() + hours * 3600000);
                    expire = "; expires=" + expire.toGMTString();
                }
                document.cookie = name + "=" + escape(value) + expire;
            }

            /*
             *
             */
            function readCookie(name)
            {
                var cookieValue = "";
                var search = name + "=";
                if(document.cookie.length > 0)
                { 
                    offset = document.cookie.indexOf(search);
                    if (offset != -1)
                    { 
                        offset += search.length;
                        end = document.cookie.indexOf(";", offset);
                        if (end == -1) end = document.cookie.length;
                        cookieValue = unescape(document.cookie.substring(offset, end))
                    }
                }
                return cookieValue;
            }

            /*
            *
            */
            function hideall()
            {
                var menucount = 8;
                var i;
                for( i=0; i<menucount; i++)
                {
                    var menuname = 'menu' + i;
                    document.getElementById(menuname).style.display = 'none';
                    document.getElementById(menuname).onclick=function(){this.classname='curr'};
                }
                /*
                document.getElementById('menua').style.display='none';
                document.getElementById('menub').style.display='none';
                document.getElementById('menuc').style.display='none';
                */
            }

            function showmenu(menuid)
            {
                hideall();
                document.getElementById(menuid).style.display='block';
                writeCookie('selectedmenu', menuid);
            }

            function showselectedmenu()
            {
                hideall ();
                var v = readCookie('selectedmenu');
                if(v != "")
                {
                    document.getElementById(v).style.display='block';
                }
            }

            /*
            *
            */
      function setup_calender_with_format( buttonid, textid, format) {
        var btn = document.getElementById (buttonid);
        if( btn == undefined )
        {
            throw 'not find button by id: ' + buttonid;
        }
        
        var txt = document.getElementById(textid);
        if ( txt == undefined )
        {
            throw 'not find text by id: ' + textid;
        }

        var cal = Calendar.setup({
            onSelect: function(cal) { cal.hide() },
            showTime: true
        });

        cal.manageFields( btn, txt, format);
      }


      function setup_calender_with_date( buttonid, textid ) {
        setup_calender_with_format(buttonid, textid, "%Y-%m-%d");
      }

      function setup_calender_with_datetime( buttonid, textid) {
        setup_calender_with_format(buttonid, textid, "%Y-%m-%d %H:%M:%S");
      }

      function setup_calender( buttonid, textid) {
        setup_calender_with_date(buttonid, textid);
      }

