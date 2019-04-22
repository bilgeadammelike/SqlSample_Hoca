using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlSample.DAL.Common
{
    public class Provider
    {
        SqlConnection conn = null;
        SqlCommand cmd = null;
        public object Value{ get; set; }
        public Provider(string cmdText,CmdTypeEnum enumtype, string conntext = "server=.;Database=NORTHWND;uid=sa;pwd=123")
        {
            conn = new SqlConnection();
            conn.ConnectionString = conntext;
            cmd = new SqlCommand(cmdText, conn);

            //işlemler
            //  Value = "";     
            switch (enumtype)
            {
                case CmdTypeEnum.insert:
                    break;
                case CmdTypeEnum.update:
                    break;
                case CmdTypeEnum.delete:
                    break;
                case CmdTypeEnum.select:
                    break;
                case CmdTypeEnum.selectObject:
                    break;
                default:
                    break;
            }


        }

        public int ExecuteNonQuery()
        {
            conn.Open();
           return  cmd.ExecuteNonQuery();            
        }



    }
}
