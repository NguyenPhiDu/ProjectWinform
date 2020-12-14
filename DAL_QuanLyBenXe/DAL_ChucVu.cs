using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;
namespace DAL_QuanLyBenXe
{
    public class DAL_ChucVu
    {
        //lay danh sach chuc vu
        public DataTable getChucVu()
        {
            string query = string.Format("SP_DanhSachChucVu");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //them danh sach chuc vu
        public bool InsertChucVu(ET_ChucVu etChucVu)
        {
            string query = string.Format("SP_InsertChucVu @MSCV , @TENCV");
            object[] para = new object[]
             {
                 etChucVu.MsCV,
                 etChucVu.TenCV
             };
            if(DataProvider.Instance.ExecuteNonQuery(query, para)!=0)
            {
                return true;
            }
            return false;
        }
        //sua chuc vu
        public bool UpdateChucVu(ET_ChucVu etChucVu)
        {
            string query = string.Format("SP_UpdateChucVu @MSCV , @TENCV");
            object[] para = new object[]
             {
                 etChucVu.MsCV,
                 etChucVu.TenCV
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
        //xoa chuc vu
        public bool DeleteChucVu(string id)
        {
            string query = string.Format("SP_XoaChucVu @MSCV");
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
