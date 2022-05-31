using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class TraDa : ThucUong
    {
        public override int GetCost()
        {
            return 5000;
        }

        public override string GetDescription()
        {
            return "Tra Da";
        }
    }
}
