using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ConfigurationTests
    {
        private readonly string CTempKeyName = "unit_test_temp_key";
        private readonly string CTempKeyValue = "temp-key-value";

        private readonly string CTempSectionName = "unit_test_temporary";
        private IAppTaxApplicationService FApplication;
        private IAppClientFileManagerService FClientFileManager;
        private IAppConfiguration FConfiguration;

        [TestInitialize]
        public void Init()
        {
            FApplication = (IAppTaxApplicationService) TestHost.CurrentInstance.AppInstance;
            FClientFileManager = FApplication.GetClientFileManager();
            FConfiguration = FApplication.Configuration;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FConfiguration = null;
            FClientFileManager = null;
            FApplication = null;
        }

        [TestMethod]
        public void CreateConfigurationSection()
        {
            Assert.IsNotNull(FConfiguration);
            FConfiguration.AddConfigurationSection(CTempSectionName);
        }

        [TestMethod]
        public void CreateConfigurationKey()
        {
            Assert.IsNotNull(FConfiguration);
            FConfiguration.AddConfigurationSection(CTempSectionName);
            FConfiguration.SetString(CTempSectionName, CTempKeyName, CTempKeyValue);
            Assert.AreEqual(CTempKeyValue, FConfiguration.AsString(CTempSectionName, CTempKeyName, ""));
            FConfiguration.RemoveKey(CTempSectionName, CTempKeyName);
        }

        [TestMethod]
        public void ReadConfigurationKeys()
        {
            FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", false);
            FConfiguration.AsString("AutoText", "Max", "0");
            FConfiguration.AsBoolean("FormEngine", "QuickOverride", false);
            FConfiguration.AsBoolean("Diagnostics", "HaveToShowValidation", false);
            FConfiguration.AsBoolean("FormEngine", "ShowLastYearDataInTaxReturn", false);
            FConfiguration.AsBoolean("Tax Return", "AlwaysRecalculate", false);
            FConfiguration.AsBoolean("Tax Return", "AlwaysUpdateProfil", false);
            FConfiguration.AsBoolean("Tax Return", "LockWhenCompleted", false);
        }

        [TestMethod]
        public void ModifyConfigurationKeys()
        {
            var LReopenLastUsedForms = FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", false);
            FConfiguration.SetBoolean("Tax Return", "ReopenLastUsedForms", !LReopenLastUsedForms);
            try
            {
                Assert.AreNotEqual(LReopenLastUsedForms,
                    FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", LReopenLastUsedForms));
            }
            finally
            {
                FConfiguration.SetBoolean("Tax Return", "ReopenLastUsedForms", LReopenLastUsedForms);
                Assert.AreEqual(LReopenLastUsedForms,
                    FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", LReopenLastUsedForms));
            }
        }

        [TestMethod]
        public void CheckConfigurationNotifier()
        {
            var LKeyChange = new KeyChangeNotifier();
            FConfiguration.AfterModifyKey = LKeyChange;
            Assert.IsNotNull(FConfiguration.AfterModifyKey);
            try
            {
                var LReopenLastUsedForms = FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", false);
                FConfiguration.SetBoolean("Tax Return", "ReopenLastUsedForms", !LReopenLastUsedForms);
                try
                {
                    Assert.AreEqual(LKeyChange.FLastKey, "ReopenLastUsedForms");
                    Assert.AreEqual(LKeyChange.FLastSection, "Tax Return");
                }
                finally
                {
                    FConfiguration.SetBoolean("Tax Return", "ReopenLastUsedForms", LReopenLastUsedForms);
                    Assert.AreEqual(LReopenLastUsedForms,
                        FConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", LReopenLastUsedForms));
                    Assert.AreEqual(LKeyChange.FLastKey, "ReopenLastUsedForms");
                    Assert.AreEqual(LKeyChange.FLastSection, "Tax Return");
                }
            }
            finally
            {
                FConfiguration.AfterModifyKey = null;
                Assert.IsNull(FConfiguration.AfterModifyKey);
            }
        }

        private class KeyChangeNotifier : IAddinConfigurationKeyModifiedHandler
        {
            public string FLastSection, FLastKey;

            public void Execute(string aLevel, string aSection, string aKey, string AValue)
            {
                FLastSection = aSection;
                FLastKey = aKey;
            }
        }
    }
}