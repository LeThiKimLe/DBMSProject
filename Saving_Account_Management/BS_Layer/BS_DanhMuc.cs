using Saving_Account_Management.DB_Layer;
using Saving_Account_Management.Setting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DanhMuc
    {
        
        DB_Connect db = null;
        public BS_DanhMuc()
        {
            db = AppSettingSingleton.getSetting().SQLConnection;
        }
        public DataSet LayDanhSachChiNhanh()
        {
            db.new_comm();
            string sql = "SELECT * FROM SLNV_ChiNhanh";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayDanhSachLoaiGiaoDich()
        {
            db.new_comm();
            string sql = "SELECT * FROM LOAI_GIAO_DICH";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet LayDanhSachLoaiTien()
        {
            db.new_comm();
            string sql = "select * from LOAI_TIEN";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayDanhSachLoaiTietKiem()
        {
            db.new_comm();
            string sql = " Select  MaLoaiTietKiem,HINH_THUC_GUI.TenHinhThucGui,HINH_THUC_TRA_LAI.TenHinhThucTraLai,KyHan,LaiSuat\r\n FROM LOAI_TIET_KIEM,HINH_THUC_GUI,HINH_THUC_TRA_LAI\r\n where LOAI_TIET_KIEM.MaHinhThucGui=HINH_THUC_GUI.MaHinhThucGui\r\n and LOAI_TIET_KIEM.MaHinhThucTraLai = HINH_THUC_TRA_LAI.MaHinhThucTraLai";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataTable TimKiemThongTin(string text)
        {
            string sqlString = "Select MaLoaiTietKiem, TenHinhThucGui,TenHinhThucTraLai,KyHan,LaiSuat from LOAI_TIET_KIEM, HINH_THUC_GUI, HINH_THUC_TRA_LAI WHERE MaLoaiTietKiem LIKE N'%" + text + "%' or TenHinhThucGui LIKE N'%" + text + "%' OR TenHinhThucTraLai LIKE N'%" + text + "%'";
            DataSet temp = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return (temp.Tables[0]);
        }
       
        public DataSet LayHoTen()
        {
            db.new_comm();
            var MaNV = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            var userName = AppSettingSingleton.getSetting().CurrentTenDangNhap;
            string sql = " select * From LayHoTen('" + userName + "','" + MaNV + "')";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayNgaySinh()
        {
            db.new_comm();
            var MaNV = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            var userName = AppSettingSingleton.getSetting().CurrentTenDangNhap;
            string sql = " select * From LayNgaySinh('" + userName + "','" + MaNV + "')";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayMaDinhDanh()
        {
            db.new_comm();
            var MaNV = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            var userName = AppSettingSingleton.getSetting().CurrentTenDangNhap;
            string sql = " select * From LayMaDinhDanh('" + userName + "','" + MaNV + "')";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LaySDT()
        {
            db.new_comm();
            var MaNV = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            var userName = AppSettingSingleton.getSetting().CurrentTenDangNhap;
            string sql = " select * From LaySDT('" + userName + "','" + MaNV + "')";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayChiNhanh()
        {
            db.new_comm();
            var MaNV = AppSettingSingleton.getSetting().CurrentMaNhanVien;
            var userName = AppSettingSingleton.getSetting().CurrentTenDangNhap;
            string sql = " select * From LayChiNhanh('" + userName + "','" + MaNV + "')";

            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet LayChucVu(string maNhanVien)
        {
            db.new_comm();
            string sql = "select * From LayChucVu(@MaNhanVien)";
            db.comm.Parameters.AddWithValue("@MaNhanVien", maNhanVien);
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

    }
}
