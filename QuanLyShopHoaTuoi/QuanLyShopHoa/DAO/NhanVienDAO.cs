using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;
        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        public bool InsertNV(string id, string name, string gender, string position, string year, string phone, string Address, float salary)
        {
            string query = string.Format("INSERT into nhanvien (MaNV,Hoten,Gioi,ChucVu,NamSinh,SDT,DiaChi,Luong) VALUES (N'" + id + "',N'" + name+"',N'"+gender+"',N'"+position+"',N'"+year+"',N'"+phone+"',N'"+Address+ "'," + salary + ")");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNV(string ID, string name, string gender, string position, string year, string phone, string Address)
        {
            string query = string.Format("UPDATE nhanvien SET Hoten = N'"+name+"', Gioi = N'"+gender+"', ChucVu = N'"+position+"', NamSinh = N'"+year+"', SDT = N'"+phone+"', DiaChi = N'"+Address+"' WHERE MaNV = '"+ID+"'");
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNV(string ID)
        {
            string query = "DELETE FROM nhanvien WHERE MaNV = '" + ID + "'";
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }
    }
}
