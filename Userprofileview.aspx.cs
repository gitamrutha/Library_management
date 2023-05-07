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
    public partial class Userprofileview : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string sel = "select * from Bookitem_tab where Book_id='" + Session["Book_id"] + "'";
            SqlDataReader dr = obj.Fun_exeReader(sel);
            while (dr.Read())
            {
                Label1.Text = dr["Book_name"].ToString();




            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string ins = "insert into Takeitem_tab values('" + TextBox1.Text + "','" + Label1.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            if(i!=0)
            {
                Label2.Text = "Sucessfully Added";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}