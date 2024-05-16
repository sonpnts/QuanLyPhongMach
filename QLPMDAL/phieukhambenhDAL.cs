using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using QLPMDTO;
using System.Text;

namespace QLPMDAL
{
    public class PhieukhambenhDAL
    {
        private string connectionString;

        public PhieukhambenhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }

        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public bool them(PhieukhambenhDTO pkb)
        {
            string query = string.Empty;
            query += "INSERT INTO [PhieuKhamBenh] ([NgayKham],[trieuChung],[maBenhNhan], [maTaiKhoan]) ";
            query += "VALUES (@NgayKham , @trieuChung, @maBenhNhan, @maTaiKhoan)";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@NgayKham", pkb.NgayKham);
                    cmd.Parameters.AddWithValue("@trieuChung", pkb.TrieuChung);
                    cmd.Parameters.AddWithValue("@maBenhNhan", pkb.MaBenhNhan);
                    cmd.Parameters.AddWithValue("@maTaiKhoan", pkb.MBS);

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

        public int AutoGenerateMaPKB()
        {
            int maPKB = 1;
            string query = "SELECT MAX(maPKB) AS MaxMaPKB FROM [PhieuKhamBenh]";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            maPKB = Convert.ToInt32(reader["MaxMaPKB"]) + 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return maPKB;
        }

        public bool sua(PhieukhambenhDTO pkb)
        {
            string query = "UPDATE [PhieuKhamBenh] SET TrieuChung = @TrieuChung WHERE maPKB = @maPKB";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@maPKB", pkb.MaPKB);
                    cmd.Parameters.AddWithValue("@TrieuChung", pkb.TrieuChung);
                    

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return false;
                    }
                }
            }
            return true;
        }

        public List<PhieukhambenhDTO> select()
        {
            string query = "SELECT * FROM [PhieuKhamBenh]";
            List<PhieukhambenhDTO> lspkb = new List<PhieukhambenhDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PhieukhambenhDTO pkb = new PhieukhambenhDTO();
                            pkb.MaPKB = reader["maPKB"].ToString();
                            pkb.TrieuChung = reader["TrieuChung"].ToString();
                            pkb.NgayKham = Convert.ToDateTime(reader["NgayKham"]);
                            pkb.MaBenhNhan = reader["maBenhNhan"].ToString();
                            pkb.MBS = int.Parse(reader["maTaiKhoan"].ToString());
                            lspkb.Add(pkb);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lspkb;
        }

        public List<PhieukhambenhDTO> selectByKeyWord(string sKeyword)
        {
            string query = "SELECT * FROM [PhieuKhamBenh] WHERE (maPKB LIKE '%' + @sKeyword + '%') OR (NgayKham = @sKeyword)";
            List<PhieukhambenhDTO> lspkb = new List<PhieukhambenhDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@sKeyword", sKeyword);

                    try
                    {
                        con.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PhieukhambenhDTO pkb = new PhieukhambenhDTO();
                            pkb.MaPKB = reader["maPKB"].ToString();
                            pkb.TrieuChung = reader["TrieuChung"].ToString();
                            pkb.NgayKham = Convert.ToDateTime(reader["NgayKham"]);
                            pkb.MaBenhNhan = reader["maBenhNhan"].ToString();
                            lspkb.Add(pkb);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return lspkb;
        }
        //public void tk()
        //{
        //    string query = string.Empty;
        //    query += "SELECT * FROM tblTK ";

        //    using (SqlConnection con = new SqlConnection(ConnectionString))
        //    {

        //        using (SqlCommand cmd = new SqlCommand())
        //        {
        //            cmd.Connection = con;
        //            cmd.CommandType = System.Data.CommandType.Text;
        //            cmd.CommandText = query;

        //            try
        //            {
        //                con.Open();
        //                SqlDataReader reader = null;
        //                reader = cmd.ExecuteReader();
        //                if (reader.HasRows == true)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        PhieukhambenhDTO.TienKham = float.Parse(reader["tienKham"].ToString());
        //                    }
        //                }

        //                con.Close();
        //                con.Dispose();
        //            }
        //            catch (Exception ex)
        //            {
        //                con.Close();

        //            }
        //        }
        //    }
        //}
        public bool thaydoiTK(float tkmoi, float tkcu)
        {
            string query = string.Empty;
            query += "UPDATE [tblTK] set tienKham=@tkmoi where tienKham=@tkcu";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tkmoi", tkmoi);
                    cmd.Parameters.AddWithValue("@tkcu", tkcu);

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
        public bool drop_trigger_khamtoida()
        {
            string query = string.Empty;
            query += "USE [QLPM]\r\nIF EXISTS (SELECT * FROM sys.objects WHERE [name] = 'kham_toida1')\r\nBEGIN\r\nDROP TRIGGER [dbo].[kham_toida1];\r\nEND;\r\n";


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
        public bool thaydoi_khamtoida(int khamtoida)
        {
            string query = string.Empty;
            query += "EXEC sp_executeSQL N'Create Trigger kham_toida1 ON tblPKB FOR INSERT AS BEGIN IF(Select Count(a.maPKB) From tblPKB a Inner Join INSERTED b On a.NgayKham = b.NgayKham) > 80 BEGIN ROLLBACK TRANSACTION END END'";
            string triggername = "kham_toida1";

            string tablename = "tblPKB";


            StringBuilder cmd = new StringBuilder();

            cmd.AppendLine("EXEC sp_executeSQL");
            cmd.AppendLine("N'");


            cmd.AppendLine(string.Format("CREATE TRIGGER dbo.{0}", triggername));

            cmd.AppendLine(string.Format("ON dbo.{0}", tablename));

            cmd.AppendLine("AFTER INSERT");

            cmd.AppendLine("AS begin");

            cmd.AppendLine(string.Format("IF(Select Count(a.maPKB) From tblPKB a Inner Join INSERTED b On a.NgayKham = b.NgayKham) > {0}", khamtoida));

            cmd.AppendLine("BEGIN");


            cmd.AppendLine("ROLLBACK TRANSACTION");

            cmd.AppendLine("END");

            cmd.AppendLine("END");

            cmd.AppendLine("'");

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cm = new SqlCommand())
                {
                    cm.Connection = con;
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.CommandText = cmd.ToString();
                    //cm.Parameters.AddWithValue("@khamtoida", khamtoida);
                    try
                    {
                        con.Open();
                        cm.ExecuteNonQuery();
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
    }
}
