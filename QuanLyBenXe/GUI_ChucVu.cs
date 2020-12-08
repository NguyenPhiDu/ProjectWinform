using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace QuanLyBenXe
{
    public partial class GUI_ChucVu : Form
    {
        BUS_ChucVu buscv = new BUS_ChucVu();
        public GUI_ChucVu()
        {
            InitializeComponent();
            Load();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenCV.Text != "" && txtMaSoCV.Text != "")
            {
                ET_ChucVu etCV = new ET_ChucVu(txtMaSoCV.Text, txtTenCV.Text);
                buscv.insertChucVu(etCV);
                Load();
                txtMaSoCV.Clear();
                txtTenCV.Clear();
                txtMaSoCV.Focus();
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
          
        }
        void Load()
        {
          
            dgvChucVu.DataSource = buscv.getChucVu();
        }

        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvChucVu.SelectedCells[0].OwningRow;
            txtMaSoCV.Text = row.Cells["mscv"].Value.ToString();
            txtTenCV.Text = row.Cells["tencv"].Value.ToString();
        }

       
    }
}
