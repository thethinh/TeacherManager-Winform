using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        string strConn = "Data Source=DESKTOP-7CSRM23\\SQLEXPRESS;Initial Catalog = \"Quản lý giáo viên đại học\"; Integrated Security = True";
        public SqlConnection conn = null;
        public void OpenConnection()
        {
            if (conn == null)
                conn = new SqlConnection(strConn);
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void CloseConnection()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
