namespace WKCA.Sample
{
    partial class OpenClientFile
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "optWithClientFileManager",
            "optOpenNoPasswordGUI_Open",
            "optOpenNoPasswordGUI_Fail",
            "optOpenNoAskReadOnly",
            "optOpenDocumentAlreadyLoaded",
            "optOpenClientFileHeaderOnly",
            "optOpenDocumentHeaderOnly",
            "optOpenDatabaseOnly",
            "optOpenOnlyReadOnly",
            "optOpenOnlyReadWrite",
            "optOpenCurrentYearOnly",
            "optOpenNoDiagnostics",
            "optOpenReturnIdListOnly",
            "optOpenNoClientFileHeader",
            "optOpenCheckCalcVersions",
            "optOpenRecalcForDLL",
            "optOpenReadOnlyForDll",
            "optOpenRecalcForProfile",
            "optOpenReadOnlyForProfile",
            "optOpenRecalcForRates",
            "optOpenReadOnlyForRates",
            "OptOpenBatch",
            "optOpenNoMRU",
            "optOpenPlanner",
            "optOpenClientFile",
            "optSetPlanner",
            "optPlannerDefaultFilter",
            "optOpenEPOnly",
            "optOpenNoCreateEPFile",
            "optCanRecalcAlways",
            "optCheckFiscalPeriod",
            "optOpenNoUpdateVersion"});
            this.checkedListBox1.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(248, 529);
            this.checkedListBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(268, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenClientFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "OpenClientFile";
            this.Text = "OpenClientFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}