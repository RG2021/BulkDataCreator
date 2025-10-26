using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using Mockit.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Mockit.Common.Constants.Constants;
using System.Linq;

namespace Mockit.Controls
{
    public class MockDetailsControl : BaseControl
    {
        private readonly ComboBox _mockType;
        private readonly Button _searchLookup;
        private readonly CheckBox _useCustom;
        private readonly RichTextBox _expression;
        private readonly Label _expressionLabel;
        private readonly TextBox _result;
        private readonly Button _save;
        private readonly Button _validate;
        private ExpressionEngine _expressionEngine;

        private GridRow boundRow;

        public event EventHandler MockChanged;

        public MockDetailsControl(GroupBox mockDetailsPanel)
        {
            _expressionEngine = new ExpressionEngine();
            _mockType = mockDetailsPanel.Controls["mockTypeCombo"] as ComboBox;
            _searchLookup = mockDetailsPanel.Controls["searchLookupButton"] as Button;
            _useCustom = mockDetailsPanel.Controls["useCustomCheck"] as CheckBox;
            _expression = mockDetailsPanel.Controls["expressionText1"] as RichTextBox;
            _result = mockDetailsPanel.Controls["resultText"] as TextBox;
            _save = mockDetailsPanel.Controls["mockSaveBtn"] as Button;
            _validate = mockDetailsPanel.Controls["mockValidateBtn"] as Button;

            _mockType.DataSource = Enum.GetValues(typeof(MockType));

            _mockType.SelectedIndexChanged += OnChangeMockType;
            _useCustom.Click += OnCheckExpression;
            _save.Click += OnSave;
            _validate.Click += OnValidate;
            _searchLookup.Click += OnLookupSearch;
        }

        public void ShowDetails(GridRow row)
        {
            boundRow = row;

            _mockType.SelectedItem = row.Mock.MockType;
            _useCustom.Checked = row.Mock.UseCustom;
            _expression.Text = row.Mock.Expression ?? string.Empty;
            _result.Text = _expressionEngine.Evaluate(row.Mock.Expression);
            _searchLookup.Enabled = Helpers.IsLookupTypeField(row.Field);
        }

        private void OnLookupSearch(object sender, EventArgs e)
        {
            _LookupSearchControl.LoadLookupSearch(boundRow);
        }


        private void OnSave(object sender, EventArgs e)
        {

            if (boundRow != null)
            {
                boundRow.Mock = new Mock
                {
                    MockType = (MockType)_mockType.SelectedItem,
                    UseCustom = _useCustom.Checked,
                    Expression = _expression.Text
                };
            }
        }

        private void OnValidate(object sender, EventArgs e)
        {
            string expressionText = _expression.Text;
            string resultText = _expressionEngine.Evaluate(expressionText);
            _result.Text = resultText;
        }

        private void OnCheckExpression (object sender, EventArgs e)
        {
            _mockType.SelectedItem = _useCustom.Checked ? MockType.CUSTOM: MockType.NONE;
        }

        private void OnChangeMockType(object sender, EventArgs e)
        {
            if (_mockType.SelectedItem is MockType selectedType)
            {
                _expression.Text = Helpers.GetExpression(selectedType);
                _useCustom.Checked = selectedType == MockType.CUSTOM;
                _expression.ReadOnly = selectedType == MockType.NONE;
                _expression.BackColor = selectedType == MockType.NONE ? System.Drawing.Color.WhiteSmoke : System.Drawing.Color.White;
            }
        }
    }
}