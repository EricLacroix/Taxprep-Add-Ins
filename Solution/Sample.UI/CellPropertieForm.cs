using System;
using System.Text;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class CellPropertieForm : Form
    {
        private IAppTaxCell FCell;
        private string FFormName;
        private IAppDocReturn FReturn;

        public CellPropertieForm()
        {
            InitializeComponent();
        }

        private void CellPropertieForm_Load(object sender, EventArgs e)
        {
        }

        private void FillXLatCombo(ComboBox ACombo, AppLanguage ALanguage, int AColumn, IAppTaxCell ACell,
            IAppTaxApplicationService AApplication)
        {
            ACombo.Items.Clear();
            var LCount = ACell.GetXLatValuesCount(AppLanguage.lEnglish, AApplication);
            ACombo.Items.Clear();
            try
            {
                for (var i = 0; i < LCount; ++i)
                {
                    ACombo.Items.Add(ACell.GetXLatValue(AApplication, ALanguage, AColumn, i));
                }
                ACombo.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        public static void ShowCellProperties(IAppTaxCell aCell, IAppTaxApplicationService aApplication)
        {
            using (var form = new CellPropertieForm())
            {
                form.FCell = aCell;
                form.FFormName = aApplication.UFL.GetFormByFormNumber(((int) aCell.GetFormNum())).FormNAme;
                form.FReturn = aApplication.GetCurrentDocReturn();
                form.txtName.Text = aCell.GetCellNameWithGroup();
                form.lblType.Text = aCell.GetCellTypeText();
                form.lblDefaultForm.Text = aCell.GetOwnerTaxData().GetFormName(aCell.GetFormNum());
                var lStringValue = "";
                if (aCell.ConvertToString(ref lStringValue))
                    form.txtValue.Text = lStringValue;
                else
                    form.txtValue.Text = "";
                form.cbHasInput.Checked = aCell.HasInput();
                form.cbHasCalc.Checked = aCell.HasCalc();
                form.cbHasImport.Checked = aCell.IsImported();
                form.cbIsEmpty.Checked = aCell.IsEmpty();
                form.cbIsEstimated.Checked = aCell.IsEstimated();
                form.cbIsTracking.Checked = aCell.IsTracking();
                form.cbHasFormNum.Checked = aCell.HasFormNum();
                form.cbHasInternalOvrd.Checked = aCell.HasInternalOvrd();
                form.cbHasRolledValue.Checked = aCell.HasRolledValue();
                form.cbHasUserOvrd.Checked = aCell.HasUserOvrd();
                form.cbIsPositiveOnly.Checked = aCell.IsPositiveOnly();
                form.cbIsNA.Checked = aCell.IsNA();
                form.cbIsSourceEstimate.Checked = aCell.IsSourceEstimate();
                form.cbIsProtected.Checked = aCell.IsProtected();
                form.cbHasRolledValue.Checked = aCell.HasRolledValue();
                form.cbIsSelectable.Checked = aCell.IsSelectable();
                form.cbIsRoundOnAssign.Checked = aCell.IsRoundOnAssign();
                form.cbIsDeprecated.Checked = aCell.IsDeprecated();
                form.cbHasTransferredValue.Checked = aCell.HasTransferredValue();
                form.cbIsLinkCell.Checked = aCell.IsLinkCell();
                var formNum = aCell.GetFormNum();
                var ufl = aApplication.UFL;
                var frm = ufl.GetFormByFormNumber((int) formNum);
                var formName = frm.FormNAme;
                var LXlat = aCell.GetAssociatedStringTable();
                uint repeatNum;
                var group = aCell.GetOwnerTaxData().GetRepeatById(aCell.GetOwnerRepeatId(), out repeatNum);
                var cells = "";
                for (uint iCellNum = 0; iCellNum < group.GetNumCells(); ++iCellNum)
                {
                    var newCell = group.GetCellFromRepeat(iCellNum, repeatNum);
                    cells += newCell.GetCellNameWithGroup() + "\r\n";
                }
                form.txtCells.Text = cells;
                if (LXlat >= 0)
                {
                    form.lblXlatEnum.Text = LXlat.ToString();
                    form.FillXLatCombo(form.cbXlatEng0, AppLanguage.lEnglish, 0, aCell, aApplication);
                    form.FillXLatCombo(form.cbXlatEng1, AppLanguage.lEnglish, 1, aCell, aApplication);
                    form.FillXLatCombo(form.cbXlatEng2, AppLanguage.lEnglish, 2, aCell, aApplication);
                    form.FillXLatCombo(form.cbXlatFr0, AppLanguage.lFrench, 0, aCell, aApplication);
                    form.FillXLatCombo(form.cbXlatFr1, AppLanguage.lFrench, 1, aCell, aApplication);
                    form.FillXLatCombo(form.cbXlatFr2, AppLanguage.lFrench, 2, aCell, aApplication);
                }
                else
                    form.lblXlatEnum.Text = "None";
                form.lblContentType.Text = aCell.GetCellTypeText();
                form.txtMask.Text = aCell.GetEditControlMask(0);
                var LAliases = "";
                for (var i = 0; i < aCell.GetAliasNamesCount(); ++i)
                {
                    LAliases += aCell.GetAliasNames(i) + "\r\n";
                }
                form.txtAliases.Text = string.Format("Aliases count {0}\r\nAliases:\r\n{1}",
                    aCell.GetAliasNamesCount(), LAliases);
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void CellPropertieForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FCell = null;
            FReturn = null;
        }

        private void cbXlatEng0_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LIndex = (sender as ComboBox).SelectedIndex;
            if (cbXlatEng0 != sender && cbXlatEng0.Items.Count > LIndex)
                cbXlatEng0.SelectedIndex = LIndex;
            if (cbXlatEng1 != sender && cbXlatEng1.Items.Count > LIndex)
                cbXlatEng1.SelectedIndex = LIndex;
            if (cbXlatEng2 != sender && cbXlatEng2.Items.Count > LIndex)
                cbXlatEng2.SelectedIndex = LIndex;
            if (cbXlatFr0 != sender && cbXlatFr0.Items.Count > LIndex)
                cbXlatFr0.SelectedIndex = LIndex;
            if (cbXlatFr1 != sender && cbXlatFr0.Items.Count > LIndex)
                cbXlatFr1.SelectedIndex = LIndex;
            if (cbXlatFr2 != sender && cbXlatFr0.Items.Count > LIndex)
                cbXlatFr2.SelectedIndex = LIndex;
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FReturn.SetAliasString(FCell.GetCellNameWithGroup(), txtValue.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var message = new StringBuilder();
            try
            {
                if (FCell.IsLinkCell())
                {
                    var formName = FFormName;
                    message.AppendFormat("FormName {0}\n", formName);

                    var columnCount = FCell.LinkCellColumnCount(formName);
                    message.AppendFormat("Column count {0}\n", columnCount);

                    var rowCount = FCell.LinkCellRowCount(formName);
                    message.AppendFormat("Row count {0}\n", rowCount);

                    message.Append("Titles\n");
                    for (var iColumn = 0; iColumn < columnCount; ++iColumn)
                    {
                        message.AppendFormat("{0}\t", FCell.LinkCellColumnNames(formName, iColumn));
                    }
                    message.Append("\n");

                    message.Append("Selected data:\n");
                    if (!FCell.IsEmpty())
                    {
                        for (var iColumn = 0; iColumn < columnCount; ++iColumn)
                        {
                            message.AppendFormat("{0}\t", FCell.LinkCellSelectedRow(formName, iColumn));
                        }
                    }
                    else
                    {
                        message.Append("empty");
                    }
                    message.Append("\n");

                    message.Append("Possible value (max 10 records):\n");
                    for (var iRow = 0; iRow < Math.Min(rowCount, 10); ++iRow)
                    {
                        for (var iColumn = 0; iColumn < columnCount; ++iColumn)
                        {
                            message.AppendFormat("{0}\t", FCell.LinkCellTable(formName, iRow, iColumn));
                        }
                        message.Append("\n");
                    }
                }
                else
                {
                    message.Append("The cell is not a LinkCell");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                MessageBox.Show(message.ToString());
            }
        }
    }
}