using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaxprepAddinAPI;
using WKCA.AddIn.Handlers.ClientFile;

namespace WKCA.UnitTest.Test
{
    [TestClass]
    public class ClientFilEvents
    {
        private IAppClientFileEventsService FEvents;

        [TestInitialize]
        public void Init()
        {
            FEvents = (IAppClientFileEventsService) TestHost.CurrentInstance.AppInstance;
        }

        [TestCleanup]
        public void CleanUp()
        {
            FEvents.AfterChangeClientFileHeaderProperty = null;
            FEvents.AfterClientFileNameChange = null;
            FEvents.AfterClientFileSave = null;
            FEvents.AfterCurrentDocumentChange = null;
            FEvents.AfterDocumentAdd = null;
            FEvents.AfterDocumentRemove = null;
            FEvents.BeforeClientFileNameChange = null;
            FEvents.BeforeClientFileSave = null;
            FEvents.BeforeCurrentDocumentChange = null;
            FEvents.BeforeDocumentAdd = null;
            FEvents.BeforeDocumentRemove = null;
            FEvents.BeforeReturnStatusChange = null;
            FEvents = null;
        }

        [TestMethod]
        public void AfterChangeClientFileHeaderProperty()
        {
            Assert.IsNull(FEvents.AfterChangeClientFileHeaderProperty);
            FEvents.AfterChangeClientFileHeaderProperty = new AfterChangeHeaderPropertyHandler(
                aFilename => { });
            Assert.IsNotNull(FEvents.AfterChangeClientFileHeaderProperty);
            FEvents.AfterChangeClientFileHeaderProperty = null;
            Assert.IsNull(FEvents.AfterChangeClientFileHeaderProperty);
        }

        [TestMethod]
        public void AfterClientFileNameChange()
        {
            Assert.IsNull(FEvents.AfterClientFileNameChange);
            FEvents.AfterClientFileNameChange = new AfterChangeNameHandler(
                aFilename => { });
            Assert.IsNotNull(FEvents.AfterClientFileNameChange);
            FEvents.AfterClientFileNameChange = null;
            Assert.IsNull(FEvents.AfterClientFileNameChange);
        }

        [TestMethod]
        public void AfterClientFileSave()
        {
            Assert.IsNull(FEvents.AfterClientFileSave);
            FEvents.AfterClientFileSave = new AfterSaveHandler(
                aFilename => { });
            Assert.IsNotNull(FEvents.AfterClientFileSave);
            FEvents.AfterClientFileSave = null;
            Assert.IsNull(FEvents.AfterClientFileSave);
        }

        [TestMethod]
        public void AfterCurrentDocumentChange()
        {
            Assert.IsNull(FEvents.AfterCurrentDocumentChange);
            FEvents.AfterCurrentDocumentChange = new ClientFileNotifyWithDocumentHandler(
                Document => { });
            Assert.IsNotNull(FEvents.AfterCurrentDocumentChange);
            FEvents.AfterCurrentDocumentChange = null;
            Assert.IsNull(FEvents.AfterCurrentDocumentChange);
        }

        [TestMethod]
        public void AfterDocumentAdd()
        {
            Assert.IsNull(FEvents.AfterDocumentAdd);
            FEvents.AfterDocumentAdd = new ClientFileNotifyWithDocumentHandler(
                Document => { });
            Assert.IsNotNull(FEvents.AfterDocumentAdd);
            FEvents.AfterDocumentAdd = null;
            Assert.IsNull(FEvents.AfterDocumentAdd);
        }

        [TestMethod]
        public void AfterDocumentRemove()
        {
            Assert.IsNull(FEvents.AfterDocumentRemove);
            FEvents.AfterDocumentRemove = new ClientFileNotifyWithDocumentHandler(
                Document => { });
            Assert.IsNotNull(FEvents.AfterDocumentRemove);
            FEvents.AfterDocumentRemove = null;
            Assert.IsNull(FEvents.AfterDocumentRemove);
        }

        [TestMethod]
        public void BeforeClientFileNameChange()
        {
            Assert.IsNull(FEvents.BeforeClientFileNameChange);
            FEvents.BeforeClientFileNameChange = new BeforeChangeNameHandler(
                (aOldFilename, aNewFileName) => { });
            Assert.IsNotNull(FEvents.BeforeClientFileNameChange);
            FEvents.BeforeClientFileNameChange = null;
            Assert.IsNull(FEvents.BeforeClientFileNameChange);
        }

        private void ExecuteDelegate(string aFileName, out bool aAccept)
        {
            aAccept = true;
        }

        [TestMethod]
        public void BeforeClientFileSave()
        {
            Assert.IsNull(FEvents.BeforeClientFileSave);
            FEvents.BeforeClientFileSave = new BeforeSaveHandler(ExecuteDelegate);
            Assert.IsNotNull(FEvents.BeforeClientFileSave);
            FEvents.BeforeClientFileSave = null;
            Assert.IsNull(FEvents.BeforeClientFileSave);
        }

        [TestMethod]
        public void BeforeCurrentDocumentChange()
        {
            Assert.IsNull(FEvents.BeforeCurrentDocumentChange);
            FEvents.BeforeCurrentDocumentChange = new BeforeCurrentDocumentChangeHandler(
                (OldDocument, NewDocument) => { });
            Assert.IsNotNull(FEvents.BeforeCurrentDocumentChange);
            FEvents.BeforeCurrentDocumentChange = null;
            Assert.IsNull(FEvents.BeforeCurrentDocumentChange);
        }

        [TestMethod]
        public void BeforeDocumentAdd()
        {
            Assert.IsNull(FEvents.BeforeDocumentAdd);
            FEvents.BeforeDocumentAdd = new ClientFileNotifyWithDocumentHandler(
                Document => { });
            Assert.IsNotNull(FEvents.BeforeDocumentAdd);
            FEvents.BeforeDocumentAdd = null;
            Assert.IsNull(FEvents.BeforeDocumentAdd);
        }

        [TestMethod]
        public void BeforeDocumentRemove()
        {
            Assert.IsNull(FEvents.BeforeDocumentRemove);
            FEvents.BeforeDocumentRemove = new ClientFileNotifyWithDocumentHandler(
                Document => { });
            Assert.IsNotNull(FEvents.BeforeDocumentRemove);
            FEvents.BeforeDocumentRemove = null;
            Assert.IsNull(FEvents.BeforeDocumentRemove);
        }

        [TestMethod]
        public void BeforeReturnStatusChange()
        {
            Assert.IsNull(FEvents.BeforeReturnStatusChange);
            FEvents.BeforeReturnStatusChange = new BeforeReturnStatusChangeHandler(
                (aDocReturn, AStatusName, aOldValue, AValue) => { });
            Assert.IsNotNull(FEvents.BeforeReturnStatusChange);
            FEvents.BeforeReturnStatusChange = null;
            Assert.IsNull(FEvents.BeforeReturnStatusChange);
        }
    }
}