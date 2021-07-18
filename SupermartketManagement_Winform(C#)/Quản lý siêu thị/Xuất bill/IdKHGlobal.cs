using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class IdKHGlobal
    {
        public static string IdKH { get; private set; }

        public static void SetGlobalIdKH(string idkh)
        {
            IdKH = idkh;
        }
    }
}
