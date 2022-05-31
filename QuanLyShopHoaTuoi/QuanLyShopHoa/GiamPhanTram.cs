using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class GiamPhanTram : CongThucTinhTien
    {
        public float tinhTien(float TongTien, float giaTri)
        {
            return TongTien*(1-giaTri/100);
        }
    }
}
