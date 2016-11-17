using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class ClientFileChangeHandler : IAddinClientFileChangeEventHandler
    {
        public delegate void ExecuteDelegate(IAppClientFile AOldClientFile, IAppClientFile ANewClientFile);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinClientFileChangeEventHandler

        public void Execute(IAppClientFile AOldClientFile, IAppClientFile ANewClientFile)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(AOldClientFile, ANewClientFile);
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

        public ClientFileChangeHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
