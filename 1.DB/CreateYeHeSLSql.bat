@rem
@rem 生成CZGR数据库脚本
@rem
@echo ====================
@echo 生成YeHeSLDB数据库脚本
@echo ====================
@echo Press any key to continue, Ctrl+C to break...
@pause > nul

"C:\Program Files\Microsoft SQL Server\MSSQL\Upgrade\scptxfr.exe" /s (local) /d yehesldb /P sa /f .\YeHeSLDB.sql /q /r /A /E
