using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class Diagnotics : Form
    {
        public Diagnotics()
        {
            InitializeComponent();
        }

        public static void ShowDiagnostic(IAppDiagnostic ADiag)
        {
            using (var form = new Diagnotics())
            {
                for (var i = 0; i < ADiag.GetDiagCount(-1); ++i)
                {
                    var LNode = ADiag.GetDiagNode(i, -1);
                    var lstItem = new ListViewItem();
                    lstItem.Text = LNode.getDiagType().ToString();
                    form.lstMain.Items.Add(lstItem);
                    var LGroup = new ListViewItem.ListViewSubItem();
                    LGroup.Text = LNode.getDiagGroupNo().ToString();
                    lstItem.SubItems.Add(LGroup);
                    var LJur = new ListViewItem.ListViewSubItem();
                    LJur.Text = LNode.getJurisdiction().ToString();
                    lstItem.SubItems.Add(LJur);
                    var LTriangle = new ListViewItem.ListViewSubItem();
                    IAppTaxCell LTaxCell;
                    LTriangle.Text = LNode.getLink(out LTaxCell, false).ToString();
                    lstItem.SubItems.Add(LTriangle);

                    var LText = new ListViewItem.ListViewSubItem();
                    LText.Text = LNode.GetDisplayText(AppLanguage.lEnglish);
                    lstItem.SubItems.Add(LText);
                }
                form.ShowDialog();
            }
        }
    }
}