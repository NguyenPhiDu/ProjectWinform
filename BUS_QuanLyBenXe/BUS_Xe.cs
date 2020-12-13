using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace BUS_QuanLyBenXe
{
    public class BUS_Xe
    {
        DAL_Xe dalXe = new DAL_Xe();
        //lay danh sach xe
        public DataTable getXe()
        {
            return dalXe.getXe();
        }

        //fill combobox ma so chu xe
        public object FillComboboxMaSoCX()
        {
            return dalXe.FillComboboxMaSoCX();
        }

        //fill combobox ma so ma tuyen
        public object FillComboboxMaSoTuyen()
        {
            return dalXe.FillComboboxMaSoTuyen();
        }



        /// <summary>
        /// them xoa sua
        /// </summary>
        /// <returns></returns>
        public bool InsertXe(ET_Xe etXe)
        {
            return dalXe.InsertXe(etXe);
        }
        //update
        public bool UpdateXe(ET_Xe etXe)
        {
            return dalXe.UpdateXe(etXe);
        }
        //Delete
        public bool DeleteXe(string id)
        {
            return dalXe.DeleteXe(id);
        }
    }
}
