using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace BUS_QuanLyBenXe
{
    public class BUS_ChucVu
    {
        DAL_ChucVu dalCV = new DAL_ChucVu();
        //method get chuc vu
        public DataTable getChucVu()
        {
            return dalCV.getChucVu();
        }
        //method insert chuc vu
        public bool InsertChucVu(ET_ChucVu etCV)
        {
            return dalCV.InsertChucVu(etCV);
        }
        //method update chuc vu
        public bool UpdateChucVu(ET_ChucVu etCV)
        {
            return dalCV.UpdateChucVu(etCV);
        }
        //method delete chuc vu
        public bool DeleteChucVu(string id)
        {
            return dalCV.DeleteChucVu(id);
        }
    }
}
