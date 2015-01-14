using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ClientFileManagerTests
    {
        private IAppClientFileManagerService FManager;

        [TestInitialize]
        public void Init()
        {
            FManager = (IAppClientFileManagerService) TestHost.CurrentInstance.AppInstance;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FManager = null;
        }

        [TestMethod]
        public void BackupFiles()
        {
            FManager.BackupFiles();
        }

        [TestMethod]
        public void GetClientFile()
        {
            if (FManager.GetCount() > 0)
            {
                var LFile = FManager.GetClientFile(0);
                Assert.IsNotNull(LFile);
                LFile = null;
                Assert.IsNull(LFile);
            }
        }

        [TestMethod]
        public void GetCurrentClientFile()
        {
            if (FManager.GetCount() > 0)
            {
                var LFile = FManager.GetCurrentClientFile();
                Assert.IsNotNull(LFile);
                LFile = null;
                Assert.IsNull(LFile);
            }
            else
            {
                var LFile = FManager.GetCurrentClientFile();
                Assert.IsNull(LFile);
            }
        }

        [TestMethod]
        public void AddClientFile()
        {
            Assert.IsNotNull(FManager);
            try
            {
                FManager.AddClientFile(null);
                Assert.Fail("It should not be allowed to add an empty client file");
            }
            catch
            {
            }
        }

        [TestMethod]
        public void GetCurrentClientFileIndex()
        {
            if (FManager.GetCount() > 0)
            {
                var LIndex = FManager.GetCurrentClientFileIndex();
                Assert.IsTrue(LIndex >= 0 && LIndex < FManager.GetCount());
            }
            else
            {
                var LIndex = FManager.GetCurrentClientFileIndex();
                Assert.IsTrue(LIndex == -1);
            }
        }

        [TestMethod]
        public void GetCurrentDocIndex()
        {
            if (FManager.GetCount() > 0)
            {
                FManager.GetCurrentDocIndex();
            }
        }

        [TestMethod]
        public void GetCurrentDocument()
        {
            if (FManager.GetCount() > 0)
            {
                var LDocument = FManager.GetCurrentDocument();
                Assert.IsNotNull(LDocument);
                LDocument = null;
                Assert.IsNull(LDocument);
            }
        }

        [TestMethod]
        public void GetCurrentReturn()
        {
            if (FManager.GetCount() > 0)
            {
                var LReturn = FManager.GetCurrentReturn();
                Assert.IsNotNull(LReturn);
                LReturn = null;
                Assert.IsNull(LReturn);
            }
        }

        [TestMethod]
        public void GetCurrentReturnId()
        {
            if (FManager.GetCount() > 0)
            {
                var LId = FManager.GetCurrentReturnId();
            }
        }

        [TestMethod]
        public void GetCurrentTaxDocument()
        {
            if (FManager.GetCount() > 0)
            {
                var LTaxDocument = FManager.GetCurrentTaxDocument();
                Assert.IsNotNull(LTaxDocument);
                LTaxDocument = null;
                Assert.IsNull(LTaxDocument);
            }
        }

        [TestMethod]
        public void GetHashCodeTest()
        {
            var LHash = FManager.GetHashCode();
        }

        [TestMethod]
        public void GetVersionInfo()
        {
            FManager.GetVersionInfo();
        }

        [TestMethod]
        public void IsBackupEnabled()
        {
            var LValue = FManager.IsBackupEnabled();
            FManager.SetBackupEnabled(!LValue);
            Assert.AreEqual(!LValue, FManager.IsBackupEnabled());
            FManager.SetBackupEnabled(LValue);
            Assert.AreEqual(LValue, FManager.IsBackupEnabled());
        }
    }
}