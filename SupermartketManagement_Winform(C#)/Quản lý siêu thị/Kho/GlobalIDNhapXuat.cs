using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class GlobalIDNhapXuat
    {
        public static string Idnhapxuat { get; private set; }

        public static void SetGlobalIdnhapxuat(string Id)
        {
            Idnhapxuat = Id;
        }
    }
}
