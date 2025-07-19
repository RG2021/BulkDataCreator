using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class FieldsSelectorControl : UserControl
{
    private readonly ListView listViewFields;
    private readonly Button btnOpenList;
    private List<CRMField> crmFields = new List<CRMField>();

    public event Action<CRMField> FieldSelected;

    public FieldsSelectorControl()
    {
        btnOpenList = new Button
        {
            Text = "Select Field",
            Dock = DockStyle.Top,
            Height = 30
        };

        listViewFields = new ListView
        {
            View = View.Details,
            Height = 200,
            Visible = false,
            Dock = DockStyle.Fill,
            FullRowSelect = true
        };
        listViewFields.Columns.Add("Display Name", 150);
        listViewFields.Columns.Add("Logical Name", 150);

        btnOpenList.Click += BtnOpenList_Click;
        listViewFields.DoubleClick += ListViewFields_DoubleClick;

        Controls.Add(listViewFields);
        Controls.Add(btnOpenList);
        Height = 240;
    }

    private void BtnOpenList_Click(object sender, EventArgs e)
    {
        listViewFields.Visible = !listViewFields.Visible;
    }

    private void ListViewFields_DoubleClick(object sender, EventArgs e)
    {
        if (listViewFields.SelectedItems.Count > 0)
        {
            var selected = listViewFields.SelectedItems[0];
            var field = new CRMField
            {
                DisplayName = selected.Text,
                LogicalName = selected.SubItems[1].Text
            };

            FieldSelected?.Invoke(field);
            listViewFields.Visible = false;
        }
    }

    public void SetFields(List<CRMField> fields)
    {
        crmFields = fields;
        listViewFields.Items.Clear();

        foreach (var field in fields)
        {
            var item = new ListViewItem(field.DisplayName);
            item.SubItems.Add(field.LogicalName);
            listViewFields.Items.Add(item);
        }
    }
}
