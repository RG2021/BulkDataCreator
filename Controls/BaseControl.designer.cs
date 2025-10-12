using Mockit.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Mockit.Controls
{
    partial class BaseControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseControl));
            this.actionGridPanel = new System.Windows.Forms.Panel();
            this.previewDataLabel = new System.Windows.Forms.Label();
            this.crmDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.fieldsListView = new System.Windows.Forms.ListView();
            this.dataGridElementHost = new System.Windows.Forms.Integration.ElementHost();
            this.metadataPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectEntity = new System.Windows.Forms.Label();
            this.labelSelectColumns = new System.Windows.Forms.Label();
            this.labelRecords = new System.Windows.Forms.Label();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.nudRecordCount = new System.Windows.Forms.NumericUpDown();
            this.selectFieldPanel = new System.Windows.Forms.Panel();
            this.selectFieldButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.importMockProfileButton = new System.Windows.Forms.Button();
            this.rightMainPanel = new System.Windows.Forms.Panel();
            this.fieldPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.mockDetailsContainer = new System.Windows.Forms.Panel();
            this.mockDetailsPanel = new System.Windows.Forms.GroupBox();
            this.expressionText1 = new System.Windows.Forms.RichTextBox();
            this.useCustomCheck = new System.Windows.Forms.CheckBox();
            this.mockSaveBtn = new System.Windows.Forms.Button();
            this.mockValidateBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.mockTypeCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expressionLbl = new System.Windows.Forms.Label();
            this.bottomMainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.previewBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.generateBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.actionGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.leftMainPanel.SuspendLayout();
            this.metadataPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).BeginInit();
            this.selectFieldPanel.SuspendLayout();
            this.rightMainPanel.SuspendLayout();
            this.mockDetailsContainer.SuspendLayout();
            this.mockDetailsPanel.SuspendLayout();
            this.bottomMainPanel.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionGridPanel
            // 
            this.actionGridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.actionGridPanel.Controls.Add(this.previewDataLabel);
            this.actionGridPanel.Controls.Add(this.crmDataGridView);
            this.actionGridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionGridPanel.Location = new System.Drawing.Point(26, 25);
            this.actionGridPanel.Name = "actionGridPanel";
            this.actionGridPanel.Size = new System.Drawing.Size(5018, 250);
            this.actionGridPanel.TabIndex = 5;
            // 
            // previewDataLabel
            // 
            this.previewDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previewDataLabel.AutoSize = true;
            this.previewDataLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.previewDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previewDataLabel.Location = new System.Drawing.Point(2437, 112);
            this.previewDataLabel.Name = "previewDataLabel";
            this.previewDataLabel.Size = new System.Drawing.Size(144, 20);
            this.previewDataLabel.TabIndex = 1;
            this.previewDataLabel.Text = "No Data to Preview";
            this.previewDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.previewDataLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // crmDataGridView
            // 
            this.crmDataGridView.AllowUserToAddRows = false;
            this.crmDataGridView.AllowUserToDeleteRows = false;
            this.crmDataGridView.AllowUserToResizeRows = false;
            this.crmDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.crmDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.crmDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.crmDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crmDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.crmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.crmDataGridView.MultiSelect = false;
            this.crmDataGridView.Name = "crmDataGridView";
            this.crmDataGridView.ReadOnly = true;
            this.crmDataGridView.RowHeadersVisible = false;
            this.crmDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.crmDataGridView.RowTemplate.Height = 28;
            this.crmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crmDataGridView.Size = new System.Drawing.Size(5016, 248);
            this.crmDataGridView.TabIndex = 0;
            this.crmDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.crmDataGridView_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.leftMainPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightMainPanel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.bottomMainPanel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 52);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(5070, 4284);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftMainPanel.AutoScroll = true;
            this.leftMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.leftMainPanel, 2);
            this.leftMainPanel.Controls.Add(this.fieldsListView);
            this.leftMainPanel.Controls.Add(this.dataGridElementHost);
            this.leftMainPanel.Controls.Add(this.metadataPanel);
            this.leftMainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftMainPanel.MinimumSize = new System.Drawing.Size(0, 600);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Padding = new System.Windows.Forms.Padding(26, 25, 26, 0);
            this.leftMainPanel.Size = new System.Drawing.Size(3295, 3984);
            this.leftMainPanel.TabIndex = 3;
            this.leftMainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftMainPanel_Paint);
            // 
            // fieldsListView
            // 
            this.fieldsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fieldsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fieldsListView.AllowColumnReorder = true;
            this.fieldsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldsListView.AutoArrange = false;
            this.fieldsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldsListView.CausesValidation = false;
            this.fieldsListView.CheckBoxes = true;
            this.fieldsListView.FullRowSelect = true;
            this.fieldsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.fieldsListView.HideSelection = false;
            this.fieldsListView.LabelWrap = false;
            this.fieldsListView.Location = new System.Drawing.Point(230, 138);
            this.fieldsListView.Name = "fieldsListView";
            this.fieldsListView.ShowItemToolTips = true;
            this.fieldsListView.Size = new System.Drawing.Size(2857, 316);
            this.fieldsListView.TabIndex = 7;
            this.fieldsListView.UseCompatibleStateImageBehavior = false;
            this.fieldsListView.View = System.Windows.Forms.View.Details;
            // 
            // dataGridElementHost
            // 
            this.dataGridElementHost.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridElementHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridElementHost.Location = new System.Drawing.Point(26, 240);
            this.dataGridElementHost.Name = "dataGridElementHost";
            this.dataGridElementHost.Size = new System.Drawing.Size(3243, 3744);
            this.dataGridElementHost.TabIndex = 10;
            this.dataGridElementHost.Text = "dataGridElementHost";
            this.dataGridElementHost.Child = null;
            // 
            // metadataPanel
            // 
            this.metadataPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metadataPanel.Controls.Add(this.tableLayoutPanel2);
            this.metadataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.metadataPanel.Location = new System.Drawing.Point(26, 25);
            this.metadataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.metadataPanel.Name = "metadataPanel";
            this.metadataPanel.Size = new System.Drawing.Size(3243, 215);
            this.metadataPanel.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelSelectEntity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSelectColumns, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRecords, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbEntities, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudRecordCount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.selectFieldPanel, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.93168F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.06832F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(3243, 215);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // labelSelectEntity
            // 
            this.labelSelectEntity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectEntity.AutoSize = true;
            this.labelSelectEntity.CausesValidation = false;
            this.labelSelectEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectEntity.Location = new System.Drawing.Point(3, 0);
            this.labelSelectEntity.Name = "labelSelectEntity";
            this.labelSelectEntity.Size = new System.Drawing.Size(181, 72);
            this.labelSelectEntity.TabIndex = 0;
            this.labelSelectEntity.Text = "Select entity:";
            // 
            // labelSelectColumns
            // 
            this.labelSelectColumns.AutoSize = true;
            this.labelSelectColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectColumns.Location = new System.Drawing.Point(3, 72);
            this.labelSelectColumns.Name = "labelSelectColumns";
            this.labelSelectColumns.Size = new System.Drawing.Size(151, 22);
            this.labelSelectColumns.TabIndex = 1;
            this.labelSelectColumns.Text = "Select columns:";
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(3, 142);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(181, 22);
            this.labelRecords.TabIndex = 2;
            this.labelRecords.Text = "Number of records:";
            // 
            // cmbEntities
            // 
            this.cmbEntities.AllowDrop = true;
            this.cmbEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEntities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbEntities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(190, 3);
            this.cmbEntities.MaxDropDownItems = 10;
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(3050, 28);
            this.cmbEntities.Sorted = true;
            this.cmbEntities.TabIndex = 3;
            this.cmbEntities.SelectionChangeCommitted += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // nudRecordCount
            // 
            this.nudRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRecordCount.Location = new System.Drawing.Point(190, 145);
            this.nudRecordCount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudRecordCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRecordCount.Name = "nudRecordCount";
            this.nudRecordCount.Size = new System.Drawing.Size(3050, 26);
            this.nudRecordCount.TabIndex = 5;
            this.nudRecordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // selectFieldPanel
            // 
            this.selectFieldPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFieldPanel.AutoSize = true;
            this.selectFieldPanel.Controls.Add(this.selectFieldButton);
            this.selectFieldPanel.Controls.Add(this.label1);
            this.selectFieldPanel.Controls.Add(this.importMockProfileButton);
            this.selectFieldPanel.Location = new System.Drawing.Point(190, 75);
            this.selectFieldPanel.Name = "selectFieldPanel";
            this.selectFieldPanel.Size = new System.Drawing.Size(3050, 30);
            this.selectFieldPanel.TabIndex = 9;
            // 
            // selectFieldButton
            // 
            this.selectFieldButton.AutoSize = true;
            this.selectFieldButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.selectFieldButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFieldButton.Location = new System.Drawing.Point(0, 0);
            this.selectFieldButton.Margin = new System.Windows.Forms.Padding(1);
            this.selectFieldButton.Name = "selectFieldButton";
            this.selectFieldButton.Size = new System.Drawing.Size(2873, 30);
            this.selectFieldButton.TabIndex = 8;
            this.selectFieldButton.Text = "Select Fields";
            this.selectFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFieldButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(2873, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "or";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // importMockProfileButton
            // 
            this.importMockProfileButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.importMockProfileButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.importMockProfileButton.Location = new System.Drawing.Point(2906, 0);
            this.importMockProfileButton.Margin = new System.Windows.Forms.Padding(1);
            this.importMockProfileButton.Name = "importMockProfileButton";
            this.importMockProfileButton.Size = new System.Drawing.Size(144, 30);
            this.importMockProfileButton.TabIndex = 11;
            this.importMockProfileButton.Text = "Import Profile";
            this.importMockProfileButton.UseVisualStyleBackColor = true;
            // 
            // rightMainPanel
            // 
            this.rightMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightMainPanel.AutoScroll = true;
            this.rightMainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightMainPanel.Controls.Add(this.fieldPropertyGrid);
            this.rightMainPanel.Controls.Add(this.mockDetailsContainer);
            this.rightMainPanel.Location = new System.Drawing.Point(3295, 0);
            this.rightMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightMainPanel.MinimumSize = new System.Drawing.Size(0, 600);
            this.rightMainPanel.Name = "rightMainPanel";
            this.rightMainPanel.Padding = new System.Windows.Forms.Padding(26, 25, 26, 26);
            this.rightMainPanel.Size = new System.Drawing.Size(1775, 3984);
            this.rightMainPanel.TabIndex = 4;
            // 
            // fieldPropertyGrid
            // 
            this.fieldPropertyGrid.DisabledItemForeColor = System.Drawing.SystemColors.ControlText;
            this.fieldPropertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldPropertyGrid.Location = new System.Drawing.Point(26, 25);
            this.fieldPropertyGrid.Margin = new System.Windows.Forms.Padding(0);
            this.fieldPropertyGrid.MinimumSize = new System.Drawing.Size(0, 250);
            this.fieldPropertyGrid.Name = "fieldPropertyGrid";
            this.fieldPropertyGrid.Size = new System.Drawing.Size(1723, 3599);
            this.fieldPropertyGrid.TabIndex = 9;
            // 
            // mockDetailsContainer
            // 
            this.mockDetailsContainer.Controls.Add(this.mockDetailsPanel);
            this.mockDetailsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mockDetailsContainer.Location = new System.Drawing.Point(26, 3624);
            this.mockDetailsContainer.Name = "mockDetailsContainer";
            this.mockDetailsContainer.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.mockDetailsContainer.Size = new System.Drawing.Size(1723, 334);
            this.mockDetailsContainer.TabIndex = 13;
            // 
            // mockDetailsPanel
            // 
            this.mockDetailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mockDetailsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mockDetailsPanel.Controls.Add(this.expressionText1);
            this.mockDetailsPanel.Controls.Add(this.useCustomCheck);
            this.mockDetailsPanel.Controls.Add(this.mockSaveBtn);
            this.mockDetailsPanel.Controls.Add(this.mockValidateBtn);
            this.mockDetailsPanel.Controls.Add(this.label6);
            this.mockDetailsPanel.Controls.Add(this.resultText);
            this.mockDetailsPanel.Controls.Add(this.mockTypeCombo);
            this.mockDetailsPanel.Controls.Add(this.label8);
            this.mockDetailsPanel.Controls.Add(this.expressionLbl);
            this.mockDetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mockDetailsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mockDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockDetailsPanel.Location = new System.Drawing.Point(0, 20);
            this.mockDetailsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mockDetailsPanel.MinimumSize = new System.Drawing.Size(0, 300);
            this.mockDetailsPanel.Name = "mockDetailsPanel";
            this.mockDetailsPanel.Padding = new System.Windows.Forms.Padding(0);
            this.mockDetailsPanel.Size = new System.Drawing.Size(1723, 314);
            this.mockDetailsPanel.TabIndex = 8;
            this.mockDetailsPanel.TabStop = false;
            this.mockDetailsPanel.Text = "Mock Details";
            // 
            // expressionText1
            // 
            this.expressionText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expressionText1.BackColor = System.Drawing.Color.White;
            this.expressionText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expressionText1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText1.Location = new System.Drawing.Point(104, 89);
            this.expressionText1.MinimumSize = new System.Drawing.Size(4, 100);
            this.expressionText1.Name = "expressionText1";
            this.expressionText1.ReadOnly = true;
            this.expressionText1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.expressionText1.Size = new System.Drawing.Size(1583, 100);
            this.expressionText1.TabIndex = 12;
            this.expressionText1.Text = "";
            this.expressionText1.TextChanged += new System.EventHandler(this.expressionText1_TextChanged);
            // 
            // useCustomCheck
            // 
            this.useCustomCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useCustomCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useCustomCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomCheck.Location = new System.Drawing.Point(1552, 43);
            this.useCustomCheck.Name = "useCustomCheck";
            this.useCustomCheck.Size = new System.Drawing.Size(135, 25);
            this.useCustomCheck.TabIndex = 6;
            this.useCustomCheck.Text = "Use Custom";
            this.useCustomCheck.UseVisualStyleBackColor = true;
            // 
            // mockSaveBtn
            // 
            this.mockSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mockSaveBtn.AutoSize = true;
            this.mockSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockSaveBtn.Location = new System.Drawing.Point(1587, 254);
            this.mockSaveBtn.MaximumSize = new System.Drawing.Size(100, 40);
            this.mockSaveBtn.Name = "mockSaveBtn";
            this.mockSaveBtn.Size = new System.Drawing.Size(100, 33);
            this.mockSaveBtn.TabIndex = 11;
            this.mockSaveBtn.Text = "Save";
            this.mockSaveBtn.UseVisualStyleBackColor = true;
            // 
            // mockValidateBtn
            // 
            this.mockValidateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mockValidateBtn.AutoSize = true;
            this.mockValidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockValidateBtn.Location = new System.Drawing.Point(1587, 215);
            this.mockValidateBtn.MaximumSize = new System.Drawing.Size(100, 40);
            this.mockValidateBtn.Name = "mockValidateBtn";
            this.mockValidateBtn.Size = new System.Drawing.Size(100, 33);
            this.mockValidateBtn.TabIndex = 10;
            this.mockValidateBtn.Text = "Validate";
            this.mockValidateBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mock type";
            // 
            // resultText
            // 
            this.resultText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultText.AutoCompleteCustomSource.AddRange(new string[] {
            "LOOKUP",
            "FULLNAME",
            "BOOLEAN"});
            this.resultText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.resultText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.resultText.BackColor = System.Drawing.Color.White;
            this.resultText.CausesValidation = false;
            this.resultText.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(106, 216);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(1475, 71);
            this.resultText.TabIndex = 9;
            // 
            // mockTypeCombo
            // 
            this.mockTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mockTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mockTypeCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockTypeCombo.FormattingEnabled = true;
            this.mockTypeCombo.Location = new System.Drawing.Point(106, 40);
            this.mockTypeCombo.Name = "mockTypeCombo";
            this.mockTypeCombo.Size = new System.Drawing.Size(1432, 28);
            this.mockTypeCombo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result";
            // 
            // expressionLbl
            // 
            this.expressionLbl.AutoSize = true;
            this.expressionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionLbl.Location = new System.Drawing.Point(10, 94);
            this.expressionLbl.Name = "expressionLbl";
            this.expressionLbl.Size = new System.Drawing.Size(87, 20);
            this.expressionLbl.TabIndex = 5;
            this.expressionLbl.Text = "Expression";
            // 
            // bottomMainPanel
            // 
            this.bottomMainPanel.AutoScroll = true;
            this.bottomMainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.bottomMainPanel, 3);
            this.bottomMainPanel.Controls.Add(this.actionGridPanel);
            this.bottomMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomMainPanel.Location = new System.Drawing.Point(0, 3984);
            this.bottomMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomMainPanel.Name = "bottomMainPanel";
            this.bottomMainPanel.Padding = new System.Windows.Forms.Padding(26, 25, 26, 25);
            this.bottomMainPanel.Size = new System.Drawing.Size(5070, 300);
            this.bottomMainPanel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.previewBtn,
            this.toolStripSeparator2,
            this.generateBtn,
            this.toolStripLabel2,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.toolStripSeparator5,
            this.toolStripLabel4,
            this.toolStripSeparator4,
            this.toolStripLabel5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(5070, 52);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Mockit.Properties.Resources.mockit_logo_small;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(221, 46);
            this.toolStripLabel1.Text = "BULK DATA CREATOR";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // previewBtn
            // 
            this.previewBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBtn.Image = global::Mockit.Properties.Resources.icons8_search_48;
            this.previewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(142, 47);
            this.previewBtn.Text = "Preview Data";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Image = global::Mockit.Properties.Resources.icons8_setting_48;
            this.generateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(152, 47);
            this.generateBtn.Text = "Generate Data";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Image = global::Mockit.Properties.Resources.icons8_linkedin_48;
            this.toolStripLabel2.IsLink = true;
            this.toolStripLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 2, 6, 3);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(127, 47);
            this.toolStripLabel2.Text = "Rohan Goel";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Image = global::Mockit.Properties.Resources.icons8_mailbox_48;
            this.toolStripLabel3.IsLink = true;
            this.toolStripLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(111, 47);
            this.toolStripLabel3.Text = "Feedback";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.IsLink = true;
            this.toolStripLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(134, 47);
            this.toolStripLabel4.Text = "Report Issue";
            this.toolStripLabel4.VisitedLinkColor = System.Drawing.Color.Blue;
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 52);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripLabel5.Image = global::Mockit.Properties.Resources.icons8_scroll_48;
            this.toolStripLabel5.IsLink = true;
            this.toolStripLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(159, 47);
            this.toolStripLabel5.Text = "Documentation";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(0, 700);
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(0, 600);
            this.Name = "BaseControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(5070, 4336);
            this.ToolName = "Bulk Data Creator";
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.actionGridPanel.ResumeLayout(false);
            this.actionGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.leftMainPanel.ResumeLayout(false);
            this.metadataPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).EndInit();
            this.selectFieldPanel.ResumeLayout(false);
            this.selectFieldPanel.PerformLayout();
            this.rightMainPanel.ResumeLayout(false);
            this.mockDetailsContainer.ResumeLayout(false);
            this.mockDetailsPanel.ResumeLayout(false);
            this.mockDetailsPanel.PerformLayout();
            this.bottomMainPanel.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel actionGridPanel;
        private System.Windows.Forms.DataGridView crmDataGridView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton previewBtn;
        private System.Windows.Forms.ToolStripButton generateBtn;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Label previewDataLabel;
        private System.Windows.Forms.Panel bottomMainPanel;
        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.ListView fieldsListView;
        private System.Windows.Forms.Panel metadataPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelSelectEntity;
        private System.Windows.Forms.Label labelSelectColumns;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.NumericUpDown nudRecordCount;
        private System.Windows.Forms.Button selectFieldButton;
        private System.Windows.Forms.Panel rightMainPanel;
        private System.Windows.Forms.RichTextBox expressionText1;
        private System.Windows.Forms.Button mockSaveBtn;
        private System.Windows.Forms.Button mockValidateBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox useCustomCheck;
        private System.Windows.Forms.Label expressionLbl;
        private System.Windows.Forms.ComboBox mockTypeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox mockDetailsPanel;
        private System.Windows.Forms.Integration.ElementHost dataGridElementHost;
        private System.Windows.Forms.PropertyGrid fieldPropertyGrid;
        private System.Windows.Forms.Button importMockProfileButton;
        private System.Windows.Forms.Panel selectFieldPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mockDetailsContainer;
    }
}
