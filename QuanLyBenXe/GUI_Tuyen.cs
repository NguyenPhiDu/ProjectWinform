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
    public partial class GUI_Tuyen : Form
    {
        public GUI_Tuyen()
        {
            InitializeComponent();
        }
        BUS_Tuyen busTuyen = new BUS_Tuyen();
       
        //Load table
        void Load()
        {
            dgvTuyen.DataSource = busTuyen.GetTuyen();
        }
        //clear and focus
        public void ClearAndFocus()
        {
            txtBenDi.Clear();
            txtDoDaiTuyen.Clear();
            txtMaSoTuyen.Clear();
            txtTuyen.Clear();
            txtMaSoTuyen.Focus();
        }

        /// <summary>
        /// Them Xoa sua
        /// </summary>
        /// <param name="etTuyen"></param>
        /// <returns></returns>
        //them danh sach tuyen
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtBenDi.Text != "" && txtDoDaiTuyen.Text  != "" && txtMaSoTuyen.Text != "" && txtTuyen.Text != "")
            {
                ET_Tuyen etTuyen = new ET_Tuyen(txtMaSoTuyen.Text,txtTuyen.Text ,txtBenDi.Text,int.Parse(txtDoDaiTuyen.Text));
                if (busTuyen.InsertTuyen(etTuyen))
                {
                    MessageBox.Show("Them thanh cong");
                    Load();
                    ClearAndFocus();
                }
                else
                {
                    MessageBox.Show("Them khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap day du thong tin");
            }
        }
        //sua tuyen
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtBenDi.Text != "" && txtDoDaiTuyen.Text != "" && txtMaSoTuyen.Text != "" && txtTuyen.Text != "")
            {
                ET_Tuyen etTuyen = new ET_Tuyen(txtMaSoTuyen.Text, txtTuyen.Text, txtBenDi.Text, int.Parse(txtDoDaiTuyen.Text));
                if (busTuyen.UpdateTuyen(etTuyen))
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
                MessageBox.Show("Vui long nhap day du thong tin");
            }
        }

        //xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtBenDi.Text != "" && txtDoDaiTuyen.Text != "" && txtMaSoTuyen.Text != "" && txtTuyen.Text != "")
            {
                //ET_Tuyen etTuyen = new ET_Tuyen(txtMaSoTuyen.Text, txtTuyen.Text, txtBenDi.Text, int.Parse(txtDoDaiTuyen.Text));
                if (busTuyen.DeleteTuyen(txtMaSoTuyen.Text))
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
                MessageBox.Show("Vui long nhap day du thong tin");
            }
        }


        //do dai tuyen
        private void dgvTuyen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTuyen.SelectedCells[0].OwningRow;
            string mst = row.Cells["mst"].Value.ToString();
            txtMaSoTuyen.Text =mst.Trim();
            txtDoDaiTuyen.Text = row.Cells["doDaiTuyen"].Value.ToString(); 
            txtBenDi.Text = row.Cells["benDi"].Value.ToString(); 
            txtTuyen.Text = row.Cells["tuyen"].Value.ToString(); 

        }

        private void GUI_Tuyen_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Do you want to close ?", "N0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;
            
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
