using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oim
{
    public partial class Film : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filmnaam = (string)Session["filmnaam"];
            Zoekers zoeker = (Zoekers)Session["zoeker"];
            Labelfilmaam.Text = filmnaam;
            Kijkfilm film = zoeker.getfilm(filmnaam);
            Imagefilm.ImageUrl = film.path;
            Labelgenre.Text = "genre: " + film.GENRE;
            Labelduur.Text = "duur: " + Convert.ToString(film.DUUR) + " min";
            Labelregisseur.Text = "regisseur: " + film.REGISSEUR;
            Labeltaal.Text = "taal: " + film.TAAL;
            
        }
    }
}