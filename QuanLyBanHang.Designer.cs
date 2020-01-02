namespace QuanLyBanHang
{
    partial class frmQuanLiBanHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLiBanHang));
            this.mnuQuanLiBanHang = new System.Windows.Forms.MenuStrip();
            this.tsmiNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblQuanLiBanHang = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDay = new System.Windows.Forms.Label();
            this.mnuQuanLiBanHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuQuanLiBanHang
            // 
            this.mnuQuanLiBanHang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuQuanLiBanHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuQuanLiBanHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNhanVien,
            this.tsmiKhachHang,
            this.tsmiSanPham,
            this.tsmiHoaDon,
            this.tsmiThoat});
            this.mnuQuanLiBanHang.Location = new System.Drawing.Point(0, 0);
            this.mnuQuanLiBanHang.Name = "mnuQuanLiBanHang";
            this.mnuQuanLiBanHang.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mnuQuanLiBanHang.Size = new System.Drawing.Size(822, 24);
            this.mnuQuanLiBanHang.TabIndex = 0;
            this.mnuQuanLiBanHang.Text = "mnuQuanLiBanHang";
            // 
            // tsmiNhanVien
            // 
            this.tsmiNhanVien.Name = "tsmiNhanVien";
            this.tsmiNhanVien.Size = new System.Drawing.Size(75, 20);
            this.tsmiNhanVien.Text = "Nhân viên";
            this.tsmiNhanVien.Click += new System.EventHandler(this.TsmiNhanVien_Click);
            // 
            // tsmiKhachHang
            // 
            this.tsmiKhachHang.Name = "tsmiKhachHang";
            this.tsmiKhachHang.Size = new System.Drawing.Size(83, 20);
            this.tsmiKhachHang.Text = "Khách hàng";
            this.tsmiKhachHang.Click += new System.EventHandler(this.TsmiKhachHang_Click);
            // 
            // tsmiSanPham
            // 
            this.tsmiSanPham.Name = "tsmiSanPham";
            this.tsmiSanPham.Size = new System.Drawing.Size(73, 20);
            this.tsmiSanPham.Text = "Sản phẩm";
            this.tsmiSanPham.Click += new System.EventHandler(this.TsmiSanPham_Click);
            // 
            // tsmiHoaDon
            // 
            this.tsmiHoaDon.Name = "tsmiHoaDon";
            this.tsmiHoaDon.Size = new System.Drawing.Size(67, 20);
            this.tsmiHoaDon.Text = "Hóa đơn";
            this.tsmiHoaDon.Click += new System.EventHandler(this.TsmiHoaDon_Click);
            // 
            // tsmiThoat
            // 
            this.tsmiThoat.Name = "tsmiThoat";
            this.tsmiThoat.Size = new System.Drawing.Size(51, 20);
            this.tsmiThoat.Text = "Thoát";
            this.tsmiThoat.Click += new System.EventHandler(this.tsmiThoat_Click);
            // 
            // lblQuanLiBanHang
            // 
            this.lblQuanLiBanHang.AutoSize = true;
            this.lblQuanLiBanHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblQuanLiBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuanLiBanHang.ForeColor = System.Drawing.Color.Blue;
            this.lblQuanLiBanHang.Location = new System.Drawing.Point(146, 153);
            this.lblQuanLiBanHang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuanLiBanHang.Name = "lblQuanLiBanHang";
            this.lblQuanLiBanHang.Size = new System.Drawing.Size(558, 63);
            this.lblQuanLiBanHang.TabIndex = 1;
            this.lblQuanLiBanHang.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(27, 37);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(97, 39);
            this.lblDay.TabIndex = 3;
            this.lblDay.Text = "Ngày";
            // 
            // frmQuanLiBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(822, 401);
            this.ControlBox = false;
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblQuanLiBanHang);
            this.Controls.Add(this.mnuQuanLiBanHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuQuanLiBanHang;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLiBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ BÁN HÀNG";
            this.Load += new System.EventHandler(this.FrmQuanLiBanHang_Load);
            this.mnuQuanLiBanHang.ResumeLayout(false);
            this.mnuQuanLiBanHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuQuanLiBanHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmiKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmiSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmiHoaDon;
        private System.Windows.Forms.Label lblQuanLiBanHang;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmiThoat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDay;
    }
}

