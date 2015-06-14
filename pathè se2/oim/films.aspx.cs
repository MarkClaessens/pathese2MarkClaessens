using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oim
{
    public partial class films : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Jurrasic World";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Spy";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "Minions";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "divergent";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "kingsmen";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "shaun het schaap";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "rambo";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton8_Click(object sender, ImageClickEventArgs e)
        {
            Session["filmnaam"] = "barry pooter";
            Response.Redirect("film.aspx");
        }
    }
}

      