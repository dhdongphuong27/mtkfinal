using QuanLyCuaHangTienLoi.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class Account
    {
        private String id;
        public Account(String id)
        {
            this.id = id;
        }
        public void Open()
        {
            String query = string.Format("UPDATE nhanvien SET TrangThai = 'Present' WHERE MaNV ='" + id + "'");
            DataProvider.Instance.ExcuteNonQuery(query);
        }
        public void Close()
        {
            String query = string.Format("UPDATE nhanvien SET TrangThai = 'Absent' WHERE MaNV ='" + id + "'");
            DataProvider.Instance.ExcuteNonQuery(query);
        }

    }
}
