using System;
using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "insert into faculty (fname,fcode,dept,pwd,date) VALUES (@fname,@fcode,@dept,@pwd,getdate())";
        using (SqlConnection con = new SqlConnection(cs))
        {

            //string add = "Kolkata";



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@fname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@fcode", TextBox2.Text);
            cmd.Parameters.AddWithValue("@dept", TextBox3.Text);
            cmd.Parameters.AddWithValue("@pwd", TextBox4.Text);
            



            con.Open();
            cmd.ExecuteNonQuery();
        }
        Label1.Text = "Faculty Successfully Registered";
    }
    protected void Button2_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}