using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oim
{
    public partial class mypathe : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //kijkt of er al ingelogd is
            if((bool)Session["ingelogd"] == true)
            {
                Response.Redirect("mijningelogdepathe.aspx");
            }
        }

        protected void Btnlogin_Click(object sender, EventArgs e)
        {
            // logt in met een account dat in de class gebruiker staat.
            try
            {
                Zoekers zoeker = (Zoekers)Session["zoeker"];
                Gebruiker ingelogdegebruiker = zoeker.login(Tbmail.Text, Tbww.Text);
                if (ingelogdegebruiker != null)
                {
                    Session["ingelogdaccount"] = ingelogdegebruiker;
                    Session["ingelogd"] = true;

                    Response.Redirect("mijningelogdepathe.aspx");
                    
                }
                
            }
            catch
            {
             
            }
        }

        
    }
}