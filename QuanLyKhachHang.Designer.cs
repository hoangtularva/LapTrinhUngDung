namespace QuanLyBanHang
{
    partial class frmQuanLyKhachHang
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
            this.btnTimMa = new System.Windows.Forms.Button();
            this.lblTimMa = new System.Windows.Forms.Label();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.dtpNgayDKy = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtDoanhSo = new System.Windows.Forms.TextBox();
            this.lblDoanhSo = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblSoDT = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblNgDK = new System.Windows.Forms.Label();
            this.lblNgSinh = new System.Windows.Forms.Label();
            this.btnTimten = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblKH = new System.Windows.Forms.Label();
            this.dgvKhachHang = new System.Windows.Forms.DataGridView();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.mtbSoDT = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).BeginInit();
            this.grbTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimMa
            // 
            this.btnTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa.Location = new System.Drawing.Point(419, 25);
            this.btnTimMa.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimMa.Name = "btnTimMa";
            this.btnTimMa.Size = new System.Drawing.Size(100, 39);
            this.btnTimMa.TabIndex = 53;
            this.btnTimMa.Text = "Tìm mã";
            this.btnTimMa.UseVisualStyleBackColor = true;
            this.btnTimMa.Click += new System.EventHandler(this.BtnTimMa_Click);
            // 
            // lblTimMa
            // 
            this.lblTimMa.AutoSize = true;
            this.lblTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimMa.Location = new System.Drawing.Point(23, 39);
            this.lblTimMa.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimMa.Name = "lblTimMa";
            this.lblTimMa.Size = new System.Drawing.Size(95, 13);
            this.lblTimMa.TabIndex = 52;
            this.lblTimMa.Text = "Mã khách hàng";
            // 
            // txtTimMa
            // 
            this.txtTimMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMa.Location = new System.Drawing.Point(191, 37);
            this.txtTimMa.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(205, 19);
            this.txtTimMa.TabIndex = 51;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiem.Location = new System.Drawing.Point(23, 88);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(100, 13);
            this.lblTimKiem.TabIndex = 50;
            this.lblTimKiem.Text = "Tên khách hàng";
            // 
            // txtTimTen
            // 
            this.txtTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTen.Location = new System.Drawing.Point(191, 84);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(205, 19);
            this.txtTimTen.TabIndex = 49;
            // 
            // dtpNgayDKy
            // 
            this.dtpNgayDKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDKy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayDKy.Location = new System.Drawing.Point(238, 603);
            this.dtpNgayDKy.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgayDKy.Name = "dtpNgayDKy";
            this.dtpNgayDKy.Size = new System.Drawing.Size(227, 19);
            this.dtpNgayDKy.TabIndex = 48;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(238, 561);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(5);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(227, 19);
            this.dtpNgaySinh.TabIndex = 47;
            this.dtpNgaySinh.Value = new System.DateTime(2019, 12, 1, 0, 0, 0, 0);
            // 
            // txtDoanhSo
            // 
            this.txtDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoanhSo.Location = new System.Drawing.Point(238, 645);
            this.txtDoanhSo.Margin = new System.Windows.Forms.Padding(5);
            this.txtDoanhSo.Name = "txtDoanhSo";
            this.txtDoanhSo.Size = new System.Drawing.Size(227, 19);
            this.txtDoanhSo.TabIndex = 46;
            // 
            // lblDoanhSo
            // 
            this.lblDoanhSo.AutoSize = true;
            this.lblDoanhSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhSo.Location = new System.Drawing.Point(86, 648);
            this.lblDoanhSo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDoanhSo.Name = "lblDoanhSo";
            this.lblDoanhSo.Size = new System.Drawing.Size(65, 13);
            this.lblDoanhSo.TabIndex = 45;
            this.lblDoanhSo.Text = "Doanh số:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(238, 477);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(227, 19);
            this.txtDiaChi.TabIndex = 43;
            // 
            // lblSoDT
            // 
            this.lblSoDT.AutoSize = true;
            this.lblSoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoDT.Location = new System.Drawing.Point(86, 522);
            this.lblSoDT.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDT.Name = "lblSoDT";
            this.lblSoDT.Size = new System.Drawing.Size(87, 13);
            this.lblSoDT.TabIndex = 42;
            this.lblSoDT.Text = "Số điện thoại:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(86, 480);
            this.lblDiaChi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(51, 13);
            this.lblDiaChi.TabIndex = 41;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblNgDK
            // 
            this.lblNgDK.AutoSize = true;
            this.lblNgDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgDK.Location = new System.Drawing.Point(86, 606);
            this.lblNgDK.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgDK.Name = "lblNgDK";
            this.lblNgDK.Size = new System.Drawing.Size(90, 13);
            this.lblNgDK.TabIndex = 40;
            this.lblNgDK.Text = "Ngày đăng ký:";
            // 
            // lblNgSinh
            // 
            this.lblNgSinh.AutoSize = true;
            this.lblNgSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgSinh.Location = new System.Drawing.Point(86, 564);
            this.lblNgSinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgSinh.Name = "lblNgSinh";
            this.lblNgSinh.Size = new System.Drawing.Size(67, 13);
            this.lblNgSinh.TabIndex = 39;
            this.lblNgSinh.Text = "Ngày sinh:";
            // 
            // btnTimten
            // 
            this.btnTimten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimten.Location = new System.Drawing.Point(419, 76);
            this.btnTimten.Margin = new System.Windows.Forms.Padding(5);
            this.btnTimten.Name = "btnTimten";
            this.btnTimten.Size = new System.Drawing.Size(100, 39);
            this.btnTimten.TabIndex = 37;
            this.btnTimten.Text = "Tìm tên";
            this.btnTimten.UseVisualStyleBackColor = true;
            this.btnTimten.Click += new System.EventHandler(this.btnTimTen_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(657, 609);
            this.btnSua.Margin = new System.Windows.Forms.Padding(5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 39);
            this.btnSua.TabIndex = 36;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(796, 609);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 39);
            this.btnXoa.TabIndex = 35;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(518, 609);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 39);
            this.btnThem.TabIndex = 34;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(238, 435);
            this.txtTenKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(227, 19);
            this.txtTenKH.TabIndex = 33;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKH.Location = new System.Drawing.Point(238, 393);
            this.txtMaKH.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(227, 19);
            this.txtMaKH.TabIndex = 32;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKH.Location = new System.Drawing.Point(86, 438);
            this.lblTenKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(49, 13);
            this.lblTenKH.TabIndex = 31;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(86, 396);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(99, 13);
            this.lblMaKH.TabIndex = 30;
            this.lblMaKH.Text = "Mã khách hàng:";
            // 
            // lblKH
            // 
            this.lblKH.AutoSize = true;
            this.lblKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lblKH.ForeColor = System.Drawing.Color.Blue;
            this.lblKH.Location = new System.Drawing.Point(370, 24);
            this.lblKH.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKH.Name = "lblKH";
            this.lblKH.Size = new System.Drawing.Size(340, 31);
            this.lblKH.TabIndex = 29;
            this.lblKH.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.lblKH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvKhachHang
            // 
            this.dgvKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachHang.Location = new System.Drawing.Point(54, 72);
            this.dgvKhachHang.Margin = new System.Windows.Forms.Padding(5);
            this.dgvKhachHang.Name = "dgvKhachHang";
            this.dgvKhachHang.RowHeadersWidth = 51;
            this.dgvKhachHang.Size = new System.Drawing.Size(1049, 297);
            this.dgvKhachHang.TabIndex = 28;
            this.dgvKhachHang.VirtualMode = true;
            this.dgvKhachHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKhachHang_CellContentClick);
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.btnTimten);
            this.grbTimKiem.Controls.Add(this.btnTimMa);
            this.grbTimKiem.Controls.Add(this.txtTimTen);
            this.grbTimKiem.Controls.Add(this.lblTimMa);
            this.grbTimKiem.Controls.Add(this.lblTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimMa);
            this.grbTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiem.Location = new System.Drawing.Point(518, 396);
            this.grbTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grbTimKiem.Size = new System.Drawing.Size(546, 140);
            this.grbTimKiem.TabIndex = 54;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(54, 13);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 50);
            this.btnExit.TabIndex = 55;
            this.btnExit.Text = "<";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(941, 609);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(5);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 39);
            this.btnLamMoi.TabIndex = 36;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.BtnLamMoi_Click);
            // 
            // mtbSoDT
            // 
            this.mtbSoDT.Location = new System.Drawing.Point(238, 517);
            this.mtbSoDT.Mask = "000-000-0000";
            this.mtbSoDT.Name = "mtbSoDT";
            this.mtbSoDT.Size = new System.Drawing.Size(227, 19);
            this.mtbSoDT.TabIndex = 56;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1144, 699);
            this.ControlBox = false;
            this.Controls.Add(this.mtbSoDT);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.dtpNgayDKy);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtDoanhSo);
            this.Controls.Add(this.lblDoanhSo);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblSoDT);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblNgDK);
            this.Controls.Add(this.lblNgSinh);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblTenKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblKH);
            this.Controls.Add(this.dgvKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.QuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachHang)).EndInit();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimMa;
        private System.Windows.Forms.Label lblTimMa;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.DateTimePicker dtpNgayDKy;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtDoanhSo;
        private System.Windows.Forms.Label lblDoanhSo;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblSoDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblNgDK;
        private System.Windows.Forms.Label lblNgSinh;
        private System.Windows.Forms.Button btnTimten;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblKH;
        private System.Windows.Forms.DataGridView dgvKhachHang;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.MaskedTextBox mtbSoDT;
    }
}