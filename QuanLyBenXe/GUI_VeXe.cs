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
    public partial class GUI_VeXe : Form
    {
        BUS_Ve busVe = new BUS_Ve();
        public GUI_VeXe()
        {
            InitializeComponent();
            Load();
        }

        //load
        void  Load()
        {

            dgvVeXe.DataSource= busVe.getVe();
        }
        //hien thi combobox
        void FillCombobox()
        {

            cbMaSoNV.DataSource = busVe.FillComboboxNhanVien();
            cbMaSoNV.DisplayMember = "tencv";
            cbMaSoNV.ValueMember = "mscv";

            cbMaSoXe.DataSource = busVe.FillComboboxMaSoXe();
            cbMaSoNV.DisplayMember = "msx";
            cbMaSoNV.ValueMember = "msx";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSoVeXe.Text != "" && txtMaSoVeXe.Text != "" &&cbMaSoNV.Text!="" &&cbMaSoXe.Text!="")
            {
                //ET_Ve etVe = new ET_Ve(tx);
                //if(busVe.InsertVe())
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
    }
}
