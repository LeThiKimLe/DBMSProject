using Saving_Account_Management.DB_Layer;
using Saving_Account_Management.Setting;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Saving_Account_Management.BS_Layer
{
    internal class BS_DSSoTK
    {
        DB_Connect db = null;
        string err;

        public BS_DSSoTK()
        {
            db = db = AppSettingSingleton.getSetting().SQLConnection;
        }

        public DataSet LayDanhSachSoTK()
        {
            db.new_comm();
            string sql = "SELECT * FROM TAI_KHOAN_TIET_KIEM";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }
        public DataSet LayDanhSachChuSoHuu(string maSoTK)
        {
            db.new_comm();
            string sql = "select MaKhachHang, HoTen, MaDinhDanh from CHI_TIET_SO where MaSoTK = @MaSoTK";
            return db.ExecuteQueryDataSet(sql, CommandType.Text, new SqlParameter("@MaSoTK", maSoTK));
        }

        public DataSet TimKiemMaSoTK(string maSoTK)
        {
            DB_Connect conn = new DB_Connect();
            string sql = "SELECT* FROM TAI_KHOAN_TIET_KIEM WHERE MaSoTK LIKE '%' + @MaSoTK+ '%'";
            DataSet ds = conn.ExecuteQueryDataSet(sql, CommandType.Text, new SqlParameter("@MaSoTK", maSoTK));
            return ds;
        }

        public DataSet TimKiemSoHuu(string hoTen)
        {
            DB_Connect conn = new DB_Connect();
            string sql = "select * from TIM_KIEM_SO_HUU(@HoTen)";
            DataSet ds = conn.ExecuteQueryDataSet(sql, CommandType.Text, new SqlParameter("@HoTen", hoTen));
            return ds;
        }

        public DataSet TenHinhThucTK()
        {
            DB_Connect conn = new DB_Connect();
            string sql = "select * from TenHinhThuc";
            DataSet ds = conn.ExecuteQueryDataSet(sql, CommandType.Text);
            return ds;
        }

        public DataSet TimKiemTheoHinhThucTK(string tenHinhThuc)
        {
            DB_Connect conn = new DB_Connect();
            string sql = "select * from TAI_KHOAN_TIET_KIEM RIGHT join " + tenHinhThuc
                       + " on TAI_KHOAN_TIET_KIEM.MaSoTK = " + tenHinhThuc + ".MaSoTK";

            DataSet ds = conn.ExecuteQueryDataSet(sql, CommandType.Text);
            return ds;
        }

        public bool ThemKhachHang(string maKhachHang, string hoTen, string sdt, string diaChi, string maDinhDanh,
                                 string noiCap, string ngaySinh, string ngayCap, string image)
        {
            string sqlString = "ThemKhachHang";
            db.new_comm();
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            db.comm.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            db.comm.Parameters.Add("@ngaySinh", SqlDbType.VarChar).Value = ngaySinh;
            db.comm.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            db.comm.Parameters.Add("@maDinhDanh", SqlDbType.VarChar).Value = maDinhDanh;
            db.comm.Parameters.Add("@ngayCap", SqlDbType.VarChar).Value = ngayCap;
            db.comm.Parameters.Add("@noiCap", SqlDbType.NVarChar).Value = noiCap;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diaChi;
            db.comm.Parameters.Add("@imageFolderPath", SqlDbType.NVarChar).Value = image;
            var result = db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
            return result;
        }

        public bool ThemNguoiDongSoHuu(string maSoTK , DateTime ngayPhatSinhGiaoDich , string maNhanVien ,
                                 string hoTen, DateTime ngaySinh, string sdt,string maDinhDanh,
                                 DateTime ngayCap, string noiCap, string diaChi, string image)
        {
            string sqlString = "DongSoHuu";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.NVarChar).Value = maSoTK;
            db.comm.Parameters.Add("@ngayPhatSinhGiaoDich", SqlDbType.Date).Value = ngayPhatSinhGiaoDich;
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoTen;
            db.comm.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = ngaySinh;
            db.comm.Parameters.Add("@sdt", SqlDbType.Char).Value = sdt;
            db.comm.Parameters.Add("@maDinhDanh", SqlDbType.VarChar).Value = maDinhDanh;
            db.comm.Parameters.Add("@ngayCap", SqlDbType.Date).Value = ngayCap;
            db.comm.Parameters.Add("@noiCap", SqlDbType.NVarChar).Value = noiCap;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diaChi;
            db.comm.Parameters.Add("@imageFolderPath", SqlDbType.NVarChar).Value = image;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);


           
        }
    }
}
