using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShopHoa
{
    internal class Combo
    {
        private ThucAn monchinh;
        private ThucAn monphu;
        private ThucAn nuocgiaikhat;
        private float gia;
        public Combo(ThucAn monchinh, ThucAn monphu, ThucAn nuocgiaikhat)
        {
            this.monchinh = monchinh;
            this.monphu = monphu;
            this.nuocgiaikhat = nuocgiaikhat;
            gia = monchinh.GetGiaTien() + monphu.GetGiaTien() + nuocgiaikhat.GetGiaTien();
        }
        public ThucAn getMonChinh()
        {
            return monchinh;
        }
        public ThucAn GetMonPhu()
        {
            return monphu;
        }
        public ThucAn GetNuocGiaiKhat()
        {
            return nuocgiaikhat;
        }
        public float getGia()
        {
            return gia*90/100;
        }
    }
}
