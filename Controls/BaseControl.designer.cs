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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseControl));
            this.labelRecords = new System.Windows.Forms.Label();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.nudRecordCount = new System.Windows.Forms.NumericUpDown();
            this.labelSelectColumns = new System.Windows.Forms.Label();
            this.labelSelectEntity = new System.Windows.Forms.Label();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.colFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldLogicalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.fieldsListView = new System.Windows.Forms.ListView();
            this.metadataPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.selectFieldButton = new System.Windows.Forms.Button();
            this.rightMainPanel = new System.Windows.Forms.Panel();
            this.fieldDetailsPanel = new System.Windows.Forms.Panel();
            this.fieldDetailsGrid = new System.Windows.Forms.DataGridView();
            this.Label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.mockDetailsPanel = new System.Windows.Forms.Panel();
            this.expressionText1 = new System.Windows.Forms.RichTextBox();
            this.mockSaveBtn = new System.Windows.Forms.Button();
            this.mockValidateBtn = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.useCustomCheck = new System.Windows.Forms.CheckBox();
            this.expressionLbl = new System.Windows.Forms.Label();
            this.mockTypeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.actionGridPanel = new System.Windows.Forms.Panel();
            this.previewDataLabel = new System.Windows.Forms.Label();
            this.crmDataGridView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.gridPanel.SuspendLayout();
            this.leftMainPanel.SuspendLayout();
            this.metadataPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.rightMainPanel.SuspendLayout();
            this.fieldDetailsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDetailsGrid)).BeginInit();
            this.mockDetailsPanel.SuspendLayout();
            this.actionGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(3, 153);
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
            this.cmbEntities.Size = new System.Drawing.Size(1003, 28);
            this.cmbEntities.Sorted = true;
            this.cmbEntities.TabIndex = 3;
            this.cmbEntities.SelectionChangeCommitted += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // nudRecordCount
            // 
            this.nudRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudRecordCount.Location = new System.Drawing.Point(190, 156);
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
            this.nudRecordCount.Size = new System.Drawing.Size(1003, 26);
            this.nudRecordCount.TabIndex = 5;
            this.nudRecordCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // labelSelectColumns
            // 
            this.labelSelectColumns.AutoSize = true;
            this.labelSelectColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectColumns.Location = new System.Drawing.Point(3, 78);
            this.labelSelectColumns.Name = "labelSelectColumns";
            this.labelSelectColumns.Size = new System.Drawing.Size(151, 22);
            this.labelSelectColumns.TabIndex = 1;
            this.labelSelectColumns.Text = "Select columns:";
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
            this.labelSelectEntity.Size = new System.Drawing.Size(181, 78);
            this.labelSelectEntity.TabIndex = 0;
            this.labelSelectEntity.Text = "Select entity:";
            // 
            // gridColumns
            // 
            this.gridColumns.AllowUserToAddRows = false;
            this.gridColumns.AllowUserToDeleteRows = false;
            this.gridColumns.AllowUserToResizeRows = false;
            this.gridColumns.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridColumns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.gridColumns.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldName,
            this.FieldLogicalName,
            this.colFieldType,
            this.colMockType,
            this.Action});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridColumns.DefaultCellStyle = dataGridViewCellStyle9;
            this.gridColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridColumns.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridColumns.Location = new System.Drawing.Point(0, 0);
            this.gridColumns.MultiSelect = false;
            this.gridColumns.Name = "gridColumns";
            this.gridColumns.ReadOnly = true;
            this.gridColumns.RowHeadersVisible = false;
            this.gridColumns.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridColumns.RowTemplate.Height = 28;
            this.gridColumns.RowTemplate.ReadOnly = true;
            this.gridColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridColumns.Size = new System.Drawing.Size(1196, 910);
            this.gridColumns.TabIndex = 1;
            this.gridColumns.SelectionChanged += new System.EventHandler(this.gridColumns_SelectionChanged);
            // 
            // colFieldName
            // 
            this.colFieldName.DataPropertyName = "FieldName";
            this.colFieldName.HeaderText = "Field Name";
            this.colFieldName.MinimumWidth = 125;
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.ReadOnly = true;
            this.colFieldName.Width = 125;
            // 
            // FieldLogicalName
            // 
            this.FieldLogicalName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.FieldLogicalName.DataPropertyName = "FieldLogicalName";
            this.FieldLogicalName.HeaderText = "Logical Name";
            this.FieldLogicalName.MinimumWidth = 125;
            this.FieldLogicalName.Name = "FieldLogicalName";
            this.FieldLogicalName.ReadOnly = true;
            this.FieldLogicalName.Width = 125;
            // 
            // colFieldType
            // 
            this.colFieldType.DataPropertyName = "FieldType";
            this.colFieldType.HeaderText = "CRM Data Type";
            this.colFieldType.MinimumWidth = 125;
            this.colFieldType.Name = "colFieldType";
            this.colFieldType.ReadOnly = true;
            this.colFieldType.Width = 125;
            // 
            // colMockType
            // 
            this.colMockType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMockType.DataPropertyName = "MockType";
            this.colMockType.HeaderText = "Mock Type";
            this.colMockType.MinimumWidth = 90;
            this.colMockType.Name = "colMockType";
            this.colMockType.ReadOnly = true;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.DataPropertyName = "actionMockBtn";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.DefaultCellStyle = dataGridViewCellStyle8;
            this.Action.HeaderText = "Action";
            this.Action.MinimumWidth = 50;
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Action.Text = "Mock";
            this.Action.UseColumnTextForButtonValue = true;
            this.Action.Width = 80;
            // 
            // gridPanel
            // 
            this.gridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanel.AutoScroll = true;
            this.gridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gridPanel.Controls.Add(this.gridColumns);
            this.gridPanel.Location = new System.Drawing.Point(25, 284);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1196, 910);
            this.gridPanel.TabIndex = 2;
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftMainPanel.AutoScroll = true;
            this.leftMainPanel.AutoSize = true;
            this.leftMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftMainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftMainPanel.Controls.Add(this.fieldsListView);
            this.leftMainPanel.Controls.Add(this.gridPanel);
            this.leftMainPanel.Controls.Add(this.metadataPanel);
            this.leftMainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMainPanel.Location = new System.Drawing.Point(0, 0);
            this.leftMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Padding = new System.Windows.Forms.Padding(25);
            this.leftMainPanel.Size = new System.Drawing.Size(1239, 1222);
            this.leftMainPanel.TabIndex = 3;
            // 
            // fieldsListView
            // 
            this.fieldsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fieldsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.fieldsListView.AllowColumnReorder = true;
            this.fieldsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldsListView.AutoArrange = false;
            this.fieldsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldsListView.CheckBoxes = true;
            this.fieldsListView.FullRowSelect = true;
            this.fieldsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.fieldsListView.HideSelection = false;
            this.fieldsListView.LabelWrap = false;
            this.fieldsListView.Location = new System.Drawing.Point(233, 149);
            this.fieldsListView.Name = "fieldsListView";
            this.fieldsListView.ShowItemToolTips = true;
            this.fieldsListView.Size = new System.Drawing.Size(985, 279);
            this.fieldsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.fieldsListView.TabIndex = 7;
            this.fieldsListView.UseCompatibleStateImageBehavior = false;
            this.fieldsListView.View = System.Windows.Forms.View.Details;
            this.fieldsListView.Visible = false;
            // 
            // metadataPanel
            // 
            this.metadataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metadataPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metadataPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metadataPanel.Controls.Add(this.tableLayoutPanel2);
            this.metadataPanel.Location = new System.Drawing.Point(25, 20);
            this.metadataPanel.Name = "metadataPanel";
            this.metadataPanel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.metadataPanel.Size = new System.Drawing.Size(1196, 237);
            this.metadataPanel.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelSelectEntity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSelectColumns, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelRecords, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbEntities, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudRecordCount, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.selectFieldButton, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.93168F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.06832F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1196, 227);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // selectFieldButton
            // 
            this.selectFieldButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectFieldButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectFieldButton.Location = new System.Drawing.Point(190, 81);
            this.selectFieldButton.Name = "selectFieldButton";
            this.selectFieldButton.Size = new System.Drawing.Size(1003, 37);
            this.selectFieldButton.TabIndex = 8;
            this.selectFieldButton.Text = "Select Fields";
            this.selectFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFieldButton.UseVisualStyleBackColor = true;
            // 
            // rightMainPanel
            // 
            this.rightMainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightMainPanel.AutoSize = true;
            this.rightMainPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.rightMainPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rightMainPanel.Controls.Add(this.fieldDetailsPanel);
            this.rightMainPanel.Controls.Add(this.mockDetailsPanel);
            this.rightMainPanel.Controls.Add(this.actionGridPanel);
            this.rightMainPanel.Location = new System.Drawing.Point(1239, 0);
            this.rightMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightMainPanel.Name = "rightMainPanel";
            this.rightMainPanel.Padding = new System.Windows.Forms.Padding(25);
            this.rightMainPanel.Size = new System.Drawing.Size(1015, 1222);
            this.rightMainPanel.TabIndex = 4;
            // 
            // fieldDetailsPanel
            // 
            this.fieldDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fieldDetailsPanel.AutoScroll = true;
            this.fieldDetailsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fieldDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldDetailsPanel.Controls.Add(this.fieldDetailsGrid);
            this.fieldDetailsPanel.Controls.Add(this.label4);
            this.fieldDetailsPanel.Location = new System.Drawing.Point(25, 19);
            this.fieldDetailsPanel.Name = "fieldDetailsPanel";
            this.fieldDetailsPanel.Size = new System.Drawing.Size(962, 238);
            this.fieldDetailsPanel.TabIndex = 7;
            // 
            // fieldDetailsGrid
            // 
            this.fieldDetailsGrid.AllowUserToAddRows = false;
            this.fieldDetailsGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldDetailsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.fieldDetailsGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.fieldDetailsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fieldDetailsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.fieldDetailsGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.fieldDetailsGrid.ColumnHeadersHeight = 34;
            this.fieldDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.fieldDetailsGrid.ColumnHeadersVisible = false;
            this.fieldDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Label,
            this.Value});
            this.fieldDetailsGrid.Cursor = System.Windows.Forms.Cursors.Default;
            this.fieldDetailsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldDetailsGrid.Location = new System.Drawing.Point(0, 40);
            this.fieldDetailsGrid.MultiSelect = false;
            this.fieldDetailsGrid.Name = "fieldDetailsGrid";
            this.fieldDetailsGrid.ReadOnly = true;
            this.fieldDetailsGrid.RowHeadersVisible = false;
            this.fieldDetailsGrid.RowHeadersWidth = 62;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldDetailsGrid.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.fieldDetailsGrid.RowTemplate.Height = 28;
            this.fieldDetailsGrid.RowTemplate.ReadOnly = true;
            this.fieldDetailsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.fieldDetailsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.fieldDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.fieldDetailsGrid.Size = new System.Drawing.Size(960, 196);
            this.fieldDetailsGrid.TabIndex = 6;
            // 
            // Label
            // 
            this.Label.DataPropertyName = "Label";
            this.Label.HeaderText = "Label";
            this.Label.MinimumWidth = 8;
            this.Label.Name = "Label";
            this.Label.ReadOnly = true;
            this.Label.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Label.Width = 80;
            // 
            // Value
            // 
            this.Value.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Value.DataPropertyName = "Value";
            this.Value.HeaderText = "Value";
            this.Value.MinimumWidth = 8;
            this.Value.Name = "Value";
            this.Value.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.MinimumSize = new System.Drawing.Size(1000, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1000, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Column Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mockDetailsPanel
            // 
            this.mockDetailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mockDetailsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mockDetailsPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mockDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mockDetailsPanel.Controls.Add(this.expressionText1);
            this.mockDetailsPanel.Controls.Add(this.mockSaveBtn);
            this.mockDetailsPanel.Controls.Add(this.mockValidateBtn);
            this.mockDetailsPanel.Controls.Add(this.resultText);
            this.mockDetailsPanel.Controls.Add(this.label8);
            this.mockDetailsPanel.Controls.Add(this.useCustomCheck);
            this.mockDetailsPanel.Controls.Add(this.expressionLbl);
            this.mockDetailsPanel.Controls.Add(this.mockTypeCombo);
            this.mockDetailsPanel.Controls.Add(this.label6);
            this.mockDetailsPanel.Controls.Add(this.label5);
            this.mockDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockDetailsPanel.Location = new System.Drawing.Point(25, 284);
            this.mockDetailsPanel.Name = "mockDetailsPanel";
            this.mockDetailsPanel.Size = new System.Drawing.Size(965, 360);
            this.mockDetailsPanel.TabIndex = 1;
            // 
            // expressionText1
            // 
            this.expressionText1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.expressionText1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.expressionText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expressionText1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText1.Location = new System.Drawing.Point(128, 130);
            this.expressionText1.Name = "expressionText1";
            this.expressionText1.ReadOnly = true;
            this.expressionText1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.expressionText1.Size = new System.Drawing.Size(807, 107);
            this.expressionText1.TabIndex = 12;
            this.expressionText1.Text = "";
            // 
            // mockSaveBtn
            // 
            this.mockSaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mockSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockSaveBtn.Location = new System.Drawing.Point(834, 258);
            this.mockSaveBtn.MaximumSize = new System.Drawing.Size(101, 40);
            this.mockSaveBtn.MinimumSize = new System.Drawing.Size(101, 40);
            this.mockSaveBtn.Name = "mockSaveBtn";
            this.mockSaveBtn.Size = new System.Drawing.Size(101, 40);
            this.mockSaveBtn.TabIndex = 11;
            this.mockSaveBtn.Text = "Save";
            this.mockSaveBtn.UseVisualStyleBackColor = true;
            // 
            // mockValidateBtn
            // 
            this.mockValidateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mockValidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockValidateBtn.Location = new System.Drawing.Point(718, 258);
            this.mockValidateBtn.MaximumSize = new System.Drawing.Size(101, 40);
            this.mockValidateBtn.MinimumSize = new System.Drawing.Size(101, 40);
            this.mockValidateBtn.Name = "mockValidateBtn";
            this.mockValidateBtn.Size = new System.Drawing.Size(101, 40);
            this.mockValidateBtn.TabIndex = 10;
            this.mockValidateBtn.Text = "Validate";
            this.mockValidateBtn.UseVisualStyleBackColor = true;
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
            this.resultText.BackColor = System.Drawing.Color.WhiteSmoke;
            this.resultText.CausesValidation = false;
            this.resultText.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(128, 263);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultText.Size = new System.Drawing.Size(573, 54);
            this.resultText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result";
            // 
            // useCustomCheck
            // 
            this.useCustomCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.useCustomCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useCustomCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomCheck.Location = new System.Drawing.Point(800, 73);
            this.useCustomCheck.Name = "useCustomCheck";
            this.useCustomCheck.Size = new System.Drawing.Size(135, 25);
            this.useCustomCheck.TabIndex = 6;
            this.useCustomCheck.Text = "Use Custom";
            this.useCustomCheck.UseVisualStyleBackColor = true;
            // 
            // expressionLbl
            // 
            this.expressionLbl.AutoSize = true;
            this.expressionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionLbl.Location = new System.Drawing.Point(14, 133);
            this.expressionLbl.Name = "expressionLbl";
            this.expressionLbl.Size = new System.Drawing.Size(87, 20);
            this.expressionLbl.TabIndex = 5;
            this.expressionLbl.Text = "Expression";
            // 
            // mockTypeCombo
            // 
            this.mockTypeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mockTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mockTypeCombo.FormattingEnabled = true;
            this.mockTypeCombo.Location = new System.Drawing.Point(128, 70);
            this.mockTypeCombo.Name = "mockTypeCombo";
            this.mockTypeCombo.Size = new System.Drawing.Size(651, 28);
            this.mockTypeCombo.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mock type";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.MinimumSize = new System.Drawing.Size(1000, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1564, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mock Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // actionGridPanel
            // 
            this.actionGridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionGridPanel.AutoScroll = true;
            this.actionGridPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.actionGridPanel.Controls.Add(this.previewDataLabel);
            this.actionGridPanel.Controls.Add(this.crmDataGridView);
            this.actionGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionGridPanel.Location = new System.Drawing.Point(25, 667);
            this.actionGridPanel.Name = "actionGridPanel";
            this.actionGridPanel.Size = new System.Drawing.Size(965, 527);
            this.actionGridPanel.TabIndex = 5;
            // 
            // previewDataLabel
            // 
            this.previewDataLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.previewDataLabel.AutoSize = true;
            this.previewDataLabel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.previewDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.previewDataLabel.Location = new System.Drawing.Point(443, 239);
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
            this.crmDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.crmDataGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.crmDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.crmDataGridView.MultiSelect = false;
            this.crmDataGridView.Name = "crmDataGridView";
            this.crmDataGridView.ReadOnly = true;
            this.crmDataGridView.RowHeadersVisible = false;
            this.crmDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.crmDataGridView.RowTemplate.Height = 28;
            this.crmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crmDataGridView.Size = new System.Drawing.Size(965, 527);
            this.crmDataGridView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.Controls.Add(this.leftMainPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rightMainPanel, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 53);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(800, 1232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(2254, 1232);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.toolStrip1.Size = new System.Drawing.Size(2268, 50);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::Mockit.Properties.Resources.mockit_logo_small;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(221, 44);
            this.toolStripLabel1.Text = "BULK DATA CREATOR";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // previewBtn
            // 
            this.previewBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previewBtn.Image = global::Mockit.Properties.Resources.icons8_search_48;
            this.previewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(142, 45);
            this.previewBtn.Text = "Preview Data";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
            // 
            // generateBtn
            // 
            this.generateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateBtn.Image = global::Mockit.Properties.Resources.icons8_setting_48;
            this.generateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(152, 45);
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
            this.toolStripLabel2.Size = new System.Drawing.Size(127, 45);
            this.toolStripLabel2.Text = "Rohan Goel";
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Image = global::Mockit.Properties.Resources.icons8_mailbox_48;
            this.toolStripLabel3.IsLink = true;
            this.toolStripLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(111, 45);
            this.toolStripLabel3.Text = "Feedback";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel4.Image")));
            this.toolStripLabel4.IsLink = true;
            this.toolStripLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(134, 45);
            this.toolStripLabel4.Text = "Report Issue";
            this.toolStripLabel4.VisitedLinkColor = System.Drawing.Color.Blue;
            this.toolStripLabel4.Click += new System.EventHandler(this.toolStripLabel4_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
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
            this.toolStripLabel5.Size = new System.Drawing.Size(159, 45);
            this.toolStripLabel5.Text = "Documentation";
            this.toolStripLabel5.Click += new System.EventHandler(this.toolStripLabel5_Click);
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseControl";
            this.PluginIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PluginIcon")));
            this.Size = new System.Drawing.Size(2268, 1300);
            this.ToolName = "Bulk Data Creator";
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.leftMainPanel.ResumeLayout(false);
            this.metadataPanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.rightMainPanel.ResumeLayout(false);
            this.fieldDetailsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fieldDetailsGrid)).EndInit();
            this.mockDetailsPanel.ResumeLayout(false);
            this.mockDetailsPanel.PerformLayout();
            this.actionGridPanel.ResumeLayout(false);
            this.actionGridPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelSelectEntity;
        private System.Windows.Forms.Label labelSelectColumns;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.NumericUpDown nudRecordCount;
        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.Panel rightMainPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mockDetailsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mockTypeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox useCustomCheck;
        private System.Windows.Forms.Label expressionLbl;
        private System.Windows.Forms.Button mockSaveBtn;
        private System.Windows.Forms.Button mockValidateBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel actionGridPanel;
        private System.Windows.Forms.DataGridView crmDataGridView;
        private System.Windows.Forms.ListView fieldsListView;
        private System.Windows.Forms.Button selectFieldButton;
        private System.Windows.Forms.RichTextBox expressionText1;
        private System.Windows.Forms.Panel metadataPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView fieldDetailsGrid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton previewBtn;
        private System.Windows.Forms.ToolStripButton generateBtn;
        private System.Windows.Forms.Panel fieldDetailsPanel;
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.Label previewDataLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldLogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMockType;
        private System.Windows.Forms.DataGridViewButtonColumn Action;
    }
}
