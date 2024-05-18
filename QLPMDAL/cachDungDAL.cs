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
    public class cachDungDAL
    {
        private string connectionString;

        public cachDungDAL()
        {
            connectionString = ConfigurationManager.AppSettings["ConnectionString"];
        }
        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public List<cachdungDTO> getcachdung()
        {
            string query = string.Empty;
            query += "SELECT * FROM CachDung";


            List<cachdungDTO> lscd = new List<cachdungDTO>();

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
                                cachdungDTO cd = new cachdungDTO();
                                cd.TenCachDung = reader["tenCachDung"].ToString();
                                cd.MaCachDung = int.Parse(reader["maCachDung"].ToString());
                                lscd.Add(cd);

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
            return lscd;
        }
    }
}
