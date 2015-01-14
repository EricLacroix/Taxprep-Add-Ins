unit TaxprepAddinAPI_TLB;

// ************************************************************************ //
// WARNING                                                                    
// -------                                                                    
// The types declared in this file were generated from data read from a       
// Type Library. If this type library is explicitly or indirectly (via        
// another type library referring to this type library) re-imported, or the   
// 'Refresh' command of the Type Library Editor activated while editing the   
// Type Library, the contents of this file will be regenerated and all        
// manual modifications will be lost.                                         
// ************************************************************************ //

// PASTLWTR : 1.2
// File generated on 08.06.2015 13:17:17 from Type Library described below.

// ************************************************************************  //
// Type Lib: tlb_D7.tlb (1)
// LIBID: {09B9DB60-0079-40BC-9098-053F8AD2D4F7}
// LCID: 0
// Helpfile: D:\iSolution\EP\Tools\TaxprepAddinAPI\
// HelpString: Taxprep Add-in API
// DepndLst: 
//   (1) v2.0 stdole, (C:\Windows\SysWOW64\stdole2.tlb)
// ************************************************************************ //
// *************************************************************************//
// NOTE:                                                                      
// Items guarded by $IFDEF_LIVE_SERVER_AT_DESIGN_TIME are used by properties  
// which return objects that may need to be explicitly created via a function 
// call prior to any access via the property. These items have been disabled  
// in order to prevent accidental use from within the object inspector. You   
// may enable them by defining LIVE_SERVER_AT_DESIGN_TIME or by selectively   
// removing them from the $IFDEF blocks. However, such items must still be    
// programmatically created via a method of the appropriate CoClass before    
// they can be used.                                                          
{$TYPEDADDRESS OFF} // Unit must be compiled without type-checked pointers. 
{$WARN SYMBOL_PLATFORM OFF}
{$WRITEABLECONST ON}
{$VARPROPSETTER ON}
interface

uses Windows, ActiveX, Classes, Graphics, StdVCL, Variants;
  

// *********************************************************************//
// GUIDS declared in the TypeLibrary. Following prefixes are used:        
//   Type Libraries     : LIBID_xxxx                                      
//   CoClasses          : CLASS_xxxx                                      
//   DISPInterfaces     : DIID_xxxx                                       
//   Non-DISP interfaces: IID_xxxx                                        
// *********************************************************************//
const
  // TypeLibrary Major and minor versions
  TaxprepAddinAPIMajorVersion = 1;
  TaxprepAddinAPIMinorVersion = 0;

  LIBID_TaxprepAddinAPI: TGUID = '{09B9DB60-0079-40BC-9098-053F8AD2D4F7}';

  IID_IAppSubMenu: TGUID = '{2A3B6A0B-AF7B-4489-96FC-8602DFCE82E4}';
  IID_IAppMenuItem: TGUID = '{6A32BB5F-F7A1-4567-BA6A-EB4D2312ECD7}';
  IID_IAppInstance: TGUID = '{6AD23F05-7F69-4DE0-BBD7-545495B4AF0A}';
  IID_IAppInstance1: TGUID = '{76DB8FF8-E738-4645-B1C2-5DAC1DB8D914}';
  IID_IAppMenuService: TGUID = '{F687E318-DFCF-4020-94E8-87CE3DE6CB46}';
  IID_IAddinInstance: TGUID = '{89325E78-90D8-455C-B833-25713EA852AE}';
  IID_IAddinNotifyHandler: TGUID = '{081BE6E2-BBE7-4357-A6B7-3B0682F291A3}';
  IID_IAddinIdleHandler: TGUID = '{6BE71394-2491-4692-B0D5-8418867005ED}';
  IID_IAppClientFileEventsService: TGUID = '{35CFDDD9-BEBC-4FD5-ACB2-1BA160F94EBB}';
  IID_IAppClientFileEventsService1: TGUID = '{5502F8FD-3D55-4603-B360-933E706982A1}';
  IID_IAddinBeforeClientFileNameChangeHandler: TGUID = '{C3254A87-DD80-41B4-8F7F-D9FF1500E0E4}';
  IID_IAddinAfterClientFileNameChangeHandler: TGUID = '{7693DE0D-430B-4BE2-85CD-22106E73D859}';
  IID_IAddinBeforeClientFileSaveHandler: TGUID = '{5B3FFCD6-9A53-492B-9DE8-388D7F9E8168}';
  IID_IAddinAfterClientFileSaveHandler: TGUID = '{478263F0-29B8-42B0-ABA3-C041FE4399FB}';
  IID_IAddinAfterChangeClientFileHeaderPropertyHandler: TGUID = '{663F7885-98A6-4A73-A4B5-5624AC242679}';
  IID_IAppDatabaseEnvEventsService: TGUID = '{48C7EC3A-A373-4A4D-8C9C-72B69BCAE789}';
  IID_IAppDatabaseEnvEventsService1: TGUID = '{6C2AF1E3-B69D-4EBF-ABC0-BCCC18968376}';
  IID_IAppDocReturn: TGUID = '{21D5800E-BF91-4414-A3F0-80977FC8A229}';
  IID_IAppDocReturn1: TGUID = '{D8BFDBF3-AF24-4852-929C-DE1BAB5FF175}';
  IID_IAddinBeforeCalcHandler: TGUID = '{0D99071F-DC0D-49CB-9221-84EB9FF296F5}';
  IID_IAppTaxCell: TGUID = '{80914BA4-6D8C-4C34-9E6F-305808E8D3ED}';
  IID_IAppTaxData: TGUID = '{154AE7F5-39D7-4AEA-8E75-82A7BDA315CB}';
  IID_IAddinClientFileNotifyWithDocumentHandler: TGUID = '{E4C83EDD-F85F-4958-9375-3C75B6BC2C4B}';
  IID_IAddinBeforeCurrentDocumentChangeHandler: TGUID = '{BE2F809C-4BFF-479B-8A19-C4C401CF1D60}';
  IID_IAppGroupArray: TGUID = '{81C79AFD-4162-45F4-BD69-3C479D63D036}';
  IID_IAppGroupInfo: TGUID = '{FE33CF79-4395-45A0-A5BD-B3D759653985}';
  IID_IAppTaxApplicationService: TGUID = '{464F2B17-0089-4E12-99E4-DC0F11AA6EA9}';
  IID_IAppTaxApplicationService1: TGUID = '{6CE793BD-4D79-4671-91F2-44DB3B4172FA}';
  IID_IAppClientFileManagerService: TGUID = '{4CC93007-AE1B-4419-AB3F-485D8F9A5910}';
  IID_IAppClientFile: TGUID = '{8CDECC10-42B1-46EF-8DA2-1E1CC2F5D4E9}';
  IID_IAddinDatabaseEnvAfterAcceptUserInput: TGUID = '{6076C17E-890F-4A91-9766-5D07E234A58B}';
  IID_IAddinDatabaseEnvNotifyWithGroupArray: TGUID = '{B9F741E2-F98E-49D7-851F-4A675BC91198}';
  IID_IAppTaxDocument: TGUID = '{D8287F8A-E546-498F-BC21-61E4276B944D}';
  IID_IAppField: TGUID = '{A0C11735-EE63-47AE-86BE-851ADDD48173}';
  IID_IAppCellSelectionIter: TGUID = '{D9AA2AB4-E5AA-480E-915A-933E522BDD1F}';
  IID_IAppDragDropService: TGUID = '{E67EF30C-8378-4F5A-8ECB-B5259CC8FBE1}';
  IID_IAddinDragDropDataFormatHandler: TGUID = '{F439D7F9-4BCE-410F-8FBA-21BA3B6CE547}';
  IID_IAppTaxReturn: TGUID = '{8F490032-CB2E-4E7D-A49D-159ACFCB65D4}';
  IID_IAppStatusProperties: TGUID = '{CAD060D8-1FB9-4E37-8DB3-53D0D46853AB}';
  IID_IAddinReturnStatusChange: TGUID = '{766BF3C1-5AAB-4305-A97D-EE1984C966B2}';
  IID_IAppTesting: TGUID = '{23C4821E-D915-47C7-B3DB-199148732FD2}';
  IID_IAppProperties: TGUID = '{9173D8A0-4B69-4C43-BAB5-5798E5261397}';
  IID_IAppConfiguration: TGUID = '{1833C577-EC89-41FC-80AB-97218384A665}';
  IID_IAppModule: TGUID = '{03F03F94-E11C-4B9C-A243-8175F52B55FD}';
  IID_IAppModuleManager: TGUID = '{46AE6773-C3E9-42A9-BE81-65945BDA3542}';
  IID_IAddinModuleManagerNotifyHandler: TGUID = '{F13AAF92-7939-45E2-B0F5-EEEE3482B14A}';
  IID_IAddinConfigurationAddRemoveKeyHandler: TGUID = '{242DEC8C-09A4-4CF0-AE70-5B3DB8789185}';
  IID_IAddinConfigurationKeyModifiedHandler: TGUID = '{D80C9A01-7A96-4EC1-8BE5-38F84CD2753C}';
  IID_IAppConfigurationSecureLevel: TGUID = '{9AF8258F-187E-4FEC-ADE9-FA8D1E3F0C86}';
  IID_IAddinConfigurationAddRemoveSectionHandler: TGUID = '{2ABF7D9B-F4B2-4334-B22E-19B4AD3A18F1}';
  IID_IAppDiagnostic: TGUID = '{A5361C8C-8E84-41E4-967E-7082A7B75AB6}';
  IID_IAppDiagNode: TGUID = '{8DD46145-92E3-4114-9FA3-E612539DECF2}';
  IID_IAppUFL: TGUID = '{A11BEDA3-C389-4EC9-8308-2146290C4443}';
  IID_IAppUFLNode: TGUID = '{E96FF84D-EED4-4C1C-91F4-2EC17587094E}';
  IID_IAppClientLetterManager: TGUID = '{045A0C8C-8FDD-44CA-BB32-6F40A01EC75E}';
  IID_IAppClientLetter: TGUID = '{B06588FD-0281-45AF-B6EA-553CDF598EF8}';
  IID_IAppPredefinedService: TGUID = '{5FCED777-B5B6-47A9-96E9-39075A88655A}';
  IID_IAppPredefinedService1: TGUID = '{68625051-2AB6-4FE5-8924-39573B40FF42}';
  IID_IAddinGetAdvertisingDataHandler: TGUID = '{A73F2F8A-4C5A-4304-8FC1-DA81BBFCF25B}';
  IID_IAppVersionInfo: TGUID = '{743D154A-3FE5-4A81-8BC7-AE38458477D6}';
  IID_IAddinClientFileEventHandler: TGUID = '{A4F01315-9040-445A-9C57-4FFA98A52F58}';
  IID_IAddinClientFileChangeEventHandler: TGUID = '{0D26D53E-91BC-4EFD-8F2A-28F97226E600}';
  IID_IAddinCanCloseEventHandler: TGUID = '{92EB012B-F19E-41F8-A693-2ABEA6739FD6}';
  IID_IAppAdvertisingButton: TGUID = '{EC530290-1CDC-4EF3-8288-546CFA50666C}';
  IID_IAddinDocReturnNotifyHandler: TGUID = '{6E413B81-DF08-448A-BBC8-74F0667BCEF1}';
  IID_IAppResourceManager: TGUID = '{706B34A3-F621-4401-8078-17CA86FD6648}';
  IID_IAppAttachementManager: TGUID = '{638BF30E-9B38-42FD-A969-8355C0699A61}';
  IID_IAppAttachment: TGUID = '{ECE8DE52-EA2B-44A1-9815-56F59E867FF3}';
  IID_IAddinDocReturnHandler: TGUID = '{7750B091-3C0C-45F2-BDE2-D93E4E3D2CBE}';
  IID_IAddinDocReturnChangeHandler: TGUID = '{9A0C7B01-FC01-4225-97D8-6093E2E4CDF0}';
  IID_IAddinCalcDiagnosticHandler: TGUID = '{80785E13-C93D-41BD-8759-7679E29693BE}';
  IID_IAddinDiagnosticClickHandler: TGUID = '{44087D3A-E50D-4D91-A795-84543820C568}';
  IID_IAppAddinCustomDiagnostic: TGUID = '{C64F2E0E-FA6A-4CA9-97FB-1DC933F8A1D0}';

// *********************************************************************//
// Declaration of Enumerations defined in Type Library                    
// *********************************************************************//
// Constants for enum AppDocType
type
  AppDocType = TOleEnum;
const
  DT_UNKNOWN = $00000000;
  DT_CURRENTYEAR = $00000001;
  DT_LASTYEAR = $00000002;
  DT_PLANNING = $00000003;
  DT_SCENARIO = $00000004;

// Constants for enum AppAskOption
type
  AppAskOption = TOleEnum;
const
  optAskReadOnly = $00000000;
  optAskPassword = $00000001;
  optAskSilent = $00000002;

// Constants for enum AppLanguage
type
  AppLanguage = TOleEnum;
const
  lEnglish = $00000000;
  lFrench = $00000001;

// Constants for enum AppOpenResult
type
  AppOpenResult = TOleEnum;
const
  CF_OPENRESULT_SUCCESS = $00000000;
  CF_OPENRESULT_SYSTEMLOCKED = $00000001;
  CF_OPENRESULT_SYSTEMREADONLY = $00000002;
  CF_OPENRESULT_PASSWORD_FAILED = $00000003;
  CF_OPENRESULT_INVALID_COMPOUND = $00000004;
  CF_OPENRESULT_HANDLE_FAILED = $00000005;
  CF_OPENRESULT_INVALID_FILENAME = $00000006;
  CF_OPENRESULT_INVALID_DOCUMENT = $00000007;
  CF_OPENRESULT_UNKNOWN = $00000008;
  CF_OPENRESULT_ACCESS_DENIED = $00000009;
  CF_OPENRESULT_INVALID_DATABASE = $0000000A;
  CF_OPENRESULT_OLDERSOFTWAREVERSION = $0000000B;
  CF_OPENRESULT_SYSTEMLOCK_FILEMANAGER = $0000000C;
  CF_OPENRESULT_OLDER_DOC_MAJOR_VERSION = $0000000D;
  CF_OPENRESULT_NEWER_DATABASE_TEMPLATE = $0000000E;
  CF_OPENRESULT_LOCKED = $0000000F;
  CF_OPENRESULT_INVALID_PERIOD = $00000010;
  CF_OPENRESULT_CANCELLED = $00000011;
  CF_OPENRESULT_DISK_FULL = $00000012;
  CF_OPENRESULT_SAVETIMESTAMP_CHANGED = $00000013;

// Constants for enum AppSaveResult
type
  AppSaveResult = TOleEnum;
const
  CF_SAVERESULT_SUCCESS = $00000000;
  CF_SAVERESULT_SYSTEMLOCKED = $00000001;
  CF_SAVERESULT_OPENINTAXRETURN = $00000002;
  CF_SAVERESULT_DATALOCKED = $00000003;
  CF_SAVERESULT_PASSWORDFAILED = $00000004;
  CF_SAVERESULT_FAILURE = $00000005;
  CF_SAVERESULT_ACCESSDENIED = $00000006;
  CF_SAVERESULT_SYSTEMREADONLY = $00000007;
  CF_SAVERESULT_INVALIDFILENAME = $00000008;
  CF_SAVERESULT_OLDERSOFTWAREVERSION = $00000009;
  CF_SAVERESULT_OLDER_DOC_MAJOR_VERSION = $0000000A;
  CF_SAVERESULT_DISK_FULL = $0000000B;

// Constants for enum AppGraphicID
type
  AppGraphicID = TOleEnum;
const
  ID_Group = $00000000;
  ID_ShortTextOut = $00000001;
  ID_Line = $00000002;
  ID_Rectangle = $00000003;
  ID_FillRect = $00000004;
  ID_Bitmap = $00000005;
  ID_Ellipse = $00000006;
  ID_Polygon = $00000007;
  ID_RoundRect = $00000008;
  ID_DrawText = $00000009;
  ID_TextFld = $0000000A;
  ID_ComboFld = $0000000B;
  ID_CalendFld = $0000000C;
  ID_CheckFld = $0000000D;
  ID_RadioFld = $0000000E;
  ID_MemoFld = $0000000F;
  ID_TextOut = $00000010;
  ID_PageBreak = $00000011;
  ID_HorzBrowse = $00000012;
  ID_HorzRepeat = $00000013;
  ID_TextAlign = $00000014;
  ID_MoveTo = $00000015;
  ID_MoveY = $00000016;
  ID_MoveRight = $00000017;
  ID_BrowseToolBar = $00000018;
  ID_DescFld = $00000019;
  ID_LinkCombo = $0000001A;
  ID_BarCode = $0000001B;
  ID_GifiNotesFld = $0000001C;
  ID_ButtonCtl = $0000001D;
  ID_AdvancedCombo = $0000001E;
  ID_CustomFooter = $0000001F;
  ID_2DBarCode = $00000020;

// Constants for enum AppPrintBkgnd
type
  AppPrintBkgnd = TOleEnum;
const
  pbNormal = $00000000;
  pbGray10 = $00000001;

// Constants for enum AppJumpDifference
type
  AppJumpDifference = TOleEnum;
const
  jdUndefined = $00000000;
  jdEqual = $00000001;
  jdNotEqual = $00000002;

