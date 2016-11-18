using System;
using System.Reflection;
using Microsoft.Win32;

namespace WKCA.Com.Utils
{
    public class OutOfProcComRegistrationService : BaseComRegistrationService
    {
        public OutOfProcComRegistrationService(bool perUser = true) : base(perUser)
        {
        }


        protected override void UpdateDefaultRegistration(Assembly asm, string hostProcessPath)
        {
            if (string.IsNullOrWhiteSpace(hostProcessPath))
            {
                throw new ApplicationException(
                    "Hosting process path is required for out of proc COM server registration");
            }
            var types = _regService.GetRegistrableTypesInAssembly(asm);
            foreach (var type in types)
            {
                UpdateDefaultTypeRegistration(type, hostProcessPath);
            }
        }

        private void UpdateDefaultTypeRegistration(Type t, string hostProcessPath)
        {
            using (
                var keyCLSID = Registry.ClassesRoot.OpenSubKey(string.Format(@"CLSID\{0}", t.GUID.ToString("B")), true))
            {
                keyCLSID.DeleteSubKeyTree("InprocServer32");
                using (var subkey = keyCLSID.CreateSubKey("LocalServer32"))
                {
                    subkey.SetValue("", hostProcessPath, RegistryValueKind.String);
                }
            }
        }
    }
}