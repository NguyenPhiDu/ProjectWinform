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
        void Load()
        {
            FillCombobox();
            dgvVeXe.DataSource = busVe.getVe();
        }
        //clearandfocus
        public void ClearAndFocus()
        {
            txtGhe.Clear();
            txtMaSoVeXe.Clear();
            txtMaSoVeXe.Focus();
        }
        //hien thi combobox
        void FillCombobox()
        {

            cbMaSoNV.DataSource = busVe.FillComboboxNhanVien();
            cbMaSoNV.DisplayMember = "tennv";
            cbMaSoNV.ValueMember = "msnv";

            cbMaSoXe.DataSource = busVe.FillComboboxMaSoXe();
            cbMaSoXe.DisplayMember = "msx";
            cbMaSoXe.ValueMember = "msx";
        }
        /// <summary>
        /// them xoa sua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// them 
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSoVeXe.Text != "" && txtMaSoVeXe.Text != "" &&cbMaSoNV.Text!="" &&cbMaSoXe.Text!="")
            {
                ET_Ve etVe = new ET_Ve(txtMaSoVeXe.Text,int.Parse( txtGhe.Text), cbMaSoXe.SelectedValue.ToString(), cbMaSoNV.SelectedValue.ToString());
                if (busVe.InsertVe(etVe))
                {
                    MessageBox.Show("Thêm thành công");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        //sua
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSoVeXe.Text != "" && txtMaSoVeXe.Text != "" && cbMaSoNV.Text != "" && cbMaSoXe.Text != "")
            {
               
                if (busVe.DeleteVe(txtMaSoVeXe.Text))
                {
                    MessageBox.Show("Xóa thành công");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để xóa");
            }
        }

        //xoa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSoVeXe.Text != "" && txtMaSoVeXe.Text != "" && cbMaSoNV.Text != "" && cbMaSoXe.Text != "")
            {
                ET_Ve etVe = new ET_Ve(txtMaSoVeXe.Text, int.Parse(txtGhe.Text), cbMaSoXe.SelectedValue.ToString(), cbMaSoNV.SelectedValue.ToString());
                if (busVe.UpdateVe(etVe))
                {
                    MessageBox.Show("Sửa thành công");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_VeXe_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r = MessageBox.Show("Do you want to close ?", "N0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void dgvVeXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvVeXe.SelectedCells[0].OwningRow;
            string msvexe = row.Cells["msv"].Value.ToString();
            txtMaSoVeXe.Text = msvexe.Trim();
            txtGhe.Text= row.Cells["ghe"].Value.ToString();
            cbMaSoNV.Text = row.Cells["msnv"].Value.ToString();
            cbMaSoXe.Text = row.Cells["msx"].Value.ToString();
        }
    }
}
