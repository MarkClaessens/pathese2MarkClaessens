using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oim
{
    public partial class Bioscoopje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // laad de geselecteerde bioscoop in op de pagina
            string filmnaam = (string)Session["bioscoopnaam"];
            Zoekers zoeker = (Zoekers)Session["zoeker"];
            Labelnaam.Text = filmnaam;
            Bioscoop bioscoop = zoeker.getbioscoop(filmnaam);
            Imagebioscoop.ImageUrl = bioscoop.path;
            Labeldesc.Text = bioscoop.description;
        }
    }
}