using Saving_Account_Management.DB_Layer;
using Saving_Account_Management.Setting;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saving_Account_Management.BS_Layer
{
    internal class BS_FromDangNhap 
    {
        DB_Connect db = null;
        public BS_FromDangNhap()
        {
        }

        public string KiemTraDangNhap(string text1, string text2)
        {
            db = AppSettingSingleton.getSetting().SQLConnection;
            db.new_comm();
            DataSet temp = new DataSet();
            bool f = false;
            string SqlString = $"Select * from DANG_NHAP where TenDangNhap = '{text1}' and MatKhau = '{text2}'";
            temp = db.ExecuteQueryDataSet(SqlString, CommandType.Text);
            if (temp.Tables[0].Rows.Count > 0)
            {
                return temp.Tables[0].Rows[0]["MaNhanVien"].ToString();
            }
            return null;
        }
        public string KiemTraQuyen(string text)
        {
            DataSet temp = new DataSet();
            string SqlString = "Select PHAN_NHOM.MaNhomNguoiDung " +
                " from DANG_NHAP, PHAN_NHOM" +
                " WHERE DANG_NHAP.MaNhanVien = PHAN_NHOM.MaNhanVien AND DANG_NHAP.TenDangNhap = '"+ text +"'";
            temp = db.ExecuteQueryDataSet(SqlString, CommandType.Text);
            string quyen = temp.Tables[0].Rows[0][0].ToString();
            return quyen;
        }
    }
}
