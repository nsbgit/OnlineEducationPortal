using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label2.Text = Session["a"].ToString();
        Label3.Text = Session["b"].ToString();
        Label4.Text = Session["c"].ToString();
        Label5.Text = Session["d"].ToString();
        Label7.Text = Session["tot"].ToString();
        Label8.Text = Session["email"].ToString();
        using (SqlConnection con = new SqlConnection(@" Data Source=.\SQLEXPRESS;Initial Catalog=educationportal;Integrated Security=True"))
        {
            SqlCommand cmd = new SqlCommand("spgetmarks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", Label8.Text);
            cmd.Parameters.AddWithValue("@partAscore", Label2.Text);
            cmd.Parameters.AddWithValue("@partBscore", Label3.Text);
            cmd.Parameters.AddWithValue("@partCscore", Label4.Text);
            cmd.Parameters.AddWithValue("@partDscore", Label5.Text);
            cmd.Parameters.AddWithValue("@Total", Label7.Text);
            con.Open();
            cmd.ExecuteNonQuery();



        }

    }

}