// Constants for enum AppDisplayFieldProp
type
  AppDisplayFieldProp = TOleEnum;
const
  dfpText = $00000000;
  dfpPath = $00000001;
  dfpICell = $00000002;

// Constants for enum AppUpdatingMenuLevel
type
  AppUpdatingMenuLevel = TOleEnum;
const
  umFieldModify = $00000000;
  umFieldMove = $00000001;
  umFormChange = $00000002;
  umFormEngine = $00000003;

// Constants for enum AppReviewModeMark
type
  AppReviewModeMark = TOleEnum;
const
  rvRevModeFirst = $00000001;
  rvRevModeSecond = $00000002;
  rvRevModeError = $00000003;
  rvRevModeEstimate = $00000004;
  rvRevModeOther = $00000005;

// Constants for enum AppConfigurationLevelType
type
  AppConfigurationLevelType = TOleEnum;
const
  ltUserConfiguration = $00000000;
  ltApplicationSystem = $00000001;

// Constants for enum AppConfigurationSecurityModeManager
type
  AppConfigurationSecurityModeManager = TOleEnum;
const
  sUser = $00000000;
  sUserNoUI = $00000001;
  sUserForceUI = $00000002;
  sNetwork = $00000003;
  sSystem = $00000004;
  sLocal = $00000005;

// Constants for enum AppPopupMessageType
type
  AppPopupMessageType = TOleEnum;
const
  popNone = $00000000;
  popNotify = $00000001;
  popQuery = $00000002;

// Constants for enum AppJuridiction
type
  AppJuridiction = TOleEnum;
const
  Const1 = $00000000;
  lOntario = $00000001;
  lQuebec = $00000002;
  lBritishColumbia = $00000003;
  lAlberta = $00000004;
  lNovaScotia = $00000005;
  lManitoba = $00000006;
  lSaskatchewan = $00000007;
  lNewBrunswick = $00000008;
  lNewFoundland = $00000009;
  PrinceEdwardIsland = $0000000A;
  YukonTerritory = $0000000B;
  NorthwestTerritories = $0000000C;
  Nunavut = $0000000D;
  InvalidJuris = $0000000E;

type

// *********************************************************************//
// Forward declaration of types defined in TypeLibrary                    
// *********************************************************************//
  IAppSubMenu = interface;
  IAppMenuItem = interface;
  IAppInstance = interface;
  IAppInstance1 = interface;
  IAppMenuService = interface;
  IAddinInstance = interface;
  IAddinNotifyHandler = interface;
  IAddinIdleHandler = interface;
  IAppClientFileEventsService = interface;
  IAppClientFileEventsService1 = interface;
  IAddinBeforeClientFileNameChangeHandler = interface;
  IAddinAfterClientFileNameChangeHandler = interface;
  IAddinBeforeClientFileSaveHandler = interface;
  IAddinAfterClientFileSaveHandler = interface;
  IAddinAfterChangeClientFileHeaderPropertyHandler = interface;
  IAppDatabaseEnvEventsService = interface;
  IAppDatabaseEnvEventsService1 = interface;
  IAppDocReturn = interface;
  IAppDocReturn1 = interface;
  IAddinBeforeCalcHandler = interface;
  IAppTaxCell = interface;
  IAppTaxData = interface;
  IAddinClientFileNotifyWithDocumentHandler = interface;
  IAddinBeforeCurrentDocumentChangeHandler = interface;
  IAppGroupArray = interface;
  IAppGroupInfo = interface;
  IAppTaxApplicationService = interface;
  IAppTaxApplicationService1 = interface;
  IAppClientFileManagerService = interface;
  IAppClientFile = interface;
  IAddinDatabaseEnvAfterAcceptUserInput = interface;
  IAddinDatabaseEnvNotifyWithGroupArray = interface;
  IAppTaxDocument = interface;
  IAppField = interface;
  IAppCellSelectionIter = interface;
  IAppDragDropService = interface;
  IAddinDragDropDataFormatHandler = interface;
  IAppTaxReturn = interface;
  IAppStatusProperties = interface;
  IAddinReturnStatusChange = interface;
  IAppTesting = interface;
  IAppProperties = interface;
  IAppConfiguration = interface;
  IAppModule = interface;
  IAppModuleManager = interface;
  IAddinModuleManagerNotifyHandler = interface;
  IAddinConfigurationAddRemoveKeyHandler = interface;
  IAddinConfigurationKeyModifiedHandler = interface;
  IAppConfigurationSecureLevel = interface;
  IAddinConfigurationAddRemoveSectionHandler = interface;
  IAppDiagnostic = interface;
  IAppDiagNode = interface;
  IAppUFL = interface;
  IAppUFLNode = interface;
  IAppClientLetterManager = interface;
  IAppClientLetter = interface;
  IAppPredefinedService = interface;
  IAppPredefinedService1 = interface;
  IAddinGetAdvertisingDataHandler = interface;
  IAppVersionInfo = interface;
  IAddinClientFileEventHandler = interface;
  IAddinClientFileChangeEventHandler = interface;
  IAddinCanCloseEventHandler = interface;
  IAppAdvertisingButton = interface;
  IAddinDocReturnNotifyHandler = interface;
  IAppResourceManager = interface;
  IAppAttachementManager = interface;
  IAppAttachment = interface;
  IAddinDocReturnHandler = interface;
  IAddinDocReturnChangeHandler = interface;
  IAddinCalcDiagnosticHandler = interface;
  IAddinDiagnosticClickHandler = interface;
  IAppAddinCustomDiagnostic = interface;

// *********************************************************************//
// Declaration of structures, unions and aliases.                         
// *********************************************************************//
  AppClientFileOpenOptions = packed record
    optWithClientFileManager: WordBool;
    optOpenNoPasswordGUI_Open: WordBool;
    optOpenNoPasswordGUI_Fail: WordBool;
    optOpenNoAskReadOnly: WordBool;
    optOpenDocumentAlreadyLoaded: WordBool;
    optOpenClientFileHeaderOnly: WordBool;
    optOpenDocumentHeaderOnly: WordBool;
    optOpenDatabaseOnly: WordBool;
    optOpenOnlyReadOnly: WordBool;
    optOpenOnlyReadWrite: WordBool;
    optOpenCurrentYearOnly: WordBool;
    optOpenNoDiagnostics: WordBool;
    optOpenReturnIdListOnly: WordBool;
    optOpenNoClientFileHeader: WordBool;
    optOpenCheckCalcVersions: WordBool;
    optOpenRecalcForDLL: WordBool;
    optOpenReadOnlyForDll: WordBool;
    optOpenRecalcForProfile: WordBool;
    optOpenReadOnlyForProfile: WordBool;
    optOpenRecalcForRates: WordBool;
    optOpenReadOnlyForRates: WordBool;
    OptOpenBatch: WordBool;
    optOpenNoMRU: WordBool;
    optOpenPlanner: WordBool;
    optOpenClientFile: WordBool;
    optSetPlanner: WordBool;
    optPlannerDefaultFilter: WordBool;
    optOpenEPOnly: WordBool;
    optOpenNoCreateEPFile: WordBool;
    optCanRecalcAlways: WordBool;
    optCheckFiscalPeriod: WordBool;
    optOpenNoUpdateVersion: WordBool;
  end;


// *********************************************************************//
// Interface: IAppSubMenu
// Flags:     (0)
// GUID:      {2A3B6A0B-AF7B-4489-96FC-8602DFCE82E4}
// *********************************************************************//
  IAppSubMenu = interface(IUnknown)
    ['{2A3B6A0B-AF7B-4489-96FC-8602DFCE82E4}']
    function Get_Caption: WideString; safecall;
    procedure Set_Caption(const Value: WideString); safecall;
    function Get_Visible: WordBool; safecall;
    procedure Set_Visible(Value: WordBool); safecall;
    function Get_Enabled: WordBool; safecall;
    procedure Set_Enabled(Value: WordBool); safecall;
    function Get_PopupHandler: IAddinNotifyHandler; safecall;
    procedure Set_PopupHandler(const Value: IAddinNotifyHandler); safecall;
    function Get_Count: Integer; safecall;
    function Get_Items(AIndex: Integer): IUnknown; safecall;
    function AddSubMenu(const ACaption: WideString; ASeparatorBefore: WordBool): IAppSubMenu; safecall;
    function AddItem(const ACaption: WideString; ASeparatorBefore: WordBool): IAppMenuItem; safecall;
    property Caption: WideString read Get_Caption write Set_Caption;
    property Visible: WordBool read Get_Visible write Set_Visible;
    property Enabled: WordBool read Get_Enabled write Set_Enabled;
    property PopupHandler: IAddinNotifyHandler read Get_PopupHandler write Set_PopupHandler;
    property Count: Integer read Get_Count;
    property Items[AIndex: Integer]: IUnknown read Get_Items;
  end;

// *********************************************************************//
// Interface: IAppMenuItem
// Flags:     (0)
// GUID:      {6A32BB5F-F7A1-4567-BA6A-EB4D2312ECD7}
// *********************************************************************//
  IAppMenuItem = interface(IUnknown)
    ['{6A32BB5F-F7A1-4567-BA6A-EB4D2312ECD7}']
    function Get_Caption: WideString; safecall;
    procedure Set_Caption(const Value: WideString); safecall;
    function Get_Visible: WordBool; safecall;
    procedure Set_Visible(Value: WordBool); safecall;
    function Get_Enabled: WordBool; safecall;
    procedure Set_Enabled(Value: WordBool); safecall;
    function Get_ClickHandler: IAddinNotifyHandler; safecall;
    procedure Set_ClickHandler(const Value: IAddinNotifyHandler); safecall;
    property Caption: WideString read Get_Caption write Set_Caption;
    property Visible: WordBool read Get_Visible write Set_Visible;
    property Enabled: WordBool read Get_Enabled write Set_Enabled;
    property ClickHandler: IAddinNotifyHandler read Get_ClickHandler write Set_ClickHandler;
  end;

// *********************************************************************//
// Interface: IAppInstance
// Flags:     (0)
// GUID:      {6AD23F05-7F69-4DE0-BBD7-545495B4AF0A}
// *********************************************************************//
  IAppInstance = interface(IUnknown)
    ['{6AD23F05-7F69-4DE0-BBD7-545495B4AF0A}']
    function Get_AppKey: TGUID; safecall;
    function Get_AppName: WideString; safecall;
    function Get_AppVersion: WideString; safecall;
    procedure AddLog(const AMessage: WideString); safecall;
    property AppKey: TGUID read Get_AppKey;
    property AppName: WideString read Get_AppName;
    property AppVersion: WideString read Get_AppVersion;
  end;

// *********************************************************************//
// Interface: IAppInstance1
// Flags:     (0)
// GUID:      {76DB8FF8-E738-4645-B1C2-5DAC1DB8D914}
// *********************************************************************//
  IAppInstance1 = interface(IAppInstance)
    ['{76DB8FF8-E738-4645-B1C2-5DAC1DB8D914}']
    procedure InstallCustomAddinFPUSettings(FpuCW: Integer); safecall;
  end;

// *********************************************************************//
// Interface: IAppMenuService
// Flags:     (0)
// GUID:      {F687E318-DFCF-4020-94E8-87CE3DE6CB46}
// *********************************************************************//
  IAppMenuService = interface(IUnknown)
    ['{F687E318-DFCF-4020-94E8-87CE3DE6CB46}']
    function AddRootMenu(const Caption: WideString): IAppSubMenu; safecall;
  end;

// *********************************************************************//
// Interface: IAddinInstance
// Flags:     (0)
// GUID:      {89325E78-90D8-455C-B833-25713EA852AE}
// *********************************************************************//
  IAddinInstance = interface(IUnknown)
    ['{89325E78-90D8-455C-B833-25713EA852AE}']
    function Get_Key: TGUID; safecall;
    function Get_Name: WideString; safecall;
    function Get_Version: WideString; safecall;
    procedure ReleaseApp; safecall;
    procedure Initialize(const aAppInstance: IAppInstance); safecall;
    property Key: TGUID read Get_Key;
    property Name: WideString read Get_Name;
    property Version: WideString read Get_Version;
  end;

// *********************************************************************//
// Interface: IAddinNotifyHandler
// Flags:     (0)
// GUID:      {081BE6E2-BBE7-4357-A6B7-3B0682F291A3}
// *********************************************************************//
  IAddinNotifyHandler = interface(IUnknown)
    ['{081BE6E2-BBE7-4357-A6B7-3B0682F291A3}']
    procedure Execute; safecall;
  end;

// *********************************************************************//
// Interface: IAddinIdleHandler
// Flags:     (0)
// GUID:      {6BE71394-2491-4692-B0D5-8418867005ED}
// *********************************************************************//
  IAddinIdleHandler = interface(IUnknown)
    ['{6BE71394-2491-4692-B0D5-8418867005ED}']
    procedure Execute(out AProcessed: WordBool); safecall;
  end;

