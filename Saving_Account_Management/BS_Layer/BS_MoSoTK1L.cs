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

    class BS_MoSoTK1L
    {
        DB_Connect db = null;
        public BS_MoSoTK1L()
        {
            db = new DB_Connect();
        }
        public DataSet LaySoTheoMaDinhDanh(string MaDinhDanh)
        {

            string sqlString = "SELECT * from dbo.KIEM_TRA_KH (@MaDinhDanh)";
            db.new_comm();
            db.comm.Parameters.AddWithValue("@MaDinhDanh", MaDinhDanh);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public string get_MaSo()
        {
            string sqlString = "SELECT dbo.AUTO_IDSTK()";
            db.new_comm();

            string kq = db.ExecuteQueryScalar<string>(sqlString, CommandType.Text);
            return kq;
        }
        public DataSet get_LoaiTien()
        {
            string sqlString = "SELECT * from LOAI_TIEN";
            db.new_comm();
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_HinhThucTraLai()
        {
            string sqlString = "SELECT * from HINH_THUC_TRA_LAI";
            db.new_comm();
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_NgayDenHan(string MASTK)
        {
            
            string sqlString = "SELECT * from dbo.LAYNGAYDENHAN(@MASTK)";
            db.new_comm();
            db.comm.Parameters.AddWithValue("@MASTK", MASTK);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_KyHan(string mahtg, string maHTTraLai)
        {
            string sqlString = "SELECT * from dbo.LAYKYHAN(@MAHTGUI,@MAHTTRALAI)";
            db.new_comm();
            db.comm.Parameters.AddWithValue("@MAHTTRALAI", maHTTraLai);
            db.comm.Parameters.AddWithValue("@MAHTGUI", mahtg);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_LaiSuat(string mahtg, string maHTTraLai, int kyhan)
        {
            string sqlString = "SELECT * from dbo.LAYLAISUAT(@MAHTGUI,@MAHTTRALAI,@KYHAN)";
            db.new_comm();
            db.comm.Parameters.AddWithValue("@MAHTTRALAI", maHTTraLai);
            db.comm.Parameters.AddWithValue("@MAHTGUI", mahtg);
            db.comm.Parameters.AddWithValue("@KYHAN", kyhan);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;

        }


        public string get_MaKH()
        {
            string sqlString = "SELECT dbo.AUTO_IDCustomer()";
            db.new_comm();

            string kq = db.ExecuteQueryScalar<string>(sqlString, CommandType.Text);
            return kq;
        }
        public bool ThemSoTK1L(string MaKH, string TenKH, string ngaysinh, string SDT, string MaDinhDanh, string ngaycap, string noicap, string diachi, string imageFolderPath,
         float khoanGui, string maNhanvien, string ngayMoSo, string maLoaiTien, int kyHan, string maHinhThucTraLai, int kyTraLai, string error, ref string err)
        {

            string sqlString = "ThemSoGui1Lan";
            db.new_comm();

            db.comm.Parameters.Add("@maKhachHang", SqlDbType.NVarChar).Value = MaKH;
            db.comm.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar).Value = TenKH;
            db.comm.Parameters.Add("@ngaySinh", SqlDbType.Date).Value = DateTime.Parse(ngaysinh);
            db.comm.Parameters.Add("@sdt", SqlDbType.VarChar).Value = SDT;
            db.comm.Parameters.Add("@cccd", SqlDbType.VarChar).Value = MaDinhDanh;
            db.comm.Parameters.Add("@ngaycap", SqlDbType.Date).Value = DateTime.Parse(ngaycap);
            db.comm.Parameters.Add("@noiCap", SqlDbType.NVarChar).Value = noicap;
            db.comm.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = diachi;
            db.comm.Parameters.Add("@imageFolderPath", SqlDbType.NVarChar).Value = imageFolderPath;
            db.comm.Parameters.Add("@khoanGui", SqlDbType.Money).Value = khoanGui;
            db.comm.Parameters.Add("@maNhanvien", SqlDbType.NVarChar).Value = maNhanvien;
            db.comm.Parameters.Add("@ngayMoSo", SqlDbType.Date).Value = DateTime.Parse(ngayMoSo);
            db.comm.Parameters.Add("@maLoaiTien", SqlDbType.NVarChar).Value = maLoaiTien;
            db.comm.Parameters.Add("@KyHan", SqlDbType.Int).Value = kyHan;
            db.comm.Parameters.Add("@maHinhThucTraLai", SqlDbType.NVarChar).Value = maHinhThucTraLai;
            db.comm.Parameters.Add("@kyTraLai", SqlDbType.Int).Value = kyTraLai;
            db.comm.Parameters.Add("@err", SqlDbType.NVarChar).Value = error;



            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);


        }



    }
}

