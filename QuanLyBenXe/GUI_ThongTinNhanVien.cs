using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL_QuanLyBenXe;
using BUS_QuanLyBenXe;

namespace QuanLyBenXe
{
    public partial class GUI_ThongTinNhanVien : Form
    {
        BUS_NhanVien nv = new BUS_NhanVien();
      
        public GUI_ThongTinNhanVien()
        {
            InitializeComponent();
            Load();
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {

            
        }
        void Load()
        {
            dgvThongTinNhanVien.DataSource = nv.getNhanVien();
        }
    }
}
