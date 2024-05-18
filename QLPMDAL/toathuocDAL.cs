using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLPMDTO;
using System.Configuration;

namespace QLPMDAL
{
    public class ToathuocDAL
    {
        private string connectionString;

        public ToathuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(ToathuocDTO tt)
        {
            string query = string.Empty;
            query += "INSERT INTO [ToaThuoc] ([maPKB], [ngayKeToa])";
            query += "VALUES (@maPKB,@ngayKeToa)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query; ;
                    cmd.Parameters.AddWithValue("@maPKB", tt.MaPkb);
                    cmd.Parameters.AddWithValue("@ngayKeToa", tt.NgayKetoa);

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
        public List<ToathuocDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [ToaThuoc]";

            List<ToathuocDTO> lsToaThuoc = new List<ToathuocDTO>();

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
                                ToathuocDTO tt = new ToathuocDTO();
                                tt.MaToa = reader["maToaThuoc"].ToString();
                                tt.NgayKetoa = Convert.ToDateTime(reader["ngayKeToa"]);
                                tt.MaPkb = reader["maPKB"].ToString();

                                lsToaThuoc.Add(tt);
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
            return lsToaThuoc;
        }

        public int autogenerate_matoa()
        {
            int matoa = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MATOA) AS MM from (SELECT CONVERT(float, ToaThuoc.maToaThuoc) AS MATOA FROM ToaThuoc ) AS KQ";

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
                                matoa = int.Parse(reader["MM"].ToString()) + 1;
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
            return matoa;
        }
    }
}
