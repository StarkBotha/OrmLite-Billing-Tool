
namespace BillingTool
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteBillings = new System.Windows.Forms.Button();
            this.chkMandates = new System.Windows.Forms.CheckBox();
            this.chkInstallments = new System.Windows.Forms.CheckBox();
            this.btnDoBillingRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtCountBilled = new System.Windows.Forms.TextBox();
            this.btnCountBilled = new System.Windows.Forms.Button();
            this.btnGetMerchants = new System.Windows.Forms.Button();
            this.lstMerchants = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGetMBPs = new System.Windows.Forms.Button();
            this.lstMBPs = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGetProducts = new System.Windows.Forms.Button();
            this.btnGetMerchantBranches = new System.Windows.Forms.Button();
            this.lstMerchantBranches = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetEligibleCount = new System.Windows.Forms.Button();
            this.txtEligibleCount = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.txtLotSize = new System.Windows.Forms.TextBox();
            this.txtLotRuns = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1477, 815);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtLotRuns);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txtLotSize);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnDeleteBillings);
            this.tabPage1.Controls.Add(this.chkMandates);
            this.tabPage1.Controls.Add(this.chkInstallments);
            this.tabPage1.Controls.Add(this.btnDoBillingRun);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rtbOutput);
            this.tabPage1.Controls.Add(this.txtCountBilled);
            this.tabPage1.Controls.Add(this.btnCountBilled);
            this.tabPage1.Controls.Add(this.btnGetMerchants);
            this.tabPage1.Controls.Add(this.lstMerchants);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnGetMBPs);
            this.tabPage1.Controls.Add(this.lstMBPs);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.btnGetProducts);
            this.tabPage1.Controls.Add(this.btnGetMerchantBranches);
            this.tabPage1.Controls.Add(this.lstMerchantBranches);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lstProducts);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGetEligibleCount);
            this.tabPage1.Controls.Add(this.txtEligibleCount);
            this.tabPage1.Controls.Add(this.cmbMonth);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cmbYear);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1469, 787);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBillings
            // 
            this.btnDeleteBillings.Location = new System.Drawing.Point(670, 12);
            this.btnDeleteBillings.Name = "btnDeleteBillings";
            this.btnDeleteBillings.Size = new System.Drawing.Size(123, 23);
            this.btnDeleteBillings.TabIndex = 27;
            this.btnDeleteBillings.Text = "Delete All Billings";
            this.btnDeleteBillings.UseVisualStyleBackColor = true;
            this.btnDeleteBillings.Click += new System.EventHandler(this.btnDeleteBillings_Click);
            // 
            // chkMandates
            // 
            this.chkMandates.AutoSize = true;
            this.chkMandates.Location = new System.Drawing.Point(1065, 74);
            this.chkMandates.Name = "chkMandates";
            this.chkMandates.Size = new System.Drawing.Size(78, 19);
            this.chkMandates.TabIndex = 26;
            this.chkMandates.Text = "Mandates";
            this.chkMandates.UseVisualStyleBackColor = true;
            // 
            // chkInstallments
            // 
            this.chkInstallments.AutoSize = true;
            this.chkInstallments.Location = new System.Drawing.Point(969, 73);
            this.chkInstallments.Name = "chkInstallments";
            this.chkInstallments.Size = new System.Drawing.Size(90, 19);
            this.chkInstallments.TabIndex = 25;
            this.chkInstallments.Text = "Installments";
            this.chkInstallments.UseVisualStyleBackColor = true;
            // 
            // btnDoBillingRun
            // 
            this.btnDoBillingRun.Location = new System.Drawing.Point(840, 70);
            this.btnDoBillingRun.Name = "btnDoBillingRun";
            this.btnDoBillingRun.Size = new System.Drawing.Size(123, 23);
            this.btnDoBillingRun.TabIndex = 24;
            this.btnDoBillingRun.Text = "Do Billing Run";
            this.btnDoBillingRun.UseVisualStyleBackColor = true;
            this.btnDoBillingRun.Click += new System.EventHandler(this.btnDoBillingRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(821, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Output";
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(821, 495);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(642, 283);
            this.rtbOutput.TabIndex = 22;
            this.rtbOutput.Text = "";
            // 
            // txtCountBilled
            // 
            this.txtCountBilled.Enabled = false;
            this.txtCountBilled.Location = new System.Drawing.Point(969, 12);
            this.txtCountBilled.Name = "txtCountBilled";
            this.txtCountBilled.Size = new System.Drawing.Size(27, 23);
            this.txtCountBilled.TabIndex = 21;
            // 
            // btnCountBilled
            // 
            this.btnCountBilled.Location = new System.Drawing.Point(840, 12);
            this.btnCountBilled.Name = "btnCountBilled";
            this.btnCountBilled.Size = new System.Drawing.Size(123, 23);
            this.btnCountBilled.TabIndex = 20;
            this.btnCountBilled.Text = "Count Billed";
            this.btnCountBilled.UseVisualStyleBackColor = true;
            this.btnCountBilled.Click += new System.EventHandler(this.btnCountBilled_Click);
            // 
            // btnGetMerchants
            // 
            this.btnGetMerchants.Location = new System.Drawing.Point(105, 103);
            this.btnGetMerchants.Name = "btnGetMerchants";
            this.btnGetMerchants.Size = new System.Drawing.Size(92, 23);
            this.btnGetMerchants.TabIndex = 19;
            this.btnGetMerchants.Text = "Get Merchants";
            this.btnGetMerchants.UseVisualStyleBackColor = true;
            this.btnGetMerchants.Click += new System.EventHandler(this.btnGetMerchants_Click);
            // 
            // lstMerchants
            // 
            this.lstMerchants.FormattingEnabled = true;
            this.lstMerchants.ItemHeight = 15;
            this.lstMerchants.Location = new System.Drawing.Point(10, 129);
            this.lstMerchants.Name = "lstMerchants";
            this.lstMerchants.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMerchants.Size = new System.Drawing.Size(187, 649);
            this.lstMerchants.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Merchants";
            // 
            // btnGetMBPs
            // 
            this.btnGetMBPs.Location = new System.Drawing.Point(514, 103);
            this.btnGetMBPs.Name = "btnGetMBPs";
            this.btnGetMBPs.Size = new System.Drawing.Size(98, 23);
            this.btnGetMBPs.TabIndex = 16;
            this.btnGetMBPs.Text = "Get MBPs";
            this.btnGetMBPs.UseVisualStyleBackColor = true;
            this.btnGetMBPs.Click += new System.EventHandler(this.btnGetMBPs_Click);
            // 
            // lstMBPs
            // 
            this.lstMBPs.FormattingEnabled = true;
            this.lstMBPs.ItemHeight = 15;
            this.lstMBPs.Location = new System.Drawing.Point(425, 129);
            this.lstMBPs.Name = "lstMBPs";
            this.lstMBPs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMBPs.Size = new System.Drawing.Size(187, 649);
            this.lstMBPs.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "MBPs";
            // 
            // btnGetProducts
            // 
            this.btnGetProducts.Location = new System.Drawing.Point(726, 103);
            this.btnGetProducts.Name = "btnGetProducts";
            this.btnGetProducts.Size = new System.Drawing.Size(89, 23);
            this.btnGetProducts.TabIndex = 13;
            this.btnGetProducts.Text = "Get Products";
            this.btnGetProducts.UseVisualStyleBackColor = true;
            this.btnGetProducts.Click += new System.EventHandler(this.btnGetProducts_Click);
            // 
            // btnGetMerchantBranches
            // 
            this.btnGetMerchantBranches.Location = new System.Drawing.Point(216, 84);
            this.btnGetMerchantBranches.Name = "btnGetMerchantBranches";
            this.btnGetMerchantBranches.Size = new System.Drawing.Size(146, 23);
            this.btnGetMerchantBranches.TabIndex = 12;
            this.btnGetMerchantBranches.Text = "Get Merchant Branches";
            this.btnGetMerchantBranches.UseVisualStyleBackColor = true;
            this.btnGetMerchantBranches.Click += new System.EventHandler(this.btnGetMerchantBranches_Click);
            // 
            // lstMerchantBranches
            // 
            this.lstMerchantBranches.FormattingEnabled = true;
            this.lstMerchantBranches.ItemHeight = 15;
            this.lstMerchantBranches.Location = new System.Drawing.Point(216, 129);
            this.lstMerchantBranches.Name = "lstMerchantBranches";
            this.lstMerchantBranches.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstMerchantBranches.Size = new System.Drawing.Size(187, 649);
            this.lstMerchantBranches.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Merchant Branches";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(628, 129);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstProducts.Size = new System.Drawing.Size(187, 649);
            this.lstProducts.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(628, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Products";
            // 
            // btnGetEligibleCount
            // 
            this.btnGetEligibleCount.Location = new System.Drawing.Point(840, 41);
            this.btnGetEligibleCount.Name = "btnGetEligibleCount";
            this.btnGetEligibleCount.Size = new System.Drawing.Size(123, 23);
            this.btnGetEligibleCount.TabIndex = 7;
            this.btnGetEligibleCount.Text = "Get Eligible Count";
            this.btnGetEligibleCount.UseVisualStyleBackColor = true;
            this.btnGetEligibleCount.Click += new System.EventHandler(this.btnGetEligibleCount_Click);
            // 
            // txtEligibleCount
            // 
            this.txtEligibleCount.Enabled = false;
            this.txtEligibleCount.Location = new System.Drawing.Point(969, 41);
            this.txtEligibleCount.Name = "txtEligibleCount";
            this.txtEligibleCount.Size = new System.Drawing.Size(27, 23);
            this.txtEligibleCount.TabIndex = 6;
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "1 - January",
            "2 - February",
            "3 - March",
            "4 - April",
            "5 - May",
            "6 - June",
            "7 - July",
            "8 - August",
            "9 - September",
            "10 - October",
            "11 - November",
            "12 - December"});
            this.cmbMonth.Location = new System.Drawing.Point(59, 59);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 23);
            this.cmbMonth.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Month";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023"});
            this.cmbYear.Location = new System.Drawing.Point(59, 21);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 23);
            this.cmbYear.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Billing Period";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1469, 787);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1149, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 28;
            this.label9.Text = "Lot Size:";
            // 
            // txtLotSize
            // 
            this.txtLotSize.Location = new System.Drawing.Point(1205, 74);
            this.txtLotSize.Name = "txtLotSize";
            this.txtLotSize.Size = new System.Drawing.Size(74, 23);
            this.txtLotSize.TabIndex = 29;
            this.txtLotSize.Text = "1000";
            // 
            // txtLotRuns
            // 
            this.txtLotRuns.Location = new System.Drawing.Point(1329, 74);
            this.txtLotRuns.Name = "txtLotRuns";
            this.txtLotRuns.Size = new System.Drawing.Size(74, 23);
            this.txtLotRuns.TabIndex = 31;
            this.txtLotRuns.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1285, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 30;
            this.label10.Text = "Runs:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 839);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Billing Tool";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEligibleCount;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetEligibleCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.ListBox lstMerchantBranches;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGetMBPs;
        private System.Windows.Forms.ListBox lstMBPs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGetProducts;
        private System.Windows.Forms.Button btnGetMerchantBranches;
        private System.Windows.Forms.Button btnGetMerchants;
        private System.Windows.Forms.ListBox lstMerchants;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCountBilled;
        private System.Windows.Forms.TextBox txtCountBilled;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnDoBillingRun;
        private System.Windows.Forms.CheckBox chkMandates;
        private System.Windows.Forms.CheckBox chkInstallments;
        private System.Windows.Forms.Button btnDeleteBillings;
        private System.Windows.Forms.TextBox txtLotSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtLotRuns;
        private System.Windows.Forms.Label label10;
    }
}

