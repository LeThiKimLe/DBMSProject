using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Saving_Account_Management.BS_Layer;

namespace Saving_Account_Management.FormGiaoDich
{
    public partial class FormGiaoDichLanDau : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();
        public FormGiaoDichLanDau()
        {
            InitializeComponent();
        }
        public FormGiaoDichLanDau(string maGiaoDich)
        {
            InitializeComponent();
            LoadData(maGiaoDich);

        }
        private void LoadData(string maGiaoDich)
        {
           
            DataTable tb = action.get_Chitiet_GiaoDichGuiTK(maGiaoDich).Tables[0];

            txtHoTen.Text = tb.Rows[0]["HoTenKH"].ToString();
            txtMaDN.Text = tb.Rows[0]["MaDinhDanh"].ToString();

            txtMaSo.Text= tb.Rows[0]["MaSoTK"].ToString();
            txtSoTien.Text= tb.Rows[0]["SoTienGiaoDich"].ToString();
            txtLoaiTien.Text= tb.Rows[0]["MaLoaiTien"].ToString();
            txtHoTenNV.Text= tb.Rows[0]["HoTenNV"].ToString();
            txtMaNV.Text = tb.Rows[0]["MaNhanVien"].ToString();

        }


    }
}
