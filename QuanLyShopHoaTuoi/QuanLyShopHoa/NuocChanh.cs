using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class NuocChanh : ThucUong
    {
        public override int GetCost()
        {
            return 9500;
        }

        public override string GetDescription()
        {
            return "Nuoc Chanh";
        }
    }
}
