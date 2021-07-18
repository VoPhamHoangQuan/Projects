using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quản_lý_siêu_thị
{
    public partial class TimeInAndTimeOut : Form
    {
        public TimeInAndTimeOut()
        {
            InitializeComponent();
        }

        MY_DB mydb = new MY_DB();


        public void GetImageAndUserName()
        {
            SqlCommand command = new SqlCommand("SELECT NV.fname,NV.lname,NV.bdate,NV.gender,NV.address,NV." +
            "phone,NV.type, NV.picture FROM NV INNER JOIN Log_in_NV on NV.id = Log_in_NV.id WHERE NV.id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = IdNVGlobal.FlagUserId; //lấy id từ lớp global

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                byte[] pic = (byte[])table.Rows[0]["picture"];
                MemoryStream picture = new MemoryStream(pic);
                pictureBoxNhanVien.Image = Image.FromStream(picture);
                labelFName.Text = "First Name: " + table.Rows[0]["fname"].ToString();
                labelLastName.Text = "Last Name: " + table.Rows[0]["lname"].ToString();
                //DateTimePickerBDate.Value = (DateTime)table.Rows[0]["bdate"];
                labelBirthday.Text = "Birthday: " + table.Rows[0]["bdate"].ToString();
                labelGender.Text = "Gender: " + table.Rows[0]["gender"].ToString();
                labelPhone.Text = "Phone: " + table.Rows[0]["phone"].ToString();
                labelAddress.Text = "Address: " + table.Rows[0]["address"].ToString();
                labelLoaiNhanVien.Text = "Job Type: " + table.Rows[0]["type"].ToString();
                labelWellcome.Text = "WELLCOME " + "<< " + table.Rows[0]["lname"].ToString() + " >>";
            }
        }
        Timer t = new Timer();

        private void TimeInAndTimeOut_Load(object sender, EventArgs e)
        {
            GetImageAndUserName();
            t.Interval = 1000;
            t.Tick += new EventHandler(this.timer1_Tick);
            t.Start();
            LoadLuong();
        }

        // time để chạy nhé !!!!
        private void timer1_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            //int MM = DateTime.Now.Month;

            string time = "";
            string time2 = " ";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time2 += ":";
            if (mm < 10)
            {
                time2 += "0" + mm;
            }
            else
            {
                time2 += mm;
            }
            time2 += ":";
            if (ss < 10)
            {
                time2 += "0" + ss;
            }
            else
            {
                time2 += ss;
            }

            labelTime.Text = time;
            labelTime2.Text = time2;
        }

        Employees NhanVien = new Employees();

        // check in nhé!!!!
        private void buttonCheck_in_Click(object sender, EventArgs e)
        {
            //int id = IdNVGlobal.FlagUserId;
            //string check_in_hours = labelTime.Text;
            //string check_in_mnsc = labelTime2.Text;
            //string check_out_hours = "";
            //string check_out_mnsc = "";
            //if (NhanVien.InsertCheck_in(id, check_in_hours, check_in_mnsc, check_out_hours, check_out_mnsc))
            //{
            //    MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    //dataGridViewManageEmployee.DataSource = NhanVien.GetAllNhanvien();
            //}
            //else
            //{
            //    MessageBox.Show("Insert Employee Unsuccess", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        // check out nhé !!!!
        private void buttonCheck_out_Click(object sender, EventArgs e)
        {
            //SqlCommand command = new SqlCommand("SELECT * FROM Time WHERE id =@id", mydb.GetConnection);
            //command.Parameters.Add("@id", SqlDbType.Int).Value = IdNVGlobal.FlagUserId; //lấy id từ lớp global

            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable table = new DataTable();

            //adapter.Fill(table);

            //if (table.Rows.Count > 0)
            //{
            //    if (table.Rows[0]["check_in_hours"].ToString() != null)
            //    {

            //        int id = IdNVGlobal.FlagUserId;
            //        string check_out_hours = labelTime.Text;
            //        string check_out_mnsc = labelTime2.Text;
            //        if (NhanVien.UpdateCheck_out(id, check_out_hours, check_out_mnsc))
            //        {
            //            MessageBox.Show("New Employee Added", "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //dataGridViewManageEmployee.DataSource = NhanVien.GetAllNhanvien();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Insert Employee Unsuccess", "Add Employee  ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Bạn chưa Log in", "Log_in ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
        }

        // tính lương nhé !!!
        public void LoadLuong()
        {
            SqlCommand command = new SqlCommand("SELECT NV.type,Time.check_in_hours,Time.check_out_hours FROM NV INNER JOIN Time on NV.id = Time.id WHERE NV.id=@id", mydb.GetConnection);
            command.Parameters.Add("@id", SqlDbType.Int).Value = IdNVGlobal.FlagUserId; //lấy id từ lớp global

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();

            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                int calam = Convert.ToInt32(table.Rows[0]["check_out_hours"].ToString()) - Convert.ToInt32(table.Rows[0]["check_in_hours"].ToString());
                if (table.Rows[0]["type"].ToString() == "Vệ Sinh")
                {
                    int luong = calam * 60000;
                    if (calam < 8)
                    {
                        // lương cuối cùng ấy!!!
                        int luongc = luong - ((8 - calam) * 10000);
                        labelLuong.Text = luongc.ToString();
                    }
                    else
                    {
                        labelLuong.Text = "Salary: " + luong.ToString();
                    }
                }
                else if (table.Rows[0]["type"].ToString() == "Bán Hàng")
                {
                    int luong = calam * 100000;
                    if (calam < 8)
                    {
                        // lương cuối cùng ấy!!!
                        int luongc = luong - ((8 - calam) * 10000);
                        labelLuong.Text = "Salary: " + luongc.ToString();
                    }
                    else
                    {
                        labelLuong.Text = "Salary: " + luong.ToString();
                    }
                }

                else if (table.Rows[0]["type"].ToString() == "Quản Lý")
                {
                    int luong = calam * 999999;
                    if (calam < 8)
                    {
                        // lương cuối cùng ấy!!!
                        int luongc = luong - ((8 - calam) * 10000);
                        labelLuong.Text = "Salary: " + luongc.ToString();
                    }
                    else
                    {
                        labelLuong.Text = "Salary: " + luong.ToString();
                    }
                }

            }
        }

        private void labelTime2_Click(object sender, EventArgs e)
        {

        }
    }
}
