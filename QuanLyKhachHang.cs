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
    public partial class frmQuanLyKhachHang : Form
    {
        private DataBaseController db = new DataBaseController();
        private CustomerController cc = new CustomerController();
        public frmQuanLyKhachHang()
        {
            InitializeComponent();
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = cc.getDataFromTable();
            for (int i = 0; i < dgvKhachHang.Columns.Count; i++)
            {
                dgvKhachHang.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void DgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang[0, row].Value.ToString();
            txtTenKH.Text = dgvKhachHang[1, row].Value.ToString();
            txtDiaChi.Text = dgvKhachHang[2, row].Value.ToString();
            mtbSoDT.Text = dgvKhachHang[3, row].Value.ToString();
            dtpNgaySinh.Text = dgvKhachHang[4, row].Value.ToString();
            dtpNgayDKy.Text = dgvKhachHang[5, row].Value.ToString();
            txtDoanhSo.Text = dgvKhachHang[6, row].Value.ToString();
            txtMaKH.ReadOnly = true;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sDiaChi = txtDiaChi.Text;
            string sSoDT = mtbSoDT.Text;
            string ngaySinh = dtpNgaySinh.Text;
            string ngayDangKy = dtpNgayDKy.Text;
            string doanhSo = txtDoanhSo.Text;

            if (sMaKH != string.Empty && sTenKH != string.Empty && sDiaChi != string.Empty && sSoDT != string.Empty && doanhSo != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = cc.insertCustomer(sMaKH, sTenKH, sDiaChi, sSoDT, ngaySinh, ngayDangKy, doanhSo);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        dgvKhachHang.DataSource = cc.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!! Hãy thử lại!");
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
            string sMaKH = txtMaKH.Text;
            string sTenKH = txtTenKH.Text;
            string sDiaChi = txtDiaChi.Text;
            string sSoDT = mtbSoDT.Text;
            string ngaySinh = dtpNgaySinh.Text;
            string ngayDangKy = dtpNgayDKy.Text;
            string doanhSo = txtDoanhSo.Text;

            if (sMaKH != string.Empty && sTenKH != string.Empty && sDiaChi != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = cc.updateCustomer(sMaKH, sTenKH, sDiaChi, sSoDT, ngaySinh, ngayDangKy, doanhSo);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thành công!");
                        dgvKhachHang.DataSource = cc.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin khách hàng thất bại!! Hãy thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            int ketquaDel = 0;
            DialogResult r;
            r = MessageBox.Show("Bạn có muốn xóa khách hàng này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    ketquaDel = cc.deleteCustomer(dgvKhachHang.CurrentRow.Cells[0].Value.ToString());
                    if (ketquaDel != -1)
                    {
                        MessageBox.Show("Xóa thành công!!");
                        dgvKhachHang.DataSource = cc.getDataFromTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnTimMa_Click(object sender, EventArgs e)
        {
            string sTimMaKH = txtTimMa.Text;
            if (sTimMaKH != string.Empty)
            {
                dgvKhachHang.DataSource = cc.findCustomerByID(sTimMaKH);
                if (dgvKhachHang.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã khách hàng này!");
                    dgvKhachHang.DataSource = cc.getDataFromTable();
                }
            }
            else
            {
                dgvKhachHang.DataSource = cc.getDataFromTable();
                MessageBox.Show("Bạn phải nhập mã chính xác!");
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
            txtDiaChi.Text = string.Empty;
            txtDoanhSo.Text = string.Empty;
            txtMaKH.Text = string.Empty;
            txtTenKH.Text = string.Empty;
            txtTimMa.Text = string.Empty;
            txtTimTen.Text = string.Empty;
            mtbSoDT.Text = string.Empty;
            txtMaKH.ReadOnly = false;
            dgvKhachHang.DataSource = cc.getDataFromTable();
        }

        private void btnTimTen_Click(object sender, EventArgs e)
        {
            string sTenKH = txtTimTen.Text;
            if (sTenKH != string.Empty)
            {
                dgvKhachHang.DataSource = cc.findCustomerByName(sTenKH);
                if (dgvKhachHang.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy khách hàng này!");
                    dgvKhachHang.DataSource = cc.getDataFromTable();
                }
            }
            else
            {
                MessageBox.Show("Phải nhập tên khách hàng muốn tìm!!");
                dgvKhachHang.DataSource = cc.getDataFromTable();
            }
        }
    }
}
