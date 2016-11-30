using System;
using System.Diagnostics;
using System.Reflection;
using Com.AddIn.ComServer;
using NLog;
using WKCA.AddIn;
using WKCA.Com.Utils;

namespace Com.AddIn
{
    public class AddinInstance : AddinInstanceBase
    {
        private static readonly Logger Log = LogManager.GetCurrentClassLogger();
        private static readonly string _keyname = "COM.AddIn";

        public AddinInstance()
            : base(
                new Guid("4E14FF51-4703-4908-B3BD-E0BAFFEFFC8E"),
                "COM AddIn",
                Assembly.GetExecutingAssembly().GetName().Version.ToString())
        {
        }

        public static string KeyName
        {
            get { return _keyname; }
        }

        public static string AssemblyFullPath
        {
            get
            {
                var codeBase = Assembly.GetExecutingAssembly().CodeBase;
                var uri = new UriBuilder(codeBase);
                var path = Uri.UnescapeDataString(uri.Path);
                return path;
            }
        }


        public string GetAppName()
        {
            return _appInstance.AppName;
        }

        public override void InitializeTaxPrepAddin()
        {
            try
            {
                TaxPrepAppHelper.AppInstance = _appInstance;
                var helper = new ComRegistrationHelper();
                ComIds.CLSID_ComAccessProvider =
                    helper.CreateApplicationSpecificGuidFromTemplate(ComIds.CLSID_ComAccessProviderTemplate,
                        Process.GetCurrentProcess().MainModule.FileName);
                OutOfProcComServer.Instance.RegisterComClasses();
            }
            catch (Exception e)
            {
                Log.Fatal(e, "Failed to load Taxprep COM Add-in.");
                throw;
            }
        }

        public override void ReleaseApp()
        {
            OutOfProcComServer.Instance.UnRegisterComClasses();
            base.ReleaseApp();
        }
    }
}