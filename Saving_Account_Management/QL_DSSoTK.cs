using Saving_Account_Management.BS_Layer;
using Saving_Account_Management.Extensions;
using Saving_Account_Management.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Saving_Account_Management
{
    public partial class QL_DSSoTK : Form
    {
        private BS_DSSoTK action = new BS_DSSoTK();

        public QL_DSSoTK()
        {
            InitializeComponent();
            Load_Data();
        }

        private void Load_Data()
        {
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

            // Load dữ liệu lên combobox
            cb_TKLoaiSo.DataSource = action.TenHinhThucTK().Tables[0];
            cb_TKLoaiSo.DisplayMember = "TenHinhThuc";

            // viết extention trong chính lớp mặc định.
            this.dgv_SoTK.EnableDoubleBuffered();
        }


        private void dgv_SoTK_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        #region tìm kiếm mã sổ và chủ sở hữu trên textbox
        private void txt_TKSoHuu_TextChanged(object sender, EventArgs e)
        {
            txt_TKMaSo.Clear();
            DataSet ds = new DataSet();
            ds = action.TimKiemSoHuu(txt_TKSoHuu.Text);

            dgv_SoTK.DataSource = ds.Tables[0];
            dgv_SoTK.AutoResizeColumns();
        }

        private void txt_TKMaSo_TextChanged(object sender, EventArgs e)
        {
            txt_TKSoHuu.Clear();
            DataSet ds = new DataSet();
            ds = action.TimKiemMaSoTK(txt_TKMaSo.Text);

            dgv_SoTK.DataSource = ds.Tables[0];
            dgv_SoTK.AutoResizeColumns();
        }
        #endregion

        #region tìm kiếm theo hình thức gửi và trả lãi
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            if (cb_TKLoaiSo.Text == "Gửi góp")
            {
                ds = action.TimKiemTheoHinhThucTK("DS_SoGuiGop");
            }
            else if (cb_TKLoaiSo.Text == "Gửi một lần")
            {
                ds = action.TimKiemTheoHinhThucTK("DS_SoGui1Lan");
            }
            else if (cb_TKLoaiSo.Text == "Trả lãi định kỳ")
            {
                ds = action.TimKiemTheoHinhThucTK("DS_SoTraLaiDinhKy");
            }
            else if (cb_TKLoaiSo.Text == "Trả lãi sau")
            {
                ds = action.TimKiemTheoHinhThucTK("DS_SoTraLaiSau");
            }
            else
            {
                ds = action.TimKiemTheoHinhThucTK("DS_SoTraLaiTruoc");
            }
            dgv_SoTK.DataSource = ds.Tables[0];
        }
        #endregion

    }
}
