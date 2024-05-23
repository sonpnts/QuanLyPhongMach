using System; 
using System.Collections.Generic;
using System.Configuration; 
using System.Data.SqlClient; 
using QLPMDTO; 

namespace QLPMDAL 
{
    public class ChandoanDAL
    {
        private string connectionString; // Biến chuỗi kết nối cơ sở dữ liệu

        public ChandoanDAL() // Hàm khởi tạo cho lớp ChandoanDAL
        {
            // Đọc chuỗi kết nối từ cấu hình ứng dụng
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        // Thuộc tính cho chuỗi kết nối
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        // Phương thức thêm mới một chẩn đoán
        public bool them(ChandoanDTO cd)
        {
            // Chuỗi truy vấn SQL để thêm mới chẩn đoán
            string query = string.Empty;
            query += "INSERT INTO [ChuanDoan] ([maBenh], [maPKB]) ";
            query += "VALUES (@maBenh,@maPKB)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con; // Kết nối lệnh với cơ sở dữ liệu
                    cmd.CommandType = System.Data.CommandType.Text; // Kiểu lệnh là văn bản
                    cmd.CommandText = query; // Gán chuỗi truy vấn cho lệnh
                    cmd.Parameters.AddWithValue("@maBenh", cd.MaBenh); // Gán giá trị cho tham số @maBenh
                    cmd.Parameters.AddWithValue("@maPKB", cd.MaPkb); // Gán giá trị cho tham số @maPKB

                    try
                    {
                        con.Open(); // Mở kết nối
                        cmd.ExecuteNonQuery(); // Thực thi lệnh thêm mới
                        con.Close(); // Đóng kết nối
                        con.Dispose(); // Giải phóng tài nguyên kết nối
                    }
                    catch (Exception ex)
                    {
                        con.Close(); // Đóng kết nối khi có lỗi
                        return false; // Trả về false nếu có lỗi
                    }
                }
            }
            return true; 
        }

        // Phương thức lấy danh sách các chẩn đoán
        public List<ChandoanDTO> select()
        {
            // Chuỗi truy vấn SQL để lấy danh sách chẩn đoán
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [ChuanDoan]";

            List<ChandoanDTO> lscd = new List<ChandoanDTO>(); // Danh sách để chứa kết quả

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con; // Kết nối lệnh với cơ sở dữ liệu
                    cmd.CommandType = System.Data.CommandType.Text; // Kiểu lệnh là văn bản
                    cmd.CommandText = query; // Gán chuỗi truy vấn cho lệnh

                    try
                    {
                        con.Open(); // Mở kết nối
                        SqlDataReader reader = cmd.ExecuteReader(); // Thực thi lệnh và nhận kết quả
                        if (reader.HasRows == true) // Kiểm tra nếu có kết quả trả về
                        {
                            while (reader.Read()) // Đọc từng dòng kết quả
                            {
                                ChandoanDTO cd = new ChandoanDTO(); // Tạo đối tượng ChandoanDTO
                                cd.MaPkb = reader["maPKB"].ToString(); // Gán giá trị cho MaPkb
                                cd.MaBenh = reader["maBenh"].ToString(); 
                                lscd.Add(cd); // Thêm vào danh sách
                            }
                        }

                        con.Close(); // Đóng kết nối
                        con.Dispose(); // Giải phóng tài nguyên kết nối
                    }
                    catch (Exception ex)
                    {
                        con.Close(); // Đóng kết nối khi có lỗi
                        return null; // Trả về null nếu có lỗi
                    }
                }
            }
            return lscd; 
        }
    }
}
