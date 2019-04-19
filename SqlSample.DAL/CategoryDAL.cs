using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
  public  class CategoryDAL : IService<CategoryDAO>
    {
        public int Delete(object ID, bool isHardDelete)
        {
            throw new NotImplementedException();
        }

        public int Insert(CategoryDAO insterted)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDAO> Select()
        {
            List<CategoryDAO> categoryList = null;
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "server=.;Database=NORTHWND;uid=sa;pwd=123";
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Categories", conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    categoryList = new List<CategoryDAO>();
                    while (rdr.Read())
                    {
                        categoryList.Add(new CategoryDAO() {
                            CategoryName=rdr["CategoryName"].ToString(),
                            ID=rdr["CategoryID"].ToString()
                        });
                    }

                }


            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }

            return categoryList;

        }

        public CategoryDAO SelectByID(object ID)
        {
            throw new NotImplementedException();
        }

        public int Update(CategoryDAO updated)
        {
            throw new NotImplementedException();
        }
    }
}
