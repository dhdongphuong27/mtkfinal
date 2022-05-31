using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
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
