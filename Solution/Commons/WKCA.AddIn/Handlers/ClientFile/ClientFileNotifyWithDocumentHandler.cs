using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class ClientFileNotifyWithDocumentHandler : IAddinClientFileNotifyWithDocumentHandler
    {
        public delegate void ExecuteDelegate(IAppTaxDocument Document);

        private readonly ExecuteDelegate _onExecute;

        public ClientFileNotifyWithDocumentHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinClientFileNotifyWithDocumentHandler

        public void Execute(IAppTaxDocument Document)
        {
            try
            {
                if (_onExecute != null)
                    _onExecute(Document);
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