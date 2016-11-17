using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class ClientFileCanCloseHandler : IAddinCanCloseEventHandler
    {
        public delegate bool ExecuteDelegate(IAppClientFile aClientFile);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinCanCloseEventHandler

        public bool Execute(IAppClientFile aClientFile)
        {
            try
            {
                if (_onExecute != null)
                    return _onExecute(aClientFile);
            }
            catch (Exception e)
            {
                if (!UnhandledExceptionManager.HandleException(this, e))
                {
                    throw;
                }
            }
            return true;
        }

        #endregion

        public ClientFileCanCloseHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
