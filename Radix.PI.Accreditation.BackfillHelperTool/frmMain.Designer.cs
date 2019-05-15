namespace Radix.PI.Accreditation.BackfillHelperTool
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.piSystemPicker = new OSIsoft.AF.UI.PISystemPicker();
            this.afDatabasePicker = new OSIsoft.AF.UI.AFDatabasePicker();
            this.afTreeView1 = new OSIsoft.AF.UI.AFTreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNameFilter = new System.Windows.Forms.TextBox();
            this.btnQueue = new System.Windows.Forms.Button();
            this.chbCalcDependencies = new System.Windows.Forms.CheckBox();
            this.cbBackfillMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbEndTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbStartTime = new System.Windows.Forms.TextBox();
            this.lbSelectedAnalysis = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // piSystemPicker
            // 
            this.piSystemPicker.AccessibleDescription = "PI System Picker";
            this.piSystemPicker.AccessibleName = "PI System Picker";
            this.piSystemPicker.ConnectAutomatically = true;
            this.piSystemPicker.Cursor = System.Windows.Forms.Cursors.Default;
            this.piSystemPicker.Location = new System.Drawing.Point(13, 13);
            this.piSystemPicker.LoginPromptSetting = OSIsoft.AF.UI.PISystemPicker.LoginPromptSettingOptions.Default;
            this.piSystemPicker.Name = "piSystemPicker";
            this.piSystemPicker.ShowBegin = false;
            this.piSystemPicker.ShowDelete = false;
            this.piSystemPicker.ShowEnd = false;
            this.piSystemPicker.ShowFind = false;
            this.piSystemPicker.ShowNavigation = false;
            this.piSystemPicker.ShowNew = false;
            this.piSystemPicker.ShowNext = false;
            this.piSystemPicker.ShowPrevious = false;
            this.piSystemPicker.Size = new System.Drawing.Size(292, 22);
            this.piSystemPicker.TabIndex = 0;
            this.piSystemPicker.ConnectionChange += new OSIsoft.AF.UI.ConnectionChangeEventHandler(this.piSystemPicker_ConnectionChange);
            // 
            // afDatabasePicker
            // 
            this.afDatabasePicker.AccessibleDescription = "Database Picker";
            this.afDatabasePicker.AccessibleName = "Database Picker";
            this.afDatabasePicker.Location = new System.Drawing.Point(13, 42);
            this.afDatabasePicker.Name = "afDatabasePicker";
            this.afDatabasePicker.ShowBegin = false;
            this.afDatabasePicker.ShowDelete = false;
            this.afDatabasePicker.ShowEnd = false;
            this.afDatabasePicker.ShowFind = false;
            this.afDatabasePicker.ShowNavigation = false;
            this.afDatabasePicker.ShowNew = false;
            this.afDatabasePicker.ShowNext = false;
            this.afDatabasePicker.ShowPrevious = false;
            this.afDatabasePicker.Size = new System.Drawing.Size(292, 22);
            this.afDatabasePicker.TabIndex = 1;
            this.afDatabasePicker.SelectionChange += new OSIsoft.AF.UI.SelectionChangeEventHandler(this.afDatabasePicker_SelectionChange);
            // 
            // afTreeView1
            // 
            this.afTreeView1.HideSelection = false;
            this.afTreeView1.Location = new System.Drawing.Point(13, 71);
            this.afTreeView1.Name = "afTreeView1";
            this.afTreeView1.ShowNodeToolTips = true;
            this.afTreeView1.Size = new System.Drawing.Size(292, 206);
            this.afTreeView1.TabIndex = 2;
            this.afTreeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afTreeView1_AfterSelect);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNameFilter);
            this.groupBox1.Controls.Add(this.btnQueue);
            this.groupBox1.Controls.Add(this.chbCalcDependencies);
            this.groupBox1.Controls.Add(this.cbBackfillMode);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbEndTime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbStartTime);
            this.groupBox1.Location = new System.Drawing.Point(312, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 150);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backfill Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name Filter";
            // 
            // tbNameFilter
            // 
            this.tbNameFilter.Location = new System.Drawing.Point(67, 97);
            this.tbNameFilter.Name = "tbNameFilter";
            this.tbNameFilter.Size = new System.Drawing.Size(279, 20);
            this.tbNameFilter.TabIndex = 8;
            this.tbNameFilter.TextChanged += new System.EventHandler(this.tbNameFilter_TextChanged);
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(246, 121);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(100, 23);
            this.btnQueue.TabIndex = 7;
            this.btnQueue.Text = "Queue Backfill";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // chbCalcDependencies
            // 
            this.chbCalcDependencies.AutoSize = true;
            this.chbCalcDependencies.Location = new System.Drawing.Point(9, 74);
            this.chbCalcDependencies.Name = "chbCalcDependencies";
            this.chbCalcDependencies.Size = new System.Drawing.Size(142, 17);
            this.chbCalcDependencies.TabIndex = 6;
            this.chbCalcDependencies.Text = "Calculate Dependencies";
            this.chbCalcDependencies.UseVisualStyleBackColor = true;
            this.chbCalcDependencies.CheckedChanged += new System.EventHandler(this.chbCalcDependencies_CheckedChanged);
            // 
            // cbBackfillMode
            // 
            this.cbBackfillMode.FormattingEnabled = true;
            this.cbBackfillMode.Location = new System.Drawing.Point(163, 45);
            this.cbBackfillMode.Name = "cbBackfillMode";
            this.cbBackfillMode.Size = new System.Drawing.Size(183, 21);
            this.cbBackfillMode.TabIndex = 5;
            this.cbBackfillMode.SelectedIndexChanged += new System.EventHandler(this.cbBackfillMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existing Data Handler Options:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbEndTime
            // 
            this.tbEndTime.Location = new System.Drawing.Point(246, 19);
            this.tbEndTime.Name = "tbEndTime";
            this.tbEndTime.Size = new System.Drawing.Size(100, 20);
            this.tbEndTime.TabIndex = 2;
            this.tbEndTime.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Time";
            // 
            // tbStartTime
            // 
            this.tbStartTime.Location = new System.Drawing.Point(67, 19);
            this.tbStartTime.Name = "tbStartTime";
            this.tbStartTime.Size = new System.Drawing.Size(100, 20);
            this.tbStartTime.TabIndex = 0;
            this.tbStartTime.Text = "*-10d";
            // 
            // lbSelectedAnalysis
            // 
            this.lbSelectedAnalysis.Enabled = false;
            this.lbSelectedAnalysis.FormattingEnabled = true;
            this.lbSelectedAnalysis.Location = new System.Drawing.Point(312, 182);
            this.lbSelectedAnalysis.Name = "lbSelectedAnalysis";
            this.lbSelectedAnalysis.Size = new System.Drawing.Size(352, 95);
            this.lbSelectedAnalysis.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Analyses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Log:";
            // 
            // lbLog
            // 
            this.lbLog.Enabled = false;
            this.lbLog.FormattingEnabled = true;
            this.lbLog.Location = new System.Drawing.Point(12, 296);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(652, 134);
            this.lbLog.TabIndex = 11;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 436);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbLog);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbSelectedAnalysis);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.afTreeView1);
            this.Controls.Add(this.afDatabasePicker);
            this.Controls.Add(this.piSystemPicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "AF Analysis Backfill Helper";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OSIsoft.AF.UI.PISystemPicker piSystemPicker;
        private OSIsoft.AF.UI.AFDatabasePicker afDatabasePicker;
        private OSIsoft.AF.UI.AFTreeView afTreeView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbStartTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEndTime;
        private System.Windows.Forms.ComboBox cbBackfillMode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbCalcDependencies;
        private System.Windows.Forms.ListBox lbSelectedAnalysis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNameFilter;
        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbLog;
    }
}

