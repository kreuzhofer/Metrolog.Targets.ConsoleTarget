@ECHO OFF
SETLOCAL
SET VERSION=%1
SET NUGET=.nuget\nuget.exe

"C:\Program Files (x86)\MSBuild\12.0\bin\amd64\msbuild" Metrolog.Targets.ConsoleTarget.sln /target:Clean;Build /p:Configuration=Release;OutDir=..\bin

FOR %%G IN (*.nuspec) DO (
  %NUGET% pack %%G -Version %VERSION%
)
