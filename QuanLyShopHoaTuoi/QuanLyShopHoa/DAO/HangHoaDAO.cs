using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.DAO
{
    public class HangHoaDAO
    {
        private static HangHoaDAO instance;
        public static HangHoaDAO Instance
        {
            get { if (instance == null) instance = new HangHoaDAO(); return HangHoaDAO.instance; }
            private set { HangHoaDAO.instance = value; }
        }
        public bool InsertHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("INSERT into hanghoa (MaHH,TenHH,XuatXu,GiaBan,SL) VALUES (N'"+id+"',N'"+name+"',N'"+from+"',N'"+price+"',N'"+number+"')");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateHH(string id, string name, string from, float price, int number)
        {
            string query = string.Format("UPDATE hanghoa SET TenHH = N'"+name+"', XuatXu = N'"+from+"', GiaBan = N'"+price+"', SL = N'"+number+"' WHERE MaHH = '"+id+"'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteHH(string id)
        {
            string query = "DELETE FROM hanghoa WHERE MaHH = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
