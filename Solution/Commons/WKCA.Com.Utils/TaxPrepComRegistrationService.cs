using System;
using System.IO;
using System.Reflection;
using Microsoft.Win32;

namespace WKCA.Com.Utils
{
    public class TaxPrepComRegistrationService : OutOfProcComRegistrationService
    {
        private readonly ComRegistrationHelper _helper;

        public TaxPrepComRegistrationService(bool perUser = true) : base(perUser)
        {
            _helper = new ComRegistrationHelper();
        }

        public override void Register(string dllPath, string exePath)
        {
            var asm = Assembly.LoadFrom(dllPath);
            ExecuteWithRegsitryKeyOverride(() =>
            {
                var types = _regService.GetRegistrableTypesInAssembly(asm);
                foreach (var type in types)
                {
                    RegisterLocalServerType(type, exePath);
                }
            });
        }

        public override void Unregister(string dllPath, string hostProcessPath)
        {
            var asm = Assembly.LoadFrom(dllPath);
            ExecuteWithRegsitryKeyOverride(() =>
            {
                var types = _regService.GetRegistrableTypesInAssembly(asm);
                foreach (var type in types)
                {
                    UnregisterLocalServerType(type, hostProcessPath);
                }
            });
        }

        private void RegisterLocalServerType(Type t, string hostProcessPath)
        {
            var versionSpecificGuid = _helper.CreateApplicationSpecificGuidFromTemplate(t.GUID.ToString(), Path.GetFileName(hostProcessPath));
            var progId = _helper.GetProgId(hostProcessPath, t.Name);

            DeleteRegistryKeyIfExists(progId);
            DeleteRegistryKeyIfExists(string.Format(@"CLSID\{0}", versionSpecificGuid.ToString("B")));

            using (var keyObjectName = Registry.ClassesRoot.CreateSubKey(progId))
            {
                keyObjectName.SetValue("", t.FullName);
                using (var keyObjectCLSID = keyObjectName.CreateSubKey("CLSID"))
                {
                    keyObjectCLSID.SetValue("", versionSpecificGuid.ToString("B"));
                }
            }

            using (var keyCLSID = Registry.ClassesRoot.CreateSubKey(string.Format(@"CLSID\{0}", versionSpecificGuid.ToString("B"))))
            {
                keyCLSID.SetValue("", progId);
                using (RegistryKey subkey = keyCLSID.CreateSubKey("LocalServer32"))
                {
                    subkey.SetValue("", hostProcessPath, RegistryValueKind.String);
                }
            }
        }

        private void UnregisterLocalServerType(Type t, string hostProcessPath)
        {
            var versionSpecificGuid = _helper.CreateApplicationSpecificGuidFromTemplate(t.GUID.ToString(), Path.GetFileName(hostProcessPath));
            var progId = _helper.GetProgId(hostProcessPath, t.Name);
            DeleteRegistryKeyIfExists(progId);
            DeleteRegistryKeyIfExists(string.Format(@"CLSID\{0}", versionSpecificGuid.ToString("B")));
        }

        private void DeleteRegistryKeyIfExists(string name)
        {
            var keyExists = false;
            using (var key = Registry.ClassesRoot.OpenSubKey(name))
            {
                keyExists = key != null;
            }

            if (keyExists)
            {
                Registry.ClassesRoot.DeleteSubKeyTree(name);
            }
        }
    }
}
