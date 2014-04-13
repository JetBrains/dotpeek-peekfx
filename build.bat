@echo off
setlocal enableextensions

set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

REM Clean
echo Cleaning...
del /q src\PeekFx\bin\Release\*

REM Package restore
tools\nuget.exe restore src\PeekFx.1.0.sln
tools\nuget.exe restore src\PeekFx.1.1.sln
tools\nuget.exe restore src\PeekFx.1.2.sln

REM Build DotPeek 1.0 version
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild src\PeekFx.1.0.sln /p:Configuration="%config%" /t:Clean,Rebuild /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false
mkdir install\PeekFx.1.0 2> NUL
copy /y src\PeekFx\bin\Release\*.1.0.dll install\PeekFx.1.0\
copy /y src\PeekFx\bin\Release\NuGet.Core.dll install\PeekFx.1.0\

REM Clean
echo Cleaning...
del /q src\PeekFx\bin\Release\*

REM Build DotPeek 1.1 version
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild src\PeekFx.1.1.sln /p:Configuration="%config%" /t:Clean,Rebuild /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false
mkdir install\PeekFx.1.1 2> NUL
copy /y src\PeekFx\bin\Release\*.1.1.dll install\PeekFx.1.1\
copy /y src\PeekFx\bin\Release\NuGet.Core.dll install\PeekFx.1.1\

REM Build DotPeek 1.2 version
%WINDIR%\Microsoft.NET\Framework\v4.0.30319\msbuild src\PeekFx.1.2.sln /p:Configuration="%config%" /t:Clean,Rebuild /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false
mkdir install\PeekFx.1.2 2> NUL
copy /y src\PeekFx\bin\Release\*.1.2.dll install\PeekFx.1.2\
copy /y src\PeekFx\bin\Release\NuGet.Core.dll install\PeekFx.1.2\