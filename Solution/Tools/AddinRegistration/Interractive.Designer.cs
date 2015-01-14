namespace AddinReg
{
    partial class Interractive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbApplication = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbActions = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedAddin = new System.Windows.Forms.Button();
            this.cbAddinToRemove = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnregisterAllAddins = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnViewUnregister = new System.Windows.Forms.Button();
            this.btnRefreshViewAddins = new System.Windows.Forms.Button();
            this.lstAddinsList = new System.Windows.Forms.ListBox();
            this.txtViewAddinDLLPath = new System.Windows.Forms.TextBox();
            this.txtViewAddinRegKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRegisterSignedAddin = new System.Windows.Forms.Button();
            this.btnSignedSelectAddinDll = new System.Windows.Forms.Button();
            this.txtSignedAddinDLL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSignedRegKeyName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtProxyVersion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtProxyGuid = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtProxyFullName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProxyShortName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnProxySelectProxyDll = new System.Windows.Forms.Button();
            this.txtProxyDll = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnProxyRegister = new System.Windows.Forms.Button();
            this.btnProxySelectAddinDll = new System.Windows.Forms.Button();
            this.txtProxyAddinDll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProxyRegKeyName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbLoaderManaged = new System.Windows.Forms.GroupBox();
            this.txtLoaderFpu = new System.Windows.Forms.MaskedTextBox();
            this.cbLoaderDefaultFPU = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnLoaderSelectConfigFile = new System.Windows.Forms.Button();
            this.txtLoaderConfigFile = new System.Windows.Forms.TextBox();
            this.txtLoaderAddinClassName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cbLoaderViaProxy = new System.Windows.Forms.CheckBox();
            this.cbLoaderManaged = new System.Windows.Forms.CheckBox();
            this.btnLoaderSelectLoaderDll = new System.Windows.Forms.Button();
            this.txtLoaderLoaderDll = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.gbLoaderProxy = new System.Windows.Forms.GroupBox();
            this.txtLoaderAddinVersion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLoaderAddinGuid = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLoaderProxyFullName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtLoaderProxyShortName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnLoaderSelectProxyDll = new System.Windows.Forms.Button();
            this.txtLoaderProxyDll = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnLoaderRegister = new System.Windows.Forms.Button();
            this.btnLoaderSelectAddinDll = new System.Windows.Forms.Button();
            this.txtLoaderAddinDll = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtLoaderAddinRegKey = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.odAddinDll = new System.Windows.Forms.OpenFileDialog();
            this.odProxyDll = new System.Windows.Forms.OpenFileDialog();
            this.odLoaderDll = new System.Windows.Forms.OpenFileDialog();
            this.odConfigFile = new System.Windows.Forms.OpenFileDialog();
            this.tbActions.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbLoaderManaged.SuspendLayout();
            this.gbLoaderProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbApplication
            // 
            this.cbApplication.FormattingEnabled = true;
            this.cbApplication.Location = new System.Drawing.Point(14, 26);
            this.cbApplication.Name = "cbApplication";
            this.cbApplication.Size = new System.Drawing.Size(199, 21);
            this.cbApplication.TabIndex = 0;
            this.cbApplication.TextChanged += new System.EventHandler(this.cbApplication_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "TaxPrep version";
            // 
            // tbActions
            // 
            this.tbActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbActions.Controls.Add(this.tabPage1);
            this.tbActions.Controls.Add(this.tabPage2);
            this.tbActions.Controls.Add(this.tabPage3);
            this.tbActions.Controls.Add(this.tabPage4);
            this.tbActions.Controls.Add(this.tabPage5);
            this.tbActions.Enabled = false;
            this.tbActions.Location = new System.Drawing.Point(12, 65);
            this.tbActions.Name = "tbActions";
            this.tbActions.SelectedIndex = 0;
            this.tbActions.Size = new System.Drawing.Size(760, 461);
            this.tbActions.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnUnregisterAllAddins);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unregistering";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemoveSelectedAddin);
            this.groupBox1.Controls.Add(this.cbAddinToRemove);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(22, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Specific add-in";
            // 
            // btnRemoveSelectedAddin
            // 
            this.btnRemoveSelectedAddin.Enabled = false;
            this.btnRemoveSelectedAddin.Location = new System.Drawing.Point(185, 98);
            this.btnRemoveSelectedAddin.Name = "btnRemoveSelectedAddin";
            this.btnRemoveSelectedAddin.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelectedAddin.TabIndex = 2;
            this.btnRemoveSelectedAddin.Text = "Unregister";
            this.btnRemoveSelectedAddin.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedAddin.Click += new System.EventHandler(this.btnRemoveSelectedAddin_Click);
            // 
            // cbAddinToRemove
            // 
            this.cbAddinToRemove.FormattingEnabled = true;
            this.cbAddinToRemove.Location = new System.Drawing.Point(25, 43);
            this.cbAddinToRemove.Name = "cbAddinToRemove";
            this.cbAddinToRemove.Size = new System.Drawing.Size(235, 21);
            this.cbAddinToRemove.TabIndex = 1;
            this.cbAddinToRemove.TextChanged += new System.EventHandler(this.cbAddinToRemove_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Addin registry key name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btnUnregisterAllAddins
            // 
            this.btnUnregisterAllAddins.Location = new System.Drawing.Point(22, 28);
            this.btnUnregisterAllAddins.Name = "btnUnregisterAllAddins";
            this.btnUnregisterAllAddins.Size = new System.Drawing.Size(163, 23);
            this.btnUnregisterAllAddins.TabIndex = 0;
            this.btnUnregisterAllAddins.Text = "Unregister all add-ins";
            this.btnUnregisterAllAddins.UseVisualStyleBackColor = true;
            this.btnUnregisterAllAddins.Click += new System.EventHandler(this.btnUnregisterAllAddins_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List of add-ins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnViewUnregister);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefreshViewAddins);
            this.splitContainer1.Panel1.Controls.Add(this.lstAddinsList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtViewAddinDLLPath);
            this.splitContainer1.Panel2.Controls.Add(this.txtViewAddinRegKey);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(740, 426);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnViewUnregister
            // 
            this.btnViewUnregister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnViewUnregister.Location = new System.Drawing.Point(94, 392);
            this.btnViewUnregister.Name = "btnViewUnregister";
            this.btnViewUnregister.Size = new System.Drawing.Size(75, 23);
            this.btnViewUnregister.TabIndex = 4;
            this.btnViewUnregister.Text = "Unregister";
            this.btnViewUnregister.UseVisualStyleBackColor = true;
            this.btnViewUnregister.Click += new System.EventHandler(this.btnViewUnregister_Click_1);
            // 
            // btnRefreshViewAddins
            // 
            this.btnRefreshViewAddins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshViewAddins.Location = new System.Drawing.Point(3, 392);
            this.btnRefreshViewAddins.Name = "btnRefreshViewAddins";
            this.btnRefreshViewAddins.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshViewAddins.TabIndex = 2;
            this.btnRefreshViewAddins.Text = "Refresh";
            this.btnRefreshViewAddins.UseVisualStyleBackColor = true;
            this.btnRefreshViewAddins.Click += new System.EventHandler(this.btnRefreshViewAddins_Click);
            // 
            // lstAddinsList
            // 
            this.lstAddinsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstAddinsList.FormattingEnabled = true;
            this.lstAddinsList.Location = new System.Drawing.Point(3, 3);
            this.lstAddinsList.Name = "lstAddinsList";
            this.lstAddinsList.Size = new System.Drawing.Size(240, 381);
            this.lstAddinsList.TabIndex = 1;
            this.lstAddinsList.SelectedIndexChanged += new System.EventHandler(this.lstAddinsList_SelectedIndexChanged);
            // 
            // txtViewAddinDLLPath
            // 
            this.txtViewAddinDLLPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewAddinDLLPath.Location = new System.Drawing.Point(34, 107);
            this.txtViewAddinDLLPath.Name = "txtViewAddinDLLPath";
            this.txtViewAddinDLLPath.ReadOnly = true;
            this.txtViewAddinDLLPath.Size = new System.Drawing.Size(428, 20);
            this.txtViewAddinDLLPath.TabIndex = 3;
            // 
            // txtViewAddinRegKey
            // 
            this.txtViewAddinRegKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewAddinRegKey.Location = new System.Drawing.Point(30, 47);
            this.txtViewAddinRegKey.Name = "txtViewAddinRegKey";
            this.txtViewAddinRegKey.ReadOnly = true;
            this.txtViewAddinRegKey.Size = new System.Drawing.Size(428, 20);
            this.txtViewAddinRegKey.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Addin DLL path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Addin registry name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRegisterSignedAddin);
            this.tabPage3.Controls.Add(this.btnSignedSelectAddinDll);
            this.tabPage3.Controls.Add(this.txtSignedAddinDLL);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtSignedRegKeyName);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 435);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Register signed add-in";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRegisterSignedAddin
            // 
            this.btnRegisterSignedAddin.Enabled = false;
            this.btnRegisterSignedAddin.Location = new System.Drawing.Point(545, 224);
            this.btnRegisterSignedAddin.Name = "btnRegisterSignedAddin";
            this.btnRegisterSignedAddin.Size = new System.Drawing.Size(166, 23);
            this.btnRegisterSignedAddin.TabIndex = 5;
            this.btnRegisterSignedAddin.Text = "Register signed add-in";
            this.btnRegisterSignedAddin.UseVisualStyleBackColor = true;
            this.btnRegisterSignedAddin.Click += new System.EventHandler(this.btnRegisterSignedAddin_Click);
            // 
            // btnSignedSelectAddinDll
            // 
            this.btnSignedSelectAddinDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignedSelectAddinDll.Location = new System.Drawing.Point(686, 117);
            this.btnSignedSelectAddinDll.Name = "btnSignedSelectAddinDll";
            this.btnSignedSelectAddinDll.Size = new System.Drawing.Size(25, 23);
            this.btnSignedSelectAddinDll.TabIndex = 4;
            this.btnSignedSelectAddinDll.Text = "...";
            this.btnSignedSelectAddinDll.UseVisualStyleBackColor = true;
            this.btnSignedSelectAddinDll.Click += new System.EventHandler(this.btnSignedSelectAddinDll_Click);
            // 
            // txtSignedAddinDLL
            // 
            this.txtSignedAddinDLL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSignedAddinDLL.Location = new System.Drawing.Point(34, 119);
            this.txtSignedAddinDLL.Name = "txtSignedAddinDLL";
            this.txtSignedAddinDLL.Size = new System.Drawing.Size(651, 20);
            this.txtSignedAddinDLL.TabIndex = 3;
            this.txtSignedAddinDLL.TextChanged += new System.EventHandler(this.txtSignedRegKeyName_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Add-in DLL path";
            // 
            // txtSignedRegKeyName
            // 
            this.txtSignedRegKeyName.Location = new System.Drawing.Point(34, 57);
            this.txtSignedRegKeyName.Name = "txtSignedRegKeyName";
            this.txtSignedRegKeyName.Size = new System.Drawing.Size(219, 20);
            this.txtSignedRegKeyName.TabIndex = 1;
            this.txtSignedRegKeyName.TextChanged += new System.EventHandler(this.txtSignedRegKeyName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Addin registry key name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtProxyVersion);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.txtProxyGuid);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.txtProxyFullName);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.txtProxyShortName);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.btnProxySelectProxyDll);
            this.tabPage4.Controls.Add(this.txtProxyDll);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnProxyRegister);
            this.tabPage4.Controls.Add(this.btnProxySelectAddinDll);
            this.tabPage4.Controls.Add(this.txtProxyAddinDll);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.txtProxyRegKeyName);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(752, 435);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Register via proxy";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtProxyVersion
            // 
            this.txtProxyVersion.Location = new System.Drawing.Point(276, 232);
            this.txtProxyVersion.Name = "txtProxyVersion";
            this.txtProxyVersion.Size = new System.Drawing.Size(219, 20);
            this.txtProxyVersion.TabIndex = 22;
            this.txtProxyVersion.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(273, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Addin version";
            // 
            // txtProxyGuid
            // 
            this.txtProxyGuid.Location = new System.Drawing.Point(39, 232);
            this.txtProxyGuid.Name = "txtProxyGuid";
            this.txtProxyGuid.Size = new System.Drawing.Size(219, 20);
            this.txtProxyGuid.TabIndex = 20;
            this.txtProxyGuid.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Addin GUID";
            // 
            // txtProxyFullName
            // 
            this.txtProxyFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyFullName.Location = new System.Drawing.Point(276, 176);
            this.txtProxyFullName.Name = "txtProxyFullName";
            this.txtProxyFullName.Size = new System.Drawing.Size(440, 20);
            this.txtProxyFullName.TabIndex = 18;
            this.txtProxyFullName.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(273, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Addin full name";
            // 
            // txtProxyShortName
            // 
            this.txtProxyShortName.Location = new System.Drawing.Point(39, 176);
            this.txtProxyShortName.Name = "txtProxyShortName";
            this.txtProxyShortName.Size = new System.Drawing.Size(219, 20);
            this.txtProxyShortName.TabIndex = 16;
            this.txtProxyShortName.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Addin short name";
            // 
            // btnProxySelectProxyDll
            // 
            this.btnProxySelectProxyDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProxySelectProxyDll.Location = new System.Drawing.Point(691, 124);
            this.btnProxySelectProxyDll.Name = "btnProxySelectProxyDll";
            this.btnProxySelectProxyDll.Size = new System.Drawing.Size(25, 23);
            this.btnProxySelectProxyDll.TabIndex = 14;
            this.btnProxySelectProxyDll.Text = "...";
            this.btnProxySelectProxyDll.UseVisualStyleBackColor = true;
            this.btnProxySelectProxyDll.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProxyDll
            // 
            this.txtProxyDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyDll.Location = new System.Drawing.Point(39, 126);
            this.txtProxyDll.Name = "txtProxyDll";
            this.txtProxyDll.Size = new System.Drawing.Size(651, 20);
            this.txtProxyDll.TabIndex = 13;
            this.txtProxyDll.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Proxy DLL path";
            // 
            // btnProxyRegister
            // 
            this.btnProxyRegister.Enabled = false;
            this.btnProxyRegister.Location = new System.Drawing.Point(550, 282);
            this.btnProxyRegister.Name = "btnProxyRegister";
            this.btnProxyRegister.Size = new System.Drawing.Size(166, 23);
            this.btnProxyRegister.TabIndex = 11;
            this.btnProxyRegister.Text = "Register proxy add-in";
            this.btnProxyRegister.UseVisualStyleBackColor = true;
            this.btnProxyRegister.Click += new System.EventHandler(this.btnProxyRegister_Click);
            // 
            // btnProxySelectAddinDll
            // 
            this.btnProxySelectAddinDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProxySelectAddinDll.Location = new System.Drawing.Point(691, 77);
            this.btnProxySelectAddinDll.Name = "btnProxySelectAddinDll";
            this.btnProxySelectAddinDll.Size = new System.Drawing.Size(25, 23);
            this.btnProxySelectAddinDll.TabIndex = 10;
            this.btnProxySelectAddinDll.Text = "...";
            this.btnProxySelectAddinDll.UseVisualStyleBackColor = true;
            this.btnProxySelectAddinDll.Click += new System.EventHandler(this.btnProxySelectAddinDll_Click);
            // 
            // txtProxyAddinDll
            // 
            this.txtProxyAddinDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProxyAddinDll.Location = new System.Drawing.Point(39, 79);
            this.txtProxyAddinDll.Name = "txtProxyAddinDll";
            this.txtProxyAddinDll.Size = new System.Drawing.Size(651, 20);
            this.txtProxyAddinDll.TabIndex = 9;
            this.txtProxyAddinDll.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Add-in DLL path";
            // 
            // txtProxyRegKeyName
            // 
            this.txtProxyRegKeyName.Location = new System.Drawing.Point(39, 32);
            this.txtProxyRegKeyName.Name = "txtProxyRegKeyName";
            this.txtProxyRegKeyName.Size = new System.Drawing.Size(219, 20);
            this.txtProxyRegKeyName.TabIndex = 7;
            this.txtProxyRegKeyName.TextChanged += new System.EventHandler(this.ProxyValues_Validate);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Addin registry key name";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbLoaderManaged);
            this.tabPage5.Controls.Add(this.cbLoaderViaProxy);
            this.tabPage5.Controls.Add(this.cbLoaderManaged);
            this.tabPage5.Controls.Add(this.btnLoaderSelectLoaderDll);
            this.tabPage5.Controls.Add(this.txtLoaderLoaderDll);
            this.tabPage5.Controls.Add(this.label22);
            this.tabPage5.Controls.Add(this.gbLoaderProxy);
            this.tabPage5.Controls.Add(this.btnLoaderRegister);
            this.tabPage5.Controls.Add(this.btnLoaderSelectAddinDll);
            this.tabPage5.Controls.Add(this.txtLoaderAddinDll);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.txtLoaderAddinRegKey);
            this.tabPage5.Controls.Add(this.label21);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 435);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Register via loader";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbLoaderManaged
            // 
            this.gbLoaderManaged.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLoaderManaged.Controls.Add(this.txtLoaderFpu);
            this.gbLoaderManaged.Controls.Add(this.cbLoaderDefaultFPU);
            this.gbLoaderManaged.Controls.Add(this.label25);
            this.gbLoaderManaged.Controls.Add(this.label24);
            this.gbLoaderManaged.Controls.Add(this.btnLoaderSelectConfigFile);
            this.gbLoaderManaged.Controls.Add(this.txtLoaderConfigFile);
            this.gbLoaderManaged.Controls.Add(this.txtLoaderAddinClassName);
            this.gbLoaderManaged.Controls.Add(this.label23);
            this.gbLoaderManaged.Location = new System.Drawing.Point(21, 266);
            this.gbLoaderManaged.Name = "gbLoaderManaged";
            this.gbLoaderManaged.Size = new System.Drawing.Size(698, 118);
            this.gbLoaderManaged.TabIndex = 46;
            this.gbLoaderManaged.TabStop = false;
            this.gbLoaderManaged.Text = "Managed options";
            // 
            // txtLoaderFpu
            // 
            this.txtLoaderFpu.Enabled = false;
            this.txtLoaderFpu.Location = new System.Drawing.Point(120, 85);
            this.txtLoaderFpu.Mask = "00000";
            this.txtLoaderFpu.Name = "txtLoaderFpu";
            this.txtLoaderFpu.Size = new System.Drawing.Size(100, 20);
            this.txtLoaderFpu.TabIndex = 52;
            this.txtLoaderFpu.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // cbLoaderDefaultFPU
            // 
            this.cbLoaderDefaultFPU.AutoSize = true;
            this.cbLoaderDefaultFPU.Checked = true;
            this.cbLoaderDefaultFPU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoaderDefaultFPU.Location = new System.Drawing.Point(12, 88);
            this.cbLoaderDefaultFPU.Name = "cbLoaderDefaultFPU";
            this.cbLoaderDefaultFPU.Size = new System.Drawing.Size(102, 17);
            this.cbLoaderDefaultFPU.TabIndex = 51;
            this.cbLoaderDefaultFPU.Text = "default (for .Net)";
            this.cbLoaderDefaultFPU.UseVisualStyleBackColor = true;
            this.cbLoaderDefaultFPU.CheckedChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            this.cbLoaderDefaultFPU.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 72);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(78, 13);
            this.label25.TabIndex = 50;
            this.label25.Text = "FPU CW value";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(246, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 49;
            this.label24.Text = "Config file";
            // 
            // btnLoaderSelectConfigFile
            // 
            this.btnLoaderSelectConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoaderSelectConfigFile.Location = new System.Drawing.Point(662, 38);
            this.btnLoaderSelectConfigFile.Name = "btnLoaderSelectConfigFile";
            this.btnLoaderSelectConfigFile.Size = new System.Drawing.Size(25, 23);
            this.btnLoaderSelectConfigFile.TabIndex = 48;
            this.btnLoaderSelectConfigFile.Text = "...";
            this.btnLoaderSelectConfigFile.UseVisualStyleBackColor = true;
            this.btnLoaderSelectConfigFile.Click += new System.EventHandler(this.btnLoaderSelectConfigFile_Click);
            // 
            // txtLoaderConfigFile
            // 
            this.txtLoaderConfigFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaderConfigFile.Location = new System.Drawing.Point(249, 40);
            this.txtLoaderConfigFile.Name = "txtLoaderConfigFile";
            this.txtLoaderConfigFile.Size = new System.Drawing.Size(412, 20);
            this.txtLoaderConfigFile.TabIndex = 47;
            this.txtLoaderConfigFile.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // txtLoaderAddinClassName
            // 
            this.txtLoaderAddinClassName.Location = new System.Drawing.Point(12, 40);
            this.txtLoaderAddinClassName.Name = "txtLoaderAddinClassName";
            this.txtLoaderAddinClassName.Size = new System.Drawing.Size(219, 20);
            this.txtLoaderAddinClassName.TabIndex = 46;
            this.txtLoaderAddinClassName.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(61, 13);
            this.label23.TabIndex = 45;
            this.label23.Text = "Class name";
            // 
            // cbLoaderViaProxy
            // 
            this.cbLoaderViaProxy.AutoSize = true;
            this.cbLoaderViaProxy.Location = new System.Drawing.Point(98, 75);
            this.cbLoaderViaProxy.Name = "cbLoaderViaProxy";
            this.cbLoaderViaProxy.Size = new System.Drawing.Size(69, 17);
            this.cbLoaderViaProxy.TabIndex = 45;
            this.cbLoaderViaProxy.Text = "Via proxy";
            this.cbLoaderViaProxy.UseVisualStyleBackColor = true;
            this.cbLoaderViaProxy.CheckedChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            this.cbLoaderViaProxy.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // cbLoaderManaged
            // 
            this.cbLoaderManaged.AutoSize = true;
            this.cbLoaderManaged.Checked = true;
            this.cbLoaderManaged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLoaderManaged.Location = new System.Drawing.Point(21, 75);
            this.cbLoaderManaged.Name = "cbLoaderManaged";
            this.cbLoaderManaged.Size = new System.Drawing.Size(71, 17);
            this.cbLoaderManaged.TabIndex = 44;
            this.cbLoaderManaged.Text = "Managed";
            this.cbLoaderManaged.UseVisualStyleBackColor = true;
            this.cbLoaderManaged.CheckedChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            this.cbLoaderManaged.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // btnLoaderSelectLoaderDll
            // 
            this.btnLoaderSelectLoaderDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoaderSelectLoaderDll.Location = new System.Drawing.Point(695, 75);
            this.btnLoaderSelectLoaderDll.Name = "btnLoaderSelectLoaderDll";
            this.btnLoaderSelectLoaderDll.Size = new System.Drawing.Size(25, 23);
            this.btnLoaderSelectLoaderDll.TabIndex = 43;
            this.btnLoaderSelectLoaderDll.Text = "...";
            this.btnLoaderSelectLoaderDll.UseVisualStyleBackColor = true;
            this.btnLoaderSelectLoaderDll.Click += new System.EventHandler(this.btnLoaderSelectLoaderDll_Click);
            // 
            // txtLoaderLoaderDll
            // 
            this.txtLoaderLoaderDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaderLoaderDll.Location = new System.Drawing.Point(259, 77);
            this.txtLoaderLoaderDll.Name = "txtLoaderLoaderDll";
            this.txtLoaderLoaderDll.Size = new System.Drawing.Size(435, 20);
            this.txtLoaderLoaderDll.TabIndex = 42;
            this.txtLoaderLoaderDll.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(256, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(87, 13);
            this.label22.TabIndex = 41;
            this.label22.Text = "Loader DLL path";
            // 
            // gbLoaderProxy
            // 
            this.gbLoaderProxy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLoaderProxy.Controls.Add(this.txtLoaderAddinVersion);
            this.gbLoaderProxy.Controls.Add(this.label15);
            this.gbLoaderProxy.Controls.Add(this.txtLoaderAddinGuid);
            this.gbLoaderProxy.Controls.Add(this.label16);
            this.gbLoaderProxy.Controls.Add(this.txtLoaderProxyFullName);
            this.gbLoaderProxy.Controls.Add(this.label17);
            this.gbLoaderProxy.Controls.Add(this.txtLoaderProxyShortName);
            this.gbLoaderProxy.Controls.Add(this.label18);
            this.gbLoaderProxy.Controls.Add(this.btnLoaderSelectProxyDll);
            this.gbLoaderProxy.Controls.Add(this.txtLoaderProxyDll);
            this.gbLoaderProxy.Controls.Add(this.label19);
            this.gbLoaderProxy.Enabled = false;
            this.gbLoaderProxy.Location = new System.Drawing.Point(21, 104);
            this.gbLoaderProxy.Name = "gbLoaderProxy";
            this.gbLoaderProxy.Size = new System.Drawing.Size(698, 155);
            this.gbLoaderProxy.TabIndex = 40;
            this.gbLoaderProxy.TabStop = false;
            this.gbLoaderProxy.Text = "Proxy";
            // 
            // txtLoaderAddinVersion
            // 
            this.txtLoaderAddinVersion.Location = new System.Drawing.Point(249, 121);
            this.txtLoaderAddinVersion.Name = "txtLoaderAddinVersion";
            this.txtLoaderAddinVersion.Size = new System.Drawing.Size(219, 20);
            this.txtLoaderAddinVersion.TabIndex = 50;
            this.txtLoaderAddinVersion.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(246, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Addin version";
            // 
            // txtLoaderAddinGuid
            // 
            this.txtLoaderAddinGuid.Location = new System.Drawing.Point(12, 121);
            this.txtLoaderAddinGuid.Name = "txtLoaderAddinGuid";
            this.txtLoaderAddinGuid.Size = new System.Drawing.Size(219, 20);
            this.txtLoaderAddinGuid.TabIndex = 48;
            this.txtLoaderAddinGuid.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 105);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 47;
            this.label16.Text = "Addin GUID";
            // 
            // txtLoaderProxyFullName
            // 
            this.txtLoaderProxyFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaderProxyFullName.Location = new System.Drawing.Point(249, 75);
            this.txtLoaderProxyFullName.Name = "txtLoaderProxyFullName";
            this.txtLoaderProxyFullName.Size = new System.Drawing.Size(440, 20);
            this.txtLoaderProxyFullName.TabIndex = 46;
            this.txtLoaderProxyFullName.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(246, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "Addin full name";
            // 
            // txtLoaderProxyShortName
            // 
            this.txtLoaderProxyShortName.Location = new System.Drawing.Point(12, 75);
            this.txtLoaderProxyShortName.Name = "txtLoaderProxyShortName";
            this.txtLoaderProxyShortName.Size = new System.Drawing.Size(219, 20);
            this.txtLoaderProxyShortName.TabIndex = 44;
            this.txtLoaderProxyShortName.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 13);
            this.label18.TabIndex = 43;
            this.label18.Text = "Addin short name";
            // 
            // btnLoaderSelectProxyDll
            // 
            this.btnLoaderSelectProxyDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoaderSelectProxyDll.Location = new System.Drawing.Point(664, 30);
            this.btnLoaderSelectProxyDll.Name = "btnLoaderSelectProxyDll";
            this.btnLoaderSelectProxyDll.Size = new System.Drawing.Size(25, 23);
            this.btnLoaderSelectProxyDll.TabIndex = 42;
            this.btnLoaderSelectProxyDll.Text = "...";
            this.btnLoaderSelectProxyDll.UseVisualStyleBackColor = true;
            this.btnLoaderSelectProxyDll.Click += new System.EventHandler(this.btnLoaderSelectProxyDll_Click);
            // 
            // txtLoaderProxyDll
            // 
            this.txtLoaderProxyDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaderProxyDll.Location = new System.Drawing.Point(12, 33);
            this.txtLoaderProxyDll.Name = "txtLoaderProxyDll";
            this.txtLoaderProxyDll.Size = new System.Drawing.Size(649, 20);
            this.txtLoaderProxyDll.TabIndex = 41;
            this.txtLoaderProxyDll.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Proxy DLL path";
            // 
            // btnLoaderRegister
            // 
            this.btnLoaderRegister.Enabled = false;
            this.btnLoaderRegister.Location = new System.Drawing.Point(554, 399);
            this.btnLoaderRegister.Name = "btnLoaderRegister";
            this.btnLoaderRegister.Size = new System.Drawing.Size(166, 23);
            this.btnLoaderRegister.TabIndex = 28;
            this.btnLoaderRegister.Text = "Register via Loader";
            this.btnLoaderRegister.UseVisualStyleBackColor = true;
            this.btnLoaderRegister.Click += new System.EventHandler(this.btnLoaderRegister_Click);
            // 
            // btnLoaderSelectAddinDll
            // 
            this.btnLoaderSelectAddinDll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoaderSelectAddinDll.Location = new System.Drawing.Point(695, 29);
            this.btnLoaderSelectAddinDll.Name = "btnLoaderSelectAddinDll";
            this.btnLoaderSelectAddinDll.Size = new System.Drawing.Size(25, 23);
            this.btnLoaderSelectAddinDll.TabIndex = 27;
            this.btnLoaderSelectAddinDll.Text = "...";
            this.btnLoaderSelectAddinDll.UseVisualStyleBackColor = true;
            this.btnLoaderSelectAddinDll.Click += new System.EventHandler(this.btnLoaderSelectAddinDll_Click);
            // 
            // txtLoaderAddinDll
            // 
            this.txtLoaderAddinDll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLoaderAddinDll.Location = new System.Drawing.Point(259, 31);
            this.txtLoaderAddinDll.Name = "txtLoaderAddinDll";
            this.txtLoaderAddinDll.Size = new System.Drawing.Size(435, 20);
            this.txtLoaderAddinDll.TabIndex = 26;
            this.txtLoaderAddinDll.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(256, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(84, 13);
            this.label20.TabIndex = 25;
            this.label20.Text = "Add-in DLL path";
            // 
            // txtLoaderAddinRegKey
            // 
            this.txtLoaderAddinRegKey.Location = new System.Drawing.Point(21, 31);
            this.txtLoaderAddinRegKey.Name = "txtLoaderAddinRegKey";
            this.txtLoaderAddinRegKey.Size = new System.Drawing.Size(219, 20);
            this.txtLoaderAddinRegKey.TabIndex = 24;
            this.txtLoaderAddinRegKey.TextChanged += new System.EventHandler(this.RegisterProxyValidate_ValueChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 15);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Addin registry key name";
            // 
            // odAddinDll
            // 
            this.odAddinDll.FileName = "Addin.dll";
            this.odAddinDll.Filter = "Dll files |*.dll";
            this.odAddinDll.Title = "Select the add-in dll";
            // 
            // odProxyDll
            // 
            this.odProxyDll.FileName = "Addin.dll";
            this.odProxyDll.Filter = "Dll files |*.dll";
            this.odProxyDll.Title = "Select the proxy dll";
            // 
            // odLoaderDll
            // 
            this.odLoaderDll.FileName = "Addin.dll";
            this.odLoaderDll.Filter = "Dll files |*.dll";
            this.odLoaderDll.Title = "Select the loader dll";
            // 
            // odConfigFile
            // 
            this.odConfigFile.FileName = "Addin.dll";
            this.odConfigFile.Filter = "Config files |*.config";
            this.odConfigFile.Title = "Select the config file";
            // 
            // Interractive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 538);
            this.Controls.Add(this.tbActions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbApplication);
            this.Name = "Interractive";
            this.Text = "Addin registration utility";
            this.Load += new System.EventHandler(this.Interractive_Load);
            this.tbActions.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.gbLoaderManaged.ResumeLayout(false);
            this.gbLoaderManaged.PerformLayout();
            this.gbLoaderProxy.ResumeLayout(false);
            this.gbLoaderProxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbApplication;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tbActions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUnregisterAllAddins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemoveSelectedAddin;
        private System.Windows.Forms.ComboBox cbAddinToRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lstAddinsList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtViewAddinDLLPath;
        private System.Windows.Forms.TextBox txtViewAddinRegKey;
        private System.Windows.Forms.Button btnRefreshViewAddins;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtSignedRegKeyName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSignedSelectAddinDll;
        private System.Windows.Forms.TextBox txtSignedAddinDLL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.OpenFileDialog odAddinDll;
        private System.Windows.Forms.Button btnRegisterSignedAddin;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnProxyRegister;
        private System.Windows.Forms.Button btnProxySelectAddinDll;
        private System.Windows.Forms.TextBox txtProxyAddinDll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProxyRegKeyName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnProxySelectProxyDll;
        private System.Windows.Forms.TextBox txtProxyDll;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProxyFullName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProxyShortName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProxyVersion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProxyGuid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog odProxyDll;
        private System.Windows.Forms.Button btnViewUnregister;
        private System.Windows.Forms.GroupBox gbLoaderManaged;
        private System.Windows.Forms.MaskedTextBox txtLoaderFpu;
        private System.Windows.Forms.CheckBox cbLoaderDefaultFPU;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnLoaderSelectConfigFile;
        private System.Windows.Forms.TextBox txtLoaderConfigFile;
        private System.Windows.Forms.TextBox txtLoaderAddinClassName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox cbLoaderViaProxy;
        private System.Windows.Forms.CheckBox cbLoaderManaged;
        private System.Windows.Forms.Button btnLoaderSelectLoaderDll;
        private System.Windows.Forms.TextBox txtLoaderLoaderDll;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox gbLoaderProxy;
        private System.Windows.Forms.TextBox txtLoaderAddinVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLoaderAddinGuid;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtLoaderProxyFullName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLoaderProxyShortName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnLoaderSelectProxyDll;
        private System.Windows.Forms.TextBox txtLoaderProxyDll;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnLoaderRegister;
        private System.Windows.Forms.Button btnLoaderSelectAddinDll;
        private System.Windows.Forms.TextBox txtLoaderAddinDll;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtLoaderAddinRegKey;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.OpenFileDialog odLoaderDll;
        private System.Windows.Forms.OpenFileDialog odConfigFile;
    }
}