# Overview
The drag&drop API in TaxPrep API is created to allow the custom data be created in the momemnt user draging and droping the data from TaxPrep application to other application or even a web browser.

## Implementation
To implement custom drag drop provider, the add-in developer should do these steps:

- Retrieve the IAppDragDropService from application refrence:

>var dropservice = (IAppDragDropService)_appInstance;
>
>dropservice.RegisterDataFormat(8, new TxpAddinLibrary.Handlers.DragDrop.DataFormatHandler(SomeMethod));   

- SomeMethod will be responcible of generating data, which will be droped to drop target.

## Interfaces

    [Guid("E67EF30C-8378-4F5A-8ECB-B5259CC8FBE1")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppDragDropService
    {
		//Register handler for generating custom drag&drop data 
        void RegisterDataFormat(uint AFormat, IAddinDragDropDataFormatHandler AHandler);
    }


    [Guid("F439D7F9-4BCE-410F-8FBA-21BA3B6CE547")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAddinDragDropDataFormatHandler
    {
		//event which will be run when application need the data be generated
        dynamic GetData(IAppCellSelectionIter ASelection);
    }

    [Guid("D9AA2AB4-E5AA-480E-915A-933E522BDD1F")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppCellSelectionIter
    {
		//Tax cell iterator
        IAppField Current();
        void First();
        bool IsDone();
        void Last();
        void Next();
    }