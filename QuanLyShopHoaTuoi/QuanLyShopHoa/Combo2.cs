using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Combo2 : LauchCombo
    {
        public override ThucAn MonChinh()
        {
            return new ThucAn("Cơm tấm", 20000);
        }

        public override ThucAn MonPhu()
        {
            return new ThucAn("Canh cà chua", 5000);
        }

        public override ThucAn NuocGiaiKhat()
        {
            return new ThucAn("7Up", 10000);
        }
    }
}
