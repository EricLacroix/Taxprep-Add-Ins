using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows;
using NLog;
using TaxprepAddinAPI;
using WKCA.AddIn.Handlers;
using WKCA.AddIn.Handlers.ClientFile;
using WKCA.AddIn.Handlers.Configuration;
using WKCA.AddIn.Handlers.DatabaseEnv;
using WKCA.AddIn.Handlers.Diagnostic;
using WKCA.AddIn.Handlers.DragDrop;
using WKCA.AddIn.Handlers.ModuleManager;
using WKCA.Sample;

namespace Sample.ComAddInClient.Services
{
    class SampleUIService
    {
        private IAppMenuItem _testMenuItem;
        private IAppSubMenu _testSubMenu;
        private IAppInstance _appInstance;
        private bool CustomDiagOn = true;
        private static Logger m_logger;
        private static string m_version = Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public SampleUIService()
        {
            m_logger = LogManager.GetCurrentClassLogger();
        }

        public void Init(IAppInstance appInstance)
        {
            _appInstance = appInstance;

            var menuName = string.Format("Sample COM Add-In v{0}", m_version);
            InitMenu(menuName);
            InitClientFileEvents();
            InitCustomDiagnostic();
            InitDatabaseEnvEvents();
          //  InitDragDrop();
            InitModuleManager();
            InitApplicationEvents();

        }

        #region Event handlers


        private void DoHelloWorld()
        {
            MessageBox.Show("Hello world");
        }

        private void DoAppProperties()
        {
            IAppTaxApplicationService aApplication = (IAppTaxApplicationService)_appInstance;
            AppProperiesForm.ShowProperties(aApplication);
        }

        private void DoClientFileProperties()
        {
            IAppClientFileManagerService aManager = (IAppClientFileManagerService)_appInstance;
            IAppClientFile aFile = aManager.GetCurrentClientFile();

            if (aFile == null)
                MessageBox.Show("Please Open a Client File first");
            else
                ClientFileProperties.ShowProperties(aFile);
        }

        private void DoAfterClientFileSave(string aFileName)
        {
            m_logger.Log(LogLevel.Trace, "ClientFileSaveHandler {0}", aFileName);
        }

        private void DoAfterClientFileNameChange(string aFileName)
        {
            m_logger.Log(LogLevel.Trace, "AfterClientFileNameChange {0}", aFileName);
        }

        private void DoAfterChangeClientFileHeaderProperty(string aClientFileHeaderKey)
        {
            m_logger.Log(LogLevel.Trace, "AfterChangeClientFileHeaderProperty {0}", aClientFileHeaderKey);
        }

        private void DoAfterCurrentDocumentChange(IAppTaxDocument aDocument)
        {
            m_logger.Log(LogLevel.Trace, "AfterCurrentDocumentChange");
        }

        private void DoAfterDocumentAdd(IAppTaxDocument aDocument)
        {
            m_logger.Log(LogLevel.Trace, "AfterDocumentAdd");
        }

        private void DoAfterDocumentRemove(IAppTaxDocument aDocument)
        {
            m_logger.Log(LogLevel.Trace, "AfterDocumentRemove");
        }

        private void DoBeforeClientFileNameChange(string aOldFileName, string aNewFileName)
        {
            m_logger.Log(LogLevel.Trace, "BeforeClientFileNameChange AOldFilename = {0}, ANewFileName = {1}",
                 aOldFileName, aNewFileName);
        }

        private void DoBeforeClientFileSave(string aFileName, out bool aAccept)
        {
            m_logger.Log(LogLevel.Trace, "BeforeClientFileSave {0}", aFileName);
            aAccept = true;
        }

        private void DoAfterLanguageChange()
        {
            m_logger.Log(LogLevel.Trace, "After language change");
        }

        private void DoBeforeLanguageChange()
        {
            m_logger.Log(LogLevel.Trace, "Before language change");
        }

        private void DoCurrentCell()
        {
            var LTaxpApp = (IAppTaxApplicationService)_appInstance;
            var LCell = LTaxpApp.GetCurrentTaxCell();
            if (LCell == null)
            {
                MessageBox.Show("Current cell is not assigned");
                return;
            }
            CellPropertieForm.ShowCellProperties(LCell, LTaxpApp);
        }

