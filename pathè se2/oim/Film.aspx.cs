using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Common;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace oim
{
    public partial class Film : System.Web.UI.Page
    {
        Database database;
        Kijkfilm film;
        protected void Page_Load(object sender, EventArgs e)
        {
            // de film die aangeklikt is wordt door een session doorgegeven en de info wordt op de pagina gezet
            string filmnaam = (string)Session["filmnaam"];
            Zoekers zoeker = (Zoekers)Session["zoeker"];
            database = new Database();
            Labelfilmaam.Text = filmnaam;
            film = zoeker.getfilm(filmnaam);
            Imagefilm.ImageUrl = film.path;
            Labelgenre.Text = "genre: " + film.GENRE;
            Labelduur.Text = "duur: " + Convert.ToString(film.DUUR) + " min";
            Labelregisseur.Text = "regisseur: " + film.REGISSEUR;
            Labeltaal.Text = "taal: " + film.TAAL;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //als je op de knop drukt dan wordt er voor de film waar je bent een ticket gekocht mits je ingelogt bent anders wordt je naar de inlog geleid
            if (Session["ingelogdaccount"] != null)
            {
                Gebruiker gebruiker = (Gebruiker)Session["ingelogdaccount"];                
                database.koopticketbijfilm(gebruiker, film);               
            }
            else
            {
                Response.Redirect("mypathe.aspx");
            }
        }
    }
}