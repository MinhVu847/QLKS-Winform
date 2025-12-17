using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_Winform.QuerySQL
{
    public class DataProvider
    {
        //Trả về 1 bảng
        public static DataTable ExcuteQuery(string query, params SqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using(SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
            }
            return dt;
        }

        //insert update delete
        public static int ExcuteNonQuery(string query, params SqlParameter[] parameters)
        {
            int result = 0;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if(parameters != null) 
                    cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteNonQuery();
                con.Close();
            }

            return result;
        }

        //sum count max
        public static object ExcuteScalar(string query, params SqlParameter[] parameters)
        {
            object result = null;
            using (SqlConnection con = new SqlConnection(ConnectionString.connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);
                result = cmd.ExecuteScalar();
                con.Close();
            }
            return result;
        }
    }
}
