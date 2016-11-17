using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class DocReturnNotifyHandler : IAddinDocReturnNotifyHandler
    {
        public delegate void ExecuteDelegate(IAppDocReturn aDocReturn);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinDocReturnNotifyHandler

        public void Execute(IAppDocReturn aDocReturn)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(aDocReturn);
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

        public DocReturnNotifyHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
