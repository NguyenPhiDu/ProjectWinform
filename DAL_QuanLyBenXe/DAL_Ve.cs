using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;

namespace DAL_QuanLyBenXe
{
    public class DAL_Ve
    {
        ET_Ve etVe = new ET_Ve();

        //get danh sach ve
        public DataTable getVe()
        {
            string query = string.Format("SP_DanhSachVe");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        //ham hien thi ma so nhan vien
        public DataTable FillComboboxNhanVien()
        {
            string query = string.Format("SP_DanhSachMaSoNhanVien");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        //ham hien thi ma so xe
        public DataTable FillComboboxMaSoXe()
        {
            string query = string.Format("SP_DanhSachMaSoXe");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        /// <summary>
        /// them xoa sua 
        /// </summary>
        /// <param name="etVe"></param>
        /// <returns></returns>

        //them ve xe
        public bool InsertVe(ET_Ve etVe)
        {
            string query = string.Format("SP_ThemVe @msv , @ghe , @msx , @msnv");
            object[] para = new object[]
            {
                etVe.MsV,etVe.Ghe,etVe.MsX,etVe.MsNV
            };
            
            if (DataProvider.Instance.ExecuteNonQuery(query , para) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //update ve
        public bool UpdateVe(ET_Ve etVe)
        {
            string query = string.Format("SP_UpDateVe @msv , @ghe , @msx , @msnv");
            object[] para = new object[]
            {
                etVe.MsV,etVe.Ghe,etVe.MsX,etVe.MsNV
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

        //delete ve
        public bool DeleteVe(string id)
        {
            string query = string.Format("SP_XoaVe @msv");
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
