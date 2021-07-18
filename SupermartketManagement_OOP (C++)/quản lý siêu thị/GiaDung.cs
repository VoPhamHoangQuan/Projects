using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    class GiaDung:SanPham
    {
        private string sUses { get; set; }

        public GiaDung() { }
        public GiaDung(string uses, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp) : base(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp)
        {
            this.sUses = uses;
        }

        ~GiaDung() { }

        //methods
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap ten do gia dung: ");
            this.sUses = Console.ReadLine();
        }

        public void Input(string uses, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp)
        {
            base.Input(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp);
            this.sUses = uses;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Chuc nang\t\t: " + this.sUses);
        }
    }
}
