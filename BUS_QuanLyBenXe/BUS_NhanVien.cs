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

        /// <summary>
        /// thêm xóa sửa ở lớp bus
        /// </summary>
        /// <param name="etNV"></param>
        /// <returns></returns>
        //them nhan vien 
        public bool InsertNhanVien(ET_NhanVien etNV)
        {
            return dalNV.InsertNhanVien(etNV);
        }
        //fill combobox
        public DataTable FillCombobox()
        {
            return dalNV.FillCombobox();
        }
        //ham tinh luong tu dong
        public object TinhLuong()
        {
            return dalNV.TinhLuong();
        }

        //sua nhan vien
        public bool UpdateNhanVien(ET_NhanVien etNV)
        {
            return dalNV.UpdateNhanVien(etNV);
        }

        //xoa nhan vien
        public bool DeleteNhanVien(string msnv)
        {
            return dalNV.DeleteNhanVien(msnv);
        }
    }
}
