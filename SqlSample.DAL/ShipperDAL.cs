using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    public class ShipperDAL
    {
        public List<ShipperDAO> ShipperSelect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Shippers", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (conn.State==System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
              
            }

            return null;
        }


    }
}
