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
    class Products
    {
        MY_DB mydb = new MY_DB();

        //thêm sản phẩm mới
        public bool insertSanPham(string idSp, string tensp, DateTime hsd, DateTime nsx, float sl, float giagoc, float giaban, MemoryStream picture, string kind, string brand)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SanPham(Idsp,Tensp,Hsd,Nsx,Sltrenke,Giagoc,Giaban,Picture,Loaisp,Hang)" +
                "VALUES (@cid,@cten,@chsd,@cnsx,@csl,@cgiagoc,@cgiaban,@cpicture,@ckind,@cbrand)", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.NChar).Value = idSp;
            command.Parameters.Add("@cten", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@chsd", SqlDbType.Date).Value = hsd;
            command.Parameters.Add("@cnsx", SqlDbType.Date).Value = nsx;
            command.Parameters.Add("@csl", SqlDbType.Float).Value = sl;
            command.Parameters.Add("@cgiagoc", SqlDbType.Float).Value = giagoc;
            command.Parameters.Add("@cgiaban", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@ckind", SqlDbType.NVarChar).Value = kind;
            command.Parameters.Add("@cbrand", SqlDbType.NVarChar).Value = brand;
            command.Parameters.Add("@cpicture", SqlDbType.Image).Value = picture.ToArray();

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

        //lấy thông tin sản phẩm
        public DataTable getSanPham(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Sửa Thông tin Sản Phẩm
        public bool updateSanPham(string idSp, string tensp, DateTime hsd, DateTime nsx, float sl, float giagoc, float giaban, MemoryStream picture, string kind, string brand)
        {
            SqlCommand command = new SqlCommand("UPDATE SanPham SET Tensp = @cten, Hsd = @chsd, Nsx = @cnsx, " +
                "Sltrenke =@csl ,Giagoc = @cgiagoc,Giaban = @cgiaban,Picture = @cpicture,Loaisp = @ckind,Hang = @cbrand WHERE Idsp=@cId", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.NChar).Value = idSp;
            command.Parameters.Add("@cten", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@chsd", SqlDbType.Date).Value = hsd;
            command.Parameters.Add("@cnsx", SqlDbType.Date).Value = nsx;
            command.Parameters.Add("@csl", SqlDbType.Float).Value = sl;
            command.Parameters.Add("@cgiagoc", SqlDbType.Float).Value = giagoc;
            command.Parameters.Add("@cgiaban", SqlDbType.Float).Value = giaban;
            command.Parameters.Add("@ckind", SqlDbType.NVarChar).Value = kind;
            command.Parameters.Add("@cbrand", SqlDbType.NVarChar).Value = brand;
            command.Parameters.Add("@cpicture", SqlDbType.Image).Value = picture.ToArray();

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

        public bool updateSLSanPham(string tensp,float sl)
        {
            SqlCommand command = new SqlCommand("UPDATE SanPham SET Sltrenke =@csl  WHERE Tensp=@cten", mydb.GetConnection);       
            command.Parameters.Add("@cten", SqlDbType.NVarChar).Value = tensp;
            
            command.Parameters.Add("@csl", SqlDbType.Float).Value = sl;
            

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

        //Xóa Sản Phẩm theo mã sản phẩm
        public bool deleteSanPham(string idSp)
        {
            SqlCommand command = new SqlCommand("DELETE FROM SanPham WHERE Idsp=@cId", mydb.GetConnection);
            command.Parameters.Add("@cId", SqlDbType.NChar).Value = idSp;
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

        public DataTable updateSoluongSP(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //kiểm tra id sản phẩm có trùng hay không 
        public bool IdCheck(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SanPham WHERE Idsp = @cid",mydb.GetConnection);
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
        public DataTable getProductById(String id)
        {
            SqlCommand command = new SqlCommand("select * from SanPham where Idsp=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        //hàm lấy dữ liệu theo command
        string execCount(string query)
        {
            SqlCommand command = new SqlCommand(query, mydb.GetConnection);
            mydb.openConnection();
            String count = command.ExecuteScalar().ToString();
            mydb.closeConnection();
            return count;
        }

        public string totalSP()
        {
            return execCount("select count(*) from SanPham ");
        }
        public string totalLaptop()
        {
            return execCount("SELECT COUNT(*) FROM SanPham WHERE Loaisp='Laptop'");
        }
        public string totalSmartphone()
        {
            return execCount("SELECT COUNT(*) FROM SanPham WHERE Loaisp='Smartphone'");
        }
    }
}
