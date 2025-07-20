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
            this.gridPanel = new System.Windows.Forms.Panel();
            this.leftMainPanel = new System.Windows.Forms.Panel();
            this.selectFieldButton = new System.Windows.Forms.Button();
            this.fieldsListView = new System.Windows.Forms.ListView();
            this.rightMainPanel = new System.Windows.Forms.Panel();
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
            this.columnDetailsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.TextBox();
            this.lblLogicalName = new System.Windows.Forms.TextBox();
            this.lblDataType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.actionGridPanel = new System.Windows.Forms.Panel();
            this.generateBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.crmDataGridView = new System.Windows.Forms.DataGridView();
            this.expressionText = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).BeginInit();
            this.gridPanel.SuspendLayout();
            this.leftMainPanel.SuspendLayout();
            this.rightMainPanel.SuspendLayout();
            this.mockDetailsPanel.SuspendLayout();
            this.columnDetailsPanel.SuspendLayout();
            this.actionGridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).BeginInit();
            this.expressionText.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRecords
            // 
            this.labelRecords.AutoSize = true;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecords.Location = new System.Drawing.Point(14, 142);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(239, 20);
            this.labelRecords.TabIndex = 2;
            this.labelRecords.Text = "Number of records to create:";
            // 
            // cmbEntities
            // 
            this.cmbEntities.AllowDrop = true;
            this.cmbEntities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEntities.FormattingEnabled = true;
            this.cmbEntities.Location = new System.Drawing.Point(275, 13);
            this.cmbEntities.Name = "cmbEntities";
            this.cmbEntities.Size = new System.Drawing.Size(726, 28);
            this.cmbEntities.TabIndex = 3;
            this.cmbEntities.SelectionChangeCommitted += new System.EventHandler(this.cmbEntities_SelectedIndexChanged);
            // 
            // nudRecordCount
            // 
            this.nudRecordCount.Location = new System.Drawing.Point(275, 140);
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
            this.nudRecordCount.Size = new System.Drawing.Size(726, 26);
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
            this.labelSelectColumns.Location = new System.Drawing.Point(14, 73);
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
            this.labelSelectEntity.Location = new System.Drawing.Point(14, 13);
            this.labelSelectEntity.Name = "labelSelectEntity";
            this.labelSelectEntity.Size = new System.Drawing.Size(114, 20);
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
            this.FieldLogicalName,
            this.colFieldType,
            this.colMockType});
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
            this.gridColumns.Size = new System.Drawing.Size(1040, 849);
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
            // FieldLogicalName
            // 
            this.FieldLogicalName.DataPropertyName = "FieldLogicalName";
            this.FieldLogicalName.HeaderText = "Logical Name";
            this.FieldLogicalName.MinimumWidth = 8;
            this.FieldLogicalName.Name = "FieldLogicalName";
            this.FieldLogicalName.ReadOnly = true;
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
            // gridPanel
            // 
            this.gridPanel.Controls.Add(this.gridColumns);
            this.gridPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridPanel.Location = new System.Drawing.Point(0, 234);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1040, 849);
            this.gridPanel.TabIndex = 2;
            // 
            // leftMainPanel
            // 
            this.leftMainPanel.Controls.Add(this.selectFieldButton);
            this.leftMainPanel.Controls.Add(this.labelRecords);
            this.leftMainPanel.Controls.Add(this.cmbEntities);
            this.leftMainPanel.Controls.Add(this.fieldsListView);
            this.leftMainPanel.Controls.Add(this.nudRecordCount);
            this.leftMainPanel.Controls.Add(this.labelSelectColumns);
            this.leftMainPanel.Controls.Add(this.labelSelectEntity);
            this.leftMainPanel.Controls.Add(this.gridPanel);
            this.leftMainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMainPanel.Location = new System.Drawing.Point(18, 57);
            this.leftMainPanel.Name = "leftMainPanel";
            this.leftMainPanel.Size = new System.Drawing.Size(1040, 1083);
            this.leftMainPanel.TabIndex = 3;
            // 
            // selectFieldButton
            // 
            this.selectFieldButton.Location = new System.Drawing.Point(275, 73);
            this.selectFieldButton.Name = "selectFieldButton";
            this.selectFieldButton.Size = new System.Drawing.Size(726, 36);
            this.selectFieldButton.TabIndex = 8;
            this.selectFieldButton.Text = "Select Fields";
            this.selectFieldButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.selectFieldButton.UseVisualStyleBackColor = true;
            // 
            // fieldsListView
            // 
            this.fieldsListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fieldsListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.fieldsListView.AutoArrange = false;
            this.fieldsListView.CheckBoxes = true;
            this.fieldsListView.FullRowSelect = true;
            this.fieldsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.fieldsListView.HideSelection = false;
            this.fieldsListView.Location = new System.Drawing.Point(275, 115);
            this.fieldsListView.Name = "fieldsListView";
            this.fieldsListView.Size = new System.Drawing.Size(726, 300);
            this.fieldsListView.TabIndex = 7;
            this.fieldsListView.UseCompatibleStateImageBehavior = false;
            this.fieldsListView.View = System.Windows.Forms.View.Details;
            this.fieldsListView.Visible = false;
            this.fieldsListView.SelectedIndexChanged += new System.EventHandler(this.fieldsListView_SelectedIndexChanged);
            // 
            // rightMainPanel
            // 
            this.rightMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightMainPanel.Controls.Add(this.mockDetailsPanel);
            this.rightMainPanel.Controls.Add(this.columnDetailsPanel);
            this.rightMainPanel.Controls.Add(this.label4);
            this.rightMainPanel.Location = new System.Drawing.Point(1064, 57);
            this.rightMainPanel.Name = "rightMainPanel";
            this.rightMainPanel.Size = new System.Drawing.Size(908, 546);
            this.rightMainPanel.TabIndex = 4;
            // 
            // mockDetailsPanel
            // 
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
            this.mockDetailsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mockDetailsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mockDetailsPanel.Location = new System.Drawing.Point(0, 218);
            this.mockDetailsPanel.Name = "mockDetailsPanel";
            this.mockDetailsPanel.Size = new System.Drawing.Size(906, 326);
            this.mockDetailsPanel.TabIndex = 1;
            // 
            // expressionText1
            // 
            this.expressionText1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expressionText1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText1.Location = new System.Drawing.Point(128, 130);
            this.expressionText1.Name = "expressionText1";
            this.expressionText1.Size = new System.Drawing.Size(742, 96);
            this.expressionText1.TabIndex = 12;
            this.expressionText1.Text = "";
            // 
            // mockSaveBtn
            // 
            this.mockSaveBtn.Location = new System.Drawing.Point(769, 246);
            this.mockSaveBtn.Name = "mockSaveBtn";
            this.mockSaveBtn.Size = new System.Drawing.Size(101, 40);
            this.mockSaveBtn.TabIndex = 11;
            this.mockSaveBtn.Text = "Save";
            this.mockSaveBtn.UseVisualStyleBackColor = true;
            // 
            // mockValidateBtn
            // 
            this.mockValidateBtn.Location = new System.Drawing.Point(662, 246);
            this.mockValidateBtn.Name = "mockValidateBtn";
            this.mockValidateBtn.Size = new System.Drawing.Size(101, 40);
            this.mockValidateBtn.TabIndex = 10;
            this.mockValidateBtn.Text = "Validate";
            this.mockValidateBtn.UseVisualStyleBackColor = true;
            // 
            // resultText
            // 
            this.resultText.CausesValidation = false;
            this.resultText.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultText.Location = new System.Drawing.Point(128, 243);
            this.resultText.Multiline = true;
            this.resultText.Name = "resultText";
            this.resultText.ReadOnly = true;
            this.resultText.Size = new System.Drawing.Size(517, 43);
            this.resultText.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Result";
            // 
            // useCustomCheck
            // 
            this.useCustomCheck.AutoSize = true;
            this.useCustomCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.useCustomCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useCustomCheck.Location = new System.Drawing.Point(750, 74);
            this.useCustomCheck.Name = "useCustomCheck";
            this.useCustomCheck.Size = new System.Drawing.Size(120, 24);
            this.useCustomCheck.TabIndex = 6;
            this.useCustomCheck.Text = "Use custom";
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
            this.mockTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mockTypeCombo.FormattingEnabled = true;
            this.mockTypeCombo.Location = new System.Drawing.Point(128, 70);
            this.mockTypeCombo.Name = "mockTypeCombo";
            this.mockTypeCombo.Size = new System.Drawing.Size(603, 28);
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
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.columnDetailsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.columnDetailsPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Display Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Logical Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Type";
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDisplayName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDisplayName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDisplayName.Location = new System.Drawing.Point(187, 4);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.ReadOnly = true;
            this.lblDisplayName.Size = new System.Drawing.Size(715, 24);
            this.lblDisplayName.TabIndex = 3;
            // 
            // lblLogicalName
            // 
            this.lblLogicalName.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLogicalName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblLogicalName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogicalName.Location = new System.Drawing.Point(187, 54);
            this.lblLogicalName.Name = "lblLogicalName";
            this.lblLogicalName.ReadOnly = true;
            this.lblLogicalName.Size = new System.Drawing.Size(715, 24);
            this.lblLogicalName.TabIndex = 4;
            // 
            // lblDataType
            // 
            this.lblDataType.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDataType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDataType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDataType.Location = new System.Drawing.Point(187, 104);
            this.lblDataType.Name = "lblDataType";
            this.lblDataType.ReadOnly = true;
            this.lblDataType.Size = new System.Drawing.Size(715, 24);
            this.lblDataType.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.actionGridPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionGridPanel.Location = new System.Drawing.Point(1064, 618);
            this.actionGridPanel.Name = "actionGridPanel";
            this.actionGridPanel.Size = new System.Drawing.Size(907, 634);
            this.actionGridPanel.TabIndex = 5;
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(754, 558);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(153, 45);
            this.generateBtn.TabIndex = 2;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(563, 557);
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
            this.crmDataGridView.Size = new System.Drawing.Size(907, 522);
            this.crmDataGridView.TabIndex = 0;
            // 
            // expressionText
            // 
            this.expressionText.AutoScroll = true;
            this.expressionText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.expressionText.Controls.Add(this.leftMainPanel);
            this.expressionText.Controls.Add(this.rightMainPanel);
            this.expressionText.Controls.Add(this.actionGridPanel);
            this.expressionText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionText.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expressionText.Location = new System.Drawing.Point(0, 0);
            this.expressionText.Name = "expressionText";
            this.expressionText.Size = new System.Drawing.Size(2413, 1283);
            this.expressionText.TabIndex = 6;
            // 
            // BaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Controls.Add(this.expressionText);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseControl";
            this.Size = new System.Drawing.Size(2413, 1283);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRecordCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridColumns)).EndInit();
            this.gridPanel.ResumeLayout(false);
            this.leftMainPanel.ResumeLayout(false);
            this.leftMainPanel.PerformLayout();
            this.rightMainPanel.ResumeLayout(false);
            this.mockDetailsPanel.ResumeLayout(false);
            this.mockDetailsPanel.PerformLayout();
            this.columnDetailsPanel.ResumeLayout(false);
            this.columnDetailsPanel.PerformLayout();
            this.actionGridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crmDataGridView)).EndInit();
            this.expressionText.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel columnDetailsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel mockDetailsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox mockTypeCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox useCustomCheck;
        private System.Windows.Forms.Label expressionLbl;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button mockSaveBtn;
        private System.Windows.Forms.Button mockValidateBtn;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel actionGridPanel;
        private System.Windows.Forms.DataGridView crmDataGridView;
        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.Panel expressionText;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldLogicalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFieldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMockType;
        private System.Windows.Forms.ListView fieldsListView;
        private System.Windows.Forms.Button selectFieldButton;
        private System.Windows.Forms.TextBox lblDisplayName;
        private System.Windows.Forms.TextBox lblLogicalName;
        private System.Windows.Forms.TextBox lblDataType;
        private System.Windows.Forms.RichTextBox expressionText1;
    }
}
