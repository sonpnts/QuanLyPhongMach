﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QLPMDTO;
using System.Configuration;
namespace QLPMDAL
{
    public class BenhDAL
    {
        private string connectionString;

        public BenhDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(BenhDTO be)
        {
            string query = string.Empty;
            query += "INSERT INTO [Benh] ([tenBenh])";
            query += "VALUES (@tenBenh)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                  
                    cmd.Parameters.AddWithValue("@tenBenh", be.TenBenh);
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
        public bool sua(BenhDTO be, string maBenhold)
        {
            string query = string.Empty;
            query += "update [Benh]";
            query += "set tenBenh=@tenBenh where maBenh=@maBenhold";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenBenh", be.TenBenh);
                    cmd.Parameters.AddWithValue("@maBenhold", maBenhold);
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
        public bool xoa(BenhDTO be)
        {
            string query = string.Empty;
            query += "delete from [Benh]";
            query += "where maBN=@maBN";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maBN", be.MaBenh);
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
        public List<BenhDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [Benh]";

            List<BenhDTO> lsBenh = new List<BenhDTO>();

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
                                BenhDTO be = new BenhDTO();
                                be.MaBenh = reader["maBenh"].ToString();
                                be.TenBenh = reader["tenBenh"].ToString();
                                lsBenh.Add(be);

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
            return lsBenh;
        }
        public List<BenhDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT * ";
            query += " FROM [Benh]";
            query += " WHERE ([maBenh] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tenBenh] LIKE CONCAT('%',@sKeyword,'%'))";

            List<BenhDTO> lsBenh = new List<BenhDTO>();

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
                                BenhDTO be = new BenhDTO();
                                be.MaBenh = reader["maBenh"].ToString();
                                be.TenBenh = reader["tenBenh"].ToString();
                                lsBenh.Add(be);

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
            return lsBenh;
        }
        public int autogenerate_mabenh()
        {
            int mabenh = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MABENH) AS MM from (SELECT CONVERT(float, Benh.maBenh) AS MABENH FROM Benh ) AS KQ";

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
                                mabenh = int.Parse(reader["MM"].ToString()) + 1;
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
            return mabenh;
        }
    }
}

