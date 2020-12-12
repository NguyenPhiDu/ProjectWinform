namespace QuanLyBenXe
{
    partial class GUI_VeXe
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaSoVeXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSoXe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSoNhanVien = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvVeXe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Số Vé Xe: ";
            // 
            // txtMaSoVeXe
            // 
            this.txtMaSoVeXe.Location = new System.Drawing.Point(124, 15);
            this.txtMaSoVeXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoVeXe.Name = "txtMaSoVeXe";
            this.txtMaSoVeXe.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoVeXe.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ghế:";
            // 
            // txtGhe
            // 
            this.txtGhe.Location = new System.Drawing.Point(124, 60);
            this.txtGhe.Margin = new System.Windows.Forms.Padding(4);
            this.txtGhe.Name = "txtGhe";
            this.txtGhe.Size = new System.Drawing.Size(225, 22);
            this.txtGhe.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Số Xe: ";
            // 
            // txtMaSoXe
            // 
            this.txtMaSoXe.Location = new System.Drawing.Point(541, 15);
            this.txtMaSoXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoXe.Name = "txtMaSoXe";
            this.txtMaSoXe.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoXe.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã Số Nhân Viên: ";
            // 
            // txtMaSoNhanVien
            // 
            this.txtMaSoNhanVien.Location = new System.Drawing.Point(541, 63);
            this.txtMaSoNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaSoNhanVien.Name = "txtMaSoNhanVien";
            this.txtMaSoNhanVien.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoNhanVien.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(117, 132);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(265, 132);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(412, 132);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(568, 132);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // dgvVeXe
            // 
            this.dgvVeXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVeXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvVeXe.Location = new System.Drawing.Point(0, 181);
            this.dgvVeXe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVeXe.Name = "dgvVeXe";
            this.dgvVeXe.Size = new System.Drawing.Size(801, 185);
            this.dgvVeXe.TabIndex = 3;
            // 
            // GUI_VeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 366);
            this.Controls.Add(this.dgvVeXe);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaSoNhanVien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaSoXe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGhe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSoVeXe);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GUI_VeXe";
            this.Text = "GUI_VeXe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaSoVeXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSoXe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSoNhanVien;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvVeXe;
    }
}