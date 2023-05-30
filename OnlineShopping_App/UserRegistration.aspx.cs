using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace OnlineShopping_App
{
    public partial class UserRegistration : System.Web.UI.Page
    {
        UserReg obj = new UserReg();
        Log obj2 = new Log();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int res = obj.CheckUsrExist(TextBox5.Text);
            if(res == 0)
            {
                int uid = obj2.GetId();
                int a = obj.reg(uid+1,TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text,TextBox5.Text,TextBox6.Text);
                if(a == 1)
                {
                    Label8.Text = "User Registered";
                }
                else
                {
                    Label8.Text = "User Registration Failed";
                }
            }
            else 
            {
                Label8.Text = "User already Registered";
            }         
        }
    }
}