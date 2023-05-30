using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using BLL;

namespace OnlineShopping_App
{
    public partial class Login : System.Web.UI.Page
    {
        Log obj = new Log();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int res = obj.GetCountId(TextBox1.Text,TextBox2.Text);
            if(res==1)
            {
                int id = obj.GetIdofUser(TextBox1.Text, TextBox2.Text);
                Session["uid"] = id;
                int ad = obj.CheckAdmin(TextBox1.Text, TextBox2.Text);
                if(ad == 0)
                {
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    Response.Redirect("AdminHome.aspx");
                }

            }
            else
            {
                Label3.Text = "Login Failed";
            }
        }
    }
}