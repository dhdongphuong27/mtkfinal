using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.DAO
{
    public class DonHangDAO
    {
        private static DonHangDAO instance;
        public static DonHangDAO Instance
        {
            get { if (instance == null) instance = new DonHangDAO(); return DonHangDAO.instance; }
            private set { DonHangDAO.instance = value; }
        }
        public bool InsertDH(int idhd, string idhh, string name, float price, int num, float totalprice)
        {
            string query = string.Format("INSERT INTO donhang (SoHD, MaHH, TenHH, DonGia, SL, ThanhTien) VALUES ('"+ idhd + "',N'"+ idhh + "',N'"+ name + "','"+ price + "','"+ num + "','"+ totalprice + "')");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteDH(string id)
        {
            string query = "DELETE FROM donhang WHERE MaHH = " + id;
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
