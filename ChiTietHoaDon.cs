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
    public partial class ChiTietHoaDon : Form
    {
        private DataBaseController db = new DataBaseController();
        private InvoiceDetailController idc = new InvoiceDetailController();
        public ChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHD();
            for (int i = 0; i < dgvChiTietHoaDon.Columns.Count; i++)
            {
                dgvChiTietHoaDon.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void dgvChiTietHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvChiTietHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgvChiTietHoaDon[0, row].Value.ToString();
            txtMaSP.Text = dgvChiTietHoaDon[1, row].Value.ToString();
            txtSoLuong.Text = dgvChiTietHoaDon[2, row].Value.ToString();
            txtMaHD.ReadOnly = true;
            txtMaSP.ReadOnly = true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sSoHD = txtMaHD.Text;
            string sMaSP = txtMaSP.Text;
            string sSoLuong = txtSoLuong.Text;
            if (sSoHD != string.Empty && sMaSP != string.Empty && sSoLuong != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = idc.spInsertCTHD(sSoHD, sMaSP, sSoLuong);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Thêm hóa đơn thành công!");
                        dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHD();
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

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string sSoHD = txtMaHD.Text;
            string sMaSP = txtMaSP.Text;
            string sSoLuong = txtSoLuong.Text;

            if (sSoHD != string.Empty && sMaSP != string.Empty && sSoLuong != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = idc.spUpdateCTHD(sSoHD, sMaSP, sSoLuong);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Sửa thông tin hóa đơn thành công!");
                        dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHD();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin hóa đơn thất bại!! Hãy thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
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

        private void btnTimMa_Click_1(object sender, EventArgs e)
        {
            string sTimMaSP = string.Empty;
            sTimMaSP = txtTimMaSanPham.Text;
            if (sTimMaSP != string.Empty)
            {
                dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHDByMaSP(sTimMaSP);
                if (dgvChiTietHoaDon.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã sản phẩm này!");
                    dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHD();
                }
            }
            else
            {
                dgvChiTietHoaDon.DataSource = idc.spgetDataFromCTHD();
                MessageBox.Show("Bạn phải nhập mã chính xác!");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtSoLuong.Text = string.Empty;
            txtMaHD.ReadOnly = false;
            txtMaSP.ReadOnly = false;
            idc.spgetDataFromCTHD();
        }
    }
}
