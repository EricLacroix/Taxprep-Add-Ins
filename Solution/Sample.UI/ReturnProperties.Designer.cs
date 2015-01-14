namespace WKCA.Sample
{
    partial class ReturnProperties
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
            this.txtReturnStatusEng = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReturnStatusFr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatusEnumName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtStatusValueFr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatusValueEn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtReturnStatusEng
            // 
            this.txtReturnStatusEng.Location = new System.Drawing.Point(138, 253);
            this.txtReturnStatusEng.Name = "txtReturnStatusEng";
            this.txtReturnStatusEng.Size = new System.Drawing.Size(395, 20);
            this.txtReturnStatusEng.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Return status Eng:";
            // 
            // txtReturnStatusFr
            // 
            this.txtReturnStatusFr.Location = new System.Drawing.Point(138, 279);
            this.txtReturnStatusFr.Name = "txtReturnStatusFr";
            this.txtReturnStatusFr.Size = new System.Drawing.Size(395, 20);
            this.txtReturnStatusFr.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Return status Fr:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtStatusValueFr);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStatusValueEn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtStatusEnumName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(24, 315);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Enum name";
            // 
            // txtStatusEnumName
            // 
            this.txtStatusEnumName.Location = new System.Drawing.Point(22, 45);
            this.txtStatusEnumName.Name = "txtStatusEnumName";
            this.txtStatusEnumName.Size = new System.Drawing.Size(121, 20);
            this.txtStatusEnumName.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtStatusValueFr
            // 
            this.txtStatusValueFr.Location = new System.Drawing.Point(369, 54);
            this.txtStatusValueFr.Name = "txtStatusValueFr";
            this.txtStatusValueFr.Size = new System.Drawing.Size(134, 20);
            this.txtStatusValueFr.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Return status Fr:";
            // 
            // txtStatusValueEn
            // 
            this.txtStatusValueEn.Location = new System.Drawing.Point(369, 28);
            this.txtStatusValueEn.Name = "txtStatusValueEn";
            this.txtStatusValueEn.Size = new System.Drawing.Size(134, 20);
            this.txtStatusValueEn.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Return status Eng:";
            // 
            // txtStatus
            // 
            this.txtStatus.FormattingEnabled = true;
            this.txtStatus.Location = new System.Drawing.Point(24, 12);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(503, 225);
            this.txtStatus.TabIndex = 8;
            // 
            // ReturnProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 438);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtReturnStatusFr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtReturnStatusEng);
            this.Controls.Add(this.label2);
            this.Name = "ReturnProperties";
            this.Text = "ReturnProperties";
            this.Load += new System.EventHandler(this.ReturnProperties_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReturnStatusEng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReturnStatusFr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtStatusEnumName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStatusValueFr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatusValueEn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox txtStatus;
    }
}