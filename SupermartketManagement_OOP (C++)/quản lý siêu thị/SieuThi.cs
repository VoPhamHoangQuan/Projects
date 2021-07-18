using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    class SieuThi:ItfaceNhapXuat,ItfaceSieuThi       //áp dụng interface
    {
        static private string sTensieuthi;          //áp dụng thuộc tính tĩnh
        private string sAddress;
        private List<SanPham> LstDSSanpham;   //áp dụng tính đa hình 
        private List<NhanVien> lNhanVien;

        public string Tensieuthi
        {
            get { return SieuThi.sTensieuthi; }
            set { SieuThi.sTensieuthi = value; }
        }
        public string Address
        {
            get {return this.sAddress; }
            set { this.sAddress = value; }
        }
        public List<SanPham> DSSanPham
        {
            get { return this.LstDSSanpham; }
            set { this.LstDSSanpham = value; }
        }
        public List<NhanVien> NhanVien
        {
            get { return this.lNhanVien; }
            set { this.lNhanVien = value; }
        }

        public SieuThi()
        {
            this.LstDSSanpham = new List<SanPham>();
            this.lNhanVien = new List<NhanVien>();
        }
        public SieuThi(string tensieuthi,string address,List<SanPham> dssanpham, List<NhanVien> NV)
        {
            SieuThi.sTensieuthi = tensieuthi;
            this.sAddress = address;
            this.LstDSSanpham = dssanpham;
            this.lNhanVien = NV;
        }
        public SieuThi(string tensieuthi, string address, List<SanPham> dssanpham)
        {
            SieuThi.sTensieuthi = tensieuthi;
            this.sAddress = address;
            this.LstDSSanpham = dssanpham;
        }
        public SieuThi( List<NhanVien> NV)
        {
            this.lNhanVien = NV;
        }

        ~SieuThi() { }

        //method
        //nhập
        public void Input()
        {
            int luongquanao, luongthucpham, luonggiadung;
            Console.Write("Nhap ten sieu thi: ");
            this.Tensieuthi = Console.ReadLine();
            Console.Write("Nhap dia chi: ");
            this.Address = Console.ReadLine();
            Console.Write("Nhap so luong quan ao: ");
            luongquanao = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cua quan ao");
            for (int i = 0; i < luongquanao; i++)
            {
                SanPham quanao = new QuanAo();
                Console.WriteLine("Mon do thu " + i + ": ");
                quanao.Input();
                this.DSSanPham.Add(quanao);
            }

            Console.Write("Nhap so luong thuc pham: ");
            luongthucpham = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cua thuc pham");
            for (int i = 0; i < luongthucpham; i++)
            {
                SanPham thucpham = new ThucPham();
                Console.WriteLine("Mon do thu " + i + ": ");
                thucpham.Input();
                this.DSSanPham.Add(thucpham);
            }

            Console.Write("Nhap so luong do gia dung: ");
            luonggiadung = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thong tin cua do gia dung");
            for (int i = 0; i < luonggiadung; i++)
            {
                SanPham giadung = new GiaDung();
                Console.WriteLine("Mon do thu " + i + ": ");
                giadung.Input();
                this.DSSanPham.Add(giadung);
            }
        }
        public void Input(string tensieuthi, string address, List<SanPham> dssanpham)
        {
            this.Tensieuthi = tensieuthi;
            this.Address = address;
            this.DSSanPham = dssanpham;
        }

        //Xuất 
        public void Output()
        {
            int x, y, z;
            Console.WriteLine("Tên siêu thị\t\t: " + this.Tensieuthi);
            Console.WriteLine("Địa chỉ     \t\t\t: " + this.Address);
            Console.WriteLine("_____________________________________________________");
            Console.WriteLine("Danh sách sản phẩm");
            for (int i = 0; i < this.DSSanPham.Count; i++)
            {
                Console.WriteLine("==================================================");
                DSSanPham[i].Output();
            }
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Bạn muốn tìm sản phẩm đắt nhất ?");
            Console.Write("Nhập 1 để thực hiện 0 để hủy: ");
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                Console.WriteLine("Sản phẩm có giá đắt nhất là: " + SearchMaxGia().Masp);
                Console.WriteLine("                           :" + SearchMaxGia().Tensp);
            }
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Bạn muốn tìm giá theo tên sp ?");
            Console.Write(    "Nhập 1 để thực hiện 0 để hủy: ");
            x = -1;
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                SanPham temp = SearchWithCode();
                if (temp != null)
                    Console.WriteLine("Giá sản phẩm bạn cần tìm là: " + temp.Giasp);
                else
                    Console.WriteLine("Sản phẩm không có trong danh sách!");
            }
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Bạn có muốn thêm sản phẩm không ?");
            Console.Write("Nhập 1 để thực hiện 0 để hủy: ");
            x = -1;
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                AddSp();
                Console.WriteLine("Danh sách sản phẩm");
                for (int i = 0; i < this.DSSanPham.Count; i++)
                {
                    Console.WriteLine("==================================================");
                    DSSanPham[i].Output();
                }
            }
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Bạn có muốn xóa sản phẩm không ?");
            Console.Write("Nhập 1 để thực hiện 0 để hủy: ");
            x = -1;
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                DeleteSp();
            }
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("Bạn có muốn sắp xếp sản phẩm theo giá");
            Console.Write("Nhập 1 để thực hiện 0 để hủy: ");
            x = -1;
            x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                SortWithGia();
                Console.WriteLine("Danh sach san pham");
                for (int i = 0; i < this.DSSanPham.Count; i++)
                {
                    Console.WriteLine("==================================================");
                    DSSanPham[i].Output();
                }
            }
        }

        //tìm mặt hàng đắt nhất
        public SanPham SearchMaxGia()
        {
            SanPham giamax = this.DSSanPham[0];
            SanPham temp = new SanPham();
            temp = DSSanPham[0];
            for (int i = 0; i < this.DSSanPham.Count; i++)
                if (DSSanPham[i] > giamax)                      //chồng toán tử
                {
                    temp = DSSanPham[i];
                    giamax = DSSanPham[i];
                }
            return temp;
        }
        //tìm sản phẩm theo mã sản phẩm
        public SanPham SearchWithCode()
        {
            string masptemp;
            int kt = 0;
            Console.Write("Nhập mã sp cần tìm: ");
            masptemp = Console.ReadLine();
            for (int i = 0; i < this.DSSanPham.Count; i++)
                if (this.DSSanPham[i].Masp == masptemp)
                    return this.DSSanPham[i];
            return null;
            
        }
        //xếp tất cả sản phẩm theo giá từ thấp tới cao
        //InterchangeSort
        public void SortWithGia()
        {
            SanPham sptemp = new SanPham();
            for (int i = 0; i < this.DSSanPham.Count; i++)
                for (int j = i + 1; j < this.DSSanPham.Count; j++)
                    if (DSSanPham[i].Giasp > DSSanPham[j].Giasp) 
                    {
                        sptemp = DSSanPham[i];
                        DSSanPham[i] = DSSanPham[j];
                        DSSanPham[j] = sptemp;
                    }
        }
        //Them san pham
        public void AddSp()
        {
            string temp;
            Console.Write("Nhập loại sản phẩm cần thêm: ");
            temp = Console.ReadLine();
            if (temp == "Quan ao" || temp == "quan ao")
            {
                SanPham quanaotemp = new QuanAo();
                quanaotemp.Input();
                DSSanPham.Add(quanaotemp);
            }
            else if (temp == "Thuc Pham" || temp == "thuc pham")
            {
                SanPham thucphamtemp = new ThucPham();
                thucphamtemp.Input();
                DSSanPham.Add(thucphamtemp);
            }
            else if (temp == "Gia dung" || temp == "gia dung")
            {
                SanPham giadungtemp = new GiaDung();
                giadungtemp.Input();
                DSSanPham.Add(giadungtemp);
            }  
        }

        //Xóa sản phẩm theo mã sp
        public void DeleteSp()
        {
            string temp;
            Console.Write("Nhập mã sp muốn giá: ");
            temp = Console.ReadLine();
            int dem = 0;
            for (int i = 0; i < this.DSSanPham.Count; i++)
            {
                if (DSSanPham[i].Masp ==temp )
                {
                    dem++;
                    DSSanPham.Remove(DSSanPham[i]);
                }
            }
            if (dem == 0)
                Console.WriteLine("không tìm thấy sản phẩm!");
            else
            {            
                Console.WriteLine("Danh sách sản phẩm sau khi xóa");
                for (int i = 0; i < this.DSSanPham.Count; i++)
                {
                    Console.WriteLine("==================================================");
                    DSSanPham[i].Output();
                }
            }
        }

        // Xuất nhân viên
        public void xuatnv(List<NhanVien> lNV)
        {
            Console.Clear();
            Console.WriteLine("\t\t\t\t DANH SÁCH NHÂN VIÊN");
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.Write(string.Format(" {0, -12} ||", "Mã Nhân Viên"));
            Console.Write(string.Format(" {0, -19} ||", "Tên Nhân Viên "));
            Console.Write(string.Format(" {0, -17} ||", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} ||", "Số Ngày Công"));
            Console.Write(string.Format(" {0, -12} ||", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -12}", "Lương"));
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            for (int i = 0; i < lNV.Count; i++)
                lNV[i].Xuat1();
        }
        // Sắp xếp nhân viên
        public void sapxepnvTL(List<NhanVien> lNV)
        {
            NhanVien temp;
            for (int i = 0; i < lNV.Count - 1; i++)
                for (int j = i + 1; j < lNV.Count; j++)
                    if (lNV[i].LuongCT() < lNV[j].LuongCT())
                    {
                        temp = lNV[i];
                        lNV[i] = lNV[j];
                        lNV[j] = temp;
                    }
            Console.Clear();
            Console.WriteLine("\t\t\t\t DANH SÁCH NHÂN VIÊN");
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.Write(string.Format(" {0, -12} ||", "Mã Nhân Viên"));
            Console.Write(string.Format(" {0, -19} ||", "Tên Nhân Viên "));
            Console.Write(string.Format(" {0, -17} ||", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} ||", "Số Ngày Công"));
            Console.Write(string.Format(" {0, -12} ||", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -12}", "Lương"));
            Console.WriteLine("_____________________________________________________________________________________________________________________");

            for (int i = 0; i < lNV.Count; i++)
                lNV[i].Xuat1();
        }
        // Sửa thông tin nhân viên
        public void suanv(List<NhanVien> lNV)
        {
            int dem = 0;
            int vt = 0;
            Console.WriteLine("Nhập Mã Nhân Viên Cần Sửa: ");
            string NV = Console.ReadLine();
            for (int i = 0; i < lNV.Count; i++)
            {
                if (lNV[i].MaNV == NV)
                {
                    dem++;
                    lNV[i].Xuat();
                    vt = i;
                    break;
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong tim thay !");
            }
            if (dem != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Cập nhật lại nhân viên");
                NhanVien nv = new NVBaoVe();
                nv.Nhap();
                lNV[vt] = nv;
                Console.Clear();
                Console.WriteLine("\t\t\t\t DANH SÁCH NHÂN VIÊN MỚI");
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.Write(string.Format(" {0, -12} ||", "Mã Nhân Viên"));
                Console.Write(string.Format(" {0, -19} ||", "Tên Nhân Viên "));
                Console.Write(string.Format(" {0, -17} ||", "Năm sinh"));
                Console.Write(string.Format(" {0, -12} ||", "Số Ngày Công"));
                Console.Write(string.Format(" {0, -12} ||", "Lương cơ bản"));
                Console.WriteLine(string.Format(" {0, -12}", "Lương"));
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                for (int i = 0; i < lNV.Count; i++)
                    lNV[i].Xuat1();
            }
        }
        // Tìm nhân viên không làm đủ 30 ngày
        public void timkiemnv(List<NhanVien> lNV)
        {
            for (int i = 0; i < lNV.Count; i++)
            {
                if (lNV[i].NgayCong < 30)
                {
                    lNV[i].Xuat1();
                }
            }
        }
        //thêm nhân viên
        public void themnhanvien(List<NhanVien> Lnv)
        {
            Console.WriteLine("Nhập thông tin của nhân viên mới");
            Console.WriteLine("___________________________________");
            NhanVien newnv = new NVBaoVe();
            newnv.Nhap();
            Lnv.Add(newnv);

            Console.WriteLine("\t\t\t\t DANH SÁCH NHÂN VIÊN MỚI");
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            Console.Write(string.Format(" {0, -12} ||", "Mã Nhân Viên"));
            Console.Write(string.Format(" {0, -19} ||", "Tên Nhân Viên "));
            Console.Write(string.Format(" {0, -17} ||", "Năm sinh"));
            Console.Write(string.Format(" {0, -12} ||", "Số Ngày Công"));
            Console.Write(string.Format(" {0, -12} ||", "Lương cơ bản"));
            Console.WriteLine(string.Format(" {0, -12}", "Lương"));
            Console.WriteLine("_____________________________________________________________________________________________________________________");
            for (int i = 0; i < Lnv.Count; i++)
            {
                Lnv[i].Xuat1();
            }
        }
        // Xóa nhân viên
        public void xoanhanvien(List<NhanVien> lNV)
        {
            int vt = 0;
            int dem = 0;
            Console.WriteLine("Nhập Mã Nhân Viên Cần Xóa ");
            string NV = Console.ReadLine();
            for (int i = 0; i < lNV.Count; i++)
            {

                if (lNV[i].MaNV == NV)
                {
                    dem++;
                    lNV.Remove(lNV[i]);
                }
            }
            if (dem != 0)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t DANH SÁCH NHÂN VIÊN MỚI");
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                Console.Write(string.Format(" {0, -12} ||", "Mã Nhân Viên"));
                Console.Write(string.Format(" {0, -19} ||", "Tên Nhân Viên "));
                Console.Write(string.Format(" {0, -17} ||", "Năm sinh"));
                Console.Write(string.Format(" {0, -12} ||", "Số Ngày Công"));
                Console.Write(string.Format(" {0, -12} ||", "Lương cơ bản"));
                Console.WriteLine(string.Format(" {0, -12}", "Lương"));
                Console.WriteLine("_____________________________________________________________________________________________________________________");
                for (int i = 0; i < lNV.Count ; i++)
                {
                    lNV[i].Xuat1();
                }
            }
            if (dem == 0)
                Console.WriteLine("Khong tim thay !");
        }

       
    }
}
