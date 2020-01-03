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
    public partial class frmQuanLyNhanVien : Form
    {
        private DataBaseController db = new DataBaseController();
        private EmployeeController ec = new EmployeeController();
        public frmQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FrmQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
            for (int i = 0; i < dgvQuanLyNhanVien.Columns.Count; i++)
            {
                dgvQuanLyNhanVien.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtHoTen.Text;
            string soDT = mtbSoDT.Text;
            string ngayVaoLam = dtpNgayVaoLam.Text;
            if (maNV != string.Empty && tenNV != string.Empty && soDT != string.Empty && ngayVaoLam != string.Empty)
            {
                try
                {
                    bool bKetQua = ec.insertEmployee(maNV, tenNV, soDT, ngayVaoLam);
                    if (bKetQua)
                    {
                        dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                        MessageBox.Show("Thêm thành công!");
                    }
                    txtMaNhanVien.Text = string.Empty;
                    txtHoTen.Text = string.Empty;
                    mtbSoDT.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void DgvQuanLyNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvQuanLyNhanVien.CurrentCell.RowIndex;
            txtMaNhanVien.Text = dgvQuanLyNhanVien[0, row].Value.ToString();
            txtMaNhanVien.ReadOnly = true;
            txtHoTen.Text = dgvQuanLyNhanVien[1, row].Value.ToString();
            mtbSoDT.Text = dgvQuanLyNhanVien[2, row].Value.ToString();
            dtpNgayVaoLam.Text = dgvQuanLyNhanVien[3, row].Value.ToString();
            txtMaNhanVien.ReadOnly = true;
        }

        private void BtnCapNhat_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtHoTen.Text;
            string soDT = mtbSoDT.Text;
            string ngayVaoLam = dtpNgayVaoLam.Text;
            if (maNV != string.Empty && tenNV != string.Empty && soDT != string.Empty && ngayVaoLam != string.Empty)
            {
                try
                {
                    bool bKetQua = ec.updateEmployee(maNV, tenNV, soDT, ngayVaoLam);
                    if (bKetQua)
                    {
                        dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                    txtMaNhanVien.Text = string.Empty;
                    txtHoTen.Text = string.Empty;
                    mtbSoDT.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa thông tin: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNhanVien.Text;
            string tenNV = txtHoTen.Text;
            string soDT = mtbSoDT.Text;
            string ngayVaoLam = dtpNgayVaoLam.Text;
            if (maNV != string.Empty && tenNV != string.Empty && soDT != string.Empty && ngayVaoLam != string.Empty)
            {
                try
                {
                    DialogResult dr = new DialogResult();
                    dr = MessageBox.Show("Bạn có chắc chắn muốn nhân viên này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        bool bKetQua = ec.deleteEmployee(maNV);
                        dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                        MessageBox.Show("Xóa thành công nhân viên " + maNV);
                    }
                    txtMaNhanVien.Text = string.Empty;
                    txtHoTen.Text = string.Empty;
                    mtbSoDT.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!");
            }
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string tenNV = txtTimKiem.Text;
                if (tenNV != string.Empty)
                {
                    dgvQuanLyNhanVien.DataSource = ec.findEmployeeByName(tenNV);
                    if (dgvQuanLyNhanVien.Rows.Count == 1)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên này!");
                        dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                    }
                }
                else
                {
                    MessageBox.Show("Phải nhập dữ liệu!");
                    dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            txtMaNhanVien.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            mtbSoDT.Text = string.Empty;
            txtTimKiem.Text = string.Empty;
            txtMaNhanVien.Text = string.Empty;
            txtMaNhanVien.ReadOnly = false;
            dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
        }

        private void btnTimMaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string manv = txtMaNhanVien.Text;
                if (manv != string.Empty)
                {
                    dgvQuanLyNhanVien.DataSource = ec.findEmployeeByID(manv);
                    if (dgvQuanLyNhanVien.Rows.Count == 1)
                    {
                        MessageBox.Show("Không tìm thấy mã nhân viên này!");
                        dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                    }
                }
                else
                {
                    MessageBox.Show("Phải nhập mã chính xác!");
                    dgvQuanLyNhanVien.DataSource = ec.getDataFromTable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
