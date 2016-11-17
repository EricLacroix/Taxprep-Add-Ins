# Add-in loader

The loader is built for:
 - To load the managed add-in into a separate CLR Application Domain. In this mode the managed add-in is unable to change/access to antoher managed add-in data. Additionally, the assemblies, which will be used by add-in will be automatically unloaded on add-in unload.
 - To fix the issue with FPU Control Word settings. The Delphi and CLR have different settings for FPU CW. That leads to diffrent strange errors on the places which are not expected by developer. For example SpreadSheet Gear library can fail with StackOverflow error with the wrong FPU CW settings.
 - To avoid of usage of Unmanaged Exports NuGet package. That package bring additional instability to the add-in development process. It can make the VisualStudio hangs on the building of the add-in.

## The usage ##

Here is the four modes in which the Loader can be used:
 - Managed add-in (direct)
 - Managed add-in (via proxy)
 - Native add-in (direct)
 - Native add-in (via proxy)

## Managed add-in (direct) ##

In this mode, the Loader will:
 1. Check the add-in digital signature
 2. Create the new Application Domain with the Unique name.
 3. Load the actual add-in assembly
 4. Install the CLR FPU CW.
 5. Create the instance of the add-in class
 6. Route the Taxprep calls to the actula add-in interface.

Here is the exampel of Loader.ini configuration:

    [Addin]
    #full path to add-in DLL file (required)
    FileName=c:\Folder\addin.dll
    #Optional
    ConfigFile=c:\Folder\addin.dll.config
    #Full class name for a c# class, which implementa IAddinInstance interface
    ClassName=TestAddin.AddinInstance
 
## Managed add-in (proxy) ##
 
The VsProxy.dll file is required. The actual add-in have to be registered on S3. In this mode, the Loader will:
 1. Check the VsProxy.dll signature
 2. Create the new Application Domain with the Unique name.
 3. Load the VsProxy.dll assembly into that domain
 4. Install the CLR FPU CW.
 5. Provide the infromation about the actual add-in to the Proxy add-in.
 
Here is the exampel of Loader.ini configuration:
    
    [Addin]
    FileName=d:\isolution\iSolutions-AddIns\advertising_addin\TestAddin\TestAddin\bin\x86\Debug\TestAddin.dll
    ConfigFile=TestAddin.dll.config
    ClassName=TestAddin.AddinInstance
    
    [Proxy]
    Guid={13580142-F284-4AA5-B479-A7403F0F82F5}
    Name=NoUmanagedExport
    Version=1.0.0.1
    ShortName=NoUmanagedExport
    ProxyDllFileName=d:\isolution\iSolutions-AddIns\API\Proxy\bin\VsProxy\VsProxy.dll
    
## Native add-in (direct) ##

In this mode, the Loader will:
 1. Check the add-in digital signature
 2. Load the actual add-in dll.
 3. Route the Taxprep calls to the actual add-in exported functions.
 
Here is the exampel of Loader.ini configuration:
    [Addin]
    FileName=d:\isolution\iSolutions-AddIns\API\Examples\bin\VSAddinTest\VSAddinTest.dll
    Native=1
    
## Native add-in (proxy) ##

The VsProxy.dll file is required. The actual add-in have to be registered on S3. In this mode, the Loader will:
 1. Check the VsProxy.dll signature
 2. Create the new Application Domain with the Unique name.
 3. Load the VsProxy.dll assembly into that domain
 4. Provide the infromation about the actual add-in to the Proxy add-in.
 
Here is the exampel of Loader.ini configuration:
    
    [Addin]
    FileName=d:\isolution\iSolutions-AddIns\API\Examples\bin\VSAddinTest\VSAddinTest.dll
    Native=1
    
    [Proxy]
    Guid={80fa33bc-d500-496d-b725-a3509430fa02}
    Name=C# Addin Test
    Version=1.0.0.0
    ShortName=VSAddinTest
    ProxyDllFileName=d:\isolution\iSolutions-AddIns\API\Proxy\bin\VsProxy\VsProxy.dll
    
## Configuration ##

Here is the configuration file (Loadeer.ini)
    #This ini file name must be the same as the Loader.dll name (without the extension) name registered in the System Registry.

    [Addin]
    #full path to add-in DLL file (required)
    FileName=c:\Folder\addin.dll
    #For managed add-ins(optional): Full path to .Net config file
    ConfigFile=c:\Folder\addin.dll.config
    #For managed add-ins: full class name for a c# class, which implementa IAddinInstance interface
    ClassName=TestAddin.AddinInstance
    #0 for managed add-ins (default), 1 - for native add-ins
    Native=0
    
    #For proxy add-ins, uncomment to run the add-in via proxy
    # The proxy way is used to develop the add-ins
    #[Proxy]
    #Exact add-in Guid which is registered with iSolutions
    #Guid={13580142-F284-4AA5-B479-A7403F0F82F5}
    #Add-in full name, which is visible in TaxPrep options
    #Name=NoUmanagedExport
    #Exact add-in version, which is registered with iSolutions
    #Version=1.0.0.1
    #name which is registered with iSolutions
    #ShortName=NoUmanagedExport
    #Full/relative path to VsProxy.dll
    #ProxyDllFileName=d:\isolution\iSolutions-AddIns\API\Proxy\bin\VsProxy\VsProxy.dll