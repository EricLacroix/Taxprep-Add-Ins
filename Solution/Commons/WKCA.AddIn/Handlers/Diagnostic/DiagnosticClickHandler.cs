using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.Diagnostic
{
    public class DiagnosticClickHandler : IAddinDiagnosticClickHandler
    {
        public delegate void ExecuteDelegate(IAppDocReturn aDocReturn, int ADiagGroup, string ADiagName);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinNotifyHandler

        public void Execute(IAppDocReturn aDocReturn, int ADiagGroup, string ADiagName)
        {
            try
            {
                if (_onExecute != null)
                    _onExecute(aDocReturn, ADiagGroup, ADiagName);
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

        public DiagnosticClickHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
