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
                GetArtistProfile(Convert.ToInt32(Session["admno"].ToString()));
            }
            else
            {
                Response.Redirect("~/Main.aspx");
            }
        }
    }
    private void GetArtistProfile(int id)
    {
        da = new SqlDataAdapter("select sname from students where admno=" + id + " ", con);
        ds = new DataSet();
        da.Fill(ds, "students");
        if (ds.Tables.Count > 0 && ds.Tables["students"].Rows.Count > 0)
        {

            Label1.Text = ds.Tables["students"].Rows[0][0].ToString();
            //Label2.Text = ds.Tables["tblStudent"].Rows[0][1].ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View Lectures.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // Response.Redirect("~/View Lectures.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}