using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Combo3 : LauchCombo
    {
        public override ThucAn MonChinh()
        {
            return new ThucAn("Mì nước", 20000);
        }

        public override ThucAn MonPhu()
        {
            return new ThucAn("Xúc xích", 6000);
        }

        public override ThucAn NuocGiaiKhat()
        {
            return new ThucAn("Fanta", 10000);
        }
    }
}
