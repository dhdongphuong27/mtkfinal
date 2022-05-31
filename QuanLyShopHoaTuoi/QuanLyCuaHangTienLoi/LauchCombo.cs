using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal abstract class LauchCombo
    {
        public abstract ThucAn MonChinh();
        public abstract ThucAn MonPhu();
        public abstract ThucAn NuocGiaiKhat();
        public Combo ComboOrder()
        {
            return new Combo(MonChinh(), MonPhu(), NuocGiaiKhat());
        }
    }
}
