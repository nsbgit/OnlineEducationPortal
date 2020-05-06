using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int partascore = 0;
    int partbscore = 0;
    int partcscore = 0;
    int partdscore = 0;
    int total = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }
    protected void bttntob_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void bttnbaka_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void bttntoc_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void bbttobakcc_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 3;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;

    }

    protected void Finish_Click(object sender, EventArgs e)
    {
        Session["a"] = partascore;
        Session["b"] = partbscore;
        Session["c"] = partcscore;
        Session["d"] = partdscore;
        Session["tot"] = total;


        if (a1.Checked)
        {
            partascore = (int)Session["a"] + 1;
            Session["a"] = partascore;

        }
        if (b3.Checked)
        {
            partascore = (int)Session["a"] + 1;
            Session["a"] = partascore;

        }
        if (c4.Checked)
        {
            partascore = (int)Session["a"] + 1;
            Session["a"] = partascore;

        }
        if (d2.Checked)
        {
            partascore = (int)Session["a"] + 1;
            Session["a"] = partascore;

        }

        if (e3.Checked)
        {
            partascore = (int)Session["a"] + 1;
            Session["a"] = partascore;

        }

        Session["a"] = partascore;

        if (f1.Checked)
        {
            partbscore = (int)Session["b"] + 1;
            Session["b"] = partbscore;

        }
        if (g3.Checked)
        {
            partbscore = (int)Session["b"] + 1;
            Session["b"] = partbscore;

        }
        if (h2.Checked)
        {
            partbscore = (int)Session["b"] + 1;
            Session["b"] = partbscore;

        }
        if (i2.Checked)
        {
            partbscore = (int)Session["b"] + 1;
            Session["b"] = partbscore;

        }
        if (j3.Checked)
        {
            partbscore = (int)Session["b"] + 1;
            Session["b"] = partbscore;

        }

        Session["b"] = partbscore;
        if (k1.Checked)
        {
            partcscore = (int)Session["c"] + 1;
            Session["c"] = partcscore;

        }
        if (l2.Checked)
        {
            partcscore = (int)Session["c"] + 1;
            Session["c"] = partcscore;

        }
        if (m2.Checked)
        {
            partcscore = (int)Session["c"] + 1;
            Session["c"] = partcscore;
        }
        if (n2.Checked)
        {
            partcscore = (int)Session["c"] + 1;
            Session["c"] = partcscore;

        }
        if (o1.Checked)
        {
            partcscore = (int)Session["c"] + 1;
            Session["c"] = partcscore;

        }

        Session["c"] = partcscore;
        if (p3.Checked)
        {

            partdscore = (int)Session["d"] + 1;
            Session["d"] = partdscore;

        }
        if (q3.Checked)
        {

            partdscore = (int)Session["d"] + 1;
            Session["d"] = partdscore;
        }
        if (r2.Checked)
        {

            partdscore = (int)Session["d"] + 1;
            Session["d"] = partdscore;
        }
        if (s3.Checked)
        {

            partdscore = (int)Session["d"] + 1;
            Session["d"] = partdscore;
        }
        if (t2.Checked)
        {

            partdscore = (int)Session["d"] + 1;
            Session["d"] = partdscore;
        }


        Session["a"] = partascore;
        Session["b"] = partbscore;
        Session["c"] = partcscore;
        Session["d"] = partdscore;
        Session["tot"] = partascore + partbscore + partcscore + partdscore;
        Response.Redirect("~/Score.aspx");

    }
    protected void Button2_Click1(object sender, EventArgs e)
    {

    }

    protected void Button2_Click2(object sender, EventArgs e)
    {

    }



    protected void timer1_tick(object sender, EventArgs e)
    {

    }


}