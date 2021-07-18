using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    interface ItfaceSieuThi
    {
        //tìm mặt hàng đắt nhất
        SanPham SearchMaxGia();
        //tìm sản phẩm theo mã sản phẩm
        SanPham SearchWithCode();
        //xếp tất cả sản phẩm theo giá từ thấp tới cao
        void SortWithGia();
        //Them san pham
        void AddSp();
        //Xóa sản phẩm theo mã sp
        void DeleteSp();
       
    }
}
