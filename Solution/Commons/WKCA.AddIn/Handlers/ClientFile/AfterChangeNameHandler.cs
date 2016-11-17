using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class AfterChangeNameHandler : IAddinAfterClientFileNameChangeHandler
    {
        public delegate void ExecuteDelegate(string aFilename);

        private readonly ExecuteDelegate _onExecute;

        public AfterChangeNameHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinAfterClientFileNameChangeHandler

        public void Execute(string aFileName)
        {
            
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aFileName);
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