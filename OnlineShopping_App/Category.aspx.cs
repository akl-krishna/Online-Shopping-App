using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace OnlineShopping_App
{
    public partial class Category : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-Q21IKUJ\SQLEXPRESS;database=PROJECT;Integrated security=true");
        Cat ct = new Cat();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Bind_Gridvew();
            }

        }
        public void Bind_Gridvew()
        {
            DataTable dt = ct.selectCat();
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
            ct.deletecat(uid);
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
            TextBox catdesc = (TextBox)(GridView1.Rows[i].Cells[2].Controls[0]);
            ct.updatecat(uid,catdesc.Text);
            GridView1.EditIndex = -1;
            Bind_Gridvew();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }
    }
}