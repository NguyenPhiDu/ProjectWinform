using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBenXe
{
    public partial class GUI_QuanLyHoaDon : Form
    {
        public GUI_QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GUI_QuanLyHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult r = MessageBox.Show("Do you want to close ?", "N0", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1); ;

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
