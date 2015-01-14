namespace WKCA.Sample
{
    partial class AdvertisingButton
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.cbVisible = new System.Windows.Forms.CheckBox();
            this.txtIdent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hint";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Width";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(26, 42);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(306, 20);
            this.txtCaption.TabIndex = 3;
            // 
            // txtHint
            // 
            this.txtHint.Location = new System.Drawing.Point(26, 90);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(306, 20);
            this.txtHint.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(26, 151);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(119, 20);
            this.txtWidth.TabIndex = 5;
            // 
            // cbVisible
            // 
            this.cbVisible.AutoSize = true;
            this.cbVisible.Location = new System.Drawing.Point(26, 199);
            this.cbVisible.Name = "cbVisible";
            this.cbVisible.Size = new System.Drawing.Size(56, 17);
            this.cbVisible.TabIndex = 6;
            this.cbVisible.Text = "Visible";
            this.cbVisible.UseVisualStyleBackColor = true;
            // 
            // txtIdent
            // 
            this.txtIdent.Location = new System.Drawing.Point(26, 253);
            this.txtIdent.Name = "txtIdent";
            this.txtIdent.Size = new System.Drawing.Size(306, 20);
            this.txtIdent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ident";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdvertisingButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtIdent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbVisible);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.txtCaption);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdvertisingButton";
            this.Text = "AdvertisingButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.CheckBox cbVisible;
        private System.Windows.Forms.TextBox txtIdent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}