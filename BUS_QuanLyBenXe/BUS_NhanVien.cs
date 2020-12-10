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
        DAL_NhanVien dalNV = new DAL_NhanVien();
        ET_NhanVien etNV = new ET_NhanVien();
        //lay danh sach nhan vien
        public DataTable getNhanVien()
        {
            return dalNV.getNhanVien();
        }
        //them nhan vien 
        public bool InsertNhanVien(ET_NhanVien etNV)
        {
            return dalNV.insertNhanVien(etNV);
        }
    }
}
