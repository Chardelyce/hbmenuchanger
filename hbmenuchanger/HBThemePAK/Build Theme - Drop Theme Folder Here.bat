@echo off
REM This script is used with hacktoolnet.exe to build a theme for the Hombrew Menu!
REM By Mikefor20
ECHO.
ECHO.
ECHO                      Welcome to Hombrew Menu Theme RomFS Builder Script!
ECHO.
ECHO.
ECHO.
set /p id=Please enter desired name for new theme! Don't forget the extension! (Example theme.romfs):
CLS
ECHO.
ECHO.
set /p var=Please Enter destination folder (leave blank for current folder):
IF "%var%"=="" GOTO noinput
CLS
ECHO.
ECHO.
IF not exist %var% mkdir %var%
hactoolnet -t romfsbuild "%~1" --outfile %var%/%id%
CLS
ECHO.
ECHO.
ECHO %~1 Build complete.
ECHO.
ECHO New theme name %id%
ECHO New theme located in %var% folder
PAUSE
EXIT

:noinput 
hactoolnet -t romfsbuild "%~1" --outfile %id%

ECHO.
ECHO.
ECHO %~1 Build complete.
ECHO.
ECHO New theme name %id%
ECHO New theme located in this folder
PAUSE
EXIT
