using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class ProductController:DataBaseController
    {
        //Lấy tất cả dữ liệu bảng sản phẩm
        public DataTable getDataFromTable()
        {
            DataTable dt = new DataTable();
            string sqlTable = "select * from " + DataBaseController.SAN_PHAM;
            SqlCommand sqlcmdTable = new SqlCommand(sqlTable, conn);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }

        //Tìm kiếm sản phẩm theo tên sp
        public DataTable findProductByName(string tenSP)
        {
            DataTable dtSP = new DataTable();
            SqlCommand cmdSP = new SqlCommand("spFindProductByName", conn);
            cmdSP.CommandType = CommandType.StoredProcedure;
            cmdSP.Parameters.AddWithValue("@tenSP", tenSP);
            SqlDataAdapter daSP = new SqlDataAdapter(cmdSP);
            daSP.Fill(dtSP);
            return dtSP;
        }

        //TÌm kiếm sản phẩm theo mã danh mục sản phẩm
        public DataTable findProductByID(string maDM)
        {
            DataTable dtSP = new DataTable();
            SqlCommand cmdSP = new SqlCommand("spFindProductByID", conn);
            cmdSP.CommandType = CommandType.StoredProcedure;
            cmdSP.Parameters.AddWithValue("@maDM", maDM);
            SqlDataAdapter daSP = new SqlDataAdapter(cmdSP);
            daSP.Fill(dtSP);    
            return dtSP;
        }

        //Thên sảm phẩm
        public int insertProduct(string maSP, string maDM, string tenSP, string donViTinh, string nuocSX, string gia)
        {
            SqlCommand cmdInsertSP = new SqlCommand("spInsertSanPham", conn);
            cmdInsertSP.CommandType = CommandType.StoredProcedure;
            cmdInsertSP.Parameters.AddWithValue("@maSP", maSP);
            cmdInsertSP.Parameters.AddWithValue("@maDM", maDM);
            cmdInsertSP.Parameters.AddWithValue("@tenSP", tenSP);
            cmdInsertSP.Parameters.AddWithValue("@donViTinh", donViTinh);
            cmdInsertSP.Parameters.AddWithValue("@nuocSX", nuocSX);
            cmdInsertSP.Parameters.AddWithValue("@gia", gia);

            if (cmdInsertSP.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Xóa sản phẩm
        public int deleteProduct(string maSP)
        {
            SqlCommand cmdDeleteSP = new SqlCommand("spDeleteProduct", conn);
            cmdDeleteSP.CommandType = CommandType.StoredProcedure;
            cmdDeleteSP.Parameters.AddWithValue("@maSP", maSP);
            if (cmdDeleteSP.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Cập nhật sản phẩm
        public int updateProduct(string maSP, string maDM, string tenSP, string donViTinh, string nuocSX, string gia)
        {
            SqlCommand cmdInsertSP = new SqlCommand("spUpdateProduct", conn);
            cmdInsertSP.CommandType = CommandType.StoredProcedure;
            cmdInsertSP.Parameters.AddWithValue("@maSP", maSP);
            cmdInsertSP.Parameters.AddWithValue("@maDM", maDM);
            cmdInsertSP.Parameters.AddWithValue("@tenSP", tenSP);
            cmdInsertSP.Parameters.AddWithValue("@donViTinh", donViTinh);
            cmdInsertSP.Parameters.AddWithValue("@nuocSX", nuocSX);
            cmdInsertSP.Parameters.AddWithValue("@gia", gia);

            if (cmdInsertSP.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
