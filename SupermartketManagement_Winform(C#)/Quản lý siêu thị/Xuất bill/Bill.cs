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
    class Bill
    {
        MY_DB mydb = new MY_DB();

        //thêm món hàng vào hóa đơn
        public bool insertBill( String sp, int sl, float thanhtien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Bill( Sp, Sl, Tongtien)" +
                "VALUES ( @sp, @sl, @tong)", mydb.GetConnection);
           // command.Parameters.Add("@idbill", SqlDbType.Int).Value = Idbill;
            command.Parameters.Add("@sp", SqlDbType.NVarChar).Value = sp;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
            command.Parameters.Add("@tong", SqlDbType.Float).Value = thanhtien;
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

        //thêm món hàng vào doanh thu
        public bool insertTotalBill(DateTime ngay, String tensp, String idnv, int sl, float tien)
        {
            SqlCommand command = new SqlCommand("INSERT INTO BillDetail(Ngay, Tensp, Idnv, Slmua, Tien)" +
                "VALUES ( @ngay, @tensp, @idnv, @sl, @tien)", mydb.GetConnection);
            //command.Parameters.Add("@id", SqlDbType.Int).Value = id;      
            command.Parameters.Add("@ngay", SqlDbType.DateTime).Value = ngay;
            command.Parameters.Add("@Tensp", SqlDbType.NVarChar).Value = tensp;
            command.Parameters.Add("@idnv", SqlDbType.NChar).Value = idnv;
            command.Parameters.Add("@sl", SqlDbType.Int).Value = sl;
            command.Parameters.Add("@tien", SqlDbType.Float).Value = tien;
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

        //lấy dữ liệu hóa đơn
        public DataTable getBill(SqlCommand command)
        {
            command.Connection = mydb.GetConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //xóa hóa đơn
        public bool deleteBill()
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill", mydb.GetConnection);
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

        //xóa Doanh thu trong ngày
        public bool deleteTotalBill()
        {
            SqlCommand command = new SqlCommand("DELETE FROM BillDetail", mydb.GetConnection);
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

        //cập nhật món hàng trong doanh thu  
        //public bool updateTotalBill(String sp, int sl, float thanhtien)
        //{
        //    SqlCommand command = new SqlCommand("UPDATE TotalBill SET amount=@am,price=@pr WHERE id =@id AND name=@name", mydb.GetConnection);
        //    command.Parameters.Add("@id", SqlDbType.Int).Value = id;
        //    command.Parameters.Add("@am", SqlDbType.Int).Value = amount;
        //    command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        //    command.Parameters.Add("@pr", SqlDbType.Int).Value = price;
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

        //cập nhật món hàng trong hóa đơn
        public bool updateBill(String sp, int sl, float thanhtien)
        {
            SqlCommand command = new SqlCommand("UPDATE Bill SET Sl=@am,Tongtien=@pr WHERE Sp=@name", mydb.GetConnection);
            command.Parameters.Add("@am", SqlDbType.Int).Value = sl;
            command.Parameters.Add("@name", SqlDbType.NVarChar).Value = sp;
            command.Parameters.Add("@pr", SqlDbType.Int).Value = thanhtien;
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

        //xóa món hàng ra khỏi hóa đơn
        public bool DeleteBill(string name)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Bill WHERE Sp=@n", mydb.GetConnection);
            command.Parameters.Add("@n", SqlDbType.NVarChar).Value = name;
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

        //đếm số lượng món hàng có trong hóa đơn
        public int CountProduct()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Bill ", mydb.GetConnection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(table);

            int kq = table.Rows.Count;
            return kq;

        }
    }
}
