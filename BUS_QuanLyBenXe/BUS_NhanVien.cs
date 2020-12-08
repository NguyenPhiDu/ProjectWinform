using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace BUS_QuanLyBenXe
{
    public class BUS_NhanVien
    {
        DAL_NhanVien nv = new DAL_NhanVien();
        public DataTable DanhSachNhanVien()
        {
            return nv.layDanhSach();
        }
    }
}
