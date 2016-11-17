using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.DatabaseEnv
{
    public class BeforeCalcHandler : IAddinBeforeCalcHandler
    {
        public delegate void ExecuteDelegate(IAppDocReturn aReturn);

        private readonly ExecuteDelegate _onExecute;

        public BeforeCalcHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinNotifyHandler

        public void Execute(IAppDocReturn aReturn)
        {

            try
            {
                if (_onExecute != null)
                    _onExecute(aReturn);
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