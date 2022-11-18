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

namespace Saving_Account_Management
{
    public partial class DM_LoaiGiaoDich : Form
    {
        private BS_DanhMuc action = new BS_DanhMuc();
        public DM_LoaiGiaoDich()
        {
            InitializeComponent();
            Load_Data();    
        }
        private void Load_Data()
        {
            dataGridView_LoaiGD.DataSource = action.LayDanhSachLoaiGiaoDich().Tables[0];

        }

        private void DM_LoaiGiaoDich_Load(object sender, EventArgs e)
        {

        }
    }
}
