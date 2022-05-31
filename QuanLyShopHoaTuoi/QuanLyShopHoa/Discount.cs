using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal interface Discount
    {
        public abstract int LoaiGiamGia();
        public abstract float MucGiamGia();
    }
}
