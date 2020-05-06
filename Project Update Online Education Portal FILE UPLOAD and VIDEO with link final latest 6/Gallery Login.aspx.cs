using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select admno from students where sname='" + TextBox1.Text + "' and pass='" + TextBox2.Text + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "students");
        if (ds.Tables["students"].Rows.Count > 0 && ds.Tables.Count > 0)
        {
            Session.Add("admno", ds.Tables["students"].Rows[0][0].ToString());
            Response.Redirect("~/Gallery.aspx");
        }
        else
        {
            Label1.Text = "Username or/and password is not correct";
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}