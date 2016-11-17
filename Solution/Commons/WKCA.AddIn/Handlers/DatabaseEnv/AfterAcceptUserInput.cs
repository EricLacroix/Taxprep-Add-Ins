using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.DatabaseEnv
{
    public class AfterAcceptUserInput : IAddinDatabaseEnvAfterAcceptUserInput
    {
        public delegate void ExecuteDelegate(IAppTaxCell aCell);

        private readonly ExecuteDelegate _onExecute;

        public AfterAcceptUserInput(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinDatabaseEnvAfterAcceptUserInput

        public void Execute(IAppTaxCell aCell)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(aCell);
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