using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication6
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                HttpCookie ht = new HttpCookie("macookies");
                ht["login"] = TextBox1.Text;
                ht["pass"] = TextBox2.Text;
                ht.Expires = DateTime.Now.AddDays(3);
                Response.Cookies.Add(ht);
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
          string c=  Request.Cookies["macookies"]["login"];
            string d = Request.Cookies["macookies"]["pass"];
            Response.Write(d + "-" + c);


        }
    }
}