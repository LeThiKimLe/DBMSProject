using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using Saving_Account_Management.BS_Layer;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_DSKhachHang : Form
    {
        private BS_DSKhachHang action = new BS_DSKhachHang();
        public QL_DSKhachHang()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            dgv_KhachHang.DataSource = action.LayDanhSachKhachHang().Tables[0];
            disable();
            rdb_TimKiemMa.Checked = true;
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (rdb_TimKiemMa.Checked == true)
            {
                ds = action.TimKiem("MaKhachHang", txt_TimKiem.Text);
            }
            else if (rdb_TimKiemTen.Checked == true)
            {
                ds = action.TimKiem("HoTen", txt_TimKiem.Text);
            }
            else
            {
                ds = action.TimKiem("MaDinhDanh", txt_TimKiem.Text);
            }
            dgv_KhachHang.DataSource = ds.Tables[0];
            dgv_KhachHang.AutoResizeColumns();

        }

        private void dgv_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgv_KhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txt_MaKH.Text = dgv_KhachHang.Rows[r].Cells[0].Value.ToString();
            this.txt_HoTen.Text = dgv_KhachHang.Rows[r].Cells[1].Value.ToString();
            this.txt_NgaySinh.Text = dgv_KhachHang.Rows[r].Cells[2].Value.ToString();
            this.txt_Sdt.Text = dgv_KhachHang.Rows[r].Cells[3].Value.ToString();
            this.txt_MaDinhDanh.Text = dgv_KhachHang.Rows[r].Cells[4].Value.ToString();
            this.txt_NgayCap.Text = dgv_KhachHang.Rows[r].Cells[5].Value.ToString();
            this.txt_NoiCap.Text = dgv_KhachHang.Rows[r].Cells[6].Value.ToString();
            this.txt_DiaChi.Text = dgv_KhachHang.Rows[r].Cells[7].Value.ToString();
            this.ptbChuky.BackgroundImage = Image.FromStream(new MemoryStream((byte[])dgv_KhachHang.Rows[r].Cells[9].Value));

            if ((bool)dgv_KhachHang.Rows[r].Cells[8].Value == true)
            {
                cb_TinhTrangSD.Checked = true;
            }
            else
            {
                cb_TinhTrangSD.Checked = false;
            }
        }

        private void disable()
        {
            this.txt_MaKH.Enabled = false;
            this.txt_HoTen.Enabled = false;
            this.txt_NgaySinh.Enabled = false;
            this.txt_Sdt.Enabled = false;
            this.txt_DiaChi.Enabled = false;
            this.txt_MaDinhDanh.Enabled = false;
            this.txt_NgayCap.Enabled = false;
            this.txt_NoiCap.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
