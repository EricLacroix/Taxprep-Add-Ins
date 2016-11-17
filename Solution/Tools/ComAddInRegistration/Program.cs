using System;

namespace RegCom
{
  
    class Program
    {
        static void ShowUsage()
        {
            Console.WriteLine("COM objects registration utility. Could be used for:");
            Console.WriteLine("\t- Registration of out of proc COM server");
            Console.WriteLine("\t- Registration of COM type library");
            Console.WriteLine();
            Console.WriteLine("Syntax: RegCom [Options] /tlb:TypeLibraryFileName.tlb /dll:OutOfProc.dll /exe:ExeHostingOutOfProcDll.exe");
            Console.WriteLine();
            Console.WriteLine("Options:");
            Console.WriteLine("\t{0,-25} {1}", "/? or /help", "Display this usage message");
            Console.WriteLine("\t{0,-25} {1}", "/r or /register", "Perform registration");
            Console.WriteLine("\t{0,-25} {1}", "/u or /unregister", "Perform unregistration");
            Console.WriteLine("\t{0,-25} {1}", "/key:user", "Per-user registration (in HKEY_CURRENT_USER) - default option");
            Console.WriteLine("\t{0,-25} {1}", "/key:classes", "Registration in HKEY_CLASSES_ROOT");
            Console.WriteLine("\t{0,-25} {1}", "/tlb:path", "Path to type library file");
            Console.WriteLine("\t{0,-25} {1}", "/dll:path", "Path to dll containing out of proc COM server");
            Console.WriteLine("\t{0,-25} {1}", "/exe:path", "Path to exe file hosting out of proc dll COM server");
            Console.WriteLine();
            Console.WriteLine("Example: register type library only");
            Console.WriteLine("\tRegCom /r /tlb:tlb_D7.tlb");
            Console.WriteLine();
            Console.WriteLine("Example: register out of proc COM server only");
            Console.WriteLine("\tRegCom /r /dll:ComAddIn.dll /exe:T1Txp2015.exe");
            Console.WriteLine();
            Console.WriteLine("Example: register both type library and out of proc COM server");
            Console.WriteLine("\tRegCom /r /tlb:tlb_D7.tlb /dll:ComAddIn.dll /exe:T1Txp2015.exe");
        }

        static void ShowInvalidArgs()
        {
            Console.WriteLine("RegCom error: invalid parameters");
        }

        static int Main(string[] args)
        {
            var parser = new ParamsParser(args);
            RegistrationRequest result;
            try
            {
                result = parser.Parse();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Invalid arguments. {0}", ex.Message);
                return -1;
            }

            if (result.RegistrationAction == RegistrationAction.Help)
            {
                ShowUsage();
                return 0;
            }
            var registrationManager = new RegistrationManager(result);
            return  registrationManager.Run() ? 0 : -1;
        }
    }
}
