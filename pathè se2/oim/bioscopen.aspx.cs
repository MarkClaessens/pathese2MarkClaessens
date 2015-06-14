using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;
using System.Web.UI.HtmlControls;

namespace oim
{
    public partial class bioscopen : System.Web.UI.Page
    {
        // pagina met buttons waar je een bioscoop kunt kiezen
        protected void Page_Load(object sender, EventArgs e)
        {
            Zoekers zoeker = (Zoekers)Session["zoeker"];
            
        }

        protected void ButtonArena_Click(object sender, EventArgs e)
        {
            Session["bioscoopnaam"] = "Arena";
            Response.Redirect("bioscoopje.aspx");
        }

        protected void Buttonhelmond_Click(object sender, EventArgs e)
        {
            Session["bioscoopnaam"] = "Helmond";
            Response.Redirect("bioscoopje.aspx");
        }

        protected void Buttonhaarlem_Click(object sender, EventArgs e)
        {
            Session["bioscoopnaam"] = "Haarlem";
            Response.Redirect("bioscoopje.aspx");
        }

        protected void Buttontilburg_Click(object sender, EventArgs e)
        {
            Session["bioscoopnaam"] = "Tilburg";
            Response.Redirect("bioscoopje.aspx");
        }

        protected void Buttoneindhoven_Click(object sender, EventArgs e)
        {
            Session["bioscoopnaam"] = "Eindhoven";
            Response.Redirect("bioscoopje.aspx");
        }
    }
}