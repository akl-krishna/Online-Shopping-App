using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace OnlineShopping_App
{
    public partial class Product : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-Q21IKUJ\SQLEXPRESS;database=PROJECT;Integrated security=true");
        Prod pd = new Prod();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Gridvew();
            }

        }
        public void Bind_Gridvew()
        {
            DataTable dt = pd.selectProd();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            GridViewRow rw = GridView1.Rows[e.NewSelectedIndex];
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int i = e.RowIndex;
            int uid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            pd.deleteprod(uid);
            Bind_Gridvew();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Bind_Gridvew();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Bind_Gridvew();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int i = e.RowIndex;
            int uid = Convert.ToInt32(GridView1.DataKeys[i].Value);
            TextBox prodprice = (TextBox)(GridView1.Rows[i].Cells[3].Controls[0]);
            pd.updateprod(uid, Convert.ToInt32(prodprice.Text));
            GridView1.EditIndex = -1;
            Bind_Gridvew();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}