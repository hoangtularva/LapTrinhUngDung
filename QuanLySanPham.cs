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
    public partial class frmQuanLySanPham : Form
    {
        private DataBaseController db = new DataBaseController();
        private ProductController pc = new ProductController();

        public frmQuanLySanPham()
        {
            InitializeComponent();
        }

        private void QuanLySanPham_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = pc.getDataFromTable();
            for (int i = 0; i < dgvSanPham.Columns.Count; i++)
            {
                dgvSanPham.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void BtnTimMa_Click(object sender, EventArgs e)
        {
            string maDM = txtTimMa.Text;
            if (maDM != string.Empty)
            {
                dgvSanPham.DataSource = pc.findProductByID(maDM);
                if (dgvSanPham.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy mã danh mục này!");
                    dgvSanPham.DataSource = pc.getDataFromTable();
                }
            }
            else
            {
                MessageBox.Show("Phải nhập mã danh mục muốn tìm!!");
                dgvSanPham.DataSource = pc.getDataFromTable();
            }
        }

        private void BtnTimTen_Click(object sender, EventArgs e)
        {
            string sTenSP = string.Empty;
            sTenSP = txtTimTen.Text;
            if (sTenSP != string.Empty)
            {
                dgvSanPham.DataSource = pc.findProductByName(sTenSP);
                if (dgvSanPham.Rows.Count == 1)
                {
                    MessageBox.Show("Không tìm thấy sản phẩm này!");
                    dgvSanPham.DataSource = pc.getDataFromTable();
                }
            }
            else
            {
                MessageBox.Show("Phải nhập tên sản phẩm muốn tìm!!");
                dgvSanPham.DataSource = pc.getDataFromTable();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            string MaDM = txtMaDM.Text;
            string TenSP = txtTenSP.Text;
            string donViTinh = txtDonViTinh.Text;
            string nuocSX = txtNuocSX.Text;
            string sGia = txtGia.Text;
            if (MaSP != string.Empty && MaDM != string.Empty && TenSP != string.Empty && donViTinh != string.Empty && nuocSX != string.Empty && sGia != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = pc.insertProduct(MaSP, MaDM, TenSP, donViTinh, nuocSX, sGia);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Thêm sản phẩm thành công!");
                        dgvSanPham.DataSource = pc.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Thêm sản phẩm thất bại!! Hãy thử lại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message,"Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu!!");
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            string MaSP = txtMaSP.Text;
            string MaDM = txtMaDM.Text;
            string TenSP = txtTenSP.Text;
            string donViTinh = txtDonViTinh.Text;
            string nuocSX = txtNuocSX.Text;
            string sGia = txtGia.Text;
            if (MaSP != string.Empty && MaDM != string.Empty && TenSP != string.Empty && donViTinh != string.Empty && nuocSX != string.Empty && sGia != string.Empty)
            {
                try
                {
                    int iKetQua;
                    iKetQua = pc.updateProduct(MaSP, MaDM, TenSP, donViTinh, nuocSX, sGia);
                    if (iKetQua == 1)
                    {
                        MessageBox.Show("Cập nhật sản phẩm thành công!");
                        dgvSanPham.DataSource = pc.getDataFromTable();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật sản phẩm thất bại!! Hãy thử lại!");
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
            r = MessageBox.Show("Bạn có muốn xóa sản phẩm này không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                try
                {
                    ketquaDel = pc.deleteProduct(dgvSanPham.CurrentRow.Cells[0].Value.ToString());
                    if (ketquaDel != -1)
                    {
                        MessageBox.Show("Xóa thành công!!");
                        dgvSanPham.DataSource = pc.getDataFromTable();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Text = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            txtMaDM.Text = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            txtTenSP.Text = dgvSanPham.CurrentRow.Cells[2].Value.ToString();
            txtDonViTinh.Text = dgvSanPham.CurrentRow.Cells[3].Value.ToString();
            txtNuocSX.Text = dgvSanPham.CurrentRow.Cells[4].Value.ToString();
            txtGia.Text = dgvSanPham.CurrentRow.Cells[5].Value.ToString();
            txtMaSP.ReadOnly = true;
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
            txtDonViTinh.Text = string.Empty;
            txtGia.Text = string.Empty;
            txtMaDM.Text = string.Empty;
            txtMaSP.Text = string.Empty;
            txtNuocSX.Text = string.Empty;
            txtTenSP.Text = string.Empty;
            txtTimMa.Text = string.Empty;
            txtTimTen.Text = string.Empty;
            txtMaSP.ReadOnly = false;
            dgvSanPham.DataSource =  pc.getDataFromTable();
        }
    }
}
