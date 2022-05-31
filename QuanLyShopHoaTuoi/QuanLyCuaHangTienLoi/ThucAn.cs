using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    internal class ThucAn
    {
        private String tenMon;
        private float giaTien;
        public ThucAn(string tenMon, float giaTien)
        {
            this.tenMon = tenMon;
            this.giaTien = giaTien;
        }
        public String GetTenMon()
        {
            return tenMon;
        }
        public float GetGiaTien()
        {
            return giaTien;
        }
    }
}
