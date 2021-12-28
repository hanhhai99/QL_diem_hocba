using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLdiem_hocba
{
    class Connect
    {
        string connStr = "Data Source=sql.nvcd.xyz;Initial Catalog=QLD;Integrated Security=True;User ID=sa;Password=Secret1234;";
        protected SqlConnection conn;
        public void openConnect()
        {
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        public void closeConnect()
        {
            conn.Close();
        }
    }
}
