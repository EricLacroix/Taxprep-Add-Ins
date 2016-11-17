using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class BeforeChangeNameHandler : IAddinBeforeClientFileNameChangeHandler
    {
        public delegate void ExecuteDelegate(string aOldFilename, string aNewFileName);

        private readonly ExecuteDelegate _onExecute;

        public BeforeChangeNameHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinBeforeClientFileNameChangeHandler

        public void Execute(string aOldFileName, string aNewFileName)
        {

            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aOldFileName, aNewFileName);
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