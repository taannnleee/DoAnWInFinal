using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinDows.Utilities
{
    public class LoadRowData
    {
        public static void LoadSelectedRowData(DataGridView dgv, string[] columnNames, Dictionary<string, Control> textBoxMapping)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgv.SelectedRows[0];
                for (int i = 0; i < columnNames.Length; i++)
                {
                    string columnName = columnNames[i];
                    if (textBoxMapping.ContainsKey(columnName) && row.Cells[columnName] != null)
                    {
                        Control control = textBoxMapping[columnName];
                        control.Text = row.Cells[columnName].Value.ToString();
                    }
                }
            }
        }

        public static void LoadObjectData(object data, Dictionary<string, Control> textBoxMapping)
        {
            Type objectType = data.GetType();
            foreach (var mapping in textBoxMapping)
            {
                string propertyName = mapping.Key;
                Control control = mapping.Value;

                PropertyInfo property = objectType.GetProperty(propertyName);
                if (property != null)
                {
                    object propertyValue = property.GetValue(data);
                    if (propertyValue != null)
                    {
                        control.Text = propertyValue.ToString();
                    }
                    else
                    {
                        control.Text = "";
                    }
                }
            }
        }
    }
}
