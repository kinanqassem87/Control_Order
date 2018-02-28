using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Order.DAL;
using System.Data;
namespace Control_Order.BL
{
    class ClassUsers
    {
        public static DataTable selectAllEmp()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllEmp", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int changpassword(int emp_id, string emp_pass) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("changpassword", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_id", SqlDbType.Int, emp_id),
                DataAccessLayer.CreateParameter("@emp_pass", SqlDbType.NVarChar, emp_pass));
            return i;
        }
        public static void Back_up(string Path)
        {
            DataAccessLayer.Open();
            string Query = string.Format("Backup Database Control_Order to Disk = '{0}'", Path);
            DataAccessLayer.ExecuteNonQuery(Query, CommandType.Text);
            DataAccessLayer.Close();

        }
    }
}
