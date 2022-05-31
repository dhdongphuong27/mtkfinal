using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Weekend : AbstractFactory
    {
        public override Bonus Bonus()
        {
            return new WeekendBonus();
        }

        public override Discount Discount()
        {
            return new WeekendDiscount();
        }
    }
}
