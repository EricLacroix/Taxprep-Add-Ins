using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class AfterChangeHeaderPropertyHandler : IAddinAfterChangeClientFileHeaderPropertyHandler
    {
        public delegate void ExecuteDelegate(string aFilename);

        private readonly ExecuteDelegate _onExecute;

        public AfterChangeHeaderPropertyHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region

        public void Execute(string aClientFileHeaderKey)
        {
            
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aClientFileHeaderKey);
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