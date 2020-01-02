using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;

namespace QuanLyBanHang
{
    class DataBaseController
    {
        public static string SAN_PHAM = "SANPHAM";
        public static string KHACH_HANG = "KHACHHANG";
        public static string HOA_DON = "HOADON";
        public static string NHAN_VIEN = "NHANVIEN";
        public static string CHI_TIET_HOA_DON = "CTHD";

        protected SqlConnection conn = new SqlConnection();

        //Tạo kết nối đến CSDL
        public DataBaseController()
        {
            try
            {
                conn.ConnectionString = @"Data Source=.;Integrated Security=SSPI;Initial Catalog=QLBH";
                conn.Open();
            }
            catch (Exception ex)
            {
                
                conn.Close();
            }
        }

        
    }
}
