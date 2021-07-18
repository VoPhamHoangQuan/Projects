using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class IdNVGlobal
    {
        public static string FlagUserId { get; private set; }

        public static void SetGlobalIdUser(string userid)
        {
            FlagUserId = userid;
        }
    }
}
