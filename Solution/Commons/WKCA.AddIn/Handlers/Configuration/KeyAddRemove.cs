using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.Configuration
{
    public class KeyAddRemove : IAddinConfigurationAddRemoveKeyHandler
    {
        public delegate void ExecuteDelegate(string aSection, string aKey);

        private readonly ExecuteDelegate _onExecute;

        public KeyAddRemove(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region

        public void Execute(string aSection, string aKey)
        {

            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aSection, aKey);
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