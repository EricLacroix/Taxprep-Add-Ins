using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;
using WKCA.AddIn.Handlers;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class TaxApplicationTests
    {
        private IAppTaxApplicationService FApplication;
        private static int AppIdleCount { get; set; }

        public static void InitTestEvents(IAppInstance aAppInstance)
        {
            var lTaxAppService = (IAppTaxApplicationService) aAppInstance;
            lTaxAppService.OnIdle = new AppIdleHandler((out bool aProcessed) =>
            {
                AppIdleCount++;
                aProcessed = true;
            });
        }

        [TestInitialize]
        public void Init()
        {
            FApplication = (IAppTaxApplicationService) TestHost.CurrentInstance.AppInstance;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FApplication = null;
        }

        [TestMethod]
        public void TestIdleEvent()
        {
            Assert.IsTrue(AppIdleCount > 0, "OnIdle handler has not been executed");
        }

        [TestMethod]
        public void CanCloseClientFile()
        {
            var LManager = (IAppClientFileManagerService) TestHost.CurrentInstance.AppInstance;
            Assert.IsTrue(FApplication.CanCloseClientFile(LManager.GetCurrentClientFile()));
        }

        [TestMethod]
        public void GetClientFileManager()
        {
            Assert.IsNotNull(FApplication.GetClientFileManager());
        }

        [TestMethod]
        public void GetCurrentDocReturn()
        {
            Assert.IsNotNull(FApplication.GetCurrentDocReturn());
        }

        [TestMethod]
        public void GetCurrentDocument()
        {
            Assert.IsNotNull(FApplication.GetCurrentDocument());
        }

        [TestMethod]
        public void GetCurrentField()
        {
            Assert.IsNotNull(FApplication.GetCurrentField());
        }

        [TestMethod]
        public void GetCurrentTaxCell()
        {
            Assert.IsNotNull(FApplication.GetCurrentTaxCell());
        }

        [TestMethod]
        public void GetCurrentTaxData()
        {
            Assert.IsNotNull(FApplication.GetCurrentTaxData());
        }

        [TestMethod]
        public void GetCurrentTaxReturn()
        {
            Assert.IsNotNull(FApplication.GetCurrentTaxReturn());
        }

        [TestMethod]
        public void GetDefaultLanguage()
        {
            Assert.IsTrue(FApplication.GetDefaultLanguage() == AppLanguage.lFrench ||
                          FApplication.GetDefaultLanguage() == AppLanguage.lEnglish);
        }

        [TestMethod]
        public void GetExecutableName()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetExecutableName()));
        }

        [TestMethod]
        public void getIsCOMAvailable()
        {
            FApplication.getIsCOMAvailable();
        }

        [TestMethod]
        public void getIsDemo()
        {
            Assert.IsFalse(FApplication.getIsDemo());
        }

        [TestMethod]
        public void getIsEducative()
        {
            Assert.IsFalse(FApplication.getIsEducative());
        }

        [TestMethod]
        public void getIsEFILEGovernment()
        {
            FApplication.getIsEFILEGovernment();
        }

        [TestMethod]
        public void GetIsFirstExecution()
        {
            FApplication.GetIsFirstExecution();
        }

        [TestMethod]
        public void getIsNetWork()
        {
            FApplication.getIsNetWork();
        }

        [TestMethod]
        public void getIsNetworkAdvanced()
        {
            FApplication.getIsNetworkAdvanced();
        }

        [TestMethod]
        public void getIsNetworkRegular()
        {
            FApplication.getIsNetworkRegular();
        }

        [TestMethod]
        public void GetMessage()
        {
            Assert.IsTrue(string.IsNullOrEmpty(FApplication.GetMessage("test")));
        }

        [TestMethod]
        public void GetMessagePath()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetMessagePath()));
        }

        [TestMethod]
        public void GetName()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetName()));
        }

        [TestMethod]
        public void GetProductName()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetProductName()));
        }

        [TestMethod]
        public void GetProductSuffix()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetProductSuffix()));
        }

        [TestMethod]
        public void getProductType()
        {
            FApplication.getProductType();
        }

        [TestMethod]
        public void GetSoftwareVersion()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetSoftwareVersion()));
        }

        [TestMethod]
        public void GetStatusBarText()
        {
            FApplication.GetStatusBarText();
        }

        [TestMethod]
        public void GetString()
        {
            Assert.IsTrue(string.IsNullOrEmpty(FApplication.GetString(FApplication.GetMessagePath(), "test")));
        }

        [TestMethod]
        public void GetStringWithLanguage()
        {
            Assert.IsTrue(string.IsNullOrEmpty(FApplication.GetStringWithLanguage("test", "test", AppLanguage.lEnglish)));
        }

        [TestMethod]
        public void GetTemplateSignaturePrefix()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetTemplateSignaturePrefix()));
        }

        [TestMethod]
        public void GetTitleName()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FApplication.GetTitleName()));
        }

        [TestMethod]
        public void GetYear()
        {
            Assert.AreEqual(DateTime.Now.Year, FApplication.GetYear());
        }
    }
}