using System;
using System.Runtime.InteropServices;

namespace WKCA.AddIn
{
    public class AddinMarshaler : ICustomMarshaler
    {
        private static readonly AddinMarshaler Instance;

        static AddinMarshaler()
        {
            Instance = new AddinMarshaler();
        }

        public void CleanUpManagedData(object managedObj)
        {
        }

        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        public int GetNativeDataSize()
        {
            return 4;
        }

        public IntPtr MarshalManagedToNative(object managedObj)
        {
            throw new NotImplementedException();
        }

        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.GetObjectForIUnknown(pNativeData);
        }

        // return the static instance
        public static ICustomMarshaler GetInstance(string cookie)
        {
            return Instance;
        }
    }
}