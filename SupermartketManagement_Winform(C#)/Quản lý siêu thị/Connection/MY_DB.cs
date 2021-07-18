using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class MY_DB
    {
        SqlConnection con = new SqlConnection(@"Data Source=inspiron5370-HoangQuan;Initial Catalog=MySupermarket_Manager_1;Integrated Security=True");
        public SqlConnection GetConnection
        {
            get
            {
                return con;
            }
        }

        //mở kết nối
        public void openConnection()
        {           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //đóng kết nối
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
