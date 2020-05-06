using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

        if (Page.IsPostBack != true)
        {
            if (Session.Count > 0)
            {
                GetArtistProfile(Convert.ToInt32(Session["id"].ToString()));
            }
            else
            {
                Response.Redirect("~/Main.aspx");
            }
        }
    }
    private void GetArtistProfile(int id)
    {
        da = new SqlDataAdapter("select fname from faculty where id=" + id + " ", con);
        ds = new DataSet();
        da.Fill(ds, "faculty");
        if (ds.Tables.Count > 0 && ds.Tables["faculty"].Rows.Count > 0)
        {
            
            Label1.Text = ds.Tables["faculty"].Rows[0][0].ToString();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Faculty file upload.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/VIDEO UPLOAD.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}