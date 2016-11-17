namespace WKCA.Sample
{
    partial class ConfigurationDemo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReopenLastUsedForms = new System.Windows.Forms.CheckBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuickOverride = new System.Windows.Forms.CheckBox();
            this.HaveToShowValidation = new System.Windows.Forms.CheckBox();
            this.ShowLastYearDataInTaxReturn = new System.Windows.Forms.CheckBox();
            this.AlwaysRecalculate = new System.Windows.Forms.CheckBox();
            this.AlwaysUpdateProfil = new System.Windows.Forms.CheckBox();
            this.LockWhenCompleted = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LockWhenCompleted);
            this.groupBox1.Controls.Add(this.AlwaysUpdateProfil);
            this.groupBox1.Controls.Add(this.AlwaysRecalculate);
            this.groupBox1.Controls.Add(this.ShowLastYearDataInTaxReturn);
            this.groupBox1.Controls.Add(this.HaveToShowValidation);
            this.groupBox1.Controls.Add(this.QuickOverride);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Max);
            this.groupBox1.Controls.Add(this.ReopenLastUsedForms);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // ReopenLastUsedForms
            // 
            this.ReopenLastUsedForms.AutoSize = true;
            this.ReopenLastUsedForms.Location = new System.Drawing.Point(19, 35);
            this.ReopenLastUsedForms.Name = "ReopenLastUsedForms";
            this.ReopenLastUsedForms.Size = new System.Drawing.Size(156, 17);
            this.ReopenLastUsedForms.TabIndex = 0;
            this.ReopenLastUsedForms.Text = "Show auto text suggestions";
            this.ReopenLastUsedForms.UseVisualStyleBackColor = true;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(209, 33);
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(62, 20);
            this.Max.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "entries";
            // 
            // QuickOverride
            // 
            this.QuickOverride.AutoSize = true;
            this.QuickOverride.Location = new System.Drawing.Point(19, 67);
            this.QuickOverride.Name = "QuickOverride";
            this.QuickOverride.Size = new System.Drawing.Size(110, 17);
            this.QuickOverride.TabIndex = 3;
            this.QuickOverride.Text = "Confirm overriding";
            this.QuickOverride.UseVisualStyleBackColor = true;
            // 
            // HaveToShowValidation
            // 
            this.HaveToShowValidation.AutoSize = true;
            this.HaveToShowValidation.Location = new System.Drawing.Point(19, 99);
            this.HaveToShowValidation.Name = "HaveToShowValidation";
            this.HaveToShowValidation.Size = new System.Drawing.Size(157, 17);
            this.HaveToShowValidation.TabIndex = 4;
            this.HaveToShowValidation.Text = "Show diagnostics indicators";
            this.HaveToShowValidation.UseVisualStyleBackColor = true;
            // 
            // ShowLastYearDataInTaxReturn
            // 
            this.ShowLastYearDataInTaxReturn.AutoSize = true;
            this.ShowLastYearDataInTaxReturn.Location = new System.Drawing.Point(19, 133);
            this.ShowLastYearDataInTaxReturn.Name = "ShowLastYearDataInTaxReturn";
            this.ShowLastYearDataInTaxReturn.Size = new System.Drawing.Size(247, 17);
            this.ShowLastYearDataInTaxReturn.TabIndex = 5;
            this.ShowLastYearDataInTaxReturn.Text = "Identify the cells with the data entered last year";
            this.ShowLastYearDataInTaxReturn.UseVisualStyleBackColor = true;
            // 
            // AlwaysRecalculate
            // 
            this.AlwaysRecalculate.AutoSize = true;
            this.AlwaysRecalculate.Location = new System.Drawing.Point(19, 165);
            this.AlwaysRecalculate.Name = "AlwaysRecalculate";
            this.AlwaysRecalculate.Size = new System.Drawing.Size(302, 17);
            this.AlwaysRecalculate.TabIndex = 6;
            this.AlwaysRecalculate.Text = "Recalculate automatically if the program version is different";
            this.AlwaysRecalculate.UseVisualStyleBackColor = true;
            // 
            // AlwaysUpdateProfil
            // 
            this.AlwaysUpdateProfil.AutoSize = true;
            this.AlwaysUpdateProfil.Location = new System.Drawing.Point(19, 200);
            this.AlwaysUpdateProfil.Name = "AlwaysUpdateProfil";
            this.AlwaysUpdateProfil.Size = new System.Drawing.Size(297, 17);
            this.AlwaysUpdateProfil.TabIndex = 7;
            this.AlwaysUpdateProfil.Text = "Recalculate automatically if the preparer profile is different";
            this.AlwaysUpdateProfil.UseVisualStyleBackColor = true;
            // 
            // LockWhenCompleted
            // 
            this.LockWhenCompleted.AutoSize = true;
            this.LockWhenCompleted.Location = new System.Drawing.Point(18, 232);
            this.LockWhenCompleted.Name = "LockWhenCompleted";
            this.LockWhenCompleted.Size = new System.Drawing.Size(220, 17);
            this.LockWhenCompleted.TabIndex = 8;
            this.LockWhenCompleted.Text = "Lock data then the status is \"Completed\"";
            this.LockWhenCompleted.UseVisualStyleBackColor = true;
            // 
            // ConfigurationDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 316);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationDemo";
            this.Text = "ConfigurationDemo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox HaveToShowValidation;
        private System.Windows.Forms.CheckBox QuickOverride;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Max;
        private System.Windows.Forms.CheckBox ReopenLastUsedForms;
        private System.Windows.Forms.CheckBox AlwaysRecalculate;
        private System.Windows.Forms.CheckBox ShowLastYearDataInTaxReturn;
        private System.Windows.Forms.CheckBox AlwaysUpdateProfil;
        private System.Windows.Forms.CheckBox LockWhenCompleted;
    }
}