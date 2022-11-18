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
    public partial class FormRutLaiTruoc : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();

        private string makhachhang = null;
        private string manhanvien = null;
        private string magiaodich = null;
        DataTable tb = null;
        public FormRutLaiTruoc()
        {
            InitializeComponent();
        }
        public FormRutLaiTruoc(string maGiaoDich, string MaKhachHang, string MaNhanVien)
        {
            InitializeComponent();
            magiaodich = maGiaoDich;
            makhachhang = MaKhachHang;
            manhanvien = MaNhanVien;
            LoadData(maGiaoDich);

        }

        private void LoadData(string maGiaoDich)
        {
            tb = action.get_Chitiet_GiaoDichRutLaiTruoc(maGiaoDich).Tables[0];
            bool tinhTrang;
            tinhTrang = bool.Parse(tb.Rows[0]["tinhTrang"].ToString());

            txtMaSo.Text = tb.Rows[0]["MaSoTK"].ToString();
            txtGoc.Text = tb.Rows[0]["SoDu"].ToString();
            txtLaiNhanTruoc.Text = tb.Rows[0]["SoTienLai"].ToString();
            txtLoaiTien.Text = tb.Rows[0]["MaLoaiTien"].ToString();
            txtLaisuat.Text = tb.Rows[0]["LaiSuatTK"].ToString();
            txtKyHan.Text = tb.Rows[0]["KyHan"].ToString();

            if (tb.Rows[0]["HoTenKH"].ToString()=="")
                txtHoTenKH.Text = "Giao dịch tự phát sinh";
            else
                txtHoTenKH.Text = tb.Rows[0]["HoTenKH"].ToString();

            if (tb.Rows[0]["MaDinhDanh"].ToString() == "")
                txtMaDN.Text = "Giao dịch tự phát sinh";
            else
                txtMaDN.Text = tb.Rows[0]["MaDinhDanh"].ToString();

            if (tb.Rows[0]["HoTenNV"].ToString() == "")
                txtHoTenNV.Text = "Giao dịch tự phát sinh";
            else
                txtHoTenNV.Text = tb.Rows[0]["HoTenNV"].ToString();

            if (tb.Rows[0]["MaNhanVien"].ToString() == "")
                txtMaNV.Text = "Giao dịch tự phát sinh";
            else
                txtMaNV.Text = tb.Rows[0]["MaNhanVien"].ToString();


            if (tinhTrang == true)
            {
                lbThanhToan.Text = "ĐÃ THANH TOÁN";
                btnThanhToan.Visible = false;
                lbChecked.Visible = true;
                txtChecked.Visible = true;
                txtChecked.Text = DateTime.Parse(tb.Rows[0]["NgayGiaoDich"].ToString()).ToShortDateString();
            }
            else
            {
                lbThanhToan.Text = "CHƯA THANH TOÁN";
                btnThanhToan.Visible = true;
                txtChecked.Visible = true;
                lbChecked.Visible = false;
                txtChecked.Visible = false;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string err = "Check";
            bool thanhtoan = action.ThanhToanTKT(txtMaSo.Text, manhanvien, DateTime.Today.ToShortDateString(), makhachhang, ref err);
            if (thanhtoan)
            {
                MessageBox.Show("Thanh toán thành công");
                LoadData(magiaodich);
            }
            else
            {
                MessageBox.Show(err, "Thanh toán thất bại, check lỗi");
            }
        }
    }
}
