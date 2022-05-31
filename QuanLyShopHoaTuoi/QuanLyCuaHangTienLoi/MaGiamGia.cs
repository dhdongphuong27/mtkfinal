using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class MaGiamGia
    {
        private CongThucTinhTien strategy;
        private float tien;
        private float mucGiamGia;
        public MaGiamGia(CongThucTinhTien congthuc, float tongTien, float giamGia)
        {
            strategy = congthuc;
            tien = tongTien;
            mucGiamGia = giamGia;
        }
        public MaGiamGia(float tongTien, float giamGia)
        {
            tien = tongTien;
            mucGiamGia = giamGia;
        }
        public void SetCongThucTinhTien(CongThucTinhTien congthuc)
        {
            strategy = congthuc;
        }
        public float TinhTien()
        {
            return strategy.tinhTien(tien,mucGiamGia);
        }
    }
}
