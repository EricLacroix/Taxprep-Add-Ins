using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.Configuration
{
    public class KeyModify : IAddinConfigurationKeyModifiedHandler
    {
        public delegate void ExecuteDelegate(string aLevel, string aSection, string aKey, string AValue);

        private readonly ExecuteDelegate _onExecute;

        public KeyModify(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region

        public void Execute(string aLevel, string aSection, string aKey, string AValue)
        {
            
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aLevel, aSection, aKey, AValue);
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