using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class NuocEpTraiCay : ThucUong
    {
        public override int GetCost()
        {
            return 16000;
        }

        public override string GetDescription()
        {
            return "Nuoc Ep Trai Cay";
        }
    }
}
