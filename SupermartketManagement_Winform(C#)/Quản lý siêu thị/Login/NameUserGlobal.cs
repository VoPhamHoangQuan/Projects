using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class NameUserGlobal
    {
        public static string NameUser { get; private set; }

        public static void SetGlobalNameUser(string user)
        {
            NameUser = user;
        }
    }
}
