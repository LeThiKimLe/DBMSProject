using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.UserControl.TextBoxs;
using System.IO;
using Saving_Account_Management.Extensions;
using System.Linq;

namespace Saving_Account_Management
{
    public partial class QL_TacVuKH : Form
    {
        private BS_DSKhachHang action = new BS_DSKhachHang();
        public QL_TacVuKH()
        {
            InitializeComponent();
            disable();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            foreach (var ctl in this.pnSuaThongTinKhachHang.GetAllChildControl().OrderBy(u => u.TabIndex))
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
            if (!File.Exists(openFileDialogChuKy.FileName))
            {
                openFileDialogChuKy.FileName = "";
            }
            action.SuaKhachHang(txtS_MaKH.Text, txtS_HoTen.Text, txtS_Sdt.Text, txtS_DiaChi.Text, 
                                txtS_MaDinhDanh.Text, txtS_NoiCap.Text, dt_NgaySinh.Text.ToString(), 
                                dt_NgayCap.Text.ToString(), openFileDialogChuKy.FileName);
            MessageBox.Show("Sửa thông tin khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Load lại data đã sửa
            DataSet ds = action.TimKiemMaDinhDanh(txt_TimKiem.Text);
            DataTable dt = ds.Tables[0];
            refesh_Data(dt);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            // TODO: nhớ check lại
            DataSet ds = action.TimKiemMaDinhDanh(txt_TimKiem.Text);
            DataTable dt = ds.Tables[0];

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show($"Không tìm thấy mã dịnh danh '{txt_TimKiem.Text}' ", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txt_TimKiem.Clear();
                txt_TimKiem.Focus();
            }
            else
            { 
                refesh_Data(dt);
                refesh_DataUpData(dt);
            }
        }

        private void ptb_ChuKy_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialogChuKy.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialogChuKy.FileName);
                ptbS_ChuKy.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbS_ChuKy.BackgroundImage = img;
            }
        }
        
        #region làm mới dữ liệu tại 2 bảng thông tin cũ và mới

        private void refesh_Data(DataTable dt)
        {
            txt_MaKH.Text = dt.Rows[0][0].ToString();
            txt_HoTen.Text = dt.Rows[0][1].ToString();
            txt_NgaySinh.Text = dt.Rows[0][2].ToString();
            txt_Sdt.Text = dt.Rows[0][3].ToString();
            txt_MaDinhDanh.Text = dt.Rows[0][4].ToString();
            txt_NgayCap.Text = dt.Rows[0][5].ToString();
            txt_NoiCap.Text = dt.Rows[0][6].ToString();
            txt_DiaChi.Text = dt.Rows[0][7].ToString();
            ptb_Chuky.BackgroundImage = Image.FromStream(new MemoryStream((byte[])dt.Rows[0][9]));
            ptb_Chuky.Refresh();
            if ((bool)dt.Rows[0][8] == true)
            {
                cb_TinhTrangSD.Checked = true;
            }
            else
            {
                cb_TinhTrangSD.Checked = false;
            }
        }

        private void refesh_DataUpData(DataTable dt)
        {
            txtS_MaKH.Text = dt.Rows[0][0].ToString();
            txtS_HoTen.Text = dt.Rows[0][1].ToString();
            txtS_Sdt.Text = dt.Rows[0][3].ToString();
            txtS_MaDinhDanh.Text = dt.Rows[0][4].ToString();
            txtS_NoiCap.Text = dt.Rows[0][6].ToString();
            txtS_DiaChi.Text = dt.Rows[0][7].ToString();
            dt_NgaySinh.Value = DateTime.Parse(dt.Rows[0][2].ToString());
            dt_NgayCap.Value = DateTime.Parse(dt.Rows[0][5].ToString());
            ptbS_ChuKy.BackgroundImage = Image.FromStream(new MemoryStream((byte[])dt.Rows[0][9]));
            ptbS_ChuKy.Refresh();
            if ((bool)dt.Rows[0][8] == true)
            {
                cbS_TinhTrangSD.Checked = true;
            }
            else
            {
                cbS_TinhTrangSD.Checked = false;
            }
        }
        #endregion

        #region không cho nhập lên các textbox show
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
            this.cb_TinhTrangSD.Enabled = false;
            // không sửa được mã khách hàng
            this.txtS_MaKH.Enabled = false;
        }
        #endregion

        // sự kiện enter
        private void txt_TimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_TimKiem_Click(sender, e);
            }
        }

        private void txtS_NoiCap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Luu_Click(sender, e);
            }
        }

    }
}
