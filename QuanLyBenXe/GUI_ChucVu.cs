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
            

            if (txtTenCV.Text != "" && txtMaSoCV.Text != "")
            {
                ET_ChucVu etCV = new ET_ChucVu(txtMaSoCV.Text, txtTenCV.Text);
                try
                {
                    if (buscv.InsertChucVu(etCV))
                    {
                        MessageBox.Show("Thêm thành công");
                        Load();
                        txtMaSoCV.Clear();
                        txtTenCV.Clear();
                        txtMaSoCV.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Thêm  thất bại");
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Mã chức vụ bị trùng");
                }

            }

            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            }

        }
        void Load()
        {

            dgvChucVu.DataSource = buscv.getChucVu();
        }

        //row  check
        DataGridViewRow row;
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
                if (buscv.UpdateChucVu(etCV))
                {

                    MessageBox.Show("Sửa thành công");
                    Load();
                    txtMaSoCV.Clear();
                    txtTenCV.Clear();
                    txtMaSoCV.Focus();

                }
                else
                {
                    MessageBox.Show("Sửa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin để sửa");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaSoCV.Text != "")
            {
                if (buscv.DeleteChucVu(txtMaSoCV.Text))
                {
                    txtMaSoCV.Enabled = true;
                    MessageBox.Show("Xóa thành công");
                    Load();
                    txtMaSoCV.Clear();
                    txtTenCV.Clear();
                    txtMaSoCV.Focus();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đối tượng để xóa");
            }

        }

        private void GUI_ChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r = MessageBox.Show("Do you want to close ?", "N0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //ErrorProvider err ;
        private void txtMaSoCV_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (((e.KeyChar > (char)47) && (e.KeyChar < (char)58) || (e.KeyChar == (char)46)) || (e.KeyChar < (char)32) || (e.KeyChar == 43))
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    MessageBox.Show("Không được nhập ký tự này!");
            //    e.Handled = true;
            //}
        }

        private void txtMaSoCV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
