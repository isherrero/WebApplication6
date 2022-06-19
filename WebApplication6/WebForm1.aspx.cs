using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;


namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string ch = @"Data Source = DESKTOP-L2DRSB9\SQL;Initial Catalog = Northwind; User ID = sa; Password=123456";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(ch);
            sc.Open();
            SqlCommand com = new SqlCommand("select * from Products ", sc);
            GridView1.DataSource = com.ExecuteReader();
            GridView1.DataBind();
            com = null;
            sc.Close();
            sc.Open();
            /////// fill  dropdownlist 
            com = new SqlCommand("select * from Categories", sc);
            SqlDataReader dr = com.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Load(dr);
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "CategoryID";
            DropDownList1.DataSource = dataTable;
            DropDownList1.DataBind();


        }

        

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/WebForm2.aspx");
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sc = new SqlConnection(ch);
            sc.Open();
            SqlCommand com = new SqlCommand("select * from Products where CategoryID=" + DropDownList2.SelectedValue, sc);
            GridView1.DataSource = com.ExecuteReader();
            GridView1.DataBind();
            com = null;
            sc.Close();
        }
    }
}