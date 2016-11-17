using System;
using System.Linq;
using System.Windows.Forms;

namespace AddinReg
{
    internal static class Program
    {
        [STAThread]
        private static void Main(string[] args)
        {
            if (args.Count() == 0)
            {
                // launch the WinForms application like normal
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Interractive());
            }
            else
            {
                ConsoleHelper.InitConsoleHandles();
                try
                {
                    //AttachConsole(ATTACH_PARENT_PROCESS);
                    try
                    {
                        if (Options.Instance.isToBeCleared)
                        {
                            AddinRegistrator.ClearRegisteredAddIns(Options.Instance.Application);
                        }
                        switch (Options.Instance.RegisterMode)
                        {
                            case RegisterModeType.Unknown:
                                break;
                            case RegisterModeType.Unregister:
                                AddinRegistrator.UnregisterAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName);
                                break;
                            case RegisterModeType.Signed:
                                AddinRegistrator.RegisterSignedAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinDllPath);
                                break;
                            case RegisterModeType.Proxy:
                                AddinRegistrator.RegisterProxyAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinShortNameProxy, Options.Instance.AddinDllPath,
                                    Options.Instance.ProxyDllPath,
                                    Options.Instance.AddinNameProxy, Options.Instance.AddinGuidProxy.ToString(),
                                    Options.Instance.AddinVersionProxy);
                                break;
                            case RegisterModeType.LoaderManaged:
                                AddinRegistrator.RegisterLoaderManagedAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinDllPath, Options.Instance.AddinClassName,
                                    Options.Instance.LoaderDllPath,
                                    Options.Instance.AddinConfigFile, Options.Instance.FpuCW);
                                break;
                            case RegisterModeType.LoaderManagedProxy:
                                AddinRegistrator.RegisterLoaderManagedProxyAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinDllPath, Options.Instance.AddinClassName,
                                    Options.Instance.LoaderDllPath,
                                    Options.Instance.AddinConfigFile, Options.Instance.FpuCW,
                                    Options.Instance.ProxyDllPath,
                                    Options.Instance.AddinShortNameProxy, Options.Instance.AddinNameProxy,
                                    Options.Instance.AddinGuidProxy.ToString(),
                                    Options.Instance.AddinVersionProxy);
                                break;
                            case RegisterModeType.LoaderNative:
                                AddinRegistrator.RegisterLoaderNativeAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinDllPath, Options.Instance.LoaderDllPath);
                                break;
                            case RegisterModeType.LoaderNativeProxy:
                                AddinRegistrator.RegisterLoaderNativeProxyAddin(Options.Instance.Application,
                                    Options.Instance.AddinRegistryKeyName,
                                    Options.Instance.AddinDllPath, Options.Instance.LoaderDllPath,
                                    Options.Instance.ProxyDllPath,
                                    Options.Instance.AddinShortNameProxy, Options.Instance.AddinNameProxy,
                                    Options.Instance.AddinGuidProxy.ToString(),
                                    Options.Instance.AddinVersionProxy);
                                break;
                            default:
                                throw new InvalidOperationException(string.Format("Unknown action type {0}",
                                    Options.Instance.RegisterMode));
                        }
                        Console.WriteLine("Operation completed successfuly");
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.ToString());
                        Console.WriteLine("Return");
                        ConsoleHelper.ReleaseConsoleHandles();
                        Environment.Exit(-2);
                    }
                }
                finally
                {
                    ConsoleHelper.ReleaseConsoleHandles();
                }
            }
        }
    }
}