namespace Mockit.Forms
{
    partial class SettingForm
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
            this.settingTabControl = new System.Windows.Forms.TabControl();
            this.configTab = new System.Windows.Forms.TabPage();
            this.configTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.createBatchSizeCount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.exportBatchSizeCount = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.settingTabControl.SuspendLayout();
            this.configTab.SuspendLayout();
            this.configTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createBatchSizeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBatchSizeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTabControl
            // 
            this.settingTabControl.Controls.Add(this.configTab);
            this.settingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingTabControl.Location = new System.Drawing.Point(0, 0);
            this.settingTabControl.Margin = new System.Windows.Forms.Padding(0);
            this.settingTabControl.Name = "settingTabControl";
            this.settingTabControl.SelectedIndex = 0;
            this.settingTabControl.Size = new System.Drawing.Size(760, 369);
            this.settingTabControl.TabIndex = 0;
            // 
            // configTab
            // 
            this.configTab.Controls.Add(this.configTableLayout);
            this.configTab.Location = new System.Drawing.Point(4, 29);
            this.configTab.Name = "configTab";
            this.configTab.Padding = new System.Windows.Forms.Padding(3);
            this.configTab.Size = new System.Drawing.Size(752, 336);
            this.configTab.TabIndex = 0;
            this.configTab.Text = "Configuration";
            this.configTab.UseVisualStyleBackColor = true;
            // 
            // configTableLayout
            // 
            this.configTableLayout.ColumnCount = 2;
            this.configTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60326F));
            this.configTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.39674F));
            this.configTableLayout.Controls.Add(this.label1, 0, 0);
            this.configTableLayout.Controls.Add(this.createBatchSizeCount, 1, 0);
            this.configTableLayout.Controls.Add(this.label3, 0, 1);
            this.configTableLayout.Controls.Add(this.exportBatchSizeCount, 1, 1);
            this.configTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.configTableLayout.Location = new System.Drawing.Point(3, 3);
            this.configTableLayout.Name = "configTableLayout";
            this.configTableLayout.Padding = new System.Windows.Forms.Padding(5);
            this.configTableLayout.RowCount = 3;
            this.configTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.45018F));
            this.configTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.54981F));
            this.configTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.configTableLayout.Size = new System.Drawing.Size(746, 330);
            this.configTableLayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Batch Size";
            // 
            // createBatchSizeCount
            // 
            this.createBatchSizeCount.Location = new System.Drawing.Point(166, 8);
            this.createBatchSizeCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.createBatchSizeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.createBatchSizeCount.Name = "createBatchSizeCount";
            this.createBatchSizeCount.Size = new System.Drawing.Size(572, 26);
            this.createBatchSizeCount.TabIndex = 2;
            this.createBatchSizeCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Export Batch Size";
            // 
            // exportBatchSizeCount
            // 
            this.exportBatchSizeCount.Location = new System.Drawing.Point(166, 58);
            this.exportBatchSizeCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.exportBatchSizeCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.exportBatchSizeCount.Name = "exportBatchSizeCount";
            this.exportBatchSizeCount.Size = new System.Drawing.Size(572, 26);
            this.exportBatchSizeCount.TabIndex = 5;
            this.exportBatchSizeCount.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(20, 20);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.settingTabControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Size = new System.Drawing.Size(760, 420);
            this.splitContainer1.SplitterDistance = 369;
            this.splitContainer1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(551, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(655, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 10);
            this.Text = "Settings";
            this.settingTabControl.ResumeLayout(false);
            this.configTab.ResumeLayout(false);
            this.configTableLayout.ResumeLayout(false);
            this.configTableLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.createBatchSizeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBatchSizeCount)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTabControl;
        private System.Windows.Forms.TabPage configTab;
        private System.Windows.Forms.TableLayoutPanel configTableLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown createBatchSizeCount;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown exportBatchSizeCount;
    }
}