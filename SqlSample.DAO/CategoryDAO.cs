﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAO
{
   public class CategoryDAO:BaseEntity
    {
        public string CategoryName { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }

    }
}
