using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal class Combo5 : LauchCombo
    {
        public override ThucAn MonChinh()
        {
            return new ThucAn("Phở nước", 20000);
        }

        public override ThucAn MonPhu()
        {
            return new ThucAn("Thịt bò", 1000);
        }

        public override ThucAn NuocGiaiKhat()
        {
            return new ThucAn("Nước chanh", 5000);
        }
    }
}
