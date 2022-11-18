using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_Account_Management.Extensions
{
    public static class DataGridViewExtension
    {
        public static void EnableDoubleBuffered(this DataGridView dgv)
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
