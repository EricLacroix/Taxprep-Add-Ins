using System;
using System.Runtime.InteropServices;
using TaxprepAddinAPI;

namespace WKCA.AddIn
{
    public abstract class AddinInstanceBase : IAddinInstance
    {
        protected IAppInstance _appInstance;
        private Guid _key;

        public AddinInstanceBase(Guid AKey, string AName, string AVersion)
        {
            _key = AKey;
            Name = AName;
            Version = AVersion;
        }

        public virtual void ReleaseApp()
        {
            // do nothing
        }

        public abstract void InitializeTaxPrepAddin();

        [AttributeUsage(AttributeTargets.Class)]
        public class AddinInstance : Attribute
        {
        }

        #region IAddinInstance Implementation

        //['{FBE92BC9-B889-49A3-A70D-FE4129071301}']
        public Guid Key
        {
            get { return Key; }
        }

        public string Name { get; private set; }

        public string Version { get; private set; }

        public void Initialize(
            [In, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof (AddinMarshaler))] IAppInstance
                appInstance)
        {
            _appInstance = appInstance;
            InitializeTaxPrepAddin();
        }

        #endregion
    }
}