using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Saving_Account_Management.Utils
{
    public class DataGridViewUtils
    {
        public static int GetWidthStringInPixel(string text, Font font)
        {
            return TextRenderer.MeasureText(text, font).Width;
        }

        public static void FitColumnHeaderWidth(DataGridView dgv)
        {
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.Width = GetWidthStringInPixel(column.HeaderText, column.DefaultCellStyle.Font) + 30;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        public static void FitDataWidth(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        public static void SetName(DataGridView dgv, List<string> listTenCot)
        {
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Columns[i].HeaderText = listTenCot[i];
            }
        }

        public static void EnableDoubleBuffered(DataGridView dgv)
        {
            typeof(DataGridView).InvokeMember(
               "DoubleBuffered",
               BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty,
               null,
               dgv,
               new object[] { true }
            );
        }
    }
}
