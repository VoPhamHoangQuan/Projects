using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quản_lý_siêu_thị
{
    class Program
    { 
           static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<NhanVien> lNV = new List<NhanVien>();
            dsnv(lNV);
            List<SanPham> lstsp = new List<SanPham>();
            dssp(lstsp);
            Menu(lstsp,lNV);

        }

        static void Menu(List<SanPham> dssanpham, List<NhanVien> lNV)
        {
            int x;
            do
            {
                Console.WriteLine("Tên siêu thị\t\t: " + "Coop Mart");
                Console.WriteLine("Địa chỉ\t\t\t: " + "106 Hai Ba Trung");
                Console.WriteLine("");
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("");
                Console.WriteLine("Chọn ");
                Console.WriteLine("1. Quản lí sản phẩm");
                Console.WriteLine("2. Quản lí nhân viên");
                Console.Write("Lựa chọn: ");
                x = int.Parse(Console.ReadLine());
            }
            while (x != 1 && x != 2);

            if (x == 1)
            {
                Console.Clear();
                QuanliSanPham(dssanpham,lNV);
            }
            if(x==2)
            {
                Console.Clear();
                quanlinhanvien(dssanpham,lNV);
            }

        }

        static void QuanliSanPham(List<SanPham> dssanpham,List<NhanVien> lNV)
        {
            int x = -1, y;
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Danh sách sản phẩm");
            for (int i = 0; i < dssanpham.Count; i++)
            {
                Console.WriteLine("==================================================");
                dssanpham[i].Output();
            }
            SieuThi T = new SieuThi("Coop Mart", "106 Hai Ba Trung", dssanpham);
            Console.WriteLine("1. Thao tác trên danh sách");
            Console.WriteLine("2. Quay lai");
            Console.Write("Lựa chọn: ");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.Clear();
                T.Output();
                Console.WriteLine("1. Quay lai mang hinh chinh");
                Console.WriteLine("2. Thoat chuong trinh");
                y = int.Parse(Console.ReadLine());
                if (y == 1)
                {
                    Console.Clear();
                    Menu(dssanpham, lNV);
                }
                else
                    Environment.Exit(0);

            }
            else
            {
                Console.Clear();
                Menu(dssanpham,lNV);
            }

        }

        static void dssp(List<SanPham> Lstsp)
        {
            SanPham x = new QuanAo("S", "pink", "Man", "GUCCI", "12345A", "Jean", "Quan ao", "12/12/2019", "None", 1, 100);
            SanPham y = new ThucPham("1 kg", "meat", "12345B", "beef", "thuc pham", "12/1/2019", "14/1/2019", 100, 10);
            SanPham z = new GiaDung("for sit", "12345C", "chair", "gia dung", "12/11/2019", "none", 12, 10000);
            Lstsp.Add(x);
            Lstsp.Add(y);
            Lstsp.Add(z);
        }

        static void dsnv(List<NhanVien> lNV)
        {

            NVThuNgan nv1 = new quản_lý_siêu_thị.NVThuNgan();
            NVThuNgan nv2 = new quản_lý_siêu_thị.NVThuNgan();
            NVThuNgan nv3 = new quản_lý_siêu_thị.NVThuNgan();
            NVThuNgan nv4 = new quản_lý_siêu_thị.NVThuNgan();
            nv1.Nhap("Trần Vũ Quốc", "NVTN01", 2000, 30, 25);
            nv2.Nhap("Võ Phạm Hoàng Quân", "NVTN02", 2000, 30, 24);
            nv3.Nhap("Hoàng Mạnh Tiến", "NVBV01", 2000, 25, 29);
            nv4.Nhap("Phạm Quốc Toàn", "NVBV02", 2000, 25, 28);
            lNV.Add(nv1);
            lNV.Add(nv2);
            lNV.Add(nv3);
            lNV.Add(nv4);
        }

        // quản lí nhân viên
        static void quanlinhanvien(List<SanPham> dssanpham, List<NhanVien> lNV)
        {
            Console.Clear();
            int n;
            Console.WriteLine("\t\t\t=======QUẢN LÍ NHÂN VIÊN=======");
            Console.WriteLine("1. Danh sách nhân viên");
            Console.WriteLine("2. Sắp xếp theo lương");
            Console.WriteLine("3. Sửa thông tin nhân viên");
            Console.WriteLine("4. Danh sách nhân viên làm thiếu ngày");
            Console.WriteLine("5. Thêm nhân viên");
            Console.WriteLine("6. Xóa nhân viên");
            Console.WriteLine("0. Quay lại");
            n = int.Parse(Console.ReadLine());
            while (n != 0 && n != 1 && n != 2 && n != 3 && n != 9 && n != 4 && n != 5 && n != 6)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t=======QUẢN LÍ NHÂN VIÊN=======");
                Console.WriteLine("1. Danh sách nhân viên");
                Console.WriteLine("2. Sắp xếp theo lương");
                Console.WriteLine("3. Sửa thông tin nhân viên");
                Console.WriteLine("4. Danh sách nhân viên làm thiếu ngày");
                Console.WriteLine("5. Thêm nhân viên");
                Console.WriteLine("6. Xóa nhân viên");
                Console.WriteLine("0. Quay lại");
                n = int.Parse(Console.ReadLine());
            }
            if (n == 0)
            {
                Console.Clear();
                Menu(dssanpham,lNV);
            }
            if (n == 1)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.xuatnv(lNV);
                Console.WriteLine();
                Console.WriteLine("Ghi chú: 'NV' là nhân viên thu ngân");
                Console.WriteLine("         'BH' là nhân viên bảo vệ");
                Console.Write("0. Quay lại");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham,lNV);
                }
            }
            if (n == 2)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.sapxepnvTL(lNV);
                Console.Write("0. Quay lại   ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham,lNV);
                }
            }
            if (n == 3)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.xuatnv(lNV);
                Console.WriteLine();
                st.suanv(lNV);
                Console.Write("0. Quay lại   ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham,lNV);
                }
            }
            if (n == 4)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.timkiemnv(lNV);
                Console.Write("0. Quay lại   ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham,lNV);
                }
            }
            if (n == 5)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.xuatnv(lNV);
                Console.WriteLine();
                st.themnhanvien(lNV);
                Console.Write("0. Quay lại   ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham, lNV);
                }

            }
            if (n == 6)
            {
                Console.Clear();
                SieuThi st = new SieuThi();
                st.xuatnv(lNV);
                Console.WriteLine();
                st.xoanhanvien(lNV);
                Console.Write("0. Quay lại   ");
                n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    quanlinhanvien(dssanpham,lNV);
                }
            }
        }
    }
}
