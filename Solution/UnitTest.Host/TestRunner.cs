using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WKCA.UnitTest.Host
{
    public partial class TestRunner : Form
    {
        private readonly Assembly FAssembly;
        private readonly SelectionStorage FStorage;

        public TestRunner()
        {
            InitializeComponent();
        }

        public TestRunner(Assembly AAssembly)
            : this()
        {
            FAssembly = AAssembly;
            FStorage = new SelectionStorage(AAssembly, this);
        }

        private void WriteLogLine(string AMessage = "")
        {
            txtLog.Text += "\r\n" + AMessage;
            txtLog.SelectionStart = txtLog.Text.Length;
            txtLog.SelectionLength = 0;
            txtLog.ScrollToCaret();
            txtLog.Refresh();
        }

        private void WriterHeader(string title)
        {
            WriteLogLine(title);
            var sb = new StringBuilder();
            var i = 0;
            while (++i < title.Length + 1)
                sb.Append("-");

            WriteLogLine(sb.ToString());
        }

        private bool RunTests()
        {

            {
                var LCount = 0;
                for (var i = 0; i < lstTests.Items.Count; ++i)
                {
                    if (lstTests.Items[i].Checked)
                    {
                        LCount++;
                        lstTests.Items[i].ImageIndex = 2;
                        lstTests.Items[i].Text = "Not runned";
                    }
                }
                lstTests.Refresh();
                pbExecution.Maximum = LCount;
            }

            WriteLogLine();

            try
            {
                // 1. Load the assembly.
                var assembly = FAssembly;

                if (lstTests.Items.Count == 0)
                    return true;


                // 3. Get test methods for each class.
                var stats = new Stats();
                List<MethodInfo> methods = null;


                pbExecution.Value = 0;

                //run the unit tests
                for (var LGroupIter = 0; LGroupIter < lstTests.Groups.Count; ++LGroupIter)
                {
                    var LCurrentGroup = lstTests.Groups[LGroupIter];
                    var current = (Type) LCurrentGroup.Tag;
                    try
                    {
                        var LSomeTestSelected = false;
                        for (var LItemIndex = 0; LItemIndex < LCurrentGroup.Items.Count; ++LItemIndex)
                        {
                            LSomeTestSelected |= LCurrentGroup.Items[LItemIndex].Checked;
                        }

                        if (!LSomeTestSelected)
                            continue;

                        var title = string.Format("{0}: {1} test(s)", current.FullName, LCurrentGroup.Items.Count);
                        WriterHeader(title);
                        WriteLogLine();

                        var instance = assembly.CreateInstance(current.FullName);

                        // 3.5 Run test initialize.
                        var initializeMethod = current.GetMethods()
                            .FirstOrDefault(m => m.GetCustomAttributes(typeof (TestInitializeAttribute), false).Any());

                        if (initializeMethod != null)
                        {
                            initializeMethod.Invoke(instance, null);
                        }

                        try
                        {
                            // 4. Run test methods.
                            for (var LMethodIter = 0; LMethodIter < LCurrentGroup.Items.Count; ++LMethodIter)
                            {
                                var LListItem = LCurrentGroup.Items[LMethodIter];
                                if (!LListItem.Checked)
                                    continue;

                                var method = (MethodInfo) LListItem.Tag;
                                try
                                {
                                    stats.AddGlobalCount();
                                    WriteLogLine(string.Format("Running test: {0}.{1}", current.FullName, method.Name));
                                    stats.StartLocalTime();
                                    method.Invoke(instance, null);
                                    WriteLogLine(string.Format("  Passed ({0} s).", stats.LocalTime.TotalSeconds));
                                    stats.AddGlobalPassCount();
                                    LListItem.Text = "Passed";
                                    LListItem.ImageIndex = 1;
                                    lstTests.Refresh();
                                }
                                catch (Exception ex)
                                {
                                    LListItem.Text = "Failed";
                                    LListItem.ImageIndex = 0;
                                    lstTests.Refresh();
                                    stats.AddGlobalFailCount();
                                    // Check for a failing assert.
                                    if (ex.InnerException != null &&
                                        ex.InnerException.GetType() == typeof (AssertFailedException))
                                    {
                                        WriteLogLine(string.Format("  Failed: {0} ({1} s).", ex.InnerException.Message,
                                            stats.LocalTime.TotalSeconds));
                                        continue;
                                    }

                                    // Unexpected error.
                                    WriteLogLine(string.Format("  An unexpected error occured: {0}", ex.Message));
                                    if (ex.InnerException != null)
                                        WriteLogLine(string.Format("  Reason: {0}", ex.InnerException.Message));
                                }
                                finally
                                {
                                    stats.ResetLocalTime();
                                    pbExecution.Value += 1;
                                }
                            }
                        }
                        finally
                        {
                            // 3.5 Run test cleanup method.
                            var cleanupMethod = current.GetMethods()
                                .FirstOrDefault(m => m.GetCustomAttributes(typeof (TestCleanupAttribute), false).Any());

                            if (cleanupMethod != null)
                            {
                                cleanupMethod.Invoke(instance, null);
                            }
                        }
                        WriteLogLine();
                        WriteLogLine(stats.GetFinalResult());
                    }
                    catch (Exception ex)
                    {
                        // Unexpected error.
                        WriteLogLine(string.Format("  An unexpected error occured: {0}", ex.Message));
                        if (ex.InnerException != null)
                            WriteLogLine(string.Format("  Reason: {0}", ex.InnerException.Message));
                        WriteLogLine();
                        if (methods != null)
                        {
                            foreach (var method in methods)
                            {
                                stats.AddGlobalFailCount();
                            }
                        }
                    }
                }
                WriteLogLine();

                return stats.GlobalFailCount == 0;
            }
            catch (Exception ex)
            {
                // Unexpected error.
                WriteLogLine(string.Format("  An unexpected error occured: {0}", ex.Message));
                if (ex.InnerException != null)
                    WriteLogLine(string.Format("  Reason: {0}", ex.InnerException.Message));

                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RunTests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lstTests.Items.Count; ++i)
            {
                lstTests.Items[i].Checked = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lstTests.Items.Count; ++i)
            {
                lstTests.Items[i].Checked = false;
            }
        }

        private void TestRunner_Shown(object sender, EventArgs e)
        {
            lstTests.ShowGroups = false;
            //load the list of tests
            lstTests.Items.Clear();
            lstTests.Groups.Clear();

            // 2. Get test classes.
            var classes = FAssembly.GetTypes()
                .Where(t => t.GetCustomAttributes(typeof (TestClassAttribute), false).Count() != 0)
                .OrderBy(t => t.Name);

            if (!classes.Any())
                return;


            // 3. Get test methods for each class.
            List<MethodInfo> methods = null;
            var LCount = 0;
            //run the unit tests
            foreach (var current in classes)
            {
                methods = current.GetMethods()
                    .Where(m => m.GetCustomAttributes(typeof (TestMethodAttribute), false).Count() != 0)
                    .OrderBy(m => m.Name)
                    .ToList();

                if (!methods.Any())
                    continue;

                var LViewGroup = new ListViewGroup();
                LViewGroup.Header = current.FullName;
                LViewGroup.Tag = current;
                lstTests.Groups.Add(LViewGroup);

                foreach (var method in methods)
                {
                    var LTestMethod = new ListViewItem();
                    LTestMethod.Text = "Not runned";
                    LTestMethod.Tag = method;
                    LTestMethod.ImageIndex = 2;
                    var LListSubItem = new ListViewItem.ListViewSubItem();
                    LListSubItem.Text = LViewGroup.Header;
                    LTestMethod.SubItems.Add(LListSubItem);
                    LListSubItem = new ListViewItem.ListViewSubItem();
                    LListSubItem.Text = method.Name;
                    LTestMethod.SubItems.Add(LListSubItem);
                    LTestMethod.Tag = method;
                    LTestMethod.Checked = !FStorage.IsUnChecked(LViewGroup.Header, method.Name);
                    lstTests.Items.Add(LTestMethod);
                    LViewGroup.Items.Add(LTestMethod);
                    LTestMethod.Group = LViewGroup;
                    LCount++;
                }
            }
            lstTests.ShowGroups = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < lstTests.Items.Count; ++i)
            {
                lstTests.Items[i].Checked = lstTests.Items[i].ImageIndex == 0;
            }
        }

        private void lstTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            var LSelectedItem = lstTests.FocusedItem;
            if (LSelectedItem == null)
            {
                txtLog.SelectionLength = 0;
                return;
            }
            var LMethodClass = LSelectedItem.SubItems[1].Text;
            var LMethodName = LSelectedItem.SubItems[2].Text;
            var LFoundText = string.Format("Running test: {0}.{1}",
                LMethodClass, LMethodName);
            var LIndex = txtLog.Text.LastIndexOf(LFoundText);
            if (LIndex >= 0)
            {
                txtLog.SelectionStart = LIndex;
                txtLog.SelectionLength = LFoundText.Length;
                txtLog.ScrollToCaret();
            }
            else
            {
                txtLog.SelectionLength = 0;
            }
        }

        private void TestRunner_FormClosed(object sender, FormClosedEventArgs e)
        {
            FStorage.StoreTestSelection();
        }
    }
}