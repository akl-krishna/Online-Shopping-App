using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DLL;


namespace BLL
{
    public class Log
    {
        Conclass obj = new Conclass();

        public int GetId()
        {
            SqlCommand cmd2 = new SqlCommand();
            cmd2.CommandText = "sp_getloginid";
            cmd2.CommandType = CommandType.StoredProcedure;

            int res = Convert.ToInt32(obj.Fun_Scalar(cmd2));
            return res;
        }
        public int GetCountId(string usr, string pwd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_countid";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usr", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            int res = Convert.ToInt32(obj.Fun_Scalar(cmd));
            return res;
        }

        public int GetIdofUser(string usr, string pwd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_getuserid";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usr", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            int res = Convert.ToInt32(obj.Fun_Scalar(cmd));
            return res;    
        }
        public int CheckAdmin(string usr, string pwd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_checkifadmin";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usr", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            int res = Convert.ToInt32(obj.Fun_Scalar(cmd));
            return res;
        }
    }
}
