using System;
using System.Collections.Generic;
using System.Text;

namespace quản_lý_siêu_thị
{
    class NVBaoVe : NhanVien
    {

        public NVBaoVe()
        {

        }

        ~NVBaoVe()
        {

        }
        public void Nhap(string TenNV, string MaNV, double NamSinh, int NgayCong, int LuongCB)
        {
            this.dNamSinh = NamSinh;
            this.sMaNV = MaNV;
            this.sTenNV = TenNV;
            this.dNgayCong = NgayCong;
            this.dLuongCB = LuongCB;

        }

        public override void Nhap()         //cài đặt phương thức lớp trừu tượng
        {
            Console.Write("Nhập tên nhân viên: ");
            this.sTenNV = Console.ReadLine();
            Console.Write("Nhập mã nhân viên: ");
            this.sMaNV = Console.ReadLine();
            Console.Write("Nhập năm sinh");
            this.dNamSinh = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số ngày công: ");
            this.dNgayCong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập lương cơ bản: ");
            this.dLuongCB = Convert.ToInt32(Console.ReadLine());
        }
        
        public override void Xuat()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Họ tên: " + this.sTenNV);
            Console.WriteLine("Mã nhân viên: " + this.sMaNV);
            Console.WriteLine("Năm sinh: " + this.dNamSinh);
            Console.WriteLine("Lương cơ bản: " + this.dLuongCB);
            Console.WriteLine("Số ngày công: " + this.dNgayCong);
            Console.WriteLine("Lương: " + this.LuongCT());
        }

        public override void Xuat1()
        {
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.Write(string.Format(" {0, -12} ||", this.sMaNV));
            Console.Write(string.Format(" {0, -19} ||", this.sTenNV));
            Console.Write(string.Format(" {0, -17} ||", this.dNamSinh));
            Console.Write(string.Format(" {0, -12} ||", this.dNgayCong));
            Console.Write(string.Format("{0, -12}  ||", this.dLuongCB));
            Console.WriteLine(string.Format(" {0, -12}", this.LuongCT() + " $"));
            Console.WriteLine("_____________________________________________________________________________________________________________________");
        }

        public int LuongCT()
        {
            if (this.dNgayCong > 15)
                return (this.dLuongCB * this.dNgayCong + 100);
            else
                return (this.dLuongCB * this.dNgayCong);
        }
    }
}
