using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class Storage
    {
        MY_DB mydb = new MY_DB();

        //thêm sản phẩm mới
        public bool importSpStore(string idSp, float sl)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Kho(Idsp, Sltrongkho)" +
                "VALUES (@cid,@csl)", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.NChar).Value = idSp;
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

        //lấy thông tin sản phẩm
        public DataTable getSanPham(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        //Xóa Sản Phẩm theo mã sản phẩm
        public bool deleteSpStore(string idSp)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Kho WHERE Idsp=@cId", mydb.GetConnection);
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

        //Đặt hàng
        public bool OrderSp(string idnhapxuat, string idSp, string idql, float slNhap, DateTime ngaynhap, float slXuat, DateTime ngayxuat)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhapXuatKho(Idnhapxuat,Idsp,Idqlkho,Slnhapkho, Ngaynhapkho, Slxuatkho, Ngayxuatkho)" +
                "VALUES (@cidnhapxuat,@cidsp,@cidql,@cslnhap,@cngaynhap,@cslxuat,@cngayxuat)", mydb.GetConnection);
            command.Parameters.Add("@cidnhapxuat", SqlDbType.NChar).Value = idnhapxuat;
            command.Parameters.Add("@cidsp", SqlDbType.NChar).Value = idSp;
            command.Parameters.Add("@cidql", SqlDbType.NChar).Value = idql;
            command.Parameters.Add("@cslnhap", SqlDbType.Float).Value = slNhap;
            command.Parameters.Add("@cngaynhap", SqlDbType.Date).Value = ngaynhap;
            command.Parameters.Add("@cslxuat", SqlDbType.Float).Value = slXuat;
            command.Parameters.Add("@cngayxuat", SqlDbType.Date).Value = ngayxuat;

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

        //Xác nhận đặt hàng
        public bool ConfirmSp( string idSp,float sltrongkho)
        {
            SqlCommand command = new SqlCommand("UPDATE Kho SET Sltrongkho = @csltrongkho WHERE Idsp=@cidsp", mydb.GetConnection);
            command.Parameters.Add("@csltrongkho", SqlDbType.Float).Value = sltrongkho;
            command.Parameters.Add("@cidsp", SqlDbType.NChar).Value = idSp;


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


        //Xuất hàng
        public bool ConfirmExportSp(string idSp,float sltrenke)
        {
            SqlCommand command = new SqlCommand("UPDATE SanPham SET Sltrenke = @csl WHERE Idsp=@cId", mydb.GetConnection);
            command.Parameters.Add("@cid", SqlDbType.NChar).Value = idSp;
            command.Parameters.Add("@csl", SqlDbType.Float).Value = sltrenke;

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


        public bool ReportExportSp(string idnhapxuat, string idSp, string idql, float slNhap, DateTime ngaynhap, float slXuat, DateTime ngayxuat)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhapXuatKho(Idnhapxuat,Idsp,Idqlkho,Slnhapkho, Ngaynhapkho, Slxuatkho, Ngayxuatkho)" +
                "VALUES (@cidnhapxuat,@cidsp,@cidql,@cslnhap,@cngaynhap,@cslxuat,@cngayxuat)", mydb.GetConnection);
            command.Parameters.Add("@cidnhapxuat", SqlDbType.NChar).Value = idnhapxuat;
            command.Parameters.Add("@cidsp", SqlDbType.NChar).Value = idSp;
            command.Parameters.Add("@cidql", SqlDbType.NChar).Value = idql;
            command.Parameters.Add("@cslnhap", SqlDbType.Float).Value = slNhap;
            command.Parameters.Add("@cngaynhap", SqlDbType.Date).Value = ngaynhap;
            command.Parameters.Add("@cslxuat", SqlDbType.Float).Value = slXuat;
            command.Parameters.Add("@cngayxuat", SqlDbType.Date).Value = ngayxuat;

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


        //xác nhận xuất hàng
        public bool ExportSp(string idSp, float sltrongkho)
        {
            SqlCommand command = new SqlCommand("UPDATE Kho SET Sltrongkho = @csltrongkho WHERE Idsp=@cidsp", mydb.GetConnection);
            command.Parameters.Add("@csltrongkho", SqlDbType.Float).Value = sltrongkho;
            command.Parameters.Add("@cidsp", SqlDbType.NChar).Value = idSp;


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



        //Xác nhận báo cáo nhập xuất
        public bool ConfirmReport()
        {
            SqlCommand command = new SqlCommand("DELETE FROM NhapXuatKho", mydb.GetConnection);
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




        //kiểm tra id sản phẩm có trùng hay không 
        public bool IdNhapCheck(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM NhapXuatKho WHERE Idnhapxuat = @cid", mydb.GetConnection);
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

        public bool IdCheck(string id)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Kho WHERE Idsp = @cid", mydb.GetConnection);
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
            return execCount("select count(*) from Kho ");
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
