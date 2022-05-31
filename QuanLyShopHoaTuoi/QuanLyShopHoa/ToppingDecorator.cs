using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    abstract class ToppingDecorator:ThucUong
    {
        public String tenTopping;
        public int giaBan;
        protected ThucUong wrapObj;
        public ToppingDecorator(ThucUong thucUong)
        {
            wrapObj = thucUong;
        }
        public int GetCost(int giaTien)
        {
            return giaTien + giaBan;
        }
    }
}
