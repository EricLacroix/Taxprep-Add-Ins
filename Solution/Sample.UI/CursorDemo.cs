using System;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class CursorDemo : Form
    {
        private const int multiplier = 1000000;

        private IAppTaxApplicationService FApplication;

        public CursorDemo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FApplication.StartLongOperation();
            progressBar1.Value = 0;
            for (var i = 0; i < progressBar1.Maximum*multiplier; ++i)
            {
                if (i%multiplier == 0)
                    progressBar1.Value = i/multiplier;
            }
            progressBar1.Value = 0;
            Close();
        }

        private void DoIdle(out bool aProcessed)
        {
            Cursor = Cursors.Default;
            aProcessed = true;
        }

        public static void Display(IAppTaxApplicationService aApplication)
        {
            using (var frm = new CursorDemo())
            {
                frm.FApplication = aApplication;
                frm.ShowDialog();
            }
        }
    }
}