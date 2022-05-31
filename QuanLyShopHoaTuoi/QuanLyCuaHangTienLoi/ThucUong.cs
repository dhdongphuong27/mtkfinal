using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    abstract class ThucUong
    {
        private int giaTien;
        private String tenMon;
        private String moTa;

        public int GiaTien { get => giaTien; set => giaTien = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string MoTa { get => moTa; set => moTa = value; }

        public abstract String GetDescription();
        public abstract int GetCost();
    }
}
