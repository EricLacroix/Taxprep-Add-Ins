using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers
{
    public class AppGetAdvertisingData : IAddinGetAdvertisingDataHandler
    {
        public delegate void ExecuteDelegate(out string AParameterName, out string AData);

        private readonly ExecuteDelegate _onExecute;

        public AppGetAdvertisingData(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinGetAdvertisingDataHandler

        public void Execute(out string AParameterName, out string AData)
        {
            AParameterName = "";
            AData = "";
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(out AParameterName, out AData);
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