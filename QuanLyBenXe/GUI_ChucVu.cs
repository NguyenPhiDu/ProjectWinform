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
                MessageBox.Show("Them thanh cong");
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

        //row  check
        DataGridViewRow row ;
        private void dgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvChucVu.SelectedCells[0].OwningRow;
            string macv = row.Cells["mscv"].Value.ToString();
            string tencv = row.Cells["tencv"].Value.ToString();
            txtMaSoCV.Text = macv.Trim();
            txtMaSoCV.Enabled = false;
            txtTenCV.Text = tencv.Trim();
        }
        ErrorProvider err = new ErrorProvider();
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTenCV.Text != "" && txtMaSoCV.Text != "")
            {
               
                ET_ChucVu etCV = new ET_ChucVu(txtMaSoCV.Text, txtTenCV.Text);
                if (buscv.updateChucVu(etCV))
                {
                    txtMaSoCV.Enabled = true;
                    MessageBox.Show("Sua thanh cong");
                    Load();
                    txtMaSoCV.Clear();
                    txtTenCV.Clear();
                    txtMaSoCV.Focus();
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
           string id= txtMaSoCV.Text;
            if (txtMaSoCV.Text != "")
            {
                if (buscv.deleteChucVu(id))
                {
                    txtMaSoCV.Enabled = true;
                    MessageBox.Show("Xoa thanh cong");
                    Load();
                    txtMaSoCV.Clear();
                    txtTenCV.Clear();
                    txtMaSoCV.Focus();
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

        private void GUI_ChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r= new DialogResult();
            MessageBox.Show("DO you want to close? ", "No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if(r == DialogResult.Yes)
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
