using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class TraSua : ThucUong
    {
        public override int GetCost()
        {
            return 20000;
        }

        public override string GetDescription()
        {
            return "Tra Sua";
        }
    }
}
