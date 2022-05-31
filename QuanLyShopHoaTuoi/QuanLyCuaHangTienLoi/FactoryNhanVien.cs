using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangTienLoi
{
    class FactoryNhanVien
    {
        public INhanVien ChonLoaiNhanVien(int loaiNV)
        {
            INhanVien value = null;
            if (loaiNV == 0)
            {
                value = new NhanVienChinhThuc();
            }else if (loaiNV == 1)
            {
                value = new NhanVienThoiVu();
            }else if (loaiNV == 2)
            {
                value = new NhanVienPhaiCu();
            }
            return value;
        }
    }
}
