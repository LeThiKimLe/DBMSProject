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
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_TKGG_MoSo : Form
    {
        BS_MoSoTKGG bl = new BS_MoSoTKGG();
        DataTable dt = null;
        string makh = "none";
        List<int> mangint = new List<int>();
        string error="Lỗi là : ";
        string err;
        string chuky;

        
        public QL_TKGG_MoSo()
        {
            InitializeComponent();           
            HienThongTin();
            textBox_MaKH.Enabled = false;
            textBox_hoten.Focus();
            textBox_masotietkiem.Enabled = false;
            textBox_ngaymoso.Enabled = false;
            textBox_laisuatcokyhan.Enabled = false;           
            textBox_ngayGGtieptheo.Enabled = false;
            textBox_ngaydenhang.Enabled = false;
            textBox_hinhthuctralai.Enabled = false;
        }
        void XoaTextbox()
        {
            textBox1.ResetText();
            textBox_diachi.ResetText();
            textBox_hoten.ResetText();
            textBox_madinhdanh.ResetText();
            textBox_sotiengui.ResetText();
            dateTimePicker_ngaycap.ResetText();
            textBox_sdt.ResetText();
            textBox_noicap.ResetText();
            dateTimePicker_ngaysinh.ResetText();
            if (pictureBox_chuky.BackgroundImage != null)
            {
                pictureBox_chuky.Refresh();
                pictureBox_chuky.BackgroundImage.Dispose();
                pictureBox_chuky.BackgroundImage = null;
            }    
           



        }
        List<int> timuoc(int A)
        {

            List<int> uoccuaA = new List<int>();
            for (int i = 1; i < A; i++)
            {
                if (A % i == 0)
                {
                    uoccuaA.Add(i);

                }
            }
            return uoccuaA;
        }
        void HienHanGuiGop()
        {

            int hanguigop;
            int.TryParse(comboBox_kyhan.Text, out hanguigop);
            if(hanguigop!=0)
            {
                mangint = timuoc(int.Parse(comboBox_kyhan.Text));
                comboBox_hanguigop.DataSource = mangint;

            }

        }
        void HienThongTin()
        {
            BS_MoSoTK1L b1 = new BS_MoSoTK1L();
            BS_MoSoTK1L b2 = new BS_MoSoTK1L();


            textBox_MaKH.Text = b1.get_MaKH();
            textBox_masotietkiem.Text = b1.get_MaSo();
            textBox_ngaymoso.Text = DateTime.Now.ToShortDateString();
            textBox_hinhthuctralai.Text = "Trả lãi sau";
            label_hienthichinhanh.Text = "BIDV Đông Sài Gòn";
            try
            {

                //Hiện loại tiền
                comboBox_loaitien.DataSource = b1.get_LoaiTien().Tables[0];
                comboBox_loaitien.DisplayMember = "LoaiTien";
                comboBox_loaitien.ValueMember = "MaLoaiTien";
                //Hiện kỳ hạn ban đầu
                comboBox_kyhan.Text="6";              
                HienLaiSuat();
                HienHanGuiGop();
                //Hiện kỳ hạn khi đổi giá trị
                comboBox_kyhan.DataSource = b2.get_KyHan("HTG_G", "HTTL_S").Tables[0];
                comboBox_kyhan.ValueMember = "KyHan";
            }
            catch (Exception m )
            {               
                MessageBox.Show(m.Message.ToString(), "Thông báo");                
            }

        }
        bool KiemTraNull()
        {
            if (textBox_hoten.Text == "")
            {
                MessageBox.Show("Chưa Nhập Tên Khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_hoten.Focus();
                return false;
            }
            else if (textBox_sdt.Text == "")
            {
                MessageBox.Show("Chưa Nhập số điện thoại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_sdt.Focus();
                return false;
            }
            else if (textBox_madinhdanh.Text == "")
            {
                MessageBox.Show("Chưa Nhập Mã Định Danh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_madinhdanh.Focus();
                return false;
            }
            else if (textBox_noicap.Text == "")
            {
                MessageBox.Show("Chưa Nhập Nơi cấp mã định danh", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_noicap.Focus();
                return false;
            }
            else if (textBox_diachi.Text == "")
            {
                MessageBox.Show("Chưa Nhập địa chỉ khách hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_diachi.Focus();
                return false;
            }
            else if (pictureBox_chuky.BackgroundImage == null)
            {
                MessageBox.Show("Chưa Chọn File Ảnh Chữ Ký", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return false;

            }
            else if (textBox_sotiengui.Text == "")
            {
                MessageBox.Show("Chưa Nhập Số Tiền Gửi Tiết Kiệm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_sotiengui.Focus();
                return false;
            }
            


            return true;
        }
        void KhongChoThacTac()
        {

            textBox_diachi.Enabled = false;
            textBox_hoten.Enabled = false;
            textBox_madinhdanh.Enabled = false;
            dateTimePicker_ngaycap.Enabled = false;
            textBox_sdt.Enabled = false;
            textBox_noicap.Enabled = false;
            dateTimePicker_ngaysinh.Enabled = false;
        }
        void ChoThaoTac()
        {
            textBox_diachi.Enabled = true;
            textBox_hoten.Enabled = true;
            textBox_madinhdanh.Enabled = true;
            dateTimePicker_ngaycap.Enabled = true;
            textBox_sdt.Enabled = true;
            textBox_noicap.Enabled = true;
            dateTimePicker_ngaysinh.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_timkiem_Click(object sender, EventArgs e)
        {
            try
            {


                dt = new DataTable();
                dt.Clear();
                DataSet dts = bl.LaySoTheoMaDinhDanh(textBox1.Text);
                dt = dts.Tables[0];


                textBox_MaKH.Text = dt.Rows[0][0].ToString();
                textBox_hoten.Text = dt.Rows[0][1].ToString();
                dateTimePicker_ngaysinh.Value = Convert.ToDateTime(dt.Rows[0][2].ToString());
                textBox_sdt.Text = dt.Rows[0][3].ToString();
                textBox_madinhdanh.Text = dt.Rows[0][4].ToString();
                dateTimePicker_ngaycap.Value = Convert.ToDateTime(dt.Rows[0][5].ToString());
                textBox_noicap.Text = dt.Rows[0][6].ToString();
                textBox_diachi.Text = dt.Rows[0][7].ToString();
                if (Convert.ToBoolean(dt.Rows[0][8].ToString()) == true)
                {
                    checkBox_dangsudung.Checked = true;
                }
                else
                {
                    checkBox_dangsudung.Checked = false;
                }
                this.pictureBox_chuky.BackgroundImage = Image.FromStream(new MemoryStream((byte[])dt.Rows[0][9]));

                textBox_sotiengui.Focus();
                KhongChoThacTac();
                makh = textBox_MaKH.Text;



            }
            catch (Exception m)
            {
                MessageBox.Show("Khách hàng chưa tồn tại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                XoaTextbox();

                
                
                makh = "none";

                textBox_hoten.Focus();
                ChoThaoTac();
                HienThongTin();

            }
        }

        private void gb_TKGG_MoSo_Enter(object sender, EventArgs e)
        {

        }
        private void Lay_ngayDenHan()
        {
            dt = new DataTable();
            dt.Clear();

            DataSet dts = bl.get_NgayDenHan(textBox_masotietkiem.Text);
            dt = dts.Tables[0];
            textBox_ngaydenhang.Text = DateTime.Parse((dt.Rows[0][0]).ToString()).ToShortDateString();
        }
        void HienLaiSuat()
        {
            int laisuat;
            int.TryParse(comboBox_kyhan.Text, out laisuat); //trả về giá trị false, a mang giá trị 0
            if (laisuat != 0)
            {
                DataTable b4 = new DataTable();
                b4.Clear();
                DataSet dts = bl.get_LaiSuat("HTG_G", "HTTL_S", laisuat);
                b4 = dts.Tables[0];
                textBox_laisuatcokyhan.Text = b4.Rows[0][0].ToString() + " %";
            }
        }

        private void comboBox_kyhan_SelectedValueChanged(object sender, EventArgs e)
        {

            HienLaiSuat();
            HienHanGuiGop();

        }
        void LayNgayGGTiepTheo()
        {
            dt = new DataTable();
            dt.Clear();

            DataSet dts = bl.get_NgayGGTiepTheo(textBox_masotietkiem.Text);
            dt = dts.Tables[0];
            textBox_ngaydenhang.Text = DateTime.Parse((dt.Rows[0][0]).ToString()).ToShortDateString();
        }
    

        private void button_moso_Click(object sender, EventArgs e)
        {
            if (KiemTraNull() == true)
            {

                string validPath = string.Empty;

                if (Uri.TryCreate(openFileDialog1.FileName, UriKind.Absolute, out Uri uri))
                {
                    validPath = uri.AbsolutePath;
                }
                else
                {
                    //throw new ArgumentException("Chưa Chọn ảnh");
                    validPath = "///";
                }

                BS_MoSoTKGG b4 = new BS_MoSoTKGG();
                b4.ThemSoTKGuiGop(makh, this.textBox_hoten.Text, this.dateTimePicker_ngaysinh.Text, textBox_sdt.Text,
                    this.textBox_madinhdanh.Text, this.dateTimePicker_ngaycap.Text.ToString(),
                    this.textBox_noicap.Text, this.textBox_diachi.Text, validPath,
                    float.Parse(this.textBox_sotiengui.Text), "NV005",
                    this.textBox_ngaymoso.Text, comboBox_loaitien.SelectedValue.ToString(),
                    Convert.ToInt32(this.comboBox_kyhan.Text), Convert.ToInt32(this.comboBox_hanguigop.Text), error, ref err);

                MessageBox.Show("Mở Sổ Thành Công");
                Lay_ngayDenHan();
                LayNgayGGTiepTheo();




            }
           
        }

        private void pictureBox_chuky_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                // Lấy hình ảnh
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureBox_chuky.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox_chuky.BackgroundImage = img;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XoaTextbox();
            HienThongTin();
            ChoThaoTac();
        }
    }
}
