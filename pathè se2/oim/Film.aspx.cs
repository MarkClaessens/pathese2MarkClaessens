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
        Kijkfilm film;
        protected void Page_Load(object sender, EventArgs e)
        {
            // de film die aangeklikt is wordt door een session doorgegeven en de info wordt op de pagina gezet
            string filmnaam = (string)Session["filmnaam"];
            Zoekers zoeker = (Zoekers)Session["zoeker"];
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
                try
                {
                    using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
                    {

                        int aantalticks = -1; ;
                        con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                        con.Open();
                        DbCommand comm = OracleClientFactory.Instance.CreateCommand();
                        comm.Connection = con;
                        comm.CommandText = "SELECT COUNT(*) from TICKET";
                        DbDataReader reader = comm.ExecuteReader();
                        while (reader.Read())
                        {
                            aantalticks = reader.GetInt32(0) + 1;
                        }
                        DbCommand com = OracleClientFactory.Instance.CreateCommand();
                        com.Connection = con;
                        com.CommandText = "insert into ticket(ticketNR, gebruikerNR, filmNR) values(" + aantalticks + "," + gebruiker.gebruikerNR + "," + film.id + ")";
                        com.ExecuteNonQuery();
                    }
                }
                    catch
                {
                    Button1.Text = "insertfout";
                    Button1.Enabled = false;
                }
                
            }
            else
            {
                Response.Redirect("mypathe.aspx");
            }
        }
    }
}