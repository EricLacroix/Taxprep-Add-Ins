using System;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class AppProperiesForm : Form
    {
        public AppProperiesForm()
        {
            InitializeComponent();
        }

        private void AppProperiesForm_Load(object sender, EventArgs e)
        {
        }

        public static void ShowProperties(IAppTaxApplicationService aApp)
        {
            using (var form = new AppProperiesForm())
            {
                form.txtlanguage.Text = aApp.GetDefaultLanguage().ToString();
                form.txtExecutableName.Text = aApp.GetExecutableName();
                form.cbIsCommAvailable.Checked = aApp.getIsCOMAvailable();
                form.checkBox1.Checked = aApp.getIsDemo();
                form.checkBox2.Checked = aApp.getIsEducative();
                form.checkBox3.Checked = aApp.getIsEFILEGovernment();
                form.checkBox4.Checked = aApp.GetIsFirstExecution();
                form.checkBox5.Checked = aApp.getIsNetWork();
                form.checkBox6.Checked = aApp.getIsNetworkAdvanced();
                form.checkBox7.Checked = aApp.getIsNetworkRegular();

                form.textBox1.Text = aApp.GetName();
                form.textBox3.Text = aApp.GetProductName();
                form.textBox2.Text = aApp.GetProductSuffix();
                form.textBox4.Text = aApp.getProductType().ToString();
                form.textBox5.Text = aApp.GetSoftwareVersion();
                form.textBox8.Text = aApp.GetTitleName();
                form.textBox7.Text = aApp.GetVersionType();
                form.textBox9.Text = aApp.GetYear().ToString();

                form.txtCalcDllName.Text = aApp.GetCalcDllName();
                form.txtCalcVersion.Text = aApp.GetCalcVersion();
                form.txtComments.Text = aApp.GetComments();
                form.txtCompanyName.Text = aApp.GetCompanyName();
                form.txtExecutableName.Text = aApp.GetExecutableName();
                form.txtFileDateTime.Text = aApp.GetFileDateTime().ToString();
                form.txtFileDescription.Text = aApp.GetFileDescription();
                form.txtFilePath.Text = aApp.GetFilePath();
                form.txtFileTimeStr.Text = aApp.GetFileTimeStr();
                form.txtFileVersion.Text = aApp.GetFileVersion();
                form.txtInternalName.Text = aApp.GetInternalName();
                form.txtLegalCopyright.Text = aApp.GetLegalCopyright();
                form.txtLegalTrademark.Text = aApp.GetLegalTradeMarks();
                form.txtOriginalFileName.Text = aApp.GetOriginalFilename();
                form.txtPrivateBuild.Text = aApp.GetPrivateBuild();
                form.txtProductVersion.Text = aApp.GetProductVersion();
                form.txtSpecialBuild.Text = aApp.GetSpecialBuild();
                form.txtUniqueID.Text = aApp.GetMachineIdentifier();
                form.txtVersionProductName.Text = aApp.GetVersionProductName();
                form.ShowDialog();
            }
        }
    }
}