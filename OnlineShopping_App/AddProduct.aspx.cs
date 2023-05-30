using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace OnlineShopping_App
{
    public partial class AddProduct : System.Web.UI.Page
    {
        Prod pd = new Prod();
        Cat ct = new Cat();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = ct.selectCatID();
            DropDownList1.DataSource = ds;
            DropDownList1.DataTextField = "cat_name";
            DropDownList1.DataValueField = "cat_id";
            DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            int res = pd.insertprod(TextBox1.Text, Convert.ToInt32(DropDownList1.SelectedItem.Value), Convert.ToInt32(TextBox2.Text), TextBox3.Text, path, Convert.ToInt32(TextBox4.Text));
            if (res == 1)
            {
                Label7.Text = "Product Added Succesfully";
            }
            else
            {
                Label7.Text = "Product Not Added";
            }
        }
    }
}