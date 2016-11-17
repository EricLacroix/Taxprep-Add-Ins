using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.ClientFile
{
    public class BeforeSaveHandler : IAddinBeforeClientFileSaveHandler
    {
        public delegate void ExecuteDelegate(string aFileName, out bool aAccept);

        private readonly ExecuteDelegate _onExecute;

        public BeforeSaveHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinBeforeClientFileSaveHandler

        public void Execute(string aFileName, out bool aAccept)
        {     
            try
            {
                if (_onExecute != null)
                    _onExecute(aFileName, out aAccept);
            }
            catch (Exception e)
            {
                if (!UnhandledExceptionManager.HandleException(this, e))
                {
                    throw;
                }
            }
            aAccept = true;
        }

        #endregion
    }
}