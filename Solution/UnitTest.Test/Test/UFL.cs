using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class UFLTests
    {
        private IAppTaxApplicationService FApplication;
        private IAppUFL FUFL;

        [TestInitialize]
        public void Init()
        {
            FApplication = (IAppTaxApplicationService) TestHost.CurrentInstance.AppInstance;
            FUFL = FApplication.UFL;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FUFL = null;
            FApplication = null;
        }

        [TestMethod]
        public void UFLTest()
        {
            Assert.IsTrue(FUFL.Count > 0);
            for (var i = 0; i < FUFL.Count; ++i)
            {
                var LForm = FUFL.Form[i];
                Assert.IsNotNull(LForm);
                FUFL.GetAccessCodeByName(LForm.FormNAme);
                FUFL.GetFormByCCHScanForm(LForm.FormNAme);
                Assert.AreEqual(FUFL.GetFormByFormNumber(LForm.formNumber).formNumber, LForm.formNumber);
                Assert.AreEqual(FUFL.GetFormByName(LForm.FormNAme).FormNAme, LForm.FormNAme);
                Assert.AreEqual(i, FUFL.GetFormIndexByFormNumber(LForm.formNumber));
                Assert.AreEqual(i, FUFL.GetFormIndexByName(LForm.FormNAme));
                FUFL.IsAvailableForm(LForm.FormNAme);
                FUFL.IsCompatibleCCHScanForm(LForm.FormNAme, LForm.FormNAme);
                FUFL.IsPrePrintForm(LForm.FormNAme);
                FUFL.IsReadyForm(LForm.FormNAme);

                Assert.IsNotNull(LForm.FormGroupName);
                LForm.InFormManager();
                LForm.InPrintFormat();
                LForm.IsAddinSupported(1);
                LForm.IsAlbertaPrint();
                LForm.IsFederalPrint();
                LForm.IsLabelForm();
                LForm.IsLetterForm();
                LForm.IsPrePrint();
                LForm.IsQuebecForm();
                LForm.IsTaxForm();
                LForm.IsXpressForm();
                Assert.IsNotNull(LForm.LinkFormName);
            }
        }

        [TestMethod]
        public void PrintIdForm()
        {
            var lForm = FUFL.GetFormByName("IDForm");
            Assert.IsNotNull(lForm);
            string LFileName;
            lForm.Print(FApplication.GetCurrentDocReturn(), AppLanguage.lEnglish, out LFileName);
            Assert.IsFalse(string.IsNullOrEmpty(LFileName));
            Assert.IsTrue(File.Exists(LFileName));
        }
    }
}