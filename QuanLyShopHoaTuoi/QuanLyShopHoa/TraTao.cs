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
            return 17000;
        }

        public override string GetDescription()
        {
            return "Tra Tao";
        }
    }
}
