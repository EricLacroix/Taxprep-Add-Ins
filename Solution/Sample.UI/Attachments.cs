using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using TaxprepAddinAPI;

namespace WKCA.Sample
{
    public partial class Attachments : Form
    {
        private IAppDocReturn1 docReturn;
        private readonly IAppAttachementManager manager;

        public Attachments(IAppDocReturn1 docReturn)
        {
            InitializeComponent();
            this.docReturn = docReturn;
            var docReturn14 = docReturn;
            manager = docReturn14.GetAttachementManager();
        }

        private void RefreshAttachementList()
        {
            lstAttachments.Items.Clear();
            for (var i = 0; i < manager.Count; ++i)
            {
                lstAttachments.Items.Add(new AttachementItem(manager.Items[i]));
            }
        }

        public static void ShowDemo(IAppDocReturn1 docReturn)
        {
            using (var form = new Attachments(docReturn))
            {
                form.RefreshAttachementList();
                form.ShowDialog();
            }
        }

        private void lstAttachments_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = lstAttachments.SelectedItem as AttachementItem;
            if (item != null)
            {
                txtFileName.Text = item.Attachment.FileName;
                txtFullName.Text = item.Attachment.FullName;
                txtLastModified.Text = item.Attachment.LastModified.ToString();
                txtOriginalPath.Text = item.Attachment.OriginalPath;
                txtSize.Text = item.Attachment.Size.ToString();

                cbIsRollForward.Checked = item.Attachment.IsRollForwarded;
                cbToRollForward.Checked = item.Attachment.ToRollForward;
                splitContainer1.Panel2.Enabled = true;
            }
            else
            {
                txtFileName.Text = "";
                txtFullName.Text = "";
                txtLastModified.Text = "";
                txtOriginalPath.Text = "";
                txtSize.Text = "";

                cbIsRollForward.Checked = false;
                cbToRollForward.Checked = false;
                splitContainer1.Panel2.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lstAttachments.SelectedItem as AttachementItem;
            item.Attachment.Delete();
            RefreshAttachementList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = lstAttachments.SelectedItem as AttachementItem;
            string fileName;
            item.Attachment.SaveToFile(out fileName);
            var psi = new ProcessStartInfo(fileName);
            psi.UseShellExecute = true;
            Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                manager.CreateAttachment(openFileDialog1.FileName);
                RefreshAttachementList();
            }
        }

        public class AttachementItem
        {
            public AttachementItem(IAppAttachment attachement)
            {
                Attachment = attachement;
            }

            public IAppAttachment Attachment { get; }

            public override string ToString()
            {
                return Path.GetFileName(Attachment.FileName);
            }
        }
    }
}