using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Saving_Account_Management.Setting;
using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.FormGiaoDich;
using System.IO;

namespace Saving_Account_Management
{
    public partial class QL_TK1L_GiaoDichTK : Form
    {
        private BS_TK1L_GiaoDichTK action = new BS_TK1L_GiaoDichTK();
        string makhachhang = null;
        string manhanvien = null;
        string tennhanvien = null;
        public QL_TK1L_GiaoDichTK()
        {
            InitializeComponent();
            manhanvien = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            tennhanvien = AppSettingSingleton.getSetting().CurrentTenhanVien;
        }

        private void button_hienso_Click(object sender, EventArgs e)
        {
            makhachhang = txtMaDinhDanh.Text;
            dgv_DSSo.AutoResizeColumns();
            dgv_DSSo.DataSource = action.get_DS_So(makhachhang).Tables[0];
        }

        private void dgv_DSSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_DSSo.CurrentCell.RowIndex;
            gbChiTiet.Visible = true;
            gbChiTiet.BringToFront();

            lbOption.Visible = true;
            txtOption.Visible = true;
            lbOption2.Visible = true;
            txtOption2.Visible = true;
            lbDenHan.Visible = true;
            txtDenHan.Visible = true;
            lbThang.Visible = true;
                
            if (dgv_DSSo.Rows.Count != 0)
            {
                txtMaSo.Text = dgv_DSSo.Rows[r].Cells["MaSoTK"].Value.ToString();

                txtMoSo.Text = DateTime.Parse(dgv_DSSo.Rows[r].Cells["NgayMoSo"].Value.ToString()).ToShortDateString();
                
                if (dgv_DSSo.Rows[r].Cells["NgayDenHan"].Value.ToString()!="")
                    txtDenHan.Text = DateTime.Parse(dgv_DSSo.Rows[r].Cells["NgayDenHan"].Value.ToString()).ToShortDateString();
                else
                {
                    lbDenHan.Visible = false;
                    txtDenHan.Visible = false;
                }    
                txtHoTen.Text = dgv_DSSo.Rows[r].Cells["HoTen"].Value.ToString();
                txtMaKH.Text = dgv_DSSo.Rows[r].Cells["MaKhachHang"].Value.ToString();
                txtMaDN.Text = dgv_DSSo.Rows[r].Cells["MaDinhDanh"].Value.ToString();
                txtNgaySinh.Text = DateTime.Parse(dgv_DSSo.Rows[r].Cells["NgaySinh"].Value.ToString()).ToShortDateString();
                txtDiaChi.Text = dgv_DSSo.Rows[r].Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = dgv_DSSo.Rows[r].Cells["SDT"].Value.ToString();
                txtChiNhanh.Text = dgv_DSSo.Rows[r].Cells["TenChiNhanh"].Value.ToString();
                txtLoaiTien.Text = dgv_DSSo.Rows[r].Cells["MaLoaiTien"].Value.ToString();
                txtHinhThucGui.Text = dgv_DSSo.Rows[r].Cells["TenHinhThucGui"].Value.ToString();
                txtTralai.Text = dgv_DSSo.Rows[r].Cells["tenHinhThucTraLai"].Value.ToString();

                if (dgv_DSSo.Rows[r].Cells["KyHan"].Value.ToString() != "0")
                    txtKyHan.Text = dgv_DSSo.Rows[r].Cells["KyHan"].Value.ToString();
                else
                {
                    txtKyHan.Text = "Không kỳ hạn";
                    lbThang.Visible = false;
                }

                if (dgv_DSSo.Rows[r].Cells["KyTraLai"].Value.ToString() != "")
                {
                    lbOption.Text = "Kỳ trả lãi";
                    txtOption.Text = dgv_DSSo.Rows[r].Cells["KyTraLai"].Value.ToString() + " tháng";
                }

                else if (dgv_DSSo.Rows[r].Cells["HanGuiGop"].Value.ToString() != "")
                {
                    lbOption.Text = "Hạn gửi góp";
                    txtOption.Text = dgv_DSSo.Rows[r].Cells["HanGuiGop"].Value.ToString() + " tháng";
                }
                else
                {
                    lbOption.Visible = false;
                    txtOption.Visible = false;
                }

                if (dgv_DSSo.Rows[r].Cells["LaiSuat"].Value.ToString() != "")
                    txtLaiSuat.Text = dgv_DSSo.Rows[r].Cells["LaiSuat"].Value.ToString();

                if (dgv_DSSo.Rows[r].Cells["NgayGuiGopTiepTheo"].Value.ToString() != "")
                {
                    lbOption2.Text = "Ngày gửi góp tiếp theo";
                    txtOption2.Text = DateTime.Parse(dgv_DSSo.Rows[r].Cells["NgayGuiGopTiepTheo"].Value.ToString()).ToShortDateString();
                }

                else if (dgv_DSSo.Rows[r].Cells["NgayNhanLaiDinhKyTiepTheo"].Value.ToString() != "")
                {
                    lbOption2.Text = "Ngày nhận lãi định kỳ tiếp theo";
                    txtOption2.Text = DateTime.Parse(dgv_DSSo.Rows[r].Cells["NgayNhanLaiDinhKyTiepTheo"].Value.ToString()).ToShortDateString();
                }

                else
                {
                    lbOption2.Visible = false;
                    txtOption2.Visible = false;
                }
                dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];

