namespace QuanLyBenXe
{
    partial class GUI_LenhXuatBen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboMasoHD = new System.Windows.Forms.ComboBox();
            this.cboMaSoXe = new System.Windows.Forms.ComboBox();
            this.lblMsHD = new System.Windows.Forms.Label();
            this.dgvLenhXuatBen = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMsXe = new System.Windows.Forms.Label();
            this.txtMaSoLenhXB = new System.Windows.Forms.TextBox();
            this.lblLenhXB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLenhXuatBen)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMasoHD
            // 
            this.cboMasoHD.FormattingEnabled = true;
            this.cboMasoHD.Location = new System.Drawing.Point(267, 96);
            this.cboMasoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMasoHD.Name = "cboMasoHD";
            this.cboMasoHD.Size = new System.Drawing.Size(225, 24);
            this.cboMasoHD.TabIndex = 23;
            // 
            // cboMaSoXe
            // 
            this.cboMaSoXe.FormattingEnabled = true;
            this.cboMaSoXe.Location = new System.Drawing.Point(267, 46);
            this.cboMaSoXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMaSoXe.Name = "cboMaSoXe";
            this.cboMaSoXe.Size = new System.Drawing.Size(225, 24);
            this.cboMaSoXe.TabIndex = 22;
            // 
            // lblMsHD
            // 
            this.lblMsHD.AutoSize = true;
            this.lblMsHD.Location = new System.Drawing.Point(84, 96);
            this.lblMsHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsHD.Name = "lblMsHD";
            this.lblMsHD.Size = new System.Drawing.Size(110, 17);
            this.lblMsHD.TabIndex = 21;
            this.lblMsHD.Text = "Mã số hóa đơn :";
            // 
            // dgvLenhXuatBen
            // 
            this.dgvLenhXuatBen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLenhXuatBen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLenhXuatBen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLenhXuatBen.Location = new System.Drawing.Point(0, 256);
            this.dgvLenhXuatBen.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLenhXuatBen.Name = "dgvLenhXuatBen";
            this.dgvLenhXuatBen.Size = new System.Drawing.Size(676, 133);
            this.dgvLenhXuatBen.TabIndex = 13;
            this.dgvLenhXuatBen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLenhXuatBen_CellContentClick_1);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(521, 155);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 19;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(354, 155);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(180, 155);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 155);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMsXe
            // 
            this.lblMsXe.AutoSize = true;
            this.lblMsXe.Location = new System.Drawing.Point(84, 52);
            this.lblMsXe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMsXe.Name = "lblMsXe";
            this.lblMsXe.Size = new System.Drawing.Size(72, 17);
            this.lblMsXe.TabIndex = 20;
            this.lblMsXe.Text = "Mã số xe :";
            // 
            // txtMaSoLenhXB
            // 
            this.txtMaSoLenhXB.Location = new System.Drawing.Point(267, 7);
            this.txtMaSoLenhXB.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoLenhXB.Name = "txtMaSoLenhXB";
            this.txtMaSoLenhXB.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoLenhXB.TabIndex = 15;
            // 
            // lblLenhXB
            // 
            this.lblLenhXB.AutoSize = true;
            this.lblLenhXB.Location = new System.Drawing.Point(68, 11);
            this.lblLenhXB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLenhXB.Name = "lblLenhXB";
            this.lblLenhXB.Size = new System.Drawing.Size(143, 17);
            this.lblLenhXB.TabIndex = 14;
            this.lblLenhXB.Text = "Mã số lệnh xuất bến :";
            // 
            // GUI_LenhXuatBen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 389);
            this.Controls.Add(this.cboMasoHD);
            this.Controls.Add(this.cboMaSoXe);
            this.Controls.Add(this.lblMsHD);
            this.Controls.Add(this.dgvLenhXuatBen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblMsXe);
            this.Controls.Add(this.txtMaSoLenhXB);
            this.Controls.Add(this.lblLenhXB);
            this.Name = "GUI_LenhXuatBen";
            this.Text = "GUI_LenhXuatBen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLenhXuatBen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMasoHD;
        private System.Windows.Forms.ComboBox cboMaSoXe;
        private System.Windows.Forms.Label lblMsHD;
        private System.Windows.Forms.DataGridView dgvLenhXuatBen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label lblMsXe;
        private System.Windows.Forms.TextBox txtMaSoLenhXB;
        private System.Windows.Forms.Label lblLenhXB;
    }
}