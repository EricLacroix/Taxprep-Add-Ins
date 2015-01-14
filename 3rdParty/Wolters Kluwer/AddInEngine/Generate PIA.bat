@echo off
setlocal

set TlbImportCmd=C:\Program Files (x86)\Microsoft SDKs\Windows\v8.0A\bin\NETFX 4.0 Tools\TlbImp.exe
set TlbFileName=%~dp0TLB_D7.tlb
set ParamNamespace=/namespace:TaxprepAddinAPI
set ParamOutFileName=/out:"%~dp0\TaxprepAddinAPI.dll"
set ParamCompany="/company:Wolters Kluwer Canada"
set ParamCopyright="/copyright:Copyright (c) Wolters Kluwer Canada 2014"
set Params=%ParamOutFileName% %ParamNamespace% %ParamCompany% %ParamCopyright%

echo.
"%TlbImportCmd%" "%TlbFileName%" %Params%
if ErrorLevel 1 (
  echo.
  echo Error: Cannot import TLB file
  exit 1
)

echo.
echo TLB file has been imported successfully
