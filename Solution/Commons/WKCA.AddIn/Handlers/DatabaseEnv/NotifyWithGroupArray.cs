using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.DatabaseEnv
{
    public class NotifyWithGroupArray : IAddinDatabaseEnvNotifyWithGroupArray
    {
        public delegate void ExecuteDelegate(IAppGroupArray aGroup);

        private readonly ExecuteDelegate _onExecute;

        public NotifyWithGroupArray(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinDatabaseEnvNotifyWithGroupArray

        public void Execute(IAppGroupArray aGroup)
        {
            try
            {
                if (_onExecute != null)
                    _onExecute(aGroup);
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