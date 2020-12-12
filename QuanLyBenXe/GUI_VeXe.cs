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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSoVeXe.Text != "" && txtMaSoNhanVien.Text != "")
            {
                ET_Ve etVe = new ET_Ve(txtMaSoVeXe.Text,int.Parse(txtGhe.Text),txtMaSoXe.Text,txtMaSoNhanVien.Text);
                if (busVe.InsertVe(etVe))
                {
                    MessageBox.Show("Them thanh cong");
                    Load();
                    txtMaSoVeXe.Clear();
                    txtMaSoVeXe.Focus();
                    txtMaSoNhanVien.Clear();
                    txtMaSoXe.Clear();
                    txtGhe.Clear();
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
    }
}
