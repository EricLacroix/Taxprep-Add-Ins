using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class ConfigurationDemo : Form
    {
        public ConfigurationDemo()
        {
            InitializeComponent();
        }

        public static void ShowConfiguration(IAppConfiguration aConfiguration)
        {
            using (var form = new ConfigurationDemo())
            {
                form.ReopenLastUsedForms.Checked = aConfiguration.AsBoolean("Tax Return", "ReopenLastUsedForms", false);
                form.Max.Text = aConfiguration.AsString("AutoText", "Max", "0");
                form.QuickOverride.Checked = !aConfiguration.AsBoolean("FormEngine", "QuickOverride", false);
                form.HaveToShowValidation.Checked = aConfiguration.AsBoolean("Diagnostics", "HaveToShowValidation",
                    false);
                form.ShowLastYearDataInTaxReturn.Checked = aConfiguration.AsBoolean("FormEngine",
                    "ShowLastYearDataInTaxReturn", false);
                form.AlwaysRecalculate.Checked = aConfiguration.AsBoolean("Tax Return", "AlwaysRecalculate", false);
                form.AlwaysUpdateProfil.Checked = aConfiguration.AsBoolean("Tax Return", "AlwaysUpdateProfil", false);
                form.LockWhenCompleted.Checked = aConfiguration.AsBoolean("Tax Return", "LockWhenCompleted", false);
                form.ShowDialog();
            }
        }
    }
}