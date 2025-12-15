using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS_Winform.QuerySQL
{
    public class AutoID
    {
        public static string nextID(string tableName, string idField, string prefix, int totalDigits)
        {
            string query = "select top 1 " + idField +
                            " from " + tableName +
                            " order by " + idField + " DESC";
            DataTable dt = new DataTable(); 
            using (SqlConnection conn = new SqlConnection(ConnectionString.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query,conn)) 
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
            }

            string nextID;
            if (dt.Rows.Count == 0)
            {
                // nếu chưa có mã thì lấy mã đầu tiên
                nextID = prefix + 1.ToString().PadLeft(totalDigits, '0');
            }
            else
            {
                //lấy id lớn nhất
                string lastID = dt.Rows[0][0].ToString();
                //Lấy 3 các chữ số sau ký tự
                string numberPart = lastID.Substring(prefix.Length);
                if (!int.TryParse(numberPart, out int number))
                    number = 0;
                number++;

                //tạo mã mới
                nextID = prefix + number.ToString().PadLeft(totalDigits, '0');
            }
            return nextID;
        }
    }
}
