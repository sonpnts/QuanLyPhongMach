using QLPMDTO; 
using System;
using System.Collections.Generic;
using System.Configuration; 
using System.Data.SqlClient; 

namespace QLPMDAL
{
    public class donViDAL 
    {
        private string connectionString; 

        // Constructor để khởi tạo chuỗi kết nối từ cài đặt trong file cấu hình
        public donViDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"]; // Đọc chuỗi kết nối từ cấu hình
        }

        // Thuộc tính cho phép đọc và thiết lập chuỗi kết nối
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        // Phương thức lấy danh sách các đơn vị từ cơ sở dữ liệu
        public List<donViDTO> getdonvi()
        {
            // Chuỗi truy vấn SQL để lấy dữ liệu từ bảng DonVi
            string query = "SELECT * FROM DonVi";

            // Khai báo danh sách để lưu trữ các đơn vị
            List<donViDTO> lsdv = new List<donViDTO>();

            // Sử dụng kết nối và lệnh SQL để truy vấn cơ sở dữ liệu
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con; // Thiết lập kết nối cho lệnh SQL
                    cmd.CommandType = System.Data.CommandType.Text; // Thiết lập loại lệnh là văn bản
                    cmd.CommandText = query; // Thiết lập nội dung lệnh SQL

                    try
                    {
                        con.Open(); // Mở kết nối đến cơ sở dữ liệu
                        SqlDataReader reader = cmd.ExecuteReader(); // Thực thi lệnh và lấy dữ liệu trả về
                        if (reader.HasRows) // Kiểm tra xem kết quả có hàng dữ liệu hay không
                        {
                            while (reader.Read()) // Duyệt qua từng hàng dữ liệu
                            {
                                // Đọc dữ liệu từ SqlDataReader và tạo đối tượng donViDTO
                                donViDTO dv = new donViDTO();
                                dv.MaDonVi = int.Parse(reader["maDonVi"].ToString()); // Đọc mã đơn vị
                                dv.TenDonVi = reader["tenDonVi"].ToString(); // Đọc tên đơn vị
                                lsdv.Add(dv); // Thêm đơn vị vào danh sách
                            }
                        }

                        con.Close(); // Đóng kết nối sau khi hoàn thành
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ nếu có lỗi xảy ra
                        Console.WriteLine("Lỗi: " + ex.Message);
                        con.Close(); // Đóng kết nối trong trường hợp xảy ra lỗi
                        return null; // Trả về null để biểu thị rằng có lỗi xảy ra
                    }
                }
            }
            return lsdv; 
        }
    }
}
