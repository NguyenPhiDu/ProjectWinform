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
    public partial class GUI_Xe : Form
    {
        BUS_Xe busXe = new BUS_Xe();
        public GUI_Xe()
        {
            InitializeComponent();
            Load();
        }

        //load table
        void Load()
        {
            FillComBobox();
            dgvThongTinXe.DataSource = busXe.getXe();
        }
        //clear and focus
        public void ClearAndFocus()
        {
            txtBienSoXe.Clear();
            txtMaSoXe.Clear();
            txtSoGhe.Clear();
            txtBienSoXe.Focus();
        }

        //fill combox 
        public void FillComBobox()
        {
            cbMaSoChuXe.DataSource = busXe.FillComboboxMaSoCX();
            cbMaSoChuXe.DisplayMember = "tencx";
            cbMaSoChuXe.ValueMember = "mscx";

            cbMaSoTuyen.DataSource = busXe.FillComboboxMaSoTuyen();
            cbMaSoTuyen.DisplayMember = "tuyen";
            cbMaSoTuyen.ValueMember = "mst";
        }
        /// <summary>
        /// them xoa sua
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        //btn them
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtBienSoXe.Text != "" && txtMaSoXe.Text != "" &&txtSoGhe.Text!= "" && cbMaSoTuyen.Text != "" && cbMaSoChuXe.Text !="")
            {
                ET_Xe etXe = new ET_Xe( txtMaSoXe.Text , txtBienSoXe.Text, int.Parse( txtSoGhe.Text) , cbMaSoTuyen.SelectedValue.ToString(), cbMaSoChuXe.SelectedValue.ToString());
                if(busXe.InsertXe(etXe))
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
                MessageBox.Show("Vui long dien day du thong tin");
            }
        }
        //btn sua
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtBienSoXe.Text != "" && txtMaSoXe.Text != "" && txtSoGhe.Text != "" && cbMaSoTuyen.Text != "" && cbMaSoChuXe.Text != "")
            {
                ET_Xe etXe = new ET_Xe(txtMaSoXe.Text, txtBienSoXe.Text, int.Parse(txtSoGhe.Text), cbMaSoTuyen.SelectedValue.ToString(), cbMaSoChuXe.SelectedValue.ToString());
                if (busXe.UpdateXe(etXe))
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
                MessageBox.Show("Vui long chon thong tin de sua");
            }
        }
        //btn xoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtBienSoXe.Text != "" && txtMaSoXe.Text != "" && txtSoGhe.Text != "" && cbMaSoTuyen.Text != "" && cbMaSoChuXe.Text != "")
            {
               
                if (busXe.DeleteXe(txtMaSoXe.Text))
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
                MessageBox.Show("Vui long chon thong tin de xoa");
            }
        }

        private void dgvThongTinXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
