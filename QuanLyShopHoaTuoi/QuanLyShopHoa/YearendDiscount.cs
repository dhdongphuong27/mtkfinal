using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal class YearendDiscount : Discount
    {
        public int LoaiGiamGia()
        {
            return 1;
        }

        public float MucGiamGia()
        {
            return 50;
        }
    }
}
