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
    public partial class ProductDetails : System.Web.UI.Page
    {
        Prod pd = new Prod();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Session["prodid"]);
            DataTable dt = pd.selectProdId(id);
            Label1.Text = dt.Rows[0].Field<string>("prod_name");
            Label2.Text = dt.Rows[0].Field<int>("prod_price").ToString();
            Label3.Text = dt.Rows[0].Field<string>("prod_desc");
            Label4.Text = dt.Rows[0].Field<long>("stock").ToString();
            Image1.ImageUrl=dt.Rows[0].Field<string>("prod_img");
        }

    }
}