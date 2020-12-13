using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using ET_QuanLyBenXe;
namespace DAL_QuanLyBenXe
{
    public class DAL_Tuyen
    {
        //lay danh sach tuyen
        public DataTable GetTuyen()
        {
            string query = string.Format("SP_DanhSachTuyen");
            return DataProvider.Instance.ExecuteQuery(query);
        }
        /// <summary>
        /// Them Xoa sua
        /// </summary>
        /// <param name="etTuyen"></param>
        /// <returns></returns>
        //them danh sach tuyen
        public bool InsertTuyen(ET_Tuyen etTuyen)
        {
            string query = string.Format("SP_ThemTuyen @mst , @tuyen , @benDi , @doDaiTuyen");
            object[] para = new object[]
             {
                 etTuyen.Mst,etTuyen.Tuyen,etTuyen.BenDi,etTuyen.DoDaiTuyen
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
        //sua tuyen
        public bool UpdateTuyen(ET_Tuyen etTuyen)
        {
            string query = string.Format("SP_UpDateTuyen @mst , @tuyen , @benDi , @doDaiTuyen");
            object[] para = new object[]
             {
                 etTuyen.Mst,etTuyen.Tuyen,etTuyen.BenDi,etTuyen.DoDaiTuyen
             };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) != 0)
            {
                return true;
            }
            return false;
        }
        //xoa Tuyen
        public bool DeleteTuyen(string id)
        {
            string query = string.Format("SP_XoaTuyen @mst");
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
