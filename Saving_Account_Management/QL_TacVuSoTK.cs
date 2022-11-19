using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.Extensions;
using Saving_Account_Management.UserControl.TextBoxs;
using Saving_Account_Management.Utils;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Saving_Account_Management.Setting;

namespace Saving_Account_Management
{
    public partial class QL_TacVuSoTK : Form
    {
        private BS_DSSoTK action = new BS_DSSoTK();
        private BS_DSKhachHang actionKH = new BS_DSKhachHang();

        public QL_TacVuSoTK()
        {
            InitializeComponent();
            Load_Data();
        }
        private void Load_Data()
        {
            disable();
            dgv_SoTK.DataSource = action.LayDanhSachSoTK().Tables[0];
            // set lại độ dài và tên các cột
            string[] tenCotSoTK = new string[13] {
                "Mã sổ", "Ngày mở sổ", "Ngày đến hạn", "Ngày tất toán", "Mã chi nhánh",
                "Mã loại tiền", "Mã loại tiết kiệm", "Ngày lãi nhập gốc", "Kỳ trả lãi", "Hạn gửi góp",
                "Tình trạng sử dụng", "Ngày gửi góp tiếp theo","Ngày nhạn lãi định kỳ tiếp theo"
            };

            // Chỉnh độ rộng các cột Bảng SoTK
            DataGridViewUtils.FitColumnHeaderWidth(this.dgv_SoTK);
            DataGridViewUtils.SetName(this.dgv_SoTK, tenCotSoTK.ToList());
        }

        #region Đổ data lên thông tin khách hàng nếu khách hàng đã có
        private void fill_Data(DataTable dt)
        {
            txt_MaKH.Text = dt.Rows[0][0].ToString();
            txt_HoTen.Text = dt.Rows[0][1].ToString();
            dt_NgaySinh.Text = dt.Rows[0][2].ToString();
            txt_Sdt.Text = dt.Rows[0][3].ToString();
            txt_MaDinhDanh.Text = dt.Rows[0][4].ToString();
            dt_NgayCap.Text = dt.Rows[0][5].ToString();
            txt_NoiCap.Text = dt.Rows[0][6].ToString();
            txt_DiaChi.Text = dt.Rows[0][7].ToString();
            ptb_ChuKy.BackgroundImage = Image.FromStream(new MemoryStream((byte[])dt.Rows[0][9]));
            ptb_ChuKy.Refresh();
            if ((bool)dt.Rows[0][8] == true)
            {
                cb_TinhTrangSD.Checked = true;
            }
            else
            {
                cb_TinhTrangSD.Checked = false;
            }
        }
        #endregion

        private void dgv_SoTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgv_SoTK.CurrentCell.RowIndex;
            string maSoTK = dgv_SoTK.Rows[r].Cells[0].Value.ToString();
            dgv_SoHuu.DataSource = action.LayDanhSachChuSoHuu(maSoTK).Tables[0];

            string[] tenCotSoHuu = new string[3] {
                "Mã khách hàng", "Họ tên", "Mã định danh"
            };

            // Chỉnh độ rộng các cột Bảng SoHuu
            DataGridViewUtils.FitDataWidth(this.dgv_SoHuu);
            DataGridViewUtils.SetName(this.dgv_SoHuu, tenCotSoHuu.ToList());
        }

        private void btn_TKSo_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = action.TimKiemMaSoTK(txt_TKMaSo.Text);
            dgv_SoTK.DataSource = ds.Tables[0];
            dgv_SoTK.AutoResizeColumns();
        }

        private void btn_TKKhachHang_Click(object sender, EventArgs e)
        {
            DataSet ds = actionKH.TimKiemMaDinhDanh(txt_TKSoHuu.Text);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy mã dịnh danh '{txt_TKSoHuu.Text}' ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_TKSoHuu.Clear();
                txt_TKSoHuu.Focus();
            }
            else
            {
                fill_Data(dt);
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            enabled();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            foreach (var ctl in this.pnThemNguoiDongSoHuu.GetAllChildControl().OrderBy(u => u.TabIndex))
            {
                if (ctl is TextBoxValidationBase)
                {
                    var textBox = ctl as TextBoxValidationBase;
                    try
                    {
                        textBox.Validate(true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //truyền dữ liệu từ txtSua
            if (!File.Exists(openFileDialog1.FileName))
            {
                openFileDialog1.FileName = "";
            }
            DateTime ngayPhatSinhGiaoDich = DateTime.Now;
            string maNhanVien = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            string err = null;
            bool checkThem = action.ThemNguoiDongSoHuu(txt_MaSo.Text, ngayPhatSinhGiaoDich, maNhanVien, 
                                txt_HoTen.Text, dt_NgaySinh.Value, txt_Sdt.Text, txt_MaDinhDanh.Text, 
                                dt_NgayCap.Value, txt_NoiCap.Text, txt_DiaChi.Text, openFileDialog1.FileName, ref err);

            if (checkThem == true && err==null)
            {
                MessageBox.Show("Đã thêm khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTxt();
            }
            else
                MessageBox.Show("Nhập sai mã sổ "+ err, "Lỗi");

        }

        private void txt_Sdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txt_MaDinhDanh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ptb_ChuKy_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);
                ptb_ChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
                ptb_ChuKy.BackgroundImage = img;
            }
        }

        #region disable, enable, clear textbox
        private void disable()
        {
            this.txt_MaKH.Enabled = false;
            this.txt_MaSo.Enabled = false;
            this.txt_HoTen.Enabled = false;
            this.dt_NgayCap.Enabled = false;
            this.txt_Sdt.Enabled = false;
            this.txt_DiaChi.Enabled = false;
            this.txt_MaDinhDanh.Enabled = false;
            this.dt_NgaySinh.Enabled = false;
            this.txt_NoiCap.Enabled = false;
            this.cb_TinhTrangSD.Enabled = false;
            this.ptb_ChuKy.Enabled = false;
        }

        private void enabled()
        {
            this.txt_MaSo.Enabled = true;
            this.txt_HoTen.Enabled = true;
            this.dt_NgayCap.Enabled = true;
            this.txt_Sdt.Enabled = true;
            this.txt_DiaChi.Enabled = true;
            this.txt_MaDinhDanh.Enabled = true;
            this.dt_NgaySinh.Enabled = true;
            this.txt_NoiCap.Enabled = true;
            this.ptb_ChuKy.Enabled = true;
        }

        private void clearTxt()
        {
            txt_MaKH.Clear();
            txt_MaSo.Clear();
            this.txt_HoTen.Clear();
            this.dt_NgayCap.Value = DateTime.Now;
            this.txt_Sdt.Clear();
            this.txt_DiaChi.Clear();
            this.txt_MaDinhDanh.Clear();
            this.dt_NgaySinh.Value = DateTime.Now;
            this.txt_NoiCap.Clear();
            ptb_ChuKy.Refresh();
        }
        #endregion


    }
}
