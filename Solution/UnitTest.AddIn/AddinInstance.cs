using System;
using TaxprepAddinAPI;
using WKCA.AddIn;
using WKCA.UnitTest;
using WKCA.UnitTest.Test;

namespace WKCA
{
    [AddinInstance]
    public class AddinInstance : AddinInstanceBase
    {
        public AddinInstance()
            : base(new Guid("EEAC0C48-F6B1-4865-B60A-8304F6F10ABF"), "Unit Testing AddIn", "1.0.0.0")
        {
        }

        public override void ReleaseApp()
        {
            base.ReleaseApp();
            // do nothing
        }

        public override void InitializeTaxPrepAddin()
        {
            try
            {
                var lMenuService = (IAppMenuService) _appInstance;

                var lRootMenu = lMenuService.AddRootMenu("Unit Test AddIn");
                lRootMenu.Visible = true;
                lRootMenu.Enabled = true;

                MenuTests.InitTestEvents(lRootMenu, true);
                ModuleManagerTests.InitTestEvents(_appInstance);
                TaxApplicationTests.InitTestEvents(_appInstance);

                TestHost.AddTestMenu(_appInstance, lRootMenu, true);
            }
            catch (Exception)
            {
                ReleaseApp();
                throw;
            }
        }
    }
}