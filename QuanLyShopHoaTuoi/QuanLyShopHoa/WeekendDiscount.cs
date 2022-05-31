using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class WeekendDiscount : Discount
    {
        public int LoaiGiamGia()
        {
            return 2;
        }

        public float MucGiamGia()
        {
            return 10000;
        }
    }
}
