using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using QLPMDTO;

namespace QLPMDAL
{
    public class BenhNhanDAL
    {
        private string connectionString;

        public BenhNhanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool Them(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "INSERT INTO [BenhNhan] ([tenBenhNhan], [gioiTinh], [ngaySinh], [diaChi])";
            query += "VALUES ( @tenBenhNhan, @gioiTinh, @ngaySinh, @diaChi)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenBenhNhan", bn.TenBN);
                    cmd.Parameters.AddWithValue("@gioiTinh", bn.GtBN);
                    cmd.Parameters.AddWithValue("@ngaySinh", bn.NgsinhBN);
                    cmd.Parameters.AddWithValue("@diaChi", bn.DiachiBN);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
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

        public bool Sua(BenhNhanDTO bn, string maBNold)
        {

           
            string query = string.Empty;
            query += "UPDATE [BenhNhan] ";
            query += "SET tenBenhNhan=@tenBenhNhan, gioiTinh=@gioiTinh, ngaySinh=@ngaySinh, diaChi=@diaChi ";
            query += "WHERE maBenhNhan=@maBNold";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;

                    // Thêm tham số và giá trị của chúng
                    
                    cmd.Parameters.AddWithValue("@tenBenhNhan", bn.TenBN);
                    cmd.Parameters.AddWithValue("@gioiTinh", bn.GtBN);
                    cmd.Parameters.AddWithValue("@ngaySinh", bn.NgsinhBN);
                    cmd.Parameters.AddWithValue("@diaChi", bn.DiachiBN);
                    cmd.Parameters.AddWithValue("@maBNold", maBNold);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi
                        Console.WriteLine("Lỗi: " + ex.Message);
                    }
                } 
            }
                return true;
        }

       
        public bool Xoa(BenhNhanDTO bn)
        {
            string query = string.Empty;
            query += "DELETE FROM [BenhNhan] ";
            query += "WHERE maBenhNhan=@MaBN";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@MaBN", bn.MaBN);

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return false;
                    }
                }
            }
            return true;
        }

        public List<BenhNhanDTO> Select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [BenhNhan]";

            List<BenhNhanDTO> lsBenhNhan = new List<BenhNhanDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BenhNhanDTO bn = new BenhNhanDTO();
                                bn.MaBN = reader["maBenhNhan"].ToString();
                                bn.TenBN = reader["tenBenhNhan"].ToString();
                                bn.GtBN = reader["gioiTinh"].ToString();
                                bn.NgsinhBN = DateTime.Parse(reader["ngaySinh"].ToString());
                                bn.DiachiBN = reader["diaChi"].ToString();
                                //bn.MaPKB = reader["maPKB"].ToString();
                                lsBenhNhan.Add(bn);
                            }
                        }
                        con.Close();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsBenhNhan;
        }

        public List<BenhNhanDTO> SelectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [BenhNhan] ";
            query += "WHERE (maBenhNhan LIKE CONCAT('%',@sKeyword,'%')) ";
            query += "OR (tenBenhNhan LIKE CONCAT('%',@sKeyword,'%')) ";
            query += "OR (ngaySinh LIKE CONCAT('%',@sKeyword,'%')) ";

            List<BenhNhanDTO> lsBenhNhan = new List<BenhNhanDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                BenhNhanDTO bn = new BenhNhanDTO();
                                bn.MaBN = reader["maBenhNhan"].ToString();
                                bn.TenBN = reader["tenBenhNhan"].ToString();
                                bn.GtBN = reader["gioiTinh"].ToString();
                                bn.NgsinhBN = DateTime.Parse(reader["ngaySinh"].ToString());
                                bn.DiachiBN = reader["diaChi"].ToString();
                                lsBenhNhan.Add(bn);
                            }
                        }
                        con.Close();
                    }
                    catch (Exception)
                    {
                        con.Close();
                        return null;
                    }
                }
            }
            return lsBenhNhan;
        }

        public int AutoGenerateMaBN()
        {
            int maBN = 1;
            string query = string.Empty;
            query += "SELECT MAX(CAST(maBenhNhan AS INT)) AS MaxMaBN FROM [BenhNhan]";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                if (reader["MaxMaBN"] != DBNull.Value)
                                {
                                    maBN = int.Parse(reader["MaxMaBN"].ToString()) + 1;
                                }
                            }
                        }
                        con.Close();
                    }
                    catch (Exception)
                    {
                        con.Close();
                    }
                }
            }
            return maBN;
        }
    }
}
