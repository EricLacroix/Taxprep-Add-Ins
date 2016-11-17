using System;
using System.Configuration;
using TaxprepAddinAPI;
using WKCA.Com.Utils;
using WKCA.UnitTest;
using WKCA.UnitTest.Test;

namespace UnitTest.ComAddIn
{
    class Program
    {
        private static IAppInstance _appInstance;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting COM AddIn unit test");
            GetTaxPrepAppUsingGuid();
            var lMenuService = (IAppMenuService)_appInstance;

            var lRootMenu = lMenuService.AddRootMenu("Com AddIn Unit Test");
            lRootMenu.Visible = true;
            lRootMenu.Enabled = true;

            MenuTests.InitTestEvents(lRootMenu, true);
            ModuleManagerTests.InitTestEvents(_appInstance);
            TaxApplicationTests.InitTestEvents(_appInstance);

            TestHost.AddTestMenu(_appInstance, lRootMenu, true);
            Console.WriteLine("Select 'Com AddIn Unit Test > Run Unit Tests' from TaxPrep menu");
            Console.WriteLine("Press any key when to exit");
            Console.ReadKey();
        }

        private static void GetTaxPrepAppUsingGuid()
        {
            var helper = new ComRegistrationHelper();
            var guidTemplate = ConfigurationManager.AppSettings["TaxPrepComGuidTemplate"];
            var taxPrepFileName = ConfigurationManager.AppSettings["TaxPrepFileName"];
            var guid = helper.CreateApplicationSpecificGuidFromTemplate(guidTemplate, taxPrepFileName);
            var type = Type.GetTypeFromCLSID(guid, true);
            dynamic comAccessProvider = Activator.CreateInstance(type);

            dynamic appInstance = comAccessProvider.GetAppInstance();
            _appInstance = (IAppInstance)appInstance;
        }
    }
}
