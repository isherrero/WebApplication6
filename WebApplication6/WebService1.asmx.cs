using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace WebApplication6
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public int nbpro()
        {
            string ch = @"Data Source = DESKTOP-L2DRSB9\SQL;Initial Catalog = Northwind; User ID = sa; Password=123456";

            SqlConnection sc = new SqlConnection(ch);
            sc.Open();
            SqlCommand com = new SqlCommand("select count(*)from Products " , sc);
            int a = Convert.ToInt32(com.ExecuteScalar());
            com = null;
            sc.Close();
            sc.Open();
            return a;
        }
    }
}
