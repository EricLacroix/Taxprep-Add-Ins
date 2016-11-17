using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class ClientFileHandler : IAddinClientFileEventHandler
    {
        public delegate void ExecuteDelegate(IAppClientFile aClientFile);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinClientFileEventHandler

        public void Execute(IAppClientFile aClientFile)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(aClientFile);
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

        public ClientFileHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
