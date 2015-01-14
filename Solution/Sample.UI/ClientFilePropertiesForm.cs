using System;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class ClientFileProperties : Form
    {
        public ClientFileProperties()
        {
            InitializeComponent();
        }

        private void ClientFilePropertiesForm_Load(object sender, EventArgs e)
        {
        }

        public static void ShowProperties(IAppClientFile aFile)
        {
            using (var form = new ClientFileProperties())
            {
                form.checkBox1.Checked = aFile.CanRecalcAlways();
                form.checkBox2.Checked = aFile.CurrentYearExists();
                form.checkBox4.Checked = aFile.GetCanModifyData();
                form.checkBox3.Checked = aFile.GetCanSaveFile();
                form.checkBox8.Checked = aFile.GetDataLocked();
                form.checkBox7.Checked = aFile.GetDataTracking();
                form.checkBox6.Checked = aFile.HasPassword();
                form.checkBox5.Checked = aFile.IsDirty();
                form.checkBox12.Checked = aFile.IsNew();
                form.checkBox11.Checked = aFile.IsOpen();
                form.checkBox10.Checked = aFile.IsPlanner();
                form.checkBox9.Checked = aFile.IsSystemLockedByCurrentUser();
                form.checkBox24.Checked = aFile.IsValidCurrentListIndex();
                form.checkBox23.Checked = aFile.LastYearExists();
                form.checkBox22.Checked = aFile.GetIsNewerDataBaseTemplate();
                form.checkBox21.Checked = aFile.PlanningExists();
                form.checkBox20.Checked = aFile.GetFileOpenReadOnly();

                form.txtlanguage.Text = aFile.GetFileOpenMode().ToString();
                form.txtExecutableName.Text = aFile.GetCurrentDocIndex().ToString();
                form.textBox1.Text = aFile.GetCurrentReturnId().ToString();
                form.textBox3.Text = aFile.GetCurrentDocListIndex().ToString();
                form.textBox2.Text = aFile.GetDateTime();
                form.textBox4.Text = aFile.GetDisplayPathFileName();
                form.textBox5.Text = aFile.GetCount().ToString();
                form.textBox8.Text = aFile.GetGUID();
                form.textBox7.Text = aFile.GetOldFileName();
                for (var i = 0; i < aFile.GetListOfReturnIDCount(); ++i)
                {
                    var lValue = aFile.GetListOfReturnIDItem(i);
                    form.listBox1.Items.Add(lValue);
                }
                form.ShowDialog();
            }
        }
    }
}