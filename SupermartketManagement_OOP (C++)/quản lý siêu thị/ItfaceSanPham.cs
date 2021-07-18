using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quản_lý_siêu_thị
{
    interface ItfaceSanPham
    {
       
        //thay thông tin sản phẩm
        void ChangeMasp();
        void ChangeTensp();
        void ChangeLoaisp();
        void ChangeNSX();
        void ChangeHSD();
        void ChangeSoLuongsp();
        void ChangeGiasp();
    }
}
