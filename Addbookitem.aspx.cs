using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Library_management
{
    public partial class Bookitem : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String d = "select Cat_id,Cat_name from Bookcat_tab";
                DataSet ds = obj.Fun_exeAdapter(d);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Cat_name";
                DropDownList1.DataValueField = "Cat_id";
                DropDownList1.DataBind();

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string d = DropDownList1.SelectedItem.Value;
            string img = "~/img1/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(img));
            string ins = "insert into Bookitem_tab values('" + d + "','" + TextBox1.Text + "','" + img + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            if (i != 0)
            {
                Label1.Text = "Successfully Inserted";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}
