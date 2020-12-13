using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace BUS_QuanLyBenXe
{
  
    public class BUS_Ve
    {
        DAL_Ve dalVe = new DAL_Ve();
        //lay danh sach ve
        public DataTable getVe()
        {
            return dalVe.getVe();
        }
        //ham hien thi ma so nhan vien
        public object FillComboboxNhanVien()
        {

            return dalVe.FillComboboxNhanVien();
        }

        //ham hien thi ma so xe
        public object FillComboboxMaSoXe()
        {
            return dalVe.FillComboboxMaSoXe();
        }

        /// <summary>
        /// them xoa sua
        /// </summary>

        //them ve
        public bool InsertVe(ET_Ve etVe)
        {
            return dalVe.InsertVe(etVe);
        }

        //update ve
        public bool UpdateVe(ET_Ve etVe)
        {
           return dalVe.UpdateVe(etVe);
        }

        //delete ve
        public bool DeleteVe(string id)
        {
            return dalVe.DeleteVe(id);
        }
    }
}
