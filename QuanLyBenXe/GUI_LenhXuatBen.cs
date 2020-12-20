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
    public partial class GUI_LenhXuatBen : Form
    {
        BUS_LenhXuatBen buslxb = new BUS_LenhXuatBen();
        public GUI_LenhXuatBen()
        {
            InitializeComponent();
            Load();
        }
        //fill combox 
        public void FillComBobox()
        {
            cboMaSoXe.DataSource = buslxb.FillComboboxMaSoXe();
            cboMaSoXe.DisplayMember = "msx";
            cboMaSoXe.ValueMember = "msx";

            cboMasoHD.DataSource = buslxb.FillComboboxMaSoHoaDon();
            cboMasoHD.DisplayMember = "mshd";
            cboMasoHD.ValueMember = "mshd";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSoLenhXB.Text != "" && cboMaSoXe.Text != "" && cboMasoHD.Text != "")
            {
                ET_LenhXuatBen etLenhXuatBen = new ET_LenhXuatBen(txtMaSoLenhXB.Text, cboMaSoXe.SelectedValue.ToString(), cboMasoHD.SelectedValue.ToString());
                buslxb.insertLenhXuatBen(etLenhXuatBen);
                MessageBox.Show("Them thanh cong");
                Load();
                txtMaSoLenhXB.Clear();
                cboMaSoXe.ResetText();
                cboMasoHD.ResetText();
                txtMaSoLenhXB.Focus();
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
        void Load()
        {
            FillComBobox();
            dgvLenhXuatBen.DataSource = buslxb.getLenhXuatBen();
        }
        //row  check
        DataGridViewRow row;

        private void dgvLenhXuatBen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvLenhXuatBen.SelectedCells[0].OwningRow;
            string mslxb = row.Cells["mslxb"].Value.ToString();
            txtMaSoLenhXB.Text = mslxb.Trim();
            string msx = row.Cells["msx"].Value.ToString();
            string mhd = row.Cells["mshd"].Value.ToString();
            cboMaSoXe.Text = msx.Trim();
            cboMaSoXe.Enabled = true;
            cboMasoHD.Text = mhd.Trim();
            cboMasoHD.Enabled = true;
        }
        ErrorProvider err = new ErrorProvider();

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSoLenhXB.Text != "" && cboMaSoXe.Text != "" && cboMasoHD.Text != "")
            {

                ET_LenhXuatBen etLenhXuatBen = new ET_LenhXuatBen(txtMaSoLenhXB.Text, cboMaSoXe.SelectedValue.ToString(), cboMasoHD.SelectedValue.ToString());
                if (buslxb.updateLenhXuatBen(etLenhXuatBen))
                {
                    //cboMaSoXe.Enabled = false;
                    //cboMasoHD.Enabled = false;
                    MessageBox.Show("Sua thanh cong");
                    Load();
                    txtMaSoLenhXB.Clear();
                    cboMaSoXe.ResetText();
                    cboMasoHD.ResetText();
                    txtMaSoLenhXB.Focus();
                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaSoLenhXB.Text;
            if (txtMaSoLenhXB.Text != "")
            {
                if (buslxb.deleteLenhXuatBen(id))
                {
                    //cboMaSoXe.Enabled = true;
                    //cboMasoHD.Enabled = true;
                    MessageBox.Show("Xoa thanh cong");
                    Load();
                    txtMaSoLenhXB.Clear();
                    cboMaSoXe.ResetText();
                    cboMasoHD.ResetText();
                    txtMaSoLenhXB.Focus();
                }
                else
                {
                    MessageBox.Show("Xoa khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long chon dong de xoa");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_LenhXuatBen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to close ?", "N0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvLenhXuatBen_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvLenhXuatBen.SelectedCells[0].OwningRow;
            string mslxb = row.Cells["mslxb"].Value.ToString();
            txtMaSoLenhXB.Text = mslxb.Trim();
            string msx = row.Cells["msx"].Value.ToString();
            string mhd = row.Cells["mshd"].Value.ToString();
            cboMaSoXe.Text = msx.Trim();
            cboMaSoXe.Enabled = true;
            cboMasoHD.Text = mhd.Trim();
            cboMasoHD.Enabled = true;
        }
    }
}
