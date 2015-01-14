using System;
using System.IO;
using System.Linq;
using CommandLine;
using CommandLine.Text;

namespace AddinReg
{
    [Flags]
    public enum RegisterModeType
    {
        None = 0,
        Unknown = 1,
        Unregister = 2,
        Signed = 4,
        Proxy = 8,
        LoaderManaged = 16,
        LoaderNative = 32,
        LoaderManagedProxy = 64,
        LoaderNativeProxy = 128,

        AnyMode = LoaderManaged | LoaderManagedProxy | LoaderNative
                  | LoaderNativeProxy | Unknown | Proxy | Signed
                  | Unregister,
        AnyProxy = LoaderManagedProxy | LoaderNativeProxy | Proxy,

        AnyLoader = LoaderManaged | LoaderManagedProxy | LoaderNative
                    | LoaderNativeProxy,

        AnyRegisteration = LoaderManaged | LoaderManagedProxy | LoaderNative
                           | LoaderNativeProxy | Proxy | Signed
    };

    internal class AddinRegOptionAttribute : BaseOptionAttribute
    {
        public AddinRegOptionAttribute()
        {
            AllowedModes = RegisterModeType.AnyMode;
            RequiredFor = RegisterModeType.None;
            IsPath = false;
        }

        public AddinRegOptionAttribute(char shortName)
            : base(shortName, null)
        {
            AllowedModes = RegisterModeType.AnyMode;
            RequiredFor = RegisterModeType.None;
            IsPath = false;
        }

        public AddinRegOptionAttribute(string longName)
            : base(null, longName)
        {
            AllowedModes = RegisterModeType.AnyMode;
            RequiredFor = RegisterModeType.None;
            IsPath = false;
        }

        public AddinRegOptionAttribute(char shortName, string longName)
            : base(shortName, longName)
        {
            AllowedModes = RegisterModeType.AnyMode;
            RequiredFor = RegisterModeType.None;
            IsPath = false;
        }

        public RegisterModeType AllowedModes { get; set; }
        public RegisterModeType RequiredFor { get; set; }
        public bool IsPath { get; set; }
    }

    public class Options
    {
        private static Options instance;

        [AddinRegOption('t', "application", Required = true,
            HelpText = "Taxprep application name (For example \"T1 Taxprep 2014\"",
            AllowedModes = RegisterModeType.AnyMode, RequiredFor = RegisterModeType.AnyMode)]
        public string Application { get; set; }

        [AddinRegOption('c', "clear", DefaultValue = false, HelpText = "remove all add-ins for the specified version",
            AllowedModes = RegisterModeType.AnyMode)]
        public bool isToBeCleared { get; set; }

        [AddinRegOption('r', "registerSigned", DefaultValue = false, HelpText = "Register signed add-in",
            AllowedModes = RegisterModeType.Signed, RequiredFor = RegisterModeType.Signed)]
        public bool isRegisterSigned { get; set; }

        [AddinRegOption('u', "unregister", DefaultValue = false, HelpText = "Unregister add-in",
            AllowedModes = RegisterModeType.Unregister, RequiredFor = RegisterModeType.Unregister)]
        public bool isUnRegister { get; set; }

        [AddinRegOption('p', "registerProxy", DefaultValue = false, HelpText = "Register proxy add-in",
            AllowedModes = RegisterModeType.AnyProxy, RequiredFor = RegisterModeType.AnyProxy)]
        public bool isRegisterProxy { get; set; }

        [AddinRegOption('l', "loaderManaged", DefaultValue = false,
            HelpText = "Register signed managed add-in via Loader",
            AllowedModes = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy,
            RequiredFor = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy)]
        public bool isRegisterLoaderManaged { get; set; }

        [AddinRegOption('n', "loaderNative", DefaultValue = false, HelpText = "Register signed native add-in via Loader",
            AllowedModes = RegisterModeType.LoaderNative | RegisterModeType.LoaderNativeProxy,
            RequiredFor = RegisterModeType.LoaderNative | RegisterModeType.LoaderNativeProxy)]
        public bool isRegisterLoaderNative { get; set; }

        [AddinRegOption('k', "registryKeyName", Required = false,
            HelpText = "The registry key name, where the add-in will be registered",
            AllowedModes = RegisterModeType.AnyRegisteration | RegisterModeType.Unregister,
            RequiredFor = RegisterModeType.AnyRegisteration | RegisterModeType.Unregister)]
        public string AddinRegistryKeyName { get; set; }

        [AddinRegOption('d', "addinDllPath", HelpText = "The full path to add-in DLL",
            AllowedModes = RegisterModeType.AnyRegisteration,
            RequiredFor = RegisterModeType.AnyRegisteration, IsPath = true)]
        public string AddinDllPath { get; set; }

        [AddinRegOption("proxyDllPath", HelpText = "The full path to the proxy dll",
            AllowedModes = RegisterModeType.AnyProxy,
            RequiredFor = RegisterModeType.AnyProxy, IsPath = true)]
        public string ProxyDllPath { get; set; }

        [AddinRegOption("loaderDllPath", HelpText = "The full path to the loader dll",
            AllowedModes = RegisterModeType.AnyLoader,
            RequiredFor = RegisterModeType.AnyLoader, IsPath = true)]
        public string LoaderDllPath { get; set; }

        [AddinRegOption("addinShortName", HelpText = "The short name of add-in (for proxy)",
            AllowedModes = RegisterModeType.AnyProxy,
            RequiredFor = RegisterModeType.AnyProxy)]
        public string AddinShortNameProxy { get; set; }

