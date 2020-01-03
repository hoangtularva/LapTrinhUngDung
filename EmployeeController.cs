using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class EmployeeController:DataBaseController
    {

        //Lấy tất cả dữ liệu bảng NV
        public DataTable getDataFromTable()
        {
            DataTable dt = new DataTable();
            string sqlTable = "select * from " + DataBaseController.NHAN_VIEN;
            SqlCommand sqlcmdTable = new SqlCommand(sqlTable, conn);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }

        //Thêm nhân viên
        public bool insertEmployee(string maNV, string hoTen, string sdt, string ngvl)
        {
            SqlCommand cmdInsert = new SqlCommand("spInserEmployee", conn);
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@maNV", maNV);
            cmdInsert.Parameters.AddWithValue("@hoTen", hoTen);
            cmdInsert.Parameters.AddWithValue("@soDT", sdt);
            cmdInsert.Parameters.AddWithValue("@ngVL", ngvl);
            if (cmdInsert.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        //Xóa nhân viên
        public bool deleteEmployee(string maNV)
        {
            SqlCommand cmdDelete = new SqlCommand("spDeleteEmployee", conn);
            cmdDelete.CommandType = CommandType.StoredProcedure;
            cmdDelete.Parameters.AddWithValue("@maNV", maNV);
            if (cmdDelete.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        //Cập nhật thông tin nhân viên
        public bool updateEmployee(string maNV, string hoTen, string sdt, string ngvl)
        {
            SqlCommand cmdUpdate = new SqlCommand("spUpdateEmployee", conn);
            cmdUpdate.CommandType = CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@maNV", maNV);
            cmdUpdate.Parameters.AddWithValue("@hoTen", hoTen);
            cmdUpdate.Parameters.AddWithValue("@soDT", sdt);
            cmdUpdate.Parameters.AddWithValue("@ngVL", ngvl);
            if (cmdUpdate.ExecuteNonQuery() > 0)
            {
                return true;
            }
            return false;
        }

        //Tìm kiếm nhân viên theo tên
        public DataTable findEmployeeByName(string tenNV)
        {
            DataTable dt = new DataTable();
            SqlCommand sqlcmdTable = new SqlCommand("spFindEmployeeByName", conn);
            sqlcmdTable.CommandType = CommandType.StoredProcedure;
            sqlcmdTable.Parameters.AddWithValue("@tenNV", tenNV);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }
		
		//Tìm kiếm nhân viên theo số điện thoại
		public DataTable findEmployeeByPhoneNumber(string soDT){
			DataTable dt = new DataTable();
            SqlCommand sqlcmdTable = new SqlCommand("spFindEmployeeByPhoneNumber", conn);
            sqlcmdTable.CommandType = CommandType.StoredProcedure;
            sqlcmdTable.Parameters.AddWithValue("@soDT", soDT);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
		}
		
		//Tìm kiếm nhân viên theo mã nhân viên
		public DataTable findEmployeeByID(string maNV){
			DataTable dt = new DataTable();
            SqlCommand sqlcmdTable = new SqlCommand("spFindEmployeeByID", conn);
            sqlcmdTable.CommandType = CommandType.StoredProcedure;
            sqlcmdTable.Parameters.AddWithValue("@maNV", maNV);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
		}
    }
}
