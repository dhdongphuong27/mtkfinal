using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class TraDao : ThucUong
    {
        public override int GetCost()
        {
            return 15000;
        }

        public override string GetDescription()
        {
            return "Tra Dao";
        }
    }
}
