using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace oim
{
    
    public partial class mijningelogdepathe : System.Web.UI.Page
    {
        Zoekers zoeker;
        Database database;
        protected void Page_Load(object sender, EventArgs e)
        {
            database = new Database();
            Gebruiker gebruker = (Gebruiker)Session["ingelogdaccount"];
            Lblvoornaam.Text = "voornaam: " + gebruker.voornaam;
            Lblachternaam.Text = "achternaam: " + gebruker.achternaam;
            Lblemail.Text = "e-mail: " + gebruker.email;
            //haalt alle tickets op voor de gebruiker die nu ingelogd is en zet de informatie van de film dmv innerhtml van een div in de site.
            zoeker = (Zoekers)Session["zoeker"];
            List<Kijkfilm> filmsuser = database.haalfilmsop(gebruker);
            foreach(Kijkfilm film in filmsuser)
            {
                      contentdiv.InnerHtml += "naam: " + film.naam + "<br>";
                      contentdiv.InnerHtml += "genre: " + film.GENRE + "<br>";
                      contentdiv.InnerHtml += "duur: " + Convert.ToString(film.DUUR) + " min<br>";
                      contentdiv.InnerHtml += "regisseur: " + film.REGISSEUR + "<br>";
                      contentdiv.InnerHtml += "taal: " + film.TAAL + "<br>";
                      contentdiv.InnerHtml += "_________________________" + "<br>"; 
            }                              
        }

        protected void btnuitlog_Click(object sender, EventArgs e)
        {
            Session["ingelogd"] = false;
            Session["ingelogdaccount"] = null;
            Response.Redirect("mypathe.aspx");
        }
    }
}