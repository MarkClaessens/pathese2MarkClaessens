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
    public partial class oke : System.Web.UI.Page
    {
        Zoekers zoeker;
        bool ingelogd = false;
        Database database; 
        protected void Page_Load(object sender, EventArgs e)
        {
            //dit is de home page dus hier haal ik alles uit de database en zet ik film, bioscopen en gebruikers in de database
            if (Session["ingelogd"] == null)
            {
                Session["ingelogd"] = ingelogd;
            }          

            zoeker = new Zoekers();
            database = new Database();
            Session["zoeker"] = zoeker;
            database.loadfilms();
            database.loadbioscopen();
            int moviecount = database.loadgebruikers();
            Session["moviecount"] = moviecount;    
            
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {   
            //als je op de plaatjes klikt ga je naar hun pagina, door de session weet hij welke pagina hij moet laden
            Session["filmnaam"] = "Jurrasic World";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {            
            Session["filmnaam"] = "Spy";
            Response.Redirect("film.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {            
            Session["filmnaam"] = "Minions";
            Response.Redirect("film.aspx");
        }

        protected void Btnzoek_Click(object sender, EventArgs e)
        {
            if(tbfilmnaam.Text != "")
            {
                database.getfilmsnel(tbfilmnaam.Text);
                Btnkoop.Enabled = true;
            }
            
            //hij zoekt na een film die enigzins overeen komt met de textbox text
           
            
        }

        protected void Btnkoop_Click(object sender, EventArgs e)
        {
            //nadat hij een item heeft gevonden kun je voor die film een ticket kopen mits je ingelogd bent
            if(Session["ingelogdaccount"] != null)
            {
                Gebruiker gebruiker = (Gebruiker)Session["ingelogdaccount"];
                database.koopticketsnel(gebruiker);
            }
            else
            {
                Response.Redirect("mypathe.aspx");
            }
            
        }

        
        
    }
}