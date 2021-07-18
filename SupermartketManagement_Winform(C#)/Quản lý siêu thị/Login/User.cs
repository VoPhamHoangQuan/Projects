using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class User
    {
        MY_DB mydb = new MY_DB();

        //thêm user
        public bool InsertUser(int id,string uname,string pass)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Log_in_KH(Id,username,password)" + "VALUES(@cid,@cusername,@cpassword)", mydb.GetConnection);
            command.Parameters.Add("@cusername", SqlDbType.NChar).Value = uname;
            command.Parameters.Add("@cpassword", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;

            mydb.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        //hàm kiểm tra user có tồn tại chưa
        public bool UserExist(string unem,string pass, int id = 0)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in_KH WHERE username = @cuname AND password = @cpass AND Id <> @cid", mydb.GetConnection);
            command.Parameters.Add("@cuname", SqlDbType.NChar).Value = unem;
            command.Parameters.Add("@cpass", SqlDbType.NChar).Value = pass;
            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0) //Có trùng dữ liệu và có tồn tại
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //đếm số lượng user
        public int CountUser()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Log_in_KH", mydb.GetConnection);

            //phương thức để lưu dữ liệu vào dataAdapter
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            //fill dữ liệu từ dataAdapter vào table
            dataAdapter.Fill(table);
            int kq = table.Rows.Count;

            return kq;
        }

    }
}
