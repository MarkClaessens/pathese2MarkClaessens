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
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //haalt alle tickets op voor de gebruiker die nu ingelogd is en zet de informatie van de film dmv innerhtml van een div in de site.
            zoeker = (Zoekers)Session["zoeker"];
            using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
            {
                Gebruiker gebruker = (Gebruiker)Session["ingelogdaccount"];
                Lblvoornaam.Text = "voornaam: " + gebruker.voornaam;
                Lblachternaam.Text = "achternaam: " + gebruker.achternaam;
                Lblemail.Text ="e-mail: "+ gebruker.email;
                con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                con.Open();
                DbCommand com = OracleClientFactory.Instance.CreateCommand();
                com.Connection = con;
                com.CommandText = "SELECT f.FILMNAAM from TICKET t, FILM f WHERE t.FILMNR = f.FILMNR AND GEBRUIKERNR = "+gebruker.gebruikerNR;
                DbDataReader reader = com.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                      Kijkfilm film = zoeker.getfilm(reader.GetString(0).Trim());
                      contentdiv.InnerHtml += "naam: " + film.naam + "<br>";
                      contentdiv.InnerHtml += "genre: " + film.GENRE + "<br>";
                      contentdiv.InnerHtml += "duur: " + Convert.ToString(film.DUUR) + " min<br>";
                      contentdiv.InnerHtml += "regisseur: " + film.REGISSEUR + "<br>";
                      contentdiv.InnerHtml += "taal: " + film.TAAL + "<br>";
                      contentdiv.InnerHtml += "_________________________" + "<br>"; 
                    }
                }
                catch
                {
                    contentdiv.InnerHtml += "DATABASEFOUT_TF";
                }
                
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