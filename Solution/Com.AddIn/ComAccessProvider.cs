using System.Runtime.InteropServices;
using TaxprepAddinAPI;

namespace Com.AddIn
{
    [ClassInterface(ClassInterfaceType.None)]
    [Guid(ComIds.CLSID_ComAccessProviderTemplate), ComVisible(true)]
    public class ComAccessProvider : StandardOleMarshalObject, IComAccessProvider
    {
        [return: MarshalAs(UnmanagedType.IUnknown)]
        public IAppInstance GetAppInstance()
        {
            return TaxPrepAppHelper.AppInstance;
        }
    }
}