        [AddinRegOption("addinName", HelpText = "The full name of add-in (for proxy)",
            AllowedModes = RegisterModeType.AnyProxy,
            RequiredFor = RegisterModeType.AnyProxy)]
        public string AddinNameProxy { get; set; }

        [AddinRegOption("addinGuid", HelpText = "The add-in GUID (for proxy)", AllowedModes = RegisterModeType.AnyProxy,
            RequiredFor = RegisterModeType.AnyProxy)]
        public Guid? AddinGuidProxy { get; set; }

        [AddinRegOption("addinVersion", HelpText = "The add-in version (for proxy)",
            AllowedModes = RegisterModeType.AnyProxy,
            RequiredFor = RegisterModeType.AnyProxy)]
        public string AddinVersionProxy { get; set; }

        [AddinRegOption("addinClassName", HelpText = "The add-in full classs name (for managed loader)",
            AllowedModes = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy,
            RequiredFor = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy)]
        public string AddinClassName { get; set; }

        [AddinRegOption("addinConfigFile", HelpText = "The add-in config file full path (for managed loader)",
            AllowedModes = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy, IsPath = true)]
        public string AddinConfigFile { get; set; }

        [AddinRegOption("fpuCW", HelpText = "The FPU CW value for loader: default - for native or intValue",
            AllowedModes = RegisterModeType.LoaderManaged | RegisterModeType.LoaderManagedProxy)]
        public string FpuCW { get; set; }

        [ParserState]
        public IParserState LastParserState { get; set; }

        public RegisterModeType RegisterMode
        {
            get
            {
                RegisterModeType lResult;
                if (isUnRegister && !isRegisterSigned && !isRegisterLoaderManaged && !isRegisterLoaderNative &&
                    !isRegisterProxy)
                    lResult = RegisterModeType.Unregister;
                else if (!isUnRegister && isRegisterSigned && !isRegisterLoaderManaged && !isRegisterLoaderNative &&
                         !isRegisterProxy)
                    lResult = RegisterModeType.Signed;
                else if (!isUnRegister && !isRegisterSigned && isRegisterLoaderManaged && !isRegisterLoaderNative &&
                         !isRegisterProxy)
                    lResult = RegisterModeType.LoaderManaged;
                else if (!isUnRegister && !isRegisterSigned && isRegisterLoaderManaged && !isRegisterLoaderNative &&
                         isRegisterProxy)
                    lResult = RegisterModeType.LoaderManagedProxy;
                else if (!isUnRegister && !isRegisterSigned && !isRegisterLoaderManaged &&
                         isRegisterLoaderNative && !isRegisterProxy)
                    lResult = RegisterModeType.LoaderNative;
                else if (!isUnRegister && !isRegisterSigned && !isRegisterLoaderManaged &&
                         isRegisterLoaderNative && isRegisterProxy)
                    lResult = RegisterModeType.LoaderNativeProxy;
                else if (!isUnRegister && !isRegisterSigned && !isRegisterLoaderManaged &&
                         !isRegisterLoaderNative && isRegisterProxy)
                    lResult = RegisterModeType.Proxy;
                else if (!isUnRegister && !isRegisterSigned && !isRegisterLoaderManaged &&
                         !isRegisterLoaderNative && !isRegisterProxy)
                    lResult = RegisterModeType.Unknown;
                else
                    throw new InvalidOperationException("Invalid actions combination");
                return lResult;
            }
        }

        public static Options Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Options();
                    Parser.Default.ParseArgumentsStrict(Environment.GetCommandLineArgs(),
                        instance, () =>
                        {
                            ConsoleHelper.ReleaseConsoleHandles();
                            Environment.Exit(-1);
                        });
                    var s = instance.Validate();
                    if (!string.IsNullOrEmpty(s))
                    {
                        Console.WriteLine("Error in parameters: {0}\nUsage:\n{1}", s, instance.GetUsage());
                        ConsoleHelper.ReleaseConsoleHandles();
                        Environment.Exit(-1);
                    }
                }
                return instance;
            }
        }

        [HelpOption]
        public string GetUsage()
        {
            return HelpText.AutoBuild(this,
                (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
        }

        private string Validate()
        {
            var properties = from a in typeof (Options).GetProperties()
                where a.GetCustomAttributes(true).Any(B => { return B is AddinRegOptionAttribute; })
                select a;

            if (string.IsNullOrWhiteSpace(Application))
                return "Application is not specified";
            try
            {
                var mode = RegisterMode;
                foreach (var property in properties)
                {
                    var attribute = (AddinRegOptionAttribute) property.GetCustomAttributes(true).First(
                        B => { return B is AddinRegOptionAttribute; });
                    var isAssigned = false;
                    if (property.PropertyType == typeof (bool))
                    {
                        isAssigned = (bool) property.GetValue(this, null);
                    }
                    else if (property.PropertyType.IsPrimitive)
                    {
                        isAssigned = true;
                    }
                    else if (property.PropertyType == typeof (string))
                    {
                        var value = (string) property.GetValue(this, null);
                        isAssigned = !string.IsNullOrWhiteSpace(value);
                        if (isAssigned && attribute.IsPath)
                        {
                            isAssigned = File.Exists(value);
                        }
                    }
                    else
                    {
                        var value = property.GetValue(this, null);
                        isAssigned = value != null;
                    }
                    //check for allowed types
                    if (isAssigned && ((mode & attribute.AllowedModes) != mode))
                        return string.Format("The parameter {0} is not allowed for selected action {1}",
                            attribute.LongName, mode);
                    if (!isAssigned && ((mode & attribute.RequiredFor) == mode))
                        return string.Format("The parameter {0} is required for selected action {1}", attribute.LongName,
                            mode);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return "";
        }
    }
}