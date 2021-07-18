using System;
using System.Collections.Generic;
using System.Text;

namespace quản_lý_siêu_thị
{
    abstract class NhanVien
    {
        protected string sTenNV;
        protected string sMaNV;
        protected double dNamSinh;
        protected int dLuongCB;
        protected int dNgayCong;

        public string TenNV
        {
            get { return this.sTenNV; }
            set { this.sTenNV = value; }
        }
        public string MaNV
        {
            get { return this.sMaNV; }
            set { this.sMaNV = value; }
        }
        public double NamSinh
        {
            get { return this.dNamSinh; }
            set { this.dNamSinh = value; }
        }
        public int LuongCB
        {
            get { return this.dLuongCB; }
            set { this.dLuongCB = value; }
        }
        public int NgayCong
        {
            get { return this.dNgayCong; }
            set { this.dNgayCong = value; }
        }

        public abstract void Nhap();


        //public void Nhap1()
        //{
        //    Console.WriteLine("Nhập năm sinh");
        //    this.dNamSinh = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Nhập số ngày công: ");
        //    this.dNgayCong = Convert.ToInt32(Console.ReadLine());
        //    Console.Write("Nhập lương cơ bản: ");
        //    this.dLuongCB = Convert.ToInt32(Console.ReadLine());
        //}


        //public abstract Nhap(string TenNV, string MaNV, double NamSinh, int NgayCong, int LuongCB);


        public abstract void Xuat();

        public abstract void Xuat1();
        
        public int LuongCT()
        {
            return (this.dLuongCB * this.dNgayCong);
        }

      

    }
}
