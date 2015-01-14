# Calc API #

## Objects diagram ##


This digram shows how the main wrappers links between each other:
![](https://gitlab.cch.ca/taxprep_addins/addintest/blob/master/Diagram.png)

## Indirect access. ##

All access to internal volatile interfaces are done, using the path or id values:

| Internal Intreface    | Description                                                                         | Addon wrapper                                                                  | Linked by                                                                                                            |
| --------------------- | ----------------------------------------------------------------------------------- | ------------------------------------------------------------------------------ | -------------------------------------------------------------------------------------------------------------------- |
| ICCHTaxReturn         | Current tax return module.                                                          | IAppTaxReturn                                                                  | TaxApplicationService method, which get a current tax return module from ModuleManager                               |
| ICCHTaxDocument       | Container for all returns in some client file                                       | IAppTaxDocument                                                                | - GUID of the client file - Document index                                                                           |
| TCCHTaxData           | Container for database related information: cells, repeats, groups                  | IAppTaxData                                                                    | - GUID of the client file - DocumentIndex - ReturnID                                                                 |
| TCCHTaxCell           | Some cell in the database                                                           | IAppTaxCell                                                                    | - GUID of the client file - DocumentIndex - ReturnID - CellName                                                      |
| ICCHApplication       | General application object singleton                                                | IAppTaxApplicationService                                                      | Throw the fmAddinModule                                                                                              |
| ICCHTaxApplication    | General tax data access singleton object                                            | IAppTaxApplicationService                                                      | Throw the fmAddinModule                                                                                              |
| TCCHStatusProperty    | List of statuses of return or document                                              | IAppStatusProperties                                                           | - GUID of the client file - DocumentIndex - ReturnID  - GetReturnProperties() method of ICCHDocReturn                |
| TCCHGroupInfo         | General and statistical information about some repeat in the return                 | IAppGroupInfo                                                                  | For now direct access - need to be fixed soon. Should be the object of TCCHGroupArray service                        |
| TCCHGroupArray        | The repeat representation. Accessing to the cells in the repeat. Cells enumeration. | IAppGroupArray                                                                 | - GUID of the client file - DocumentIndex - ReturnID  - Group Name                                                   |
| ICCHField             | Some field (UI object, TCCHTaxCell view) on the tax return form                     | IAppField                                                                      | For now direct access - need to be fixed soon.  Should be the object of TCCHGroupArray service                       |
| ICCHClientFile        | Client file repsentation                                                            | IAPPClientFile                                                                 | GUID of the client file                                                                                              |
| ICCHClientFileManager | The container for client files                                                      | IAPPClientFileManagerService                                                   | Throw the fmAddinModule                                                                                              |
| ICCHDocument          | Document (container for returns) in the client file                                 | IAppDocument                                                                   | - GUID of the client file - DocumentIndex                                                                            |
| ICCHDocReturn         | Return as a document                                                                | IAppDocReturn                                                                  | - GUID of the client file - DocumentIndex  - ReturnID                                                                |
| ICCHCellSelectionIter | The list of cells for drag and drop                                                 | IAppCellSelectionIter                                                          | For now direct access - need to be fixed soon.  Should be the object of TCCHGroupArray service                       |

## Interfaces ##

### IAppTaxApplicationService (global service) ###

| Method name                                                                                                | Description                                                                                        | Test |
| ---------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------- | ---- |
| CanCloseClientFile(const aClientFile: IAppClientFile): WordBool;                                           | Check if the client file could be closed right now                                                 | yes  |
| GetClientFileManager: IAppClientFileManagerService;                                                        | Returns client file manager wrapper                                                                | yes  |
| GetDefaultLanguage: AppLanguage;                                                                           | Returns the selected language from the application configuration                                   | yes  |
| GetProductName: WideString;                                                                                | Returns the product name                                                                           | yes  |
| GetProductSuffix: WideString;                                                                              | Returns the product suffix                                                                         | yes  |
| getIsDemo: WordBool;                                                                                       | Returns true if the application is in the demo mode                                                | yes  |
| getIsEducative: WordBool;                                                                                  | Returns true if the application is in for educative purpose                                        | yes  |
| getIsNetWork: WordBool;                                                                                    | Returns true for Network version                                                                   | yes  |
| getIsNetworkRegular: WordBool;                                                                             | Returns true for regular network version                                                           | yes  |
| getIsNetworkAdvanced: WordBool;                                                                            | Returns true for network advanced version                                                          | yes  |
| getIsEFILEGovernment: WordBool;                                                                            | Returns true if the efile module available                                                         | yes  |
| getIsCOMAvailable: WordBool;                                                                               | Returns true if the TaxPrep COM library available                                                  | yes  |
| getProductType: Integer;                                                                                   | integer version of product type                                                                    | yes  |
| GetVersionType: WideString;                                                                                | Version Type                                                                                       | yes  |
| GetName: WideString;                                                                                       | Name of the application                                                                            | yes  |
| GetExecutableName: WideString;                                                                             | TaxPrep executable file name                                                                       | yes  |
| GetTitleName: WideString;                                                                                  | The tittle of the application (on task bar)                                                        | yes  |
| GetSoftwareVersion: WideString;                                                                            | The TaxPrep version number                                                                         | yes  |
| GetTemplateSignaturePrefix: WideString;                                                                    | Template Signature Prefix                                                                          | yes  |
| GetIsFirstExecution: WordBool;                                                                             | True if the TaxPrep is run first time.                                                             | yes  | 
| GetConfiguration: IAppConfiguration                                                                        | Application configuration wrapper                                                                  | yes  |
| CreateDocument: IAppDocument;                                                                              | Create a new document inside the current client file                                               | no   |
| GetCurrentDocument: IAppDocument;                                                                          | Returns the current document in the current client file                                            | yes  |
| GetString(const APath: WideString; const AID: WideString): WideString;                                     | Reads the string from resource (current language)                                                  | yes  |
| GetStringWithLanguage(const APath: WideString; const AID: WideString; aLanguage: AppLanguage): WideString; | Reads the string from resource                                                                     | yes  |
| GetMessagePath: WideString;                                                                                | Returns the path in the resource to the message table                                              | yes  |
| GetMessage(const AID: WideString): WideString;                                                             | Returns the message text by strign indentifier                                                     | yes  |
| <em>GetVersionInfo: IUnknown;</em>                                                                         | Returns the version info intreface wrapper (not implemented yet)                                   | no   |
| ShowMessageString(const Title: WideString; const aMessage: WideString): Integer;                           | Show the message dialog in the same way as it does by TaxPrep                                      | no   |
| procedure SetAppStatusBar(const aValue: WideString);                                                       | Set the status bar text in the TaxPrep main form                                                   | no   |
| GetStatusBarText: WideString;                                                                              | Return the current status bar taxt i nthe TaxPrep main form                                        | yes  |
| <em>GetDBEnv: IUnknown;</em>                                                                               | Shuld return the database manager object (not implemented yet)                                     | no   |
| GetYear: Integer;                                                                                          | Return the current year                                                                            | yes  |
| GetCurrentField: IAppFIeld;                                                                                | Return the select field (on UI)                                                                    | yes  |
| GetCurrentTaxData: IAppTaxData;                                                                            | Return the current tax data of tax return                                                          | yes  |
| GetCurrentTaxReturn: IAppTaxReturn;                                                                        | Return the current tax return                                                                      | yes  |
| GetCurrentTaxCell: IAppTaxCell;                                                                            | Return the current tax cell                                                                        | yes  |
| GetCurrentDocReturn: IAppDocReturn;                                                                        | Return the current doc return object                                                               | yes  |
| Get_Configuration: IAppConfiguration;                                                                      |                                                                                                    | yes  |
| OnIdle: IAddinIdleHandler;                                                                                 | An event to provide the ability to do something when TaxPrep enters into the Idle cycle            | yes  |
| Get_UFL: IAppUFL;                                                                                          | Provides access to the information and printing functionality about the forms available in Taxprep | yes  |
| ClientLetterManager: IAppClientLetterManager;                                                              | Provides the list to client file managed interface                                                 | yes  |
| StartLongOperation;                                                                                        | Shows the dialog with the information that the TaxPrep is working on the momemnt                   | yes  |
| getMainMainFormsBaunds(out aLeft: Integer; out aTop: Integer; out aWidth: Integer; out aHeight: Integer);  | Returns the position of the main TaxPrep form                                                      | yes  |
| getMainFormHandle: LongWord;                                                                               | returns the handle of the manin Taxprep form                                                       | yes  |
| RefreshAdvertisingMenu;                                                                                    | Repaints the advertising button                                                                    | yes  |
| OnGetAdvertisingData: IAddinGetAdvertisingDataHandler;                                                     | An event handle to add some additional information on requesting the advertising banner            | yes  |
| GetMachineIdentifier: WideString;                                                                          | Returns the Taxprep machine identifier                                                             | yes  |
| GetCalcDllName: WideString;                                                                                | Returns the file name of calc engine                                                               | yes  |
| GetCalcVersion: WideString;                                                                                | Returns the version of calc engine                                                                 | yes  |
| GetFilePath: WideString;                                                                                   | Returns the file name of the running Taxprep                                                       | yes  |
| GetFileDateTime: TDateTime;                                                                                | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetFileDateStr: WideString;                                                                                | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetFileTimeStr: WideString;                                                                                | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetCompanyName: WideString;                                                                                | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetFileDescription: WideString;                                                                            | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetFileVersion: WideString;                                                                                | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetInternalName: WideString;                                                                               | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetLegalCopyright: WideString;                                                                             | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetLegalTradeMarks: WideString;                                                                            | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetOriginalFilename: WideString;                                                                           | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetVersionProductName: WideString;                                                                         | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetProductVersion: WideString;                                                                             | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetComments: WideString;                                                                                   | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetPrivateBuild: WideString;                                                                               | Returns an additional information about TaxPrep.exe                                                | yes  |
| GetSpecialBuild: WideString;                                                                               | Returns an additional information about TaxPrep.exe                                                | yes  | 
| OnAfterLanguageChange: IAddinNotifyHandler;                                                                | An event, which occurs after the user changes the current Taxprep language                         | yes  | 
| OnBeforeLanguageChange: IAddinNotifyHandler;                                                               | An event, which occurs before the user changes the current Taxprep language                        | yes  |
| GetResourceManager: IAppResourceManager;                                                                   | Returns an interface to the resource manager                                                       | yes  |
| GetLanguage: AppLanguage;                                                                                  | Returns the currently selected Taxprep language                                                    | yes  |
| GetApplicationHandle: LongWord;                                                                            | Returns the handler (HWND) of the Taxprep VCL.Forms.Application                                    | yes  |
| GetCustomDiagnostic: IAppAddinCustomDiagnostic;                                                            | Returns an inteface to manage the custom add-in diagnostics                                        | yes  |

### IAppClientFileEventsService (global service) ###


| Event name                          | Description                                                                                              | Test |
| ----------------------------------- | -------------------------------------------------------------------------------------------------------- | ---- |
| BeforeClientFileNameChange          | Handled when the before the client file name to be changed                                               | yes  |
| AfterClientFileNameChange           | Handled when the after the client file name has been changed                                             | yes  |
| BeforeClientFileSave                | Handled before the current client file to be saved                                                       | yes  |
| AfterClientFileSave                 | Handled after the client file has been saved                                                             | yes  |
| AfterChangeClientFileHeaderProperty | Handled after the some header property was changed in the client file                                    | yes  |
| BeforeDocumentAdd                   | Handled before some document to be added in the client file                                              | yes  |
| AfterDocumentAdd                    | Handled after the document has been added to the client file                                             | yes  |
| BeforeDocumentRemove                | Handled before the document to be removed from the client file                                           | yes  |
| AfterDocumentRemove                 | Handled before the document has been removed from the client file                                        | yes  |
| BeforeCurrentDocumentChange         | Handled before the current document to be changed                                                        | yes  |
| AfterCurrentDocumentChange          | Handled after the current document has been changed                                                      | yes  |
| BeforeReturnStatusChange            | Handled before the property will be changed in the return or document                                    | yes  |
| BeforeCurrentClientFileChange       | Occurs before the users switches to the another client file                                              | yes  |
| AfterCurrentClientFileChange        | Occurs after the users switches to the another client file                                               | yes  |     
| BeforeClientFileAdd                 | Occurs before the user add a new client file to the list of client files in Client File Managed          | yes  |     
| AfterClientFileAdd                  | Occurs before the user add a new client file to the list of client files in Client File Managed          | yes  |     
| BeforeClientFileRemove              | Occurs before the user removes (closes) a client file to the list of client files in Client File Managed | yes  |     
| AfterClientFileRemove               | Occurs after the user removes (closes) a client file to the list of client files in Client File Managed  | yes  |     
|                                     | Occurs when the users switches to the another return in Tax Return View                                  | yes  |     
| CanCloseClientFile                  | Can stop the closing of client file be returning false in an apropriate parameter                        | yes  |     
| OnCheckHeaderAlias                  | Occurs when the TaxPrep is trying to get the value of header alias for the statuses                      | yes  |     
| OnUpdateReturnHeader                | Occurs when the TaxPrep recalculates the return headers                                                  | yes  |
| OnSaveReturnHeader                  | Occurs when TaxPrep store the return header                                                              | yes  |
| OnUpdateDatabaseFromReturnHeader    | Occurs when the TaxPrep is updating the database (client file) from the return header                    | yes  |
| OnBeforeOpenClientFile              | General event, which occurs before the user opens the client file                                        | yes  |
| OnBeforeReturnAdd                   | Occurs before the user adds a new return to the client file                                              | yes  |     
| OnAfterReturnAdd                    | Occurs after the user adds a new return to the client file                                               | yes  |
| OnBeforeReturnRemove                | Occurs before the user removes a return to the client file                                               | yes  |
| OnAfterReturnRemove                 | Occurs after the user removes a return to the client file                                                | yes  |
| OnBeforeCurrentReturnChange         | Occurs before the user switches between tax returns in Tax Return view.                                  | yes  |
| OnAfterCurrentReturnChange          | Occurs after the user switches between tax returns in Tax Return view.                                   | yes  |

### IAppClientFileManagerService (global service) ###

| Method name                                                                                      | Description                                                            | Test |
| ------------------------------------------------------------------------------------------------ | ---------------------------------------------------------------------- | ---- |
| NewClientFile(const AFilePath: WideString; out aClientFile: IAppClientFile): WordBool;           | Creates a new client file with given properties                        | no   |
| OpenClientFile(const AFilePath: WideString; out aClientFile: IAppClientFile): WordBool;          | Open an existed client file.                                           | no   |
| CloseCurrentClientFile(AWithManager: WordBool): WordBool;                                        | Use it to close the current client file.                               | no   |
| AddClientFile(const aClientFile: IAppClientFile): Integer;                                       | Adds the client file to client file manager.                           | no   |
| procedure InsertClientFile(AIndex: Integer; const aClientFile: IAppClientFile);                  | Insert the client file to manager with apropriate index.               | no   |
| procedure DeleteClientFile(AIndex: Integer);                                                     | Removes the client file from manager by index.                         | no   |
| RemoveClientFile(const aClientFile: IAppClientFile): Integer;                                    | Removes the client file from manager by interface.                     | no   |
| procedure ClearClientFiles;                                                                      | Clear the client file manager's list                                   | no   |
| GetClientFileByFilePath(const AFilePath: WideString): IAppClientFile;                            | Search for client file by it's file path                               | no   |
| GetClientFile(AIndex: Integer): IAppClientFile;                                                  | Gets the client file by index from the list.                           | yes  |
| GetCurrentClientFile: IAppClientFile;                                                            | Returns the current client file.                                       | yes  |
| procedure SetCurrentClientFile(const aClientFile: IAppClientFile);                               | Sets the current client file.                                          | yes  |
| GetCurrentClientFileIndex: Integer;                                                              | Retuns the current client file index.                                  | no   |
| procedure SetCurrentClientFileIndex(AClientFileIndex: Integer);                                  | Sets the current client file by it's index.                            | no   |
| procedure GetCurrentDocument(var AResult: IAppDocument);                                         | Returns the current IAppDocument                                       | yes  |
| GetCurrentDocIndex: LongWord;                                                                    | Returns the current document index.                                    | yes  |
| GetCurrentTaxDocument: IAppTaxDocument;                                                          | Returns the current TaxDocument                                        | yes  |
| GetCurrentReturn: IAppDocReturn;                                                                 | Returns the current IAppDocReturn                                      | yes  |
| GetCurrentReturnId: LongWord;                                                                    | Returns the current return's unique ID.                                | yes  |
| SetCurrentDocument(AClientFileIndex: Integer; ADocIndex: LongWord): WordBool;                    | Set current client file and document.                                  | no   |
| SetCurrentReturn(AClientFileIndex: Integer; ADocIndex: LongWord; aReturnId: LongWord): WordBool; | Set current client file, document and return.                          | no   |
| GetCount: Integer;                                                                               | Returns the clien files count                                          | yes  |
| procedure SilentOpenMode;                                                                        | Set the silent open mode (no UI).                                      | yes  |
| procedure BackupFiles;                                                                           | Create the backups for all client files.                               | yes  |
| procedure SetBackupEnabled(Value: WordBool);                                                     | Enable or disable backups                                              | yes  |
| IsBackupEnabled: WordBool;                                                                       | Return true if the backup is enabled.                                  | yes  |
| GetVersionInfo: WideString;                                                                      | Returns the version information as a string.                           | yes  |
| OpenClientFileUIDefault(const AFileName: WideString; out aClientFile: IAppClientFile): WordBool  | Open client file in the same way as Taxprep do with File->Open dialog. | yes  |
| OpenClientFileUISilent(const AFileName: WideString; out aClientFile: IAppClientFile): WordBool;  | Open the client file in silent mode with not messages.                 | yes  |   

### IAPPClientFile (local service) ###

Addon should react on some ClienFileManager event or run the method of client file manager to access this class.

| Method name                                                                                          | Description                                                                     | Test |
| ---------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ---- |
| CreateNew(const AFilePath: WideString): WordBool;                                                    | Create a new file on a given location.                                          | no   |
| Open(const AFilePath: WideString): WordBool;                                                         | Opens an existed client file.                                                   | no   |
| Save(const AFilePath: WideString): WordBool;                                                         | Save the client file to disk.                                                   | yes  |
| SaveQuietly(const AFilePath: WideString): WordBool;                                                  | Save the client file without any request to user.                               | yes  |
| Backup(const Path: WideString; const Ext: WideString): WordBool;                                     | Creates a backup for the client file.                                           | yes  |
| LoadHeader(const AFilePath: WideString): WordBool;                                                   | Loads only the client file headers.                                             | no   |
| SaveHeader(const AFilePath: WideString): WordBool;                                                   | Saves only the client file headers.                                             | no   |
| procedure RestorePathName;                                                                           | Restore the the original path.                                                  | yes  |
| procedure CommitPathName;                                                                            | Apply the file path.                                                            | yes  |
| procedure SetPathFileName(const AFilePath: WideString);                                              | Changes the file path.                                                          | no   |
| GetDisplayPathFileName: WideString;                                                                  | Returns the file name.                                                          | yes  |
| GetTryingSavePathName: WideString;                                                                   | ???                                                                             | yes  |
| IsOpen: WordBool;                                                                                    | Returns true if file is opened.                                                 | yes  |
| IsNew: WordBool;                                                                                     | Returns true is the file is new (did not saved any time)                        | yes  |
| NewForRoll: WordBool;                                                                                | True if the file is applicable for roll forward.                                | yes  |
| procedure SetIsNew;                                                                                  | Sets IsNew flag to true.                                                        | no   |
| IsDirty: WordBool;                                                                                   | Set the Dirty flag to true.                                                     | yes  |
| procedure resetDirty;                                                                                | Set the Dirty flag to false.                                                    | yes  |
| procedure SetDirty(AValue: WordBool);                                                                | Set the dirrty flag value.                                                      | yes  |
| procedure CreateTimeStamp;                                                                           | Creates a new TiemStamp                                                         | yes  |
| procedure CreateGUID;                                                                                | Create a new file GUID                                                          | yes  |
| GetGUID: WideString;                                                                                 | Returns the file GUID.                                                          | yes  |
| AddDocument(ADocIndex: LongWord; const ADocName: WideString; const ATaxClient: IUnknown): Integer;   | Adds a new Document to client file (not yet fully implemented)                  | no   |
| AddScenario(const ADocName: WideString): Integer;                                                    | Adds a new scenario                                                             | yes  |
| RemoveDocument(ADocIndex: LongWord): WordBool;                                                       | Removes the document by index.                                                  | no   |
| procedure Clear;                                                                                     | Clears the documents.                                                           | no   |
| LoadDocuments: WordBool;                                                                             | Loads the documents and returns the status of action.                           | no   |
| LoadDocumentByIndex(ADocIndex: LongWord): WordBool;                                                  | Loads the document by it's index.                                               | no   |
| LoadDocumentByInterface(const ADocument: IAppDocument): WordBool;                                    | Loads the document by it's IAppDocument wrapper.                                | no   |
| LoadDocumentHeaderByIndex(ADocIndex: LongWord): WordBool;                                            | Loads the document's header by document index.                                  | no   |
| LoadDocumentHeaderByInterface(const ADocument: IAppDocument): WordBool;                              | Loads the document's header by IAppDocument wrapper.                            | no   |
| SaveDocumentByIndex(ADocIndex: LongWord): WordBool;                                                  | Saves the document by it's index                                                | yes  |
| SaveDocumentByInterface(const ADocument: IAppDocument): WordBool;                                    | Saves the document by it's wrapper                                              | yes  |
| SaveSystemHeadersNoUserDirty: WordBool;                                                              | Saves the system headers, but not change the UserDirty flag.                    | yes  |
| IsDocumentLoaded(ADocIndex: LongWord): WordBool;                                                     | Returns true if the document with document index is loaded.                     | yes  |
| EraseDocument(ADocIndex: LongWord): WordBool;                                                        | Removes the document from client file by it's index.                            | no   |
| GetDocument(ADocIndex: LongWord): IAppDocument;                                                      | Returns the document's wrapper by document's index.                             | yes  |
| GetDocInfo(ADocIndex: LongWord): IUnknown;                                                           | Returns the statistical information about document (Not yet implmented)         | no   |
| GetDocIndexByListIndex(AListIndex: Integer): LongWord;                                               | Returns the document index by index in the document's list.                     | yes  |
| GetDocumentFromList(Ndx: Integer; loadDocIfNotExists: WordBool): IAppDocument;                       | Enumerates documents.                                                           | yes  |
| GetCurrentDocIndex: LongWord;                                                                        | Returns the index of current document.                                          | yes  |
| GetCurrentDocListIndex: Integer;                                                                     | Returns the index in the list of current document.                              | yes  |
| GetCurrentYearDocument: IAppDocument;                                                                | Returns the current year document.                                              | yes  |
| GetTaxDocument(ADocIndex: LongWord; out ATaxDocument: IAppTaxDocument): WordBool;                    | Returns IAppTaxDocument by document index.                                      | yes  |
| GetCurrentTaxDocument(out ATaxDocument: IAppTaxDocument): WordBool;                                  | Returns the current IAppTaxDocument.                                            | yes  |
| SetDefaultCurrentDocument: WordBool;                                                                 | Set the current document as default.                                            | yes  |
| SetCurrentDocument(ADocIndex: LongWord; ForceEvents: WordBool): WordBool;                            | Sets the current document by index.                                             | no   |
| SetCurrentDocumentFromList(Ndx: Integer; UnSelectReturn: WordBool; ForceEvents: WordBool): WordBool; | Sets the current document by list index.                                        | no   |
| SetScenarioAsCurrentYear: WordBool;                                                                  | Set the scenarion as a current year.                                            | yes  |
| GetScenarioCount: Integer;                                                                           | Returns the count of scenarion.                                                 | yes  |
| GetLastScenarioIndex: LongWord;                                                                      | Returns the last scenarion index.                                               | yes  |
| GetLastScenarioDocIndex: LongWord;                                                                   | Returns the doc index of last scenarion.                                        | yes  |
| CurrentYearExists: WordBool;                                                                         | Returns true is the current year information exists in the client file.         | yes  |
| LastYearExists: WordBool;                                                                            | Returns true is the last year information exist in the client file.             | yes  |
| PlanningExists: WordBool;                                                                            | Returns true if the planning exists in the client file.                         | yes  |
| GetCount: Integer;                                                                                   | Returns count of documents inside the client file.                              | yes  |
| GetDocumentByIndex(AIndex: Integer): IAppDocument;                                                   | Returns document by Document index.                                             | yes  |
| ListIndexOfInterface(const ADocument: IAppDocument): Integer;                                        | Returns ListIndex of document.                                                  | yes  |
| ListIndexOfDocIndex(ADocIndex: LongWord): Integer;                                                   | Returns List index by document's index.                                         | yes  |
| IsValidListIndex(AIndex: Integer): WordBool;                                                         | Returns true if the given list index is valid.                                  | yes  |
| IsValidCurrentListIndex: WordBool;                                                                   | Return true the current list index is valid.                                    | yes  |
| GetDocumentName(ADocIndex: LongWord): WideString;                                                    | Returns document name by document index.                                        | yes  |
| IsUniqueDocumentName(const AName: WideString): WordBool;                                             | Returns false if the document with the same name is existed in the client file. | yes  |
| GetCurrentReturn: IAppDocReturn;                                                                     | Returns the current IAppDocReturn.                                              | yes  |
| GetCurrentReturnId: LongWord;                                                                        | Retuns the current return ID.                                                   | yes  |
| GetDatabaseEnv: IUnknown;                                                                            | Returns the database env wrapper (not yet implemented)                          | no   |
| LoadLastYearDocument(const AFilePath: WideString): WordBool;                                         | Loads the last year document from the provided file path.                       | no   |
| LoadLastYearPlanner(const AFilePath: WideString): WordBool;                                          | Loads the last year planner from the provided file path.                        | no   |
| GetTaxPayer(aReturnId: LongWord): WideString;                                                        | Return TaxPayer name by return id.                                              | yes  |
| procedure RunCalcForAllReturns;                                                                      | Runs the calc cycle for all returns in the client file.                         | yes  |
| GetDocInfoByDocType(aDocType: AppDocType): IUnknown;                                                 | Returns the document statistical information (not yet implemented.)             | no   |
| getAskedOptions(Value: AppAskOption): WordBool;                                                      | Return the asked option value.                                                  | yes  |
| procedure setAskedOptions(Value: AppAskOption; add: WordBool);                                       | Sets the asked option value.                                                    | yes  |
| procedure SetReadOnlyFileAttr(Value: WordBool);                                                      | Set the file as readonly.                                                       | yes  |
| HasPassword: WordBool;                                                                               | Returns true if the document has password.                                      | yes  |
| CreateAttachmentManager: IUnknown;                                                                   | Returns the attachment manager. (not yet implemented)                           | no   |
| GetClientFileLinksMgr: IUnknown;                                                                     | Returns links manager (not yet implemented)                                     | no   |
| GetFileOpenMode: LongWord;                                                                           | Returns the file open mode (the same as in WinAPI).                             | yes  |
| GetFileOpenReadOnly: WordBool;                                                                       | Returns true if the client file is read only.                                   | yes  |
| GetDataTracking: WordBool;                                                                           | Returns true if the data is tracked.                                            | yes  |
| GetDataLocked: WordBool;                                                                             | Return true if the data is locked.                                              | yes  |
| procedure SetDataLocked(ADataLocked: WordBool);                                                      | Set DataLocked flag.                                                            | yes  |
| procedure SetSystemDataLocked(ADataLocked: WordBool);                                                | Set the systen data as locked.                                                  | yes  |
| GetSystemLocked: WordBool;                                                                           | Returns true if the system data is locked.                                      | yes  |
| procedure SetSystemLocked(Lock: WordBool);                                                           | Set the system locked.                                                          | yes  |
| GetSystemLockedBy(out AName: WideString): WordBool;                                                  | Returns the name of user who locked the system.                                 | yes  |
| IsSystemLockedByCurrentUser: WordBool;                                                               | Returns true if the system is locked by current user.                           | yes  |
| procedure SetLanguage(ALanguage: AppLanguage);                                                       | Sets the lanaguage.                                                             | yes  |
| GetLanguage: AppLanguage;                                                                            | Returns the selected language.                                                  | yes  |
| GetCanSaveFile: WordBool;                                                                            | Returns true if the file could be saved.                                        | yes  |
| GetCanModifyData: WordBool;                                                                          | Retrusn true if the file could be modified.                                     | yes  |
| GetOpenResult: AppOpenResult;                                                                        | Returns the result of open file action.                                         | yes  |
| procedure SetOpenResult(AResult: AppOpenResult);                                                     | Sets the open file result.                                                      | no   |
| GetSaveResult: AppSaveResult;                                                                        | Returns the result of save action.                                              | yes  |
| GetDateTime: WideString;                                                                             | Returns the current date time as a string.                                      | yes  |
| IsPlanner: WordBool;                                                                                 | Returns true if the file is planner.                                            | yes  |
| procedure SetPlanner;                                                                                | Set the file as planner.                                                        | yes  |
| GetOldFileName: WideString;                                                                          | Returns the previous file name.                                                 | yes  |
| procedure SetOldFileName(const Value: WideString);                                                   | Sets the previous file name.                                                    | no   |
| IsCouplingUpdated: WordBool;                                                                         | Returns true if the coupling is updated.                                        | yes  |
| procedure SetCouplingUpdated;                                                                        | Set the CouplingUpdated flag as true.                                           | no   |
| GetReadOnlyFileAttr: WordBool;                                                                       | Returns the read only file attr.                                                | yes  |
| GetCalcPersonalDiags: WordBool;                                                                      | Calculate the personal diagnostics.                                             | yes  |
| GetIsNewerDataBaseTemplate: WordBool;                                                                | Returns true if the file is built with the newer database template.             | yes  |
| procedure SetIsNewerDataBaseTemplate(aNewerDataBaseTemplate: WordBool);                              | Set the IsNewerDatabaseTemplate flag's value.                                   | yes  |
| GetListOfReturnIDCount: Integer;                                                                     | Returns the count of list of return id.                                         | yes  |
| GetListOfReturnIDItem(AIndex: Integer): WideString;                                                  | Return the return id by index.                                                  | yes  |
| procedure SetRecalcAlways;                                                                           | Set the RecalAlways flag value.                                                 | yes  |
| CanRecalcAlways: WordBool;                                                                           | Returns true if the client file could be always recalculated.                   | yes  |

### IAppTaxDocument (local service) ###

| Method name                                                                              | Description                                                             | Test |
| ---------------------------------------------------------------------------------------- | ----------------------------------------------------------------------- | ---- |
| GetTaxpayerIdInReturn(aReturn: LongWord): WideString;                                    | Returns the taxpayer's ID in the given return.                          | no   |
| GetFileTimeStamp: WideString;                                                            | Returns the time stamp of the client file.                              | no   |
| GetTaxationYearEnd(const aReturn: IAppDocReturn): WideString;                            | retirns the end date of taxation year.                                  | no   |
| ResetDirty;                                                                              | Sets the Dirty flag to false.                                           | no   |
| IsDirty: WordBool;                                                                       | Returns the dirty flag.                                                 | yes  |
| GetDbEnv: IUnknown;                                                                      | Returns the DdEnv wrapper (not yet implemented)                         | no   |
| GetDatabase: IUnknown;                                                                   | Return the Database wrapper (not yet implemented)                       | no   |
| GetCurrentTaxData: IAppTaxData;                                                          | Return's the current tax data.                                          | yes  |
| NewDocument(const aName: WideString);                                                    | Creates a new document with a given name.                               | no   |
| FindDocReturn(aReturnId: LongWord): IAppDocReturn;                                       | Find the DocReturn by ReturnID.                                         | yes  |
| GetCurrentReturnId: LongWord;                                                            | Returns the current return ID.                                          | yes  |
| CurrentReturn: IAppDocReturn;                                                            | Returns the current return wrapper.                                     | yes  |
| GetReturnAt(anIndex: Integer): IAppDocReturn;                                            | Enumerates the returns.                                                 | yes  |
| GetReturnCount: Integer;                                                                 | Returns the return count.                                               | yes  |
| IndexOf(const aDocReturn: IAppDocReturn): Integer;                                       | Returns the index of return wrapper.                                    | yes  |
| UpdateAllHeaders;                                                                        | Update the values of all headers.                                       | no   |
| AddDocReturnForExistingTaxData(AReturnId: LongWord);                                     | creates the document for existing tax data.                             | no   |
| GetStatus: IUnknown;                                                                     | Returns the status wrapper (not yet implemented)                        | no   |
| SelectReturn(aReturnId: LongWord; ForceEvents: WordBool): WordBool;                      | Selects the return by return id.                                        | no   |
| RemoveReturn(returnId: LongWord);                                                        | Removes the return from the document by return id.                      | no   |
| getDocumentProperties: IAppProperties;                                                   | Returns the document properties wrapper                                 | yes  |
| getReturnProperties(aReturnId: LongWord): IAppStatusProperties;                          | Returns the return proeprties wrapper.                                  | yes  |
| GetCalcVersionFromHeader: WideString;                                                    | Returns the calc engine version from document header.                   | no   |
| GetDocIndexStr: WideString;                                                              | Returns document index as string.                                       | no   |
| SetDocIndexStr(const AName: WideString);                                                 | Sets the document index as string.                                      | no   |
| IsReturnRegistered(AReturnId: LongWord): WordBool;                                       | Returns true if the return with given ID is registered in the document. | no   |
| IsReturnRegisteredWithBankId(AReturnId: LongWord; out aWithBlankID: WordBool): WordBool; | the same + bank id                                                      | no   |
| IsRolled: WordBool;                                                                      | Return true if the document is rolled.                                  | yes  |
| SystemDirty: WordBool;                                                                   | sets the system dirty flag as true.                                     | yes  |
| SetCalcDirty(aDirty_: WordBool);                                                         | set the calc dirty flag value.                                          | no   |
| IsCalcDirty: WordBool;                                                                   | returns calc dirty flag.                                                | yes  |
| SetCalcPersonalDiagInterrupted(AValue: WordBool);                                        | sets CalcPersonalDiagInterrupted flag value.                            | no   |
| GetCalcPersonalDiagInterrupted: WordBool;                                                | returns CalcPersonalDiagInterrupted value.                              | yes  |
| UpdateDatabaseFromAllHeaders;                                                            | updates the database values from header's values.                       | no   |
| getDocIndex: Integer;                                                                    | Returns the doc index.                                                  | yes  |
| SetDirty;                                                                                | Sets the returns as Dirty (changed)                                     | yes  |
| DocName: WideString;                                                                     | Returns the document nam                                               e| yes  |


### IAppDocReturn (local service) ###

| Method name                                                                                                  | Description                                                                                 | Test |
| ------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- | ---- |
| GetProperties: IAppStatusProperties;                                                                         | Returns the return statuses objects.                                                        | yes  |
| GetReturnPath: WideString;                                                                                   | Returns the string representation of return path                                            | yes  |
| GetReturnId: LongWord;                                                                                       | Use to get the return unique ID.                                                            | yes  |
| GetDocument: IAppDocument;                                                                                   | Returns the owner document interface.                                                       | yes  |
| IsNameAssigned: WordBool;                                                                                    | Returns true if the name is assigned.                                                       | no   |
| GetTaxData: IAppTaxData;                                                                                     | Returns the TaxData interface.                                                              | yes  |
| SetDirty;                                                                                                    | Mark the return as dirty (not saved)                                                        | no   |
| GetIsSystemDirty: WordBool;                                                                                  | Returns true if the tax system is dirty (not stored)                                        | yes  |
| SetIsSystemDirty(AValue: WordBool);                                                                          | Mark the tax system as non-stored                                                           | no   |
| IsApplicable(aFormIndex: LongWord): WordBool;                                                                | Returns true if the form with aFormIndex is applicable for this return.                     | no   |
| IsApplicableForRepeat(aFormIndex: LongWord; aRepeatNum: LongWord): WordBool;                                 | Returns true if the return is applicable for form and repeat number                         | no   |
| IsApplicableForRepeatPath(aFormIndex: LongWord; const aRepeatPath: WideString; aRepeat: LongWord): WordBool; | Returns true if it is applicable for some form and the repeat specified by its repeat path. | no   |
| GetPropertyNameByCellName(const CellName: WideString; out PropertyName: WideString): WordBool;               | Returns status property name by some cell, if it is assignedd to some property.             | no   |
| resetDirty: WordBool;                                                                                        | resets the dirty flag                                                                       | no   |
| <em>GetInputList: IUnknown;</em>                                                                             | Returns the list of possible inputs (not implemented yet)                                   | no   |
| getAttachmentPath: WideString;                                                                               | Returns the path to the attachmenets                                                        | no   |
| GetDiagnostic: IAppDiagnostic;                                                                               | Returns the dignostic object.                                                               | yes  |
| GetAttachementManager: IAppAttachementManager                                                                | Returns the Atachements managed interface                                                   | yes  |


### IAppStatusProperties (local service) ###

| Method name                                                                                                          | Description                                                                  | Test |
| -------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------- | ---- |
| SetStringNoUserDirty(const aKey: WideString; const aValue: WideString): WordBool;                                    | Set string value and do not set change the UserDirty flag                    | no   |
| SetIntegerNoUserDirty(const aKey: WideString; aValue: Integer): WordBool;                                            | Set integer value and do not set change the UserDirty flag                   | no   |
| SetBooleanNoUserDirty(const aKey: WideString; aValue: WordBool): WordBool;                                           | Set boolean value and do not set change the UserDirty flag                   | no   |
| SetCurrencyNoUserDirty(const aKey: WideString; aValue: Currency): WordBool;                                          | Set currency value and do not set change the UserDirty flag                  | no   |
| SetDateTimeNoUserDirty(const aKey: WideString; aValue: TDateTime): WordBool;                                         | Set datetime value and do not set change the UserDirty flag                  | no   |
| SetString(const aKey: WideString; const aValue: WideString): WordBool;                                               | Sets the string value.                                                       | yes  |
| SetInteger(const aKey: WideString; aValue: Integer): WordBool;                                                       | Sets the integer value.                                                      | no   |
| SetBoolean(const aKey: WideString; aValue: WordBool): WordBool;                                                      | Sets the boolean value.                                                      | no   |
| SetCurrency(const aKey: WideString; aValue: Currency): WordBool;                                                     | Sets the currency value.                                                     | no   |
| SetDateTime(const aKey: WideString; aValue: TDateTime): WordBool;                                                    | Sets the date time value.                                                    | no   |
| SimulateSetString(const aKey: WideString; const aValue: WideString): WordBool;                                       | simulating setting the string value.                                         | no   |
| RemoveKey(const aKey: WideString): WordBool;                                                                         | removes the key from list.                                                   | yes  |
| SetSectionName(const aSectionName: WideString);                                                                      | sets the section name                                                        | no   |
| GetSectionName: WideString;                                                                                          | returns the section name.                                                    | yes  |
| Get_IsDirty: WordBool;                                                                                               | Returns IsDirty flag                                                         | yes  |
| Set_IsDirty(Value: WordBool);                                                                                        | sets IsDirty flag                                                            | no   |
| KeyExists(const aKey: WideString): WordBool;                                                                         | Return true if the key is existed.                                           | yes  |
| AsString(const aKey: WideString; const aDefaultVallue: WideString): WideString;                                      | Read the string value. If the value do not exists, use the default value.    | yes  |
| AsInteger(const aKey: WideString; aDefaultValue: Integer): Integer;                                                  | Read the integer value. If the value do not exists, use the default value.   | yes  |
| AsInt64(const aKey: WideString; aDefaultValue: Int64): Int64;                                                        | Read the int64 value. If the value do not exists, use the default value.     | no   |
| AsBoolean(const aKey: WideString; aDefaultValue: WordBool): WordBool;                                                | Read the boolean value. If the value do not exists, use the default value.   | yes  |
| AsCurrency(const aKey: WideString; aDefaultValue: Currency): Currency;                                               | Read the currency value. If the value do not exists, use the default value.  | no   |
| AsDateTime(const aKey: WideString; aDefaultValue: TDateTime): TDateTime;                                             | Read the date time value. If the value do not exists, use the default value. | no   |
| GetKeyAt(aIndex: Integer; out aReturnedKey: WideString): WordBool;                                                   | returns the key name by index.                                               | yes  |
| GetKeyCount: Integer;                                                                                                | Returns the count of keys.                                                   | yes  |
| Empty;                                                                                                               | clears all properties.                                                       | no   |
| IsEmpty: WordBool;                                                                                                   | Returns true of the list is empty.                                           | no   |
| Get_Count: Integer;                                                                                                  | Retuns the count of keys.                                                    | yes  |
| Get_IsDataOwner: WordBool;                                                                                           | Returns IsDataOwner flag.                                                    | no   |
| Get_IsSorted: WordBool;                                                                                              | Returns IsSorted flag.                                                       | no   |
| Set_IsSorted(Value: WordBool);                                                                                       | Sets IsSorted flag.                                                          | no   |
| GetReturnStatus(ALanguage: AppLanguage): WideString;                                                                 | Returns the value of ReturnStatus key.                                       | yes  |
| GetStatusInLanguage(const AStatusName: WideString; ALanguage: AppLanguage; const AEnumName: WideString): WideString; | Returns the string representation of key in some language.                   | yes  |

### IAppTaxReturn (local service) ###

| Method name                                                                                                                 | Description                                                  | Test |
| --------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------ | ---- |
| SaveConfiguration;                                                                                                          | Save the configuration                                       | no   |
| ReadConfiguration;                                                                                                          | Read the configuration                                       | no   |
| OpenTaxForm(const FormNAme: WideString): WordBool;                                                                          | Opens the a tax return form                                  | no   |
| CtrlGJumpToCellForm(AJumpAction: Integer; AJumpLevel: Integer);                                                             | Jump to cell                                                 | no   |
| AcceptUserInput: WordBool;                                                                                                  | Returns true if the current fields accepts the user input.   | yes  |
| EnableCellBrowserButtons(EnableBrowserCommands: WordBool);                                                                  | Enables the cells browser buttons.                           | no   |
| DoFMSearch;                                                                                                                 | search the form.                                             | no   |
| DoFMClearSearch;                                                                                                            | clear the fm serach                                          | no   |
| UpdateFormMenuItems(UpdatingLevel: AppUpdatingMenuLevel);                                                                   | updates the menu items.                                      | no   |
| ProcessPrintButton;                                                                                                         | execute the print button actions.                            | no   |
| GetFormEngine: IUnknown;                                                                                                    | Return the form engine wrapper (not yet implemented)         | no   |
| GetEntryUndoManager: IUnknown;                                                                                              | Returns the undo manager (not yet implemented)               | no   |
| CanDeactivateCurrentReturn: WordBool;                                                                                       | Returns true if the current return could be deactivated now. | no   |
| NewTaxReturn: WordBool;                                                                                                     | Create a new tax return.                                     | no   |
| DoSaveTaxReturn;                                                                                                            | Save the tax return.                                         | no   |
| DoSaveTaxReturnAs;                                                                                                          | Save the tax return as.                                      | no   |
| ShowFMSearchBarItems(pVisible: WordBool);                                                                                   | Shows/hides the fm serch                                     | no   |
| GetFMSearchKey: WideString;                                                                                                 | returns the current fm seach text.                           | no   |
| SetFMSearchKey(const aString: WideString);                                                                                  | set the current fm serach text.                              | no   |
| GetXpressModule: IUnknown;                                                                                                  | Returns the Xpress module (not imeplemented)                 | no   |
| GetScanModule: IUnknown;                                                                                                    | Returns scan module (not yet implemented)                    | no   |
| GetFormManager: IUnknown;                                                                                                   | Returns form manager (not yet implemented)                   | no   |
| GetDiagnosticKey: WordBool;                                                                                                 | Returns the diagnostic key value.                            | yes  |
| GetScanKey: WordBool;                                                                                                       | Returns the scan key value.                                  | yes  |
| GetXpressKey: WordBool;                                                                                                     | Returns the Xpress key value.                                | yes  |
| SetDiagnosticKey(AValue: WordBool);                                                                                         | Set the Diagnostic key value.                                | no   |
| SetScanKey(AValue: WordBool);                                                                                               | Sets the scan key value.                                     | no   |
| SetXpressKey(AValue: WordBool);                                                                                             | Sets the Xpress key value.                                   | no   |
| ActivateDiagnosticFrame(aActive: WordBool);                                                                                 | Focus the diagnostic frame.                                  | no   |
| ActivateXpressFrame(AValue: WordBool);                                                                                      | Focus the Xpress frame.                                      | no   |
| ActivateScanFrame(activate: WordBool; aFromFormManager: WordBool; aFromModuleChange: WordBool; aFromRevisionBar: WordBool); | Focus the Scan frame.                                        | no   |
| ActivateRevisionBar(activate: WordBool);                                                                                    | Focus the Revision Bar.                                      | no   |
| ActivateMonitor(activate: WordBool);                                                                                        | Focus the Monitor.                                           | no   |
| AddScanPage;                                                                                                                | Adds a page to the Scan module.                              | no   |
| RemoveScanPage;                                                                                                             | Removes the page from Scan module.                           | no   |
| XpressCustomizedFilterModified(const AFilterName: WideString);                                                              | send the modified event to Xpress module.                    | no   |
| IsXpressTabActive: WordBool;                                                                                                | Reuturns true us the Xpress tab is active.                   | no   |
| IsScanTabVisible: WordBool;                                                                                                 | Return true is Scan tab is visible.                          | no   |
| IsRevisionbarFrameVisible: WordBool;                                                                                        | Returns true if the Revisionbar frame is visible.            | no   |
| CheckDiagFlagForForm(const AFormName: WideString): WordBool;                                                                | checks the diagnostic for the form given by name.            | no   |
| DoJumpToCellForm(const AFormName: WideString; const ACellPath: WideString; AICell: LongWord): Integer;                      | Jump to cell.                                                | no   |
| SwitchReturn(AReturnID: LongWord): WordBool;                                                                                | Swithc to another return by id.                              | no   |
| GetBasicTaxReturn: IUnknown;                                                                                                | Returns the basic tax return wrapper (not yet implemented)   | no   |
| ShowFormManager;                                                                                                            | Shows the form manager.                                      | no   |
| GetReviewMode: WordBool;                                                                                                    | Returns the review mode.                                     | no   |
| SetReviewMode(AValue: WordBool);                                                                                            | Sets the review mode flag.                                   | no   |
| GetReviewModeMark: AppReviewModeMark;                                                                                       | Returns the review mode mark.                                | no   |
| SetReviewModeMark(AValue: AppReviewModeMark);                                                                               | Sets the review mode mark.                                   | no   |
| GetDisplayReviewMarks: WordBool;                                                                                            | Displays the review marks.                                   | no   |
| PrintCurrentForms;                                                                                                          | Print the current form.                                      | no   |
| RefreshTreeList;                                                                                                            | Refresh the tree list.                                       | no   |

### IAppTaxCell (Local service) ###

| Method name                                                                                                                        | Description                                                                              | Test |
| ---------------------------------------------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------------- | ---- |
| GetOwnerTaxData: IAppTaxData;                                                                                                      | Returns the TaxData wrapper.                                                             | yes  |
| GetChoices(AIndex1: Integer; AIndex2: Integer; ALanguage: AppLanguage): WideString;                                                | Returns the list of choises (Xlat and link cell)                                         | yes  |
| GetOwnerRepeatId: LongWord;                                                                                                        | Returns the owner repeat id.                                                             | yes  |
| GetCellName: WideString;                                                                                                           | Returns the cell name                                                                    | yes  |
| GetCellNameWithGroup: WideString;                                                                                                  | Returns the cell name with group path.                                                   | yes  |
| GetComparableCellName: WideString;                                                                                                 | Returns the cell name for compariotion.                                                  | no   |
| GetAliasNames(AIndex: Integer): WideString;                                                                                        | Returns the alias name by its index.                                                     | yes  |
| GetDescriptionString(GlobalDescriptionOnly: WordBool): WideString;                                                                 | Returns the cell description text.                                                       | no   |
| GetCellIndex: LongWord;                                                                                                            | Returns the cell index.                                                                  | yes  |
| GetFormNum: LongWord;                                                                                                              | Returns the number of form.                                                              | yes  |
| CopyCell(const AFrom: IAppTaxCell);                                                                                                | Copy cell value from given cell wrapper.                                                 | no   |
| VirtualCompare(const ACell: IAppTaxCell): Integer;                                                                                 | Compare the cell's values.                                                               | no   |
| CompareToString(const sValue: WideString): WordBool;                                                                               | Compare the cell value with string value                                                 | no   |
| AcceptUserInput(const SValue: WideString): WordBool;                                                                               | Return true if the given value is correct.                                               | no   |
| AcceptImportedInput(const SValue: WideString): WordBool;                                                                           | Returns true if the cell accept imported user input.                                     | no   |
| AcceptUserVariantValue(Value: OleVariant): WordBool;                                                                               | Return true if the given value is correct.                                               | no   |
| AcceptImportedVariantValue(Value: OleVariant): WordBool;                                                                           | Return true if the given imported value is correct.                                      | no   |
| ConvertFromString(const sValue: WideString): WordBool;                                                                             | Convert the string to cell value.                                                        | yes  |
| ToString: WideString;                                                                                                              | Returns the string value of the cell.                                                    | yes  |
| ConvertToString(var sValue: WideString): WordBool;                                                                                 | Try to convert the cell value to string.                                                 | yes  |
| GetVariantValue: OleVariant;                                                                                                       | Returns the variant value.                                                               | yes  |
| ClearCell;                                                                                                                         | Clear the cell value.                                                                    | no   |
| Reset;                                                                                                                             | Reset the cell to default.                                                               | no   |
| Clear;                                                                                                                             | Clear the cell.                                                                          | no   |
| RemoveUserOverride;                                                                                                                | Remove the user overrided value.                                                         | no   |
| AssignEmpty;                                                                                                                       | Assign empty cell value.                                                                 | no   |
| EqualsEmpty: WordBool;                                                                                                             | Returns true if the cell value is empty.                                                 | yes  |
| DoSelection: WordBool;                                                                                                             | Return true if the selection was succeded.                                               | no   |
| IsEmpty: WordBool;                                                                                                                 | Return true if the cell value is empty.                                                  | yes  |
| IsProtected: WordBool;                                                                                                             | Returns true if the cell is protected.                                                   | yes  |
| IsDeprecated: WordBool;                                                                                                            | Returns true is the cell is deprecated.                                                  | yes  |
| HasFormNum: WordBool;                                                                                                              | Returns true if the cell has form number.                                                | yes  |
| IsPositiveOnly: WordBool;                                                                                                          | Returns true if the cell accepts only positive numbers.                                  | yes  |
| IsRoundOnAssign: WordBool;                                                                                                         | Returns true if the cell value will be rounded on assigning.                             | yes  |
| IsSelectable: WordBool;                                                                                                            | Returns true if the cell is selecable.                                                   | yes  |
| HasUserOvrd: WordBool;                                                                                                             | Returns true if the cell has user override.                                              | yes  |
| CanAssignTo: WordBool;                                                                                                             | Returns true if the cell could be assigned to.                                           | yes  |
| HasInput: WordBool;                                                                                                                | Returns true if the cell has input.                                                      | yes  |
| HasCalc: WordBool;                                                                                                                 | Returns true if the cell has calc assigned.                                              | yes  |
| HasInternalOvrd: WordBool;                                                                                                         | Returns true if the cell contains internal override.                                     | yes  |
| IsEstimated: WordBool;                                                                                                             | Returns the value of Estimated flag.                                                     | yes  |
| IsSourceEstimate: WordBool;                                                                                                        | Returns the value of SourceEstimated flag.                                               | yes  |
| IsRolled: WordBool;                                                                                                                | Returns true if the cell value is rolled forward.                                        | yes  |
| HasRolledValue: WordBool;                                                                                                          | Returns true if the cell has rolled forward value.                                       | yes  |
| IsImported: WordBool;                                                                                                              | Return true if the cell is imported.                                                     | yes  |
| SetImported;                                                                                                                       | Sets imported flag to true.                                                              | no   |
| IsNA: WordBool;                                                                                                                    | Returns true if the cell value is NA.                                                    | yes  |
| IsTracking: WordBool;                                                                                                              | Returns the IsTracking flag value.                                                       | yes  |
| GetTransferSource: Integer;                                                                                                        | Returns the transfer source flag.                                                        | no   |
| SetTransferSource(Value: Integer);                                                                                                 | Sets the transfer source flag.                                                           | no   |
| HasTransferredValue: WordBool;                                                                                                     | Returns true if cell contains the transferred value.                                     | no   |
| WasTransferred: WordBool;                                                                                                          | Returns true if the cell was transferred.                                                | yes  |
| GetAttachedScheduleRepeat: LongWord;                                                                                               | Returns the attached schedule repeat id.                                                 | no   |
| GetAttachedNoteRepeat: LongWord;                                                                                                   | Returns attached note repeat id.                                                         | no   |
| HasAttachedSchedule: WordBool;                                                                                                     | Returns true if the cell contains attached scheduler.                                    | yes  |
| HasAttachedNote: WordBool;                                                                                                         | Returns true ifk the cell contains the attached note.                                    | yes  |
| GetAttachedNoteText: WideString;                                                                                                   | Returns the attached note text.                                                          | yes  |
| SetAttachedNoteText(const Value: WideString);                                                                                      | Sets the attached note text.                                                             | no   |
| GetAttachmentTargetForExpand: IAppTaxCell;                                                                                         | Returns the attachment cell target.                                                      | no   |
| SetCalc;                                                                                                                           | Set Calc flag to true.                                                                   | no   |
| ClearCalc;                                                                                                                         | Clear the calc flag                                                                      | no   |
| SetCalcOrderUsed;                                                                                                                  | Sets calc order used flag.                                                               | no   |
| SetProtected;                                                                                                                      | Set protected flag.                                                                      | no   |
| SetHasFormNum;                                                                                                                     | Set has form num flag.                                                                   | no   |
| ClearInput;                                                                                                                        | Clears the input.                                                                        | no   |
| ClearEstimate;                                                                                                                     | Clears the estimate.                                                                     | no   |
| SetEstimate;                                                                                                                       | Sets the estimate flag.                                                                  | no   |
| SetNotEmpty;                                                                                                                       | Set not empty flag.                                                                      | no   |
| PromoteCalcToInput;                                                                                                                | ???                                                                                      | no   |
| SetRolled;                                                                                                                         | Set rolled flag.                                                                         | no   |
| ClearRolled;                                                                                                                       | Clears rolled flag.                                                                      | no   |
| SetSourceEstimate;                                                                                                                 | Set source estimate flag.                                                                | no   |
| ClearSourceEstimate;                                                                                                               | Clears source estimate flag.                                                             | no   |
| SetInternalOvrd;                                                                                                                   | Sets internal override flag.                                                             | no   |
| ClearInternalOvrd;                                                                                                                 | Clears internal override flag.                                                           | no   |
| ClearCalcOrderFlags;                                                                                                               | Clears calc order flags                                                                  | no   |
| SetNA;                                                                                                                             | Set NA flag.                                                                             | no   |
| ClearNA;                                                                                                                           | Clear NA flag.                                                                           | no   |
| SetIsTracking;                                                                                                                     | Set IsTracking flag.                                                                     | no   |
| ClearIsTracking;                                                                                                                   | Clear IsTracking flag.                                                                   | no   |
| SetReviewMark(markNum: LongWord);                                                                                                  | Sets review mark number.                                                                 | no   |
| ClearReviewMark;                                                                                                                   | Clear review mark flag and number.                                                       | no   |
| GetReviewMark: LongWord;                                                                                                           | Returns review mark number if any.                                                       | no   |
| GetCellTypeText: WideString;                                                                                                       | Returns cell type string representation.                                                 | yes  |
| GetDefaultDelimiterString: WideString;                                                                                             | Returns the default delimiter.                                                           | no   |
| GetSampleText(Fmt: Int64): WideString;                                                                                             | Returns the sample text.                                                                 | no   |
| GetEditControlMask(Fmt: Int64): WideString;                                                                                        | Reads the edit control mask.                                                             | no   |
| GetCellType: Int64;                                                                                                                | Returns cell type id.                                                                    | yes  |
| GetAssociatedStringTable: Integer;                                                                                                 | Returns the id of assiciated string table.                                               | no   |
| GetDesiredFieldLength(Fmt: Int64): Integer;                                                                                        | Returns desired field length for given format.                                           | no   |
| GetRelevantFormattingOptions: Int64;                                                                                               | Returns formatting options.                                                              | no   |
| GetGenericObject: IAppTaxCell;                                                                                                     | Returns generic cell.                                                                    | no   |
| IsInFilter(InclusionFilter: Integer; ExclusionFilter: Integer): WordBool;                                                          | Returns true if the cell is acceptable for given filter.                                 | no   |
| GetAliasNamesCount: Integer;                                                                                                       | Returns the count of aliases.                                                            | yes  |
| GetChoicesCount(out ACount1: Integer; out ACount2: Integer; ALanguage: AppLanguage);                                               | Returns the count of choises.                                                            | yes  |
| GetXLatValue(const AApplication: IAppTaxApplicationService; ALanguage: AppLanguage; AColumn: Integer; Index: Integer): WideString; | Returns Xlat value.                                                                      | yes  |
| GetXLatValuesCount(ALanguage: AppLanguage; const AApplication: IAppTaxApplicationService): Integer;                                | Returns Xlat values count.                                                               | yes  |
| IsLinkCell: WordBool                                                                                                               | Returns true in case if the cell is LinkCell                                             | yes  |
| LinkCellColumnCount(const AFormName: WideString): Integer                                                                          | Returns the count of columns in the Dialog, which would be opened in the apropriate form | yes  |
| LinkCellSelectedRow(const AFormName: WideString; AIndex: Integer): WideString                                                      | Returns the value in the LinkCell dialog, which is currently selected                    | yes  |
| LinkCellRowCount(const AFormName: WideString): Integer                                                                             | Returns the count of rows in the LinkCell dialog                                         | yes  |
| LinkCellTable(const AFormName: WideString; ARow: Integer; AColumn: Integer): WideString                                            | Returns the value of cell in the LinkCell dialog                                         | yes  |
| LinkCellColumnNames(const AFormName: WideString; AIndex: Integer): WideString                                                      | Returns the title in the LinkCell dialog                                                 | yes  |


### IAppTaxData (local service) ###

| Method name                                                                                                                                                 | Description                                                        | Test |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------ | ---- |
| RootGroup: IAppGroupArray;                                                                                                                                  | Reutns the root owner group.                                       | yes  |
| GetReturnId: LongWord;                                                                                                                                      | Returns the return ID                                              | yes  |
| IsADependent: WordBool;                                                                                                                                     | Returns ADependent flag value.                                     | no   |
| GetDependentIndex: Integer;                                                                                                                                 | Returns DependantIndex.                                            | no   |
| GetPermanentId: LongWord;                                                                                                                                   | Returns the permanent group id.                                    | no   |
| GetNextRepeatId: LongWord;                                                                                                                                  | Return the next repeat id.                                         | yes  |
| GetOwnerClient: IUnknown;                                                                                                                                   | Returns the owner TaxClient (not yet implemented)                  | no   |
| GetRelatedData(AResurnId: LongWord): IAppTaxData;                                                                                                           | Gets the related tax data for given return id.                     | no   |
| GetExportTag: WideString;                                                                                                                                   | Returns the ExportTag value.                                       | no   |
| GetShortNames(AIndex: Integer; out AName: WideString; out ANumIndicesRequired: Integer);                                                                    | Returns the short name by index.                                   | yes  |
| GetShortNamesCount: Integer;                                                                                                                                | Returns the short names count.                                     | yes  |
| GetCellByName(const CellName: WideString; CreateRepeatsAsNeeded: WordBool; MarkNewRepeatsAsCreatedByUser: WordBool): IAppTaxCell;                           | Locate the cell by it's name.                                      | yes  |
| GetLinkVarByName(const LinkName: WideString; CreateRepeatsAsNeeded: WordBool; MarkNewRepeatsAsCreatedByUser: WordBool): IUnknown;                           | Returns Link by it's name (not yet implemented)                    | no   |
| GetGroupByName(const Name: WideString; CreateRepeatsAsNeeded: WordBool; MarkNewRepeatsAsCreatedByUser: WordBool): IAppGroupArray;                           | Returns group by it's name                                         | yes  |
| GetRepeatByName(const Name: WideString; out RepeatNum: LongWord; CreateRepeatsAsNeeded: WordBool; MarkNewRepeatsAsCreatedByUser: WordBool): IAppGroupArray; | Locate repeat by it's name                                         | no   |
| GetRepeatById(RepeatId: LongWord; out RepeatNum: LongWord): IAppGroupArray;                                                                                 | Locate the repeat by repeat id.                                    | yes  |
| GetAliasNames(const ACellName: WideString; AIndex: Integer): WideString;                                                                                    | Get alias name by index.                                           | yes  |
| GetAliasNamesCount(const ACellName: WideString): Integer;                                                                                                   | Get count of aliases.                                              | yes  |
| GetNumAttachments(AttachmentType: Integer): Integer;                                                                                                        | Retuns quantity of attachments.                                    | no   |
| GetAttachmentTarget(AttachmentType: Integer; RepeatNum: LongWord): IAppTaxCell;                                                                             | Returns the atachment target cell.                                 | no   |
| GetAttachSchedTitleCell(RepeatNum: LongWord): IAppTaxCell;                                                                                                  | Returns the attachment's tittle cell.                              | no   |
| GetAttachSchedTotalCell(RepeatNum: LongWord): IAppTaxCell;                                                                                                  | Retrusn the attachment's total cell.                               | no   |
| GetAttachNoteCell(RepeatNum: LongWord): IAppTaxCell;                                                                                                        | Returns the attachment's note cell.                                | no   |
| GetAttachNoteDescCell(RepeatNum: LongWord): IAppTaxCell;                                                                                                    | Returns the attachment's description cell.                         | no   |
| GetAttachNoteRollOptionCell(RepeatNum: LongWord): IAppTaxCell;                                                                                              | Returns the attachment's note roll option cell.                    | no   |
| IsAttachmentRollOptionAvailable(AttachmentType: LongWord): WordBool;                                                                                        | Returns true if the attachment roll option is available.           | no   |
| GetAttachmentRollOption(AttachmentType: LongWord; RepeatNum: LongWord): WordBool;                                                                           | Return the value of attachment roll option.                        | no   |
| GetAttachmentGroup(AttachmentType: LongWord): IAppGroupArray;                                                                                               | Return the attachment group by attachment type.                    | no   |
| GetCellDescription(const CellName: WideString; Language: AppLanguage): WideString;                                                                          | Returns the cell description.                                      | no   |
| GetLinkDescription(const LinkName: WideString; Language: AppLanguage): WideString;                                                                          | Returns link description.                                          | no   |
| IsGroupNamePossible(const Name: WideString): WordBool;                                                                                                      | Returns true if the gooup name is valid.                           | no   |
| IsCellNamePossible(const Name: WideString): WordBool;                                                                                                       | Returns true if the cell name is valid.                            | no   |
| IsLinkNamePossible(const Name: WideString): WordBool;                                                                                                       | Returns true if the link name is valid.                            | no   |
| GetDefaultYear(Day: Integer; Month: Integer): Integer;                                                                                                      | Returns the default year for a given month and day.                | yes  |
| IsFormApplicable(FormNum: LongWord): WordBool;                                                                                                              | Returns true if the form with given number is applicable.          | no   |
| GetNumApplicableCopies(FormNum: LongWord): SYSUINT;                                                                                                         | Returns the quantity of applicable copies for a given form number. | no   |
| GetFormName(FormNum: LongWord): WideString;                                                                                                                 | Returns the form name by it's number.                              | no   |


### IAppGroupArray (local service) ###

| Method name                                                                                                                                                        | Description                                                  | Test |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ------------------------------------------------------------ | ---- |
| RemoveAllLinks;                                                                                                                                                    | Remove all assigned links.                                   | no   |
| DuplicateStructure(const From: IAppGroupArray): WordBool;                                                                                                          | Create the group with the same structure.                    | no   |
| DuplicateContents(const From: IAppGroupArray): WordBool;                                                                                                           | Create the group with the same contents.                     | no   |
| GetNumRepeats: LongWord;                                                                                                                                           | Returns the quantity of repeats.                             | yes  |
| GetMinRepeats: LongWord;                                                                                                                                           | Return the minimal repeat id.                                | yes  |
| GetMaxRepeats: LongWord;                                                                                                                                           | Return the max repeat id.                                    | yes  |
| GetNumCells: LongWord;                                                                                                                                             | Return the quantity of cells.                                | no   |
| GetNumLinks: LongWord;                                                                                                                                             | Return the quantityt of links.                               | no   |
| GetNumSubgroups: LongWord;                                                                                                                                         | Return the quanityt of subgroups.                            | yes  |
| GetIndex: LongWord;                                                                                                                                                | Return the group index.                                      | yes  |
| GetGroupInfo: IAppGroupInfo;                                                                                                                                       | Return the group info wrapper.                               | yes  |
| GetFormNum: LongWord;                                                                                                                                              | Return the form number.                                      | no   |
| IsRepeatingGroup: WordBool;                                                                                                                                        | Return true if the group is repeating.                       | no   |
| InUse: WordBool;                                                                                                                                                   | Returns true if the group is in use.                         | no   |
| GetOwner: IAppGroupArray;                                                                                                                                          | Return the owner group.                                      | yes  |
| GetOwnerByRepeatIndex(RepeatNum: LongWord): IAppGroupArray;                                                                                                        | Find the owner by repeat index.                              | no   |
| GetOwnerById(RepId: LongWord): IAppGroupArray;                                                                                                                     | Find the owner by repeat id.                                 | no   |
| GetName(GetFullName: WordBool): WideString;                                                                                                                        | returns the group name.                                      | yes  |
| GetSubgroup(GrpNum: LongWord; RepNum: LongWord): IAppGroupArray;                                                                                                   | Returns subgroup by group number and repeat number.          | yes  |
| GetSubgroupFromRepeat0(GrpNum: LongWord): IAppGroupArray;                                                                                                          | Return the subgroup from repeat #0.                          | no   |
| GetCellFromRepeat(CellNum: LongWord; RepNum: LongWord): IAppTaxCell;                                                                                               | Gets cell from repeat by cell number.                        | no   |
| GetCellFromRepeat0(CellNum: LongWord): IAppTaxCell;                                                                                                                | Gets cell from repeat #0                                     | no   |
| GetRepeatId(RepNum: LongWord): LongWord;                                                                                                                           | Returns the repeat id by repeat number.                      | yes  |
| FindRepeatById(RepId: LongWord): LongWord;                                                                                                                         | Find the repeat number by repeat id.                         | yes  |
| CreateRepeat(NumRepeats: LongWord; InsertionPoint: LongWord; CreatedByUser: WordBool): WordBool;                                                                   | Creates a repeat.                                            | no   |
| CreateRolledRepeat(const SourceGroup: IAppGroupArray; SourceRepNum: LongWord): LongWord;                                                                           | Creates a repeat for roll forward.                           | no   |
| MapRolledRepeat(RepNum: LongWord; const SourceGroup: IAppGroupArray; SourceRepNum: LongWord);                                                                      | Maps repeat to last year repeat.                             | no   |
| DeleteRepeat(IndexToDelete: LongWord; NumToDelete: LongWord);                                                                                                      | Delete repeat(-s) by repeat number.                          | no   |
| ResetArray;                                                                                                                                                        | reset the list of subgroups.                                 | no   |
| AssignCells(const From: IAppGroupArray);                                                                                                                           | assign cells from one group to another.                      | no   |
| AssignCellsEx(const From: IAppGroupArray; TargetRepNum: LongWord; SourceRepNum: LongWord);                                                                         | assign cells from one group to another.                      | no   |
| MultiplyCellsInt(Value: Integer);                                                                                                                                  | Multiply cells value.                                        | no   |
| MultiplyCellsDecimal(AValue: Currency);                                                                                                                            | Multiply cells value.                                        | no   |
| MultiplyCellsFloat(AValue: Single);                                                                                                                                | Multiply cells value.                                        | no   |
| MultiplyCellsByCell(const ACell: IAppTaxCell);                                                                                                                     | Multiply cells value.                                        | no   |
| ResolveLinkedRepeats: WordBool;                                                                                                                                    | Is the linked repeat resolved.                               | no   |
| ResetRepeat(RepNum: LongWord);                                                                                                                                     | Reset repeat by it's repeat number.                          | no   |
| IsRepeatOwnedByLinkOfType(RepNum: LongWord; const GroupInfo: IUnknown; LinkNum: LongWord): WordBool;                                                               | Not yet implemented.                                         | no   |
| HasCellsWithInput(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool;                                                                                        | Returns true if the group contains cells with user input.    | no   |
| GetNumCellsWithInput(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer;                                                                                      | Returns quantity of cells with use input.                    | no   |
| HasOverriddenCells(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool;                                                                                       | Returns true if the group contains cells with user override. | no   |
| HasOverriddenCellsOnForms(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool;                                                                                | Returns true if the group contains cells with user override. | no   |
| GetNumOverriddenCells(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer;                                                                                     | Returns quantity of cells with user override.                | no   |
| GetNumOverriddenCellsOnForms(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer;                                                                              | Returns quantity of cells with user override.                | no   |
| WasCreatedByUser(RepeatNum: LongWord): WordBool;                                                                                                                   | Returns true if the return was created by user.              | no   |
| GetOwnerTaxData: IAppTaxData;                                                                                                                                      | Returns owner tax data wrapper.                              | yes  |
| ResetCalcOrderBits;                                                                                                                                                | Resets calc order bits.                                      | no   |
| ClearApplicInfo;                                                                                                                                                   | clears the applicable information.                           | no   |
| ClearAllReviewMarks(DoSubgroups: WordBool; RepeatNum: LongWord);                                                                                                   | Clears all review marks.                                     | no   |
| ClearEstimateFlags(DoSubgroups: WordBool; RepeatNum: LongWord);                                                                                                    | Clears all estimated flags.                                  | no   |
| ClearIsTrackingFlags(DoSubgroups: WordBool; RepeatNum: LongWord);                                                                                                  | Clears all tracking flags.                                   | no   |
| SetIsTrackingFlags(DoSubgroups: WordBool; RepeatNum: LongWord): WordBool;                                                                                          | Sets all tracking flags to true.                             | no   |
| AddApplicableForm(FormNum: LongWord; RepNum: LongWord): WordBool;                                                                                                  | Adds applicable form.                                        | no   |
| IsFormApplicable(FormNum: LongWord; RepNum: LongWord): WordBool;                                                                                                   | Returns true if the form is applicable.                      | no   |
| GetCorrespondingComparativeRepeat(CurrentYearRepeatNumber: LongWord; const ComparativeReturn: IAppTaxData; out ComparativeRepeatNumber: LongWord): IAppGroupArray; | Gets the comparative repeat.                                 | no   |
| GetCorrespondingCurrentYearRepeat(ComparativeRepeatNumber: LongWord; const CurrentYearReturn: IAppTaxData; out CurrentYearRepeatNumber: LongWord): IAppGroupArray; | Gets current year repeat                                     | no   |


### IAppGroupInfo (local service) ###

| Method name                                                                        | Description                                                       | Test |
| ---------------------------------------------------------------------------------- | ----------------------------------------------------------------- | ---- |
| GetName: WideString;                                                               | Group name                                                        | yes  |
| GetFullName: WideString;                                                           | Group full name                                                   | yes  |
| GetTemplateGroupName: WideString;                                                  | The template name                                                 | no   |
| GetNumCells: LongWord;                                                             | quantity of cells                                                 | no   |
| GetNumLinks: LongWord;                                                             | quantity of links                                                 | no   |
| GetNumSubgroups: LongWord;                                                         | quantity of subgroups.                                            | no   |
| GetCellType(CellNumber: LongWord): LongWord;                                       | cell type by cell number.                                         | no   |
| IsCellProtected(CellNumber: LongWord): WordBool;                                   | Cell IsProtected flag.                                            | no   |
| CellHasFormNumOverride(CellNumber: LongWord): WordBool;                            | True if the cell has form number override.                        | no   |
| GetFormNumForCell(CellNumber: LongWord): LongWord;                                 | Returns form number for cell number.                              | no   |
| GetMaskString(Index: Integer): WideString;                                         | Returns mask strings by index.                                    | no   |
| GetSubgroup(Index: LongWord): IAppGroupInfo;                                       | Sub group information                                             | yes  |
| GetSubgroupByName(const Name: WideString): IAppGroupInfo;                          | Sub group information by subgroup name                            | no   |
| GetRollMapping(const CellName: WideString; out SkipThisOne: WordBool): WideString; | Rolling mapping info for cell name                                | no   |
| GetParent: IAppGroupInfo;                                                          | parent group group info                                           | yes  |
| GetMaxRepeats: LongWord;                                                           | Max repeat id                                                     | yes  |
| GetMinRepeats: LongWord;                                                           | Min repeat id                                                     | yes  |
| GetLinkedGroup(LinkNum: LongWord): IAppGroupInfo;                                  | Linked group by link number.                                      | no   |
| GetLinkedGroupForLinkCell(CellNum: LongWord): IAppGroupInfo;                       | Linked group for LinkCell.                                        | no   |
| GetLinkSelectionCellNum(LinkNum: LongWord): LongWord;                              | Linked selection cell number.                                     | no   |
| GetLinkCellSelectionCellNum(CellNum: LongWord): LongWord;                          | Cell number for LinkCell                                          | no   |
| IsOwnerLink(LinkNum: LongWord): WordBool;                                          | True if the link is owner link                                    | no   |
| IsGenericLink(LinkNum: LongWord): WordBool;                                        | True if the link is generic link.                                 | no   |
| GetIndex: LongWord;                                                                | Returns group index.                                              | no   |
| GetAllLevelsCount: LongWord;                                                       | Returns the quantity of all levels subgroups.                     | no   |
| GetAllLevels(AIndex: Integer): IAppGroupInfo;                                      | Group info for all levels                                         | no   |
| GetNumRepeatingLevels: Integer;                                                    | Get quantity of repeating levels.                                 | no   |
| GetAllIndicesCount: Integer;                                                       | Get quantity of all indices.                                      | no   |
| GetAllIndices(AIndex: Integer): LongWord;                                          | ???                                                               | no   |
| GetFormNum: LongWord;                                                              | Returns form number.                                              | no   |
| DescendsFrom(const Info: IAppGroupInfo): WordBool;                                 | Returns true if the group is descandant for given group info.     | no   |
| GetTemplateVersion: LongWord;                                                      | Returns the number of template version.                           | no   |
| InUse: WordBool;                                                                   | Returns true if the group is in use.                              | no   |
| IsRepeatingGroup: WordBool;                                                        | Returne true if the group is repeating group.                     | no   |
| IsDeprecated: WordBool;                                                            | Returns true if the group is deprecated.                          | no   |
| IsCellDeprecated(CellNum: LongWord): WordBool;                                     | Returns true if the cell is marked as deprecated.                 | no   |
| IsLinkDeprecated(LinkNum: LongWord): WordBool;                                     | Returns true if the link is marked as deperecated.                | no   |
| HasIdenticalStructureAs(const GroupInfo: IAppGroupInfo): WordBool;                 | Returns true if the group has identical structure as given group. | no   |
| GetCellClassName(CellNumber: LongWord): WideString;                                | Returns the internal cell class name.                             | no   |
| ConstructTempCell(CellNum: LongWord): IAppTaxCell;                                 | Create a temporary cell.                                          | no   |
| CalcHeapUsageForCellsAndLinks: Integer;                                            | Returns the amount of memory used by cells and links              | no   |

### IAppCellSelectionIter (local service) ###

| Method name         | Description                             | Test |
| ------------------- | --------------------------------------- | ---- |
| First;              | Reset the iterator to the first record. | yes  |
| Last;               | Set the iterator to the last record.    | yes  |
| Next;               | Select the next field.                  | yes  |
| Current: IAppFIeld; | Returns the current selected field.     | yes  |
| IsDone: WordBool;   | Returns EOF if not more field in list.  | yes  |

### IAppConfiguration (local service) ###

Access to configuration for reading, writing. Also provide a set of events to listen the configuration changes. Fully covered by tests.

### IAppDiagnostic and IAppDiagNode (local service) ###

Provide access to list of diagnostics. The wrapper is fully covered by tests.


### IAppField (local service) ###

| Method name                                                                                                                                                              | Description                                                    | Test |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | -------------------------------------------------------------- | ---- |
| IsOfType(ATypeID: AppGraphicID): WordBool;                                                                                                                               | Returns true if the field is of given type.                    | no   |
| GetCellText: WideString;                                                                                                                                                 | Return the cell text.                                          | yes  |
| SetCellText(const AValue: WideString);                                                                                                                                   | Sets the cell text.                                            | no   |
| GetFieldColor: Integer;                                                                                                                                                  | Return the cell color.                                         | no   |
| GetCellFmt: Int64;                                                                                                                                                       | Return the cell format.                                        | no   |
| SetCellFmt(AValue: Int64);                                                                                                                                               | Set the cell format.                                           | no   |
| SetFieldColor(AValue: Integer);                                                                                                                                          | Sets the cell color.                                           | no   |
| SetFieldCellPath(const APath: WideString);                                                                                                                               | Sets the cell path                                             | no   |
| GetFieldCellPath(Alternative: WordBool): WideString;                                                                                                                     | Return the apropriate cell path.                               | no   |
| SetFieldFlags(cFlagHelp: WordBool; cFlagEnabled: WordBool; cFlagAutoText: WordBool; cFlagNoXpress: WordBool; cFlagAllowDecimal: WordBool);                               | Sets the fields flags values.                                  | no   |
| GetFieldFlags(out cFlagHelp: WordBool; out cFlagEnabled: WordBool; out cFlagAutoText: WordBool; out cFlagNoXpress: WordBool; out cFlagAllowDecimal: WordBool);           | Returns the field's flags.                                     | no   |
| SetCellOrder(Value: Integer);                                                                                                                                            | Sets the cell order.                                           | no   |
| GetCellOrder: Integer;                                                                                                                                                   | Returns the cell order value.                                  | no   |
| GetPrintBkgnd: AppPrintBkgnd;                                                                                                                                            | Return the print background.                                   | no   |
| GetICell: LongWord;                                                                                                                                                      | Returns cell index.                                            | no   |
| SetAttach(AValue: WordBool);                                                                                                                                             | Set attach falg.                                               | no   |
| GetAttach: WordBool;                                                                                                                                                     | Gets attach flag.                                              | no   |
| SetOverriden(Value: WordBool);                                                                                                                                           | Sets override flag.                                            | no   |
| GetOverriden: WordBool;                                                                                                                                                  | Gets overide flag.                                             | no   |
| HasCCHHelpLink: WordBool;                                                                                                                                                | Return true if the help link is assigned.                      | no   |
| GetDiagFlag: WordBool;                                                                                                                                                   | Returns the value of diag flag.                                | no   |
| SetFDiagFlag(Value: WordBool);                                                                                                                                           | Sets the diag flag.                                            | no   |
| ApplyRepeatIndex(const RepeatPath: WideString; Index: LongWord);                                                                                                         | Apply the repeat path and index.                               | no   |
| GetFlagWidth: Integer;                                                                                                                                                   | Returns the value of flag width.                               | no   |
| GetRepeatNumber: LongWord;                                                                                                                                               | Returns repeat number.                                         | no   |
| GetBox: WideString;                                                                                                                                                      | Returns the box string value.                                  | no   |
| SetBox(const AValue: WideString);                                                                                                                                        | Sets the box string value.                                     | no   |
| GetReviewMarks(out rmFirst: WordBool; out rmSecond: WordBool; out rmError: WordBool; out rmEstimated: WordBool; out rmSourceEstimated: WordBool; out rmOther: WordBool); | Returns the review marks values.                               | no   |
| SetReviewMarks(rmFirst: WordBool; rmSecond: WordBool; rmError: WordBool; rmEstimated: WordBool; rmSourceEstimated: WordBool; rmOther: WordBool);                         | Sets the review marks values.                                  | no   |
| GetReviewMarkXOffset: Integer;                                                                                                                                           | Returns the position of review mark.                           | no   |
| GetDrawHighlightBorder: WordBool;                                                                                                                                        | Returns true if the highlight border will be drawn.            | no   |
| SetDrawHighlightBorder(AValue: WordBool);                                                                                                                                | Sets the Highlight border flag.                                | no   |
| HasJumpSource: WordBool;                                                                                                                                                 | Returns true if the field contains jump source assigned.       | no   |
| GetJumpSource: WideString;                                                                                                                                               | Returns the jump sources.                                      | no   |
| GetSourceFormName: WideString;                                                                                                                                           | Returns the source form name.                                  | no   |
| IsJumpSourceCond: WordBool;                                                                                                                                              | Retturn true if the field contains the jump source conditions. | no   |
| HasOverride: WordBool;                                                                                                                                                   | Returns true if the pointed cell has override.                 | no   |
| HasJumpTarget: WordBool;                                                                                                                                                 | Return JumpTargetFlag.                                         | no   |
| JumpTargetCount: Integer;                                                                                                                                                | Return the count of jump targets.                              | no   |
| GetJumpTarget(Index: Integer): WideString;                                                                                                                               | Returns the jump target names.                                 | no   |
| JumpTargetDifference(AIndex: Integer): AppJumpDifference;                                                                                                                | Returns the information about jump target.                     | no   |
| GetTargetFormName(Index: Integer): WideString;                                                                                                                           | Retuns the target form name for jump.                          | no   |
| GetSourceICell: LongWord;                                                                                                                                                | Returns the source cell index.                                 | no   |
| GetTargetICell(Index: Integer): LongWord;                                                                                                                                | Returns target cell index.                                     | no   |
| GetTargetCellPath(Index: Integer; const ATaxData: IAppTaxData): WideString;                                                                                              | Returns the target cell path.                                  | no   |
| IsJumpTargetCond(Index: Integer): WordBool;                                                                                                                              | Returns if the jump target has a condition.                    | no   |
| SetJumpTargetDifferenceFlags(const ATaxData: IAppTaxData; const ATaxCell: IAppTaxCell);                                                                                  | Set the jump target difference flags.                          | no   |
| GetHasAttachmentTargetExpand: WordBool;                                                                                                                                  | Returns field AttachmentTargetExpand flag value.               | no   |
| SetHasAttachmentTargetExpand(Value: WordBool);                                                                                                                           | Set the AttachmentTargetExpand flag value.                     | no   |
| GetDisplayText(DisplayFieldProp: AppDisplayFieldProp): WideString;                                                                                                       | Return the field display text.                                 | no   |
| SetCellTextForPrint(aPrintLanguage: AppLanguage; const aTaxData: IAppTaxData);                                                                                           | Sets the cell text fro print in some language.                 | no   |
  
### IAppResourceManager (local service) ###

  Provides acces to application resources.
 
| Method name                                                           | Description                                                 | Test |
| --------------------------------------------------------------------- | ----------------------------------------------------------- | ---- |
|  PathExists(const inPath: WideString): WordBool;                      |  Returns true if the mentioned path exists in the resources | yes |
|  GetString(const inPath: WideString): WideString;                     |  returns the resource value                                 | yes |
|  GetInt(const inPath: WideString): Integer;                           |  returns the resource value                                 | yes |
|  GetDec(const inPath: WideString): Double;                            |  returns the resource value                                 | yes |
|  GetBool(const inPath: WideString): WordBool;                         |  returns the resource value                                 | yes |
|  GetLines(const inPath: WideString; out aLines: WideString): Integer; |  returns the resource value                                 | yes |

  
### IAppAttachementManager (local service) ###

  Provides acces to attachements
 
|  Method name                                                     |  Description                              | Test |
| ---------------------------------------------------------------- | ----------------------------------------- | ---- |
|  CreateAttachment(const AInputFile: WideString): IAppAttachment; |  Cretes a new attachement                 | yes |
|  Count: Integer                                                  |  Return the count of existed attachements | yes |
|  Items[AIndex: Integer]: IAppAttachment                          |  Returns the existed attachement          | yes |

  
### IAppAttachment (local service) ###

  Existed or newly created attchement

| Method name                       |  Description                                       | Test |
| --------------------------------- | -------------------------------------------------- | ---- |
| GUID: WideString                  | Attachemnet guid                                   | yes  |
| FileName: WideString              | attchement file name                               | yes  |
| FullName: WideString              | Attchementa full name                              | yes  |
| OriginalPath                      | The file path where the attchement was loaded from | yes  |
| TimeStamp: Int64                  | File timestamp                                     | yes  |
| LastModified: TDateTime           |                                                    | yes  |
| Size: Integer read Get_Size write | The size in bytes                                  | yes  |
| ToRollForward: WordBool           | Will the file be rolled forward                    | yes  |
| IsRollForwarded: WordBool         | Has the file been rolled forward.                  | yes  |

  
### IAppAddinCustomDiagnostic (local service) ###

  Support of custom diagnostics

| Method name                                                                                                                                                                                                   | Description                                                                                                                            | Test |
| ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------- | ---- |
| RegisterAddinDiagnostic(AGroupNo: Integer; ADiagType: Integer; const AName: WideString; const AEnglishText: WideString; const AFrenchText: WideString; AJurisdiction: AppJuridiction; AApplicable: WordBool); |  Register a new custom diagnostic (shoud be run a part of add-in initialisation                                                        | yes  |
| UnRegisterAddinDiagnostic(AGroupNo: Integer; const AName: WideString);                                                                                                                                        |  UnRegister the previously registered custom diagnostic. Optionally, the diagnostic will be unregistered automatically on add-in unload| yes  |
| UnRegisterAllAddinDiagnostic;                                                                                                                                                                                 |  Unregister all of the custom diagnostic, the current add-in has installed                                                             | yes  |

  
### IAppDatabaseEnvEventsService (local service) ###

  Different events handler, which occurs when Taxprep calculates the tax return
 
| Method name                                                 |  Description                                                                                                             |  Test |
| ----------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------ | ----- |
| BeforeCalc                                                  |  Before the engine start the caluclation                                                                                 | yes   |
| AfterCalc: IAddinBeforeCalcHandler read Get_AfterCalc write |  After the engine complete the calcualation                                                                              | yes   |
| AfterCalcGlobalRates                                        |  after the global rates calculation completed                                                                            | yes   |
| AfterAcceptUserInput                                        |  After the use changes some cell                                                                                         | yes   |
| AfterAddRepeat                                              |  After the user adds the new return                                                                                      | yes   |
| AfterDeleteRepeat                                           |  After the user deletes some repeat                                                                                      | yes   |
| OnCalcAddinDiag                                             |  This the event the the add-in can add the previously registered custom diagnostic to the return.                        | yes   |
| OnDiagClick                                                 |  This this the event occured after the user clicks on the custom add-in diagnostic, which was added by the current add-in| yes   |

 