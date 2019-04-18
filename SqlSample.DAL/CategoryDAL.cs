using SqlSample.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL
{
    class CategoryDAL : IService<CategoryDAO>
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
            throw new NotImplementedException();
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
