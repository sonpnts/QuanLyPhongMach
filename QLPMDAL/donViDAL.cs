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
    public class donViDAL
    {
        private string connectionString;

        public donViDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public List<donViDTO> getdonvi()
        {
            string query = string.Empty;
            query += "SELECT * FROM DonVi";


            List<donViDTO> lsdv = new List<donViDTO>();

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
                                donViDTO dv = new donViDTO();
                                dv.MaDonVi = int.Parse(reader["maDonVi"].ToString());
                                dv.TenDonVi = reader["tenDonVi"].ToString();
                                lsdv.Add(dv);

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
            return lsdv;
        }
    }
}
