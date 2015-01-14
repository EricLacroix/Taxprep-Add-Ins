using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace AddinReg
{
    public partial class Interractive : Form
    {
        public Interractive()
        {
            InitializeComponent();
        }

        private void Interractive_Load(object sender, EventArgs e)
        {
            var regKey = Registry.CurrentUser.OpenSubKey("Software\\CCH");
            if (regKey != null)
            {
                cbApplication.Items.AddRange((
                    from a in regKey.GetSubKeyNames()
                    where regKey.OpenSubKey(a + "\\Addins") != null
                    select a
                    ).ToArray());
            }
        }

        private string[] ReadInstalledAddins(string Application)
        {
            var regKey = Registry.CurrentUser.OpenSubKey(string.Format("Software\\CCH\\{0}\\Addins", Application));
            if (regKey != null)
            {
                return regKey.GetSubKeyNames();
            }
            return null;
        }

        private void UpdateAddinLists()
        {
            var list = ReadInstalledAddins(cbApplication.Text);
            cbAddinToRemove.Items.Clear();
            lstAddinsList.Items.Clear();
            if (list != null && list.Count() > 0)
            {
                cbAddinToRemove.Items.AddRange(list);
                lstAddinsList.Items.AddRange(list);
            }
            lstAddinsList_SelectedIndexChanged(null, null);
        }

        private void btnUnregisterAllAddins_Click(object sender, EventArgs e)
        {
            AddinRegistrator.ClearRegisteredAddIns(cbApplication.Text);
            UpdateAddinLists();
        }

        private void cbApplication_TextChanged(object sender, EventArgs e)
        {
            tbActions.Enabled = !string.IsNullOrWhiteSpace(cbApplication.Text);
            if (!string.IsNullOrWhiteSpace(cbApplication.Text))
            {
                UpdateAddinLists();
            }
        }

        private void cbAddinToRemove_TextChanged(object sender, EventArgs e)
        {
            btnRemoveSelectedAddin.Enabled = !string.IsNullOrWhiteSpace(cbAddinToRemove.Text);
        }

        private void btnRemoveSelectedAddin_Click(object sender, EventArgs e)
        {
            AddinRegistrator.UnregisterAddin(cbApplication.Text, cbAddinToRemove.Text);
            UpdateAddinLists();
        }

        private void btnRefreshViewAddins_Click(object sender, EventArgs e)
        {
            UpdateAddinLists();
        }

        private void lstAddinsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RegistryKey regKey = null;
            if (lstAddinsList.SelectedItem != null)
                regKey = Registry.CurrentUser.OpenSubKey(string.Format("Software\\CCH\\{0}\\Addins\\{1}",
                    cbApplication.Text, lstAddinsList.SelectedItem));
            if (regKey != null)
            {
                txtViewAddinDLLPath.Text = (string) (regKey.GetValue("FileName") ?? "");
                txtViewAddinRegKey.Text = regKey.Name;
            }
            else
            {
                txtViewAddinDLLPath.Text = "";
                txtViewAddinRegKey.Text = "";
            }
        }

        private void txtSignedRegKeyName_TextChanged(object sender, EventArgs e)
        {
            btnRegisterSignedAddin.Enabled = !string.IsNullOrWhiteSpace(txtSignedRegKeyName.Text)
                                             && File.Exists(txtSignedAddinDLL.Text);
        }

        private void btnSignedSelectAddinDll_Click(object sender, EventArgs e)
        {
            odAddinDll.FileName = txtSignedAddinDLL.Text;
            if (odAddinDll.ShowDialog() == DialogResult.OK)
            {
                txtSignedAddinDLL.Text = odAddinDll.FileName;
            }
        }

        private void btnRegisterSignedAddin_Click(object sender, EventArgs e)
        {
            AddinRegistrator.RegisterSignedAddin(cbApplication.Text, txtSignedRegKeyName.Text,
                txtSignedAddinDLL.Text);
            UpdateAddinLists();
        }

        private void ProxyValues_Validate(object sender, EventArgs e)
        {
            Guid tmpGuid;
            btnProxyRegister.Enabled = !string.IsNullOrWhiteSpace(txtProxyRegKeyName.Text)
                                       && File.Exists(txtProxyAddinDll.Text)
                                       && File.Exists(txtProxyDll.Text)
                                       && Guid.TryParse(txtProxyGuid.Text, out tmpGuid)
                                       && !string.IsNullOrWhiteSpace(txtProxyShortName.Text)
                                       && !string.IsNullOrWhiteSpace(txtProxyFullName.Text)
                                       && !string.IsNullOrWhiteSpace(txtProxyVersion.Text);
        }

        private void btnProxyRegister_Click(object sender, EventArgs e)
        {
            AddinRegistrator.RegisterProxyAddin(cbApplication.Text, txtProxyRegKeyName.Text,
                txtProxyShortName.Text, txtSignedAddinDLL.Text, txtProxyDll.Text, txtProxyFullName.Text,
                txtProxyGuid.Text, txtProxyVersion.Text);
            UpdateAddinLists();
        }

        private void btnProxySelectAddinDll_Click(object sender, EventArgs e)
        {
            odAddinDll.FileName = txtProxyAddinDll.Text;
            if (odAddinDll.ShowDialog() == DialogResult.OK)
            {
                txtProxyAddinDll.Text = odAddinDll.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odProxyDll.FileName = txtProxyDll.Text;
            if (odProxyDll.ShowDialog() == DialogResult.OK)
            {
                txtProxyDll.Text = odProxyDll.FileName;
            }
        }

        private void btnViewUnregister_Click_1(object sender, EventArgs e)
        {
            AddinRegistrator.UnregisterAddin(cbApplication.Text, lstAddinsList.SelectedItem.ToString());
            UpdateAddinLists();
        }

        private void RegisterProxyValidate_ValueChanged(object sender, EventArgs e)
        {
            gbLoaderManaged.Enabled = cbLoaderManaged.Checked;
            gbLoaderProxy.Enabled = cbLoaderViaProxy.Checked;
            txtLoaderFpu.Enabled = !cbLoaderDefaultFPU.Checked;
            int tmpInt;
            Guid tmpGuid;
            btnLoaderRegister.Enabled = !string.IsNullOrWhiteSpace(txtLoaderAddinRegKey.Text)
                                        && File.Exists(txtLoaderAddinDll.Text)
                                        && File.Exists(txtLoaderLoaderDll.Text)
                                        && (
                                            (!cbLoaderManaged.Checked)
                                            || (
                                                !string.IsNullOrWhiteSpace(txtLoaderAddinClassName.Text)
                                                &&
                                                (string.IsNullOrEmpty(txtLoaderConfigFile.Text) ||
                                                 File.Exists(txtLoaderConfigFile.Text))
                                                &&
                                                (cbLoaderDefaultFPU.Checked ||
                                                 int.TryParse(txtLoaderFpu.Text, out tmpInt))
                                                )
                                            )
                                        && (
                                            (!cbLoaderViaProxy.Checked)
                                            || (
                                                File.Exists(txtProxyAddinDll.Text)
                                                && !string.IsNullOrWhiteSpace(txtLoaderProxyFullName.Text)
                                                && !string.IsNullOrWhiteSpace(txtLoaderProxyShortName.Text)
                                                && Guid.TryParse(txtLoaderAddinGuid.Text, out tmpGuid)
                                                && !string.IsNullOrWhiteSpace(txtLoaderAddinVersion.Text)
                                                )
                                            );
        }

        private void btnLoaderSelectAddinDll_Click(object sender, EventArgs e)
        {
            odAddinDll.FileName = txtLoaderAddinDll.Text;
            if (odAddinDll.ShowDialog() == DialogResult.OK)
            {
                txtLoaderAddinDll.Text = odAddinDll.FileName;
            }
        }

        private void btnLoaderSelectLoaderDll_Click(object sender, EventArgs e)
        {
            odLoaderDll.FileName = txtLoaderLoaderDll.Text;
            if (odLoaderDll.ShowDialog() == DialogResult.OK)
            {
                txtLoaderLoaderDll.Text = odLoaderDll.FileName;
            }
        }

        private void btnLoaderSelectProxyDll_Click(object sender, EventArgs e)
        {
            odProxyDll.FileName = txtLoaderProxyDll.Text;
            if (odProxyDll.ShowDialog() == DialogResult.OK)
            {
                txtLoaderProxyDll.Text = odProxyDll.FileName;
            }
        }

        private void btnLoaderSelectConfigFile_Click(object sender, EventArgs e)
        {
            odConfigFile.FileName = txtLoaderConfigFile.Text;
            if (odConfigFile.ShowDialog() == DialogResult.OK)
            {
                txtLoaderConfigFile.Text = odConfigFile.FileName;
            }
        }

        private void btnLoaderRegister_Click(object sender, EventArgs e)
        {
            var fpuCW = cbLoaderDefaultFPU.Checked ? "default" : txtLoaderFpu.Text;
            if (cbLoaderManaged.Checked && !cbLoaderViaProxy.Checked)
            {
                AddinRegistrator.RegisterLoaderManagedAddin(cbApplication.Text, txtLoaderAddinRegKey.Text,
                    txtLoaderAddinDll.Text, txtLoaderAddinClassName.Text, txtLoaderLoaderDll.Text,
                    txtLoaderConfigFile.Text, fpuCW);
            }
            else if (!cbLoaderManaged.Checked && !cbLoaderViaProxy.Checked)
            {
                AddinRegistrator.RegisterLoaderNativeAddin(cbApplication.Text, txtLoaderAddinRegKey.Text,
                    txtLoaderAddinDll.Text, txtLoaderLoaderDll.Text);
            }
            else if (cbLoaderManaged.Checked && cbLoaderViaProxy.Checked)
            {
                AddinRegistrator.RegisterLoaderManagedProxyAddin(cbApplication.Text, txtLoaderAddinRegKey.Text,
                    txtLoaderAddinDll.Text, txtLoaderAddinClassName.Text, txtLoaderLoaderDll.Text,
                    txtLoaderConfigFile.Text, fpuCW, txtLoaderProxyDll.Text, txtLoaderProxyShortName.Text,
                    txtLoaderProxyFullName.Text, txtLoaderAddinGuid.Text, txtLoaderAddinVersion.Text);
            }
            else if (!cbLoaderManaged.Checked && cbLoaderViaProxy.Checked)
            {
                AddinRegistrator.RegisterLoaderNativeProxyAddin(cbApplication.Text, txtLoaderAddinRegKey.Text,
                    txtLoaderAddinDll.Text, txtLoaderLoaderDll.Text, txtLoaderProxyDll.Text,
                    txtLoaderProxyShortName.Text,
                    txtLoaderProxyFullName.Text, txtLoaderAddinGuid.Text, txtLoaderAddinVersion.Text);
            }
            UpdateAddinLists();
        }
    }
}