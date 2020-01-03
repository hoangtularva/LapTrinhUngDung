using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class InvoiceDetailController : DataBaseController
    {
        //Lấy tất cả dữ liệu bảng CTHD
        public DataTable spgetDataFromCTHD()
        {
            DataTable dt = new DataTable();
            string sqlTable = "select * from " + DataBaseController.CHI_TIET_HOA_DON;
            SqlCommand sqlcmdTable = new SqlCommand(sqlTable, conn);
            SqlDataAdapter dtTable = new SqlDataAdapter(sqlcmdTable);
            dtTable.Fill(dt);
            return dt;
        }

        //THêm CHI TIET hóa đơn
        public int spInsertCTHD(string soHD, string MaSP, string soLuong)
        {
            SqlCommand cmdInsertHD = new SqlCommand("spInsertCTHD", conn);
            cmdInsertHD.CommandType = CommandType.StoredProcedure;
            cmdInsertHD.Parameters.AddWithValue("@SOHD", soHD);
            cmdInsertHD.Parameters.AddWithValue("@MASP", MaSP);
            cmdInsertHD.Parameters.AddWithValue("@SOLUONG", soLuong);
            if (cmdInsertHD.ExecuteNonQuery() > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }


        //Cập nhật CHI TIET hóa đơn
        public int spUpdateCTHD(string soHD, string MaSP, string soLuong)
        {
            SqlCommand cmdUpdateHD = new SqlCommand("spUpdateCTHD", conn);
            cmdUpdateHD.CommandType = CommandType.StoredProcedure;
            cmdUpdateHD.Parameters.AddWithValue("@SOHD", soHD);
            cmdUpdateHD.Parameters.AddWithValue("@MASP", MaSP);
            cmdUpdateHD.Parameters.AddWithValue("@SOLUONG", soLuong);
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
        public DataTable spgetDataFromCTHDByMaSP(string MaSP)
        {
            DataTable dtHD = new DataTable();
            SqlCommand cmdHD = new SqlCommand("spgetDataFromCTHDByMaSP", conn);
            cmdHD.CommandType = CommandType.StoredProcedure;
            cmdHD.Parameters.AddWithValue("@MASP", MaSP);
            SqlDataAdapter daHD = new SqlDataAdapter(cmdHD);
            daHD.Fill(dtHD);
            return dtHD;
        }
    }
}
