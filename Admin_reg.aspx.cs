using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_management
{
    public partial class User_reg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sel = "select max(Reg_id) from Log_tab";
            String regid = obj.Fun_exescalar(sel);

            int reg_id = 0;
            if (regid == "")
            {
                reg_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                reg_id = newregid + 1;
            }
            String ins = "insert into Admin_tab values(" + reg_id + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = obj.Fun_exenonquery(ins);
            String inslog = "insert into Log_tab values(" + reg_id + ",'Admin','" + TextBox5.Text + "','" + TextBox6.Text + "','active')";
            int j = obj.Fun_exenonquery(inslog);
            if (i != 0 && j != 0)
            {
                Label1.Text = "Registered";
            }

        }
    }
}