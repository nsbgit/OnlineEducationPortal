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
using System.Data;
using System.Data.SqlClient;

public partial class changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnChange_Click(object sender, EventArgs e)
    {
        string msg = FacultyDAL.ChangePassword(
              Session["fcode"].ToString(),
              txtOldpwd.Text, 
              txtNewpwd.Text);
        if (msg == null)
            lblMsg.Text = "Password Changed Sucessfully!";
        else
            lblMsg.Text = "Error -->" + msg;
    }
}
