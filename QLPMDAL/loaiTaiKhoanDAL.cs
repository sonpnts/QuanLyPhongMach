using QLPMDTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPMDAL
{
    public class loaiTaiKhoanDAL
    {
        private string connectionString;
        public loaiTaiKhoanDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(loaiTaiKhoanDTO loaitk)
        {
            string query = string.Empty;
            query += "INSERT INTO [Roles] ([tenRole])";
            query += "VALUES (@tenRole)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenRole", loaitk.TenLoaiTaiKhoan);
                 
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
        public bool sua(loaiTaiKhoanDTO loaitk, string maLoaiTaiKhoanold)
        {
            string query = string.Empty;
     

            query += "update [Roles]";
            query += "set maRole=@maRole,tenRole=@tenRole where maRole=@maLoaiTaiKhoanold";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenRole", loaitk.TenLoaiTaiKhoan);
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
        public bool xoa(loaiTaiKhoanDTO loaitk)
        {
            string query = string.Empty;
            query += "delete from [Roles]";
            query += "where maRole=@maRole";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenRole", loaitk.TenLoaiTaiKhoan);
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
        public List<loaiTaiKhoanDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [Roles]";

            List<loaiTaiKhoanDTO> lsloaitk = new List<loaiTaiKhoanDTO>();

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
                                loaiTaiKhoanDTO loaitk = new loaiTaiKhoanDTO();
                                loaitk.TenLoaiTaiKhoan = reader["tenRole"].ToString();
                                loaitk.MaRole = int.Parse(reader["maRole"].ToString());

                                lsloaitk.Add(loaitk);
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
            return lsloaitk;
        }
    }
}
