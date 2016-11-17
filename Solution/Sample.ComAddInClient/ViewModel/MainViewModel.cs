using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using NLog;
using Sample.ComAddInClient.Services;
using TaxprepAddinAPI;
using WKCA.Com.Utils;

namespace Sample.ComAddInClient.ViewModel
{

    public class MainViewModel : ViewModelBase
    {
        private IAppInstance _appInstance;
        private readonly SampleUIService _uiService;

        private string _status;
        private string _exceptionMessage;
        
        private static Logger _logger;
      
        public MainViewModel()
        {
            _uiService = new SampleUIService();
            _logger = LogManager.GetCurrentClassLogger();
            Status = "Not connected";
            TaxPrepFileName = "T1Txp2015.exe";
            ConnectComAddIn = new RelayCommand(ConnectComAddInExecute, () => Status == "Not connected");
        }

        public string TaxPrepFileName { get; set; }

        public string Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                RaisePropertyChanged();
            }
        }

        public string ExceptionMessage
        {
            get
            {
                return _exceptionMessage;
            }
            set
            {
                _exceptionMessage = value;
                RaisePropertyChanged();
            }
        }

        public RelayCommand ConnectComAddIn { get; set; }

        public async void ConnectComAddInExecute()
        {
            _logger.Log (LogLevel.Trace, "Start connection to COM Add-In");
            try
            {
                Status = "Connecting...";
                await Task.Factory.StartNew(GetTaxPrepApp);
                var appTitle = ((_appInstance) as IAppTaxApplicationService).GetTitleName();
                Status = string.Format($"Connected to {appTitle}");
                _logger.Log(LogLevel.Trace, "Connected to COM Add-In");
                _uiService.Init(_appInstance);
            }
            catch (Exception ex)
            {
                Status = "Connection failed";
                ExceptionMessage = ex.Message;
                _logger.Log(LogLevel.Fatal, ex);
            }
            ConnectComAddIn.RaiseCanExecuteChanged();
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
        /// Uses GUID to create COM object. If COM object is registered in the registry corresponding process will be started automatically.
        /// If COM object is not registered in the registry, but corresponding process is already running will connect to this process.
        /// </summary>
        private void GetTaxPrepAppUsingGuid()
        {
            var helper = new ComRegistrationHelper();
            var guidTemplate = ConfigurationManager.AppSettings["TaxPrepComGuidTemplate"];
            var guid = helper.CreateApplicationSpecificGuidFromTemplate(guidTemplate, TaxPrepFileName);
            var type = Type.GetTypeFromCLSID(guid, true);
            dynamic comAccessProvider = Activator.CreateInstance(type);

            dynamic appInstance = comAccessProvider.GetAppInstance();
            _appInstance = (IAppInstance)appInstance;
        }

        /// <summary>
        /// Uses ProgId to create COM object. If COM object is registered in the registry corresponding process will be started automatically.
        /// If COM object is not registered in the registry, fails to connect even if corresponding process is running.
        /// </summary>
        private void GetTaxPrepAppUsingProgId()
        {
            var helper = new ComRegistrationHelper();
            var typeName = ConfigurationManager.AppSettings["TaxPrepComTypeName"];
            var progId = helper.GetProgId(TaxPrepFileName, typeName);
            var type = Type.GetTypeFromProgID(progId);
            dynamic comAccessProvider = Activator.CreateInstance(type);

            dynamic appInstance = comAccessProvider.GetAppInstance();
            _appInstance = (IAppInstance)appInstance;
        }
    }
}