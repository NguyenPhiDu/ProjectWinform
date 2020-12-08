namespace QuanLyBenXe
{
    partial class GUI_Tuyen
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
            this.txtDoDaiTuyen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBenDi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSoTuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTuyen = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDoDaiTuyen
            // 
            this.txtDoDaiTuyen.Location = new System.Drawing.Point(366, 51);
            this.txtDoDaiTuyen.Name = "txtDoDaiTuyen";
            this.txtDoDaiTuyen.Size = new System.Drawing.Size(170, 20);
            this.txtDoDaiTuyen.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Độ Dài Tuyến:";
            // 
            // txtTuyen
            // 
            this.txtTuyen.Location = new System.Drawing.Point(366, 12);
            this.txtTuyen.Name = "txtTuyen";
            this.txtTuyen.Size = new System.Drawing.Size(170, 20);
            this.txtTuyen.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tuyến:";
            // 
            // txtBenDi
            // 
            this.txtBenDi.Location = new System.Drawing.Point(75, 49);
            this.txtBenDi.Name = "txtBenDi";
            this.txtBenDi.Size = new System.Drawing.Size(170, 20);
            this.txtBenDi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bến Đi:";
            // 
            // txtMaSoTuyen
            // 
            this.txtMaSoTuyen.Location = new System.Drawing.Point(75, 12);
            this.txtMaSoTuyen.Name = "txtMaSoTuyen";
            this.txtMaSoTuyen.Size = new System.Drawing.Size(170, 20);
            this.txtMaSoTuyen.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Số Tuyến:";
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTuyen.Location = new System.Drawing.Point(0, 170);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.Size = new System.Drawing.Size(555, 180);
            this.dgvTuyen.TabIndex = 30;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(419, 92);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(302, 92);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(192, 92);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(81, 92);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // GUI_Tuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 350);
            this.Controls.Add(this.dgvTuyen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDoDaiTuyen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTuyen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBenDi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMaSoTuyen);
            this.Controls.Add(this.label1);
            this.Name = "GUI_Tuyen";
            this.Text = "GUI_Tuyen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTuyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDoDaiTuyen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBenDi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaSoTuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTuyen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}