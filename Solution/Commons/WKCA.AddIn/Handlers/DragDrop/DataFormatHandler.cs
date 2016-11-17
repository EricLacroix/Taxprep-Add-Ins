using System;
using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers.DragDrop
{
    public class DataFormatHandler : IAddinDragDropDataFormatHandler
    {
        public delegate dynamic ExecuteDelegate(IAppCellSelectionIter aSelection);

        private readonly ExecuteDelegate _onExecute;

        public DataFormatHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }

        #region IAddinDragDropDataFormatHandler

        public dynamic GetData(IAppCellSelectionIter aSelection)
        {
            try
            {
                if (_onExecute != null)
                    return _onExecute(aSelection);
            }
            catch (Exception e)
            {
                if (!UnhandledExceptionManager.HandleException(this, e))
                {
                    throw;
                }
            }

            return null;
        }

        #endregion
    }
}