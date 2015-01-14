using System;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.Win32;

namespace AddinReg
{
    public static class AddinRegistrator
    {
        public static void RegisterLoaderManagedAddin(string appName, string regKeyName, string addinDll,
            string className,
            string loaderDllPath, string configFile, string FpuCW)
        {
            //ini file
            var iniFile = new StringBuilder("[Addin]\r\n");
            iniFile.AppendFormat("FileName={0}\r\n", Path.GetFullPath(addinDll));
            iniFile.AppendFormat("ClassName={0}\r\n", className);
            iniFile.Append("Native=0\r\n");
            if (!string.IsNullOrWhiteSpace(configFile))
                iniFile.AppendFormat("ConfigFile={0}\r\n", configFile);
            if (!string.IsNullOrWhiteSpace(FpuCW))
                iniFile.AppendFormat("FPUCW={0}\r\n", FpuCW);
            File.WriteAllText(
                Path.Combine(Path.GetDirectoryName(Path.GetFullPath(loaderDllPath)),
                    Path.GetFileNameWithoutExtension(loaderDllPath) + ".ini"),
                iniFile.ToString(), Encoding.ASCII);
            RegisterSignedAddin(appName, regKeyName, loaderDllPath);
        }

        public static void RegisterLoaderManagedProxyAddin(string appName, string regKeyName, string addinDll,
            string className,
            string loaderDllPath, string configFile, string FpuCW, string proxyDll, string proxyShortName,
            string proxyName, string proxyGuid,
            string proxyVersion)
        {
            //ini file
            var iniFile = new StringBuilder("[Addin]\r\n");
            iniFile.AppendFormat("FileName={0}\r\n", Path.GetFullPath(addinDll));
            iniFile.AppendFormat("ClassName={0}\r\n", className);
            iniFile.Append("Native=0\r\n");
            if (!string.IsNullOrWhiteSpace(configFile))
                iniFile.AppendFormat("ConfigFile={0}\r\n", configFile);
            if (!string.IsNullOrWhiteSpace(FpuCW))
                iniFile.AppendFormat("FPUCW={0}\r\n", FpuCW);
            iniFile.Append("[Proxy]\r\n");
            iniFile.AppendFormat("Guid={0}\r\n", proxyGuid);
            iniFile.AppendFormat("Name={0}\r\n", proxyName);
            iniFile.AppendFormat("Version={0}\r\n", proxyVersion);
            iniFile.AppendFormat("ShortName={0}\r\n", proxyShortName);
            iniFile.AppendFormat("ProxyDllFileName={0}\r\n", Path.GetFullPath(proxyDll));
            File.WriteAllText(
                Path.Combine(Path.GetDirectoryName(Path.GetFullPath(loaderDllPath)),
                    Path.GetFileNameWithoutExtension(loaderDllPath) + ".ini"),
                iniFile.ToString(), Encoding.ASCII);
            RegisterSignedAddin(appName, regKeyName, loaderDllPath);
        }

        public static void RegisterLoaderNativeAddin(string appName, string regKeyName, string addinDll,
            string loaderDllPath)
        {
            //ini file
            var iniFile = new StringBuilder("[Addin]\r\n");
            iniFile.AppendFormat("FileName={0}\r\n", Path.GetFullPath(addinDll));
            iniFile.Append("Native=1\r\n");
            File.WriteAllText(
                Path.Combine(Path.GetDirectoryName(Path.GetFullPath(loaderDllPath)),
                    Path.GetFileNameWithoutExtension(loaderDllPath) + ".ini"),
                iniFile.ToString(), Encoding.ASCII);
            RegisterSignedAddin(appName, regKeyName, loaderDllPath);
        }

