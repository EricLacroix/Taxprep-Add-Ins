using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers
{
    public class AppNotifyHandler : IAddinNotifyHandler
    {
        public delegate void ExecuteDelegate();

        private readonly ExecuteDelegate _onExecute;

        public AppNotifyHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinNotifyHandler

        public void Execute()
        {
            try
            {
                if (_onExecute != null)
                    _onExecute();
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