using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.Configuration
{
    public class SectionAddRemove : IAddinConfigurationAddRemoveSectionHandler
    {
        public delegate void ExecuteDelegate(string aSectionName);

        private readonly ExecuteDelegate _onExecute;

        public SectionAddRemove(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region

        public void Execute(string aSectionName)
        {
            
            try
            {
                if (_onExecute != null)
                {
                    _onExecute(aSectionName);
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