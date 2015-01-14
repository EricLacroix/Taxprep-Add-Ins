using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;
using WKCA.AddIn.Handlers.ModuleManager;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ModuleManagerTests
    {
        private static int AfterCurrentModuleChangeCount { get; set; }
        private static int BeforeCurrentModuleChangeCount { get; set; }

        private IAppInstance AppInstance { get; set; }

        public static void InitTestEvents(IAppInstance aAppInstance)
        {
            var lService = (IAppModuleManager) aAppInstance;

            lService.BeforeCurrentModuleChange = new NotifyHandler(aModule => BeforeCurrentModuleChangeCount++);
            lService.AfterCurrentModuleChange = new NotifyHandler(aModule => AfterCurrentModuleChangeCount++);
        }

        [TestInitialize]
        public void Init()
        {
            AppInstance = TestHost.CurrentInstance.AppInstance;
        }

        [TestCleanup]
        public void CleanUp()
        {
            AppInstance = null;
        }

        [TestMethod]
        public void TestModuleManager()
        {
            var manager = (IAppModuleManager) AppInstance;
            var testHandler = new NotifyHandler(null);
// ReSharper disable once JoinDeclarationAndInitializer
            IAddinModuleManagerNotifyHandler oldHandler;

            // just read CurrentModule 
            Assert.IsTrue(manager.CurrentModule != null, "Unassigned CurrentModule");

            // test BeforeCurrentModuleChange
            oldHandler = manager.BeforeCurrentModuleChange;
            manager.BeforeCurrentModuleChange = testHandler;
            Assert.IsTrue(manager.BeforeCurrentModuleChange == testHandler, "Cannot Set BeforeCurrentModuleChange");
            manager.BeforeCurrentModuleChange = null;
            Assert.IsTrue(manager.BeforeCurrentModuleChange == null, "Cannot Set BeforeCurrentModuleChange");
            manager.BeforeCurrentModuleChange = oldHandler;
            Assert.IsTrue(manager.BeforeCurrentModuleChange == oldHandler, "Cannot restore BeforeCurrentModuleChange");
            Assert.IsTrue(BeforeCurrentModuleChangeCount > 0, "BeforeCurrentModuleChange handler has not been executed");

            // test AfterCurrentModuleChange
            oldHandler = manager.AfterCurrentModuleChange;
            manager.AfterCurrentModuleChange = testHandler;
            Assert.IsTrue(manager.AfterCurrentModuleChange == testHandler, "Cannot Set AfterCurrentModuleChange");
            manager.AfterCurrentModuleChange = null;
            Assert.IsTrue(manager.AfterCurrentModuleChange == null, "Cannot Set AfterCurrentModuleChange");
            manager.AfterCurrentModuleChange = oldHandler;
            Assert.IsTrue(manager.AfterCurrentModuleChange == oldHandler, "Cannot estore AfterCurrentModuleChange");
            Assert.IsTrue(AfterCurrentModuleChangeCount > 0, "AfterCurrentModuleChange handler has not been executed");
        }

        [TestMethod]
        public void TestModule()
        {
            var module = ((IAppModuleManager) AppInstance).CurrentModule;

            // just read the properies
            Assert.IsTrue(module.Name != string.Empty, "Empty Name");
            Assert.IsTrue(module.TitleName != string.Empty, "Empty TitleName");
            Assert.IsTrue(module.TitleButtonName != string.Empty, "Empty TitleButtonName");
        }
    }
}