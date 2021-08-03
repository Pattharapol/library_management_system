using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Code
{
    public class CommonCode
    {
        public static string GetDesignationID(string designation)
        {
            string sql = string.Format(@"SELECT deg_Id FROM designations WHERE designation = '{0}'", designation);
            return Convert.ToString(DataAccessLayer.Retreiving(sql).Rows[0][0]);
        }

        public static string GetDesignationName(string designationID)
        {
            string sql = string.Format(@"SELECT designation FROM designations WHERE deg_Id = '{0}'", designationID);
            return Convert.ToString(DataAccessLayer.Retreiving(sql).Rows[0][0]);
        }
    }
}