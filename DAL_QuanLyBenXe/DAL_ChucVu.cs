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
        /// <summary>
        /// them xoa sua
        /// </summary>
        /// <param name="etChucVu"></param>
        /// <returns></returns>
        //them danh sach chuc vu
        public bool InsertChucVu(ET_ChucVu etChucVu)
        {
            string query = string.Format("SP_ThemChucVu @mscv , @tencv");
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
            string query = string.Format("SP_UpDateChucVu @mscv , @tencv");
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
            string query = string.Format("SP_XoaChucVu @mscv");
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
