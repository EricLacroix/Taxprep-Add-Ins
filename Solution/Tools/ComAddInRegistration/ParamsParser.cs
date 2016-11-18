using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegCom
{
    public class ParamsParser
    {
        private readonly string[] _args;

        public ParamsParser(string[] args)
        {
            _args = args;
        }

        public RegistrationRequest Parse()
        {
            if (_args.Length == 0)
            {
                return RegistrationRequest.GetHelpResult();
            }

            if (_args.Length == 1 && (StrEquals(_args[0], "/?") || StrEquals(_args[0], "/help")))
            {
                return RegistrationRequest.GetHelpResult();
            }

            var result = new RegistrationRequest
            {
                RegistrationAction = GetAction(),
                TlbFileName = GetParamValue(_args, "tlb"),
                DllFileName = GetParamValue(_args, "dll"),
                ExeFileName = GetParamValue(_args, "exe"),
                PerUser = GetPerUser()
            };

            ValidateResult(result);

            return result;
        }

        private bool StrEquals(string s1, string s2)
        {
            return string.Compare(s1, s2, StringComparison.InvariantCultureIgnoreCase) == 0;
        }

        private string GetParamValue(string[] args, string paramName)
        {
            var regex = new Regex(string.Format("/{0}:(?<FilePath>.+)", paramName));
            var param = args.FirstOrDefault(arg => regex.IsMatch(arg));

            if (param == null)
            {
                return null;
            }

            var res = regex.Match(param);
            return res.Groups["FilePath"].Value;
        }

        private RegistrationAction GetAction()
        {
            var reg = _args.Any(arg => StrEquals(arg, "/r") || StrEquals(arg, "/register"));
            if (reg)
            {
                return RegistrationAction.Register;
            }
            var unreg = _args.Any(arg => StrEquals(arg, "/u") || StrEquals(arg, "/unregister"));
            if (unreg)
            {
                return RegistrationAction.Unregister;
            }
            //If nothing is specified do registration
            return RegistrationAction.Register;
        }

        private bool GetPerUser()
        {
            var key = GetParamValue(_args, "key");
            if (key == null || StrEquals(key, "user"))
            {
                return true;
            }
            if (StrEquals(key, "classes"))
            {
                return false;
            }
            throw new ArgumentException(
                string.Format("Incorrect key value: /key:{0}. Expected: /key:user or /key:classes", key));
        }

        private void ValidateResult(RegistrationRequest result)
        {
            if (result.RegistrationAction == RegistrationAction.Register &&
                string.IsNullOrWhiteSpace(result.DllFileName) && string.IsNullOrWhiteSpace(result.TlbFileName))
            {
                throw new ArgumentException("File names for registration are missing");
            }

            if (result.RegistrationAction == RegistrationAction.Unregister &&
                string.IsNullOrWhiteSpace(result.DllFileName) && string.IsNullOrWhiteSpace(result.TlbFileName))
            {
                throw new ArgumentException("File names for unregistration are missing");
            }

            if (!string.IsNullOrWhiteSpace(result.DllFileName) && string.IsNullOrWhiteSpace(result.ExeFileName))
            {
                throw new ArgumentException(
                    "Path to exe file hosting out of proc dll COM server should be specified for out of proc COM server registration");
            }

            if (string.IsNullOrWhiteSpace(result.DllFileName) && !string.IsNullOrWhiteSpace(result.ExeFileName))
            {
                throw new ArgumentException(
                    "Path to dll containing out of proc COM server should be specified for out of proc COM server registration");
            }
        }
    }
}