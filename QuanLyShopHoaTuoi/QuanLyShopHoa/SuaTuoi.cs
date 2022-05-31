using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class SuaTuoi : ThucUong
    {
        public override int GetCost()
        {
            return 10000;
        }

        public override string GetDescription()
        {
            return "Sua Tuoi";
        }
    }
}
