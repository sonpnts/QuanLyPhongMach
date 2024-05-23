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
    public class DichvuDAL
    {
        private string connectionString;

        public DichvuDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(DichvuDTO dv)
        {
            string query = string.Empty;
            query += "INSERT INTO [DichVu] ([tenDichVu], [tienDichVu])";
            query += "VALUES (@tenDichVu,@tienDichVu)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenDichVu", dv.TenDichVu);
                    cmd.Parameters.AddWithValue("@tienDichVu", dv.TienDichVu);
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
        public bool sua(DichvuDTO dv, int maDichVuOld)
        {
            string query = string.Empty;
            query += "update [DichVu]";
            query += "set tenDichVu=@tenDichVu,tienDichVu=@tienDichVu where maDichVu=@maDichVuOld";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenDichVu", dv.TenDichVu);
                    cmd.Parameters.AddWithValue("@tienDichVu", dv.TienDichVu);
                    cmd.Parameters.AddWithValue("@maDichVuOld", maDichVuOld);
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

                return true;
            }
        }
        public bool xoa(DichvuDTO dv)
        {
            string query = string.Empty;
            query += "delete from [DichVu]";
            query += "where maDichVu=@maDichVu";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maDichVu", dv.MaDichVu);
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

                return true;
            }
        }
        public List<DichvuDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [DichVu]";

            List<DichvuDTO> lsDichVu = new List<DichvuDTO>();

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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DichvuDTO dv = new DichvuDTO();
                                dv.MaDichVu = int.Parse(reader["maDichVu"].ToString());
                                dv.TenDichVu = reader["tenDichVu"].ToString();
                                dv.TienDichVu = float.Parse(reader["tienDichVu"].ToString());

                                lsDichVu.Add(dv);

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
            return lsDichVu;
        }
        public List<DichvuDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT * ";
            query += " FROM [DichVu]";
            query += " WHERE ([maDichVu] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tenDichVu] LIKE CONCAT('%',@sKeyword,'%'))";

            List<DichvuDTO> lsDichVu = new List<DichvuDTO>();

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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                DichvuDTO dv = new DichvuDTO();
                                dv.MaDichVu = int.Parse(reader["maDichVu"].ToString());
                                dv.TenDichVu = reader["tenDichVu"].ToString();
                                dv.TienDichVu = float.Parse(reader["tienDichVu"].ToString());

                                lsDichVu.Add(dv);

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
            return lsDichVu;
        }

        public int autogenerate_madv()
        {
            int mathuoc = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MADICHVU) AS MM from (SELECT CONVERT(float, DichVu.maDichVu) AS MADICHVU FROM DichVu) AS KQ";

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
                        SqlDataReader reader = null;
                        reader = cmd.ExecuteReader();
                        if (reader.HasRows == true)
                        {
                            while (reader.Read())
                            {
                                mathuoc = int.Parse(reader["MM"].ToString()) + 1;
                            }
                        }

                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                    }
                }
            }
            return mathuoc;

        }
    }
}
