using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Combo4 : LauchCombo
    {
        public override ThucAn MonChinh()
        {
            return new ThucAn("Mì nước", 20000);
        }

        public override ThucAn MonPhu()
        {
            return new ThucAn("Trứng", 5000);
        }

        public override ThucAn NuocGiaiKhat()
        {
            return new ThucAn("Sting", 10000);
        }
    }
}
