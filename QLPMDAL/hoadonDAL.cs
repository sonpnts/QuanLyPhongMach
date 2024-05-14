using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLPMDTO;
using System.Configuration;
using System.Data.SqlClient;
namespace QLPMDAL
{
    public class HoadonDAL
    {
        private string connectionString;

        public HoadonDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(HoadonDTO hd)
        {
            string query = string.Empty;
            query += "INSERT INTO [HoaDon] ([ngayLapHoaDon], [tienThuoc], [tienKham], [tongTien], [maPKB], [maToaThuoc])";
            query += "VALUES (@ngayLapHoaDon,@tienThuoc,@tienKham,@tongTien,@maPKB,@maToaThuoc";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@ngayLapHoaDon", hd.NgayLapHoaDon);
					cmd.Parameters.AddWithValue("@tienThuoc", hd.TienThuoc);
					cmd.Parameters.AddWithValue("@tienKham", hd.TienKham);
					cmd.Parameters.AddWithValue("@tongTien", hd.TongTien);
                    cmd.Parameters.AddWithValue("@maPKB", hd.MaPKB);
                    cmd.Parameters.AddWithValue("@maToaThuoc", hd.MaToaThuoc);
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }
        public float tienthuoc(HoadonDTO hd, string maPKB)
        {
            float tien = 0;
            string query = string.Empty;
            query += "SELECT SUM(TH.donGia * KT.soLuong) AS TIENTHUOC ";
            query += "FROM PhieuKhamBenh PKB ";
            query += "JOIN ToaThuoc T ON PKB.maPKB = T.maPKB ";
            query += "JOIN KeThuoc KT ON T.maToaThuoc = KT.maToaThuoc ";
            query += "JOIN Thuoc TH ON KT.maThuoc = TH.maThuoc ";
            query += "WHERE PKB.maPKB = @maPKB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maPKB", maPKB);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["TIENTHUOC"] != DBNull.Value)
                                {
                                    tien = float.Parse(reader["TIENTHUOC"].ToString());
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log or handle the exception
                        throw new Exception("Error calculating medication cost: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            return tien;
        }


        public float tienkham()
        {
            float tien = 0;
            string query = "SELECT tienDichVu FROM DichVu WHERE tenDichVu = @tenDichVu";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@tenDichVu", "Kham benh");

                    try
                    {
                        con.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            tien = Convert.ToSingle(result);
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exception (optional: log the exception)
                        con.Close();
                    }
                }
            }
            return tien;
        }


        public float doanhthu(string ngayLapHoaDon)
        {
            float doanhthu = 0;
            string query = string.Empty;
            query += "SELECT sum (HD.TongTien) as doanhthu FROM HoaDon HD WHERE HD.NgayLapHoaDon=@NgayLapHoaDon";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NgayLapHoaDon", ngayLapHoaDon);
     
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                doanhthu = float.Parse(reader["doanhthu"].ToString());

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return doanhthu;
        }
        public int sobenhnhan(string ngayLapHoaDon)
        {
            int sobn = 0;
            string query = string.Empty;
            query += "SELECT count (HD.maHoaDon) as sobn FROM HoaDon HD WHERE HD.NgayLapHoaDon=@NgayLapHoaDon";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@NgayLapHoaDon", ngayLapHoaDon);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                sobn = int.Parse(reader["sobn"].ToString());

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return 0;
                    }
                }
            }
            return sobn;
        }
        public List<HoadonDTO> selectByMonth(string month,string year)
        {
            string query = string.Empty;
            query += " SELECT NgayLapHoaDon ";
            query += " FROM [HoaDon] ";
            query += " WHERE MONTH(NgayLapHoaDon)=@month and YEAR(NgayLapHoaDon)=@year group by NgayLapHoaDon ";


            List<HoadonDTO> lsHoadon = new List<HoadonDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@month", month);
                    cmd.Parameters.AddWithValue("@year", year);
                    try
                    {
                        con.Open();
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                HoadonDTO hd = new HoadonDTO();
                                hd.NgayLapHoaDon = DateTime.Parse(reader["NgayLapHoaDon"].ToString());
                                lsHoadon.Add(hd);

                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsHoadon;
        }
    }
}
