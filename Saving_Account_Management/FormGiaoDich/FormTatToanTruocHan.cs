﻿using System;
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
    public partial class FormTatToanTruocHan : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();
        private string makhachhang = null;
        private string manhanvien = null;
        private string magiaodich = null;
        DataTable tb = null;
        public FormTatToanTruocHan()
        {
            InitializeComponent();
        }

        public FormTatToanTruocHan(string maGiaoDich, string MaKhachHang, string MaNhanVien, bool guigop=false)
        {
            InitializeComponent();
            makhachhang = MaKhachHang;
            manhanvien = MaNhanVien;
            magiaodich = maGiaoDich;
            if (guigop == false)
                LoadData_So1Lan(magiaodich);
            else
                LoadData_SoGuiGop(magiaodich);

        }

        private void LoadData_So1Lan(string maGiaoDich)
        {

            tb = action.get_Chitiet_GiaoDichTatToanTruocHanSo1Lan(maGiaoDich).Tables[0];
            
            txtHoTenKH.Text = tb.Rows[0]["HoTenKH"].ToString();
            txtMaDN.Text = tb.Rows[0]["MaDinhDanh"].ToString();

            txtMaSo.Text = tb.Rows[0]["MaSoTK"].ToString();
            txtGoc.Text = tb.Rows[0]["SoDu"].ToString();
            txtTru.Text = tb.Rows[0]["KhauTru"].ToString();
            txtLoaiTien.Text = tb.Rows[0]["MaLoaiTien"].ToString();
            txtSoTien.Text = tb.Rows[0]["TongTien"].ToString();

            txtHoTenNV.Text = tb.Rows[0]["HoTenNV"].ToString();
            txtMaNV.Text = tb.Rows[0]["MaNhanVien"].ToString();

            lbThanhToan.Text = "ĐÃ THANH TOÁN";
            btnThanhToan.Visible = false;
            lbChecked.Visible = true;
            txtChecked.Visible = true;
            txtChecked.Text = DateTime.Parse(tb.Rows[0]["NgayGiaoDich"].ToString()).ToShortDateString();
            
        }

        private void LoadData_SoGuiGop(string maGiaoDich)
        {

            tb = action.get_Chitiet_GiaoDichTatToanTruocHanSoGuiGop(maGiaoDich).Tables[0];

            txtTru.Text = "0";

            if (tb.Rows[0]["HoTenKH"].ToString() == "")
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

            txtMaSo.Text = tb.Rows[0]["MaSoTK"].ToString();
            txtGoc.Text = tb.Rows[0]["SoDu"].ToString();
            
            txtLoaiTien.Text = tb.Rows[0]["MaLoaiTien"].ToString();
            txtSoTien.Text = tb.Rows[0]["SoDu"].ToString();
            bool tinhTrang;
            tinhTrang = bool.Parse(tb.Rows[0]["tinhTrang"].ToString());

            if (tinhTrang == true)
            {
                lbThanhToan.Text = "ĐÃ THANH TOÁN";
                btnThanhToan.Visible = false;
                lbChecked.Visible = true;
                txtChecked.Visible = true;
                txtChecked.Text = DateTime.Parse(tb.Rows[0]["ngayGiaoDich"].ToString()).ToShortDateString();
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
            bool thanhtoan = action.XacNhanTatToanTruocHan(txtMaSo.Text, manhanvien, DateTime.Today.ToShortDateString(), makhachhang, ref err);

            if (thanhtoan)
            {
                MessageBox.Show("Thanh toán thành công");
                LoadData_SoGuiGop(magiaodich);
            }
            else
                MessageBox.Show("Thanh toán thất bại, check lỗi " + err, "Thất bại");
        }
    }
}
