using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    public class Customer
    {
        MY_DB mydb = new MY_DB();

        //thêm khách hàng
        public bool InsertKH(int Id, string fname, string lname, DateTime bdate, string gioitinh, string address, string phone,  MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO KH(Id,fname,lname,bdate,gender,address,phone,picture)" +
                "VALUES (@id,@fn,@ln,@bdt,@gdr,@adrs,@phn,@pic)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.openConnection();
                return false;
            }
        }


        //hàm lấy tất cả thông tin của tất cả nhân viên
        public DataTable GetAllKH()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KH", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //lấy thông tin nhân viên theo yêu cầu
        public DataTable GetKH(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //hàm xóa nhân viên theo id
        public bool DeleteKH(int id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM KH WHERE Id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = id;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.openConnection();
                return false;
            }
        }


        //hàm sửa thông tin nhân viên
        public bool updateKH(int Id, string fname, string Iname, DateTime bdate,string gender, string phone, string address,  MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE KH SET fname=@fn,lname=@ln,bdate=@bdt, gender=@gdr,phone=@phn,ad" +
                "dress=@adrs, picture = @pic WHERE Id=@ID", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = Iname;
            command.Parameters.Add("@bdt", SqlDbType.DateTime).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gender;
            command.Parameters.Add("@phn", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();


            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.openConnection();
                return false;
            }
        }


        //kiểm tra id Nhân viên có trùng hay không 
        //trả true nếu không trùng và ngược lại
        public bool IdCheck(int id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM KH WHERE Id = @cid", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.Int).Value = id;

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            mydb.openConnection();
            if (command.ExecuteScalar() == null)
            {
                return true;
                mydb.closeConnection();
            }
            else
            {
                return false;
                mydb.closeConnection();
            }
        }
    }
}
