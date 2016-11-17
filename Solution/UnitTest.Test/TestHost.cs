using System.Reflection;
using TaxprepAddinAPI;
using WKCA.UnitTest.Host;

// ReSharper disable once CheckNamespace

namespace WKCA.UnitTest
{
    //singleton
    public class TestHost : IAddinNotifyHandler
    {
        private TestHost(IAppInstance aAppInstance, Assembly aAssemblyWithTests)
        {
            TestAssembly = aAssemblyWithTests;
            AppInstance = aAppInstance;
        }

        public Assembly TestAssembly { get; }
        public IAppInstance AppInstance { get; private set; }

        public static TestHost CurrentInstance { get; private set; }

        //show the menu item
        public void Execute()
        {
            var oldInstance = CurrentInstance;
            CurrentInstance = this;
            try
            {
                var lRunnerForm = new TestRunner(TestAssembly);
                lRunnerForm.ShowDialog();
            }
            finally
            {
                CurrentInstance = oldInstance;
            }
        }

        public static void AddTestMenu(IAppInstance aAppInstance, Assembly aAssemblyWithTests,
            IAppSubMenu aParentSubMenu, bool aSeparatorBefore)
        {
            var lMenuItem = aParentSubMenu.AddItem("Run Unit Tests", aSeparatorBefore);
            lMenuItem.ClickHandler = new TestHost(aAppInstance, aAssemblyWithTests);
            lMenuItem.Visible = true;
            lMenuItem.Enabled = true;
        }

        public static void AddTestMenu(IAppInstance aAppInstance, IAppSubMenu aParentSubMenu, bool aSeparatorBefore)
        {
            AddTestMenu(aAppInstance, Assembly.GetExecutingAssembly(), aParentSubMenu, aSeparatorBefore);
        }
    }
}