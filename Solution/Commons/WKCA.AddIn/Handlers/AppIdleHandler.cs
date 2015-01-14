using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers
{
    public class AppIdleHandler : IAddinIdleHandler
    {
        public delegate void ExecuteDelegate(out bool aProcessed);

        private readonly ExecuteDelegate _onExecute;

        public AppIdleHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinIdleHandler

        public void Execute(out bool aProcessed)
        {
            aProcessed = true;
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(out aProcessed);
                }
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