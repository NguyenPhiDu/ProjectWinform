using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace BUS_QuanLyBenXe
{
    public class BUS_Tuyen
    {
        DAL_Tuyen dalTuyen = new DAL_Tuyen();
        //lay danh sach tuyen
        public DataTable GetTuyen()
        {
            return dalTuyen.GetTuyen();
        }
        /// <summary>
        /// Them Xoa sua
        /// </summary>
        /// <param name="etTuyen"></param>
        /// <returns></returns>
        //them danh sach tuyen
        public bool InsertTuyen(ET_Tuyen etTuyen)
        {
            return dalTuyen.InsertTuyen(etTuyen);
        }
        //sua tuyen
        public bool UpdateTuyen(ET_Tuyen etTuyen)
        {
            return dalTuyen.UpdateTuyen(etTuyen);
        }
        //xoa Tuyen
        public bool DeleteTuyen(string id)
        {
            return dalTuyen.DeleteTuyen(id);
        }
    }
}
