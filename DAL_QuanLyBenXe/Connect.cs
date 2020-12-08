using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DAL_QuanLyBenXe
{
    public class Connect
    {
        protected SqlConnection connectionString = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLBenXe;Integrated Security=True"); 
    }
}
