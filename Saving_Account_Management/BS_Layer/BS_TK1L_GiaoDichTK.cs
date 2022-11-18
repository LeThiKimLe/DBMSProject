using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

using Saving_Account_Management.DB_Layer;

namespace Saving_Account_Management.BS_Layer
{
    
    class BS_TK1L_GiaoDichTK
    {
        DB_Connect db = null;
        public BS_TK1L_GiaoDichTK()
        {
            db = new DB_Connect();
        }

        public DataSet get_DS_So(string MaDinhDanh)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayChiTietThongTinSo(@maDinhDanh)";
            db.comm.Parameters.AddWithValue("@maDinhDanh", MaDinhDanh);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_DS_GiaoDich(string MaSo)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichSoTK(@maSo)";
            db.comm.Parameters.AddWithValue("@maSo", MaSo);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichGuiTK(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichGuiLanDau(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichRutLaiDinhKy(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichRutLaiDinhKy(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichRutLaiSau(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichRutLaiSau(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichRutLaiTruoc(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichRutLaiTruoc(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichRutTruocHan(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichRutLaiTruocHan(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichTatToanTruocHanSo1Lan(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichTatToanTruocHan_So1Lan(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }
        public DataSet get_Chitiet_GiaoDichTatToanTruocHanSoGuiGop(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichTatToanTruocHan_SoGuiGop(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichTatToanDungHan(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichTatToanDungHan(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_GiaoDichGiaHanSo1Lan(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichGiaHanSo(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public string GiaoDichGuiGop(string maSoTK, string soTien, string ngayGiaoDich, string maNhanvien, string maKhachHang, ref string err)						  
        {
            
            string sqlString = "GuiGop";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSoTK;
            db.comm.Parameters.Add("@soTien", SqlDbType.Money).Value = Decimal.Parse(soTien);
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngayGiaoDich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanvien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            SqlParameter retval = db.comm.Parameters.Add("@maGiaoDich", SqlDbType.VarChar, 10);
            retval.Direction = ParameterDirection.Output;
            bool thuchien;
            thuchien= db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
            if (thuchien)
                return (string)db.comm.Parameters["@maGiaoDich"].Value;
            else
                return null;
        }

        public DataSet get_Chitiet_GiaoDichGuiGop(string MaGiaoDich)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayGiaoDichGuiGop(@maGiaoDich)";
            db.comm.Parameters.AddWithValue("@maGiaoDich", MaGiaoDich);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public DataSet get_Chitiet_LayThongTinSoGuiGop(string MaSo)
        {
            db.new_comm();
            string sqlString = "SELECT * from dbo.LayThongTinSoTruocGuiGop(@maSoTK)";
            db.comm.Parameters.AddWithValue("@maSoTK", MaSo);
            DataSet dts = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            return dts;
        }

        public bool ThanhToanTKDK(string maSo, string maNhanVien, string ngaygiaodich, string maKhachHang, ref string err)
        { 
            
            string sqlString = "LayLaiDinhKy";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@ngaylaylai", SqlDbType.Date).Value = DateTime.Parse(ngaygiaodich);
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            db.comm.Parameters.Add("@err", SqlDbType.VarChar).Value = err;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool ThanhToanTKS(string maSo, string maNhanVien, string ngaygiaodich, string maKhachHang, ref string err)
        {
            
            string sqlString = "RutLaiSau";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngaygiaodich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool ThanhToanTKT(string maSo, string maNhanVien, string ngaygiaodich, string maKhachHang, ref string err)
        {
            
            string sqlString = "RutLaiTruoc";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngaygiaodich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool TatToanSoCoHan(string maSo, string ngayGiaoDich, string maNhanVien, string maKhachHang, ref string err, bool DungHan=true)
        {
            string sqlString = null;
            if (DungHan)
                sqlString = "TatToanDungHan";
            else
                sqlString = "TatToanTruocHan";

            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngayGiaoDich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool TatToanSoKhongThoiHan(string maSo, string ngayGiaoDich, string maNhanVien, string maKhachHang, ref string err)
        {
            string sqlString = "TatToanSoKhongKyHan";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngayGiaoDich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool XacNhanTatToanSoGuiGop(string maSo, string ngayGiaoDich, string maNhanVien, string maKhachHang, ref string err)
        {
            string sqlString = "TatToanDungHan";
            db.new_comm();
            db.comm.Parameters.Add("@maSoTK", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngayGiaoDich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool XacNhanRutLaiTruocHan(string maSo, string maNhanVien, string ngaygiaodich, string maKhachHang, ref string err)
        {
            string sqlString = "XacNhanRutLaiTruocHan";
            db.new_comm();
            db.comm.Parameters.Add("@maSo", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngaygiaodich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }

        public bool XacNhanTatToanTruocHan(string maSo, string maNhanVien, string ngaygiaodich, string maKhachHang, ref string err)
        {
            string sqlString = "XacNhanTatToanTruocHan";
            db.new_comm();
            db.comm.Parameters.Add("@maSo", SqlDbType.VarChar).Value = maSo;
            db.comm.Parameters.Add("@ngayGiaoDich", SqlDbType.Date).Value = DateTime.Parse(ngaygiaodich);
            db.comm.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = maNhanVien;
            db.comm.Parameters.Add("@maKhachHang", SqlDbType.VarChar).Value = maKhachHang;
            return db.MyExecuteNonQuery(sqlString, CommandType.StoredProcedure, ref err);
        }





    }
}
