using Saving_Account_Management.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Saving_Account_Management
{
    public partial class DM_ChiNhanh : Form
    {
        private BS_DanhMuc action = new BS_DanhMuc();
        public DM_ChiNhanh()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            dataGridView_ChiNhanh.DataSource = action.LayDanhSachChiNhanh().Tables[0];
     
        }


        private void dataGridView_ChiNhanh_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
