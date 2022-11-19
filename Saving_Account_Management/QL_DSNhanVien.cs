using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using Saving_Account_Management.BS_Layer;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_DSNhanVien : Form
    {
        DataTable dt = null;
        bool Them;
        string err;

        BS_DSNhanVien dssv = new BS_DSNhanVien();
       
        public QL_DSNhanVien()
        {
            InitializeComponent();
            maNV_tb.Enabled = false;
            BS_DSNhanVien b1 = new BS_DSNhanVien();
            comboBox_timtheoCN.DataSource = b1.get_MaChiNhanh().Tables[0];
            comboBox_timtheoCN.DisplayMember = "TenChiNhanh";
            comboBox_timtheoCN.ValueMember = "MaChiNhanh";
            comboBox_timtheoCN.Text = "";
            
            


            LoadData();
        }
        void LoadData()
        {
            try
            {
                DataTable dt = null;

                dt = new DataTable();
                dt.Clear();
                DataSet dts = dssv.Get_DSSinhVien();
                dt= dts.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dataGridView_NV.DataSource = dt;
                // Thay đổi độ rộng cột 
                dataGridView_NV.AutoResizeColumns();
               
                XoaDuLieu();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.save_btn.Enabled = false;
                panel1.Enabled = false;
                
                
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.save_btn.Enabled = true;
                this.fix_btn.Enabled = false;
                this.DeleteNV_btn.Enabled = false;


            }
            catch (Exception)
            {
                MessageBox.Show("Không lấy được nội dung. Lỗi rồi!!!");
            }
        }
        //void khongchothaotac()
        //{
        //    tenNV_tb.Enabled = false;
        //    maNV_tb.Enabled = false;
        //    sdtNV_tb.Enabled = false;
        //    comboBox_machinhanh.Enabled = false;
        //    cmndNV_tb.Enabled = false;

        //}
        private void label12_Click(object sender, EventArgs e)
        {

        }
        void HienThongTin()
        {
            BS_DSNhanVien b1 = new BS_DSNhanVien();
            maNV_tb.Text = b1.get_MaNV();
            Hienchinhanh();
            HienChucVu();
        }
        void Hienchinhanh()
        {
            BS_DSNhanVien b1 = new BS_DSNhanVien();
            comboBox_machinhanh.DataSource = b1.get_MaChiNhanh().Tables[0];
            comboBox_machinhanh.DisplayMember = "TenChiNhanh";
            comboBox_machinhanh.ValueMember = "MaChiNhanh";
        }

        void XoaDuLieu()
        {
            this.maNV_tb.ResetText();
            this.tenNV_tb.ResetText();
            this.sdtNV_tb.ResetText();           
            this.cmndNV_tb.ResetText();
            comboBox_machinhanh.Text = "";

        }

        void HienChucVu()
        {
            BS_DSNhanVien b1 = new BS_DSNhanVien();
            cbbChucVu.DataSource = b1.get_ChucVu().Tables[0];
            cbbChucVu.DisplayMember = "TenNhom";
            cbbChucVu.ValueMember = "MaNhomNguoiDung";
        }

        private void dataGridView_NV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dataGridView_NV.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            if (dataGridView_NV.Rows[r].Cells[0].Value != null)
            {
                this.maNV_tb.Text = dataGridView_NV.Rows[r].Cells[2].Value.ToString();
                this.tenNV_tb.Text = dataGridView_NV.Rows[r].Cells[0].Value.ToString();
                this.sdtNV_tb.Text = dataGridView_NV.Rows[r].Cells[4].Value.ToString();
                this.comboBox_machinhanh.Text = dataGridView_NV.Rows[r].Cells[6].Value.ToString();
                this.cmndNV_tb.Text = dataGridView_NV.Rows[r].Cells[1].Value.ToString();
                this.dateTimePicker_ngaysinh.Value= Convert.ToDateTime(dataGridView_NV.Rows[r].Cells[3].Value.ToString());
                this.comboBox_machinhanh.Text = dataGridView_NV.Rows[r].Cells[6].Value.ToString();
                this.cbbChucVu.Text = dataGridView_NV.Rows[r].Cells[7].Value.ToString();

            }
            // Không cho thao tác trên các nút Lưu / Hủy 
            this.save_btn.Enabled = false;
            AddNV_btn.Enabled = true;

            // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
            fix_btn.Enabled = true;
            DeleteNV_btn.Enabled = true;
           
            
            Them = false;

        }

        private void AddNV_btn_Click(object sender, EventArgs e)
        {
            Them = true;
            dataGridView_NV.Enabled = false;
            this.panel1.Enabled = true;
            // Xóa trống các đối tượng trong Panel 
            XoaDuLieu();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.save_btn.Enabled = true;
            this.button_huy.Enabled = true;
            
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.AddNV_btn.Enabled = false;
            this.fix_btn.Enabled = false;
            this.DeleteNV_btn.Enabled = false;
            
            // Đưa con trỏ đến TextField txtThanhPho 
            this.tenNV_tb.Focus();
            
            HienThongTin();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BS_DSNhanVien dssv = new BS_DSNhanVien();
                    dssv.ThemNhanVien(this.tenNV_tb.Text,this.dateTimePicker_ngaysinh.Value.ToString(),cmndNV_tb.Text,sdtNV_tb.Text,comboBox_machinhanh.SelectedValue.ToString(),cbbChucVu.SelectedValue.ToString(),ref err);
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã thêm nhân viên thành công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                catch (SqlException err)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!\n"+ err.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Thực hiện lệnh 
                BS_DSNhanVien dssv = new BS_DSNhanVien();
                dssv.SuaNhanVien(this.maNV_tb.Text, this.tenNV_tb.Text, this.dateTimePicker_ngaysinh.Value.ToString(), cmndNV_tb.Text, sdtNV_tb.Text, comboBox_machinhanh.SelectedValue.ToString(), ref err);
                // Load lại dữ liệu trên DataGridView 
                LoadData();
                // Thông báo 
                MessageBox.Show("Đã sửa thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Đóng kết nối
            dataGridView_NV.Enabled = true;
            AddNV_btn.Enabled = true;

        }

        private void fix_btn_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            dataGridView_NV.Enabled = false;
            // Cho phép thao tác trên Panel 
            this.panel1.Enabled = true;
          //  dataGridView_NV_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.save_btn.Enabled = true;
            this.button_huy.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.AddNV_btn.Enabled = false;
            this.fix_btn.Enabled = false;
            this.DeleteNV_btn.Enabled = false;


            // Đưa con trỏ đến TextField txtMaKH 

            Hienchinhanh();
            this.tenNV_tb.Focus();
        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            XoaDuLieu();
            dataGridView_NV.Enabled = true;
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.AddNV_btn.Enabled = true;
           // this.fix_btn.Enabled = true;
            this.DeleteNV_btn.Enabled = true;
            fix_btn.Enabled = false;

            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.save_btn.Enabled = false;
            this.button_huy.Enabled = false;
            this.panel1.Enabled = false;
        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            DataSet dts = dssv.get_TimKiem(comboBox_timtheoCN.SelectedValue.ToString());
            dt = dts.Tables[0];
            // Đưa dữ liệu lên DataGridView 
            dataGridView_NV.DataSource = dt;
            // Thay đổi độ rộng cột 
            dataGridView_NV.AutoResizeColumns();
        }

        private void DeleteNV_btn_Click(object sender, EventArgs e)
        {
            string err = null;
            DialogResult xacnhanXoa = MessageBox.Show("Chắc chắn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (xacnhanXoa == DialogResult.Yes)
            {
                bool thuchien=dssv.XoaNhanVien(this.maNV_tb.Text, ref err);
                if (thuchien)
                {
                    MessageBox.Show("Xóa thành công nhân viên", "Đã thực hiện");
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại\n" + err, "Lỗi");
                }
            }
        }
    }
}
