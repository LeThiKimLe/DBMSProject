using System.Data.SqlClient;
using System.Data;
using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management.BS_Layer
{
    class BS_DSKhachHang
    {
        DB_Connect db = null;
        string err;
        public BS_DSKhachHang()
        {
            db = new DB_Connect();
        }
        
        public DataSet LayDanhSachKhachHang()
        {
            db.new_comm();
            string sql = "SELECT * FROM KHACH_HANG ";
            return db.ExecuteQueryDataSet(sql, CommandType.Text);
        }

        public DataSet TimKiem(string loaiTK, string maKH)
        {
            DB_Connect conn = new DB_Connect();
            string temp = "SELECT* ROM KHACH_HANG WHERE " + loaiTK + " LIKE '%" + maKH + "%'";
            DataSet ds = conn.ExecuteQueryDataSet(temp, CommandType.Text);
            return ds;
        }

        public DataSet TimKiemMaDinhDanh(string maDinhDanh)
        {
            DB_Connect conn = new DB_Connect();
            string temp = "SELECT* FROM KHACH_HANG WHERE MADINHDANH = @mdd";
            DataSet ds = null;
            ds = conn.ExecuteQueryDataSet(temp, CommandType.Text,
                new SqlParameter("@mdd", maDinhDanh));
            return ds;
        }

        public bool SuaKhachHang(string maKhachHang, string hoTen, string sdt,string diaChi, string maDinhDanh, 
                                 string noiCap, string ngaySinh,string ngayCap,  string image)
        {
            string sqlString = "SuaKhachHang";
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

    }
}