        private void DoReturnStatuses()
        {
            var LTaxApp = (IAppTaxApplicationService)_appInstance;
            var LReturn = LTaxApp.GetCurrentDocReturn();

            if (LReturn == null)
                MessageBox.Show("Please Open a Client File first");
            else
                ReturnProperties.ShowReturnproperties(LReturn);
        }

        private void DoBeforeCurrentDocumentChange(IAppTaxDocument OldDocument, IAppTaxDocument NewDocument)
        {
            m_logger.Log(LogLevel.Trace, "BeforeCurrentDocumentChange");
        }

        private void DoBeforeDocumentAdd(IAppTaxDocument aDocument)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeDocumentAdd: '{0}'", aDocument.DocName);
        }

        private void DoBeforeDocumentRemove(IAppTaxDocument aDocument)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeDocumentRemove: '{0}'", aDocument.DocName);
        }

        private void DoBeforeReturnStatusChange(IAppDocReturn aDocReturn, string AStatusName, int aOldValue, int AValue)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeReturnStatusChange status '{0}' from '{1}' to '{2}'", AStatusName, aOldValue, AValue);
        }

        private void DoAfterClientFileAdd(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "AfterClientFileAdd : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());
        }

        private bool DoCanCloseClientFile(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoCanCloseClientFile : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());

            return true;
        }

        private void DoAfterClientFileRemove(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoAfterClientFileRemove : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());
        }

        private void DoBeforeClientFileRemove(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeClientFileRemove : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());
        }

        private void DoBeforeClientFileAdd(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeClientFileAdd : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());
        }

        private void DoAfterCurrentClientFileChange(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoAfterCurrentClientFileChange : ClientFile {0}", aClientFile == null ? "NULL" : aClientFile.GetGUID());
        }

        private void DoBeforeCurrentClientFileChange(IAppClientFile AOldClientFile, IAppClientFile ANewClientFile)
        {
            m_logger.Log(LogLevel.Trace, "DoBeforeCurrentClientFileChange : AOldClientFile {0}, ANewClientFile {1}", AOldClientFile == null ? "NULL" : AOldClientFile.GetGUID(),
                ANewClientFile == null ? "NULL" : ANewClientFile.GetGUID());
        }

        private void DoOnBeforeOpenClientFile(IAppClientFile aClientFile)
        {
            m_logger.Log(LogLevel.Trace, "Before open document, AClientFile : {0}", aClientFile.GetGUID());
        }

        private void DoOnUpdateDatabaseFromReturnHeader(IAppDocReturn Document)
        {
            m_logger.Log(LogLevel.Trace, "DoOnUpdateDatabaseFromReturnHeader : AReturnId={0}", Document.GetReturnId());
        }

        private void DoOnSaveReturnHeader(IAppDocReturn Document)
        {
            m_logger.Log(LogLevel.Trace, "DoOnSaveReturnHeader : AReturnId={0}", Document.GetReturnId());
        }

        private void DoOnUpdateReturnHeader(IAppDocReturn Document)
        {
            m_logger.Log(LogLevel.Trace, "DoOnUpdateReturnHeader : AReturnId={0}", Document.GetReturnId());
        }

        private void DoOnCheckHeaderAlias(IAppDocReturn Document)
        {
            m_logger.Log(LogLevel.Trace, "DoOnCheckHeaderAlias : AReturnId={0}", Document.GetReturnId());
        }

        private void DoAfterAcceptUserInput(IAppTaxCell aCell)
        {
            m_logger.Log(LogLevel.Trace, aCell.GetCellNameWithGroup());
        }

        private void DoAfterAddRepeat(IAppGroupArray aGroup)
        {
            m_logger.Log(LogLevel.Trace, "DbEnv.AfterAddRepeat");
        }

        private void DoAfterCalc(IAppDocReturn aReturn)
        {
            m_logger.Log(LogLevel.Trace, "DbEnv.DoAfterCalc");
        }

        private void DoAfterCalcGlobalRates()
        {
            m_logger.Log(LogLevel.Trace, "DbEnv.AfterCalcGlobalRates");
        }

        private void DoAfterDeleteRepeat(IAppGroupArray aGroup)
        {
            m_logger.Log(LogLevel.Trace, "DbEnv.AfterDeleteRepeat");
        }

        private void DoBeforeCalc(IAppDocReturn aReturn)
        {
            m_logger.Log(LogLevel.Trace, "DbEnv.BeforeCalc");
        }

        private void DoTriggerAddinException()
        {
            throw new Exception("Addin-triggered exception");
        }

        private void DoTriggerAppException()
        {
            var lTesting = (IAppTesting)_appInstance;
            lTesting.TestRaiseError("Test message 1");
        }

