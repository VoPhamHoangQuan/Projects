using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class CheckPartLoginGlobal
    {
        public static string FlagUser { get; private set; }

        public static void SetGlobalFlagUser(string position)
        {
            FlagUser = position;
        }
    }
}
