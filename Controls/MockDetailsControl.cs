using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using Mockit.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Controls
{
    public class MockDetailsControl : BaseControl
    {
        private readonly ComboBox _mockType;
        private readonly CheckBox _useCustom;
        private readonly RichTextBox _expression;
        private readonly Label _expressionLabel;
        private readonly TextBox _result;
        private readonly Button _save;
        private readonly Button _validate;

        private Mock boundMock;

        public event EventHandler MockChanged;

        public MockDetailsControl(Panel mockDetailsPanel)
        {
            _mockType = mockDetailsPanel.Controls["mockTypeCombo"] as ComboBox;
            _useCustom = mockDetailsPanel.Controls["useCustomCheck"] as CheckBox;
            _expression = mockDetailsPanel.Controls["expressionText1"] as RichTextBox;
            _result = mockDetailsPanel.Controls["resultText"] as TextBox;
            _save = mockDetailsPanel.Controls["mockSaveBtn"] as Button;
            _validate = mockDetailsPanel.Controls["mockValidateBtn"] as Button;

            _mockType.DataSource = Enum.GetNames(typeof(MockType));

            _mockType.SelectedIndexChanged += OnChangeMockType;
            _useCustom.Click += OnCheckExpression;
            _save.Click += OnSave;
            _validate.Click += OnValidate;
        }

        public void ShowDetails(Mock mock)
        {
            boundMock = mock;

            _mockType.SelectedItem = mock.MockType;
            _useCustom.Checked = mock.UseCustom;
            _expression.Text = mock.Expression ?? string.Empty;
            _result.Text = ExpressionEngine.Evaluate(mock.Expression);
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (boundMock != null) 
            {
                boundMock.MockType = (MockType)_mockType.SelectedItem;
                boundMock.UseCustom = _useCustom.Checked;
                boundMock.Expression = _expression.Text;

                MockChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void OnValidate(object sender, EventArgs e)
        {
            string expressionText = _expression.Text;
            string resultText = ExpressionEngine.Evaluate(expressionText);
            _result.Text = resultText;
        }

        private void OnCheckExpression (object sender, EventArgs e)
        {
            _mockType.SelectedItem = _useCustom.Checked ? MockType.CUSTOM: MockType.NONE;
        }

        private void OnChangeMockType(object sender, EventArgs e)
        {
            if (Enum.TryParse(_mockType.SelectedItem?.ToString(), out MockType selectedType))
            {
                _expression.Text = Helpers.GetExpression(selectedType);
                _useCustom.Checked = selectedType == MockType.CUSTOM;
                _expression.ReadOnly = selectedType == MockType.NONE;
            }
        }
    }
}