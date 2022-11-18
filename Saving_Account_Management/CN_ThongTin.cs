using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.Setting;
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
    public partial class CN_ThongTin : Form
    {
        BS_DanhMuc action = new BS_DanhMuc();
        public CN_ThongTin()
        {
            InitializeComponent();
            ThongTin_Load();
        }

        private void ThongTin_Load()
        {
            text_MaNV.Text = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            text_HoTen.Text = action.LayHoTen().Tables[0].Rows[0].ItemArray[0].ToString();
            AppSettingSingleton.getSetting().CurrentTenhanVien = text_HoTen.Text;
            text_NgaySinh.Text = DateTime.Parse(action.LayNgaySinh().Tables[0].Rows[0].ItemArray[0].ToString()).ToShortDateString();
            text_MaDinhDanh.Text = action.LayMaDinhDanh().Tables[0].Rows[0].ItemArray[0].ToString();
            text_SDT.Text = action.LaySDT().Tables[0].Rows[0].ItemArray[0].ToString();
            text_DiaChiCN.Text = action.LayChiNhanh().Tables[0].Rows[0].ItemArray[0].ToString();
            txtChucVu.Text = action.LayChucVu(text_MaNV.Text).Tables[0].Rows[0][0].ToString();

        }
        private void CN_ThongTin_Load(object sender, EventArgs e)
        {
            /*text_MaNV.Text = action.LayMaNhanVien().Tables[0].Rows[0].ItemArray[0].ToString();*/
        }


    }
}
