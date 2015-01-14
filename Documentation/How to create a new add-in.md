# Overview

As each add-in have to be signed with a code signing certificate, developers could use the Proxy add-in wrapper to create and test their own Add-in. 

## Using proxy add-in to develop the new add-in

The compiled binaries for the proxy add-in is locating in :

`bin\ProxyAddin\1.0.0.0\`

Each developed add-in is assigned to the apropriate TaxPrep Unlock Code and have to be registered with iSolutions.

Each add-in from the Examples folder are registering itself with the ProxyAddin. This is done by using the post-build events in VisualStudio. For example for "Hello world" add-in:

> cmd /c copy /y "$(ProjectDir)..\..\bin\ProxyAddin\1.0.0.0\*.*" "$(TargetDir)"
> 
> "$(ProjectDir)..\..\api\AddinReg.exe" "T1 Taxprep 2014" -register -p $(ProjectName) "Empty hello world add-in example via ProxyAddin" "26A2ECE8-ED75-47B9-8797-32B3C0D227A8" "1.0.0.0" "$(TargetPath)" "$(TargetDir)VSProxy.dll" 
> 
> "$(ProjectDir)..\..\api\AddinReg.exe" "T2 Taxprep 2014-2" -register -p "$(ProjectName)" "Empty hello world add-in example via ProxyAddin" "26A2ECE8-ED75-47B9-8797-32B3C0D227A8" "1.0.0.0" "$(TargetPath)" "$(TargetDir)VSProxy.dll"

First command copied the proxy add-in to the project build folder. Next two commands registered it with the TaxPrep T1 and TaxPrep T1-2.

To register your own add-in please use the AddinReg.exe tool, which is located in the `api\` folder. The parameters are following:

> 
> d:\isolution\Addins\api>AddinReg.exe
> 
> Usage:
> 
>   For signed add-ins:
>   
>     AddinReg.exe <Application[-c] -register|-unregister AddinShortName AddinDllPath
> 
>   For proxy add-ins:
>     
>     AddinReg.exe <Application[-c] -register|-unregister -p AddinShortName AddinName AddinGuid AddinVersion AddinDllPath AddinProxyDllPath 
>     
>   Use "-c" to clear the list of registered add-ins.
>   
>   Application:
>   
>     "T1 Taxprep 2014"
>     "T2 Taxprep 2014-1"
>     ...
>     "Taxprep Forms 2014"
>     


### Creating a "hello world" add-in ###


- Create a new class library project in Visual Studio.
- Rename the Class1 to AddinInstance.
- Add "UnmanagedExports" NuGet package (Manage NuGet Packages->Seach for "UnmanagedExports"->Install).
- Open project options and change Platform target from "Any CPU" to "x86".
- Add TaxprepAddinAPI.dll to references (<repopath>\Addins\api\bin\TaxprepAddinAPI.dll)
- Copy sources from <repopath>\Addins\api\lib to your project folder
- In solution explorer click "Show all files".
- Right click on lib folder and press "Include in project".
- Add `using TaxprepAddinAPI;` to the AddinInstance.cs.
- Add `using TxpAddinLibrary;` to the AddinInstance.cs.
- Mark AddinInstance class with attribute [AddinInstance] and derive it from AddinInstanceBase.
- Override ReleaseApp method to handle any clean-up needed when add-in is unloaded from TaxPrep:
    
>     public override void ReleaseApp()
>     {
>         base.ReleaseApp();
>         // some finalization code
>     }


- Add a constructor. The guid, name and version should be the same as defined in ProxyAddin configuration and registered with iSolutions:

>        public AddinInstance()
>            : base(new Guid("26A2ECE8-ED75-47B9-8797-32B3C0D227A8"), 
>            "EmptyAddinExample", "1.0.0.0")
>        { 
>            //some class initizalition code
>        }

- Override an initialization method. This method can create menu items and register all required event handlers:

>        public override void InitializeTaxPrepAddin()
>        {
>            var appMenuService = (IAppMenuService)_appInstance;
>            if (appMenuService != null)
>            {
>                var subMenu = appMenuService.AddRootMenu("Empty add-in");
>                subMenu.Visible = true;
>
>                var item = subMenu.AddItem("Hello world", false);
>                item.ClickHandler = new TxpAddinLibrary.Handlers.AppNotifyHandler(DoHelloWorld);
>                item.Visible = true;
>                item.Enabled = true;
>            }
>        }

- Implement the handlers code:

>        private void DoHelloWorld()
>        {
>            var app = (IAppTaxApplicationService)_appInstance;
>            app.ShowMessageString("Test message", "Hello world!");
>        }


**The add-in created by that actions is available in repository: (<repositorypath>\Addins\Examples\EmptyAddin)*

### Registering the add-in with TaxPrep

To register add-in, please run the appropriate AddinReg.bat file. The batch file will:

- Correct the VSProxy.dll.config file with apropriate add-in path.
- Register your add-in in the system registry (`HKCU\Software\CCH\<ProductName>\Addins\<AddinShortName>`).

### List of available interfaces

To see the list of available interfaces, please refer to CalcAPI.md.

### Unmanaged export side effects

Sometimes, when the add-in become bigger, due to unmanaged export the project shows the compile-time errors. You will get this error for sure if add a new Windows form to add-in. As a work-around for C# it's recommended to move all your UI into a separated dll.

### Error handling
All unhandled error in your add-in will be shown as crash report in TaxPrep. 

### Debug instructions.

- Register your add-in with apropriate bach file.
- Go to your Project->Properties->Debug
- Set the TaxPrep executable as a "Start external program" 
- Run the project.

OR

- Register your add-in with apropriate bach file.
- Run TaxPrep from Start menu
- Debug-> Attach to Process -> <TaxPrep application>

