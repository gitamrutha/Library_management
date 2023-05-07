using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management
{
    public partial class bookcat : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String img = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string ins = "insert into Bookcat_tab values('" + TextBox1.Text + "','" + img + "','" + TextBox2.Text + "','active')";
            int i = obj.Fun_exenonquery(ins);
            if (i != 0)
            {
                Label1.Text = "Inserted successfully";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}