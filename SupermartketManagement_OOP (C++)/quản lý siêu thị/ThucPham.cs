using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    class ThucPham:SanPham
    {
        private string sWeight { get; set; }
        private string sKind { get; set; }

        public ThucPham() { }
        public ThucPham(string weight, string kind, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp) : base(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp)
        {
            this.sWeight = weight;
            this.sKind = kind;          
        }

        ~ThucPham() { }

        //methods
        public override void Input()
        {
            base.Input();
            Console.Write("Nhap loai thuc pham: ");
            this.sKind = Console.ReadLine();
            Console.Write("Nhap so luong thuc pham: ");
            this.sWeight = Console.ReadLine();
        }

            public void Input(string weight, string kind, string masp, string tensp, string loaisp, string nsx, string hsd, int soluongsp, double giasp)
        {
            base.Input(masp, tensp, loaisp, nsx, hsd, soluongsp, giasp);
            this.sWeight = weight;
            this.sKind = kind;
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine("Thực phẩm là \t\t:" + this.sKind);
            Console.WriteLine("Lương thực muốn mua:" + this.sWeight);
        }
    }
}
    