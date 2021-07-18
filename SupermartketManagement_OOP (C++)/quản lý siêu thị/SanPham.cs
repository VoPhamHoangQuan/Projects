using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    class SanPham : ItfaceSanPham, ItfaceNhapXuat        //ứng dụng interface
    {
        //Fieds
        private string sMasp;
        private string sTensp;
        private string sLoaisp;
        private string sNSX;
        private string sHSD;
        private int iSoLuongsp;
        private double dGiasp;

        public string Masp
        {
            get { return this.sMasp; }
            set { this.sMasp = value; }
        }
        public string Tensp
        {
            get { return this.sTensp; }
            set { this.sTensp = value; }
        }
        public string Loaisp
        {
            get { return this.sLoaisp; }
            set { this.sLoaisp = value; }
        }
        public string NSX
        {
            get { return this.sNSX; }
            set { this.sNSX = value; }
        }
        public string HSD
        {
            get { return this.sHSD; }
            set { this.sHSD = value; }
        }
        public int SoLuongsp
        {
            get { return this.iSoLuongsp; }
            set { this.iSoLuongsp = value; }
        }
        public double Giasp
        {
            get { return this.dGiasp; }
            set { this.dGiasp = value; }
        }
        //constructors
        public SanPham()
        {
        }
        public SanPham(string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp)
        {
            this.sMasp = masp;
            this.sTensp = tensp;
            this.sLoaisp = loaisp;
            this.sNSX = nsx;
            this.sHSD = hsd;
            this.iSoLuongsp = soluongsp;
            this.dGiasp = giasp;
        }

        //Finalize
        ~SanPham() { }

        //methods
        //input
        public virtual void Input()
        {
            Console.Write("Nhap ten san pham    : ");
            this.sTensp = Console.ReadLine();
            Console.Write("Nhap ma san pham     : ");
            this.sMasp = Console.ReadLine();
            Console.Write("Nhap loai san pham   : ");
            this.sLoaisp = Console.ReadLine();
            Console.Write("Nhap NSX san pham    : ");
            this.sNSX = Console.ReadLine();
            Console.Write("Nhap HSD san pham    : ");
            this.sHSD = Console.ReadLine();
            Console.Write("Nhap so san pham     : ");
            this.iSoLuongsp = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia san pham    : ");
            this.dGiasp = double.Parse(Console.ReadLine());
        }

        public void Input(string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp)
        {
            this.sMasp = masp;
            this.sTensp = tensp;
            this.sLoaisp = loaisp;
            this.sNSX = nsx;
            this.sHSD = hsd;
            this.iSoLuongsp = soluongsp;
            this.dGiasp = giasp;
        }

        //output
        public virtual void Output()
        {
            Console.WriteLine("Tên sản phẩm     \t: " + this.sTensp);
            Console.WriteLine("Mã sản phẩm      \t: " + this.sMasp);
            Console.WriteLine("Loại sản phẩm    \t: " + this.sLoaisp);
            Console.WriteLine("NXS              \t: " + this.sNSX);
            Console.WriteLine("HSD              \t: " + this.sHSD);
            Console.WriteLine("Số lượng         \t: " + this.iSoLuongsp);
            Console.WriteLine("Giá của sản phẩm \t: " + this.dGiasp);
        }

        //change "masp" of product
        public void ChangeMasp()
        {
            string newMasp;
            Console.Write("Nhập code mới của sản phẩm: ");
            newMasp = Console.ReadLine();
            this.sMasp = newMasp;
        }

        //Change infomation of product
        public void ChangeTensp()
        {
            string newTensp;
            Console.Write("Nhập tên mới của sản phẩm: ");
            newTensp = Console.ReadLine();
            this.sTensp = newTensp;
        }
        public void ChangeLoaisp()
        {
            string newLoaisp;
            Console.Write("Nhập loại mới của sản phẩm: ");
            newLoaisp = Console.ReadLine();
            this.sLoaisp = newLoaisp;
        }
        public void ChangeNSX()
        {
            string newNSX;
            Console.Write("Nhập NSX mới của sản phẩm: ");
            newNSX = Console.ReadLine();
            this.sNSX = newNSX;
        }
        public void ChangeHSD()
        {
            string newHSD;
            Console.Write("Nhập HSD của sản phẩm: ");
            newHSD = Console.ReadLine();
            this.sHSD = newHSD;
        }
        public void ChangeSoLuongsp()
        {
            int newLuong;
            Console.Write("Nhập số lượng mới của sản phẩm: ");
            newLuong = int.Parse(Console.ReadLine());
            this.iSoLuongsp = newLuong;
        }
        public void ChangeGiasp()
        {
            double newGia;
            Console.Write("Nhập giá mới của sản phẩm: ");
            newGia = double.Parse(Console.ReadLine());
            this.dGiasp = newGia;
        }


        //Định nghĩa phép so sánh > cho giá của sản phẩm
        //chồng toán tử 
        public static bool operator >(SanPham a, SanPham b)
        {
            return (a.Giasp > b.Giasp);

        }
        public static bool operator <(SanPham a,SanPham b)
        {
            return (a.Giasp < b.Giasp);
        }

    }
}
