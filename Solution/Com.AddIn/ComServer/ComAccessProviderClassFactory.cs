using System;
using System.Runtime.InteropServices;

namespace Com.AddIn.ComServer
{
    /// <summary>
    /// Class factory for the class  ComAccessProviderClassFactory.
    /// </summary>
    internal class ComAccessProviderClassFactory : StandardOleMarshalObject, IClassFactory
    {
        public int CreateInstance(IntPtr pUnkOuter, ref Guid riid, out IntPtr ppvObject)
        {
            ppvObject = IntPtr.Zero;

            if (pUnkOuter != IntPtr.Zero)
            {
                // The pUnkOuter parameter was non-NULL and the object does not support aggregation.
                Marshal.ThrowExceptionForHR(ComNative.CLASS_E_NOAGGREGATION);
            }

            if (riid == ComIds.CLSID_ComAccessProvider || riid == new Guid(ComNative.IID_IDispatch) || riid == new Guid(ComNative.IID_IUnknown))
            {
                // Create the instance of the .NET object
                ppvObject = Marshal.GetComInterfaceForObject(new ComAccessProvider(), typeof(IComAccessProvider));
            }
            else
            {
                // The object that ppvObject points to does not support the interface identified by riid.
                Marshal.ThrowExceptionForHR(ComNative.E_NOINTERFACE);
            }

            return ComNative.S_OK; 
        }

        public int LockServer(bool fLock)
        {
            return ComNative.S_OK;
        }
    }
}
