using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA
{
    public partial class CurrentUserPropertiesDemo : Form
    {
        public CurrentUserPropertiesDemo()
        {
            InitializeComponent();
        }

        protected void SetObject(UserProperties props)
        {
            pgCU.SelectedObject = props;
        }

        public static void ShowCurrentUserProperties(IAppNetworkProviderService networkProvider)
        {
            using (var form = new CurrentUserPropertiesDemo())
            {
                UserProperties up = new UserProperties();
                IAppUser user = networkProvider.GetServer().Context();
                up.Name = user.GetName();
                up.FirstName = user.GetFirst_Name();
                up.Group = user.GetGroup();
                up.LastName = user.GetLast_Name();
                up.Email = user.GetEmail();
                up.ChangePasswordAtNextLogon = user.GetChangePasswordAtNextLogon();
                up.CannotChangePassword = user.GetCannotChangePassword();
                up.PasswordExpired = user.GetPasswordExpired();
                up.Disabled = user.GetDisabled();
                up.LockedOut = user.GetLockedOut();
                up.RemainingLockOutMinutes = user.GetRemainingLockOutMinutes();
                up.PasswordChangedAt = user.GetPasswordChangedAt();
                up.LockedOutToDateTime = user.GetLockedOutToDateTime();
                form.SetObject(up);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
            }
        }
    }

    public class UserProperties
    {
        public string Name { get; set; }
        public int Group { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool ChangePasswordAtNextLogon { get; set; }
        public bool CannotChangePassword { get; set; }
        public bool PasswordExpired { get; set; }
        public bool Disabled { get; set; }
        public bool LockedOut { get; set; }
        public int RemainingLockOutMinutes { get; set; }
        public DateTime PasswordChangedAt { get; set; }
        public DateTime LockedOutToDateTime { get; set; }

        public UserProperties()
        {

        }
    }
}
