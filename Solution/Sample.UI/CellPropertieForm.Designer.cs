namespace WKCA.Sample
{
    partial class CellPropertieForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDefaultForm = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblXlatEnum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLinkCellData = new System.Windows.Forms.Button();
            this.cbIsLinkCell = new System.Windows.Forms.CheckBox();
            this.cbHasTransferredValue = new System.Windows.Forms.CheckBox();
            this.cbIsDeprecated = new System.Windows.Forms.CheckBox();
            this.cbIsRoundOnAssign = new System.Windows.Forms.CheckBox();
            this.cbIsSelectable = new System.Windows.Forms.CheckBox();
            this.cbIsRolled = new System.Windows.Forms.CheckBox();
            this.cbIsProtected = new System.Windows.Forms.CheckBox();
            this.cbIsSourceEstimate = new System.Windows.Forms.CheckBox();
            this.cbIsNA = new System.Windows.Forms.CheckBox();
            this.cbIsPositiveOnly = new System.Windows.Forms.CheckBox();
            this.cbHasUserOvrd = new System.Windows.Forms.CheckBox();
            this.cbHasRolledValue = new System.Windows.Forms.CheckBox();
            this.cbHasInternalOvrd = new System.Windows.Forms.CheckBox();
            this.cbHasFormNum = new System.Windows.Forms.CheckBox();
            this.cbIsTracking = new System.Windows.Forms.CheckBox();
            this.cbIsEstimated = new System.Windows.Forms.CheckBox();
            this.cbIsEmpty = new System.Windows.Forms.CheckBox();
            this.cbHasImport = new System.Windows.Forms.CheckBox();
            this.cbHasCalc = new System.Windows.Forms.CheckBox();
            this.cbHasInput = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.txtAliases = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblContentType = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbXlatFr2 = new System.Windows.Forms.ComboBox();
            this.cbXlatEng2 = new System.Windows.Forms.ComboBox();
            this.cbXlatFr1 = new System.Windows.Forms.ComboBox();
            this.cbXlatEng1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbXlatFr0 = new System.Windows.Forms.ComboBox();
            this.cbXlatEng0 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCells = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 24);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(621, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Type:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(68, 62);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(0, 13);
            this.lblType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Default Form:";
            // 
            // lblDefaultForm
            // 
            this.lblDefaultForm.AutoSize = true;
            this.lblDefaultForm.Location = new System.Drawing.Point(320, 62);
            this.lblDefaultForm.Name = "lblDefaultForm";
            this.lblDefaultForm.Size = new System.Drawing.Size(0, 13);
            this.lblDefaultForm.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enum (for XLAT):";
            // 
            // lblXlatEnum
            // 
            this.lblXlatEnum.AutoSize = true;
            this.lblXlatEnum.Location = new System.Drawing.Point(106, 89);
            this.lblXlatEnum.Name = "lblXlatEnum";
            this.lblXlatEnum.Size = new System.Drawing.Size(33, 13);
            this.lblXlatEnum.TabIndex = 6;
            this.lblXlatEnum.Text = "None";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLinkCellData);
            this.groupBox1.Controls.Add(this.cbIsLinkCell);
            this.groupBox1.Controls.Add(this.cbHasTransferredValue);
            this.groupBox1.Controls.Add(this.cbIsDeprecated);
            this.groupBox1.Controls.Add(this.cbIsRoundOnAssign);
            this.groupBox1.Controls.Add(this.cbIsSelectable);
            this.groupBox1.Controls.Add(this.cbIsRolled);
            this.groupBox1.Controls.Add(this.cbIsProtected);
            this.groupBox1.Controls.Add(this.cbIsSourceEstimate);
            this.groupBox1.Controls.Add(this.cbIsNA);
            this.groupBox1.Controls.Add(this.cbIsPositiveOnly);
            this.groupBox1.Controls.Add(this.cbHasUserOvrd);
            this.groupBox1.Controls.Add(this.cbHasRolledValue);
            this.groupBox1.Controls.Add(this.cbHasInternalOvrd);
            this.groupBox1.Controls.Add(this.cbHasFormNum);
            this.groupBox1.Controls.Add(this.cbIsTracking);
            this.groupBox1.Controls.Add(this.cbIsEstimated);
            this.groupBox1.Controls.Add(this.cbIsEmpty);
            this.groupBox1.Controls.Add(this.cbHasImport);
            this.groupBox1.Controls.Add(this.cbHasCalc);
            this.groupBox1.Controls.Add(this.cbHasInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 179);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flags";
            // 
            // btnLinkCellData
            // 
            this.btnLinkCellData.Location = new System.Drawing.Point(348, 94);
            this.btnLinkCellData.Name = "btnLinkCellData";
            this.btnLinkCellData.Size = new System.Drawing.Size(75, 23);
            this.btnLinkCellData.TabIndex = 22;
            this.btnLinkCellData.Text = "LinkCell";
            this.btnLinkCellData.UseVisualStyleBackColor = true;
            this.btnLinkCellData.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbIsLinkCell
            // 
            this.cbIsLinkCell.AutoSize = true;
            this.cbIsLinkCell.Location = new System.Drawing.Point(348, 52);
            this.cbIsLinkCell.Name = "cbIsLinkCell";
            this.cbIsLinkCell.Size = new System.Drawing.Size(86, 17);
            this.cbIsLinkCell.TabIndex = 21;
            this.cbIsLinkCell.Text = "Is Link CELL";
            this.cbIsLinkCell.UseVisualStyleBackColor = true;
            // 
            // cbHasTransferredValue
            // 
            this.cbHasTransferredValue.AutoCheck = false;
            this.cbHasTransferredValue.AutoSize = true;
            this.cbHasTransferredValue.Location = new System.Drawing.Point(348, 29);
            this.cbHasTransferredValue.Name = "cbHasTransferredValue";
            this.cbHasTransferredValue.Size = new System.Drawing.Size(126, 17);
            this.cbHasTransferredValue.TabIndex = 20;
            this.cbHasTransferredValue.Text = "HasTransferredValue";
            this.cbHasTransferredValue.UseVisualStyleBackColor = true;
            // 
            // cbIsDeprecated
            // 
            this.cbIsDeprecated.AutoCheck = false;
            this.cbIsDeprecated.AutoSize = true;
            this.cbIsDeprecated.Location = new System.Drawing.Point(215, 144);
            this.cbIsDeprecated.Name = "cbIsDeprecated";
            this.cbIsDeprecated.Size = new System.Drawing.Size(90, 17);
            this.cbIsDeprecated.TabIndex = 17;
            this.cbIsDeprecated.Text = "IsDeprecated";
            this.cbIsDeprecated.UseVisualStyleBackColor = true;
            // 
            // cbIsRoundOnAssign
            // 
            this.cbIsRoundOnAssign.AutoCheck = false;
            this.cbIsRoundOnAssign.AutoSize = true;
            this.cbIsRoundOnAssign.Location = new System.Drawing.Point(215, 121);
            this.cbIsRoundOnAssign.Name = "cbIsRoundOnAssign";
            this.cbIsRoundOnAssign.Size = new System.Drawing.Size(111, 17);
            this.cbIsRoundOnAssign.TabIndex = 16;
            this.cbIsRoundOnAssign.Text = "IsRoundOnAssign";
            this.cbIsRoundOnAssign.UseVisualStyleBackColor = true;
            // 
            // cbIsSelectable
            // 
            this.cbIsSelectable.AutoCheck = false;
            this.cbIsSelectable.AutoSize = true;
            this.cbIsSelectable.Location = new System.Drawing.Point(215, 98);
            this.cbIsSelectable.Name = "cbIsSelectable";
            this.cbIsSelectable.Size = new System.Drawing.Size(84, 17);
            this.cbIsSelectable.TabIndex = 15;
            this.cbIsSelectable.Text = "IsSelectable";
            this.cbIsSelectable.UseVisualStyleBackColor = true;
            // 
            // cbIsRolled
            // 
            this.cbIsRolled.AutoCheck = false;
            this.cbIsRolled.AutoSize = true;
            this.cbIsRolled.Location = new System.Drawing.Point(215, 75);
            this.cbIsRolled.Name = "cbIsRolled";
            this.cbIsRolled.Size = new System.Drawing.Size(64, 17);
            this.cbIsRolled.TabIndex = 14;
            this.cbIsRolled.Text = "IsRolled";
            this.cbIsRolled.UseVisualStyleBackColor = true;
            // 
            // cbIsProtected
            // 
            this.cbIsProtected.AutoCheck = false;
            this.cbIsProtected.AutoSize = true;
            this.cbIsProtected.Location = new System.Drawing.Point(215, 52);
            this.cbIsProtected.Name = "cbIsProtected";
            this.cbIsProtected.Size = new System.Drawing.Size(80, 17);
            this.cbIsProtected.TabIndex = 13;
            this.cbIsProtected.Text = "IsProtected";
            this.cbIsProtected.UseVisualStyleBackColor = true;
            // 
            // cbIsSourceEstimate
            // 
            this.cbIsSourceEstimate.AutoCheck = false;
            this.cbIsSourceEstimate.AutoSize = true;
            this.cbIsSourceEstimate.Location = new System.Drawing.Point(215, 29);
            this.cbIsSourceEstimate.Name = "cbIsSourceEstimate";
            this.cbIsSourceEstimate.Size = new System.Drawing.Size(108, 17);
            this.cbIsSourceEstimate.TabIndex = 12;
            this.cbIsSourceEstimate.Text = "IsSourceEstimate";
            this.cbIsSourceEstimate.UseVisualStyleBackColor = true;
            // 
            // cbIsNA
            // 
            this.cbIsNA.AutoCheck = false;
            this.cbIsNA.AutoSize = true;
            this.cbIsNA.Location = new System.Drawing.Point(97, 144);
            this.cbIsNA.Name = "cbIsNA";
            this.cbIsNA.Size = new System.Drawing.Size(49, 17);
            this.cbIsNA.TabIndex = 11;
            this.cbIsNA.Text = "IsNA";
            this.cbIsNA.UseVisualStyleBackColor = true;
            // 
            // cbIsPositiveOnly
            // 
            this.cbIsPositiveOnly.AutoCheck = false;
            this.cbIsPositiveOnly.AutoSize = true;
            this.cbIsPositiveOnly.Location = new System.Drawing.Point(97, 121);
            this.cbIsPositiveOnly.Name = "cbIsPositiveOnly";
            this.cbIsPositiveOnly.Size = new System.Drawing.Size(92, 17);
            this.cbIsPositiveOnly.TabIndex = 10;
            this.cbIsPositiveOnly.Text = "IsPositiveOnly";
            this.cbIsPositiveOnly.UseVisualStyleBackColor = true;
            // 
            // cbHasUserOvrd
            // 
            this.cbHasUserOvrd.AutoCheck = false;
            this.cbHasUserOvrd.AutoSize = true;
            this.cbHasUserOvrd.Location = new System.Drawing.Point(97, 98);
            this.cbHasUserOvrd.Name = "cbHasUserOvrd";
            this.cbHasUserOvrd.Size = new System.Drawing.Size(90, 17);
            this.cbHasUserOvrd.TabIndex = 9;
            this.cbHasUserOvrd.Text = "HasUserOvrd";
            this.cbHasUserOvrd.UseVisualStyleBackColor = true;
            // 
            // cbHasRolledValue
            // 
            this.cbHasRolledValue.AutoCheck = false;
            this.cbHasRolledValue.AutoSize = true;
            this.cbHasRolledValue.Location = new System.Drawing.Point(97, 75);
            this.cbHasRolledValue.Name = "cbHasRolledValue";
            this.cbHasRolledValue.Size = new System.Drawing.Size(102, 17);
            this.cbHasRolledValue.TabIndex = 8;
            this.cbHasRolledValue.Text = "HasRolledValue";
            this.cbHasRolledValue.UseVisualStyleBackColor = true;
            // 
            // cbHasInternalOvrd
            // 
            this.cbHasInternalOvrd.AutoCheck = false;
            this.cbHasInternalOvrd.AutoSize = true;
            this.cbHasInternalOvrd.Location = new System.Drawing.Point(97, 52);
            this.cbHasInternalOvrd.Name = "cbHasInternalOvrd";
            this.cbHasInternalOvrd.Size = new System.Drawing.Size(103, 17);
            this.cbHasInternalOvrd.TabIndex = 7;
            this.cbHasInternalOvrd.Text = "HasInternalOvrd";
            this.cbHasInternalOvrd.UseVisualStyleBackColor = true;
            // 
            // cbHasFormNum
            // 
            this.cbHasFormNum.AutoCheck = false;
            this.cbHasFormNum.AutoSize = true;
            this.cbHasFormNum.Location = new System.Drawing.Point(97, 29);
            this.cbHasFormNum.Name = "cbHasFormNum";
            this.cbHasFormNum.Size = new System.Drawing.Size(90, 17);
            this.cbHasFormNum.TabIndex = 6;
            this.cbHasFormNum.Text = "HasFormNum";
            this.cbHasFormNum.UseVisualStyleBackColor = true;
            // 
            // cbIsTracking
            // 
            this.cbIsTracking.AutoCheck = false;
            this.cbIsTracking.AutoSize = true;
            this.cbIsTracking.Location = new System.Drawing.Point(8, 144);
            this.cbIsTracking.Name = "cbIsTracking";
            this.cbIsTracking.Size = new System.Drawing.Size(76, 17);
            this.cbIsTracking.TabIndex = 5;
            this.cbIsTracking.Text = "IsTracking";
            this.cbIsTracking.UseVisualStyleBackColor = true;
            // 
            // cbIsEstimated
            // 
            this.cbIsEstimated.AutoCheck = false;
            this.cbIsEstimated.AutoSize = true;
            this.cbIsEstimated.Location = new System.Drawing.Point(8, 121);
            this.cbIsEstimated.Name = "cbIsEstimated";
            this.cbIsEstimated.Size = new System.Drawing.Size(80, 17);
            this.cbIsEstimated.TabIndex = 4;
            this.cbIsEstimated.Text = "IsEstimated";
            this.cbIsEstimated.UseVisualStyleBackColor = true;
            // 
            // cbIsEmpty
            // 
            this.cbIsEmpty.AutoCheck = false;
            this.cbIsEmpty.AutoSize = true;
            this.cbIsEmpty.Location = new System.Drawing.Point(8, 98);
            this.cbIsEmpty.Name = "cbIsEmpty";
            this.cbIsEmpty.Size = new System.Drawing.Size(63, 17);
            this.cbIsEmpty.TabIndex = 3;
            this.cbIsEmpty.Text = "IsEmpty";
            this.cbIsEmpty.UseVisualStyleBackColor = true;
            // 
            // cbHasImport
            // 
            this.cbHasImport.AutoCheck = false;
            this.cbHasImport.AutoSize = true;
            this.cbHasImport.Location = new System.Drawing.Point(8, 75);
            this.cbHasImport.Name = "cbHasImport";
            this.cbHasImport.Size = new System.Drawing.Size(74, 17);
            this.cbHasImport.TabIndex = 2;
            this.cbHasImport.Text = "HasImport";
            this.cbHasImport.UseVisualStyleBackColor = true;
            // 
            // cbHasCalc
            // 
            this.cbHasCalc.AutoCheck = false;
            this.cbHasCalc.AutoSize = true;
            this.cbHasCalc.Location = new System.Drawing.Point(8, 52);
            this.cbHasCalc.Name = "cbHasCalc";
            this.cbHasCalc.Size = new System.Drawing.Size(66, 17);
            this.cbHasCalc.TabIndex = 1;
            this.cbHasCalc.Text = "HasCalc";
            this.cbHasCalc.UseVisualStyleBackColor = true;
            // 
            // cbHasInput
            // 
            this.cbHasInput.AutoCheck = false;
            this.cbHasInput.AutoSize = true;
            this.cbHasInput.Location = new System.Drawing.Point(8, 29);
            this.cbHasInput.Name = "cbHasInput";
            this.cbHasInput.Size = new System.Drawing.Size(69, 17);
            this.cbHasInput.TabIndex = 0;
            this.cbHasInput.Text = "HasInput";
            this.cbHasInput.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Value:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(71, 303);
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(353, 54);
            this.txtValue.TabIndex = 9;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // txtAliases
            // 
            this.txtAliases.Location = new System.Drawing.Point(473, 303);
            this.txtAliases.Multiline = true;
            this.txtAliases.Name = "txtAliases";
            this.txtAliases.ReadOnly = true;
            this.txtAliases.Size = new System.Drawing.Size(160, 54);
            this.txtAliases.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Aliases:";
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.Location = new System.Drawing.Point(341, 89);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(33, 13);
            this.lblContentType.TabIndex = 14;
            this.lblContentType.Text = "None";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Content type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mask:";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(492, 59);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(141, 20);
            this.txtMask.TabIndex = 16;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbXlatFr2);
            this.groupBox2.Controls.Add(this.cbXlatEng2);
            this.groupBox2.Controls.Add(this.cbXlatFr1);
            this.groupBox2.Controls.Add(this.cbXlatEng1);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbXlatFr0);
            this.groupBox2.Controls.Add(this.cbXlatEng0);
            this.groupBox2.Location = new System.Drawing.Point(20, 412);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(613, 100);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "XLat";
            // 
            // cbXlatFr2
            // 
            this.cbXlatFr2.FormattingEnabled = true;
            this.cbXlatFr2.Location = new System.Drawing.Point(328, 61);
            this.cbXlatFr2.Name = "cbXlatFr2";
            this.cbXlatFr2.Size = new System.Drawing.Size(223, 21);
            this.cbXlatFr2.TabIndex = 32;
            this.cbXlatFr2.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // cbXlatEng2
            // 
            this.cbXlatEng2.FormattingEnabled = true;
            this.cbXlatEng2.Location = new System.Drawing.Point(328, 19);
            this.cbXlatEng2.Name = "cbXlatEng2";
            this.cbXlatEng2.Size = new System.Drawing.Size(223, 21);
            this.cbXlatEng2.TabIndex = 31;
            this.cbXlatEng2.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // cbXlatFr1
            // 
            this.cbXlatFr1.FormattingEnabled = true;
            this.cbXlatFr1.Location = new System.Drawing.Point(177, 61);
            this.cbXlatFr1.Name = "cbXlatFr1";
            this.cbXlatFr1.Size = new System.Drawing.Size(138, 21);
            this.cbXlatFr1.TabIndex = 30;
            this.cbXlatFr1.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // cbXlatEng1
            // 
            this.cbXlatEng1.FormattingEnabled = true;
            this.cbXlatEng1.Location = new System.Drawing.Point(177, 19);
            this.cbXlatEng1.Name = "cbXlatEng1";
            this.cbXlatEng1.Size = new System.Drawing.Size(138, 21);
            this.cbXlatEng1.TabIndex = 29;
            this.cbXlatEng1.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "French XLAT :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "English XLAT :";
            // 
            // cbXlatFr0
            // 
            this.cbXlatFr0.FormattingEnabled = true;
            this.cbXlatFr0.Location = new System.Drawing.Point(95, 61);
            this.cbXlatFr0.Name = "cbXlatFr0";
            this.cbXlatFr0.Size = new System.Drawing.Size(76, 21);
            this.cbXlatFr0.TabIndex = 26;
            this.cbXlatFr0.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // cbXlatEng0
            // 
            this.cbXlatEng0.FormattingEnabled = true;
            this.cbXlatEng0.Location = new System.Drawing.Point(95, 19);
            this.cbXlatEng0.Name = "cbXlatEng0";
            this.cbXlatEng0.Size = new System.Drawing.Size(76, 21);
            this.cbXlatEng0.TabIndex = 25;
            this.cbXlatEng0.SelectedIndexChanged += new System.EventHandler(this.cbXlatEng0_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtCells
            // 
            this.txtCells.Location = new System.Drawing.Point(639, 24);
            this.txtCells.Multiline = true;
            this.txtCells.Name = "txtCells";
            this.txtCells.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCells.Size = new System.Drawing.Size(253, 488);
            this.txtCells.TabIndex = 19;
            // 
            // CellPropertieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 540);
            this.Controls.Add(this.txtCells);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblContentType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAliases);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblXlatEnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDefaultForm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CellPropertieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cell properties from addin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CellPropertieForm_FormClosed);
            this.Load += new System.EventHandler(this.CellPropertieForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDefaultForm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblXlatEnum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHasInput;
        private System.Windows.Forms.CheckBox cbHasCalc;
        private System.Windows.Forms.CheckBox cbIsEmpty;
        private System.Windows.Forms.CheckBox cbHasImport;
        private System.Windows.Forms.CheckBox cbIsEstimated;
        private System.Windows.Forms.CheckBox cbIsTracking;
        private System.Windows.Forms.CheckBox cbIsNA;
        private System.Windows.Forms.CheckBox cbIsPositiveOnly;
        private System.Windows.Forms.CheckBox cbHasUserOvrd;
        private System.Windows.Forms.CheckBox cbHasRolledValue;
        private System.Windows.Forms.CheckBox cbHasInternalOvrd;
        private System.Windows.Forms.CheckBox cbHasFormNum;
        private System.Windows.Forms.CheckBox cbHasTransferredValue;
        private System.Windows.Forms.CheckBox cbIsDeprecated;
        private System.Windows.Forms.CheckBox cbIsRoundOnAssign;
        private System.Windows.Forms.CheckBox cbIsSelectable;
        private System.Windows.Forms.CheckBox cbIsRolled;
        private System.Windows.Forms.CheckBox cbIsProtected;
        private System.Windows.Forms.CheckBox cbIsSourceEstimate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox txtAliases;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbXlatFr2;
        private System.Windows.Forms.ComboBox cbXlatEng2;
        private System.Windows.Forms.ComboBox cbXlatFr1;
        private System.Windows.Forms.ComboBox cbXlatEng1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbXlatFr0;
        private System.Windows.Forms.ComboBox cbXlatEng0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbIsLinkCell;
        private System.Windows.Forms.Button btnLinkCellData;
        private System.Windows.Forms.TextBox txtCells;
    }
}