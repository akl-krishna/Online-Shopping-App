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
    public class UserReg
    {
        Conclass obj = new Conclass();

        public int CheckUsrExist(string usr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_chckuser";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@usr", usr);

            int res = Convert.ToInt32(obj.Fun_Scalar(cmd));
            return res;
        }
        public int reg(int uid,string name, string mail, string phn, string addr, string usr, string pwd)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "sp_insertDB";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@na", name);
            cmd.Parameters.AddWithValue("@mail", mail);
            cmd.Parameters.AddWithValue("@phn", Convert.ToInt64(phn));
            cmd.Parameters.AddWithValue("@addr", addr);
            cmd.Parameters.AddWithValue("@usr", usr);
            cmd.Parameters.AddWithValue("@pwd", pwd);

            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@status";
            sp.DbType = DbType.Int32;
            sp.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(sp);

            obj.Fun_NonQuery(cmd);
            int st = Convert.ToInt32(sp.Value);
            return st;
        }
    }
}
