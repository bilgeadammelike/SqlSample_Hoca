using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    public class ProductDAL : IService<ProductDAO>
    {
        public int Delete(object ID, bool isHardDelete)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductDAO insterted)
        {
            throw new NotImplementedException();
        }

        public List<ProductDAO> Select()
        {
            throw new NotImplementedException();
        }

        public ProductDAO SelectByID(object ID)
        {
            throw new NotImplementedException();
        }


        //m.melikememis@gmail.com

        public List<ProductDAO> SelectByID(int ID)
        {
            List<ProductDAO> categoryList = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            SqlCommand cmd = new SqlCommand("select * from Products where CategoryID="+ID,conn);
            //SqlCommand cmd1 = new SqlCommand("select * from Products where CategoryID= @id", conn);
            //cmd1.Parameters.AddWithValue("@id",ID);
            conn.Open();
            SqlDataReader rdr= cmd.ExecuteReader();
            categoryList = new List<ProductDAO>();
            while (rdr.Read())
            {
               
                categoryList.Add(new ProductDAO()
                {
                    ProductName = rdr["ProductName"].ToString(),
                    UnitPrice=Convert.ToDecimal(rdr["UnitPrice"]),
                    UnitsInStock=Convert.ToInt32(rdr["UnitsInStock"])
                });
            }   
           

            return categoryList;
        }
        


        public int Update(ProductDAO updated)
        {
            throw new NotImplementedException();
        }
    }
}
