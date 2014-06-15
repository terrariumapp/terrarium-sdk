@echo off

REM spec
REM ..\.nuget\NuGet.exe spec

REM pack
..\.nuget\NuGet.exe pack Terrarium.Sdk.csproj -Prop Configuration=Release

REM publish
..\.nuget\NuGet.exe push Terrarium.Sdk.1.1.0.0.nupkg