#if (EmulateDragAndDropError)
        string sOld;
#endif
        private dynamic DoGetUnicodeTextDragDropData(IAppCellSelectionIter aSelection)
        {
            var lText = "[";
            aSelection.First();
            while (!aSelection.IsDone())
            {
#if (EmulateDragAndDropError)
                if (!string.IsNullOrEmpty(sOld) && sOld != aSelection.Current().GetFieldCellPath(false))
                {
                    throw new Exception("bad field");
                }
                sOld = aSelection.Current().GetFieldCellPath(false);
#endif
                lText += '"' + aSelection.Current().GetFieldCellPath(false) + '"';
                aSelection.Next();
                if (!aSelection.IsDone())
                    lText += ',';
            }
            lText += ']';

            lText = '{' + string.Format("name:\"WKCA.Sample\",cells:{0}", lText) + "}\0";

            return System.Text.Encoding.Unicode.GetBytes(lText);
        }

        private void DoQueryComplexData()
        {
            var LApplication = (IAppTaxApplicationService)_appInstance;
            if (LApplication.GetCurrentTaxData() == null)
                MessageBox.Show("Please Open a Client File first");
            else
            {
                using (var form = new WKCA.Sample.QueryComplexDataForm())
                {
                    form.LoadData(LApplication.GetCurrentTaxData());
                    form.ShowDialog();
                }
            }

        }

        private void DoCurrentModuleInfo()
        {
            var lMsg = "(none)";
            var lModule = ((IAppModuleManager)_appInstance).CurrentModule;
            if (lModule != null)
                lMsg = string.Format("Name: '{0}'\r\nTitleName: '{1}'\r\nTitleButtonName: '{2}'",
                    lModule.Name, lModule.TitleName, lModule.TitleButtonName);

            MessageBox.Show(lMsg);
        }


        private void DoShowUnlockCodeEfile()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LConfig = LApp.Configuration;
            int LEfileType = LConfig.AsInteger("Application", "EFILEType", 0);
            var LEFileUnlock = LApp.GetStringWithLanguage("\\Unlock\\EFILE\\", LEfileType.ToString(), LApp.GetDefaultLanguage());
            MessageBox.Show(string.IsNullOrEmpty(LEFileUnlock) ? "No efile unlock code assigned" : LEFileUnlock);
        }

        private void DoShowUnlockKey()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LConfig = LApp.Configuration;
            var LKey = LConfig.AsString("Application", "UnlockKey", "");
            MessageBox.Show(string.Format("{0}\n The code is copied to clipboard", string.IsNullOrEmpty(LKey) ? "No unlock key assigned" : LKey));
            Clipboard.SetText(LKey);
        }

        private void DoShowUniqueID()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LKey = LApp.GetMachineIdentifier();
            MessageBox.Show(string.Format("{0}\n The Unique ID is copied to clipboard", string.IsNullOrEmpty(LKey) ? "No unlock key assigned" : LKey));
            Clipboard.SetText(LKey);
        }

        private void DoShowUnlockCodeNetwork()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LConfig = LApp.Configuration;
            int LNetworkType = LConfig.AsInteger("Application", "NetworkType", 0);
            string networkOption = LApp.GetStringWithLanguage("\\Unlock\\Network", LNetworkType.ToString(), LApp.GetDefaultLanguage());
            MessageBox.Show(string.IsNullOrEmpty(networkOption) ? "No network unlock code assigned" : networkOption);
        }

        private void DoAddConfigurationSection(string aSectionName)
        {
            m_logger.Log(LogLevel.Trace, "Add the configuration section {0}", aSectionName);
        }

        private void DoRemoveConfigurationSection(string aSectionName)
        {
            m_logger.Log(LogLevel.Trace, "Remove the configuration section {0}", aSectionName);
        }

        private void DoModifyKey(string aLevel, string aSection, string aKey, string AValue)
        {
            m_logger.Log(LogLevel.Trace, "Modify the configuration key Level: {3}, Section: {0}, Key: {1}, NewValue: {2}",
                aSection, aKey, AValue, aLevel);
        }

        private void DoConfigurationDemo()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LConfig = LApp.Configuration;
            WKCA.Sample.ConfigurationDemo.ShowConfiguration(LConfig);
        }

        private void DoDiagDemo()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;

            if (LApp.GetClientFileManager().GetCurrentClientFile() == null)
                MessageBox.Show("Please Open a Client File first");
            else
            {
                var LDiag = LApp.GetClientFileManager().GetCurrentClientFile().GetCurrentReturn().GetDiagnostic();
                WKCA.Sample.Diagnotics.ShowDiagnostic(LDiag);
            }

        }

        private void DoUFLDemo()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LUFL = LApp.UFL;
            var LCurrentReturn = LApp.GetCurrentDocReturn();

            if (LCurrentReturn == null)
                MessageBox.Show("Please Open a Client File first");
            else
            {
                WKCA.Sample.UFLDemo.ShowUFL(LUFL, LCurrentReturn);
            }
        }

        private void DoClientLettersDemo()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            var LCLManager = LApp.ClientLetterManager;
            var LUFL = LApp.UFL;
            var LCurrentReturn = LApp.GetCurrentDocReturn();

            if (LCurrentReturn == null)
                MessageBox.Show("Please Open a Client File first");
            else
            {
                WKCA.Sample.ClientLettersDemo.ShowDemo(LCLManager, LCurrentReturn, LUFL);
            }

        }

        private void DoCursorDemo()
        {
            var LApp = (IAppTaxApplicationService)_appInstance;
            WKCA.Sample.CursorDemo.Display(LApp);
        }

        private void DoOpenClientFileDemo()
        {
            string lFileName;
            AppClientFileOpenOptions options = WKCA.Sample.OpenClientFile.RunOpenClientFile(out lFileName);
            if (string.IsNullOrEmpty(lFileName))
                return;
            var manager = (IAppClientFileManagerService)_appInstance;
            IAppClientFile cf;
            manager.OpenClientFile(lFileName, out cf, options);
            Debug.WriteLine(string.Format("Open client file {0}", cf.GetGUID()));
        }

        private void DoOpenClientFileDemoUiSilent()
        {
            string lFileName = WKCA.Sample.OpenFileSimple.Execute();
            if (!string.IsNullOrEmpty(lFileName))
            {
                var manager = (IAppClientFileManagerService)_appInstance;
                IAppClientFile cf;
                manager.OpenClientFileUISilent(lFileName, out cf);

                m_logger.Log(LogLevel.Trace, "Open client file {0}", cf.GetGUID());
            }
        }

        private void DoOpenClientFileDemoUiDefault()
        {
            string lFileName = WKCA.Sample.OpenFileSimple.Execute();
            if (!string.IsNullOrEmpty(lFileName))
            {
                var manager = (IAppClientFileManagerService)_appInstance;
                IAppClientFile cf;
                manager.OpenClientFileUIDefault(lFileName, out cf);

                m_logger.Log(LogLevel.Trace, "Open client file {0}", cf.GetGUID());
            }
        }

        private void DoAttachementDemo()
        {
            var application = (IAppTaxApplicationService)_appInstance;
            var docReturn = application.GetCurrentDocReturn();

            if (docReturn == null)
                MessageBox.Show("Please Open a Client File first");
            else if (docReturn is IAppDocReturn1)
                WKCA.Sample.Attachments.ShowDemo(docReturn as IAppDocReturn1);
            else
                MessageBox.Show("Attachment manager is not supported by current version of Taxprep");
        }

        private void DoBaundsDemo()
        {
            int x, y, width, heigh;
            uint handle;
            var app = (IAppTaxApplicationService)_appInstance;
            handle = app.getMainFormHandle();
            app.getMainMainFormsBaunds(out x, out y, out width, out heigh);
            MessageBox.Show(string.Format("Bounds x:{0}, y:{1}, width{2}, height{3}\nHandle {4}", x, y, width, heigh, handle));
        }


        private IAppMenuItem CreateMenuItem(IAppSubMenu aParent, string aCaption,
            AppNotifyHandler.ExecuteDelegate aOnExecute, bool aNewGroup = false)
        {
            var item = aParent.AddItem(aCaption, aNewGroup);
            item.Enabled = true;

            if (aOnExecute != null)
                item.ClickHandler = new AppNotifyHandler(aOnExecute);

            return item;
        }

        private void InitClientFileEvents()
        {
            var ClientFileEvents = (IAppClientFileEventsService)_appInstance;
            if (ClientFileEvents != null)
            {
                ClientFileEvents.AfterClientFileSave = new AfterSaveHandler(DoAfterClientFileSave);
                ClientFileEvents.AfterClientFileNameChange = new AfterChangeNameHandler(DoAfterClientFileNameChange);
                ClientFileEvents.AfterChangeClientFileHeaderProperty = new AfterChangeHeaderPropertyHandler(DoAfterChangeClientFileHeaderProperty);
                ClientFileEvents.AfterCurrentDocumentChange = new ClientFileNotifyWithDocumentHandler(DoAfterCurrentDocumentChange);
                ClientFileEvents.AfterDocumentAdd = new ClientFileNotifyWithDocumentHandler(DoAfterDocumentAdd);
                ClientFileEvents.AfterDocumentRemove = new ClientFileNotifyWithDocumentHandler(DoAfterDocumentRemove);
                ClientFileEvents.BeforeClientFileNameChange = new BeforeChangeNameHandler(DoBeforeClientFileNameChange);
                ClientFileEvents.BeforeClientFileSave = new BeforeSaveHandler(DoBeforeClientFileSave);
                ClientFileEvents.BeforeCurrentDocumentChange = new BeforeCurrentDocumentChangeHandler(DoBeforeCurrentDocumentChange);
                ClientFileEvents.BeforeDocumentAdd = new ClientFileNotifyWithDocumentHandler(DoBeforeDocumentAdd);
                ClientFileEvents.BeforeDocumentRemove = new ClientFileNotifyWithDocumentHandler(DoBeforeDocumentRemove);
                ClientFileEvents.BeforeReturnStatusChange = new BeforeReturnStatusChangeHandler(DoBeforeReturnStatusChange);
                var app = (IAppTaxApplicationService)_appInstance;
                var version = app.GetCalcVersion().Split('.');
                var majorVersion = Convert.ToInt32(version[0]);
                var buildVersion = Convert.ToInt32(version[3]);
                if ((majorVersion > 2014) || (buildVersion > 13))
                {
                    ClientFileEvents.BeforeCurrentClientFileChange = new ClientFileChangeHandler(DoBeforeCurrentClientFileChange);
                    ClientFileEvents.AfterCurrentClientFileChange = new ClientFileHandler(DoAfterCurrentClientFileChange);
                    ClientFileEvents.BeforeClientFileAdd = new ClientFileHandler(DoBeforeClientFileAdd);
                    ClientFileEvents.AfterClientFileAdd = new ClientFileHandler(DoAfterClientFileAdd);
                    ClientFileEvents.BeforeClientFileRemove = new ClientFileHandler(DoBeforeClientFileRemove);
                    ClientFileEvents.AfterClientFileRemove = new ClientFileHandler(DoAfterClientFileRemove);
                    ClientFileEvents.CanCloseClientFile = new ClientFileCanCloseHandler(DoCanCloseClientFile);
                    ClientFileEvents.OnCheckHeaderAlias = new DocReturnNotifyHandler(DoOnCheckHeaderAlias);
                    ClientFileEvents.OnUpdateReturnHeader = new DocReturnNotifyHandler(DoOnUpdateReturnHeader);
                    ClientFileEvents.OnSaveReturnHeader = new DocReturnNotifyHandler(DoOnSaveReturnHeader);
                    ClientFileEvents.OnUpdateDatabaseFromReturnHeader = new DocReturnNotifyHandler(DoOnUpdateDatabaseFromReturnHeader);
                    ClientFileEvents.OnBeforeOpenClientFile = new ClientFileHandler(DoOnBeforeOpenClientFile);
                }
            }
            var LApplication = (IAppTaxApplicationService)_appInstance;
            var LConfiguration = LApplication.Configuration;
            LConfiguration.AfterAddSection = new SectionAddRemove(DoAddConfigurationSection);
            LConfiguration.AfterRemoveSection = new SectionAddRemove(DoRemoveConfigurationSection);
            LConfiguration.AfterModifyKey = new KeyModify(DoModifyKey);
        }

        private void InitApplicationEvents()
        {
            var app = (IAppTaxApplicationService)_appInstance;
            if (app is IAppTaxApplicationService1)
            {
                var app14 = app as IAppTaxApplicationService1;
                app14.OnBeforeLanguageChange = new AppNotifyHandler(DoBeforeLanguageChange);
                app14.OnAfterLanguageChange = new AppNotifyHandler(DoAfterLanguageChange);
            }
        }

        private void InitDatabaseEnvEvents()
        {
            var DBEnv = (IAppDatabaseEnvEventsService)_appInstance;
            if (DBEnv != null)
            {
                DBEnv.AfterAcceptUserInput = new AfterAcceptUserInput(DoAfterAcceptUserInput);
                DBEnv.AfterAddRepeat = new NotifyWithGroupArray(DoAfterAddRepeat);
                DBEnv.AfterCalc = new BeforeCalcHandler(DoAfterCalc);
                DBEnv.AfterCalcGlobalRates = new AppNotifyHandler(DoAfterCalcGlobalRates);
                DBEnv.AfterDeleteRepeat = new NotifyWithGroupArray(DoAfterDeleteRepeat);
                DBEnv.BeforeCalc = new BeforeCalcHandler(DoBeforeCalc);
                if (DBEnv is IAppDatabaseEnvEventsService1)
                {
                    var DBEnv1 = DBEnv as IAppDatabaseEnvEventsService1;

                    DBEnv1.OnCalcAddinDiag = new CalcAddinDiagHandler(DoCalcAddinDiag);
                    DBEnv1.OnDiagClick = new DiagnosticClickHandler(DoClickAddinDiag);
                }
            }
        }

        private void DoClickAddinDiag(IAppDocReturn aDocReturn, int ADiagGroup, string ADiagName)
        {
            MessageBox.Show("Click on custom diag " + ADiagName);
        }

        private bool DoCalcAddinDiag(IAppDocReturn aDocReturn, int AGroupNo, string ADiagName)
        {
            return (AGroupNo == 0 && ADiagName.Equals("MyUniqueDiagIdentification") && CustomDiagOn);
        }

        private void InitMenu(string menuName)
        {
            var appMenuService = (IAppMenuService)_appInstance;
            if (appMenuService != null)
            {
                var subMenu = appMenuService.AddRootMenu(menuName);
                subMenu.Visible = true;
                //subMenu.PopupHandler = new AppNotifyHandler(DoHelloWorld);

                var item = subMenu.AddItem("Click Me", false);
                item.ClickHandler = new AppNotifyHandler(DoHelloWorld);
                item.Visible = true;
                item.Enabled = true;



                var item3 = subMenu.AddItem("Application properties...", true);
                item3.ClickHandler = new AppNotifyHandler(DoAppProperties);
                item3.Visible = true;
                item3.Enabled = true;


                var itemConfig = subMenu.AddItem("Configuration read demo...", true);
                itemConfig.ClickHandler = new AppNotifyHandler(DoConfigurationDemo);
                itemConfig.Enabled = true;
                itemConfig.Visible = true;

                var itemUnlockCodeNetwork = subMenu.AddItem("Unlock code network", false);
                itemUnlockCodeNetwork.ClickHandler = new AppNotifyHandler(DoShowUnlockCodeNetwork);
                itemUnlockCodeNetwork.Enabled = true;
                itemUnlockCodeNetwork.Visible = true;

                var itemUnlockCodeEfile = subMenu.AddItem("Unlock code efile", false);
                itemUnlockCodeEfile.ClickHandler = new AppNotifyHandler(DoShowUnlockCodeEfile);
                itemUnlockCodeEfile.Enabled = true;
                itemUnlockCodeEfile.Visible = true;

                var itemUnlockKey = subMenu.AddItem("Unlock key", false);
                itemUnlockKey.ClickHandler = new AppNotifyHandler(DoShowUnlockKey);
                itemUnlockKey.Enabled = true;
                itemUnlockKey.Visible = true;

                var itemUniqueId = subMenu.AddItem("Unique ID", false);
                itemUniqueId.ClickHandler = new AppNotifyHandler(DoShowUniqueID);
                itemUniqueId.Enabled = true;
                itemUniqueId.Visible = true;

                CreateMenuItem(subMenu, "Current Module Name", DoCurrentModuleInfo, false);

                var item7 = subMenu.AddItem("Trigger exception from Add-In", true);
                item7.ClickHandler = new AppNotifyHandler(DoTriggerAddinException);
                item7.Enabled = true;
                item7.Visible = true;

                var item8 = subMenu.AddItem("Trigger exception from Application ", false);
                item8.ClickHandler = new AppNotifyHandler(DoTriggerAppException);
                item8.Enabled = true;
                item8.Visible = true;


                var item4 = subMenu.AddItem("Client file properties...", true);
                item4.ClickHandler = new AppNotifyHandler(DoClientFileProperties);
                item4.Enabled = true;
                item4.Visible = true;

                var itemUFL = subMenu.AddItem("Print Tax form...", false);
                itemUFL.ClickHandler = new AppNotifyHandler(DoUFLDemo);
                itemUFL.Enabled = true;
                itemUFL.Visible = true;

                var itemClientLetters = subMenu.AddItem("Client Letters...", false);
                itemClientLetters.ClickHandler = new AppNotifyHandler(DoClientLettersDemo);
                itemClientLetters.Enabled = true;
                itemClientLetters.Visible = true;

                var itemDiag = subMenu.AddItem("Diagnostic properties...", false);
                itemDiag.ClickHandler = new AppNotifyHandler(DoDiagDemo);
                itemDiag.Enabled = true;
                itemDiag.Visible = true;

                var item6 = subMenu.AddItem("Return statuses properties...", false);
                item6.ClickHandler = new AppNotifyHandler(DoReturnStatuses);
                item6.Enabled = true;
                item6.Visible = true;

                var item5 = subMenu.AddItem("Selected Cell properties...", false);
                item5.ClickHandler = new AppNotifyHandler(DoCurrentCell);
                item5.Enabled = true;
                item5.Visible = true;

                var itemAttachements = subMenu.AddItem("File Attachements...", false);
                itemAttachements.ClickHandler = new AppNotifyHandler(DoAttachementDemo);
                itemAttachements.Enabled = true;


                var item9 = subMenu.AddItem("Query complex data", false);
                item9.ClickHandler = new AppNotifyHandler(DoQueryComplexData);
                item9.Enabled = true;
                item9.Visible = true;

                var itemAddDiag = subMenu.AddItem("Toggle custom diagnostic", false);
                itemAddDiag.ClickHandler = new AppNotifyHandler(DoAddDiagDemo);
                itemAddDiag.Enabled = true;
                itemAddDiag.Visible = true;



                var itemCursorDemo = subMenu.AddItem("Hours glass cursor demo", true);
                itemCursorDemo.ClickHandler = new AppNotifyHandler(DoCursorDemo);
                itemCursorDemo.Enabled = true;
                itemCursorDemo.Visible = true;

                var itemBaunds = subMenu.AddItem("Application window information", false);
                itemBaunds.ClickHandler = new AppNotifyHandler(DoBaundsDemo);
                itemBaunds.Enabled = true;
                itemBaunds.Visible = true;
                itemBaunds.Visible = true;




                var itemOpenClientSubMenu = subMenu.AddSubMenu("Programatically Open", false);

                var itemOpenClientFile = itemOpenClientSubMenu.AddItem("Open client file demo", false);
                itemOpenClientFile.ClickHandler = new AppNotifyHandler(DoOpenClientFileDemo);
                itemOpenClientFile.Enabled = true;
                itemOpenClientFile.Visible = true;

                var itemOpenClientFileUiDefault = itemOpenClientSubMenu.AddItem("Open client file demo (UIDefault)", false);
                itemOpenClientFileUiDefault.ClickHandler = new AppNotifyHandler(DoOpenClientFileDemoUiDefault);
                itemOpenClientFileUiDefault.Enabled = true;
                itemOpenClientFileUiDefault.Visible = true;

                var itemOpenClientFileUiSilent = itemOpenClientSubMenu.AddItem("Open client file demo (UI Silent)", false);
                itemOpenClientFileUiSilent.ClickHandler = new AppNotifyHandler(DoOpenClientFileDemoUiSilent);
                itemOpenClientFileUiSilent.Enabled = true;
                itemOpenClientFileUiSilent.Visible = true;

                var testSubMenu = subMenu.AddSubMenu("Sub Menu", true);
                _testSubMenu = testSubMenu.AddSubMenu("SubMenu", false);
                _testSubMenu.AddItem("(empty)", false).Enabled = false;
                _testMenuItem = testSubMenu.AddItem("Menu Item", false);



                CreateMenuItem(testSubMenu, "Change 'Submenu' Enabled", () => _testSubMenu.Enabled = !_testSubMenu.Enabled, true);
                CreateMenuItem(testSubMenu, "Change 'Submenu' Visible", () => _testSubMenu.Visible = !_testSubMenu.Visible, false);

                CreateMenuItem(testSubMenu, "Change 'MenuItem' Enabled", () => _testMenuItem.Enabled = !_testMenuItem.Enabled, true);
                CreateMenuItem(testSubMenu, "Change 'MenuItem' Visible", () => _testMenuItem.Visible = !_testMenuItem.Visible, false);

            }
        }

        private void DoAddDiagDemo()
        {
            CustomDiagOn = !CustomDiagOn;
        }

        private void InitDragDrop()
        {
            const uint cfUnicodetext = 13; //CF_UNICODETEXT

            var appDragDrop = (IAppDragDropService)_appInstance;
            if (appDragDrop != null)
            {
                appDragDrop.RegisterDataFormat(cfUnicodetext, new DataFormatHandler(DoGetUnicodeTextDragDropData));
            }
        }


        private delegate string GetModuleName(IAppModule aModule);

        private void InitModuleManager()
        {
            var mn = (GetModuleName)(m => (m == null) ? "(none)" : m.Name);

            var lManager = (IAppModuleManager)_appInstance;

            lManager.BeforeCurrentModuleChange = new NotifyHandler(
                aModule => m_logger.Log(LogLevel.Trace, "Changing '{0}' module to '{1}'", mn(lManager.CurrentModule), mn(aModule)));

            lManager.AfterCurrentModuleChange = new NotifyHandler(
                aModule => m_logger.Log(LogLevel.Trace, "Module '{0}' is active now.", mn(aModule)));
        }

        private void InitCustomDiagnostic()
        {
            var app = (IAppTaxApplicationService)_appInstance;
            if (app is IAppTaxApplicationService1)
            {
                var app14 = app as IAppTaxApplicationService1;
                var diag = app14.GetCustomDiagnostic();
                diag.RegisterAddinDiagnostic(0, 0, "MyUniqueDiagIdentification", "Some Custom Diag with English Text", "Un diagnostique maison avec un texte francais", AppJuridiction.Const1, false);
            }
        }

        #endregion
    }
}
