using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class ThachPhoMaiDecorator : ToppingDecorator
    {
        public ThachPhoMaiDecorator(ThucUong thucUong):base(thucUong)
        {
            wrapObj = thucUong;
            tenTopping = "Thach Pho Mai";
            GiaTien = 20;
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
