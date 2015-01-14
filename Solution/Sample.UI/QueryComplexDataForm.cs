using System;
using System.Globalization;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class QueryComplexDataForm : Form
    {
        private readonly string csZero = ((decimal) 0).ToString("0.00", CultureInfo.InvariantCulture);

        public QueryComplexDataForm()
        {
            InitializeComponent();
        }

        private void AddListDetail(ListViewItem AListItem, string ADetail)
        {
            var LDetail = new ListViewItem.ListViewSubItem();
            LDetail.Text = string.IsNullOrEmpty(ADetail) ? csZero : ADetail;
            AListItem.SubItems.Add(LDetail);
        }

        private void AddListItem(string AClass, string AUCCStart, string ASubstract,
            string ACostOfAddition, string ADispositions, string ABaseCCA, string ARate,
            string ACCAForYear, string UCCEnd)
        {
            var LListItem = new ListViewItem();
            LListItem.Text = AClass;
            AddListDetail(LListItem, AUCCStart);
            AddListDetail(LListItem, ASubstract);
            AddListDetail(LListItem, ACostOfAddition);
            AddListDetail(LListItem, ADispositions);
            AddListDetail(LListItem, ABaseCCA);
            AddListDetail(LListItem, ARate);
            AddListDetail(LListItem, ACCAForYear);
            AddListDetail(LListItem, UCCEnd);
            lstMain.Items.Add(LListItem);
        }

        public void LoadData(IAppTaxData ATaxData)
        {
            lstMain.Items.Clear();

            //locate the right group
            var LCCAGroup = ATaxData.GetGroupByName("T2121[1].CCA", false, false);
            if (LCCAGroup == null)
                throw new Exception("Could not locate the right CCA");

            //iterate other subgroups to fill the list view
            for (var iRow = 1;; ++iRow)
            {
                var LCellPath = string.Format("{0}.CCACat[{1}].",
                    LCCAGroup.GetName(true), iRow);
                var LCellClass = ATaxData.GetCellByName(LCellPath + "Towcls59", false, false);
                if (LCellClass == null)
                    break;
                AddListItem(LCellClass.ToString(),
                    ATaxData.GetCellByName(LCellPath + "FED.UCCOpening", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "Towcls78", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "Towcls57", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "FED.Disp", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "FED.BalanceCCA", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "FED.Rate", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "Towcls10", false, false).ToString(),
                    ATaxData.GetCellByName(LCellPath + "FED.UCCEnding", false, false).ToString()
                    );
            }
            var LTotal = ATaxData.GetCellByName(LCCAGroup.GetName(true) + ".CCA.Torcaa36", false, false).ToString();
            txtTotal.Text = string.IsNullOrEmpty(LTotal) ? csZero : LTotal;
            lstMain.Refresh();
        }
    }
}