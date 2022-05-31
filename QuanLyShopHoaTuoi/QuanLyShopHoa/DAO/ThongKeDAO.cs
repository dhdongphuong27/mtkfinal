using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.DAO
{
    public class ThongKeDAO
    {
        private static ThongKeDAO instance;

        public static ThongKeDAO Instance
        {
            get { if (instance == null) instance = new ThongKeDAO(); return ThongKeDAO.instance; }
            private set { ThongKeDAO.instance = value; }
        }

        public bool InsertTK(DateTime date)
        {
            string query = string.Format("INSERT into thongke (NgayTK) VALUES (NOW())");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTK(int id, float collect, float spend, float income)
        {
            string query = string.Format("UPDATE thongke SET Thu = '"+collect+"', Chi = '"+spend+"', DoanhThu = '"+income+"' WHERE ID = '"+id+"'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTK(int id)
        {
            string query = "DELETE FROM thongke WHERE ID = '" + id + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
