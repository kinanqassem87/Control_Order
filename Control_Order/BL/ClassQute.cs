using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Control_Order.DAL;
using System.Data;
namespace Control_Order.BL
{
    class ClassQute
    {
        public static int AddNewQute(string Qute_type, string Qute_own, string Qute_contact, DateTime Qute_date, string Qute_note, string Qute_state, string Qute_Emp_Creater) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddNewQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_type", SqlDbType.NVarChar, Qute_type),
                DataAccessLayer.CreateParameter("@Qute_own", SqlDbType.NVarChar, Qute_own),
                DataAccessLayer.CreateParameter("@Qute_contact", SqlDbType.NVarChar, Qute_contact),
                DataAccessLayer.CreateParameter("@Qute_date", SqlDbType.DateTime, Qute_date),
                DataAccessLayer.CreateParameter("@Qute_note", SqlDbType.NVarChar, Qute_note),
                DataAccessLayer.CreateParameter("@Qute_state", SqlDbType.NVarChar, Qute_state),
                DataAccessLayer.CreateParameter("@Qute_Emp_Creater", SqlDbType.NVarChar, Qute_Emp_Creater));
            DataAccessLayer.Close();
            return i;
        }
        public static int AddImgQute(byte[] Qute_img, int Qute_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddImgQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_img", SqlDbType.Image, Qute_img),
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectLastQute() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectLastQute", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectAllQute() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllQute", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectimgforQute(int Qute_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectimgforQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectAllState() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllState", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static int UpdateStatQute(int Qute_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("UpdateStatQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable searchQuteInOrder(string search) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchQuteInOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable selectAllQuteManag() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllQuteManag", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable searchAllQuteManag(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchAllQuteManag", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static int deleteQuteImg(int Qute_img_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteQuteImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_img_id", SqlDbType.Int, Qute_img_id));
            DataAccessLayer.Close();
            return i;
        }

        public static int updateQuteManag(int Qute_id, string Qute_type, string Qute_own, string Qute_contact, DateTime Qute_date, string Qute_note, string Qute_state) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateQuteManag", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id),
                DataAccessLayer.CreateParameter("@Qute_type", SqlDbType.NVarChar, Qute_type),
                DataAccessLayer.CreateParameter("@Qute_own", SqlDbType.NVarChar, Qute_own),
                DataAccessLayer.CreateParameter("@Qute_contact", SqlDbType.NVarChar, Qute_contact),
                DataAccessLayer.CreateParameter("@Qute_date", SqlDbType.Date, Qute_date),
                DataAccessLayer.CreateParameter("@Qute_note", SqlDbType.NVarChar, Qute_note),
                DataAccessLayer.CreateParameter("@Qute_state", SqlDbType.NVarChar, Qute_state));
            DataAccessLayer.Close();
            return i;

        }

        public static int deleteQutewithAllIMG(int Qute_id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteQutewithAllIMG", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return i;
        }

        public static int deleteQute(int Qute_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("deleteQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return i;
        }

        public static int FreeStatQuteOrder(int Qute_id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("FreeStatQuteOrder", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return i;
        }

        public static DataTable selectStateOFQute(int Qute_id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectStateOFQute", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Qute_id", SqlDbType.Int, Qute_id));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
