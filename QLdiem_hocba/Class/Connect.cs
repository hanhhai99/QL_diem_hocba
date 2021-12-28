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
        string connStr = "Data Source=LAPTOP-TFK9EVFA;Initial Catalog=QLD;Integrated Security=True";
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
