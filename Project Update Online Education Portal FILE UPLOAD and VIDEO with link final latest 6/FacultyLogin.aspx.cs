﻿using System;
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
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
    SqlDataAdapter da;
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Focus();

        if (con.State == ConnectionState.Closed)
        {
            con.Open();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        da = new SqlDataAdapter("select id from faculty where fcode='" + TextBox1.Text + "' and pwd='" + TextBox2.Text + "' ", con);
        ds = new DataSet();
        da.Fill(ds, "faculty");
        if (ds.Tables["faculty"].Rows.Count > 0 && ds.Tables.Count > 0)
        {
            Session.Add("id", ds.Tables["faculty"].Rows[0][0].ToString());
            Response.Redirect("~/Faculty Controls.aspx");
        }
        else
        {
            Label1.Text = "Username or/and password is not correct";
        }
    }
    protected void Button2_Click(object sender, System.EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}