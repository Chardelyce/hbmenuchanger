@echo off
REM This script is used with hacktoolnet.exe to extract Hombrew Menu Theme romfs files!!
REM By Mikefor20
ECHO.
ECHO.
ECHO                       Welcome to Hombrew Menu Theme Romfs Extractor Script!
ECHO.
ECHO.
ECHO.
ECHO Please enter folder name for extracted theme.  It will be created if it's not there.
set /p id="(Press Enter for EXTRACTED folder in this directory):
CLS										
IF "%id%"=="" GOTO noinput

ECHO.
hactoolnet -t romfs "%~1" --romfsdir "%id%"
ECHO.
ECHO.
ECHO %~1 EXTRACTION COMPLETE.
ECHO.
ECHO EXTRACTED theme located in the %id% folder
PAUSE
EXIT
:noinput 
hactoolnet -t romfs "%~1" --romfsdir EXTRACTED
ECHO.
ECHO.
ECHO %~1 EXTRACTION COMPLETE.
ECHO.
ECHO EXTRACTED theme located in the EXTRACTED folder
PAUSE
EXIT