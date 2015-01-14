using System;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class OpenClientFile : Form
    {
        private string FFileName;
        private AppClientFileOpenOptions FOptions;

        public OpenClientFile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FFileName = textBox1.Text;
            var lIndex = 0;
            FOptions.optWithClientFileManager =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoPasswordGUI_Open =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoPasswordGUI_Fail =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoAskReadOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenDocumentAlreadyLoaded =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenClientFileHeaderOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenDocumentHeaderOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenDatabaseOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenOnlyReadOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenOnlyReadWrite =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenCurrentYearOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoDiagnostics =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenReturnIdListOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoClientFileHeader =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenCheckCalcVersions =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenRecalcForDLL =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenReadOnlyForDll =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenRecalcForProfile =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenReadOnlyForProfile =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenRecalcForRates =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenReadOnlyForRates =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.OptOpenBatch =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoMRU =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenPlanner =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenClientFile =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optSetPlanner =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optPlannerDefaultFilter =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenEPOnly =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoCreateEPFile =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optCanRecalcAlways =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optCheckFiscalPeriod =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            FOptions.optOpenNoUpdateVersion =
                (short) ((checkedListBox1.GetItemCheckState(lIndex++) == CheckState.Checked) ? 1 : 0);
            DialogResult = DialogResult.OK;
        }

        public static AppClientFileOpenOptions RunOpenClientFile(out string AFileName)
        {
            var form = new OpenClientFile();
            if (form.ShowDialog() == DialogResult.OK)
                AFileName = form.FFileName;
            else
                AFileName = "";
            return form.FOptions;
        }
    }
}