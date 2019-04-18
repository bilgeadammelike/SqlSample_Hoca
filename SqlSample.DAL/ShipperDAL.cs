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
            List<ShipperDAO> shipperlist=null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Shippers", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    shipperlist = new List<ShipperDAO>();
                    while (rdr.Read())
                    {
                        shipperlist.Add(new ShipperDAO() {
                            CompanyName=rdr["CompanyName"].ToString(),
                            ID=rdr["ShipperID"].ToString(),
                            Phone=rdr["Phone"].ToString()
                        });
                    }

                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                if (conn.State==System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
              
            }

            return shipperlist;
        }

        public int ShipperAdd(ShipperDAO added)
        {
            //validate
            SqlTransaction tran;
            int donendeger = 0;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            conn.Open();
            tran = conn.BeginTransaction();         
            try
            {
                SqlCommand cmd = new SqlCommand(string.Format("insert into Shippers(CompanyName,Phone) values('{0}','{1}')", added.CompanyName, added.Phone), conn);               
                 donendeger = cmd.ExecuteNonQuery();
              //  tran.Commit();
            }
            catch (Exception ex)
            {
               // tran.Rollback();
            }
            conn.Close();
            return donendeger;
        }


    }
}
