using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_Account_Management.Extensions
{
    public static class FormExtension
    {
        /// <summary>
        /// Lấy toàn bộ control con của control
        /// </summary>
        /// <param name="control"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static IEnumerable<Control> GetAllChildControl(this Control control)
        {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAllChildControl(ctrl)).Union(controls);
        }
    }
}