        public static void RegisterLoaderNativeProxyAddin(string appName, string regKeyName, string addinDll,
            string loaderDllPath,
            string proxyDll, string proxyShortName, string proxyName, string proxyGuid, string proxyVersion)
        {
            //ini file
            var iniFile = new StringBuilder("[Addin]\r\n");
            iniFile.AppendFormat("FileName={0}\r\n", Path.GetFullPath(addinDll));
            iniFile.Append("Native=1\r\n");
            iniFile.Append("[Proxy]\r\n");
            iniFile.AppendFormat("Guid={0}\r\n", proxyGuid);
            iniFile.AppendFormat("Name={0}\r\n", proxyName);
            iniFile.AppendFormat("Version={0}\r\n", proxyVersion);
            iniFile.AppendFormat("ShortName={0}\r\n", proxyShortName);
            iniFile.AppendFormat("ProxyDllFileName={0}\r\n", Path.GetFullPath(proxyDll));
            File.WriteAllText(
                Path.Combine(Path.GetDirectoryName(Path.GetFullPath(loaderDllPath)),
                    Path.GetFileNameWithoutExtension(loaderDllPath) + ".ini"),
                iniFile.ToString(), Encoding.ASCII);
            RegisterSignedAddin(appName, regKeyName, loaderDllPath);
        }

        public static void RegisterProxyAddin(string appName, string addinRegistryKeyName, string addinShortName,
            string addinDllPath, string proxyDllPath, string proxyName, string proxyGuid, string proxyVersion)
        {
            //change the config file
            if (!File.Exists(proxyDllPath))
                throw new Exception("Proxy add-in is not existed");
            var configFilePath = proxyDllPath + ".config";
            if (!File.Exists(configFilePath))
                throw new Exception("Proxy add-in config file is not existed");
            var xml = new XmlDocument();
            xml.Load(configFilePath);
            var nodes = xml.DocumentElement.SelectSingleNode("/configuration/appSettings");
            foreach (XmlNode node in nodes)
            {
                if (node.Attributes["key"].Value.Equals("AddinName", StringComparison.InvariantCultureIgnoreCase))
                    node.Attributes["value"].Value = proxyName;
                else if (node.Attributes["key"].Value.Equals("AddinShortName",
                    StringComparison.InvariantCultureIgnoreCase))
                    node.Attributes["value"].Value = addinShortName;
                else if (node.Attributes["key"].Value.Equals("AddinGuid", StringComparison.InvariantCultureIgnoreCase))
                    node.Attributes["value"].Value = proxyGuid.ToUpper();
                else if (node.Attributes["key"].Value.Equals("AddinVersion",
                    StringComparison.InvariantCultureIgnoreCase))
                    node.Attributes["value"].Value = proxyVersion;
                else if (node.Attributes["key"].Value.Equals("AddinDLL",
                    StringComparison.InvariantCultureIgnoreCase))
                    node.Attributes["value"].Value = addinDllPath;
            }
            //File.Delete(configFilePath);
            xml.Save(configFilePath);
            RegisterSignedAddin(appName, addinRegistryKeyName, proxyDllPath);
        }

        public static void RegisterSignedAddin(string appName, string registryKey, string addinDllPath)
        {
            var key =
                Registry.CurrentUser.CreateSubKey(string.Format("Software\\CCH\\{0}\\Addins\\{1}", appName, registryKey));
            key.SetValue("FileName", addinDllPath);
        }

        public static void UnregisterAddin(string appName, string addinName)
        {
            var key = Registry.CurrentUser.OpenSubKey(string.Format("Software\\CCH\\{0}\\Addins", appName), true);
            if (key == null || key.OpenSubKey(addinName) == null)
            {
                Console.WriteLine("Add-in is not registered");
            }
            else
            {
                key.DeleteSubKeyTree(addinName);
                Console.WriteLine("Add-in has been unregistered successfully");
            }
        }

        public static void ClearRegisteredAddIns(string appName)
        {
            var key = Registry.CurrentUser.OpenSubKey(string.Format("Software\\CCH\\{0}\\Addins", appName), true);
            if (key != null)
            {
                foreach (var addinkey in key.GetSubKeyNames())
                {
                    key.DeleteSubKeyTree(addinkey);
                }
            }
            Console.WriteLine("Cleaned up successully");
        }
    }
}