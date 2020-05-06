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
         string sql = "insert into students (sname,address,emailid,year,stream,bcode,pass,date) VALUES (@sname,@address,@emailid,@year,@stream,@bcode,@pass,getdate())";
        using (SqlConnection con = new SqlConnection(cs))
        {

            //string add = "Kolkata";
            


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@sname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@address", TextBox3.Text);
            cmd.Parameters.AddWithValue("@emailid", TextBox4.Text);
            cmd.Parameters.AddWithValue("@year", TextBox5.Text);
            cmd.Parameters.AddWithValue("@stream", TextBox6.Text);
            cmd.Parameters.AddWithValue("@pass", TextBox7.Text);
            cmd.Parameters.AddWithValue("@bcode", TextBox8.Text);




            con.Open();
            cmd.ExecuteNonQuery();
           
            /*
             if (kp.Equals(txtPass.Text))
             {
                 int p = cmd.ExecuteNonQuery();

                 Response.Write(p);
             }
             else
                 Response.Write("NOT MATCHED");
            */
        }
        Label1.Text = "Student successfully registered";
    }
    protected void Button2_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}
