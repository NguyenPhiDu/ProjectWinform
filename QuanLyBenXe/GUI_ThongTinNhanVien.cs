using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL_QuanLyBenXe;
using BUS_QuanLyBenXe;
using ET_QuanLyBenXe;
namespace QuanLyBenXe
{
    public partial class GUI_ThongTinNhanVien : Form
    {
        BUS_NhanVien nv = new BUS_NhanVien();

        public GUI_ThongTinNhanVien()
        {
            InitializeComponent();
            Load();
        }



        private void btnThem_Click(object sender, EventArgs e)
        {

            if (txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                ET_NhanVien etNV = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, int.Parse(txtSDT.Text), int.Parse(txtHeSoLuong.Text), float.Parse(txtLuongCB.Text), float.Parse(txtTienLuong.Text), cbMSCV.SelectedValue.ToString());
                if (nv.InsertNhanVien(etNV))
                {
                    MessageBox.Show("Them thanh cong");
                    Load();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    txtHeSoLuong.Clear();
                    txtLuongCB.Clear();
                    txtTienLuong.Clear();
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
        void FillCombobox()
        {
            cbMSCV.DataSource = nv.FillCombobox();
            cbMSCV.DisplayMember = "tencv";
            cbMSCV.ValueMember = "mscv";
        }
        void Load()
        {

            FillCombobox();

            dgvThongTinNhanVien.DataSource = nv.getNhanVien();
        }
        private void txtLuongCB_Validated(object sender, EventArgs e)
        {
            if (txtLuongCB.Text != "" && txtHeSoLuong.Text != "")
            {
                txtTienLuong.Text = nv.TinhLuong().ToString();
            }
        }
        private void txtHeSoLuong_Validated(object sender, EventArgs e)
        {
            if (txtLuongCB.Text != "" && txtHeSoLuong.Text != "")
            {
                txtTienLuong.Text = nv.TinhLuong().ToString();
            }
        }
        //sua nhan vien 
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                ET_NhanVien etNV = new ET_NhanVien(txtMaNV.Text, txtTenNV.Text, dtpNgaySinh.Value, txtDiaChi.Text, int.Parse(txtSDT.Text), int.Parse(txtHeSoLuong.Text), float.Parse(txtLuongCB.Text), float.Parse(txtTienLuong.Text), cbMSCV.SelectedValue.ToString());
                if (nv.UpdateNhanVien(etNV))
                {
                    MessageBox.Show("Sua  thanh cong");
                    Load();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    txtHeSoLuong.Clear();
                    txtLuongCB.Clear();
                    txtTienLuong.Clear();
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
        //ham lay thong tin tu bang
        private void dgvThongTinNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvThongTinNhanVien.SelectedCells[0].OwningRow;
            string msnv = row.Cells["msnv"].Value.ToString();
            string tennv = row.Cells["tennv"].Value.ToString();
            DateTime ngaysinh = (DateTime)row.Cells["ngaySinh"].Value;
            string diachi = row.Cells["diachi"].Value.ToString();
            int sdt = int.Parse(row.Cells["soDT"].Value.ToString());
            int hesoluong = int.Parse(row.Cells["hesoluong"].Value.ToString());
            float luongcb = float.Parse(row.Cells["luongCB"].Value.ToString());
            float tienluong = float.Parse(row.Cells["tienluong"].Value.ToString());
            string masochucvu = row.Cells["mscv"].Value.ToString();

            txtMaNV.Text = msnv.Trim();
            txtTenNV.Text = tennv.Trim();
            dtpNgaySinh.Text = ngaysinh.ToString();
            txtDiaChi.Text = diachi.Trim();
            txtSDT.Text = sdt.ToString();
            txtHeSoLuong.Text = hesoluong.ToString();
            txtLuongCB.Text = luongcb.ToString();
            txtTienLuong.Text = tienluong.ToString();
            cbMSCV.Text = masochucvu.Trim();
                

        }

        //xoa nhan vien 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtTenNV.Text != "")
            {
                ET_NhanVien etNV = new ET_NhanVien();
                string msnv = txtMaNV.Text;
               
                if (nv.DeleteNhanVien(msnv))
                {
                    MessageBox.Show("Xoa  thanh cong");
                    Load();
                    txtMaNV.Clear();
                    txtTenNV.Clear();
                    txtDiaChi.Clear();
                    txtSDT.Clear();
                    txtHeSoLuong.Clear();
                    txtLuongCB.Clear();
                    txtTienLuong.Clear();
                    txtMaNV.Focus();
                }
                else
                {
                    MessageBox.Show("xoa khong thanh cong");
                }
            }
            else
            {
                MessageBox.Show("Vui long chon nhan vien de xoa");
            }
        }
    }
}
