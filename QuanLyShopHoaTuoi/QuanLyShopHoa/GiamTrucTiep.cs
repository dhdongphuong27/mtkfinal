using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class GiamTrucTiep : CongThucTinhTien
    {
        public float tinhTien(float TongTien, float giaTri)
        {
            return TongTien - giaTri;
        }
    }
}
