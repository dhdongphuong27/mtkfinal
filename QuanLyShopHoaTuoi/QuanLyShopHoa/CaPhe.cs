using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class CaPhe : ThucUong
    {
        public override int GetCost()
        {
            return 12000;
        }

        public override string GetDescription()
        {
            return "Ca Phe";
        }
    }
}
