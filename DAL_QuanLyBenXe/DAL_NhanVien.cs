using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAL_QuanLyBenXe
{
    public class DAL_NhanVien : Connect
    {
        
        /// <summary>
        /// Hien thi danh sach nhan vien 
        /// </summary>
        /// <returns></returns>
        public DataTable layDanhSach()
        {
            string query =string.Format("SP_DanhSachNhanVien ");
           
            return DataProvider.Instance.ExecuteQuery(query);

            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NHAN_VIEN", connectionString);
            //DataTable dsNhanVien = new DataTable();
            //da.Fill(dsNhanVien);
            //return dsNhanVien;
        }
    }
}
