using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_siêu_thị
{
    class IdSpGlobal
    {
        public static String FlagSpId { get; private set; }

        public static void SetGlobalFlagSPId(String SpID)
        {
            FlagSpId = SpID;
        }
    }
}
