using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class InvoiceController:DataBaseController
    {
        //Lấy tất cả dữ liệu bảng HD
        public DataTable getDataFromTable()
        {
            DataTable dt = new DataTable();
            string sqlTable = "select * from " + DataBaseController.HOA_DON;
            SqlCommand sqlcmdTable = new SqlCommand(sqlTable, conn);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }

        //THêm hóa đơn
        public int insertInvoice(string maKH, string maNV, string maHD, string triGia, string ngayXuat)
        {
            SqlCommand cmdInsertHD = new SqlCommand("spInsertInvoice", conn);
            cmdInsertHD.CommandType = CommandType.StoredProcedure;
            cmdInsertHD.Parameters.AddWithValue("@soHD", maHD);
            cmdInsertHD.Parameters.AddWithValue("@ngHD", ngayXuat);
            cmdInsertHD.Parameters.AddWithValue("@maKH", maKH);
            cmdInsertHD.Parameters.AddWithValue("@maNV", maNV);
            cmdInsertHD.Parameters.AddWithValue("@triGia", triGia);
            if (cmdInsertHD.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Xóa hóa đơn
        public int deleteInvoice(string maHD)
        {
            SqlCommand cmdDeleteKH = new SqlCommand("spDeleteInvoice", conn);
            cmdDeleteKH.CommandType = CommandType.StoredProcedure;
            cmdDeleteKH.Parameters.AddWithValue("@soHD", maHD);
            if (cmdDeleteKH.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Cập nhật hóa đơn
        public int updateInvoice(string maKH, string maNV, string maHD, string triGia, string ngayXuat)
        {
            SqlCommand cmdUpdateHD = new SqlCommand("spUpdateInvoice", conn);
            cmdUpdateHD.CommandType = CommandType.StoredProcedure;
            cmdUpdateHD.Parameters.AddWithValue("@soHD", maHD);
            cmdUpdateHD.Parameters.AddWithValue("@ngHD", ngayXuat);
            cmdUpdateHD.Parameters.AddWithValue("@maKH", maKH);
            cmdUpdateHD.Parameters.AddWithValue("@maNV", maNV);
            cmdUpdateHD.Parameters.AddWithValue("@triGia", triGia);
            if (cmdUpdateHD.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Tìm kiếm hóa đơn theo số HD
        public DataTable findInvoiceByID(string soHD)
        {
            DataTable dtHD = new DataTable();
            SqlCommand cmdHD = new SqlCommand("spFindInvoiceByID", conn);
            cmdHD.CommandType = CommandType.StoredProcedure;
            cmdHD.Parameters.AddWithValue("@soHD", soHD);
            SqlDataAdapter daHD = new SqlDataAdapter(cmdHD);
            daHD.Fill(dtHD);
            return dtHD;
        }

        //Tìm kiếm hóa đơn theo mã nhân viên
        public DataTable findInvoiceByEmployeeID(string maNV)
        {
            DataTable dtHD = new DataTable();
            SqlCommand cmdHD = new SqlCommand("spFindInvoiceByEmployeeID", conn);
            cmdHD.CommandType = CommandType.StoredProcedure;
            cmdHD.Parameters.AddWithValue("@maNV", maNV);
            SqlDataAdapter daHD = new SqlDataAdapter(cmdHD);
            daHD.Fill(dtHD);
            return dtHD;
        }

        //Tìm kiếm hóa đơn theo mã khách hàng
        public DataTable findInvoiceByCustomerID(string maKH)
        {
            DataTable dtHD = new DataTable();
            SqlCommand cmdHD = new SqlCommand("spFindInvoiceByCustomerID", conn);
            cmdHD.CommandType = CommandType.StoredProcedure;
            cmdHD.Parameters.AddWithValue("@maKH", maKH);
            SqlDataAdapter daHD = new SqlDataAdapter(cmdHD);
            daHD.Fill(dtHD);
            return dtHD;
        }
    }
}
