@echo off

set msbuild2=%windir%\Microsoft.NET\Framework\v2.0.50727\msbuild.exe
set msbuild35=%windir%\Microsoft.NET\Framework\v3.5\msbuild.exe

%msbuild35% MSBuildDefault.Proj /target:Source /m /property:Configuration=Debug /ToolsVersion:3.5

pause


