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
     public class Prod
    {
        Conclass obj = new Conclass();
        public DataTable selectProd()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_selectproduct";
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = obj.Fun_Adapter(cmd).Tables[0];
            return dt;
        }
        public void deleteprod(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_deleteproduct";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            obj.Fun_NonQuery(cmd);
        }
        public void updateprod(int id, int price)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_updateproduct";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@price", price);
            obj.Fun_NonQuery(cmd);
        }
        public int insertprod(string name, int cat, int price, string desc, string img, int stock)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insertproduct";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@na", name);
            cmd.Parameters.AddWithValue("@cat", cat);
            cmd.Parameters.AddWithValue("@pri", price);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@img", img);
            cmd.Parameters.AddWithValue("@sto", stock);

            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@status";
            sp.DbType = DbType.Int32;
            sp.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sp);

            obj.Fun_NonQuery(cmd);
            int res = Convert.ToInt32(sp.Value);
            return res;
        }
        public DataTable selectProdsofCat(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_selectproductofcat";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = obj.Fun_Adapter(cmd).Tables[0];
            return dt;
        }
        public DataTable selectProdId(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_selectproductid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            DataTable dt = obj.Fun_Adapter(cmd).Tables[0];
            return dt;
        }
    }
}
