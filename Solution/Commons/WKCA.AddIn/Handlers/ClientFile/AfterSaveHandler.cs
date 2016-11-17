using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class AfterSaveHandler : IAddinAfterClientFileSaveHandler
    {
        public delegate void ExecuteDelegate(string aFileName);

        private readonly ExecuteDelegate _onExecute;

        public AfterSaveHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinAfterClientFileSavHandler

        public void Execute(string aFileName)
        {
            
            try
            {
                if (_onExecute != null)
                    _onExecute(aFileName);
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