// *********************************************************************//
// Interface: IAppClientFileEventsService
// Flags:     (0)
// GUID:      {35CFDDD9-BEBC-4FD5-ACB2-1BA160F94EBB}
// *********************************************************************//
  IAppClientFileEventsService = interface(IUnknown)
    ['{35CFDDD9-BEBC-4FD5-ACB2-1BA160F94EBB}']
    function Get_BeforeClientFileNameChange: IAddinBeforeClientFileNameChangeHandler; safecall;
    procedure Set_BeforeClientFileNameChange(const Value: IAddinBeforeClientFileNameChangeHandler); safecall;
    function Get_AfterClientFileNameChange: IAddinAfterClientFileNameChangeHandler; safecall;
    procedure Set_AfterClientFileNameChange(const Value: IAddinAfterClientFileNameChangeHandler); safecall;
    function Get_BeforeClientFileSave: IAddinBeforeClientFileSaveHandler; safecall;
    procedure Set_BeforeClientFileSave(const Value: IAddinBeforeClientFileSaveHandler); safecall;
    function Get_AfterClientFileSave: IAddinAfterClientFileSaveHandler; safecall;
    procedure Set_AfterClientFileSave(const Value: IAddinAfterClientFileSaveHandler); safecall;
    function Get_AfterChangeClientFileHeaderProperty: IAddinAfterChangeClientFileHeaderPropertyHandler; safecall;
    procedure Set_AfterChangeClientFileHeaderProperty(const Value: IAddinAfterChangeClientFileHeaderPropertyHandler); safecall;
    function Get_BeforeDocumentAdd: IAddinClientFileNotifyWithDocumentHandler; safecall;
    procedure Set_BeforeDocumentAdd(const Value: IAddinClientFileNotifyWithDocumentHandler); safecall;
    function Get_AfterDocumentAdd: IAddinClientFileNotifyWithDocumentHandler; safecall;
    procedure Set_AfterDocumentAdd(const Value: IAddinClientFileNotifyWithDocumentHandler); safecall;
    function Get_BeforeDocumentRemove: IAddinClientFileNotifyWithDocumentHandler; safecall;
    procedure Set_BeforeDocumentRemove(const Value: IAddinClientFileNotifyWithDocumentHandler); safecall;
    function Get_AfterDocumentRemove: IAddinClientFileNotifyWithDocumentHandler; safecall;
    procedure Set_AfterDocumentRemove(const Value: IAddinClientFileNotifyWithDocumentHandler); safecall;
    function Get_BeforeCurrentDocumentChange: IAddinBeforeCurrentDocumentChangeHandler; safecall;
    procedure Set_BeforeCurrentDocumentChange(const Value: IAddinBeforeCurrentDocumentChangeHandler); safecall;
    function Get_AfterCurrentDocumentChange: IAddinClientFileNotifyWithDocumentHandler; safecall;
    procedure Set_AfterCurrentDocumentChange(const Value: IAddinClientFileNotifyWithDocumentHandler); safecall;
    function Get_BeforeReturnStatusChange: IAddinReturnStatusChange; safecall;
    procedure Set_BeforeReturnStatusChange(const Value: IAddinReturnStatusChange); safecall;
    function Get_BeforeCurrentClientFileChange: IAddinClientFileChangeEventHandler; safecall;
    procedure Set_BeforeCurrentClientFileChange(const Value: IAddinClientFileChangeEventHandler); safecall;
    function Get_AfterCurrentClientFileChange: IAddinClientFileEventHandler; safecall;
    procedure Set_AfterCurrentClientFileChange(const Value: IAddinClientFileEventHandler); safecall;
    function Get_BeforeClientFileAdd: IAddinClientFileEventHandler; safecall;
    procedure Set_BeforeClientFileAdd(const Value: IAddinClientFileEventHandler); safecall;
    function Get_AfterClientFileAdd: IAddinClientFileEventHandler; safecall;
    procedure Set_AfterClientFileAdd(const Value: IAddinClientFileEventHandler); safecall;
    function Get_BeforeClientFileRemove: IAddinClientFileEventHandler; safecall;
    procedure Set_BeforeClientFileRemove(const Value: IAddinClientFileEventHandler); safecall;
    function Get_AfterClientFileRemove: IAddinClientFileEventHandler; safecall;
    procedure Set_AfterClientFileRemove(const Value: IAddinClientFileEventHandler); safecall;
    function Get_CanCloseClientFile: IAddinCanCloseEventHandler; safecall;
    procedure Set_CanCloseClientFile(const Value: IAddinCanCloseEventHandler); safecall;
    function Get_OnCheckHeaderAlias: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnCheckHeaderAlias(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnUpdateReturnHeader: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnUpdateReturnHeader(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnSaveReturnHeader: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnSaveReturnHeader(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnUpdateDatabaseFromReturnHeader: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnUpdateDatabaseFromReturnHeader(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnBeforeOpenClientFile: IAddinClientFileEventHandler; safecall;
    procedure Set_OnBeforeOpenClientFile(const Value: IAddinClientFileEventHandler); safecall;
    property BeforeClientFileNameChange: IAddinBeforeClientFileNameChangeHandler read Get_BeforeClientFileNameChange write Set_BeforeClientFileNameChange;
    property AfterClientFileNameChange: IAddinAfterClientFileNameChangeHandler read Get_AfterClientFileNameChange write Set_AfterClientFileNameChange;
    property BeforeClientFileSave: IAddinBeforeClientFileSaveHandler read Get_BeforeClientFileSave write Set_BeforeClientFileSave;
    property AfterClientFileSave: IAddinAfterClientFileSaveHandler read Get_AfterClientFileSave write Set_AfterClientFileSave;
    property AfterChangeClientFileHeaderProperty: IAddinAfterChangeClientFileHeaderPropertyHandler read Get_AfterChangeClientFileHeaderProperty write Set_AfterChangeClientFileHeaderProperty;
    property BeforeDocumentAdd: IAddinClientFileNotifyWithDocumentHandler read Get_BeforeDocumentAdd write Set_BeforeDocumentAdd;
    property AfterDocumentAdd: IAddinClientFileNotifyWithDocumentHandler read Get_AfterDocumentAdd write Set_AfterDocumentAdd;
    property BeforeDocumentRemove: IAddinClientFileNotifyWithDocumentHandler read Get_BeforeDocumentRemove write Set_BeforeDocumentRemove;
    property AfterDocumentRemove: IAddinClientFileNotifyWithDocumentHandler read Get_AfterDocumentRemove write Set_AfterDocumentRemove;
    property BeforeCurrentDocumentChange: IAddinBeforeCurrentDocumentChangeHandler read Get_BeforeCurrentDocumentChange write Set_BeforeCurrentDocumentChange;
    property AfterCurrentDocumentChange: IAddinClientFileNotifyWithDocumentHandler read Get_AfterCurrentDocumentChange write Set_AfterCurrentDocumentChange;
    property BeforeReturnStatusChange: IAddinReturnStatusChange read Get_BeforeReturnStatusChange write Set_BeforeReturnStatusChange;
    property BeforeCurrentClientFileChange: IAddinClientFileChangeEventHandler read Get_BeforeCurrentClientFileChange write Set_BeforeCurrentClientFileChange;
    property AfterCurrentClientFileChange: IAddinClientFileEventHandler read Get_AfterCurrentClientFileChange write Set_AfterCurrentClientFileChange;
    property BeforeClientFileAdd: IAddinClientFileEventHandler read Get_BeforeClientFileAdd write Set_BeforeClientFileAdd;
    property AfterClientFileAdd: IAddinClientFileEventHandler read Get_AfterClientFileAdd write Set_AfterClientFileAdd;
    property BeforeClientFileRemove: IAddinClientFileEventHandler read Get_BeforeClientFileRemove write Set_BeforeClientFileRemove;
    property AfterClientFileRemove: IAddinClientFileEventHandler read Get_AfterClientFileRemove write Set_AfterClientFileRemove;
    property CanCloseClientFile: IAddinCanCloseEventHandler read Get_CanCloseClientFile write Set_CanCloseClientFile;
    property OnCheckHeaderAlias: IAddinDocReturnNotifyHandler read Get_OnCheckHeaderAlias write Set_OnCheckHeaderAlias;
    property OnUpdateReturnHeader: IAddinDocReturnNotifyHandler read Get_OnUpdateReturnHeader write Set_OnUpdateReturnHeader;
    property OnSaveReturnHeader: IAddinDocReturnNotifyHandler read Get_OnSaveReturnHeader write Set_OnSaveReturnHeader;
    property OnUpdateDatabaseFromReturnHeader: IAddinDocReturnNotifyHandler read Get_OnUpdateDatabaseFromReturnHeader write Set_OnUpdateDatabaseFromReturnHeader;
    property OnBeforeOpenClientFile: IAddinClientFileEventHandler read Get_OnBeforeOpenClientFile write Set_OnBeforeOpenClientFile;
  end;

// *********************************************************************//
// Interface: IAppClientFileEventsService1
// Flags:     (0)
// GUID:      {5502F8FD-3D55-4603-B360-933E706982A1}
// *********************************************************************//
  IAppClientFileEventsService1 = interface(IAppClientFileEventsService)
    ['{5502F8FD-3D55-4603-B360-933E706982A1}']
    function Get_OnBeforeReturnAdd: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnBeforeReturnAdd(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnAfterReturnAdd: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnAfterReturnAdd(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnBeforeReturnRemove: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnBeforeReturnRemove(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnAfterReturnRemove: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnAfterReturnRemove(const Value: IAddinDocReturnNotifyHandler); safecall;
    function Get_OnBeforeCurrentReturnChange: IAddinDocReturnChangeHandler; safecall;
    procedure Set_OnBeforeCurrentReturnChange(const Value: IAddinDocReturnChangeHandler); safecall;
    function Get_OnAfterCurrentReturnChange: IAddinDocReturnNotifyHandler; safecall;
    procedure Set_OnAfterCurrentReturnChange(const Value: IAddinDocReturnNotifyHandler); safecall;
    property OnBeforeReturnAdd: IAddinDocReturnNotifyHandler read Get_OnBeforeReturnAdd write Set_OnBeforeReturnAdd;
    property OnAfterReturnAdd: IAddinDocReturnNotifyHandler read Get_OnAfterReturnAdd write Set_OnAfterReturnAdd;
    property OnBeforeReturnRemove: IAddinDocReturnNotifyHandler read Get_OnBeforeReturnRemove write Set_OnBeforeReturnRemove;
    property OnAfterReturnRemove: IAddinDocReturnNotifyHandler read Get_OnAfterReturnRemove write Set_OnAfterReturnRemove;
    property OnBeforeCurrentReturnChange: IAddinDocReturnChangeHandler read Get_OnBeforeCurrentReturnChange write Set_OnBeforeCurrentReturnChange;
    property OnAfterCurrentReturnChange: IAddinDocReturnNotifyHandler read Get_OnAfterCurrentReturnChange write Set_OnAfterCurrentReturnChange;
  end;

// *********************************************************************//
// Interface: IAddinBeforeClientFileNameChangeHandler
// Flags:     (0)
// GUID:      {C3254A87-DD80-41B4-8F7F-D9FF1500E0E4}
// *********************************************************************//
  IAddinBeforeClientFileNameChangeHandler = interface(IUnknown)
    ['{C3254A87-DD80-41B4-8F7F-D9FF1500E0E4}']
    procedure Execute(const AOldFilename: WideString; const ANewFileName: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAddinAfterClientFileNameChangeHandler
// Flags:     (0)
// GUID:      {7693DE0D-430B-4BE2-85CD-22106E73D859}
// *********************************************************************//
  IAddinAfterClientFileNameChangeHandler = interface(IUnknown)
    ['{7693DE0D-430B-4BE2-85CD-22106E73D859}']
    procedure Execute(const AFileName: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAddinBeforeClientFileSaveHandler
// Flags:     (0)
// GUID:      {5B3FFCD6-9A53-492B-9DE8-388D7F9E8168}
// *********************************************************************//
  IAddinBeforeClientFileSaveHandler = interface(IUnknown)
    ['{5B3FFCD6-9A53-492B-9DE8-388D7F9E8168}']
    procedure Execute(const AFileName: WideString; out Accept: WordBool); safecall;
  end;

// *********************************************************************//
// Interface: IAddinAfterClientFileSaveHandler
// Flags:     (0)
// GUID:      {478263F0-29B8-42B0-ABA3-C041FE4399FB}
// *********************************************************************//
  IAddinAfterClientFileSaveHandler = interface(IUnknown)
    ['{478263F0-29B8-42B0-ABA3-C041FE4399FB}']
    procedure Execute(const AFileName: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAddinAfterChangeClientFileHeaderPropertyHandler
// Flags:     (0)
// GUID:      {663F7885-98A6-4A73-A4B5-5624AC242679}
// *********************************************************************//
  IAddinAfterChangeClientFileHeaderPropertyHandler = interface(IUnknown)
    ['{663F7885-98A6-4A73-A4B5-5624AC242679}']
    procedure Execute(const AClientFileHeaderkey: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppDatabaseEnvEventsService
// Flags:     (0)
// GUID:      {48C7EC3A-A373-4A4D-8C9C-72B69BCAE789}
// *********************************************************************//
  IAppDatabaseEnvEventsService = interface(IUnknown)
    ['{48C7EC3A-A373-4A4D-8C9C-72B69BCAE789}']
    function Get_BeforeCalc: IAddinBeforeCalcHandler; safecall;
    procedure Set_BeforeCalc(const Value: IAddinBeforeCalcHandler); safecall;
    function Get_AfterCalc: IAddinBeforeCalcHandler; safecall;
    procedure Set_AfterCalc(const Value: IAddinBeforeCalcHandler); safecall;
    function Get_AfterCalcGlobalRates: IAddinNotifyHandler; safecall;
    procedure Set_AfterCalcGlobalRates(const Value: IAddinNotifyHandler); safecall;
    function Get_AfterAcceptUserInput: IAddinDatabaseEnvAfterAcceptUserInput; safecall;
    procedure Set_AfterAcceptUserInput(const Value: IAddinDatabaseEnvAfterAcceptUserInput); safecall;
    function Get_AfterAddRepeat: IAddinDatabaseEnvNotifyWithGroupArray; safecall;
    procedure Set_AfterAddRepeat(const Value: IAddinDatabaseEnvNotifyWithGroupArray); safecall;
    function Get_AfterDeleteRepeat: IAddinDatabaseEnvNotifyWithGroupArray; safecall;
    procedure Set_AfterDeleteRepeat(const Value: IAddinDatabaseEnvNotifyWithGroupArray); safecall;
    property BeforeCalc: IAddinBeforeCalcHandler read Get_BeforeCalc write Set_BeforeCalc;
    property AfterCalc: IAddinBeforeCalcHandler read Get_AfterCalc write Set_AfterCalc;
    property AfterCalcGlobalRates: IAddinNotifyHandler read Get_AfterCalcGlobalRates write Set_AfterCalcGlobalRates;
    property AfterAcceptUserInput: IAddinDatabaseEnvAfterAcceptUserInput read Get_AfterAcceptUserInput write Set_AfterAcceptUserInput;
    property AfterAddRepeat: IAddinDatabaseEnvNotifyWithGroupArray read Get_AfterAddRepeat write Set_AfterAddRepeat;
    property AfterDeleteRepeat: IAddinDatabaseEnvNotifyWithGroupArray read Get_AfterDeleteRepeat write Set_AfterDeleteRepeat;
  end;

// *********************************************************************//
// Interface: IAppDatabaseEnvEventsService1
// Flags:     (0)
// GUID:      {6C2AF1E3-B69D-4EBF-ABC0-BCCC18968376}
// *********************************************************************//
  IAppDatabaseEnvEventsService1 = interface(IAppDatabaseEnvEventsService)
    ['{6C2AF1E3-B69D-4EBF-ABC0-BCCC18968376}']
    function Get_OnCalcAddinDiag: IAddinCalcDiagnosticHandler; safecall;
    procedure Set_OnCalcAddinDiag(const Value: IAddinCalcDiagnosticHandler); safecall;
    function Get_OnDiagClick: IAddinDiagnosticClickHandler; safecall;
    procedure Set_OnDiagClick(const Value: IAddinDiagnosticClickHandler); safecall;
    property OnCalcAddinDiag: IAddinCalcDiagnosticHandler read Get_OnCalcAddinDiag write Set_OnCalcAddinDiag;
    property OnDiagClick: IAddinDiagnosticClickHandler read Get_OnDiagClick write Set_OnDiagClick;
  end;

// *********************************************************************//
// Interface: IAppDocReturn
// Flags:     (0)
// GUID:      {21D5800E-BF91-4414-A3F0-80977FC8A229}
// *********************************************************************//
  IAppDocReturn = interface(IUnknown)
    ['{21D5800E-BF91-4414-A3F0-80977FC8A229}']
    function GetProperties: IAppStatusProperties; safecall;
    function GetReturnPath: WideString; safecall;
    function GetReturnId: LongWord; safecall;
    function GetDocument: IAppTaxDocument; safecall;
    function IsNameAssigned: WordBool; safecall;
    function GetTaxData: IAppTaxData; safecall;
    procedure SetDirty; safecall;
    function GetIsSystemDirty: WordBool; safecall;
    procedure SetIsSystemDirty(AValue: WordBool); safecall;
    function IsApplicable(aFormIndex: LongWord): WordBool; safecall;
    function IsApplicableForRepeat(aFormIndex: LongWord; aRepeatNum: LongWord): WordBool; safecall;
    function IsApplicableForRepeatPath(aFormIndex: LongWord; const aRepeatPath: WideString; 
                                       aRepeat: LongWord): WordBool; safecall;
    function GetPropertyNameByCellName(const CellName: WideString; out PropertyName: WideString): WordBool; safecall;
    function resetDirty: WordBool; safecall;
    function GetInputList: IUnknown; safecall;
    function getAttachmentPath: WideString; safecall;
    function GetDiagnostic: IAppDiagnostic; safecall;
    function GetAliasString(const aAliasName: WideString): WideString; safecall;
    function GetAliasInteger(const aAliasName: WideString): Integer; safecall;
    function GetAliasShort(const aAliasName: WideString): Integer; safecall;
    function GetAliasBoolean(const aAlias: WideString): WordBool; safecall;
    function GetAliasTranslated(const aAlias: WideString): Integer; safecall;
    function GetAliasDate(const aAlias: WideString): TDateTime; safecall;
    procedure SetAliasString(const aAliasName: WideString; const AValue: WideString); safecall;
    procedure SetAliasInteger(const aAlias: WideString; AValue: Integer; 
                              CreateRepeatsAsNeeded: WordBool); safecall;
    procedure SetAliasBoolean(const aAlias: WideString; AValue: WordBool); safecall;
    procedure SetAliasDateToday(const aAlias: WideString); safecall;
    procedure SetAliasTranslated(const aAlias: WideString; const AValue: WideString; 
                                 CreateRepeatsAsNeeded: WordBool); safecall;
    procedure SetAliasDate(const aAlias: WideString; AValue: TDateTime); safecall;
    procedure SetShortAlias(const aAlias: WideString; AValue: Integer; 
                            CreateRepeatsAsNeeded: WordBool); safecall;
    procedure CheckAlias(const aAliasName: WideString); safecall;
    procedure RunCalc; safecall;
  end;

// *********************************************************************//
// Interface: IAppDocReturn1
// Flags:     (0)
// GUID:      {D8BFDBF3-AF24-4852-929C-DE1BAB5FF175}
// *********************************************************************//
  IAppDocReturn1 = interface(IAppDocReturn)
    ['{D8BFDBF3-AF24-4852-929C-DE1BAB5FF175}']
    function GetAttachementManager: IAppAttachementManager; safecall;
  end;

// *********************************************************************//
// Interface: IAddinBeforeCalcHandler
// Flags:     (0)
// GUID:      {0D99071F-DC0D-49CB-9221-84EB9FF296F5}
// *********************************************************************//
  IAddinBeforeCalcHandler = interface(IUnknown)
    ['{0D99071F-DC0D-49CB-9221-84EB9FF296F5}']
    procedure Execute(const AReturn: IAppDocReturn); safecall;
  end;

// *********************************************************************//
// Interface: IAppTaxCell
// Flags:     (0)
// GUID:      {80914BA4-6D8C-4C34-9E6F-305808E8D3ED}
// *********************************************************************//
  IAppTaxCell = interface(IUnknown)
    ['{80914BA4-6D8C-4C34-9E6F-305808E8D3ED}']
    function GetOwnerTaxData: IAppTaxData; safecall;
    function GetChoices(AIndex1: Integer; AIndex2: Integer; ALanguage: AppLanguage): WideString; safecall;
    function GetOwnerRepeatId: Int64; safecall;
    function GetCellName: WideString; safecall;
    function GetCellNameWithGroup: WideString; safecall;
    function GetComparableCellName: WideString; safecall;
    function GetAliasNames(AIndex: Integer): WideString; safecall;
    function GetDescriptionString(GlobalDescriptionOnly: WordBool): WideString; safecall;
    function GetCellIndex: LongWord; safecall;
    function GetFormNum: LongWord; safecall;
    procedure CopyCell(const AFrom: IAppTaxCell); safecall;
    function VirtualCompare(const ACell: IAppTaxCell): Integer; safecall;
    function CompareToString(const sValue: WideString): WordBool; safecall;
    function AcceptUserInput(const sValue: WideString): WordBool; safecall;
    function AcceptImportedInput(const sValue: WideString): WordBool; safecall;
    function AcceptUserVariantValue(Value: OleVariant): WordBool; safecall;
    function AcceptImportedVariantValue(Value: OleVariant): WordBool; safecall;
    function ConvertFromString(const sValue: WideString): WordBool; safecall;
    function ToString: WideString; safecall;
    function ConvertToString(var sValue: WideString): WordBool; safecall;
    function GetVariantValue: OleVariant; safecall;
    procedure ClearCell; safecall;
    procedure Reset; safecall;
    procedure Clear; safecall;
    procedure RemoveUserOverride; safecall;
    procedure AssignEmpty; safecall;
    function EqualsEmpty: WordBool; safecall;
    function DoSelection: WordBool; safecall;
    function IsEmpty: WordBool; safecall;
    function IsProtected: WordBool; safecall;
    function IsDeprecated: WordBool; safecall;
    function HasFormNum: WordBool; safecall;
    function IsPositiveOnly: WordBool; safecall;
    function IsRoundOnAssign: WordBool; safecall;
    function IsSelectable: WordBool; safecall;
    function HasUserOvrd: WordBool; safecall;
    function CanAssignTo: WordBool; safecall;
    function HasInput: WordBool; safecall;
    function HasCalc: WordBool; safecall;
    function HasInternalOvrd: WordBool; safecall;
    function IsEstimated: WordBool; safecall;
    function IsSourceEstimate: WordBool; safecall;
    function IsRolled: WordBool; safecall;
    function HasRolledValue: WordBool; safecall;
    function IsImported: WordBool; safecall;
    procedure SetImported; safecall;
    function IsNA: WordBool; safecall;
    function IsTracking: WordBool; safecall;
    function GetTransferSource: Integer; safecall;
    procedure SetTransferSource(Value: Integer); safecall;
    function HasTransferredValue: WordBool; safecall;
    function WasTransferred: WordBool; safecall;
    function GetAttachedScheduleRepeat: LongWord; safecall;
    function GetAttachedNoteRepeat: LongWord; safecall;
    function HasAttachedSchedule: WordBool; safecall;
    function HasAttachedNote: WordBool; safecall;
    function GetAttachedNoteText: WideString; safecall;
    procedure SetAttachedNoteText(const Value: WideString); safecall;
    function GetAttachmentTargetForExpand: IAppTaxCell; safecall;
    procedure SetCalc; safecall;
    procedure ClearCalc; safecall;
    procedure SetCalcOrderUsed; safecall;
    procedure SetProtected; safecall;
    procedure SetHasFormNum; safecall;
    procedure ClearInput; safecall;
    procedure ClearEstimate; safecall;
    procedure SetEstimate; safecall;
    procedure SetNotEmpty; safecall;
    procedure PromoteCalcToInput; safecall;
    procedure SetRolled; safecall;
    procedure ClearRolled; safecall;
    procedure SetSourceEstimate; safecall;
    procedure ClearSourceEstimate; safecall;
    procedure SetInternalOvrd; safecall;
    procedure ClearInternalOvrd; safecall;
    procedure ClearCalcOrderFlags; safecall;
    procedure SetNA; safecall;
    procedure ClearNA; safecall;
    procedure SetIsTracking; safecall;
    procedure ClearIsTracking; safecall;
    procedure SetReviewMark(markNum: LongWord); safecall;
    procedure ClearReviewMark; safecall;
    function GetReviewMark: LongWord; safecall;
    function GetCellTypeText: WideString; safecall;
    function GetDefaultDelimiterString: WideString; safecall;
    function GetSampleText(Fmt: Int64): WideString; safecall;
    function GetEditControlMask(Fmt: Int64): WideString; safecall;
    function GetCellType: Int64; safecall;
    function GetAssociatedStringTable: Integer; safecall;
    function GetDesiredFieldLength(Fmt: Int64): Integer; safecall;
    function GetRelevantFormattingOptions: Int64; safecall;
    function GetGenericObject: IAppTaxCell; safecall;
    function IsInFilter(InclusionFilter: Integer; ExclusionFilter: Integer): WordBool; safecall;
    function GetAliasNamesCount: Integer; safecall;
    procedure GetChoicesCount(out ACount1: Integer; out ACount2: Integer; ALanguage: AppLanguage); safecall;
    function GetXLatValue(const AApplication: IAppTaxApplicationService; ALanguage: AppLanguage; 
                          AColumn: Integer; Index: Integer): WideString; safecall;
    function GetXLatValuesCount(ALanguage: AppLanguage; 
                                const AApplication: IAppTaxApplicationService): Integer; safecall;
    procedure SetString(const AValue: WideString); safecall;
    function IsLinkCell: WordBool; safecall;
    function LinkCellColumnCount(const AFormName: WideString): Integer; safecall;
    function LinkCellSelectedRow(const AFormName: WideString; AIndex: Integer): WideString; safecall;
    function LinkCellRowCount(const AFormName: WideString): Integer; safecall;
    function LinkCellTable(const AFormName: WideString; ARow: Integer; AColumn: Integer): WideString; safecall;
    function LinkCellColumnNames(const AFormName: WideString; AIndex: Integer): WideString; safecall;
  end;

// *********************************************************************//
// Interface: IAppTaxData
// Flags:     (0)
// GUID:      {154AE7F5-39D7-4AEA-8E75-82A7BDA315CB}
// *********************************************************************//
  IAppTaxData = interface(IUnknown)
    ['{154AE7F5-39D7-4AEA-8E75-82A7BDA315CB}']
    function RootGroup: IAppGroupArray; safecall;
    function GetReturnId: LongWord; safecall;
    function IsADependent: WordBool; safecall;
    function GetDependentIndex: Integer; safecall;
    function GetPermanentId: LongWord; safecall;
    function GetNextRepeatId: Int64; safecall;
    function GetOwnerClient: IUnknown; safecall;
    function GetRelatedData(aReturnId: LongWord): IAppTaxData; safecall;
    function GetExportTag: WideString; safecall;
    procedure GetShortNames(AIndex: Integer; out AName: WideString; out ANumIndicesRequired: Integer); safecall;
    function GetShortNamesCount: Integer; safecall;
    function GetCellByName(const CellName: WideString; CreateRepeatsAsNeeded: WordBool; 
                           MarkNewRepeatsAsCreatedByUser: WordBool): IAppTaxCell; safecall;
    function GetLinkVarByName(const LinkName: WideString; CreateRepeatsAsNeeded: WordBool; 
                              MarkNewRepeatsAsCreatedByUser: WordBool): IUnknown; safecall;
    function GetGroupByName(const Name: WideString; CreateRepeatsAsNeeded: WordBool; 
                            MarkNewRepeatsAsCreatedByUser: WordBool): IAppGroupArray; safecall;
    function GetRepeatByName(const Name: WideString; out RepeatNum: LongWord; 
                             CreateRepeatsAsNeeded: WordBool; 
                             MarkNewRepeatsAsCreatedByUser: WordBool): IAppGroupArray; safecall;
    function GetRepeatById(RepeatId: Int64; out RepeatNum: LongWord): IAppGroupArray; safecall;
    function GetAliasNames(const ACellName: WideString; AIndex: Integer): WideString; safecall;
    function GetAliasNamesCount(const ACellName: WideString): Integer; safecall;
    function GetNumAttachments(AttachmentType: Integer): Integer; safecall;
    function GetAttachmentTarget(AttachmentType: Integer; RepeatNum: LongWord): IAppTaxCell; safecall;
    function GetAttachSchedTitleCell(RepeatNum: LongWord): IAppTaxCell; safecall;
    function GetAttachSchedTotalCell(RepeatNum: LongWord): IAppTaxCell; safecall;
    function GetAttachNoteCell(RepeatNum: LongWord): IAppTaxCell; safecall;
    function GetAttachNoteDescCell(RepeatNum: LongWord): IAppTaxCell; safecall;
    function GetAttachNoteRollOptionCell(RepeatNum: LongWord): IAppTaxCell; safecall;
    function IsAttachmentRollOptionAvailable(AttachmentType: LongWord): WordBool; safecall;
    function GetAttachmentRollOption(AttachmentType: LongWord; RepeatNum: LongWord): WordBool; safecall;
    function GetAttachmentGroup(AttachmentType: LongWord): IAppGroupArray; safecall;
    function GetCellDescription(const CellName: WideString; Language: AppLanguage): WideString; safecall;
    function GetLinkDescription(const LinkName: WideString; Language: AppLanguage): WideString; safecall;
    function IsGroupNamePossible(const Name: WideString): WordBool; safecall;
    function IsCellNamePossible(const Name: WideString): WordBool; safecall;
    function IsLinkNamePossible(const Name: WideString): WordBool; safecall;
    function GetDefaultYear(Day: Integer; Month: Integer): Integer; safecall;
    function IsFormApplicable(FormNum: LongWord): WordBool; safecall;
    function GetNumApplicableCopies(FormNum: LongWord): SYSUINT; safecall;
    function GetFormName(FormNum: LongWord): WideString; safecall;
  end;

// *********************************************************************//
// Interface: IAddinClientFileNotifyWithDocumentHandler
// Flags:     (0)
// GUID:      {E4C83EDD-F85F-4958-9375-3C75B6BC2C4B}
// *********************************************************************//
  IAddinClientFileNotifyWithDocumentHandler = interface(IUnknown)
    ['{E4C83EDD-F85F-4958-9375-3C75B6BC2C4B}']
    procedure Execute(const Document: IAppTaxDocument); safecall;
  end;

// *********************************************************************//
// Interface: IAddinBeforeCurrentDocumentChangeHandler
// Flags:     (0)
// GUID:      {BE2F809C-4BFF-479B-8A19-C4C401CF1D60}
// *********************************************************************//
  IAddinBeforeCurrentDocumentChangeHandler = interface(IUnknown)
    ['{BE2F809C-4BFF-479B-8A19-C4C401CF1D60}']
    procedure Execute(const OldDocument: IAppTaxDocument; const NewDocument: IAppTaxDocument); safecall;
  end;

// *********************************************************************//
// Interface: IAppGroupArray
// Flags:     (0)
// GUID:      {81C79AFD-4162-45F4-BD69-3C479D63D036}
// *********************************************************************//
  IAppGroupArray = interface(IUnknown)
    ['{81C79AFD-4162-45F4-BD69-3C479D63D036}']
    procedure RemoveAllLinks; safecall;
    function DuplicateStructure(const From: IAppGroupArray): WordBool; safecall;
    function DuplicateContents(const From: IAppGroupArray): WordBool; safecall;
    function GetNumRepeats: LongWord; safecall;
    function GetMinRepeats: LongWord; safecall;
    function GetMaxRepeats: LongWord; safecall;
    function GetNumCells: LongWord; safecall;
    function GetNumLinks: LongWord; safecall;
    function GetNumSubgroups: LongWord; safecall;
    function GetIndex: LongWord; safecall;
    function GetGroupInfo: IAppGroupInfo; safecall;
    function GetFormNum: LongWord; safecall;
    function IsRepeatingGroup: WordBool; safecall;
    function InUse: WordBool; safecall;
    function GetOwner: IAppGroupArray; safecall;
    function GetOwnerByRepeatIndex(RepeatNum: LongWord): IAppGroupArray; safecall;
    function GetOwnerById(RepId: Int64): IAppGroupArray; safecall;
    function GetName(GetFullName: WordBool): WideString; safecall;
    function GetSubgroup(GrpNum: LongWord; RepNum: LongWord): IAppGroupArray; safecall;
    function GetSubgroupFromRepeat0(GrpNum: LongWord): IAppGroupArray; safecall;
    function GetCellFromRepeat(CellNum: LongWord; RepNum: LongWord): IAppTaxCell; safecall;
    function GetCellFromRepeat0(CellNum: LongWord): IAppTaxCell; safecall;
    function GetRepeatId(RepNum: LongWord): Int64; safecall;
    function FindRepeatById(RepId: Int64): LongWord; safecall;
    function CreateRepeat(NumRepeats: LongWord; InsertionPoint: LongWord; CreatedByUser: WordBool): WordBool; safecall;
    function CreateRolledRepeat(const SourceGroup: IAppGroupArray; SourceRepNum: LongWord): LongWord; safecall;
    procedure MapRolledRepeat(RepNum: LongWord; const SourceGroup: IAppGroupArray; 
                              SourceRepNum: LongWord); safecall;
    procedure DeleteRepeat(IndexToDelete: LongWord; NumToDelete: LongWord); safecall;
    procedure ResetArray; safecall;
    procedure AssignCells(const From: IAppGroupArray); safecall;
    procedure AssignCellsEx(const From: IAppGroupArray; TargetRepNum: LongWord; 
                            SourceRepNum: LongWord); safecall;
    procedure MultiplyCellsInt(Value: Integer); safecall;
    procedure MultiplyCellsDecimal(AValue: Currency); safecall;
    procedure MultiplyCellsFloat(AValue: Single); safecall;
    procedure MultiplyCellsByCell(const ACell: IAppTaxCell); safecall;
    function ResolveLinkedRepeats: WordBool; safecall;
    procedure ResetRepeat(RepNum: LongWord); safecall;
    function IsRepeatOwnedByLinkOfType(RepNum: LongWord; const GroupInfo: IAppGroupInfo; 
                                       LinkNum: LongWord): WordBool; safecall;
    function HasCellsWithInput(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool; safecall;
    function GetNumCellsWithInput(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer; safecall;
    function HasOverriddenCells(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool; safecall;
    function HasOverriddenCellsOnForms(CheckSubgroups: WordBool; RepeatNum: LongWord): WordBool; safecall;
    function GetNumOverriddenCells(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer; safecall;
    function GetNumOverriddenCellsOnForms(CheckSubgroups: WordBool; RepeatNum: LongWord): Integer; safecall;
    function WasCreatedByUser(RepeatNum: LongWord): WordBool; safecall;
    function GetOwnerTaxData: IAppTaxData; safecall;
    procedure ResetCalcOrderBits; safecall;
    procedure ClearApplicInfo; safecall;
    procedure ClearAllReviewMarks(DoSubgroups: WordBool; RepeatNum: LongWord); safecall;
    procedure ClearEstimateFlags(DoSubgroups: WordBool; RepeatNum: LongWord); safecall;
    procedure ClearIsTrackingFlags(DoSubgroups: WordBool; RepeatNum: LongWord); safecall;
    function SetIsTrackingFlags(DoSubgroups: WordBool; RepeatNum: LongWord): WordBool; safecall;
    function AddApplicableForm(FormNum: LongWord; RepNum: LongWord): WordBool; safecall;
    function IsFormApplicable(FormNum: LongWord; RepNum: LongWord): WordBool; safecall;
    function GetCorrespondingComparativeRepeat(CurrentYearRepeatNumber: LongWord; 
                                               const ComparativeReturn: IAppTaxData; 
                                               out ComparativeRepeatNumber: LongWord): IAppGroupArray; safecall;
    function GetCorrespondingCurrentYearRepeat(ComparativeRepeatNumber: LongWord; 
                                               const CurrentYearReturn: IAppTaxData; 
                                               out CurrentYearRepeatNumber: LongWord): IAppGroupArray; safecall;
  end;

// *********************************************************************//
// Interface: IAppGroupInfo
// Flags:     (0)
// GUID:      {FE33CF79-4395-45A0-A5BD-B3D759653985}
// *********************************************************************//
  IAppGroupInfo = interface(IUnknown)
    ['{FE33CF79-4395-45A0-A5BD-B3D759653985}']
    function GetName: WideString; safecall;
    function GetFullName: WideString; safecall;
    function GetTemplateGroupName: WideString; safecall;
    function GetNumCells: LongWord; safecall;
    function GetNumLinks: LongWord; safecall;
    function GetNumSubgroups: LongWord; safecall;
    function GetCellType(CellNumber: LongWord): LongWord; safecall;
    function IsCellProtected(CellNumber: LongWord): WordBool; safecall;
    function CellHasFormNumOverride(CellNumber: LongWord): WordBool; safecall;
    function GetFormNumForCell(CellNumber: LongWord): LongWord; safecall;
    function GetMaskString(Index: Integer): WideString; safecall;
    function GetSubgroup(Index: LongWord): IAppGroupInfo; safecall;
    function GetSubgroupByName(const Name: WideString): IAppGroupInfo; safecall;
    function GetRollMapping(const CellName: WideString; out SkipThisOne: WordBool): WideString; safecall;
    function GetParent: IAppGroupInfo; safecall;
    function GetMaxRepeats: LongWord; safecall;
    function GetMinRepeats: LongWord; safecall;
    function GetLinkedGroup(LinkNum: LongWord): IAppGroupInfo; safecall;
    function GetLinkedGroupForLinkCell(CellNum: LongWord): IAppGroupInfo; safecall;
    function GetLinkSelectionCellNum(LinkNum: LongWord): LongWord; safecall;
    function GetLinkCellSelectionCellNum(CellNum: LongWord): LongWord; safecall;
    function IsOwnerLink(LinkNum: LongWord): WordBool; safecall;
    function IsGenericLink(LinkNum: LongWord): WordBool; safecall;
    function GetIndex: LongWord; safecall;
    function GetAllLevelsCount: LongWord; safecall;
    function GetAllLevels(AIndex: Integer): IAppGroupInfo; safecall;
    function GetNumRepeatingLevels: Integer; safecall;
    function GetAllIndicesCount: Integer; safecall;
    function GetAllIndices(AIndex: Integer): LongWord; safecall;
    function GetFormNum: LongWord; safecall;
    function DescendsFrom(const Info: IAppGroupInfo): WordBool; safecall;
    function GetTemplateVersion: LongWord; safecall;
    function InUse: WordBool; safecall;
    function IsRepeatingGroup: WordBool; safecall;
    function IsDeprecated: WordBool; safecall;
    function IsCellDeprecated(CellNum: LongWord): WordBool; safecall;
    function IsLinkDeprecated(LinkNum: LongWord): WordBool; safecall;
    function HasIdenticalStructureAs(const GroupInfo: IAppGroupInfo): WordBool; safecall;
    function GetCellClassName(CellNumber: LongWord): WideString; safecall;
    function ConstructTempCell(CellNum: LongWord): IAppTaxCell; safecall;
    function CalcHeapUsageForCellsAndLinks: Integer; safecall;
  end;

// *********************************************************************//
// Interface: IAppTaxApplicationService
// Flags:     (0)
// GUID:      {464F2B17-0089-4E12-99E4-DC0F11AA6EA9}
// *********************************************************************//
  IAppTaxApplicationService = interface(IUnknown)
    ['{464F2B17-0089-4E12-99E4-DC0F11AA6EA9}']
    function CanCloseClientFile(const aClientFile: IAppClientFile): WordBool; safecall;
    function GetClientFileManager: IAppClientFileManagerService; safecall;
    function GetDefaultLanguage: AppLanguage; safecall;
    function GetProductName: WideString; safecall;
    function GetProductSuffix: WideString; safecall;
    function getIsDemo: WordBool; safecall;
    function getIsEducative: WordBool; safecall;
    function getIsNetWork: WordBool; safecall;
    function getIsNetworkRegular: WordBool; safecall;
    function getIsNetworkAdvanced: WordBool; safecall;
    function getIsEFILEGovernment: WordBool; safecall;
    function getIsCOMAvailable: WordBool; safecall;
    function getProductType: Integer; safecall;
    function GetVersionType: WideString; safecall;
    function GetName: WideString; safecall;
    function GetExecutableName: WideString; safecall;
    function GetTitleName: WideString; safecall;
    function GetSoftwareVersion: WideString; safecall;
    function GetTemplateSignaturePrefix: WideString; safecall;
    function GetIsFirstExecution: WordBool; safecall;
    function GetConfiguration: IUnknown; safecall;
    function CreateDocument: IAppTaxDocument; safecall;
    function GetCurrentDocument: IAppTaxDocument; safecall;
    function GetString(const APath: WideString; const AID: WideString): WideString; safecall;
    function GetStringWithLanguage(const APath: WideString; const AID: WideString; 
                                   ALanguage: AppLanguage): WideString; safecall;
    function GetMessagePath: WideString; safecall;
    function GetMessage(const AID: WideString): WideString; safecall;
    function GetVersionInfo: IUnknown; safecall;
    function ShowMessageString(const Title: WideString; const AMessage: WideString): Integer; safecall;
    procedure SetAppStatusBar(const AValue: WideString); safecall;
    function GetStatusBarText: WideString; safecall;
    function GetDBEnv: IUnknown; safecall;
    function GetYear: Integer; safecall;
    function GetCurrentField: IAppField; safecall;
    function GetCurrentTaxData: IAppTaxData; safecall;
    function GetCurrentTaxReturn: IAppTaxReturn; safecall;
    function GetCurrentTaxCell: IAppTaxCell; safecall;
    function GetCurrentDocReturn: IAppDocReturn; safecall;
    function Get_Configuration: IAppConfiguration; safecall;
    function Get_OnIdle: IAddinIdleHandler; safecall;
    procedure Set_OnIdle(const Value: IAddinIdleHandler); safecall;
    function Get_UFL: IAppUFL; safecall;
    function Get_ClientLetterManager: IAppClientLetterManager; safecall;
    procedure StartLongOperation; safecall;
    procedure getMainMainFormsBaunds(out aLeft: Integer; out aTop: Integer; out aWidth: Integer; 
                                     out aHeight: Integer); safecall;
    function getMainFormHandle: LongWord; safecall;
    procedure RefreshAdvertisingMenu; safecall;
    function Get_OnGetAdvertisingData: IAddinGetAdvertisingDataHandler; safecall;
    procedure Set_OnGetAdvertisingData(const Value: IAddinGetAdvertisingDataHandler); safecall;
    function GetMachineIdentifier: WideString; safecall;
    function GetCalcDllName: WideString; safecall;
    function GetCalcVersion: WideString; safecall;
    function GetFilePath: WideString; safecall;
    function GetFileDateTime: TDateTime; safecall;
    function GetFileDateStr: WideString; safecall;
    function GetFileTimeStr: WideString; safecall;
    function GetCompanyName: WideString; safecall;
    function GetFileDescription: WideString; safecall;
    function GetFileVersion: WideString; safecall;
    function GetInternalName: WideString; safecall;
    function GetLegalCopyright: WideString; safecall;
    function GetLegalTradeMarks: WideString; safecall;
    function GetOriginalFilename: WideString; safecall;
    function GetVersionProductName: WideString; safecall;
    function GetProductVersion: WideString; safecall;
    function GetComments: WideString; safecall;
    function GetPrivateBuild: WideString; safecall;
    function GetSpecialBuild: WideString; safecall;
    property Configuration: IAppConfiguration read Get_Configuration;
    property OnIdle: IAddinIdleHandler read Get_OnIdle write Set_OnIdle;
    property UFL: IAppUFL read Get_UFL;
    property ClientLetterManager: IAppClientLetterManager read Get_ClientLetterManager;
    property OnGetAdvertisingData: IAddinGetAdvertisingDataHandler read Get_OnGetAdvertisingData write Set_OnGetAdvertisingData;
  end;

// *********************************************************************//
// Interface: IAppTaxApplicationService1
// Flags:     (0)
// GUID:      {6CE793BD-4D79-4671-91F2-44DB3B4172FA}
// *********************************************************************//
  IAppTaxApplicationService1 = interface(IAppTaxApplicationService)
    ['{6CE793BD-4D79-4671-91F2-44DB3B4172FA}']
    function Get_OnAfterLanguageChange: IAddinNotifyHandler; safecall;
    procedure Set_OnAfterLanguageChange(const Value: IAddinNotifyHandler); safecall;
    function Get_OnBeforeLanguageChange: IAddinNotifyHandler; safecall;
    procedure Set_OnBeforeLanguageChange(const Value: IAddinNotifyHandler); safecall;
    function GetResourceManager: IAppResourceManager; safecall;
    function GetLanguage: AppLanguage; safecall;
    function GetApplicationHandle: LongWord; safecall;
    function GetCustomDiagnostic: IAppAddinCustomDiagnostic; safecall;
    property OnAfterLanguageChange: IAddinNotifyHandler read Get_OnAfterLanguageChange write Set_OnAfterLanguageChange;
    property OnBeforeLanguageChange: IAddinNotifyHandler read Get_OnBeforeLanguageChange write Set_OnBeforeLanguageChange;
  end;

// *********************************************************************//
// Interface: IAppClientFileManagerService
// Flags:     (0)
// GUID:      {4CC93007-AE1B-4419-AB3F-485D8F9A5910}
// *********************************************************************//
  IAppClientFileManagerService = interface(IUnknown)
    ['{4CC93007-AE1B-4419-AB3F-485D8F9A5910}']
    function NewClientFile(const AFilePath: WideString; out aClientFile: IAppClientFile): WordBool; safecall;
    function OpenClientFile(const AFilePath: WideString; out aClientFile: IAppClientFile; 
                            AOpenParameters: AppClientFileOpenOptions): WordBool; safecall;
    function CloseCurrentClientFile(AWithManager: WordBool): WordBool; safecall;
    function AddClientFile(const aClientFile: IAppClientFile): Integer; safecall;
    procedure InsertClientFile(AIndex: Integer; const aClientFile: IAppClientFile); safecall;
    procedure DeleteClientFile(AIndex: Integer); safecall;
    function RemoveClientFile(const aClientFile: IAppClientFile): Integer; safecall;
    procedure ClearClientFiles; safecall;
    function GetClientFileByFilePath(const AFilePath: WideString): IAppClientFile; safecall;
    function GetClientFile(AIndex: Integer): IAppClientFile; safecall;
    function GetCurrentClientFile: IAppClientFile; safecall;
    procedure SetCurrentClientFile(const aClientFile: IAppClientFile); safecall;
    function GetCurrentClientFileIndex: Integer; safecall;
    procedure SetCurrentClientFileIndex(AClientFileIndex: Integer); safecall;
    function GetCurrentDocument: IAppTaxDocument; safecall;
    function GetCurrentDocIndex: LongWord; safecall;
    function GetCurrentTaxDocument: IAppTaxDocument; safecall;
    function GetCurrentReturn: IAppDocReturn; safecall;
    function GetCurrentReturnId: LongWord; safecall;
    function SetCurrentDocument(AClientFileIndex: Integer; ADocIndex: LongWord): WordBool; safecall;
    function SetCurrentReturn(AClientFileIndex: Integer; ADocIndex: LongWord; aReturnId: LongWord): WordBool; safecall;
    function GetCount: Integer; safecall;
    procedure SilentOpenMode; safecall;
    procedure BackupFiles; safecall;
    procedure SetBackupEnabled(Value: WordBool); safecall;
    function IsBackupEnabled: WordBool; safecall;
    function GetVersionInfo: WideString; safecall;
    function OpenClientFileUIDefault(const AFileName: WideString; out aClientFile: IAppClientFile): WordBool; safecall;
    function OpenClientFileUISilent(const AFileName: WideString; out aClientFile: IAppClientFile): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAppClientFile
// Flags:     (0)
// GUID:      {8CDECC10-42B1-46EF-8DA2-1E1CC2F5D4E9}
// *********************************************************************//
  IAppClientFile = interface(IUnknown)
    ['{8CDECC10-42B1-46EF-8DA2-1E1CC2F5D4E9}']
    function CreateNew(const AFilePath: WideString): WordBool; safecall;
    function Open(const AFilePath: WideString): WordBool; safecall;
    function Save(const AFilePath: WideString): WordBool; safecall;
    function SaveQuietly(const AFilePath: WideString): WordBool; safecall;
    function Backup(const Path: WideString; const Ext: WideString): WordBool; safecall;
    function LoadHeader(const AFilePath: WideString): WordBool; safecall;
    function SaveHeader(const AFilePath: WideString): WordBool; safecall;
    procedure RestorePathName; safecall;
    procedure CommitPathName; safecall;
    procedure SetPathFileName(const AFilePath: WideString); safecall;
    function GetDisplayPathFileName: WideString; safecall;
    function GetTryingSavePathName: WideString; safecall;
    function IsOpen: WordBool; safecall;
    function IsNew: WordBool; safecall;
    function NewForRoll: WordBool; safecall;
    procedure SetIsNew; safecall;
    function IsDirty: WordBool; safecall;
    procedure resetDirty; safecall;
    procedure SetDirty(AValue: WordBool); safecall;
    procedure CreateTimeStamp; safecall;
    procedure CreateGUID; safecall;
    function GetGUID: WideString; safecall;
    function AddDocument(ADocIndex: LongWord; const ADocName: WideString; const ATaxClient: IUnknown): Integer; safecall;
    function AddScenario(const ADocName: WideString): Integer; safecall;
    function RemoveDocument(ADocIndex: LongWord): WordBool; safecall;
    procedure Clear; safecall;
    function LoadDocuments: WordBool; safecall;
    function LoadDocumentByIndex(ADocIndex: LongWord): WordBool; safecall;
    function LoadDocumentByInterface(const ADocument: IAppTaxDocument): WordBool; safecall;
    function LoadDocumentHeaderByIndex(ADocIndex: LongWord): WordBool; safecall;
    function LoadDocumentHeaderByInterface(const ADocument: IAppTaxDocument): WordBool; safecall;
    function SaveDocumentByIndex(ADocIndex: LongWord): WordBool; safecall;
    function SaveDocumentByInterface(const ADocument: IAppTaxDocument): WordBool; safecall;
    function SaveSystemHeadersNoUserDirty: WordBool; safecall;
    function IsDocumentLoaded(ADocIndex: LongWord): WordBool; safecall;
    function EraseDocument(ADocIndex: LongWord): WordBool; safecall;
    function GetDocument(ADocIndex: LongWord): IAppTaxDocument; safecall;
    function GetDocInfo(ADocIndex: LongWord): IUnknown; safecall;
    function GetDocIndexByListIndex(AListIndex: Integer): LongWord; safecall;
    function GetDocumentFromList(Ndx: Integer; loadDocIfNotExists: WordBool): IAppTaxDocument; safecall;
    function GetCurrentDocIndex: LongWord; safecall;
    function GetCurrentDocListIndex: Integer; safecall;
    function GetCurrentYearDocument: IAppTaxDocument; safecall;
    function GetTaxDocument(ADocIndex: LongWord; out ATaxDocument: IAppTaxDocument): WordBool; safecall;
    function GetCurrentTaxDocument(out ATaxDocument: IAppTaxDocument): WordBool; safecall;
    function SetDefaultCurrentDocument: WordBool; safecall;
    function SetCurrentDocument(ADocIndex: LongWord; ForceEvents: WordBool): WordBool; safecall;
    function SetCurrentDocumentFromList(Ndx: Integer; UnSelectReturn: WordBool; 
                                        ForceEvents: WordBool): WordBool; safecall;
    function SetScenarioAsCurrentYear: WordBool; safecall;
    function GetScenarioCount: Integer; safecall;
    function GetLastScenarioIndex: LongWord; safecall;
    function GetLastScenarioDocIndex: LongWord; safecall;
    function CurrentYearExists: WordBool; safecall;
    function LastYearExists: WordBool; safecall;
    function PlanningExists: WordBool; safecall;
    function GetCount: Integer; safecall;
    function GetDocumentByIndex(AIndex: Integer): IAppTaxDocument; safecall;
    function ListIndexOfInterface(const ADocument: IAppTaxDocument): Integer; safecall;
    function ListIndexOfDocIndex(ADocIndex: LongWord): Integer; safecall;
    function IsValidListIndex(AIndex: Integer): WordBool; safecall;
    function IsValidCurrentListIndex: WordBool; safecall;
    function GetDocumentName(ADocIndex: LongWord): WideString; safecall;
    function IsUniqueDocumentName(const AName: WideString): WordBool; safecall;
    function GetCurrentReturn: IAppDocReturn; safecall;
    function GetCurrentReturnId: LongWord; safecall;
    function GetDatabaseEnv: IUnknown; safecall;
    function LoadLastYearDocument(const AFilePath: WideString): WordBool; safecall;
    function LoadLastYearPlanner(const AFilePath: WideString): WordBool; safecall;
    function GetTaxPayer(aReturnId: LongWord): WideString; safecall;
    procedure RunCalcForAllReturns; safecall;
    function GetDocInfoByDocType(aDocType: AppDocType): IUnknown; safecall;
    function getAskedOptions(Value: AppAskOption): WordBool; safecall;
    procedure setAskedOptions(Value: AppAskOption; add: WordBool); safecall;
    procedure SetReadOnlyFileAttr(Value: WordBool); safecall;
    function HasPassword: WordBool; safecall;
    function CreateAttachmentManager: IUnknown; safecall;
    function GetClientFileLinksMgr: IUnknown; safecall;
    function GetFileOpenMode: LongWord; safecall;
    function GetFileOpenReadOnly: WordBool; safecall;
    function GetDataTracking: WordBool; safecall;
    function GetDataLocked: WordBool; safecall;
    procedure SetDataLocked(ADataLocked: WordBool); safecall;
    procedure SetSystemDataLocked(ADataLocked: WordBool); safecall;
    function GetSystemLocked: WordBool; safecall;
    procedure SetSystemLocked(Lock: WordBool); safecall;
    function GetSystemLockedBy(out AName: WideString): WordBool; safecall;
    function IsSystemLockedByCurrentUser: WordBool; safecall;
    procedure SetLanguage(ALanguage: AppLanguage); safecall;
    function GetLanguage: AppLanguage; safecall;
    function GetCanSaveFile: WordBool; safecall;
    function GetCanModifyData: WordBool; safecall;
    function GetOpenResult: AppOpenResult; safecall;
    procedure SetOpenResult(AResult: AppOpenResult); safecall;
    function GetSaveResult: AppSaveResult; safecall;
    function GetDateTime: WideString; safecall;
    function IsPlanner: WordBool; safecall;
    procedure SetPlanner; safecall;
    function GetOldFileName: WideString; safecall;
    procedure SetOldFileName(const Value: WideString); safecall;
    function IsCouplingUpdated: WordBool; safecall;
    procedure SetCouplingUpdated; safecall;
    function GetReadOnlyFileAttr: WordBool; safecall;
    function GetCalcPersonalDiags: WordBool; safecall;
    function GetIsNewerDataBaseTemplate: WordBool; safecall;
    procedure SetIsNewerDataBaseTemplate(aNewerDataBaseTemplate: WordBool); safecall;
    function GetListOfReturnIDCount: Integer; safecall;
    function GetListOfReturnIDItem(AIndex: Integer): WideString; safecall;
    procedure SetRecalcAlways; safecall;
    function CanRecalcAlways: WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAddinDatabaseEnvAfterAcceptUserInput
// Flags:     (0)
// GUID:      {6076C17E-890F-4A91-9766-5D07E234A58B}
// *********************************************************************//
  IAddinDatabaseEnvAfterAcceptUserInput = interface(IUnknown)
    ['{6076C17E-890F-4A91-9766-5D07E234A58B}']
    procedure Execute(const aTaxCell: IAppTaxCell); safecall;
  end;

// *********************************************************************//
// Interface: IAddinDatabaseEnvNotifyWithGroupArray
// Flags:     (0)
// GUID:      {B9F741E2-F98E-49D7-851F-4A675BC91198}
// *********************************************************************//
  IAddinDatabaseEnvNotifyWithGroupArray = interface(IUnknown)
    ['{B9F741E2-F98E-49D7-851F-4A675BC91198}']
    procedure Execute(const Group: IAppGroupArray); safecall;
  end;

// *********************************************************************//
// Interface: IAppTaxDocument
// Flags:     (0)
// GUID:      {D8287F8A-E546-498F-BC21-61E4276B944D}
// *********************************************************************//
  IAppTaxDocument = interface(IUnknown)
    ['{D8287F8A-E546-498F-BC21-61E4276B944D}']
    function GetTaxpayerIdInReturn(AReturn: LongWord): WideString; safecall;
    function GetFileTimeStamp: WideString; safecall;
    function GetTaxationYearEnd(const AReturn: IAppDocReturn): WideString; safecall;
    procedure resetDirty; safecall;
    function IsDirty: WordBool; safecall;
    function GetDBEnv: IUnknown; safecall;
    function GetDatabase: IUnknown; safecall;
    function GetCurrentTaxData: IAppTaxData; safecall;
    procedure NewDocument(const AName: WideString); safecall;
    function FindDocReturn(aReturnId: LongWord): IAppDocReturn; safecall;
    function GetCurrentReturnId: LongWord; safecall;
    function CurrentReturn: IAppDocReturn; safecall;
    function GetReturnAt(anIndex: Integer): IAppDocReturn; safecall;
    function GetReturnCount: Integer; safecall;
    function IndexOf(const aDocReturn: IAppDocReturn): Integer; safecall;
    procedure UpdateAllHeaders; safecall;
    procedure AddDocReturnForExistingTaxData(aReturnId: LongWord); safecall;
    function GetStatus: IUnknown; safecall;
    function SelectReturn(aReturnId: LongWord; ForceEvents: WordBool): WordBool; safecall;
    procedure RemoveReturn(returnId: LongWord); safecall;
    function getDocumentProperties: IAppProperties; safecall;
    function getReturnProperties(aReturnId: LongWord): IAppStatusProperties; safecall;
    function GetCalcVersionFromHeader: WideString; safecall;
    function GetDocIndexStr: WideString; safecall;
    procedure SetDocIndexStr(const AName: WideString); safecall;
    function IsReturnRegistered(aReturnId: LongWord): WordBool; safecall;
    function IsReturnRegisteredWithBankId(aReturnId: LongWord; out aWithBlankID: WordBool): WordBool; safecall;
    function IsRolled: WordBool; safecall;
    function SystemDirty: WordBool; safecall;
    procedure SetCalcDirty(aDirty: WordBool); safecall;
    function IsCalcDirty: WordBool; safecall;
    procedure SetCalcPersonalDiagInterrupted(AValue: WordBool); safecall;
    function GetCalcPersonalDiagInterrupted: WordBool; safecall;
    procedure UpdateDatabaseFromAllHeaders; safecall;
    function getDocIndex: Integer; safecall;
    procedure SetDirty; safecall;
    function Get_DocName: WideString; safecall;
    procedure Set_DocName(const Value: WideString); safecall;
    property DocName: WideString read Get_DocName write Set_DocName;
  end;

// *********************************************************************//
// Interface: IAppField
// Flags:     (0)
// GUID:      {A0C11735-EE63-47AE-86BE-851ADDD48173}
// *********************************************************************//
  IAppField = interface(IUnknown)
    ['{A0C11735-EE63-47AE-86BE-851ADDD48173}']
    function IsOfType(ATypeID: AppGraphicID): WordBool; safecall;
    function GetCellText: WideString; safecall;
    procedure SetCellText(const AValue: WideString); safecall;
    function GetFieldColor: Integer; safecall;
    function GetCellFmt: Int64; safecall;
    procedure SetCellFmt(AValue: Int64); safecall;
    procedure SetFieldColor(AValue: Integer); safecall;
    procedure SetFieldCellPath(const APath: WideString); safecall;
    function GetFieldCellPath(Alternative: WordBool): WideString; safecall;
    procedure SetFieldFlags(cFlagHelp: WordBool; cFlagEnabled: WordBool; cFlagAutoText: WordBool; 
                            cFlagNoXpress: WordBool; cFlagAllowDecimal: WordBool); safecall;
    procedure GetFieldFlags(out cFlagHelp: WordBool; out cFlagEnabled: WordBool; 
                            out cFlagAutoText: WordBool; out cFlagNoXpress: WordBool; 
                            out cFlagAllowDecimal: WordBool); safecall;
    procedure SetCellOrder(Value: Integer); safecall;
    function GetCellOrder: Integer; safecall;
    function GetPrintBkgnd: AppPrintBkgnd; safecall;
    function GetICell: LongWord; safecall;
    procedure SetAttach(AValue: WordBool); safecall;
    function GetAttach: WordBool; safecall;
    procedure SetOverriden(Value: WordBool); safecall;
    function GetOverriden: WordBool; safecall;
    function HasCCHHelpLink: WordBool; safecall;
    function GetDiagFlag: WordBool; safecall;
    procedure SetFDiagFlag(Value: WordBool); safecall;
    procedure ApplyRepeatIndex(const RepeatPath: WideString; Index: LongWord); safecall;
    function GetFlagWidth: Integer; safecall;
    function GetRepeatNumber: LongWord; safecall;
    function GetBox: WideString; safecall;
    procedure SetBox(const AValue: WideString); safecall;
    procedure GetReviewMarks(out rmFirst: WordBool; out rmSecond: WordBool; out rmError: WordBool; 
                             out rmEstimated: WordBool; out rmSourceEstimated: WordBool; 
                             out rmOther: WordBool); safecall;
    procedure SetReviewMarks(rmFirst: WordBool; rmSecond: WordBool; rmError: WordBool; 
                             rmEstimated: WordBool; rmSourceEstimated: WordBool; rmOther: WordBool); safecall;
    function GetReviewMarkXOffset: Integer; safecall;
    function GetDrawHighlightBorder: WordBool; safecall;
    procedure SetDrawHighlightBorder(AValue: WordBool); safecall;
    function HasJumpSource: WordBool; safecall;
    function GetJumpSource: WideString; safecall;
    function GetSourceFormName: WideString; safecall;
    function IsJumpSourceCond: WordBool; safecall;
    function HasOverride: WordBool; safecall;
    function HasJumpTarget: WordBool; safecall;
    function JumpTargetCount: Integer; safecall;
    function GetJumpTarget(Index: Integer): WideString; safecall;
    function JumpTargetDifference(AIndex: Integer): AppJumpDifference; safecall;
    function GetTargetFormName(Index: Integer): WideString; safecall;
    function GetSourceICell: LongWord; safecall;
    function GetTargetICell(Index: Integer): LongWord; safecall;
    function GetTargetCellPath(Index: Integer; const ATaxData: IAppTaxData): WideString; safecall;
    function IsJumpTargetCond(Index: Integer): WordBool; safecall;
    procedure SetJumpTargetDifferenceFlags(const ATaxData: IAppTaxData; const aTaxCell: IAppTaxCell); safecall;
    function GetHasAttachmentTargetExpand: WordBool; safecall;
    procedure SetHasAttachmentTargetExpand(Value: WordBool); safecall;
    function GetDisplayText(DisplayFieldProp: AppDisplayFieldProp): WideString; safecall;
    procedure SetCellTextForPrint(aPrintLanguage: AppLanguage; const ATaxData: IAppTaxData); safecall;
  end;

// *********************************************************************//
// Interface: IAppCellSelectionIter
// Flags:     (0)
// GUID:      {D9AA2AB4-E5AA-480E-915A-933E522BDD1F}
// *********************************************************************//
  IAppCellSelectionIter = interface(IUnknown)
    ['{D9AA2AB4-E5AA-480E-915A-933E522BDD1F}']
    procedure First; safecall;
    procedure Last; safecall;
    procedure Next; safecall;
    function Current: IAppField; safecall;
    function IsDone: WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAppDragDropService
// Flags:     (0)
// GUID:      {E67EF30C-8378-4F5A-8ECB-B5259CC8FBE1}
// *********************************************************************//
  IAppDragDropService = interface(IUnknown)
    ['{E67EF30C-8378-4F5A-8ECB-B5259CC8FBE1}']
    procedure RegisterDataFormat(AFormat: LongWord; const AHandler: IAddinDragDropDataFormatHandler); safecall;
  end;

// *********************************************************************//
// Interface: IAddinDragDropDataFormatHandler
// Flags:     (0)
// GUID:      {F439D7F9-4BCE-410F-8FBA-21BA3B6CE547}
// *********************************************************************//
  IAddinDragDropDataFormatHandler = interface(IUnknown)
    ['{F439D7F9-4BCE-410F-8FBA-21BA3B6CE547}']
    function GetData(const ASelection: IAppCellSelectionIter): OleVariant; safecall;
  end;

// *********************************************************************//
// Interface: IAppTaxReturn
// Flags:     (0)
// GUID:      {8F490032-CB2E-4E7D-A49D-159ACFCB65D4}
// *********************************************************************//
  IAppTaxReturn = interface(IUnknown)
    ['{8F490032-CB2E-4E7D-A49D-159ACFCB65D4}']
    procedure SaveConfiguration; safecall;
    procedure ReadConfiguration; safecall;
    function OpenTaxForm(const FormNAme: WideString): WordBool; safecall;
    procedure CtrlGJumpToCellForm(AJumpAction: Integer; AJumpLevel: Integer); safecall;
    function AcceptUserInput: WordBool; safecall;
    procedure EnableCellBrowserButtons(EnableBrowserCommands: WordBool); safecall;
    procedure DoFMSearch; safecall;
    procedure DoFMClearSearch; safecall;
    procedure UpdateFormMenuItems(UpdatingLevel: AppUpdatingMenuLevel); safecall;
    procedure ProcessPrintButton; safecall;
    function GetFormEngine: IUnknown; safecall;
    function GetEntryUndoManager: IUnknown; safecall;
    function CanDeactivateCurrentReturn: WordBool; safecall;
    function NewTaxReturn: WordBool; safecall;
    procedure DoSaveTaxReturn; safecall;
    procedure DoSaveTaxReturnAs; safecall;
    procedure ShowFMSearchBarItems(pVisible: WordBool); safecall;
    function GetFMSearchKey: WideString; safecall;
    procedure SetFMSearchKey(const aString: WideString); safecall;
    function GetXpressModule: IUnknown; safecall;
    function GetScanModule: IUnknown; safecall;
    function GetFormManager: IUnknown; safecall;
    function GetDiagnosticKey: WordBool; safecall;
    function GetScanKey: WordBool; safecall;
    function GetXpressKey: WordBool; safecall;
    procedure SetDiagnosticKey(AValue: WordBool); safecall;
    procedure SetScanKey(AValue: WordBool); safecall;
    procedure SetXpressKey(AValue: WordBool); safecall;
    procedure ActivateDiagnosticFrame(aActive: WordBool); safecall;
    procedure ActivateXpressFrame(AValue: WordBool); safecall;
    procedure ActivateScanFrame(activate: WordBool; aFromFormManager: WordBool; 
                                aFromModuleChange: WordBool; aFromRevisionBar: WordBool); safecall;
    procedure ActivateRevisionBar(activate: WordBool); safecall;
    procedure ActivateMonitor(activate: WordBool); safecall;
    procedure AddScanPage; safecall;
    procedure RemoveScanPage; safecall;
    procedure XpressCustomizedFilterModified(const AFilterName: WideString); safecall;
    function IsXpressTabActive: WordBool; safecall;
    function IsScanTabVisible: WordBool; safecall;
    function IsRevisionbarFrameVisible: WordBool; safecall;
    function CheckDiagFlagForForm(const AFormName: WideString): WordBool; safecall;
    function DoJumpToCellForm(const AFormName: WideString; const ACellPath: WideString; 
                              AICell: LongWord): Integer; safecall;
    function SwitchReturn(aReturnId: LongWord): WordBool; safecall;
    function GetBasicTaxReturn: IUnknown; safecall;
    procedure ShowFormManager; safecall;
    function GetReviewMode: WordBool; safecall;
    procedure SetReviewMode(AValue: WordBool); safecall;
    function GetReviewModeMark: AppReviewModeMark; safecall;
    procedure SetReviewModeMark(AValue: AppReviewModeMark); safecall;
    function GetDisplayReviewMarks: WordBool; safecall;
    procedure PrintCurrentForms; safecall;
    procedure RefreshTreeList; safecall;
  end;

// *********************************************************************//
// Interface: IAppStatusProperties
// Flags:     (0)
// GUID:      {CAD060D8-1FB9-4E37-8DB3-53D0D46853AB}
// *********************************************************************//
  IAppStatusProperties = interface(IUnknown)
    ['{CAD060D8-1FB9-4E37-8DB3-53D0D46853AB}']
    function SetStringNoUserDirty(const aKey: WideString; const AValue: WideString): WordBool; safecall;
    function SetIntegerNoUserDirty(const aKey: WideString; AValue: Integer): WordBool; safecall;
    function SetBooleanNoUserDirty(const aKey: WideString; AValue: WordBool): WordBool; safecall;
    function SetCurrencyNoUserDirty(const aKey: WideString; AValue: Currency): WordBool; safecall;
    function SetDateTimeNoUserDirty(const aKey: WideString; AValue: TDateTime): WordBool; safecall;
    function SetString(const aKey: WideString; const AValue: WideString): WordBool; safecall;
    function SetInteger(const aKey: WideString; AValue: Integer): WordBool; safecall;
    function SetBoolean(const aKey: WideString; AValue: WordBool): WordBool; safecall;
    function SetCurrency(const aKey: WideString; AValue: Currency): WordBool; safecall;
    function SetDateTime(const aKey: WideString; AValue: TDateTime): WordBool; safecall;
    function SimulateSetString(const aKey: WideString; const AValue: WideString): WordBool; safecall;
    function RemoveKey(const aKey: WideString): WordBool; safecall;
    procedure SetSectionName(const aSectionName: WideString); safecall;
    function GetSectionName: WideString; safecall;
    function Get_IsDirty: WordBool; safecall;
    procedure Set_IsDirty(Value: WordBool); safecall;
    function KeyExists(const aKey: WideString): WordBool; safecall;
    function AsString(const aKey: WideString; const aDefaultVallue: WideString): WideString; safecall;
    function AsInteger(const aKey: WideString; aDefaultValue: Integer): Integer; safecall;
    function AsInt64(const aKey: WideString; aDefaultValue: Int64): Int64; safecall;
    function AsBoolean(const aKey: WideString; aDefaultValue: WordBool): WordBool; safecall;
    function AsCurrency(const aKey: WideString; aDefaultValue: Currency): Currency; safecall;
    function AsDateTime(const aKey: WideString; aDefaultValue: TDateTime): TDateTime; safecall;
    function GetKeyAt(AIndex: Integer; out aReturnedKey: WideString): WordBool; safecall;
    function GetKeyCount: Integer; safecall;
    procedure Empty; safecall;
    function IsEmpty: WordBool; safecall;
    function Get_Count: Integer; safecall;
    function Get_IsDataOwner: WordBool; safecall;
    function Get_IsSorted: WordBool; safecall;
    procedure Set_IsSorted(Value: WordBool); safecall;
    function GetReturnStatus(ALanguage: AppLanguage): WideString; safecall;
    function GetStatusInLanguage(const AStatusName: WideString; ALanguage: AppLanguage; 
                                 const AEnumName: WideString): WideString; safecall;
    property IsDirty: WordBool read Get_IsDirty write Set_IsDirty;
    property Count: Integer read Get_Count;
    property IsDataOwner: WordBool read Get_IsDataOwner;
    property IsSorted: WordBool read Get_IsSorted write Set_IsSorted;
  end;

// *********************************************************************//
// Interface: IAddinReturnStatusChange
// Flags:     (0)
// GUID:      {766BF3C1-5AAB-4305-A97D-EE1984C966B2}
// *********************************************************************//
  IAddinReturnStatusChange = interface(IUnknown)
    ['{766BF3C1-5AAB-4305-A97D-EE1984C966B2}']
    procedure Execute(const aDocReturn: IAppDocReturn; const AStatusName: WideString; 
                      aOldValue: Integer; AValue: Integer); safecall;
  end;

// *********************************************************************//
// Interface: IAppTesting
// Flags:     (0)
// GUID:      {23C4821E-D915-47C7-B3DB-199148732FD2}
// *********************************************************************//
  IAppTesting = interface(IUnknown)
    ['{23C4821E-D915-47C7-B3DB-199148732FD2}']
    procedure TestRaiseError(const AMesasge: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppProperties
// Flags:     (0)
// GUID:      {9173D8A0-4B69-4C43-BAB5-5798E5261397}
// *********************************************************************//
  IAppProperties = interface(IUnknown)
    ['{9173D8A0-4B69-4C43-BAB5-5798E5261397}']
    function SetString(const aKey: WideString; const AValue: WideString): WordBool; safecall;
    function SetInteger(const aKey: WideString; AValue: Integer): WordBool; safecall;
    function SetBoolean(const aKey: WideString; AValue: WordBool): WordBool; safecall;
    function SetCurrency(const aKey: WideString; AValue: Currency): WordBool; safecall;
    function SetDateTime(const aKey: WideString; AValue: TDateTime): WordBool; safecall;
    function SimulateSetString(const aKey: WideString; const AValue: WideString): WordBool; safecall;
    function RemoveKey(const aKey: WideString): WordBool; safecall;
    procedure SetSectionName(const aSectionName: WideString); safecall;
    function GetSectionName: WideString; safecall;
    function Get_IsDirty: WordBool; safecall;
    procedure Set_IsDirty(Value: WordBool); safecall;
    function KeyExists(const aKey: WideString): WordBool; safecall;
    function AsString(const aKey: WideString; const aDefaultVallue: WideString): WideString; safecall;
    function AsInteger(const aKey: WideString; aDefaultValue: Integer): Integer; safecall;
    function AsInt64(const aKey: WideString; aDefaultValue: Int64): Int64; safecall;
    function AsBoolean(const aKey: WideString; aDefaultValue: WordBool): WordBool; safecall;
    function AsCurrency(const aKey: WideString; aDefaultValue: Currency): Currency; safecall;
    function AsDateTime(const aKey: WideString; aDefaultValue: TDateTime): TDateTime; safecall;
    function GetKeyAt(AIndex: Integer; out aReturnedKey: WideString): WordBool; safecall;
    function GetKeyCount: Integer; safecall;
    procedure Empty; safecall;
    function IsEmpty: WordBool; safecall;
    function Get_Count: Integer; safecall;
    function Get_IsDataOwner: WordBool; safecall;
    function Get_IsSorted: WordBool; safecall;
    procedure Set_IsSorted(Value: WordBool); safecall;
    property IsDirty: WordBool read Get_IsDirty write Set_IsDirty;
    property Count: Integer read Get_Count;
    property IsDataOwner: WordBool read Get_IsDataOwner;
    property IsSorted: WordBool read Get_IsSorted write Set_IsSorted;
  end;

// *********************************************************************//
// Interface: IAppConfiguration
// Flags:     (0)
// GUID:      {1833C577-EC89-41FC-80AB-97218384A665}
// *********************************************************************//
  IAppConfiguration = interface(IUnknown)
    ['{1833C577-EC89-41FC-80AB-97218384A665}']
    function RemoveKey(const aSectionName: WideString; const aKey: WideString): WordBool; safecall;
    function getSectionListOfProperties(const aSectionName: WideString): IAppProperties; safecall;
    procedure AddConfigurationSection(const aSectionName: WideString); safecall;
    function LoadProperties: WordBool; safecall;
    function SaveProperties: WordBool; safecall;
    function SetString(const aSectionName: WideString; const aKey: WideString; 
                       const AValue: WideString): WordBool; safecall;
    function SetInteger(const aSectionName: WideString; const aKey: WideString; AValue: Integer): WordBool; safecall;
    function SetBoolean(const aSectionName: WideString; const aKey: WideString; AValue: WordBool): WordBool; safecall;
    function SetCurrency(const aSectionName: WideString; const aKey: WideString; AValue: Currency): WordBool; safecall;
    function SetDateTime(const aSectionName: WideString; const aKey: WideString; AValue: TDateTime): WordBool; safecall;
    function SetPoint(const aSectionName: WideString; const aKey: WideString; AValueX: Integer; 
                      AValueY: Integer): WordBool; safecall;
    function SetRect(const aSectionName: WideString; const aKey: WideString; aLeft: Integer; 
                     aTop: Integer; ARigh: Integer; ABottom: Integer): WordBool; safecall;
    function SetPath(const aSectionName: WideString; const aKey: WideString; 
                     const AValue: WideString): WordBool; safecall;
    function SetEncryptedString(const aSectionName: WideString; const aKey: WideString; 
                                const AValue: WideString): WordBool; safecall;
    function KeyExists(const aSectionName: WideString; const aKey: WideString): WordBool; safecall;
    function AsString(const aSectionName: WideString; const aKey: WideString; 
                      const aDefaultValue: WideString): WideString; safecall;
    function AsInteger(const aSectionName: WideString; const aKey: WideString; 
                       aDefaultValue: Integer): Integer; safecall;
    function AsBoolean(const aSectionName: WideString; const aKey: WideString; 
                       aDefaultValue: WordBool): WordBool; safecall;
    function AsCurrency(const aSectionName: WideString; const aKey: WideString; 
                        aDefaultValue: Currency): Currency; safecall;
    function AsDateTime(const aSectionName: WideString; const aKey: WideString; 
                        aDefaultValue: TDateTime): TDateTime; safecall;
    procedure AsPoint(const aSectionName: WideString; const aKey: WideString; ADefaultX: Integer; 
                      ADefaultY: Integer; out AResultX: Integer; out AResultY: Integer); safecall;
    procedure AsRect(const aSectionName: WideString; const aKey: WideString; ADefaultLeft: Integer; 
                     ADefaultTop: Integer; ADefaultRight: Integer; ADefaultBottom: Integer; 
                     out AResultLeft: Integer; out AResultTop: Integer; out AResultRight: Integer; 
                     out AResultBottom: Integer); safecall;
    function AsPath(const aSectionName: WideString; const aKey: WideString; 
                    const aDefaultValue: WideString): WideString; safecall;
    function AsEncryptedString(const aSectionName: WideString; const aKey: WideString; 
                               const aDefaultValue: WideString): WideString; safecall;
    function Enable(const aSectionName: WideString; const aKey: WideString): WordBool; safecall;
    function GetLevelType: AppConfigurationLevelType; safecall;
    procedure SetLevelType(aLevelType: AppConfigurationLevelType); safecall;
    function GetSecurityMode: AppConfigurationSecurityModeManager; safecall;
    function KeyEnable(const aSection: WideString; const aKey: WideString): WordBool; safecall;
    procedure SetKeyEnabled(const aSectionName: WideString; const aKey: WideString; AValue: WordBool); safecall;
    function GetLastLevelSectionsCount: Integer; safecall;
    function GetLastLevelSectionNameAt(aSectionIndex: Integer): WideString; safecall;
    procedure SetMRULanguage(const Language: WideString); safecall;
    procedure ClearLastLevel; safecall;
    function GetSectionKeyCount(const aSectionName: WideString): Integer; safecall;
    function GetSectionKeyNameAt(const aSectionName: WideString; AIndex: Integer): WideString; safecall;
    function GetSecurityLayerByName(const aLevelName: WideString): IAppConfigurationSecureLevel; safecall;
    function Get_AfterAddSection: IAddinConfigurationAddRemoveSectionHandler; safecall;
    procedure Set_AfterAddSection(const Value: IAddinConfigurationAddRemoveSectionHandler); safecall;
    function Get_AfterRemoveSection: IAddinConfigurationAddRemoveSectionHandler; safecall;
    procedure Set_AfterRemoveSection(const Value: IAddinConfigurationAddRemoveSectionHandler); safecall;
    function Get_AfterAddProperty(const aSectionName: WideString): IAddinConfigurationAddRemoveKeyHandler; safecall;
    procedure Set_AfterAddProperty(const aSectionName: WideString; 
                                   const Value: IAddinConfigurationAddRemoveKeyHandler); safecall;
    function Get_AfterRemoveProperty(const aSectionName: WideString): IAddinConfigurationAddRemoveKeyHandler; safecall;
    procedure Set_AfterRemoveProperty(const aSectionName: WideString; 
                                      const Value: IAddinConfigurationAddRemoveKeyHandler); safecall;
    function Get_AfterModifyKey: IAddinConfigurationKeyModifiedHandler; safecall;
    procedure Set_AfterModifyKey(const Value: IAddinConfigurationKeyModifiedHandler); safecall;
    property AfterAddSection: IAddinConfigurationAddRemoveSectionHandler read Get_AfterAddSection write Set_AfterAddSection;
    property AfterRemoveSection: IAddinConfigurationAddRemoveSectionHandler read Get_AfterRemoveSection write Set_AfterRemoveSection;
    property AfterAddProperty[const aSectionName: WideString]: IAddinConfigurationAddRemoveKeyHandler read Get_AfterAddProperty write Set_AfterAddProperty;
    property AfterRemoveProperty[const aSectionName: WideString]: IAddinConfigurationAddRemoveKeyHandler read Get_AfterRemoveProperty write Set_AfterRemoveProperty;
    property AfterModifyKey: IAddinConfigurationKeyModifiedHandler read Get_AfterModifyKey write Set_AfterModifyKey;
  end;

// *********************************************************************//
// Interface: IAppModule
// Flags:     (0)
// GUID:      {03F03F94-E11C-4B9C-A243-8175F52B55FD}
// *********************************************************************//
  IAppModule = interface(IUnknown)
    ['{03F03F94-E11C-4B9C-A243-8175F52B55FD}']
    function Get_Name: WideString; safecall;
    function Get_TitleName: WideString; safecall;
    function Get_TitleButtonName: WideString; safecall;
    property Name: WideString read Get_Name;
    property TitleName: WideString read Get_TitleName;
    property TitleButtonName: WideString read Get_TitleButtonName;
  end;

// *********************************************************************//
// Interface: IAppModuleManager
// Flags:     (0)
// GUID:      {46AE6773-C3E9-42A9-BE81-65945BDA3542}
// *********************************************************************//
  IAppModuleManager = interface(IUnknown)
    ['{46AE6773-C3E9-42A9-BE81-65945BDA3542}']
    function Get_CurrentModule: IAppModule; safecall;
    function Get_AfterCurrentModuleChange: IAddinModuleManagerNotifyHandler; safecall;
    procedure Set_AfterCurrentModuleChange(const Value: IAddinModuleManagerNotifyHandler); safecall;
    function Get_BeforeCurrentModuleChange: IAddinModuleManagerNotifyHandler; safecall;
    procedure Set_BeforeCurrentModuleChange(const Value: IAddinModuleManagerNotifyHandler); safecall;
    property CurrentModule: IAppModule read Get_CurrentModule;
    property AfterCurrentModuleChange: IAddinModuleManagerNotifyHandler read Get_AfterCurrentModuleChange write Set_AfterCurrentModuleChange;
    property BeforeCurrentModuleChange: IAddinModuleManagerNotifyHandler read Get_BeforeCurrentModuleChange write Set_BeforeCurrentModuleChange;
  end;

// *********************************************************************//
// Interface: IAddinModuleManagerNotifyHandler
// Flags:     (4096) Dispatchable
// GUID:      {F13AAF92-7939-45E2-B0F5-EEEE3482B14A}
// *********************************************************************//
  IAddinModuleManagerNotifyHandler = interface(IDispatch)
    ['{F13AAF92-7939-45E2-B0F5-EEEE3482B14A}']
    procedure Execute(const AModule: IAppModule); safecall;
  end;

// *********************************************************************//
// Interface: IAddinConfigurationAddRemoveKeyHandler
// Flags:     (0)
// GUID:      {242DEC8C-09A4-4CF0-AE70-5B3DB8789185}
// *********************************************************************//
  IAddinConfigurationAddRemoveKeyHandler = interface(IUnknown)
    ['{242DEC8C-09A4-4CF0-AE70-5B3DB8789185}']
    procedure Execute(const aSection: WideString; const aKey: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAddinConfigurationKeyModifiedHandler
// Flags:     (0)
// GUID:      {D80C9A01-7A96-4EC1-8BE5-38F84CD2753C}
// *********************************************************************//
  IAddinConfigurationKeyModifiedHandler = interface(IUnknown)
    ['{D80C9A01-7A96-4EC1-8BE5-38F84CD2753C}']
    procedure Execute(const aLevel: WideString; const aSection: WideString; const aKey: WideString; 
                      const AValue: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppConfigurationSecureLevel
// Flags:     (0)
// GUID:      {9AF8258F-187E-4FEC-ADE9-FA8D1E3F0C86}
// *********************************************************************//
  IAppConfigurationSecureLevel = interface(IUnknown)
    ['{9AF8258F-187E-4FEC-ADE9-FA8D1E3F0C86}']
    procedure Initialize(const AFilePath: WideString); safecall;
    procedure Load; safecall;
    function Save: WordBool; safecall;
    function RemoveKey(const aSectionName: WideString; const aKey: WideString): WordBool; safecall;
    function RemoveSection(const aSectionName: WideString): WordBool; safecall;
    function AddSection(const aSectionName: WideString): WordBool; safecall;
    function GetData(const aSectionName: WideString; const aKey: WideString; out AValue: WideString): WordBool; safecall;
    function SetData(const aSectionName: WideString; const aKey: WideString; 
                     const AValue: WideString): WordBool; safecall;
    function KeyExists(const aSectionName: WideString; const aKey: WideString): WordBool; safecall;
    function GetObjectName: WideString; safecall;
    procedure SetObjectName(const AValue: WideString); safecall;
    function SimulateSetData(const aSectionName: WideString; const aKey: WideString; 
                             const AValue: WideString): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAddinConfigurationAddRemoveSectionHandler
// Flags:     (0)
// GUID:      {2ABF7D9B-F4B2-4334-B22E-19B4AD3A18F1}
// *********************************************************************//
  IAddinConfigurationAddRemoveSectionHandler = interface(IUnknown)
    ['{2ABF7D9B-F4B2-4334-B22E-19B4AD3A18F1}']
    procedure Execute(const aSectionName: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppDiagnostic
// Flags:     (0)
// GUID:      {A5361C8C-8E84-41E4-967E-7082A7B75AB6}
// *********************************************************************//
  IAppDiagnostic = interface(IUnknown)
    ['{A5361C8C-8E84-41E4-967E-7082A7B75AB6}']
    procedure Initialize; safecall;
    function GetDiagCount(AGroupNo: Integer): Integer; safecall;
    function GetDiagNode(AIndex: Integer; AGroupNo: Integer): IAppDiagNode; safecall;
    function getDiagnosticByCell(const aTaxCell: IAppTaxCell; var AText: WideString; 
                                 onlyFirst: WordBool): WordBool; safecall;
    procedure ClearAll; safecall;
    function GetReturnId: LongWord; safecall;
    function getDocReturn: IAppDocReturn; safecall;
    function DiagAdded: WordBool; safecall;
    function Update: WordBool; safecall;
    function CalcPersonalDiagInterrupted: WordBool; safecall;
    procedure CalcPersonalDiags(ResetCounter: WordBool); safecall;
    function GetCalcPersonalDiagCompleted: WordBool; safecall;
    procedure SetCalcPersonalDiagCompleted(AValue: WordBool); safecall;
  end;

// *********************************************************************//
// Interface: IAppDiagNode
// Flags:     (0)
// GUID:      {8DD46145-92E3-4114-9FA3-E612539DECF2}
// *********************************************************************//
  IAppDiagNode = interface(IUnknown)
    ['{8DD46145-92E3-4114-9FA3-E612539DECF2}']
    function getDiagGroupNo: Integer; safecall;
    function getDiagNo: Integer; safecall;
    function getDiagType: Integer; safecall;
    function getJurisdiction: AppJuridiction; safecall;
    function getMessagePopupType: AppPopupMessageType; safecall;
    function getDiagText(ALanguage: AppLanguage): WideString; safecall;
    function getDiagName: WideString; safecall;
    function getDiagNote: WideString; safecall;
    procedure getOption(out doDefaultAccept: WordBool; out doNoExtraText: WordBool); safecall;
    function getDiagIndex: Integer; safecall;
    function getLink(out aTaxCell: IAppTaxCell; aReturnTaxCell: WordBool): WordBool; safecall;
    function getParamsCount: Integer; safecall;
    function getParams(AIndex: Integer; ALanguage: AppLanguage): WideString; safecall;
    function getDiagRevMark: Integer; safecall;
    function getFormNumber: LongWord; safecall;
    function GetApplicable: WordBool; safecall;
    function GetDisplayText(ALanguage: AppLanguage): WideString; safecall;
  end;

// *********************************************************************//
// Interface: IAppUFL
// Flags:     (0)
// GUID:      {A11BEDA3-C389-4EC9-8308-2146290C4443}
// *********************************************************************//
  IAppUFL = interface(IUnknown)
    ['{A11BEDA3-C389-4EC9-8308-2146290C4443}']
    function GetFormByFormNumber(formNumber: Integer): IAppUFLNode; safecall;
    function GetFormByName(const AFormName: WideString): IAppUFLNode; safecall;
    function GetFormIndexByName(const FormNAme: WideString): Integer; safecall;
    function GetFormIndexByFormNumber(formNumber: Integer): Integer; safecall;
    function GetAccessCodeByName(const AFormName: WideString): WideString; safecall;
    function IsReadyForm(const FormNAme: WideString): WordBool; safecall;
    function IsAvailableForm(const FormNAme: WideString): WordBool; safecall;
    function IsPrePrintForm(const AFormName: WideString): WordBool; safecall;
    function GetFormByCCHScanForm(const aCCHScanFormName: WideString): IAppUFLNode; safecall;
    function IsCompatibleCCHScanForm(const aCCHScanFormName: WideString; const AFormName: WideString): WordBool; safecall;
    function Get_Form(AIndex: Integer): IAppUFLNode; safecall;
    function Get_Count: Integer; safecall;
    property Form[AIndex: Integer]: IAppUFLNode read Get_Form;
    property Count: Integer read Get_Count;
  end;

// *********************************************************************//
// Interface: IAppUFLNode
// Flags:     (0)
// GUID:      {E96FF84D-EED4-4C1C-91F4-2EC17587094E}
// *********************************************************************//
  IAppUFLNode = interface(IUnknown)
    ['{E96FF84D-EED4-4C1C-91F4-2EC17587094E}']
    function Get_formNumber: Integer; safecall;
    function Get_FormNAme: WideString; safecall;
    function Get_LinkFormName: WideString; safecall;
    function Get_LinkSectionName: WideString; safecall;
    function Get_AccesCode: WideString; safecall;
    function Get_ShortDesc: WideString; safecall;
    function Get_LongDesc: WideString; safecall;
    function Get_Juridiction: AppJuridiction; safecall;
    function Get_JuridictionDisplay: AppJuridiction; safecall;
    function Get_FormGroupName: WideString; safecall;
    function Get_IsPayForm: WordBool; safecall;
    function Get_CCHScanFormName: WideString; safecall;
    function Get_SupportedAddIns: Integer; safecall;
    function MustInFormManager: WordBool; safecall;
    function MustInPrintFormat: WordBool; safecall;
    function InFormManager: WordBool; safecall;
    function InPrintFormat: WordBool; safecall;
    function IsTaxForm: WordBool; safecall;
    function IsQuebecForm: WordBool; safecall;
    function IsFederalPrint: WordBool; safecall;
    function IsAlbertaPrint: WordBool; safecall;
    function IsXpressForm: WordBool; safecall;
    function IsLetterForm: WordBool; safecall;
    function IsLabelForm: WordBool; safecall;
    function IsPrePrint: WordBool; safecall;
    function IsAddinSupported(anAddinBitValue: Integer): WordBool; safecall;
    function Print(const AReturn: IAppDocReturn; ALanguage: AppLanguage; 
                   out aOutputFileName: WideString): WordBool; safecall;
    property formNumber: Integer read Get_formNumber;
    property FormNAme: WideString read Get_FormNAme;
    property LinkFormName: WideString read Get_LinkFormName;
    property LinkSectionName: WideString read Get_LinkSectionName;
    property AccesCode: WideString read Get_AccesCode;
    property ShortDesc: WideString read Get_ShortDesc;
    property LongDesc: WideString read Get_LongDesc;
    property Juridiction: AppJuridiction read Get_Juridiction;
    property JuridictionDisplay: AppJuridiction read Get_JuridictionDisplay;
    property FormGroupName: WideString read Get_FormGroupName;
    property IsPayForm: WordBool read Get_IsPayForm;
    property CCHScanFormName: WideString read Get_CCHScanFormName;
    property SupportedAddIns: Integer read Get_SupportedAddIns;
  end;

// *********************************************************************//
// Interface: IAppClientLetterManager
// Flags:     (0)
// GUID:      {045A0C8C-8FDD-44CA-BB32-6F40A01EC75E}
// *********************************************************************//
  IAppClientLetterManager = interface(IUnknown)
    ['{045A0C8C-8FDD-44CA-BB32-6F40A01EC75E}']
    function Get_Count: Integer; safecall;
    function Get_ClientLetters(AIndex: Integer): IAppClientLetter; safecall;
    property Count: Integer read Get_Count;
    property ClientLetters[AIndex: Integer]: IAppClientLetter read Get_ClientLetters;
  end;

// *********************************************************************//
// Interface: IAppClientLetter
// Flags:     (0)
// GUID:      {B06588FD-0281-45AF-B6EA-553CDF598EF8}
// *********************************************************************//
  IAppClientLetter = interface(IUnknown)
    ['{B06588FD-0281-45AF-B6EA-553CDF598EF8}']
    function Get_FormNAme: WideString; safecall;
    function Get_FilePath: WideString; safecall;
    function Get_AddInsBitField: Integer; safecall;
    property FormNAme: WideString read Get_FormNAme;
    property FilePath: WideString read Get_FilePath;
    property AddInsBitField: Integer read Get_AddInsBitField;
  end;

// *********************************************************************//
// Interface: IAppPredefinedService
// Flags:     (0)
// GUID:      {5FCED777-B5B6-47A9-96E9-39075A88655A}
// *********************************************************************//
  IAppPredefinedService = interface(IUnknown)
    ['{5FCED777-B5B6-47A9-96E9-39075A88655A}']
    function GetPredefinedMenu(const AIndentifier: WideString; out AMenuItem: IAppMenuItem): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAppPredefinedService1
// Flags:     (0)
// GUID:      {68625051-2AB6-4FE5-8924-39573B40FF42}
// *********************************************************************//
  IAppPredefinedService1 = interface(IAppPredefinedService)
    ['{68625051-2AB6-4FE5-8924-39573B40FF42}']
    function GetAdvertisingButton(const AIndentifier: WideString; 
                                  out AAdvertisingButton: IAppAdvertisingButton): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAddinGetAdvertisingDataHandler
// Flags:     (0)
// GUID:      {A73F2F8A-4C5A-4304-8FC1-DA81BBFCF25B}
// *********************************************************************//
  IAddinGetAdvertisingDataHandler = interface(IUnknown)
    ['{A73F2F8A-4C5A-4304-8FC1-DA81BBFCF25B}']
    procedure Execute(out AParameterName: WideString; out AData: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppVersionInfo
// Flags:     (0)
// GUID:      {743D154A-3FE5-4A81-8BC7-AE38458477D6}
// *********************************************************************//
  IAppVersionInfo = interface(IUnknown)
    ['{743D154A-3FE5-4A81-8BC7-AE38458477D6}']
    function GetVersionInfo: WordBool; safecall;
    function CompiledBySystemQA: WordBool; safecall;
    function GetFileFound: WordBool; safecall;
    function GetTdsFound: WordBool; safecall;
    function GetInfoFound: WordBool; safecall;
    function GetFilePath: WideString; safecall;
    function GetFileDateTime: TDateTime; safecall;
    function GetFileDateStr: WideString; safecall;
    function GetFileTimeStr: WideString; safecall;
    function GetTdsDateTime: WordBool; safecall;
    function GetTdsDateStr: WideString; safecall;
    function GetTdsTimeStr: WideString; safecall;
    function GetLanguage: WideString; safecall;
    function GetCompanyName: WideString; safecall;
    function GetFileDescription: WideString; safecall;
    function GetFileVersion: WideString; safecall;
    function GetInternalName: WideString; safecall;
    function GetLegalCopyright: WideString; safecall;
    function GetLegalTradeMarks: WideString; safecall;
    function GetOriginalFilename: WideString; safecall;
    function GetProductName: WideString; safecall;
    function GetProductVersion: WideString; safecall;
    function GetComments: WideString; safecall;
    function GetPrivateBuild: WideString; safecall;
    function GetSpecialBuild: WideString; safecall;
  end;

// *********************************************************************//
// Interface: IAddinClientFileEventHandler
// Flags:     (0)
// GUID:      {A4F01315-9040-445A-9C57-4FFA98A52F58}
// *********************************************************************//
  IAddinClientFileEventHandler = interface(IUnknown)
    ['{A4F01315-9040-445A-9C57-4FFA98A52F58}']
    procedure Execute(const aClientFile: IAppClientFile); safecall;
  end;

// *********************************************************************//
// Interface: IAddinClientFileChangeEventHandler
// Flags:     (0)
// GUID:      {0D26D53E-91BC-4EFD-8F2A-28F97226E600}
// *********************************************************************//
  IAddinClientFileChangeEventHandler = interface(IUnknown)
    ['{0D26D53E-91BC-4EFD-8F2A-28F97226E600}']
    procedure Execute(const AOldClientFile: IAppClientFile; const ANewClientFile: IAppClientFile); safecall;
  end;

// *********************************************************************//
// Interface: IAddinCanCloseEventHandler
// Flags:     (0)
// GUID:      {92EB012B-F19E-41F8-A693-2ABEA6739FD6}
// *********************************************************************//
  IAddinCanCloseEventHandler = interface(IUnknown)
    ['{92EB012B-F19E-41F8-A693-2ABEA6739FD6}']
    function Execute(const aClientFile: IAppClientFile): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAppAdvertisingButton
// Flags:     (0)
// GUID:      {EC530290-1CDC-4EF3-8288-546CFA50666C}
// *********************************************************************//
  IAppAdvertisingButton = interface(IUnknown)
    ['{EC530290-1CDC-4EF3-8288-546CFA50666C}']
    function Get_Caption: WideString; safecall;
    procedure Set_Caption(const Value: WideString); safecall;
    function Get_Width: Integer; safecall;
    procedure Set_Width(Value: Integer); safecall;
    function Get_Hint: WideString; safecall;
    procedure Set_Hint(const Value: WideString); safecall;
    function Get_OnClick: IAddinNotifyHandler; safecall;
    procedure Set_OnClick(const Value: IAddinNotifyHandler); safecall;
    function Get_Visible: WordBool; safecall;
    procedure Set_Visible(Value: WordBool); safecall;
    procedure Refresh; safecall;
    function Get_AdvertisingIdent: WideString; safecall;
    procedure Set_AdvertisingIdent(const Value: WideString); safecall;
    function Get_AdvertisingActivated(const AIdent: WideString): WordBool; safecall;
    procedure Set_AdvertisingActivated(const AIdent: WideString; Value: WordBool); safecall;
    function GetPostData(const AUrl: WideString; const AIdent: WideString; 
                         const AAditionalData: WideString): WideString; safecall;
    property Caption: WideString read Get_Caption write Set_Caption;
    property Width: Integer read Get_Width write Set_Width;
    property Hint: WideString read Get_Hint write Set_Hint;
    property OnClick: IAddinNotifyHandler read Get_OnClick write Set_OnClick;
    property Visible: WordBool read Get_Visible write Set_Visible;
    property AdvertisingIdent: WideString read Get_AdvertisingIdent write Set_AdvertisingIdent;
    property AdvertisingActivated[const AIdent: WideString]: WordBool read Get_AdvertisingActivated write Set_AdvertisingActivated;
  end;

// *********************************************************************//
// Interface: IAddinDocReturnNotifyHandler
// Flags:     (0)
// GUID:      {6E413B81-DF08-448A-BBC8-74F0667BCEF1}
// *********************************************************************//
  IAddinDocReturnNotifyHandler = interface(IUnknown)
    ['{6E413B81-DF08-448A-BBC8-74F0667BCEF1}']
    procedure Execute(const aDocReturn: IAppDocReturn); safecall;
  end;

// *********************************************************************//
// Interface: IAppResourceManager
// Flags:     (0)
// GUID:      {706B34A3-F621-4401-8078-17CA86FD6648}
// *********************************************************************//
  IAppResourceManager = interface(IUnknown)
    ['{706B34A3-F621-4401-8078-17CA86FD6648}']
    function PathExists(const inPath: WideString): WordBool; safecall;
    function GetString(const inPath: WideString): WideString; safecall;
    function GetInt(const inPath: WideString): Integer; safecall;
    function GetDec(const inPath: WideString): Double; safecall;
    function GetBool(const inPath: WideString): WordBool; safecall;
    function GetLines(const inPath: WideString; out aLines: WideString): Integer; safecall;
  end;

// *********************************************************************//
// Interface: IAppAttachementManager
// Flags:     (0)
// GUID:      {638BF30E-9B38-42FD-A969-8355C0699A61}
// *********************************************************************//
  IAppAttachementManager = interface(IUnknown)
    ['{638BF30E-9B38-42FD-A969-8355C0699A61}']
    function Get_Count: Integer; safecall;
    function Get_Items(AIndex: Integer): IAppAttachment; safecall;
    function CreateAttachment(const AInputFile: WideString): IAppAttachment; safecall;
    property Count: Integer read Get_Count;
    property Items[AIndex: Integer]: IAppAttachment read Get_Items;
  end;

// *********************************************************************//
// Interface: IAppAttachment
// Flags:     (0)
// GUID:      {ECE8DE52-EA2B-44A1-9815-56F59E867FF3}
// *********************************************************************//
  IAppAttachment = interface(IUnknown)
    ['{ECE8DE52-EA2B-44A1-9815-56F59E867FF3}']
    function Get_GUID: WideString; safecall;
    function Get_FileName: WideString; safecall;
    function Get_FullName: WideString; safecall;
    procedure Set_FullName(const Value: WideString); safecall;
    function Get_OriginalPath: WideString; safecall;
    procedure Set_OriginalPath(const Value: WideString); safecall;
    function Get_TimeStamp: Int64; safecall;
    procedure Set_TimeStamp(Value: Int64); safecall;
    function Get_LastModified: TDateTime; safecall;
    procedure Set_LastModified(Value: TDateTime); safecall;
    function Get_Size: Integer; safecall;
    procedure Set_Size(Value: Integer); safecall;
    function Get_ToRollForward: WordBool; safecall;
    procedure Set_ToRollForward(Value: WordBool); safecall;
    function Get_IsRollForwarded: WordBool; safecall;
    procedure Set_IsRollForwarded(Value: WordBool); safecall;
    procedure SaveToFile(out aOutputFile: WideString); safecall;
    procedure Delete; safecall;
    property GUID: WideString read Get_GUID;
    property FileName: WideString read Get_FileName;
    property FullName: WideString read Get_FullName write Set_FullName;
    property OriginalPath: WideString read Get_OriginalPath write Set_OriginalPath;
    property TimeStamp: Int64 read Get_TimeStamp write Set_TimeStamp;
    property LastModified: TDateTime read Get_LastModified write Set_LastModified;
    property Size: Integer read Get_Size write Set_Size;
    property ToRollForward: WordBool read Get_ToRollForward write Set_ToRollForward;
    property IsRollForwarded: WordBool read Get_IsRollForwarded write Set_IsRollForwarded;
  end;

// *********************************************************************//
// Interface: IAddinDocReturnHandler
// Flags:     (0)
// GUID:      {7750B091-3C0C-45F2-BDE2-D93E4E3D2CBE}
// *********************************************************************//
  IAddinDocReturnHandler = interface(IUnknown)
    ['{7750B091-3C0C-45F2-BDE2-D93E4E3D2CBE}']
    procedure Execute(const aDocReturn: IAppDocReturn); safecall;
  end;

// *********************************************************************//
// Interface: IAddinDocReturnChangeHandler
// Flags:     (0)
// GUID:      {9A0C7B01-FC01-4225-97D8-6093E2E4CDF0}
// *********************************************************************//
  IAddinDocReturnChangeHandler = interface(IUnknown)
    ['{9A0C7B01-FC01-4225-97D8-6093E2E4CDF0}']
    procedure Execute(const AOldDocReturn: IAppDocReturn; const NewDocReturn: IAppDocReturn); safecall;
  end;

// *********************************************************************//
// Interface: IAddinCalcDiagnosticHandler
// Flags:     (0)
// GUID:      {80785E13-C93D-41BD-8759-7679E29693BE}
// *********************************************************************//
  IAddinCalcDiagnosticHandler = interface(IUnknown)
    ['{80785E13-C93D-41BD-8759-7679E29693BE}']
    function Execute(const aDocReturn: IAppDocReturn; AGroupNo: Integer; const ADiagName: WideString): WordBool; safecall;
  end;

// *********************************************************************//
// Interface: IAddinDiagnosticClickHandler
// Flags:     (0)
// GUID:      {44087D3A-E50D-4D91-A795-84543820C568}
// *********************************************************************//
  IAddinDiagnosticClickHandler = interface(IUnknown)
    ['{44087D3A-E50D-4D91-A795-84543820C568}']
    procedure Execute(const aDocReturn: IAppDocReturn; ADiagGroup: Integer; 
                      const ADiagName: WideString); safecall;
  end;

// *********************************************************************//
// Interface: IAppAddinCustomDiagnostic
// Flags:     (0)
// GUID:      {C64F2E0E-FA6A-4CA9-97FB-1DC933F8A1D0}
// *********************************************************************//
  IAppAddinCustomDiagnostic = interface(IUnknown)
    ['{C64F2E0E-FA6A-4CA9-97FB-1DC933F8A1D0}']
    procedure RegisterAddinDiagnostic(AGroupNo: Integer; ADiagType: Integer; 
                                      const AName: WideString; const AEnglishText: WideString; 
                                      const AFrenchText: WideString; AJurisdiction: AppJuridiction; 
                                      AApplicable: WordBool); safecall;
    procedure UnRegisterAddinDiagnostic(AGroupNo: Integer; const AName: WideString); safecall;
    procedure UnRegisterAllAddinDiagnostic; safecall;
  end;

implementation

uses ComObj;

end.
