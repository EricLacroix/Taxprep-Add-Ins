using System;
using System.Text.RegularExpressions;

namespace WKCA.Com.Utils
{
    public class ComRegistrationHelper
    {
        private string _productNameCode;
        private string _productVersion;
        private string _productYear;

        /// <summary>
        ///     Replaces first 6 zero digits of Guid with TaxPrep specific values.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="taxPrepFileName"></param>
        /// <returns></returns>
        public Guid CreateApplicationSpecificGuidFromTemplate(string template, string taxPrepFileName)
        {
            var productSpecificPart = GetApplicationSpecificPrefix(taxPrepFileName);
            var versionSpecificGuid = Regex.Replace(template, @"^(?<versionPart>\d{6})", productSpecificPart);
            return new Guid(versionSpecificGuid);
        }

        public string GetApplicationSpecificPrefix(string exeName)
        {
            ParseTaxPrepExeName(exeName);
            var productVersion = _productVersion ?? "0";
            return string.Format($"{_productNameCode}{_productYear}{productVersion}");
        }

        public string GetApplicationNamespace(string exeName)
        {
            ParseTaxPrepExeName(exeName);
            return _productVersion != null
                ? string.Format($"t{_productNameCode}_taxprep_{_productYear}-{_productVersion}")
                : string.Format($"t{_productNameCode}_taxprep_{_productYear}");
        }

        public string GetProgId(string exeName, string typeName)
        {
            var appNamespace = GetApplicationNamespace(exeName);
            return string.Format($"Cch.{appNamespace}.{typeName}");
        }

        private void ParseTaxPrepExeName(string exeName)
        {
            //Names should be like: T1Txp2014, T2Txp2014V2
            var taxPrepFileNameRegex = new Regex(@"T(?<productCode>\d{1})Txp(?<year>\d{4})(V(?<version>\d{1}))?");
            var match = taxPrepFileNameRegex.Match(exeName);
            if (!match.Success)
            {
                throw new NotImplementedException($"Application {exeName} is not supported");
            }

            _productNameCode = match.Groups["productCode"].Value;
            _productYear = match.Groups["year"].Value;
            _productVersion = match.Groups["version"].Success ? match.Groups["version"].Value : null;
        }
    }
}