using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace WKCA.Com.Utils
{
    public class BaseComRegistrationService
    {
        protected readonly bool _perUser;
        protected readonly RegistrationServices _regService;
        public BaseComRegistrationService(bool perUser = true)
        {
            _perUser = perUser;
            _regService = new RegistrationServices();
        }

        public virtual void Register(string dllPath, string hostProcessPath)
        {
            var asm = Assembly.LoadFrom(dllPath);
            ExecuteWithRegsitryKeyOverride(() =>
            {
                if (!_regService.RegisterAssembly(asm, AssemblyRegistrationFlags.None))
                {
                    throw new ApplicationException("Can not register assembly");
                }
                UpdateDefaultRegistration(asm, hostProcessPath);
            });
        }

        public virtual void Unregister(string dllPath, string hostProcessPath)
        {
            var asm = Assembly.LoadFrom(dllPath);

            ExecuteWithRegsitryKeyOverride(() =>
            {
                if (!_regService.UnregisterAssembly(asm))
                {
                    throw new ApplicationException("Can not unregister assembly");
                }
            });
        }

        protected virtual void  UpdateDefaultRegistration(Assembly asm, string hostProcessPath)
        {
            
        }

        protected void ExecuteWithRegsitryKeyOverride(Action action)
        {
            SetClassesRoot();

            try
            {
                action();
            }
            finally
            {
                RestoreClassesRoot();
            }
        }

        protected void SetClassesRoot()
        {
            if (!_perUser)
            {
                return;
            }

            UIntPtr hKey;
            var res = RegOpenKey(HKEY_CURRENT_USER, "Software\\Classes", out hKey);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("Can not open registry key. Error Code: {0:X}", res));
            }

            res = RegOverridePredefKey(HKEY_CLASSES_ROOT, hKey);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("Can not override registry key. Error Code: {0:X}", res));
            }

            RegCloseKey(hKey);
        }

        protected void RestoreClassesRoot()
        {
            if (!_perUser)
            {
                return;
            }
            var res = RegOverridePredefKey(HKEY_CLASSES_ROOT, UIntPtr.Zero);
            if (res != 0)
            {
                throw new ApplicationException(string.Format("Can not restore registry key. Error Code: {0:X}", res));
            }
        }
     
        [DllImport("advapi32.dll")]
        private static extern int RegOverridePredefKey(UIntPtr hKey, UIntPtr hNewHKey);

        [DllImport("advapi32.dll")]
        private static extern int RegOpenKey(UIntPtr hKey, string lpSubKey, out UIntPtr phkResult);

        [DllImport("advapi32.dll")]
        private static extern int RegCloseKey(UIntPtr hKey);


        private static UIntPtr HKEY_CLASSES_ROOT = new UIntPtr(0x80000000);
        private static UIntPtr HKEY_CURRENT_USER = new UIntPtr(0x80000001u);

    }
}
