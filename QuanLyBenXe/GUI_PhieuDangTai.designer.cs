namespace QuanLyBenXe
{
    partial class GUI_PhieuDangTai
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
            this.dgvPhieuDangTai = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaSoTuyen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaSoXe = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSoPhieuDT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangTai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhieuDangTai
            // 
            this.dgvPhieuDangTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDangTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDangTai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPhieuDangTai.Location = new System.Drawing.Point(0, 201);
            this.dgvPhieuDangTai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhieuDangTai.Name = "dgvPhieuDangTai";
            this.dgvPhieuDangTai.Size = new System.Drawing.Size(800, 222);
            this.dgvPhieuDangTai.TabIndex = 20;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(588, 150);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 150);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(285, 150);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 18;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(137, 150);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // txtMaSoTuyen
            // 
            this.txtMaSoTuyen.Location = new System.Drawing.Point(517, 63);
            this.txtMaSoTuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoTuyen.Name = "txtMaSoTuyen";
            this.txtMaSoTuyen.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoTuyen.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 63);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Mã Số Tuyến:";
            // 
            // txtMaSoXe
            // 
            this.txtMaSoXe.Location = new System.Drawing.Point(517, 15);
            this.txtMaSoXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoXe.Name = "txtMaSoXe";
            this.txtMaSoXe.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoXe.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mã Số Xe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Thời Gian:";
            // 
            // txtMaSoPhieuDT
            // 
            this.txtMaSoPhieuDT.Location = new System.Drawing.Point(136, 15);
            this.txtMaSoPhieuDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoPhieuDT.Name = "txtMaSoPhieuDT";
            this.txtMaSoPhieuDT.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoPhieuDT.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Số Phiếu ĐT:";
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.Location = new System.Drawing.Point(136, 63);
            this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(225, 22);
            this.dtpThoiGian.TabIndex = 29;
            // 
            // GUI_PhieuDangTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.dtpThoiGian);
            this.Controls.Add(this.txtMaSoTuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaSoXe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSoPhieuDT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPhieuDangTai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_PhieuDangTai";
            this.Text = "GUI_PhieuDangTai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDangTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhieuDangTai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaSoTuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaSoXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSoPhieuDT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
    }
}