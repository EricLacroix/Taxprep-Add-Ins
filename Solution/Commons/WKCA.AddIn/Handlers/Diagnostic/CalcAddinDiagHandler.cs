using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.Diagnostic
{
    public class CalcAddinDiagHandler : IAddinCalcDiagnosticHandler
    {
        public delegate bool ExecuteDelegate(IAppDocReturn aDocReturn, int AGroupNo, string ADiagName);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinNotifyHandler

        public bool Execute(IAppDocReturn aDocReturn, int AGroupNo, string ADiagName)
        {
            try
            {
                if (_onExecute != null)
                    return _onExecute(aDocReturn, AGroupNo, ADiagName);
            }
            catch (Exception e)
            {
                if (!UnhandledExceptionManager.HandleException(this, e))
                {
                    throw;
                }
            }
            return false;
        }

        #endregion

        public CalcAddinDiagHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
