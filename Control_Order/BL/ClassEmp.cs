using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Order.DAL;
using System.Data;

namespace Control_Order.BL
{
    class ClassEmp
    {
        public static int AddNewEmp(string emp_user, string emp_pass, string emp_fname, string emp_lname, string Qute_enter, string Order_enter, string Order_control, string Order_management, string Order_view,
string Qute_management, string Qute_view, string emp_enter, string emp_managment, string Change_pass, string Backup_data) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddNewEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_user", SqlDbType.NVarChar, emp_user),
                DataAccessLayer.CreateParameter("@emp_pass", SqlDbType.NVarChar, emp_pass),
                DataAccessLayer.CreateParameter("@emp_fname", SqlDbType.NVarChar, emp_fname),
                DataAccessLayer.CreateParameter("@emp_lname", SqlDbType.NVarChar, emp_lname),
                DataAccessLayer.CreateParameter("@Qute_enter", SqlDbType.NVarChar, Qute_enter),
                DataAccessLayer.CreateParameter("@Order_enter", SqlDbType.NVarChar, Order_enter),
                DataAccessLayer.CreateParameter("@Order_control", SqlDbType.NVarChar, Order_control),
                DataAccessLayer.CreateParameter("@Order_management", SqlDbType.NVarChar, Order_management),
                DataAccessLayer.CreateParameter("@Order_view", SqlDbType.NVarChar, Order_view),
                DataAccessLayer.CreateParameter("@Qute_management", SqlDbType.NVarChar, Qute_management),
                DataAccessLayer.CreateParameter("@Qute_view", SqlDbType.NVarChar, Qute_view),
                DataAccessLayer.CreateParameter("@emp_enter", SqlDbType.NVarChar, emp_enter),
                DataAccessLayer.CreateParameter("@emp_managment", SqlDbType.NVarChar, emp_managment),
                DataAccessLayer.CreateParameter("@Change_pass", SqlDbType.NVarChar, Change_pass),
                DataAccessLayer.CreateParameter("@Backup_data", SqlDbType.NVarChar, Backup_data));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable getusername() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("getusername", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SelectEmpInfo() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectEmpInfo", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchEmpInfo(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchEmpInfo", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search",SqlDbType.NVarChar,search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectOnemp(int emp_id)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOnemp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_id", SqlDbType.Int, emp_id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable empNotExist(int emp_id, string emp_user)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("empNotExist", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_id", SqlDbType.Int, emp_id),
                DataAccessLayer.CreateParameter("@emp_user", SqlDbType.NVarChar, emp_user));
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateEmp(int emp_id,string emp_user, string emp_pass, string emp_fname, string emp_lname, string Qute_enter, string Order_enter, string Order_control, string Order_management, string Order_view,
string Qute_management, string Qute_view, string emp_enter, string emp_managment, string Change_pass, string Backup_data)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_id", SqlDbType.Int, emp_id),
                DataAccessLayer.CreateParameter("@emp_user", SqlDbType.NVarChar, emp_user),
                DataAccessLayer.CreateParameter("@emp_pass", SqlDbType.NVarChar, emp_pass),
                DataAccessLayer.CreateParameter("@emp_fname", SqlDbType.NVarChar, emp_fname),
                DataAccessLayer.CreateParameter("@emp_lname", SqlDbType.NVarChar, emp_lname),
                DataAccessLayer.CreateParameter("@Qute_enter", SqlDbType.NVarChar, Qute_enter),
                DataAccessLayer.CreateParameter("@Order_enter", SqlDbType.NVarChar, Order_enter),
                DataAccessLayer.CreateParameter("@Order_control", SqlDbType.NVarChar, Order_control),
                DataAccessLayer.CreateParameter("@Order_management", SqlDbType.NVarChar, Order_management),
                DataAccessLayer.CreateParameter("@Order_view", SqlDbType.NVarChar, Order_view),
                DataAccessLayer.CreateParameter("@Qute_management", SqlDbType.NVarChar, Qute_management),
                DataAccessLayer.CreateParameter("@Qute_view", SqlDbType.NVarChar, Qute_view),
                DataAccessLayer.CreateParameter("@emp_enter", SqlDbType.NVarChar, emp_enter),
                DataAccessLayer.CreateParameter("@emp_managment", SqlDbType.NVarChar, emp_managment),
                DataAccessLayer.CreateParameter("@Change_pass", SqlDbType.NVarChar, Change_pass),
                DataAccessLayer.CreateParameter("@Backup_data", SqlDbType.NVarChar, Backup_data));
            DataAccessLayer.Close();
            return i;
        }

        public static int DeleteEmp(int emp_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteEmp", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@emp_id", SqlDbType.Int, emp_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
