using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    string cs = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string sql = "insert into schedule (weekno,bcode,period,fcode,scode) VALUES (@weekno,@bcode,@period,@fcode,@scode)";
        using (SqlConnection con = new SqlConnection(cs))
        {

            



            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@weekno", TextBox1.Text);
            cmd.Parameters.AddWithValue("@bcode", TextBox2.Text);
            cmd.Parameters.AddWithValue("@period", TextBox3.Text);
            cmd.Parameters.AddWithValue("@fcode", TextBox4.Text);
            cmd.Parameters.AddWithValue("@scode", TextBox5.Text);
           




            con.Open();
            cmd.ExecuteNonQuery();

           
        }
        Response.Redirect("~/View Time Table.aspx");
    }
    protected void LinkButton1_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}