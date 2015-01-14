using System;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class AdvertisingButton : Form
    {
        private IAppAdvertisingButton FButton;

        public AdvertisingButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FButton.Caption = txtCaption.Text;
            FButton.Hint = txtHint.Text;
            FButton.Width = Convert.ToInt32(txtWidth.Text);
            FButton.Visible = cbVisible.Checked;
            FButton.AdvertisingIdent = txtIdent.Text;
            FButton.Refresh();
            LoadUI();
        }

        private void LoadUI()
        {
            txtCaption.Text = FButton.Caption;
            txtHint.Text = FButton.Hint;
            txtWidth.Text = FButton.Width.ToString();
            cbVisible.Checked = FButton.Visible;
            txtIdent.Text = FButton.AdvertisingIdent;
        }

        public static void Execute(IAppAdvertisingButton aButton)
        {
            using (var form = new AdvertisingButton())
            {
                form.FButton = aButton;
                form.LoadUI();
                form.ShowDialog();
            }
        }
    }
}