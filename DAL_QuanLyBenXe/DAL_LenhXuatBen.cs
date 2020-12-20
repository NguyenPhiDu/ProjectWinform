using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;

namespace DAL_QuanLyBenXe
{
    public class DAL_LenhXuatBen
    {
        //lay danh sach Lenh Xuat Ben
        public DataTable getLenhXuatBen()
        {
            string query = string.Format("SP_DanhSachLenhXuatBen");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //fill combobox ma so xe
        public DataTable FillComboboxMaSoXe()
        {
            string query = string.Format("SP_DanhSachMaSoXe");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //fill combobox ma so ma hoa don
        public DataTable FillComboboxMaSoHoaDon()
        {
            string query = string.Format("SP_DanhSachHoaDon");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //them danh sach Lenh Xuat Ben
        public bool insertLenhXuatBen(ET_LenhXuatBen etLenhXuatBen)
        {
            string query = string.Format("SP_ThemLenhXuatBen @mslxb , @msx , @mshd");
            object[] para = new object[]
             {
                 etLenhXuatBen.MsLXB, etLenhXuatBen.MsX, etLenhXuatBen.MsHD
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
        //sua Lenh Xuat Ben
        public bool updateLenhXuatBen(ET_LenhXuatBen etLenhXuatBen)
        {
            string query = string.Format("SP_UpDateLenhXuatBen @mslxb , @msx , @mshd");
            object[] para = new object[]
             {
                 etLenhXuatBen.MsLXB, etLenhXuatBen.MsX, etLenhXuatBen.MsHD
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
        //xoa Lenh Xuat Ben
        public bool deleteLenhXuatBen(string id)
        {
            string query = string.Format("SP_XoaLenhXuatBen @mslxb");
            object[] para = new object[]
             {
                 id
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
    }
}

