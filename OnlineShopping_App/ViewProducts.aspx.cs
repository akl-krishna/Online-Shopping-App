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
    public partial class ViewProducts : System.Web.UI.Page
    {
        Prod pd = new Prod();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_DataListvew();
            }
        }
        public void Bind_DataListvew()
        {   
                int id = Convert.ToInt32(Session["catid"]);
                DataTable dt = pd.selectProdsofCat(id);
                Label4.Text = dt.Rows[0].Field<string>("cat_name");
                DataList1.DataSource = dt;
                DataList1.DataBind();            
        }    

        protected void ImageButton1_Command1(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["prodid"] = id;
            Response.Redirect("ProductDetails.aspx");
        }
    }
}