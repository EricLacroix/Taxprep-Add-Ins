using System;
using TaxprepAddinAPI;
using WKCA.AddIn;
using WKCA.AddIn.Handlers;

namespace WKCA
{
    [AddinInstance]
    public class AddinInstance : AddinInstanceBase
    {
        public AddinInstance()
            : base(new Guid("26A2ECE8-ED75-47B9-8797-32B3C0D227A7"), "Hello World AddIn",
                "1.0.0.0")
        {
            //some class initizalition code
        }

        public override void ReleaseApp()
        {
            base.ReleaseApp();
            //some finalization code
        }

        public override void InitializeTaxPrepAddin()
        {
            var appMenuService = (IAppMenuService) _appInstance;
            if (appMenuService != null)
            {
                var subMenu = appMenuService.AddRootMenu("Hello World AddIn");
                subMenu.Visible = true;

                var item = subMenu.AddItem("Hello world", false);
                item.ClickHandler = new AppNotifyHandler(DoHelloWorld);
                item.Visible = true;
                item.Enabled = true;
            }
        }

        private void DoHelloWorld()
        {
            var app = (IAppTaxApplicationService) _appInstance;
            app.ShowMessageString("Echo", "Hello world!");
        }
    }
}