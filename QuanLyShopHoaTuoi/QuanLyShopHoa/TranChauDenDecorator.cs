using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    class TranChauDenDecorator : ToppingDecorator
    {
        public TranChauDenDecorator(ThucUong thucUong):base(thucUong)
        {
            wrapObj = thucUong;
            tenTopping = "Tran Chau Den";
            GiaTien = 5;
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
