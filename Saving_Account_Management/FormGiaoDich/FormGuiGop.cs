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
    public partial class FormGuiGop : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();
        private string makhachhang = null;
        private string manhanvien = null;
        private string magiaodich = null;
        DataTable tb = null;
        public FormGuiGop()
        {
            InitializeComponent();
        }
        public FormGuiGop(string maGiaoDich, string MaNhanVien, string MaKhachHang)
        {
            InitializeComponent();
            makhachhang = MaKhachHang;
            manhanvien = MaNhanVien;
            magiaodich = maGiaoDich;
            LoadData(magiaodich);
        }
        public FormGuiGop(string MaNhanVien, string MaKhachHang, string MaSo = "", string TenKH = "", string MaDD = "", string TenNV = "")
        {
            InitializeComponent();
            makhachhang = MaKhachHang;
            manhanvien = MaNhanVien;
            GhiNhanGuiGop(MaSo, TenKH, MaDD, TenNV, MaNhanVien);
        }

        private void LoadData(string maGiaoDich)
        {
            txtGuiThem.ReadOnly = true;
            lbThanhToan.Visible = true;
            lbNgayGD.Visible = true;
            txtGiaoDich.Visible = true;

            tb = action.get_Chitiet_GiaoDichGuiGop(maGiaoDich).Tables[0];

            txtHoTenKH.Text = tb.Rows[0]["HoTenKH"].ToString();
            txtMaDN.Text = tb.Rows[0]["MaDinhDanh"].ToString();

            txtMaSo.Text = tb.Rows[0]["MaSoTK"].ToString();
            txtLoaiTien.Text = tb.Rows[0]["LoaiTien"].ToString();

            txtSoDuHT.Text = tb.Rows[0]["SoDuTruoc"].ToString();
            txtGuiThem.Text = tb.Rows[0]["SoGuiThem"].ToString();
            txtSoDuMoi.Text = tb.Rows[0]["SoDuMoi"].ToString();
            txtLaiKyTruoc.Text = tb.Rows[0]["LaiKyTruoc"].ToString();

            txtHoTenNV.Text = tb.Rows[0]["HoTenNV"].ToString();
            txtMaNV.Text = tb.Rows[0]["MaNhanVien"].ToString();

            lbThanhToan.Text = "ĐÃ THANH TOÁN";
            btnThanhToan.Visible = false;

            txtGiaoDich.Text = DateTime.Parse(tb.Rows[0]["NgayGiaoDich"].ToString()).ToShortDateString();

        }
        private void GhiNhanGuiGop(string MaSo, string HoTenKH, string MaDD, string HoTenNV, string MaNV)
        {
            lbThanhToan.Visible = false;
            lbNgayGD.Visible = false;
            txtGiaoDich.Visible = false;

            txtHoTenKH.Text = HoTenKH;
            txtMaDN.Text = MaDD;
            txtHoTenNV.Text = HoTenNV;
            txtMaNV.Text = MaNV;
            txtGuiThem.ReadOnly = false;
            txtMaSo.Text = MaSo;
            tb=action.get_Chitiet_LayThongTinSoGuiGop(txtMaSo.Text).Tables[0];
            txtLoaiTien.Text = tb.Rows[0]["LoaiTien"].ToString();
            txtSoDuHT.Text = tb.Rows[0]["SoDuTruoc"].ToString();
            txtLaiKyTruoc.Text = tb.Rows[0]["LaiDaPhatSinh"].ToString();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string err="";
            string maGD=null;
            decimal sotien;

            if (txtGuiThem.Text != "" && Decimal.TryParse(txtGuiThem.Text, out sotien) == true)
            {
                //maGD = action.GiaoDichGuiGop(txtMaSo.Text, txtGuiThem.Text, DateTime.Today.ToString(), manhanvien, makhachhang, ref err);
                maGD = action.GiaoDichGuiGop(txtMaSo.Text, txtGuiThem.Text, "2022-11-15", manhanvien, makhachhang, ref err);

                if (maGD != null)
                {
                    MessageBox.Show("Thực hiện gửi góp thành công", "Giao dịch thành công");
                    LoadData(maGD);
                }
                else
                {
                    MessageBox.Show("Lỗi " + err, "Thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số tiền hợp lệ", "Lưu ý");
            }
        }
    }
}
