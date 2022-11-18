using System.Data;
using System.Data.SqlClient;

namespace Saving_Account_Management.DB_Layer
{
    public class DB_Connect
    {
        SqlConnection link = null;
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

        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct, params SqlParameter[] sqlParameters)
        {
            if (link.State == ConnectionState.Open)
                link.Close();
            link.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            comm.Parameters.AddRange(sqlParameters);
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
                error = ex.Errors[0].Message;
            }
            finally
            {
                link.Close();
            }
            return f;
        }
    }
}
