using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    class QuanAo:SanPham
    {
        private string sSize { get; set; }
        private string sColor { get; set; }
        private string sSexual { get; set; }
        private string sBrand { get; set; }

        public QuanAo() { }
        public QuanAo(string size, string color, string sexual, string brand, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp) : base(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp)
        {
            this.sSize = size;
            this.sColor = color;
            this.sSexual = sexual;
            this.sBrand = brand;
        }

        ~QuanAo() { }

        //methods
        public override void Input()
        {
            base.Input();
            Console.Write("Nhập thương hiệu: ");
            this.sBrand = Console.ReadLine();

            Console.Write("Nhập kích cỡ: ");
            this.sSize = Console.ReadLine();
            Console.Write("Quần áo cho nam hay nữ: ");
            this.sSexual = Console.ReadLine();
            Console.Write("Nhap mau cua quan ao: ");
            this.sColor = Console.ReadLine();
        }

        public void Input(string size, string color, string sexual, string brand, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp)
        {
            base.Input(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp);
            this.sSize = size;
            this.sColor = color;
            this.sSexual = sexual;
            this.sBrand = brand;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Thương hiệu     \t: " + this.sBrand);
            Console.WriteLine("Kích cỡ         \t: " + this.sSize);
            Console.WriteLine("Quần áo dành cho\t: " + this.sSexual);
            Console.WriteLine("Màu             \t: " + this.sColor);

        }


    }
}
