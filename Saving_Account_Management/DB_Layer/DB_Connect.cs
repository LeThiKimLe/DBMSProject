using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Saving_Account_Management.DB_Layer
{
    public class DB_Connect
    {
        public SqlConnection Conn = new SqlConnection("Data Source=tcp:DESKTOP-SH243I1;Initial Catalog=QUANLYTAIKHOANTIETKIEM;User ID=sa;Password=Conchosu@1");

        public void myConnect()
        {
            Conn.Open();
        }
        //combobox sự kiện selectindexchange
        public void myClose()
        {
            Conn.Close();
        }

        public DataTable createTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ds = new SqlDataAdapter(sql, Conn);
            ds.Fill(dt);
            return dt;
        }
        SqlConnection link=null;
        public SqlCommand comm = null;
        SqlDataAdapter da = null;
        string connectString;
        public DB_Connect()
        {
            connectString = "Data Source=tcp:DESKTOP-SH243I1;Initial Catalog=QUANLYTAIKHOANTIETKIEM;User ID=sa;Password=123456";
            link = new SqlConnection(connectString);
            comm = link.CreateCommand();
        }

        public void new_comm()
        {
            comm = link.CreateCommand();

        }

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (link.State == ConnectionState.Open)
                link.Close();
            link.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public T ExecuteQueryScalar<T>(string strSQL, CommandType ct)
        {
            if (link.State == ConnectionState.Open)
                link.Close();
            link.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            T kq = (T)comm.ExecuteScalar();
            return kq;
        }


        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (link.State == ConnectionState.Open)
                link.Close();
            link.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                link.Close();
            }
            return f;
        }
    }
}
