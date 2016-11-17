using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ClientLetters
    {
        private IAppTaxApplicationService FApplication;
        private IAppClientLetterManager FLetters;

        [TestInitialize]
        public void Init()
        {
            FApplication = (IAppTaxApplicationService) TestHost.CurrentInstance.AppInstance;
            FLetters = FApplication.ClientLetterManager;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FLetters = null;
            FApplication = null;
        }

        [TestMethod]
        public void ClientLettersTest()
        {
            Assert.IsTrue(FLetters.Count > 0);
            for (var i = 0; i < FLetters.Count; ++i)
            {
                var LLetter = FLetters.ClientLetters[i];
                Assert.IsNotNull(LLetter);
                Assert.IsFalse(string.IsNullOrEmpty(LLetter.FilePath));
                Assert.IsFalse(string.IsNullOrEmpty(LLetter.FormNAme));
                Assert.IsTrue(LLetter.AddInsBitField >= 0);
            }
        }
    }
}