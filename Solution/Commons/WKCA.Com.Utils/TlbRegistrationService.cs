using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace WKCA.Com.Utils
{
    public class TlbRegistrationService
    {
        private readonly bool _perUser;
        public TlbRegistrationService(bool perUser = true)
        {
            _perUser = perUser;
        }

        public void Register(string fileName)
        {
            ITypeLib ppbc;
            var res = LoadTypeLib(fileName, out ppbc);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("File {0} is missing or is not a valid type library. Error code: {1:X}", fileName, res));
            }
            res = _perUser ? RegisterTypeLibForUser(ppbc, fileName, null) : RegisterTypeLib(ppbc, fileName, null);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("File {0} could not be registered. Error code: {1:X}", fileName, res));
            }
        }

        public void Unregister(string fileName)
        {
            ITypeLib ppbc;
            var res = LoadTypeLib(fileName, out ppbc);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("File {0} is missing or is not a valid type library. Error code: {1:X}", fileName, res));
            }
            
            System.Runtime.InteropServices.ComTypes.TYPELIBATTR attr;
            IntPtr ptr;

            ppbc.GetLibAttr(out ptr);
            attr = (System.Runtime.InteropServices.ComTypes.TYPELIBATTR)Marshal.PtrToStructure(ptr, typeof(System.Runtime.InteropServices.ComTypes.TYPELIBATTR));
            var guid = attr.guid;

            res = _perUser ? UnRegisterTypeLibForUser(ref guid, attr.wMajorVerNum, attr.wMinorVerNum, attr.lcid, attr.syskind) : UnRegisterTypeLib(ref guid, attr.wMajorVerNum, attr.wMinorVerNum, attr.lcid, attr.syskind);
            
            if (res != 0)
            {
                throw new ApplicationException(string.Format("File {0} could not be unregisterd. Error code: {1:X}", fileName, res));
            }
        }

        [DllImport("oleaut32.dll")]
        private static extern int LoadTypeLib([MarshalAs(UnmanagedType.LPTStr)] string szFullPath, out ITypeLib ppbc);
        [DllImport("oleaut32.dll")]
        private static extern int RegisterTypeLib(ITypeLib ptlib, [MarshalAs(UnmanagedType.LPTStr)] string szFullPath, [MarshalAs(UnmanagedType.LPTStr)] string szHelpDir);
        [DllImport("oleaut32.dll")]
        private static extern int RegisterTypeLibForUser(ITypeLib ptlib, [MarshalAs(UnmanagedType.LPTStr)] string szFullPath, [MarshalAs(UnmanagedType.LPTStr)] string szHelpDir);

        [DllImport("oleaut32.dll")]
        private static extern int UnRegisterTypeLib(ref Guid libID, short wMajorVerNum, short wMinorVerNum, int lcid, System.Runtime.InteropServices.ComTypes.SYSKIND syskind);
        [DllImport("oleaut32.dll")]
        private static extern int UnRegisterTypeLibForUser(ref Guid libID, short wMajorVerNum, short wMinorVerNum, int lcid, System.Runtime.InteropServices.ComTypes.SYSKIND syskind);

     
    }
}
