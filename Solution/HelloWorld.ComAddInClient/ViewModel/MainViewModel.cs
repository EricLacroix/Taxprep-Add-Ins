using System;
using System.Configuration;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NLog;
using TaxprepAddinAPI;
using WKCA.Com.Utils;

namespace HelloWorld.ComAddInClient.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private static Logger _logger;
        private IAppInstance _appInstance;
        private string _exceptionMessage;

        private string _status;

        public MainViewModel()
        {
            _logger = LogManager.GetCurrentClassLogger();
            Status = "Not connected";
            TaxPrepFileName = "T1Txp2015.exe";
            ConnectComAddIn = new RelayCommand(ConnectComAddInExecute, () => Status == "Not connected");
            ShowMessage = new RelayCommand(ShowMessageExecute, () => Status.StartsWith("Connected"));
            DisconnectComAddIn = new RelayCommand(DisconnectComAddInExecute, () => Status.StartsWith("Connected"));
        }

        public string TaxPrepFileName { get; set; }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        public string ExceptionMessage
        {
            get { return _exceptionMessage; }
            set
            {
                _exceptionMessage = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand ConnectComAddIn { get; set; }
        public RelayCommand DisconnectComAddIn { get; set; }
        public RelayCommand ShowMessage { get; set; }

        public async void ConnectComAddInExecute()
        {
            _logger.Log(LogLevel.Trace, "Start connection to COM Add-In");
            try
            {
                Status = "Connecting...";
                await Task.Factory.StartNew(GetTaxPrepApp);
                var appTitle = ((_appInstance) as IAppTaxApplicationService).GetTitleName();
                Status = string.Format($"Connected to {appTitle}");
                _logger.Log(LogLevel.Trace, "Connected to COM Add-In");
            }
            catch (Exception ex)
            {
                Status = "Connection failed";
                ExceptionMessage = ex.Message;
                _logger.Log(LogLevel.Fatal, ex);
            }
            ConnectComAddIn.RaiseCanExecuteChanged();
            ShowMessage.RaiseCanExecuteChanged();
            DisconnectComAddIn.RaiseCanExecuteChanged();
        }

        public void ShowMessageExecute()
        {
            _logger.Log(LogLevel.Trace, "ShowMessageExecute called");
            try
            {
                _appInstance.AddLog("Hello world");
            }
            catch (Exception ex)
            {
                ExceptionMessage = ex.Message;
                _logger.Log(LogLevel.Fatal, ex);
            }
        }

        public void DisconnectComAddInExecute()
        {
            Marshal.ReleaseComObject(_appInstance);
            _appInstance = null;

            Status = "Not connected";
            ConnectComAddIn.RaiseCanExecuteChanged();
            ShowMessage.RaiseCanExecuteChanged();
            DisconnectComAddIn.RaiseCanExecuteChanged();
        }

        private void GetTaxPrepApp()
        {
            if (_appInstance != null)
            {
                return;
            }

            GetTaxPrepAppUsingGuid();
            //GetTaxPrepAppUsingProgId();
        }

        /// <summary>
        ///     Uses GUID to create COM object. If COM object is registered in the registry corresponding process will be started
        ///     automatically.
        ///     If COM object is not registered in the registry, but corresponding process is already running will connect to this
        ///     process.
        /// </summary>
        private void GetTaxPrepAppUsingGuid()
        {
            var helper = new ComRegistrationHelper();
            var guidTemplate = ConfigurationManager.AppSettings["TaxPrepComGuidTemplate"];
            var guid = helper.CreateApplicationSpecificGuidFromTemplate(guidTemplate, TaxPrepFileName);
            var type = Type.GetTypeFromCLSID(guid, true);
            dynamic comAccessProvider = Activator.CreateInstance(type);

            dynamic appInstance = comAccessProvider.GetAppInstance();
            _appInstance = (IAppInstance) appInstance;

            Marshal.ReleaseComObject(comAccessProvider);
        }

        /// <summary>
        ///     Uses ProgId to create COM object. If COM object is registered in the registry corresponding process will be started
        ///     automatically.
        ///     If COM object is not registered in the registry, fails to connect even if corresponding process is running.
        /// </summary>
        private void GetTaxPrepAppUsingProgId()
        {
            var helper = new ComRegistrationHelper();
            var typeName = ConfigurationManager.AppSettings["TaxPrepComTypeName"];
            var progId = helper.GetProgId(TaxPrepFileName, typeName);
            var type = Type.GetTypeFromProgID(progId);
            dynamic comAccessProvider = Activator.CreateInstance(type);

            dynamic appInstance = comAccessProvider.GetAppInstance();
            _appInstance = (IAppInstance) appInstance;
        }
    }
}