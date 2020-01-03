using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class CustomerController:DataBaseController
    {
        //Lấy tất cả dữ liệu khách hàng
        public DataTable getDataFromTable()
        {
            DataTable dt = new DataTable();
            string sqlTable = "select * from " + DataBaseController.KHACH_HANG;
            SqlCommand sqlcmdTable = new SqlCommand(sqlTable, conn);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }

        //Tìm kiếm theo tên khách hàng
        public DataTable findCustomerByName(string tenKH)
        {
            DataTable dtKH = new DataTable();
            SqlCommand cmdKH = new SqlCommand("spFindCustomerByName", conn);
            cmdKH.CommandType = CommandType.StoredProcedure;
            cmdKH.Parameters.AddWithValue("@tenKH", tenKH);
            SqlDataAdapter daKH = new SqlDataAdapter(cmdKH);
            daKH.Fill(dtKH);
            return dtKH;
        }

        //Tìm kiếm theo mã khách hàng
        public DataTable findCustomerByID(string maKH)
        {
            DataTable dtKH = new DataTable();
            SqlCommand cmdKH = new SqlCommand("spFindCustomerByID", conn);
            cmdKH.CommandType = CommandType.StoredProcedure;
            cmdKH.Parameters.AddWithValue("@maKH", maKH);
            SqlDataAdapter daKH = new SqlDataAdapter(cmdKH);
            daKH.Fill(dtKH);
            return dtKH;
        }

        //Tìm khách hàng theo số điên thoại
        public DataTable findCustomerByPhoneNumber(string soDT)
        {
            DataTable dtKH = new DataTable();
            SqlCommand cmdKH = new SqlCommand("spFindCustomerByPhoneNumber", conn);
            cmdKH.CommandType = CommandType.StoredProcedure;
            cmdKH.Parameters.AddWithValue("@soDT", soDT);
            SqlDataAdapter daKH = new SqlDataAdapter(cmdKH);
            daKH.Fill(dtKH);
            return dtKH;
        }

        //Thêm khách hàng
        public int insertCustomer(string maKH, string tenKH, string diaChi, string soDT, string ngaySinh, string ngayDK, string doanhSo)
        {
            SqlCommand cmdInsertKH = new SqlCommand("spInsertCustomer", conn);
            cmdInsertKH.CommandType = CommandType.StoredProcedure;
            cmdInsertKH.Parameters.AddWithValue("@maKH", maKH);
            cmdInsertKH.Parameters.AddWithValue("@tenKH", tenKH);
            cmdInsertKH.Parameters.AddWithValue("@diaChi", diaChi);
            cmdInsertKH.Parameters.AddWithValue("@soDT", soDT);
            cmdInsertKH.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            cmdInsertKH.Parameters.AddWithValue("@ngayDK", ngayDK);
            cmdInsertKH.Parameters.AddWithValue("@doanhSo", doanhSo);

            if (cmdInsertKH.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Xóa khách hàng
        public int deleteCustomer(string maKH)
        {
            SqlCommand cmdDeleteKH = new SqlCommand("spDeleteCustomer", conn);
            cmdDeleteKH.CommandType = CommandType.StoredProcedure;
            cmdDeleteKH.Parameters.AddWithValue("@maKH", maKH);
            if (cmdDeleteKH.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //Cập nhật thông tin khách hàng
        public int updateCustomer(string maKH, string tenKH, string diaChi, string soDT, string ngaySinh, string ngayDK, string doanhSo)
        {
            SqlCommand cmdUpdateKH = new SqlCommand("spUpdateCustomer", conn);
            cmdUpdateKH.CommandType = CommandType.StoredProcedure;
            cmdUpdateKH.Parameters.AddWithValue("@maKH", maKH);
            cmdUpdateKH.Parameters.AddWithValue("@tenKH", tenKH);
            cmdUpdateKH.Parameters.AddWithValue("@diaChi", diaChi);
            cmdUpdateKH.Parameters.AddWithValue("@soDT", soDT);
            cmdUpdateKH.Parameters.AddWithValue("@ngaySinh", ngaySinh);
            cmdUpdateKH.Parameters.AddWithValue("@ngayDK", ngayDK);
            cmdUpdateKH.Parameters.AddWithValue("@doanhSo", doanhSo);
            if (cmdUpdateKH.ExecuteNonQuery() > 0)
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
