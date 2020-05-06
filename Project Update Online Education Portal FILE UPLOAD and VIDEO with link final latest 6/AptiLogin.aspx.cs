using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Security;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (authenticate(txtuname.Text, txtpaswd.Text))
        {
            FormsAuthentication.RedirectFromLoginPage(txtuname.Text, false);
            Session["email"] = txtuname.Text;
            Response.Redirect("~/Test.aspx");
        }
        else
        {
            Label1.Text = "Username or/and password is not correct";
        }
    }
    private bool authenticate(string emailid, string pass)
    {

        using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=educationportal;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("spauthenticate", con);
            cmd.CommandType = CommandType.StoredProcedure;
           // string Encrypted = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
            SqlParameter paramusername = new SqlParameter("@emailid", emailid);
            SqlParameter parampassword = new SqlParameter("@pass", pass);
            cmd.Parameters.Add(paramusername);
            cmd.Parameters.Add(parampassword);
            con.Open();
            int returncode = (int)cmd.ExecuteScalar();
            return returncode == 1;

        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/StudentReg.aspx");
    }
}