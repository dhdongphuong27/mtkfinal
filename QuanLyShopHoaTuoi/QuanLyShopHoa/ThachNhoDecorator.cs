using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class ThachNhoDecorator : ToppingDecorator
    {
        public ThachNhoDecorator(ThucUong thucUong):base(thucUong)
        {
            wrapObj = thucUong;
            tenTopping = "Pudding Trung";
            GiaTien = 22;
        }
        public override int GetCost()
        {
            return wrapObj.GetCost() + GiaTien;
        }

        public override string GetDescription()
        {
            return wrapObj.GetDescription() + " + " + tenTopping;
        }
    }
}
