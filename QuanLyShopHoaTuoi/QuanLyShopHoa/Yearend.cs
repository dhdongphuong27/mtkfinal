using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal class Yearend : AbstractFactory
    {
        public override Bonus Bonus()
        {
            return new YearendBonus();
        }

        public override Discount Discount()
        {
            return new YearendDiscount();
        }
    }
}
