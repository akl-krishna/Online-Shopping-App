using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BLL;

namespace OnlineShopping_App
{
    public partial class Home : System.Web.UI.Page
    {
        Cat ct = new Cat();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_DataListvew();
            }
        }
        public void Bind_DataListvew()
        {
            DataTable dt = ct.selectCat();
            DataList1.DataSource = dt;
            DataList1.DataBind();
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["catid"] = id;
            Response.Redirect("ViewProducts.aspx");
        }
    }
}