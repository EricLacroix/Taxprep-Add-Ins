using System.Runtime.InteropServices;
using TaxprepAddinAPI;

namespace Com.AddIn
{
    [Guid(ComIds.IID_IComAccessProvider), ComVisible(true)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IComAccessProvider
    {
        [return: MarshalAs(UnmanagedType.IUnknown)]
        IAppInstance GetAppInstance();
    }
}
