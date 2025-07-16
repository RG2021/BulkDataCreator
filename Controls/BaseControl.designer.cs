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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metadataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelRecords = new System.Windows.Forms.Label();
            this.cmbEntities = new System.Windows.Forms.ComboBox();
            this.cmbColumns = new System.Windows.Forms.ComboBox();
            this.nudRecordCount = new System.Windows.Forms.NumericUpDown();
            this.labelSelectColumns = new System.Windows.Forms.Label();
            this.labelSelectEntity = new System.Windows.Forms.Label();
            this.gridColumns = new System.Windows.Forms.DataGridView();
            this.colFieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFieldType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMockType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MockValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.rightMainPanel = new System.Windows.Forms.Panel();
            this.mockDetailsPanel = new System.Windows.Forms.Panel();
            this.mockSaveBtn = new System.Windows.Forms.Button();
            this.mockValidateBtn = new System.Windows.Forms.Button();
            this.resultText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.expressionText = new System.Windows.Forms.TextBox();
            this.useCustomCheck = new System.Windows.Forms.CheckBox();
            this.expressionLbl = new System.Windows.Forms.Label();
            this.mockTypeCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.columnDetailsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblLogicalName = new System.Windows.Forms.Label();
            this.lblDataType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionGridPanel = new System.Windows.Forms.Panel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.crmDataGridView = new System.Windows.Forms.DataGridView();
            this.metadataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.gridPanel.SuspendLayout();
            this.leftMainPanel.SuspendLayout();
            this.rightMainPanel.SuspendLayout();
            this.mockDetailsPanel.SuspendLayout();
            this.columnDetailsPanel.SuspendLayout();
            this.actionGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // metadataPanel
            // 
            this.metadataPanel.ColumnCount = 2;
            this.metadataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.76983F));
            this.metadataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.23017F));
            this.metadataPanel.Controls.Add(this.labelRecords, 0, 2);
            this.metadataPanel.Controls.Add(this.cmbEntities, 1, 0);
            this.metadataPanel.Controls.Add(this.cmbColumns, 1, 1);
            this.metadataPanel.Controls.Add(this.nudRecordCount, 1, 2);
            this.metadataPanel.Controls.Add(this.labelSelectColumns, 0, 1);
            this.metadataPanel.Controls.Add(this.labelSelectEntity, 0, 0);
            this.metadataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.metadataPanel.Location = new System.Drawing.Point(0, 0);
            this.metadataPanel.Name = "metadataPanel";
            this.metadataPanel.RowCount = 3;
            this.metadataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.41177F));
            this.metadataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.58823F));
            this.metadataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.metadataPanel.Size = new System.Drawing.Size(1027, 194);
            this.metadataPanel.TabIndex = 0;
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(3, 135);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(239, 20);
            this.labelRecords.TabIndex = 2;
            this.labelRecords.Text = "Number of records to create:";
            // 
            // cmbEntities
            // 
            this.cmbEntities.AllowDrop = true;
            this.cmbEntities.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(339, 3);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(685, 28);
            this.cmbEntities.TabIndex = 3;
            this.cmbEntities.SelectionChangeCommitted += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // cmbColumns
            // 
            this.cmbColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.cmbColumns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColumns.FormattingEnabled = true;
            this.cmbColumns.Location = new System.Drawing.Point(339, 70);
            this.cmbColumns.Name = "cmbColumns";
            this.cmbColumns.Size = new System.Drawing.Size(685, 28);
            this.cmbColumns.TabIndex = 4;
            this.cmbColumns.SelectionChangeCommitted += new System.EventHandler(this.cmbColumns_SelectedIndexChanged);
            // 
            // nudRecordCount
            // 
            this.nudRecordCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.nudRecordCount.Location = new System.Drawing.Point(339, 138);
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
            this.nudRecordCount.Size = new System.Drawing.Size(685, 26);
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
            this.labelSelectColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectColumns.Location = new System.Drawing.Point(3, 67);
            this.labelSelectColumns.Name = "labelSelectColumns";
            this.labelSelectColumns.Size = new System.Drawing.Size(136, 20);
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
            this.labelSelectEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectEntity.Location = new System.Drawing.Point(3, 0);
            this.labelSelectEntity.Name = "labelSelectEntity";
            this.labelSelectEntity.Size = new System.Drawing.Size(330, 67);
            this.labelSelectEntity.TabIndex = 0;
            this.labelSelectEntity.Text = "Select entity:";
            // 
            // gridColumns
            // 
            this.gridColumns.AllowUserToAddRows = false;
            this.gridColumns.AllowUserToDeleteRows = false;
            this.gridColumns.AllowUserToResizeColumns = false;
            this.gridColumns.AllowUserToResizeRows = false;
            this.gridColumns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridColumns.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.gridColumns.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridColumns.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridColumns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridColumns.ColumnHeadersHeight = 34;
            this.gridColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridColumns.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFieldName,
            this.colFieldType,
            this.colMockType,
            this.MockValue});
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
            this.gridColumns.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridColumns.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridColumns.Size = new System.Drawing.Size(1027, 864);
            this.gridColumns.TabIndex = 1;
            this.gridColumns.SelectionChanged += new System.EventHandler(this.gridColumns_SelectionChanged);
            // 
            // colFieldName
            // 
            this.colFieldName.DataPropertyName = "FieldName";
            this.colFieldName.HeaderText = "Field Name";
            this.colFieldName.MinimumWidth = 8;
            this.colFieldName.Name = "colFieldName";
            this.colFieldName.ReadOnly = true;
            // 
            // colFieldType
            // 
            this.colFieldType.DataPropertyName = "FieldType";
            this.colFieldType.HeaderText = "CRM Data Type";
            this.colFieldType.MinimumWidth = 8;
            this.colFieldType.Name = "colFieldType";
            this.colFieldType.ReadOnly = true;
            // 
            // colMockType
            // 
            this.colMockType.DataPropertyName = "MockType";
            this.colMockType.HeaderText = "Mock Type";
            this.colMockType.MinimumWidth = 8;
            this.colMockType.Name = "colMockType";
            this.colMockType.ReadOnly = true;
            // 
            // MockValue
            // 
            this.MockValue.DataPropertyName = "MockValue";
            this.MockValue.HeaderText = "Mock Value";
            this.MockValue.MinimumWidth = 8;
            this.MockValue.Name = "MockValue";
            this.MockValue.ReadOnly = true;
            // 
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.gridColumns);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPanel.Location = new System.Drawing.Point(0, 219);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1027, 864);
            this.gridPanel.TabIndex = 2;
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.Controls.Add(this.metadataPanel);
            this.leftMainPanel.Controls.Add(this.gridPanel);
            this.leftMainPanel.Location = new System.Drawing.Point(55, 45);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(1027, 1083);
            this.leftMainPanel.TabIndex = 3;
            // 
            // rightMainPanel
            // 
            this.rightMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightMainPanel.Controls.Add(this.mockDetailsPanel);
            this.rightMainPanel.Controls.Add(this.columnDetailsPanel);
            this.rightMainPanel.Controls.Add(this.label4);
            this.rightMainPanel.Location = new System.Drawing.Point(1108, 48);
            this.rightMainPanel.Name = "rightMainPanel";
            this.rightMainPanel.Size = new System.Drawing.Size(908, 474);
            this.rightMainPanel.TabIndex = 4;
            // 
            // mockDetailsPanel
            // 
            this.mockDetailsPanel.Controls.Add(this.mockSaveBtn);
            this.mockDetailsPanel.Controls.Add(this.mockValidateBtn);
            this.mockDetailsPanel.Controls.Add(this.resultText);
            this.mockDetailsPanel.Controls.Add(this.label8);
            this.mockDetailsPanel.Controls.Add(this.expressionText);
            this.mockDetailsPanel.Controls.Add(this.useCustomCheck);
            this.mockDetailsPanel.Controls.Add(this.expressionLbl);
            this.mockDetailsPanel.Controls.Add(this.mockTypeCombo);
            this.mockDetailsPanel.Controls.Add(this.label6);
            this.mockDetailsPanel.Controls.Add(this.label5);
            this.mockDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mockDetailsPanel.Location = new System.Drawing.Point(0, 213);
            this.mockDetailsPanel.Name = "mockDetailsPanel";
            this.mockDetailsPanel.Size = new System.Drawing.Size(906, 259);
            this.mockDetailsPanel.TabIndex = 1;
            // 
            // mockSaveBtn
            // 
            this.mockSaveBtn.Location = new System.Drawing.Point(769, 189);
            this.mockSaveBtn.Name = "mockSaveBtn";
            this.mockSaveBtn.Size = new System.Drawing.Size(101, 38);
            this.mockSaveBtn.TabIndex = 11;
            this.mockSaveBtn.Text = "Save";
            this.mockSaveBtn.UseVisualStyleBackColor = true;
            // 
            // mockValidateBtn
            // 
            this.mockValidateBtn.Location = new System.Drawing.Point(662, 186);
            this.mockValidateBtn.Name = "mockValidateBtn";
            this.mockValidateBtn.Size = new System.Drawing.Size(101, 38);
            this.mockValidateBtn.TabIndex = 10;
            this.mockValidateBtn.Text = "Validate";
            this.mockValidateBtn.UseVisualStyleBackColor = true;
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(128, 192);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(517, 26);
            this.resultText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result";
            // 
            // expressionText
            // 
            this.expressionText.Location = new System.Drawing.Point(128, 133);
            this.expressionText.Name = "expressionText";
            this.expressionText.Size = new System.Drawing.Size(742, 26);
            this.expressionText.TabIndex = 7;
            // 
            // useCustomCheck
            // 
            this.useCustomCheck.AutoSize = true;
            this.useCustomCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useCustomCheck.Location = new System.Drawing.Point(726, 74);
            this.useCustomCheck.Name = "useCustomCheck";
            this.useCustomCheck.Size = new System.Drawing.Size(120, 24);
            this.useCustomCheck.TabIndex = 6;
            this.useCustomCheck.Text = "Use custom";
            this.useCustomCheck.UseVisualStyleBackColor = true;
            // 
            // expressionLbl
            // 
            this.expressionLbl.AutoSize = true;
            this.expressionLbl.Location = new System.Drawing.Point(14, 133);
            this.expressionLbl.Name = "expressionLbl";
            this.expressionLbl.Size = new System.Drawing.Size(87, 20);
            this.expressionLbl.TabIndex = 5;
            this.expressionLbl.Text = "Expression";
            
            // 
            // mockTypeCombo
            // 
            this.mockTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mockTypeCombo.FormattingEnabled = true;
            this.mockTypeCombo.Location = new System.Drawing.Point(128, 70);
            this.mockTypeCombo.Name = "mockTypeCombo";
            this.mockTypeCombo.Size = new System.Drawing.Size(570, 28);
            this.mockTypeCombo.TabIndex = 2;
            
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mock type";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(906, 40);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mock Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnDetailsPanel
            // 
            this.columnDetailsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.columnDetailsPanel.ColumnCount = 2;
            this.columnDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.22333F));
            this.columnDetailsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.77667F));
            this.columnDetailsPanel.Controls.Add(this.label1, 0, 0);
            this.columnDetailsPanel.Controls.Add(this.label2, 0, 1);
            this.columnDetailsPanel.Controls.Add(this.label3, 0, 2);
            this.columnDetailsPanel.Controls.Add(this.lblDisplayName, 1, 0);
            this.columnDetailsPanel.Controls.Add(this.lblLogicalName, 1, 1);
            this.columnDetailsPanel.Controls.Add(this.lblDataType, 1, 2);
            this.columnDetailsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.columnDetailsPanel.Location = new System.Drawing.Point(0, 40);
            this.columnDetailsPanel.Name = "columnDetailsPanel";
            this.columnDetailsPanel.RowCount = 3;
            this.columnDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columnDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.columnDetailsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.columnDetailsPanel.Size = new System.Drawing.Size(906, 151);
            this.columnDetailsPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logical Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Type";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.Location = new System.Drawing.Point(187, 1);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(14, 20);
            this.lblDisplayName.TabIndex = 3;
            this.lblDisplayName.Text = "-";
            // 
            // lblLogicalName
            // 
            this.lblLogicalName.AutoSize = true;
            this.lblLogicalName.Location = new System.Drawing.Point(187, 51);
            this.lblLogicalName.Name = "lblLogicalName";
            this.lblLogicalName.Size = new System.Drawing.Size(14, 20);
            this.lblLogicalName.TabIndex = 4;
            this.lblLogicalName.Text = "-";
            // 
            // lblDataType
            // 
            this.lblDataType.AutoSize = true;
            this.lblDataType.Location = new System.Drawing.Point(187, 101);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.Size = new System.Drawing.Size(14, 20);
            this.lblDataType.TabIndex = 5;
            this.lblDataType.Text = "-";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(906, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Column Details";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // actionGridPanel
            // 
            this.actionGridPanel.Controls.Add(this.generateBtn);
            this.actionGridPanel.Controls.Add(this.previewBtn);
            this.actionGridPanel.Controls.Add(this.crmDataGridView);
            this.actionGridPanel.Location = new System.Drawing.Point(1108, 547);
            this.actionGridPanel.Name = "actionGridPanel";
            this.actionGridPanel.Size = new System.Drawing.Size(907, 693);
            this.actionGridPanel.TabIndex = 5;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(751, 613);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(153, 45);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(565, 612);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(169, 46);
            this.previewBtn.TabIndex = 1;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
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
            this.crmDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.crmDataGridView.Location = new System.Drawing.Point(0, 0);
            this.crmDataGridView.MultiSelect = false;
            this.crmDataGridView.Name = "crmDataGridView";
            this.crmDataGridView.ReadOnly = true;
            this.crmDataGridView.RowHeadersVisible = false;
            this.crmDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.crmDataGridView.RowTemplate.Height = 28;
            this.crmDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.crmDataGridView.Size = new System.Drawing.Size(907, 581);
            this.crmDataGridView.TabIndex = 0;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.actionGridPanel);
            this.Controls.Add(this.rightMainPanel);
            this.Controls.Add(this.leftMainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(2413, 1283);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.metadataPanel.ResumeLayout(false);
            this.metadataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.leftMainPanel.ResumeLayout(false);
            this.rightMainPanel.ResumeLayout(false);
            this.mockDetailsPanel.ResumeLayout(false);
            this.mockDetailsPanel.PerformLayout();
            this.columnDetailsPanel.ResumeLayout(false);
            this.columnDetailsPanel.PerformLayout();
            this.actionGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel metadataPanel;
        private System.Windows.Forms.Label labelSelectEntity;
        private System.Windows.Forms.Label labelSelectColumns;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.ComboBox cmbEntities;
        private System.Windows.Forms.NumericUpDown nudRecordCount;
        private System.Windows.Forms.DataGridView gridColumns;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Panel leftMainPanel;
        private System.Windows.Forms.ComboBox cmbColumns;
        private System.Windows.Forms.Panel rightMainPanel;
        private System.Windows.Forms.TableLayoutPanel columnDetailsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblLogicalName;
        private System.Windows.Forms.Label lblDataType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mockDetailsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mockTypeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox useCustomCheck;
        private System.Windows.Forms.Label expressionLbl;
        private System.Windows.Forms.TextBox expressionText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button mockSaveBtn;
        private System.Windows.Forms.Button mockValidateBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMockType;
        private System.Windows.Forms.DataGridViewTextBoxColumn MockValue;
        private System.Windows.Forms.Panel actionGridPanel;
        private System.Windows.Forms.DataGridView crmDataGridView;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}
