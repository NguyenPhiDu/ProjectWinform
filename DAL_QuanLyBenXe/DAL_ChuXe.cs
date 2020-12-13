using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;
namespace DAL_QuanLyBenXe
{
    public class DAL_ChuXe
    {
        //lay danh sach chu xe 
        public DataTable GetChuXe()
        {
            string query = string.Format("SP_DanhSachChuXe");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        /// <summary>
        /// Them xoa sua chu xe
        /// </summary>
        /// <param name="etChuXe"></param>
        /// <returns></returns>
        //insert chu xe
        public bool InsertChuXE(ET_ChuXe etChuXe)
        {
            string query = string.Format("SP_ThemChuXe @mscx , @tencx , @cmnd , @diachi , @soDT");
            object[] para = new object[]
            {
                etChuXe.MsCX,etChuXe.TenCX,etChuXe.CMND,etChuXe.DiaChi,etChuXe.SoDT
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Update chu xe
        public bool UpdateChuXe(ET_ChuXe etChuXe)
        {
            string query = string.Format("SP_UpDateChuXe @mscx , @tencx , @cmnd , @diachi , @soDT");
            object[] para = new object[]
            {
                etChuXe.MsCX,etChuXe.TenCX,etChuXe.CMND,etChuXe.DiaChi,etChuXe.SoDT
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //delete chu xe
        public bool DeleteChuXe(string id)
        {
            string query = string.Format("SP_XoaChuXe @mscx");
            object[] para = new object[]
            {
                id
            };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
