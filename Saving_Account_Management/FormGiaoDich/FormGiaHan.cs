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
    public partial class FormGiaHan : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();

       
        private string magiaodich = null;
        DataTable tb = null;
        public FormGiaHan()
        {
            InitializeComponent();
        }
        public FormGiaHan(string maGiaoDich)
        {
            InitializeComponent();
            magiaodich = maGiaoDich;
            LoadData(magiaodich);
        }
        private void LoadData(string maGiaoDich)
        {
            tb = action.get_Chitiet_GiaoDichGiaHanSo1Lan(maGiaoDich).Tables[0];
            txtMaSo.Text = tb.Rows[0]["MaSoTK"].ToString();
            txtLaiSuat.Text= tb.Rows[0]["LaiSuat"].ToString();
            txtKyHan.Text = tb.Rows[0]["KyHan"].ToString();
            txtLoaiTien.Text = tb.Rows[0]["LoaiTien"].ToString();
            txtGocCu.Text = DateTime.Parse(tb.Rows[0]["ngayNhapGocCu"].ToString()).ToShortDateString();
            txtHanCu.Text= DateTime.Parse(tb.Rows[0]["ngayDenHanCu"].ToString()).ToShortDateString();
            txtSoDuCu.Text= tb.Rows[0]["SoDuCu"].ToString();
            txtGocMoi.Text= DateTime.Parse(tb.Rows[0]["ngayNhapGocMoi"].ToString()).ToShortDateString();
            txtHanMoi.Text = DateTime.Parse(tb.Rows[0]["ngayDenHanMoi"].ToString()).ToShortDateString();
            txtSoDuMoi.Text= tb.Rows[0]["SoDuMoi"].ToString();
        }
    }
}
