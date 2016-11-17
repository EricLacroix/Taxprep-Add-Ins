using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    internal class DiagnosticTests
    {
        private IAppInstance AppInstance { get; set; }
        private IAppDiagnostic Diagnostic { get; set; }

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
        public void DiagnosticAcces()
        {
            var LClientFileManager = (IAppClientFileManagerService) AppInstance;
            Assert.IsNotNull(LClientFileManager);
            var LClientFile = LClientFileManager.GetCurrentClientFile();
            Assert.IsNotNull(LClientFile);
            var LReturn = LClientFile.GetCurrentReturn();
            Assert.IsNotNull(LReturn);
            var LDiag = LReturn.GetDiagnostic();
            Assert.IsNotNull(LDiag);
        }

        [TestMethod]
        public void DiagnosticMethods()
        {
            var LClientFileManager = (IAppClientFileManagerService) AppInstance;
            Assert.IsNotNull(LClientFileManager);
            var LClientFile = LClientFileManager.GetCurrentClientFile();
            Assert.IsNotNull(LClientFile);
            var LReturn = LClientFile.GetCurrentReturn();
            Assert.IsNotNull(LReturn);
            var LDiag = LReturn.GetDiagnostic();
            Assert.IsNotNull(LDiag);
            //LDiag.ClearAll();
            LDiag.CalcPersonalDiagInterrupted();
            LDiag.CalcPersonalDiags(true);
            LDiag.GetCalcPersonalDiagCompleted();
            if (LDiag.GetDiagCount(0) > 0)
                LDiag.GetDiagNode(0, 0);
            Assert.IsNotNull(LDiag.getDocReturn());
            LDiag.GetHashCode();
            LDiag.CalcPersonalDiags(true);
            LDiag.GetReturnId();
            LDiag.GetType();
        }

        [TestMethod]
        public void DiagnosticNodeMethods()
        {
            var LClientFileManager = (IAppClientFileManagerService) AppInstance;
            Assert.IsNotNull(LClientFileManager);
            var LClientFile = LClientFileManager.GetCurrentClientFile();
            Assert.IsNotNull(LClientFile);
            var LReturn = LClientFile.GetCurrentReturn();
            Assert.IsNotNull(LReturn);
            var LDiag = LReturn.GetDiagnostic();
            Assert.IsNotNull(LDiag);
            for (var i = 0; i < LDiag.GetDiagCount(0); ++i)
            {
                var LNode = LDiag.GetDiagNode(i, 0);
                Assert.IsNotNull(LNode);
                LNode.GetApplicable();
                LNode.getDiagGroupNo();
                LNode.getDiagIndex();
                Assert.IsFalse(string.IsNullOrEmpty(LNode.getDiagName()));
                LNode.getDiagNo();
                LNode.getDiagNote();
                LNode.getDiagRevMark();
                Assert.IsFalse(string.IsNullOrEmpty(LNode.getDiagText(AppLanguage.lEnglish)));
                Assert.IsFalse(string.IsNullOrEmpty(LNode.getDiagText(AppLanguage.lFrench)));
                LNode.getDiagType();
                Assert.IsFalse(string.IsNullOrEmpty(LNode.GetDisplayText(AppLanguage.lEnglish)));
                Assert.IsFalse(string.IsNullOrEmpty(LNode.GetDisplayText(AppLanguage.lFrench)));
                LNode.getFormNumber();
                LNode.GetHashCode();
                LNode.getJurisdiction();
                IAppTaxCell LCell;
                if (LNode.getLink(out LCell, true))
                    Assert.IsNotNull(LCell);
                LNode.getMessagePopupType();
                bool b1, b2;
                LNode.getOption(out b1, out b2);
                for (var iParam = 0; iParam < LNode.getParamsCount(); ++iParam)
                {
                    LNode.getParams(iParam, AppLanguage.lFrench);
                    LNode.getParams(iParam, AppLanguage.lEnglish);
                }
            }
        }
    }
}