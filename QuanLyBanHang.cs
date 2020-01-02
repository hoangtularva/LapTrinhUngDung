using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Threading;

namespace QuanLyBanHang
{
    public partial class frmQuanLiBanHang : Form
    {
        public frmQuanLiBanHang()
        {
            InitializeComponent();
        }

        private void TsmiNhanVien_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien nhanVien = new frmQuanLyNhanVien();
            nhanVien.Show();
        }

        private void TsmiSanPham_Click(object sender, EventArgs e)
        {
            frmQuanLySanPham sanPham = new frmQuanLySanPham();
            sanPham.Show();
        }

        private void TsmiKhachHang_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang khachHang = new frmQuanLyKhachHang();
            khachHang.Show();
        }

        private void FrmQuanLiBanHang_Load(object sender, EventArgs e)
        {
            ProductController pc = new ProductController();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }

        private void TsmiHoaDon_Click(object sender, EventArgs e)
        {
            frmQuanLyHoaDon hoaDon = new frmQuanLyHoaDon();
            hoaDon.Show();
        }
        private static int i = 80;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblQuanLiBanHang.Location = new Point(lblQuanLiBanHang.Location.X + i, lblQuanLiBanHang.Location.Y);
            if (lblQuanLiBanHang.Location.X > 220 || lblQuanLiBanHang.Location.X < 90)
            {
                i = -i;
            }

        }

        private void tsmiThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString();
        }
    }
}
