using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace OnlineShopping_App
{
    public partial class CreateCategory : System.Web.UI.Page
    {
        Cat ct = new Cat();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/PHS/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));
            int res = ct.insertcat(TextBox1.Text, TextBox2.Text, path, DropDownList1.SelectedItem.Value);
            if(res==1)
            {
                Label5.Text = "Category Added Succesfully";
                Response.Redirect("Category.aspx");
            }
            else
            {
                Label5 .Text = "Category Not Added";
            }
        }
    }
}