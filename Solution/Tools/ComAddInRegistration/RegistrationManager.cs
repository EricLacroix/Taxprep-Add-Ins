using System;
using WKCA.Com.Utils;

namespace RegCom
{
    class RegistrationManager
    {
        private readonly RegistrationRequest _request;
        public RegistrationManager(RegistrationRequest request)
        {
            _request = request;
        }
        public bool Run()
        {
            switch (_request.RegistrationAction)
            {
                case RegistrationAction.Register:
                    return Register();
                case RegistrationAction.Unregister:
                    return Unregister();
            }
            return false;
        }

        private bool Register()
        {
            if (!string.IsNullOrWhiteSpace(_request.TlbFileName))
            {
                var tlbRegistrationService = new TlbRegistrationService(_request.PerUser);
                try
                {
                    tlbRegistrationService.Register(_request.TlbFileName);
                    Console.WriteLine("Type library registered successfully");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Type library registration failed. {0}", ex.Message);
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(_request.DllFileName))
            {
                var outOfProcComRegistrationService = new TaxPrepComRegistrationService(_request.PerUser);
                try
                {
                    outOfProcComRegistrationService.Register(_request.DllFileName, _request.ExeFileName);
                    Console.WriteLine("Out of proc COM server registered successfully");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Out of proc COM server registration failed. {0}", ex.Message);
                    return false;
                }
            }
            return true;
        }

        private bool Unregister()
        {
            if (!string.IsNullOrWhiteSpace(_request.TlbFileName))
            {
                var tlbRegistrationService = new TlbRegistrationService(_request.PerUser);
                try
                {
                    tlbRegistrationService.Unregister(_request.TlbFileName);
                    Console.WriteLine("Type library unregistered successfully");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Type library unregistration failed. {0}", ex.Message);
                    return false;
                }
            }

            if (!string.IsNullOrWhiteSpace(_request.DllFileName))
            {
                var outOfProcComRegistrationService = new TaxPrepComRegistrationService(_request.PerUser);
                try
                {
                    outOfProcComRegistrationService.Unregister(_request.DllFileName, _request.ExeFileName);
                    Console.WriteLine("Out of proc COM server unregistered successfully");
                }
                catch (ApplicationException ex)
                {
                    Console.WriteLine("Out of proc COM server unregistration failed. {0}", ex.Message);
                    return false;
                }
            }
            return true;
        }
    }
}
