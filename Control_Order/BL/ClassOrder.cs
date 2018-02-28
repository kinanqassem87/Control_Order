using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Order.DAL;
using System.Data;

namespace Control_Order.BL
{
    class ClassOrder
    {
        public static int AddNewOrder(string Order_type, string Order_own, string Order_contact, DateTime Order_date, string Order_note, int Order_state_id, int Qute_id, string Order_emp_creater) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddNewOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_type", SqlDbType.NVarChar, Order_type),
                DataAccessLayer.CreateParameter("@Order_own", SqlDbType.NVarChar, Order_own),
                DataAccessLayer.CreateParameter("@Order_contact", SqlDbType.NVarChar, Order_contact),
                DataAccessLayer.CreateParameter("@Order_date", SqlDbType.DateTime, Order_date),
                DataAccessLayer.CreateParameter("@Order_note", SqlDbType.NVarChar, Order_note),
                DataAccessLayer.CreateParameter("@Order_state_id", SqlDbType.Int, Order_state_id),
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id),
                DataAccessLayer.CreateParameter("@Order_emp_creater", SqlDbType.NVarChar, Order_emp_creater));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectlastOrder() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectlastOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int AddImageOrder(byte[] Order_Image, int Order_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddImageOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_Image", SqlDbType.Image, Order_Image),
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectOrderControl() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOrderControl", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchOrderControl(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchOrderControl", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectImgOrder(int Order_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectAllStateOrder() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllStateOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateStateOrder(int Order_id, int Order_state_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateStateOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id),
                DataAccessLayer.CreateParameter("@Order_state_id", SqlDbType.Int, Order_state_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectOrder()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectOrder", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchOrderAll(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchOrderAll", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int deleteImgForOrder(int Order_img_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteImgForOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_img_id", SqlDbType.Int, Order_img_id));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateOrder(int Order_id, string Order_type, string Order_own, string Order_contact, DateTime Order_date, string Order_note, int Order_state_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id),
                DataAccessLayer.CreateParameter("@Order_type", SqlDbType.NVarChar, Order_type),
                DataAccessLayer.CreateParameter("@Order_own", SqlDbType.NVarChar, Order_own),
                DataAccessLayer.CreateParameter("@Order_contact", SqlDbType.NVarChar, Order_contact),
                DataAccessLayer.CreateParameter("@Order_date", SqlDbType.DateTime, Order_date),
                DataAccessLayer.CreateParameter("@Order_note", SqlDbType.NVarChar, Order_note),
                DataAccessLayer.CreateParameter("@Order_state_id", SqlDbType.Int, Order_state_id));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteImgWithIDOrder(int Order_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteImgWithIDOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectQuteIdwithOrder(int Order_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectQuteIdwithOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id));
            return dt;
        }

        public static int deleteOrder(int Order_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Order_id", SqlDbType.Int, Order_id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
