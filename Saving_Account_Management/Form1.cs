using Saving_Account_Management.DB_Layer;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Saving_Account_Management
{
    public partial class Form1 : Form
    {
        DB_Connect db = null;

        private GroupBox my_work = new GroupBox();
        public Form1()
        {

            db = new DB_Connect();
            InitializeComponent();
            task_screen.Controls.Add(my_work);
            task_screen2.Controls.Add(my_work);
            
            task_screen4.Controls.Add(my_work);
        }

        private void materialTabSelector2_Click(object sender, EventArgs e)
        {

        }

        private void button42_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button47_Click(object sender, EventArgs e)
        {

        }

        private void btn_QLQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_Quyen new_win = new QL_Quyen();
                my_work = new_win.gb_QLQuyen;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btn_QLNhomNguoiDung_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_NhomNguoiDung new_win = new QL_NhomNguoiDung();
                my_work = new_win.gb_NhomNguoiDung;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();

            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }


        private void btn_QLPhanNhom_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_PhanNhom new_win = new QL_PhanNhom();
                my_work = new_win.gb_PhanNhom;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }

        private void btn_QLPhanQuyen_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_PhanQuyen new_win = new QL_PhanQuyen();
                my_work = new_win.gb_PhanQuyen;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TKDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TKDangNhap new_win = new QL_TKDangNhap();
                my_work = new_win.gb_TKDangNhap;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }

        private void btn_QLDSNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_DSNhanVien new_win = new QL_DSNhanVien();
                my_work = new_win.gb_DSNhanVien;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();

            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }

        private void btn_DSSoTK_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_DSSoTK new_win = new QL_DSSoTK();
                my_work = new_win.gb_DSSoTK;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }

        private void btn_QLTacVuSoTK_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TacVuSoTK new_win = new QL_TacVuSoTK();
                my_work = new_win.gb_TacVuSoTK;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TK1L_MoSo_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TK1L_MoSo new_win = new QL_TK1L_MoSo();
                my_work = new_win.gb_TK1L_MoSo;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }
        private void btn_TK1L_TBGiaHan_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TK1L_TBGiaHan new_win = new QL_TK1L_TBGiaHan();
                my_work = new_win.gb_TK1L_TBGiaHan;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TKGG_MoSo_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TKGG_MoSo new_win = new QL_TKGG_MoSo();
                my_work = new_win.gb_TKGG_MoSo;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TKGG_GiaoDichTK_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TKGG_GiaoDichTK new_win = new QL_TKGG_GiaoDichTK();
                my_work = new_win.gb_TKGG_GiaoDichTK;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TKGG_TBDenHan_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TKGG_TBDenHan new_win = new QL_TKGG_TBDenHan();
                my_work = new_win.gb_TKGG_TBDenHan;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_QLDSKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_DSKhachHang new_win = new QL_DSKhachHang();
                my_work = new_win.gb_DSKhachHang;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_QLTacVuKH_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TacVuKH new_win = new QL_TacVuKH();
                my_work = new_win.gb_TacVuKH;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_DMLoaiTien_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen2.Controls.Remove(my_work);
                DM_LoaiTien new_win = new DM_LoaiTien();
                my_work = new_win.gb_DMLoaiTien;
                task_screen2.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_DMLaiTietKiem_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen2.Controls.Remove(my_work);
                DM_LaiTietKiem new_win = new DM_LaiTietKiem();
                my_work = new_win.gb_DMLaiTietKiem;
                task_screen2.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_DMLoaiGiaoDich_Click(object sender, EventArgs e)
        {
            try
            {

                task_screen2.Controls.Remove(my_work);
                DM_LoaiGiaoDich new_win = new DM_LoaiGiaoDich();
                my_work = new_win.gb_DMLoaiGiaoDich;
                task_screen2.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_DMChiNhanh_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen2.Controls.Remove(my_work);
                DM_ChiNhanh new_win = new DM_ChiNhanh();
                my_work = new_win.gb_DMChiNhanh;
                task_screen2.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }

        }

        private void btn_CNThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen4.Controls.Remove(my_work);
                CN_ThongTin new_win = new CN_ThongTin();
                my_work = new_win.gb_CNThongTin;
                task_screen4.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_TK1L_GiaoDichTK_Click(object sender, EventArgs e)
        {
            try
            {
                task_screen.Controls.Remove(my_work);
                QL_TK1L_GiaoDichTK new_win = new QL_TK1L_GiaoDichTK();
                my_work = new_win.gb_TK1L_GiaoDichTK;
                task_screen.Controls.Add(my_work);
                my_work.Dock = DockStyle.Fill;
                my_work.BringToFront();
            }
            catch (SqlException err)
            {
                MessageBox.Show("Người dùng không có quyền truy cập chức năng này\n" + err.Message, "Lỗi truy cập");
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn đăng xuất ?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                FormDangNhap from = new FormDangNhap();
                from.ShowDialog();
            }

        }
    }
}
