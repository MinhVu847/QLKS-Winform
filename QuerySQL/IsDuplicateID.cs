using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS_Winform.QuerySQL
{
    public class IsDuplicateID
    {
        public static bool isDuplicateID(string tableName, string idField, string idCheck)
        {
            string query = "SELECT " + idField + " FROM " + tableName + " WHERE " + idField + " = @id";
            SqlParameter parameters = new SqlParameter("@id", idCheck);
            if (DataProvider.ExcuteScalar(query, parameters) != null)
                return true;
            return false;
        }
    }
}
