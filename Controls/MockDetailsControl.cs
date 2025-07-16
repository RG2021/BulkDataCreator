using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using System.Xml.XPath;
using XrmToolBox.Extensibility;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Controls
{
    public class MockDetailsControl : BaseControl
    {
        private readonly Panel _mockDetailsPanel;
        private readonly ComboBox _mockType;
        private readonly CheckBox _useExpression;
        private readonly TextBox _expression;
        private readonly Label _expressionLabel;
        private readonly TextBox _result;
        private readonly Button _save;

        private Mock boundMock;
        public event EventHandler MockChanged;

        public MockDetailsControl(Panel mockDetailsPanel)
        {
            _mockDetailsPanel = mockDetailsPanel;

            _mockType = _mockDetailsPanel.Controls["mockTypeCombo"] as ComboBox;
            _useExpression = _mockDetailsPanel.Controls["useExpressionCheck"] as CheckBox;
            _expression = _mockDetailsPanel.Controls["expressionText"] as TextBox;
            _expressionLabel = _mockDetailsPanel.Controls["expressionLbl"] as Label;
            _result = _mockDetailsPanel.Controls["resultText"] as TextBox;
            _save = _mockDetailsPanel.Controls["mockSaveBtn"] as Button;

            _mockType.DataSource = Enum.GetValues(typeof(MockType));

            _mockType.SelectedIndexChanged += OnChangeMockType;
            _useExpression.CheckedChanged += OnCheckExpression;
            _save.Click += OnSave;
        }

        public void ShowDetails(Mock mock)
        {
            boundMock = mock;

            _mockType.SelectedItem = mock.MockType;
            _useExpression.Checked = mock.UseExpression;
            _expression.Text = mock.Expression ?? string.Empty;
            _result.Text = mock.Value ?? string.Empty;
        }

        private void OnSave(object sender, EventArgs e)
        {
            boundMock.MockType = (MockType) _mockType.SelectedItem;
            boundMock.UseExpression = _useExpression.Checked;
            boundMock.Expression = _expression.Text;
            boundMock.Value = _result.Text;

            MockChanged?.Invoke(this, EventArgs.Empty);
        }

        private void OnCheckExpression (object sender, EventArgs e)
        {
            _mockType.SelectedItem = _useExpression.Checked ? MockType.EXPRESSION: MockType.NONE;
        }

        private void OnChangeMockType(object sender, EventArgs e)
        {
            if(_mockType.SelectedItem is MockType type)
            {
                _useExpression.Checked = type == MockType.EXPRESSION;
            }
        }
    }
}