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
using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management
{
    public partial class DM_LoaiTien : Form
    {
        private BS_DanhMuc action = new BS_DanhMuc();

        public DM_LoaiTien()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            dataGridView_LoaiTien.DataSource = action.LayDanhSachLoaiTien().Tables[0];

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
