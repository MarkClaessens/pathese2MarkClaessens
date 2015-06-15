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
    public partial class registreer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            try
            {
                //maakt met de gegevens die je invoert een account aan in de database
                using (DbConnection con = OracleClientFactory.Instance.CreateConnection())
                {
                    int moviecount = (int)Session["moviecount"];
                    con.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectieStr"].ConnectionString;
                    con.Open();
                    DbCommand com = OracleClientFactory.Instance.CreateCommand();
                    com.Connection = con;
                    if(Page.IsValid)
                    {
                        com.CommandText = "insert into gebruiker values(" + moviecount + ",'" + Tbvoornaam.Text + "','" + Tbachternaam.Text + "','" + Tbgeboortedatum.Text + "','" + Tbgeslacht.Text + "','" + Tbemail.Text + "','" + Tbww.Text + "')";
                        com.ExecuteNonQuery();
                        Zoekers zoeker = (Zoekers)Session["zoeker"];
                        zoeker.addgebruiker(moviecount, Tbvoornaam.Text, Tbachternaam.Text, Tbgeslacht.Text, Tbemail.Text, Tbww.Text);
                        Response.Redirect("mypathe.aspx");
                    }
                    
                }
            }
            catch
            {
                btnconfirm.Enabled = false;
                if(Tbvoornaam.Text == null)
                {
                    Tbvoornaam.Text = "vul in";
                }
                if (Tbachternaam.Text == null)
                {
                    Tbachternaam.Text = "vul in";
                }
                if (Tbgeslacht.Text == null)
                {
                    Tbgeslacht.Text = "vul in";
                }
                if (Tbgeboortedatum.Text == null)
                {
                    Tbgeboortedatum.Text = "vul in";
                }
                if (Tbemail.Text == null)
                {
                    Tbemail.Text = "vul in";
                }
                if (Tbww.Text == null)
                {
                    Tbww.Text = "vul in";
                }
                              
                
            }
        }
    }
}