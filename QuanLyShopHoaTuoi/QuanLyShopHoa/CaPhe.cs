using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class CaPhe : ThucUong
    {
        public override int GetCost()
        {
            return 500;
        }

        public override string GetDescription()
        {
            return "Ca Phe";
        }
    }
}
