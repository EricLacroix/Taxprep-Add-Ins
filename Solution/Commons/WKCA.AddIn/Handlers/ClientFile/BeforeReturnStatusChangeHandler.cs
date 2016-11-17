using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class BeforeReturnStatusChangeHandler : IAddinReturnStatusChange
    {
        public delegate void ExecuteDelegate(IAppDocReturn aDocReturn, string AStatusName, int aOldValue, int AValue);

        private readonly ExecuteDelegate _onExecute;

        public BeforeReturnStatusChangeHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinBeforeClientFileSaveHandler

        public void Execute(IAppDocReturn aDocReturn, string AStatusName, int aOldValue, int AValue)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(aDocReturn, AStatusName, aOldValue, AValue);
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