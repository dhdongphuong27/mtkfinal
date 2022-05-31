using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class NuocEpTraiCay : ThucUong
    {
        public override int GetCost()
        {
            return 600;
        }

        public override string GetDescription()
        {
            return "Nuoc Ep Trai Cay";
        }
    }
}
