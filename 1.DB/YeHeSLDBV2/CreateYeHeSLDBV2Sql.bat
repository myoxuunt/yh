@rem
@rem 生成数据库脚本
@rem
@echo ====================
@echo 生成 YeHeSLDB - V2 数据库脚本
@echo ====================
@echo Press any key to continue, Ctrl+C to break...
@pause > nul

"C:\Program Files\Microsoft SQL Server\MSSQL\Upgrade\scptxfr.exe" /s a /d yehesldbv2-3 /P sa /f .\YeHeSLDBV2.sql /q /r /A /E
