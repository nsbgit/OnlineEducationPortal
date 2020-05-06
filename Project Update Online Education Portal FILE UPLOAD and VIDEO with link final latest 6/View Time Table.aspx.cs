using System;
using System.Collections.Generic;
using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    SqlCommand cmd;
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack != true)
        {
            getdetails();

        }
    }
    private void getdetails()
    {
        da = new SqlDataAdapter("select * from students", con);
        ds = new DataSet();
        da.Fill(ds, "newemp");
        GridView1.DataSource = ds.Tables["students"];
        GridView1.DataBind();
    }
    protected void LinkButton1_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}