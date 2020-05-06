using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
    /*    string id, pass;
        id = TextBox2.Text;
        pass = TextBox3.Text;
        if(id.Equals("Admin")&&pass.Equals("1234"))
        {
            Response.Redirect("~/AdminControls.aspx");
        }*/
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        string id, pass;
        id = TextBox1.Text;
        pass = TextBox2.Text;
        if (id.Equals("Admin") && pass.Equals("1234"))
        {
            Response.Redirect("~/AdminControls.aspx");
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Main.aspx");
    }
}