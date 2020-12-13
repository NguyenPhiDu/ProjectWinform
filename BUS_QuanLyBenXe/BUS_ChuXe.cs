using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;

namespace BUS_QuanLyBenXe
{
    public class BUS_ChuXe
    {
      
        DAL_ChuXe dalChuXE = new DAL_ChuXe();
        //lay danh sach chu xe
        public DataTable GetChuXE()
        {
            return dalChuXE.GetChuXe();
        }

        /// <summary>
        /// Them Xoa sua
        /// </summary>

        //insert chu xe 
        public bool InsertChuXe(ET_ChuXe etChuXe) {
            return dalChuXE.InsertChuXE(etChuXe);
        }

        //update chu xe 
        public bool UpdateChuXe(ET_ChuXe etChuXe)
        {
            return dalChuXE.UpdateChuXe(etChuXe);
        }

        //delete chu xe
        public bool DeleteChuXe(string id)
        {
            return dalChuXE.DeleteChuXe(id);
        }
    }
}
