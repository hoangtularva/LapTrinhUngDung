using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmQuanLyHoaDon : Form
    {
        private DataBaseController db = new DataBaseController();
        private InvoiceController ic = new InvoiceController();
        public frmQuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKhachhang.Text;
            string sMaNV = txtMaNhanVien.Text;
            string sMaHD = txtMaHoaDon.Text;
            string sTriGia = txtTriGia.Text;
            string sNgayXuat = dtpNgayXuat.Text;

            if (sMaHD != string.Empty && sMaKH != string.Empty && sMaNV != string.Empty && sTriGia != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = ic.insertInvoice(sMaKH, sMaNV, sMaHD, sTriGia, sNgayXuat);

                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        dgvHoaDon.DataSource = ic.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Thêm hóa đơn thất bại!! Hãy thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu!!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int ketquaDel = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa hóa đơn này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    ketquaDel = ic.deleteInvoice(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());
                    if (ketquaDel != -1)
                    {
                        MessageBox.Show("Xóa thành công!!");
                        dgvHoaDon.DataSource = ic.getDataFromTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKhachhang.Text;
            string sMaNV = txtMaNhanVien.Text;
            string sMaHD = txtMaHoaDon.Text;
            string sTriGia = txtTriGia.Text;
            string sNgayXuat = dtpNgayXuat.Text;

            if (sMaHD != string.Empty && sMaKH != string.Empty && sMaNV != string.Empty && sTriGia != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = ic.updateInvoice(sMaKH, sMaNV, sMaHD, sTriGia, sNgayXuat);

                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Sửa hóa đơn thành công!");
                        dgvHoaDon.DataSource = ic.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Sửa hóa đơn thất bại!! Hãy thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu!!");
            }
        }

        private void DgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvHoaDon.CurrentCell.RowIndex;
            txtMaHoaDon.Text = dgvHoaDon.Rows[row].Cells[0].Value.ToString();
            dtpNgayXuat.Text = dgvHoaDon.Rows[row].Cells[1].Value.ToString();
            txtMaKhachhang.Text = dgvHoaDon.Rows[row].Cells[2].Value.ToString();
            txtMaNhanVien.Text = dgvHoaDon.Rows[row].Cells[3].Value.ToString();
            txtTriGia.Text = dgvHoaDon.Rows[row].Cells[4].Value.ToString();
            txtMaHoaDon.ReadOnly = true;
        }

        private void FrmQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dgvHoaDon.DataSource = ic.getDataFromTable();
            for (int i = 0; i < dgvHoaDon.Columns.Count; i++)
            {
                dgvHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string sTimMaHD = txtTimMaHoaDon.Text;
            if (sTimMaHD != string.Empty)
            {
                dgvHoaDon.DataSource = ic.findInvoiceByID(sTimMaHD);
                if (dgvHoaDon.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã hóa đơn này!");
                    dgvHoaDon.DataSource = ic.getDataFromTable();
                }
            }
            else
            {
                dgvHoaDon.DataSource = ic.getDataFromTable();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("Bạn có muốn trở về không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Close();
            }
        }

        private void BtnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHoaDon.Text = string.Empty;
            txtMaKhachhang.Text = string.Empty;
            txtMaNhanVien.Text = string.Empty;
            txtTimMaHoaDon.Text = string.Empty;
            txtTriGia.Text = string.Empty;
            txtTimMaHoaDon.Text = string.Empty;
            txtTimMaKH.Text = string.Empty;
            txtMaHoaDon.ReadOnly = false;
            dgvHoaDon.DataSource = ic.getDataFromTable();
        }

        private void BtnTimMaKH_Click(object sender, EventArgs e)
        {
            string sMaKH = txtTimMaKH.Text;
            if (sMaKH != string.Empty)
            {
                dgvHoaDon.DataSource = ic.findInvoiceByCustomerID(sMaKH);
                if (dgvHoaDon.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng này!");
                    dgvHoaDon.DataSource = ic.getDataFromTable();
                }
            }
            else
            {
                dgvHoaDon.DataSource = ic.getDataFromTable();
            }
        }

        private void BtnTimMaNV_Click(object sender, EventArgs e)
        {
            string sMaNV = txtTimMaNV.Text;
            if (sMaNV != string.Empty)
            {
                dgvHoaDon.DataSource = ic.findInvoiceByEmployeeID(sMaNV);
                if (dgvHoaDon.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên đơn này!");
                    dgvHoaDon.DataSource = ic.getDataFromTable();
                }
            }
            else
            {
                dgvHoaDon.DataSource = ic.getDataFromTable();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon CTHD = new ChiTietHoaDon();
            CTHD.Show();
        }
    }
}
