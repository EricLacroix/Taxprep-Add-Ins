using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ModuleManager
{
    public class NotifyHandler : IAddinModuleManagerNotifyHandler
    {
        public delegate void ExecuteDelegate(IAppModule aModule);

        private readonly ExecuteDelegate _onExecute;

        public NotifyHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinModuleManagerNotifyHandler

        public void Execute(IAppModule aModule)
        {
            try
            {
                if (_onExecute != null)
                    _onExecute(aModule);
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