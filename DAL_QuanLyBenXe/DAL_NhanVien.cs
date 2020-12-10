using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;
namespace DAL_QuanLyBenXe
{
    public class DAL_NhanVien 
    {
        ET_NhanVien etNV = new ET_NhanVien();
        /// <summary>
        /// Hien thi danh sach nhan vien 
        /// </summary>
        /// <returns></returns>
        public DataTable getNhanVien()
        {
            string query = string.Format("SP_DanhSachNhanVien");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        /// <summary>
        /// Them xoa sua nhan vien 
        /// </summary>
        /// <returns></returns>

        public bool insertNhanVien(ET_NhanVien etNV)
        {
            string query = string.Format("SP_ThemNhanVien @msnv , @tennv , @ngaySinh , @diachi , @soDT , @hesoluong , @luongCB , @tienluong , @mscv");
            object[] para = new object[]
            {
                etNV.MaSoNV,etNV.TenNV,etNV.NgaySinh,etNV.DiaChi,etNV.SDT,etNV.HeSoLuong,etNV.LuongCB,etNV.TienLuong,etNV.MaSoChucVu
            };
            if(DataProvider.Instance.ExecuteNonQuery(query,para)!= 0)
            {
                return true;
            }
            return false;
        }

    }
}
