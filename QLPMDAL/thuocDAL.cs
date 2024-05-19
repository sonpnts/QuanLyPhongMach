﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using QLPMDTO;
using System.Configuration;

namespace QLPMDAL
{
    public class ThuocDAL
    {
        private string connectionString;

        public ThuocDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public bool them(ThuocDTO th)
        {
            string query = string.Empty;
            query += "INSERT INTO [Thuoc] ([tenThuoc],[maDonVi],[Dongia],[maCachDung])";
            query += "VALUES (@tenThuoc,@donVi,@Dongia,@CachDung)";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenThuoc", th.TenThuoc);
                    cmd.Parameters.AddWithValue("@donVi", th.MaDonVi);
                    cmd.Parameters.AddWithValue("@Dongia", th.DonGia);
                    cmd.Parameters.AddWithValue("@CachDung", th.MaCachDung);
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
        public bool sua(ThuocDTO th, string maThuocold)
        {
            string query = string.Empty;
            query += "update [Thuoc]";
            query += "set tenThuoc=@tenThuoc,maDonVi=@DonVi,Dongia=@Dongia,maCachDung=@CachDung where maThuoc=@maThuocold";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@tenThuoc", th.TenThuoc);
                    cmd.Parameters.AddWithValue("@DonVi", th.MaDonVi);
                    cmd.Parameters.AddWithValue("@Dongia", th.DonGia);
                    cmd.Parameters.AddWithValue("@CachDung", th.MaCachDung);
                    cmd.Parameters.AddWithValue("@maThuocold", maThuocold);
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
        public bool xoa(ThuocDTO th)
        {
            string query = string.Empty;
            query += "delete from [Thuoc]";
            query += "where maThuoc=@maThuoc";

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@maThuoc", th.MaThuoc);
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
        public List<ThuocDTO> select()
        {
            string query = string.Empty;
            query += "SELECT * ";
            query += "FROM [Thuoc]";

            List<ThuocDTO> lsThuoc = new List<ThuocDTO>();

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
                                ThuocDTO th = new ThuocDTO();
                                th.MaThuoc = reader["maThuoc"].ToString();
                                th.TenThuoc = reader["tenThuoc"].ToString();
                                th.MaDonVi = int.Parse(reader["maDonVi"].ToString());
                                th.MaCachDung = int.Parse(reader["maCachDung"].ToString());
                                th.DonGia = float.Parse(reader["donGia"].ToString());

                                lsThuoc.Add(th);

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
            return lsThuoc;
        }
        public List<ThuocDTO> selectByKeyWord(string sKeyword)
        {
            string query = string.Empty;
            query += " SELECT * ";
            query += " FROM [Thuoc]";
            query += " WHERE ([maThuoc] LIKE CONCAT('%',@sKeyword,'%'))";
            query += " OR ([tenThuoc] LIKE CONCAT('%',@sKeyword,'%'))";

            List<ThuocDTO> lsThuoc = new List<ThuocDTO>();

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
                                ThuocDTO th = new ThuocDTO();
                                th.MaThuoc = reader["maThuoc"].ToString();
                                th.TenThuoc = reader["tenThuoc"].ToString();
                                th.MaDonVi = int.Parse(reader["maDonVi"].ToString());
                                th.MaCachDung = int.Parse(reader["maCachDung"].ToString());
                                th.DonGia = float.Parse(reader["donGia"].ToString());

                                lsThuoc.Add(th);

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
            return lsThuoc;
        }
        public int autogenerate_mathuoc()
        {
            int mathuoc = 1;
            string query = string.Empty;
            query += "SELECT MAX (KQ.MATHUOC) AS MM from (SELECT CONVERT(float, Thuoc.maThuoc) AS MATHUOC FROM Thuoc) AS KQ";

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
        public List<ThuocDTO> selectbypkb(string mapkb)
        {
            string query = @"
        SELECT TH.maThuoc, TH.tenThuoc, TH.maCachDung, TH.maDonVi, TH.donGia 
        FROM PhieuKhamBenh PKB 
        JOIN ToaThuoc T ON PKB.maPKB = T.maPKB 
        JOIN KeThuoc KT ON T.maToaThuoc = KT.maToaThuoc 
        JOIN Thuoc TH ON KT.maThuoc = TH.maThuoc 
        WHERE PKB.maPKB = @mapkb";

            List<ThuocDTO> lsThuoc = new List<ThuocDTO>();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.AddWithValue("@mapkb", mapkb);
                    try
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    ThuocDTO th = new ThuocDTO
                                    {
                                        MaThuoc = reader["maThuoc"].ToString(),
                                        TenThuoc = reader["tenThuoc"].ToString(),
                                        MaDonVi = int.Parse(reader["maDonVi"].ToString()),
                                        MaCachDung = int.Parse(reader["maCachDung"].ToString()),
                                        DonGia = float.Parse(reader["donGia"].ToString())
                                    };

                                    lsThuoc.Add(th);
                                }
                            }
                        }
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                        con.Close();
                        return null;
                    }
                }
            }
            return lsThuoc;
        }

        public List<ThuocDTO> baocaobymonth(string month, string year)
        {
            string query = string.Empty;
            query += "SELECT TH.maThuoc, TH.tenThuoc, TH.maDonVi FROM ToaThuoc T JOIN KeThuoc KT ON T.maToaThuoc=KT.maToaThuoc JOIN Thuoc TH ON KT.maThuoc=TH.maThuoc WHERE MONTH(T.ngayKeToa)=@month and YEAR(T.ngayKeToa)=@year group by TH.maThuoc,TH.tenThuoc,TH.maDonVi";


            List<ThuocDTO> lsThuoc = new List<ThuocDTO>();

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
                                ThuocDTO th = new ThuocDTO();
                                th.MaThuoc = reader["maThuoc"].ToString();
                                th.TenThuoc = reader["tenThuoc"].ToString();
                                th.MaDonVi = int.Parse(reader["maDonVi"].ToString());
                                lsThuoc.Add(th);

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
            return lsThuoc;
        }
       
        
        
    }
}
