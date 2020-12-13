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
    public partial class GUI_ChuXe : Form
    {
        BUS_ChuXe busChuXe = new BUS_ChuXe();
        public GUI_ChuXe()
        {
            InitializeComponent();
            Load();
        }
        

        // ClearAndFocus
        void ClearAndFocus()
        {
            txtMaSoChuXe.Clear();
            txtTenChuXe.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMaSoChuXe.Focus();
        }


        /// <summary>
        /// them xoa sua 
        /// </summary>
        /// 

        //btn them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtTenChuXe.Text != "" && txtMaSoChuXe.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
            {
                ET_ChuXe etChuXe = new ET_ChuXe(txtMaSoChuXe.Text, txtTenChuXe.Text,int.Parse( txtCMND.Text), txtDiaChi.Text,int.Parse( txtSDT.Text));
                if (busChuXe.InsertChuXe(etChuXe))
                {
                    MessageBox.Show("Them thanh cong");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        //btn sua

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenChuXe.Text != "" && txtMaSoChuXe.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
            {
                ET_ChuXe etChuXe = new ET_ChuXe(txtMaSoChuXe.Text, txtTenChuXe.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, int.Parse(txtSDT.Text));
                if (busChuXe.UpdateChuXe(etChuXe))
                {
                    MessageBox.Show("Sua thanh cong");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Sua khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }

        //btn xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenChuXe.Text != "" && txtMaSoChuXe.Text != "" && txtSDT.Text != "" && txtDiaChi.Text != "" && txtCMND.Text != "")
            {
                //ET_ChuXe etChuXe = new ET_ChuXe(txtMaSoChuXe.Text, txtTenChuXe.Text, int.Parse(txtCMND.Text), txtDiaChi.Text, int.Parse(txtSDT.Text));
                if (busChuXe.DeleteChuXe(txtMaSoChuXe.Text))
                {
                    MessageBox.Show("Xoa thanh cong");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Xoa khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }
        }
        //lay thong tin tu bang
        private void dgvThongTinChuXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvThongTinChuXe.SelectedCells[0].OwningRow;
            string mscx = row.Cells["mscx"].Value.ToString();
            txtMaSoChuXe.Text = mscx.Trim();
            txtTenChuXe.Text = row.Cells["tencx"].Value.ToString();
            txtCMND.Text = row.Cells["cmnd"].Value.ToString();
            txtDiaChi.Text= row.Cells["diachi"].Value.ToString();
            txtSDT.Text= row.Cells["soDT"].Value.ToString();
        }

        //Load table
        void Load()
        {
            dgvThongTinChuXe.DataSource = busChuXe.GetChuXE();
        }

        private void GUI_ChuXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = new DialogResult();
            MessageBox.Show("Do you to close", "No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if(r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
