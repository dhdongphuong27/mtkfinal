using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class ThachTraXanhDecorator : ToppingDecorator
    {
        public ThachTraXanhDecorator(ThucUong thucUong):base(thucUong)
        {
            wrapObj = thucUong;
            tenTopping = "Thach Tra Xanh";
            GiaTien = 12;
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
