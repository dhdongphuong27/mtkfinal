using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Combo1 : LauchCombo
    {
        public override ThucAn MonChinh()
        {
            return new ThucAn("Cơm tấm", 20000);
        }

        public override ThucAn MonPhu()
        {
            return new ThucAn("Canh cải", 4000);
        }

        public override ThucAn NuocGiaiKhat()
        {
            return new ThucAn("Pepsi", 10000);
        }
    }
}
