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
    //DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }

    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("delete from faculty where fcode=" + Convert.ToInt32(TextBox1.Text) + " ", con);
        int res = da.SelectCommand.ExecuteNonQuery();
        if (res == 1)
        {
            Response.Redirect("~/Faculty details.aspx");
        }
    }
}