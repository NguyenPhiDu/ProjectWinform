using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using DAL_QuanLyBenXe;
using ET_QuanLyBenXe;

namespace BUS_QuanLyBenXe
{
    public class BUS_LenhXuatBen
    {
        DAL_LenhXuatBen dallxb = new DAL_LenhXuatBen();
        //method get Lenh Xuat Ben
        public DataTable getLenhXuatBen()
        {
            return dallxb.getLenhXuatBen();
        }
        //fill combobox ma so xe
        public object FillComboboxMaSoXe()
        {
            return dallxb.FillComboboxMaSoXe();
        }

        //fill combobox ma so ma tuyen
        public object FillComboboxMaSoHoaDon()
        {
            return dallxb.FillComboboxMaSoHoaDon();
        }
        //method insert Lenh Xuat Ben
        public bool insertLenhXuatBen(ET_LenhXuatBen etCV)
        {
            return dallxb.insertLenhXuatBen(etCV);
        }
        //method update Lenh Xuat Ben
        public bool updateLenhXuatBen(ET_LenhXuatBen etCV)
        {
            return dallxb.updateLenhXuatBen(etCV);
        }
        //method delete Lenh Xuat Ben
        public bool deleteLenhXuatBen(string id)
        {
            return dallxb.deleteLenhXuatBen(id);
        }
    }
}
