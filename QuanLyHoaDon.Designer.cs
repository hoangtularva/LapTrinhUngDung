namespace QuanLyBanHang
{
    partial class frmQuanLyHoaDon
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
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTimMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblTimMaHD = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dtpNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtTriGia = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.lblTriGia = new System.Windows.Forms.Label();
            this.lblMaNhanVien = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.txtMaKhachhang = new System.Windows.Forms.TextBox();
            this.lblNgayXuatHD = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.lblHD = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimMaNV = new System.Windows.Forms.Button();
            this.btnTimMaKH = new System.Windows.Forms.Button();
            this.lblTimMaNV = new System.Windows.Forms.Label();
            this.lblTimMaKH = new System.Windows.Forms.Label();
            this.txtTimMaNV = new System.Windows.Forms.TextBox();
            this.txtTimMaKH = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTim
            // 
            this.btnTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTim.Location = new System.Drawing.Point(324, 27);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 32);
            this.btnTim.TabIndex = 30;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // txtTimMaHoaDon
            // 
            this.txtTimMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaHoaDon.Location = new System.Drawing.Point(83, 34);
            this.txtTimMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMaHoaDon.Name = "txtTimMaHoaDon";
            this.txtTimMaHoaDon.Size = new System.Drawing.Size(237, 19);
            this.txtTimMaHoaDon.TabIndex = 29;
            // 
            // lblTimMaHD
            // 
            this.lblTimMaHD.AutoSize = true;
            this.lblTimMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMaHD.Location = new System.Drawing.Point(9, 37);
            this.lblTimMaHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimMaHD.Name = "lblTimMaHD";
            this.lblTimMaHD.Size = new System.Drawing.Size(75, 13);
            this.lblTimMaHD.TabIndex = 28;
            this.lblTimMaHD.Text = "Mã hóa đơn";
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(474, 490);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 32);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(588, 490);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 32);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(362, 490);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 32);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // dtpNgayXuat
            // 
            this.dtpNgayXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayXuat.Location = new System.Drawing.Point(180, 330);
            this.dtpNgayXuat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayXuat.Name = "dtpNgayXuat";
            this.dtpNgayXuat.Size = new System.Drawing.Size(138, 19);
            this.dtpNgayXuat.TabIndex = 23;
            // 
            // txtTriGia
            // 
            this.txtTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTriGia.Location = new System.Drawing.Point(180, 415);
            this.txtTriGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTriGia.Name = "txtTriGia";
            this.txtTriGia.Size = new System.Drawing.Size(138, 19);
            this.txtTriGia.TabIndex = 22;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhanVien.Location = new System.Drawing.Point(180, 387);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(138, 19);
            this.txtMaNhanVien.TabIndex = 21;
            // 
            // lblTriGia
            // 
            this.lblTriGia.AutoSize = true;
            this.lblTriGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriGia.Location = new System.Drawing.Point(62, 418);
            this.lblTriGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTriGia.Name = "lblTriGia";
            this.lblTriGia.Size = new System.Drawing.Size(45, 13);
            this.lblTriGia.TabIndex = 16;
            this.lblTriGia.Text = "Trị Giá";
            // 
            // lblMaNhanVien
            // 
            this.lblMaNhanVien.AutoSize = true;
            this.lblMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhanVien.Location = new System.Drawing.Point(62, 389);
            this.lblMaNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNhanVien.Name = "lblMaNhanVien";
            this.lblMaNhanVien.Size = new System.Drawing.Size(87, 13);
            this.lblMaNhanVien.TabIndex = 15;
            this.lblMaNhanVien.Text = "Mã Nhân Viên";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKhachHang.Location = new System.Drawing.Point(62, 361);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(98, 13);
            this.lblMaKhachHang.TabIndex = 19;
            this.lblMaKhachHang.Text = "Mã Khách Hàng";
            // 
            // txtMaKhachhang
            // 
            this.txtMaKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhachhang.Location = new System.Drawing.Point(180, 358);
            this.txtMaKhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKhachhang.Name = "txtMaKhachhang";
            this.txtMaKhachhang.Size = new System.Drawing.Size(138, 19);
            this.txtMaKhachhang.TabIndex = 20;
            // 
            // lblNgayXuatHD
            // 
            this.lblNgayXuatHD.AutoSize = true;
            this.lblNgayXuatHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayXuatHD.Location = new System.Drawing.Point(62, 334);
            this.lblNgayXuatHD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgayXuatHD.Name = "lblNgayXuatHD";
            this.lblNgayXuatHD.Size = new System.Drawing.Size(120, 13);
            this.lblNgayXuatHD.TabIndex = 14;
            this.lblNgayXuatHD.Text = "Ngày Xuất Hóa Đơn";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(180, 301);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(138, 19);
            this.txtMaHoaDon.TabIndex = 18;
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHoaDon.Location = new System.Drawing.Point(62, 304);
            this.lblMaHoaDon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(78, 13);
            this.lblMaHoaDon.TabIndex = 17;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(62, 58);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(714, 229);
            this.dgvHoaDon.TabIndex = 13;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHoaDon_CellContentClick);
            // 
            // lblHD
            // 
            this.lblHD.AutoSize = true;
            this.lblHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblHD.ForeColor = System.Drawing.Color.Blue;
            this.lblHD.Location = new System.Drawing.Point(305, 7);
            this.lblHD.Name = "lblHD";
            this.lblHD.Size = new System.Drawing.Size(282, 31);
            this.lblHD.TabIndex = 31;
            this.lblHD.Text = "QUẢN LÝ HÓA ĐƠN";
            this.lblHD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimMaNV);
            this.grbTimKiem.Controls.Add(this.btnTimMaKH);
            this.grbTimKiem.Controls.Add(this.btnTim);
            this.grbTimKiem.Controls.Add(this.lblTimMaNV);
            this.grbTimKiem.Controls.Add(this.lblTimMaKH);
            this.grbTimKiem.Controls.Add(this.lblTimMaHD);
            this.grbTimKiem.Controls.Add(this.txtTimMaNV);
            this.grbTimKiem.Controls.Add(this.txtTimMaKH);
            this.grbTimKiem.Controls.Add(this.txtTimMaHoaDon);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(362, 304);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimKiem.Size = new System.Drawing.Size(415, 170);
            this.grbTimKiem.TabIndex = 32;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnTimMaNV
            // 
            this.btnTimMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaNV.Location = new System.Drawing.Point(324, 126);
            this.btnTimMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMaNV.Name = "btnTimMaNV";
            this.btnTimMaNV.Size = new System.Drawing.Size(75, 32);
            this.btnTimMaNV.TabIndex = 30;
            this.btnTimMaNV.Text = "Tìm";
            this.btnTimMaNV.UseVisualStyleBackColor = true;
            this.btnTimMaNV.Click += new System.EventHandler(this.BtnTimMaNV_Click);
            // 
            // btnTimMaKH
            // 
            this.btnTimMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMaKH.Location = new System.Drawing.Point(324, 78);
            this.btnTimMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMaKH.Name = "btnTimMaKH";
            this.btnTimMaKH.Size = new System.Drawing.Size(75, 32);
            this.btnTimMaKH.TabIndex = 30;
            this.btnTimMaKH.Text = "Tìm";
            this.btnTimMaKH.UseVisualStyleBackColor = true;
            this.btnTimMaKH.Click += new System.EventHandler(this.BtnTimMaKH_Click);
            // 
            // lblTimMaNV
            // 
            this.lblTimMaNV.AutoSize = true;
            this.lblTimMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMaNV.Location = new System.Drawing.Point(9, 136);
            this.lblTimMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimMaNV.Name = "lblTimMaNV";
            this.lblTimMaNV.Size = new System.Drawing.Size(45, 13);
            this.lblTimMaNV.TabIndex = 28;
            this.lblTimMaNV.Text = "Mã NV";
            // 
            // lblTimMaKH
            // 
            this.lblTimMaKH.AutoSize = true;
            this.lblTimMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMaKH.Location = new System.Drawing.Point(9, 89);
            this.lblTimMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimMaKH.Name = "lblTimMaKH";
            this.lblTimMaKH.Size = new System.Drawing.Size(45, 13);
            this.lblTimMaKH.TabIndex = 28;
            this.lblTimMaKH.Text = "Mã KH";
            // 
            // txtTimMaNV
            // 
            this.txtTimMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaNV.Location = new System.Drawing.Point(83, 133);
            this.txtTimMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMaNV.Name = "txtTimMaNV";
            this.txtTimMaNV.Size = new System.Drawing.Size(237, 19);
            this.txtTimMaNV.TabIndex = 29;
            // 
            // txtTimMaKH
            // 
            this.txtTimMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaKH.Location = new System.Drawing.Point(83, 85);
            this.txtTimMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMaKH.Name = "txtTimMaKH";
            this.txtTimMaKH.Size = new System.Drawing.Size(237, 19);
            this.txtTimMaKH.TabIndex = 29;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(62, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 41);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "<";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(146, 451);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 32);
            this.btnLamMoi.TabIndex = 26;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChiTiet.Location = new System.Drawing.Point(702, 490);
            this.btnChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(75, 32);
            this.btnChiTiet.TabIndex = 34;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // frmQuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(833, 539);
            this.ControlBox = false;
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.lblHD);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgayXuat);
            this.Controls.Add(this.txtTriGia);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.lblTriGia);
            this.Controls.Add(this.lblMaNhanVien);
            this.Controls.Add(this.lblMaKhachHang);
            this.Controls.Add(this.txtMaKhachhang);
            this.Controls.Add(this.lblNgayXuatHD);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.dgvHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ HÓA ĐƠN";
            this.Load += new System.EventHandler(this.FrmQuanLyHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTimMaHoaDon;
        private System.Windows.Forms.Label lblTimMaHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpNgayXuat;
        private System.Windows.Forms.TextBox txtTriGia;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label lblTriGia;
        private System.Windows.Forms.Label lblMaNhanVien;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.TextBox txtMaKhachhang;
        private System.Windows.Forms.Label lblNgayXuatHD;
        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label lblHD;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnTimMaNV;
        private System.Windows.Forms.Button btnTimMaKH;
        private System.Windows.Forms.Label lblTimMaNV;
        private System.Windows.Forms.Label lblTimMaKH;
        private System.Windows.Forms.TextBox txtTimMaNV;
        private System.Windows.Forms.TextBox txtTimMaKH;
        private System.Windows.Forms.Button btnChiTiet;
    }
}