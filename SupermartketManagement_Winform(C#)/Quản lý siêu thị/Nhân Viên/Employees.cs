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
    class Employees
    {

        MY_DB mydb = new MY_DB();

        //thêm nhân viên
        public bool InsertNhanVien(string Id, string fname, string lname, DateTime bdate, string gioitinh, string address, string idql, string position, MemoryStream picture, string usename, string password,string phone)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhanVien(Idnv,Fname,Lname,Bdate,Gender,Addr,Idql,Position,Picture,Usename,Pass,Phone)" +
                "VALUES (@id,@fn,@ln,@bdt,@gdr,@adrs,@idql,@position,@pic,@uname,@pass,@phone)", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@idql", SqlDbType.NChar).Value = idql;
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = position;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = usename;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;

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
        public DataTable GetAllNhanvien()
        {
            SqlCommand command = new SqlCommand("SELECT Idnv as 'Mã nhân viên' ,Fname as 'Họ' ,Lname as'Tên',Bdate as 'Sinh nhật',Gender as 'Giới tính',Addr as 'Địa chỉ',Idql as 'Mã quản lý' ,Position as 'Chức vụ',Picture as 'Ảnh',Usename,Pass,Phone as 'SĐT' FROM NhanVien", mydb.GetConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //lấy thông tin nhân viên theo yêu cầu
        public DataTable GetNV(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //hàm xóa nhân viên theo id
        public bool DeleteNhanVien(string id)
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhanVien WHERE Idnv=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
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
        public bool updateNhanVien(string Id, string fname, string lname, DateTime bdate, string gioitinh, string address, string idql, string position, MemoryStream picture, string usename, string password, string phone)
        {
            SqlCommand command = new SqlCommand("UPDATE NhanVien SET Fname=@fn,Lname=@ln,Bdate=@bdt,Gender=@gdr,Ad" +
                "dr=@adrs, Idql = @idql, Position = @position, Picture = @pic, Usename = @uname, Pass = @pass, Phone = @phone WHERE Idnv=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = Id;
            command.Parameters.Add("@fn", SqlDbType.NVarChar).Value = fname;
            command.Parameters.Add("@ln", SqlDbType.NVarChar).Value = lname;
            command.Parameters.Add("@bdt", SqlDbType.Date).Value = bdate;
            command.Parameters.Add("@gdr", SqlDbType.NVarChar).Value = gioitinh;
            command.Parameters.Add("@adrs", SqlDbType.NVarChar).Value = address;
            command.Parameters.Add("@idql", SqlDbType.NChar).Value = idql;
            command.Parameters.Add("@position", SqlDbType.NVarChar).Value = position;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();
            command.Parameters.Add("@uname", SqlDbType.NChar).Value = usename;
            command.Parameters.Add("@pass", SqlDbType.NChar).Value = password;
            command.Parameters.Add("@phone", SqlDbType.NChar).Value = phone;


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
        public bool IdCheck(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NhanVien WHERE Idnv = @cid", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.NChar).Value = id;

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



        //public bool InsertCheck_in(int id, string check_in_hours, string check_in_mnsc, string check_out_hours, string check_out_mnsc)
        //{
        //    SqlCommand command = new SqlCommand("INSERT INTO Time(id,check_in_hours,check_in_minute_second,check_out_hours,check_out_minute_second)" +
        //        "VALUES (@id,@ih,@imsc,@oh,@omsc)", mydb.GetConnection);
        //    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //    command.Parameters.Add("@ih", SqlDbType.NVarChar).Value = check_in_hours;
        //    command.Parameters.Add("@imsc", SqlDbType.NVarChar).Value = check_in_mnsc;
        //    command.Parameters.Add("@oh", SqlDbType.NVarChar).Value = check_out_hours;
        //    command.Parameters.Add("omsc", SqlDbType.NVarChar).Value = check_out_mnsc;


        //    mydb.openConnection();
        //    if ((command.ExecuteNonQuery() == 1))
        //    {
        //        mydb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        mydb.openConnection();
        //        return false;
        //    }
        //}

        //public bool UpdateCheck_out(int id, string check_out_hours, string check_out_mnsc)
        //{
        //    SqlCommand command = new SqlCommand("UPDATE Time SET check_out_hours=@oh,check_out_minute_second" +
        //        "=@omsc WHERE id=@id", mydb.GetConnection);
        //    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //    command.Parameters.Add("@oh", SqlDbType.NVarChar).Value = check_out_hours;
        //    command.Parameters.Add("omsc", SqlDbType.NVarChar).Value = check_out_mnsc;


        //    mydb.openConnection();
        //    if ((command.ExecuteNonQuery() == 1))
        //    {
        //        mydb.closeConnection();
        //        return true;
        //    }
        //    else
        //    {
        //        mydb.openConnection();
        //        return false;
        //    }
        //}
    }
}
