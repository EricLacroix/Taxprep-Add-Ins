namespace RegCom
{
    public enum RegistrationAction
    {
        Help,
        Register,
        Unregister
    };

    public class RegistrationRequest
    {
        public RegistrationAction RegistrationAction { get; set; }
        public string TlbFileName { get; set; }
        public string DllFileName { get; set; }
        public string ExeFileName { get; set; }

        public bool PerUser { get; set; }

        public static RegistrationRequest GetHelpResult()
        {
            return new RegistrationRequest()
            {
                RegistrationAction = RegistrationAction.Help
            };
        }
    }
 }
