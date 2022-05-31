using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class TraTao : ThucUong
    {
        public override int GetCost()
        {
            return 700;
        }

        public override string GetDescription()
        {
            return "Tra Tao";
        }
    }
}