                if (txtHinhThucGui.Text == "Gửi góp")
                    btnGuiGop.Enabled = true;

                if (dgv_DSSo.Rows[r].Cells["TinhTrangSuDung"].Value.ToString() == "False")
                {
                    btnTatToan.Enabled = false;
                    btnGuiGop.Enabled = false;
                }
                else
                    btnTatToan.Enabled = true;
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_LichSuGD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgv_LichSuGD.CurrentCell.RowIndex;
            string loaigiaodich;
            if (dgv_LichSuGD.Rows.Count != 0)
            {
                loaigiaodich = dgv_LichSuGD.Rows[r].Cells[1].Value.ToString();
                if (loaigiaodich == "GD_GTTK")
                {
                    FormGiaoDichLanDau f1 = new FormGiaoDichLanDau(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString());
                    f1.ShowDialog();
                }

                if (loaigiaodich == "GD_RLDK")
                {
                    FormRutLaiDinhKy f2 = new FormRutLaiDinhKy(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                    f2.ShowDialog();
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_RLS")
                {
                    FormRutLaiSau f3 = new FormRutLaiSau(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                    f3.ShowDialog();
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_RLT")
                {
                    FormRutLaiTruoc f4 = new FormRutLaiTruoc(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                    f4.ShowDialog();
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_RLTH")
                {
                    FormRutLaiTruocHan f5 = new FormRutLaiTruocHan(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                    f5.ShowDialog();
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_TTTH")
                {
                    if (txtHinhThucGui.Text != "Gửi góp")
                    {
                        FormTatToanTruocHan f6 = new FormTatToanTruocHan(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                        f6.ShowDialog();
                    }
                    else
                    {
                        FormTatToanTruocHan f6 = new FormTatToanTruocHan(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien, true);
                        f6.ShowDialog();
                    }

                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_TTDH")
                {
                    FormTatToanDungHan f7 = new FormTatToanDungHan(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), txtMaKH.Text, manhanvien);
                    f7.ShowDialog();
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }

                if (loaigiaodich == "GD_GH")
                {
                    FormGiaHan f8 = new FormGiaHan(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString());
                    f8.ShowDialog();
                }

                if (loaigiaodich == "GD_GG")
                {
                    FormGuiGop f9 = new FormGuiGop(dgv_LichSuGD.Rows[r].Cells[0].Value.ToString(), manhanvien, txtMaKH.Text);
                    f9.ShowDialog();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            gbChiTiet.Visible = false;
            dgv_DSSo.DataSource = action.get_DS_So(makhachhang).Tables[0];
        }

        private void btnTatToan_Click(object sender, EventArgs e)
        {
            DialogResult xacnhanTatToan = MessageBox.Show("Tất toán sổ tiết kiệm này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (xacnhanTatToan == DialogResult.Yes)
            {
                // Kiểm tra xem còn giao dịch nào chưa thanh toán không
                foreach (DataGridViewRow item in dgv_LichSuGD.Rows)
                {
                    if (item.Cells["DaThanhToan"].Value != null)
                        if (item.Cells["DaThanhToan"].Value.ToString() == "False")
                        {
                            MessageBox.Show("Cần thanh toán các giao dịch khác trước khi tất toán", "Thông báo");
                            return;
                        }
                }

                //Xác định loại sổ (Có thời hạn - Không thời hạn)
                string err = null;
                bool thuchien;
                if (int.TryParse(txtKyHan.Text, out int kyhan)) // Sổ có kỳ hạn
                {
                    //Xác định tất toán đúng hạn hay trước hạn
                    DateTime ngayDenHan = DateTime.Parse(txtDenHan.Text);
                    if (DateTime.Compare(ngayDenHan, DateTime.Today)<0)
                    {
                        // Tất toán đúng hạn
                        thuchien = action.TatToanSoCoHan(txtMaSo.Text, DateTime.Today.ToShortDateString(), manhanvien, txtMaKH.Text ,ref err);
                    }
                    else
                    {
                        // Tất toán trước hạn
                        thuchien = action.TatToanSoCoHan(txtMaSo.Text, DateTime.Today.ToShortDateString(), manhanvien, txtMaKH.Text, ref err, false);
                    }
                }
                else
                {
                    // Sổ không kỳ hạn
                    thuchien = action.TatToanSoKhongThoiHan(txtMaSo.Text, DateTime.Today.ToShortDateString(), manhanvien, txtMaKH.Text, ref err);
                }

                if (thuchien)
                {
                    MessageBox.Show("Tất toán sổ thành công. Kiểm tra lại các giao dịch", "Giao dịch thành công");
                    dgv_LichSuGD.DataSource = action.get_DS_GiaoDich(txtMaSo.Text).Tables[0];
                }
                else
                {
                    MessageBox.Show("Lỗi: " + err, "Giao dịch thất bại");
                }
            }
        }

        private void btnGuiGop_Click(object sender, EventArgs e)
        {
            DateTime ngayGuiGop = DateTime.Parse(txtOption2.Text);
            //if (DateTime.Compare(ngayGuiGop, DateTime.Today) <= 0)
            if (DateTime.Compare(ngayGuiGop, new DateTime(2022,12,7))<= 0)
            {
                FormGuiGop f9 = new FormGuiGop(manhanvien, txtMaKH.Text, txtMaSo.Text, txtHoTen.Text, txtMaDN.Text, tennhanvien);
                f9.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa đến hạn gửi góp", "Thông báo");
            }
        }
    }
}
