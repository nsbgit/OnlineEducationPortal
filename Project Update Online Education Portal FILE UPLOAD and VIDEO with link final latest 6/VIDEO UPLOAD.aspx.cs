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
        if (!IsPostBack)
        {
            BindGrid();
        }
    }
    private void BindGrid()
    {
        string strConnString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        using (SqlConnection con = new SqlConnection(strConnString))
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.CommandText = "select Id, Name from tblFiles";
                cmd.Connection = con;
                con.Open();
                DataList1.DataSource = cmd.ExecuteReader();
                DataList1.DataBind();
                con.Close();
            }
        }
    }
    protected void btnUpload_Click(object sender, EventArgs e)
    {
        using (BinaryReader br = new BinaryReader(FileUpload1.PostedFile.InputStream))
        {
            byte[] bytes = br.ReadBytes((int)FileUpload1.PostedFile.InputStream.Length);
            string strConnString = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
            using (SqlConnection con = new SqlConnection(strConnString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "insert into tblFiles(Name, ContentType, Data,Subject) values (@Name, @ContentType, @Data,@Subject)";
                    cmd.Parameters.AddWithValue("@Name", Path.GetFileName(FileUpload1.PostedFile.FileName));
                    cmd.Parameters.AddWithValue("@ContentType", "video/mp4");
                    cmd.Parameters.AddWithValue("@Data", bytes);
                    cmd.Parameters.AddWithValue("@Subject", TextBox1.Text);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        Response.Redirect(Request.Url.AbsoluteUri);
    }

    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void DataList1_SelectedIndexChanged1(object sender, System.EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}