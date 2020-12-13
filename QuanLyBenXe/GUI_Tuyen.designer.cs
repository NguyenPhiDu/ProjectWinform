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
            this.txtDoDaiTuyen.Location = new System.Drawing.Point(488, 63);
            this.txtDoDaiTuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDoDaiTuyen.Name = "txtDoDaiTuyen";
            this.txtDoDaiTuyen.Size = new System.Drawing.Size(225, 22);
            this.txtDoDaiTuyen.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(352, 66);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Độ Dài Tuyến:";
            // 
            // txtTuyen
            // 
            this.txtTuyen.Location = new System.Drawing.Point(488, 15);
            this.txtTuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTuyen.Name = "txtTuyen";
            this.txtTuyen.Size = new System.Drawing.Size(225, 22);
            this.txtTuyen.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tuyến:";
            // 
            // txtBenDi
            // 
            this.txtBenDi.Location = new System.Drawing.Point(100, 60);
            this.txtBenDi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBenDi.Name = "txtBenDi";
            this.txtBenDi.Size = new System.Drawing.Size(225, 22);
            this.txtBenDi.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Bến Đi:";
            // 
            // txtMaSoTuyen
            // 
            this.txtMaSoTuyen.Location = new System.Drawing.Point(100, 15);
            this.txtMaSoTuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaSoTuyen.Name = "txtMaSoTuyen";
            this.txtMaSoTuyen.Size = new System.Drawing.Size(225, 22);
            this.txtMaSoTuyen.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã Số Tuyến:";
            // 
            // dgvTuyen
            // 
            this.dgvTuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTuyen.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTuyen.Location = new System.Drawing.Point(0, 209);
            this.dgvTuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvTuyen.Name = "dgvTuyen";
            this.dgvTuyen.Size = new System.Drawing.Size(740, 222);
            this.dgvTuyen.TabIndex = 30;
            this.dgvTuyen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTuyen_CellContentClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(559, 113);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 26;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(403, 113);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 28);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(256, 113);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 28);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(108, 113);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 28);
            this.btnThem.TabIndex = 29;
            this.btnThem.Text = "&Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // GUI_Tuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 431);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GUI_Tuyen";
            this.Text = "GUI_Tuyen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GUI_Tuyen_FormClosing);
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