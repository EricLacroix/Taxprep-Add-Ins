# Overview

COM Add-in allows external application to access TaxPrep API.

### Registering the add-in with TaxPrep

To register add-in, please run AddinReg.exe utility. It will:

- Create Loader.ini file in Add-in filder with parameters for TaxPrep loader.
- Register your add-in in the system registry (`HKCU\Software\CCH\<ProductName>\Addins\<AddinShortName>`).

### Registering COM objects

Use RegCom.exe utility to register:
1. TaxPrep API type library (tlb_D7.tlb) - for COM marshalling
2. Out Of Proc COM server hosted in COM AddIn

The second option is required only if you need TaxPrep to be started automatically by COM clients. If clients will be connecting to a running instance of TaxPrep this option is not required.

#### Syntax:  
```
RegCom [Options] /tlb:TypeLibraryFileName.tlb /dll:OutOfProc.dll /exe:ExeHostingOutOfProcDll.exe
```

#### Options:
        /? or /help               Display this usage message  
        /r or /register           Perform registration  
        /u or /unregister         Perform unregistration  
        /key:user                 Per-user registration (in HKEY_CURRENT_USER) - default option  
        /key:classes              Registration in HKEY_CLASSES_ROOT  
        /tlb:path                 Path to type library file  
        /dll:path                 Path to dll containing out of proc COM server  
        /exe:path                 Path to exe file hosting out of proc dll COM server  

### Support of several TaxPrep versions

Each TaxPrep version uses a different Guid for _ComAccessProvider_ COM object registration. This Guid is generated dynamically based in the version of TaxPrep. TaxPrep version is extracted from TaxPrep executable file name. Expected executable file name format is:
```
T{code}Txp{year}V{version}
```
Version part is optional.    
For example: T1Txp2014, T2Txp2015V1

Version information included into:
- Guid in format:
```
 {code}{year}{version}00-XXXX-XXXX-XXXX-XXXXXXXXXXXX
```
X - is digit form COM object Guid template

- In ProgId in format:
```
Cch.{taxAppNamespace}.{typeName}
```

For example:

TaxPrep exe name | Guid | ProgId
------------ | -------------
T1Txp2014 | 12014000-XXXX-XXXX-XXXX-XXXXXXXXXXXX | Cch.t1_taxprep_2014.ComAccessProvider
T2Txp2014V2 | 22014200-XXXX-XXXX-XXXX-XXXXXXXXXXXX | Cch.t2_taxprep_2014-2.ComAccessProvider

Guid is used both for registration is registry and for exposing COM objects with OLE (in run time). ProgId is used only for registration in registry.

Version specific registration is done automatically by:
- COM AddIn loaded into TaxPrep process - it generates version specific Guid for registration with OLE
- ComReg utility - it generates version specific Guid and ProgId and registers them is registry (along with a path to the correct TaxPrep executable)

### Access to TaxPrep API from client application

For clients to interact with a specific version of TaxPrep the corresponding Guid or ProgId has to be specified.
They could be constructed manually (using example above) or generated from TaxPrep exe name using _ComRegistrationHelper_ class in _RegComLib.dll_.    
- ProgId could be used only if COM AddIn is registered in the registry. In this case corresponding TaxPrep  version will be launched automatically
- Guid could be used in both cases: to launch TaxPrep when it is registered in the registry or to interact with a running TaxPrep version. For the last case, registration in registry is not required

Example of client:    
get type from PropId
```cs
var progId = "Cch.t1_taxprep_2014.ComAccessProvider";
var type = Type.GetTypeFromProgID(progId);
```

get type from Guid
```cs
var guid = new Guid("22014200-XXXX-XXXX-XXXX-XXXXXXXXXXXX");
var type = Type.GetTypeFromCLSID(guid, true);
```

  get IAppTaxApplicationService
  ```cs
dynamic comAccessProvider = Activator.CreateInstance(type);
dynamic appInstance = comAccessProvider.GetAppInstance();
 Marshal.ReleaseComObject(comAccessProvider);
_appTaxApplicationService = (IAppTaxApplicationService)appInstance;
```
