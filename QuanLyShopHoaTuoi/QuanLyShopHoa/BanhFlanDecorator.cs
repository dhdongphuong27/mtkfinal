using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class BanhFlanDecorator : ToppingDecorator
    {
        public BanhFlanDecorator(ThucUong thucUong):base(thucUong)
        {
            wrapObj = thucUong;
            tenTopping = "Banh Flan";
            GiaTien = 11;
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
