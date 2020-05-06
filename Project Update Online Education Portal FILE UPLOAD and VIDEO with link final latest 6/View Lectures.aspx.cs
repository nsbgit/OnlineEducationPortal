using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {

       /* if (!IsPostBack)
        {
            BindGrid();
        }*/
    }
    private void BindGrid()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select Id, Name from tblFiles where Subject='" + TextBox1.Text + "' ";
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
            }
        }
       
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BindGrid();
    }
}