using TaxprepAddinAPI;

namespace WKCA.AddIn.Handlers
{
    public class AppLogonHandler : IAddinLogonEventHandler
    {
        public delegate void ExecuteDelegate(string aUsername, string aPassword);
        private readonly ExecuteDelegate _onExecute;

        #region IAddinLogonEventHandler
        public void Execute(string aUsername, string aPassword)
        {
            if (_onExecute != null)
                _onExecute(aUsername, aPassword);
        }
        #endregion

        public AppLogonHandler(ExecuteDelegate onExecute)
        {
            _onExecute = onExecute;
        }
    }
}
