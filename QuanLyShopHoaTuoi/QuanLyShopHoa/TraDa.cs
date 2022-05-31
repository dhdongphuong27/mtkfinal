using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class TraDa : ThucUong
    {
        public override int GetCost()
        {
            return 100;
        }

        public override string GetDescription()
        {
            return "Tra Da";
        }
    }
}
