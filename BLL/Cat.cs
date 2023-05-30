using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL;
using System.Data;
using System.Data.SqlClient;

namespace BLL
{
    public class Cat
    {
        Conclass obj = new Conclass();
        public DataTable selectCat()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_selectcategory";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = obj.Fun_Adapter(cmd).Tables[0];
            return dt;
        }
        public void deletecat(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_deletecategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id",id);
            obj.Fun_NonQuery(cmd);
        }
        public void updatecat(int id, string desc)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_updatecategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@desc", desc);
            obj.Fun_NonQuery(cmd);
        }
        public int insertcat(string name, string desc, string img, string status)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insertcategory";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@na", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@stat", status);

            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@status";
            sp.DbType = DbType.Int32;
            sp.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sp);

            obj.Fun_NonQuery(cmd);
            int res = Convert.ToInt32(sp.Value);
            return res;
        }
        public DataSet selectCatID()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_selectcategoryID";
            cmd.CommandType = CommandType.StoredProcedure;
            DataSet ds = obj.Fun_Adapter(cmd);
            return ds;
        }
    }
}
