using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAO
{
    public class ProductDAO:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice{ get; set; }
        public int UnitsInStock { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
