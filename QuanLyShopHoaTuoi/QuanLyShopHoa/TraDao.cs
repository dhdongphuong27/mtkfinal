using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class TraDao : ThucUong
    {
        public override int GetCost()
        {
            return 800;
        }

        public override string GetDescription()
        {
            return "Tra Dao";
        }
    }
}
