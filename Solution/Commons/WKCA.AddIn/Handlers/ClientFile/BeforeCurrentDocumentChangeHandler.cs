using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class BeforeCurrentDocumentChangeHandler : IAddinBeforeCurrentDocumentChangeHandler
    {
        public delegate void ExecuteDelegate(IAppTaxDocument OldDocument, IAppTaxDocument NewDocument);

        private readonly ExecuteDelegate _onExecute;

        public BeforeCurrentDocumentChangeHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinBeforeCurrentDocumentChangeHandler

        public void Execute(IAppTaxDocument OldDocument, IAppTaxDocument NewDocument)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(OldDocument, NewDocument);
            }
            catch (Exception e)
            {
                if (!UnhandledExceptionManager.HandleException(this, e))
                {
                    throw;
                }
            }
        }

        #endregion
    }
}