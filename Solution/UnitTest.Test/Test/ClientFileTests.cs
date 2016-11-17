using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ClientFileTests
    {
        private IAppClientFile FClientFile;

        [TestInitialize]
        public void Init()
        {
            var LManager = (IAppClientFileManagerService) TestHost.CurrentInstance.AppInstance;
            FClientFile = LManager.GetCurrentClientFile();
        }

        [TestCleanup]
        public void CleanUp()
        {
            FClientFile = null;
        }

        [TestMethod]
        public void AddScenario()
        {
            FClientFile.AddScenario("test");
        }

        [TestMethod]
        public void Backup()
        {
            Assert.IsTrue(FClientFile.Backup("c:", ".txt"));
        }

        [TestMethod]
        public void CanRecalcAlways()
        {
            FClientFile.CanRecalcAlways();
        }

        [TestMethod]
        public void CommitPathName()
        {
            FClientFile.CommitPathName();
        }

        [TestMethod]
        public void CreateGUID()
        {
            var LGuid = FClientFile.GetGUID();
            FClientFile.CreateGUID();
            try
            {
                FClientFile.GetGUID();
                Assert.Fail();
            }
            catch
            {
            }
            FClientFile = null;
            var LManager = (IAppClientFileManagerService) TestHost.CurrentInstance.AppInstance;
            FClientFile = LManager.GetCurrentClientFile();
            Assert.AreNotEqual(LGuid, FClientFile.GetGUID());
        }

        [TestMethod]
        public void CreateNew()
        {
            Assert.IsTrue(FClientFile.CreateNew("c:"));
        }

        [TestMethod]
        public void CreateTimeStamp()
        {
            FClientFile.CreateTimeStamp();
        }

        [TestMethod]
        public void CurrentYearExists()
        {
            Assert.IsTrue(FClientFile.CurrentYearExists());
        }

        [TestMethod]
        public void getAskedOptions()
        {
            Assert.IsFalse(FClientFile.getAskedOptions(AppAskOption.optAskPassword));
            Assert.IsFalse(FClientFile.getAskedOptions(AppAskOption.optAskReadOnly));
            Assert.IsFalse(FClientFile.getAskedOptions(AppAskOption.optAskSilent));
        }

        [TestMethod]
        public void GetCalcPersonalDiags()
        {
            Assert.IsTrue(FClientFile.GetCalcPersonalDiags());
        }

        [TestMethod]
        public void GetCanModifyData()
        {
            Assert.IsTrue(FClientFile.GetCanModifyData());
        }

        [TestMethod]
        public void GetCanSaveFile()
        {
            Assert.IsTrue(FClientFile.GetCanSaveFile());
        }

        [TestMethod]
        public void GetCount()
        {
            Assert.IsTrue(FClientFile.GetCount() > 0);
        }

        [TestMethod]
        public void GetCurrentDocIndex()
        {
            Assert.IsTrue(FClientFile.GetCurrentDocIndex() >= 0);
        }

        [TestMethod]
        public void GetCurrentDocListIndex()
        {
            Assert.IsTrue(FClientFile.GetCurrentDocListIndex() >= 0);
        }

        [TestMethod]
        public void GetCurrentReturn()
        {
            Assert.IsNotNull(FClientFile.GetCurrentReturn());
        }

        [TestMethod]
        public void GetCurrentReturnId()
        {
            Assert.AreEqual(FClientFile.GetCurrentReturn().GetReturnId(), FClientFile.GetCurrentReturnId());
        }

        [TestMethod]
        public void GetCurrentReturnWithPath()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FClientFile.GetCurrentReturn().GetReturnPath()));
        }

        [TestMethod]
        public void GetCurrentTaxDocument()
        {
            IAppTaxDocument LDoc;
            Assert.IsTrue(FClientFile.GetCurrentTaxDocument(out LDoc));
            Assert.IsNotNull(LDoc);
            LDoc.GetCurrentReturnId();
        }

        [TestMethod]
        public void GetCurrentYearDocument()
        {
            var LDoc = FClientFile.GetCurrentYearDocument();
            Assert.IsNotNull(LDoc);
            LDoc.GetCurrentReturnId();
        }

        [TestMethod]
        public void GetDataLocked()
        {
            Assert.IsFalse(FClientFile.GetDataLocked());
        }

        [TestMethod]
        public void GetDataTracking()
        {
            Assert.IsFalse(FClientFile.GetDataTracking());
        }

        [TestMethod]
        public void GetDateTime()
        {
            FClientFile.GetDateTime();
        }

        [TestMethod]
        public void GetDisplayPathFileName()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FClientFile.GetDisplayPathFileName()));
        }

        [TestMethod]
        public void GetDocIndexByListIndex()
        {
            var LListIndex = FClientFile.GetCurrentDocListIndex();
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            Assert.AreEqual(FClientFile.GetDocIndexByListIndex(LListIndex), LDocIndex);
        }

        [TestMethod]
        public void GetDocument()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            var LDoc = FClientFile.GetDocument(LDocIndex);
            Assert.IsNotNull(LDoc);
            LDoc.GetCurrentReturnId();
        }

        [TestMethod]
        public void GetDocumentByIndex()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            var LDoc = FClientFile.GetDocumentByIndex((int) LDocIndex);
            Assert.IsNotNull(LDoc);
            LDoc.GetCurrentReturnId();
        }

        [TestMethod]
        public void GetDocumentName()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            Assert.IsFalse(string.IsNullOrEmpty(FClientFile.GetDocumentName(LDocIndex)));
        }

        [TestMethod]
        public void GetFileOpenMode()
        {
            FClientFile.GetFileOpenMode();
        }

        [TestMethod]
        public void GetFileOpenReadOnly()
        {
            Assert.IsFalse(FClientFile.GetFileOpenReadOnly());
        }

        [TestMethod]
        public void GetGUID()
        {
            Assert.IsFalse(string.IsNullOrEmpty(FClientFile.GetGUID()));
        }

        [TestMethod]
        public void GetIsNewerDataBaseTemplate()
        {
            Assert.IsFalse(FClientFile.GetIsNewerDataBaseTemplate());
        }

        [TestMethod]
        public void GetLanguage()
        {
            Assert.IsTrue(FClientFile.GetLanguage() == AppLanguage.lEnglish ||
                          FClientFile.GetLanguage() == AppLanguage.lFrench);
        }

        [TestMethod]
        public void GetLastScenarioDocIndex()
        {
            FClientFile.GetLastScenarioDocIndex();
        }

        [TestMethod]
        public void GetLastScenarioIndex()
        {
            FClientFile.GetLastScenarioIndex();
        }

        [TestMethod]
        public void GetListOfReturnIDCount()
        {
            Assert.IsTrue(FClientFile.GetListOfReturnIDCount() >= 0);
        }

        [TestMethod]
        public void GetListOfReturnIDItem()
        {
            for (var i = 0; i < FClientFile.GetListOfReturnIDCount(); ++i)
                Assert.IsFalse(string.IsNullOrEmpty(FClientFile.GetListOfReturnIDItem(i)));
        }

        [TestMethod]
        public void GetOldFileName()
        {
            FClientFile.GetOldFileName();
        }

        [TestMethod]
        public void GetOpenResult()
        {
            Assert.IsTrue(FClientFile.GetOpenResult() >=
                          Enum.GetValues(typeof (AppOpenResult)).Cast<AppOpenResult>().Min());
            Assert.IsTrue(FClientFile.GetOpenResult() <=
                          Enum.GetValues(typeof (AppOpenResult)).Cast<AppOpenResult>().Max());
        }

        [TestMethod]
        public void GetReadOnlyFileAttr()
        {
            Assert.IsFalse(FClientFile.GetReadOnlyFileAttr());
        }

        [TestMethod]
        public void GetSaveResult()
        {
            Assert.IsTrue(FClientFile.GetSaveResult() >=
                          Enum.GetValues(typeof (AppSaveResult)).Cast<AppSaveResult>().Min());
            Assert.IsTrue(FClientFile.GetSaveResult() >=
                          Enum.GetValues(typeof (AppSaveResult)).Cast<AppSaveResult>().Min());
        }

        [TestMethod]
        public void GetScenarioCount()
        {
            FClientFile.GetScenarioCount();
        }

        [TestMethod]
        public void GetSystemLocked()
        {
            Assert.IsFalse(FClientFile.GetSystemLocked());
        }

        [TestMethod]
        public void GetSystemLockedBy()
        {
            string LBy;
            Assert.IsFalse(FClientFile.GetSystemLockedBy(out LBy));
            Assert.IsTrue(string.IsNullOrEmpty(LBy));
        }

        [TestMethod]
        public void GetTaxDocument()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            IAppTaxDocument LDoc;
            Assert.IsTrue(FClientFile.GetTaxDocument(LDocIndex, out LDoc));
            Assert.IsNotNull(LDoc);
            LDoc.GetCurrentReturnId();
        }

        [TestMethod]
        public void GetTaxPayer()
        {
            var LRes = FClientFile.GetTaxPayer(FClientFile.GetCurrentReturnId());
        }

        [TestMethod]
        public void GetTryingSavePathName()
        {
            FClientFile.GetTryingSavePathName();
        }

        [TestMethod]
        public void HasPassword()
        {
            Assert.IsFalse(FClientFile.HasPassword());
        }

        [TestMethod]
        public void IsCouplingUpdated()
        {
            Assert.IsFalse(FClientFile.IsCouplingUpdated());
        }

        [TestMethod]
        public void IsDirty()
        {
            FClientFile.IsDirty();
        }

        [TestMethod]
        public void IsDocumentLoaded()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            Assert.IsTrue(FClientFile.IsDocumentLoaded(LDocIndex));
        }

        [TestMethod]
        public void IsNew()
        {
            FClientFile.IsNew();
        }

        [TestMethod]
        public void IsOpen()
        {
            FClientFile.IsOpen();
        }

        [TestMethod]
        public void IsPlanner()
        {
            FClientFile.IsPlanner();
        }

        [TestMethod]
        public void IsSystemLockedByCurrentUser()
        {
            Assert.IsFalse(FClientFile.IsSystemLockedByCurrentUser());
        }

        [TestMethod]
        public void IsUniqueDocumentName()
        {
            FClientFile.IsUniqueDocumentName("test");
        }

        [TestMethod]
        public void IsValidCurrentListIndex()
        {
            Assert.IsTrue(FClientFile.IsValidCurrentListIndex());
        }

        [TestMethod]
        public void IsValidListIndex()
        {
            var LDocIndex = FClientFile.GetCurrentDocListIndex();
            Assert.IsTrue(FClientFile.IsValidListIndex(LDocIndex));
        }

        [TestMethod]
        public void LastYearExists()
        {
            Assert.IsFalse(FClientFile.LastYearExists());
        }

        [TestMethod]
        public void ListIndexOfDocIndex()
        {
            var LDocIndex = FClientFile.GetCurrentDocIndex();
            Assert.AreEqual(FClientFile.ListIndexOfDocIndex(LDocIndex), FClientFile.GetCurrentDocListIndex());
        }
    }
}