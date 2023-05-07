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
    public partial class Userselection1 : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select Cat_id,Cat_image,Cat_name,Cat_de from Bookcat_tab";
                DataSet ds = obj.Fun_exeAdapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            Session["Cat_id"] = id;
            Response.Redirect("BookDisplay.aspx");
        }
    }
}