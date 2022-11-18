using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Saving_Account_Management.DB_Layer;
using System.Data.SqlClient;



namespace Saving_Account_Management.BS_Layer
{
    class BS_DSNhanVien
    {
        DB_Connect db = null;
        public BS_DSNhanVien()
        {
            db = new DB_Connect();
        }
        public DataSet Get_DSSinhVien()
        {

            string sqlString = "SELECT * from dbo.LAY_DSNHANVIEN()";
            db.new_comm();            
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public string get_MaNV()
        {
            string sqlString = "SELECT dbo.AUTO_IDNV()";
            db.new_comm();

            string kq = db.ExecuteQueryScalar<string>(sqlString, CommandType.Text);
            return kq;
        }
        public DataSet get_MaChiNhanh()
        {
            string sqlString = "SELECT * from CHI_NHANH";
            db.new_comm();
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_TimKiem(string machinhanh)
        {
            string sqlString = "SELECT * FROM (SELECT * from dbo.LAY_DSNHANVIEN())Q WHERE Q.MachiNhanh='"+machinhanh+"'";
            db.new_comm();
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public bool ThemNhanVien(string hoten,string ngaysinh,string madinhdanh,string sdt, string machinhanh, ref string err)
        { 

            string sqlString = "ThemNhanVien";
            db.new_comm();

            db.comm.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoten;
         
            db.comm.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = DateTime.Parse(ngaysinh);
            db.comm.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            db.comm.Parameters.Add("@maDinhDanh", SqlDbType.VarChar).Value = madinhdanh;
            db.comm.Parameters.Add("@maChiNhanh", SqlDbType.VarChar).Value = machinhanh;
          return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);


        }
        public bool SuaNhanVien(string MaNV,string hoten, string ngaysinh, string madinhdanh, string sdt, string machinhanh, ref string err)
        {

            string sqlString = "SuaNhanVien";
            db.new_comm();

            db.comm.Parameters.Add("@maNV", SqlDbType.VarChar).Value = MaNV;
            db.comm.Parameters.Add("@hoTen", SqlDbType.NVarChar).Value = hoten;

            db.comm.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = DateTime.Parse(ngaysinh);
            db.comm.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            db.comm.Parameters.Add("@maDinhDanh", SqlDbType.VarChar).Value = madinhdanh;
            db.comm.Parameters.Add("@maChiNhanh", SqlDbType.VarChar).Value = machinhanh;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);


        }

    }
}
